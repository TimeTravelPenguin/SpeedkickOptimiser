#region Title Header

// Name: Phillip Smith
// 
// Solution: SpeedkickOptimiser
// Project: SpeedkickOptimiser
// File Name: frm_Main.cs
// 
// Current Data:
// 2019-08-03 10:14 PM
// 
// Creation Date:
// 2019-01-20 11:17 AM

#endregion

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Windows.Forms;

// By TimeTravelPenguin

namespace SpeedkickOptimiser
{
    public partial class frm_Main : Form
    {
        // This application will calculate angles to be used for a "speed-kick" technique
        // specific to Super Mario 64 Tool-Assisted Speedrunning.
        // It is important to note that this logic works by taking RAW Data, being the analogue
        // stick's X and Y positions, and converting it to a precessed coordinate system used by
        // the game code's logic. I don't know why the game devs did what they did. I am just the
        // monkey who made this program based off their code.

        public frm_Main()
        {
            InitializeComponent();
        }

        private void btn_Calculate_Click(object sender, EventArgs e)
        {
            btn_Calculate.Enabled = false;

            var x = (int) numStickX.Value;
            var y = (int) numStickY.Value;
            var deltaAngle = (double) numAngle.Value * (Math.PI / 180); // convert to radians

            dataGrid_StickOutput.Rows.Clear();
            Speedkick(x, y, deltaAngle);

            btn_Calculate.Enabled = true;
        }

        /// <summary>
        ///     Calculates speed-kick coordinates
        /// </summary>
        /// <param name="rawStickX">The X coordinate on the TAS Tool</param>
        /// <param name="rawStickY">The Y coordinate on the TAS Tool</param>
        /// <param name="deltaAngle">The off-axis angle in degrees to check for speed-kick coordinates</param>
        private void Speedkick(int rawStickX, int rawStickY, double deltaAngle)
        {
            // update labels
            var inputController = new Controller(rawStickX, rawStickY);
            lbl_Magnitude.Text = $"{inputController.stickMag}";
            lbl_Angle.Text = $"{(float) (inputController.stickAngle * (180 / Math.PI))}";

            var angle = inputController.stickAngle;

            var maxAngle = angle + deltaAngle;
            var minAngle = angle - deltaAngle;

            // do max coords for new angle
            const double r = 48; // max speed-kick magnitude

            var maxX = (int) Math.Ceiling(r * Math.Cos(maxAngle) - 6);
            var minX = (int) Math.Ceiling(r * Math.Cos(minAngle) + 6);

            var maxY = (int) Math.Ceiling(r * Math.Sin(maxAngle) + 6);
            var minY = (int) Math.Ceiling(r * Math.Sin(minAngle) - 6);

            // find max Mag
            var controllerList = new List<Controller>();

            // the minimum and maximum angle bounds
            var maxTangent = Math.Atan2(maxY, maxX);
            var minTangent = Math.Atan2(minY, minX);

            // list all angles in range
            for (var x = 0; x <= minX; x++)
            {
                for (var y = 0; y <= maxY; y++)
                {
                    var theta = Math.Atan2(y, x);

                    if (theta >= minTangent && theta <= maxTangent) // if (x, y) is in angle bounds
                    {
                        var c = new Controller(x, y);
                        if (c.stickMag <= r)
                        {
                            controllerList.Add(c);
                        }
                    }
                }
            }

            var sortedMagList = controllerList.OrderByDescending(o => o.stickMag);

            // put data in data-grid
            foreach (var item in sortedMagList)
            {
                dataGrid_StickOutput.Rows.Add(item.rawStickX, item.rawStickY,
                    (float) (item.stickAngle * (180 / Math.PI)),
                    (float) ((item.stickAngle - inputController.stickAngle) * (180 / Math.PI)), item.stickMag);
            }

            // sort data-grid
            dataGrid_StickOutput.Sort(dataGrid_StickOutput.Columns["stickMag"] ?? throw new InvalidOperationException(),
                ListSortDirection.Descending);
        }


        private void dataGrid_StickOutput_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var row = e.RowIndex;
            if (row >= 0)
            {
                lblSelected_Mag.Text = dataGrid_StickOutput.Rows[row].Cells["stickMag"].Value.ToString();
                lblSelected_Angle.Text = dataGrid_StickOutput.Rows[row].Cells["stickAngle"].Value.ToString();
                lblSelected_Delta.Text = dataGrid_StickOutput.Rows[row].Cells["stickAngleDelta"].Value.ToString();
            }
        }
    }
}