﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

// By TimeTravelPenguin

namespace SpeedkickOptimiser
{
    public partial class frm_Main : Form
    {

        // This application will calculate angles to be used for a "speedkick" technique
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

            int x = (int)numStickX.Value;
            int y = (int)numStickY.Value;
            double deltaAngle = (double)numAngle.Value * (Math.PI / 180); // convert to radians

            dataGrid_StickOutput.Rows.Clear();
            Speedkick(x, y, deltaAngle);

            btn_Calculate.Enabled = true;
        }

        /// <summary>
        /// Calculates speedkick coordinates
        /// </summary>
        /// <param name="rawstickX">The X coordinate on the TAS Tool</param>
        /// <param name="rawstickY">The Y coordinate on the TAS Tool</param>
        /// <param name="deltaAngle">The off-axis angle in degrees to check for speedkick coordinates</param>
        private void Speedkick(int rawStickX, int rawStickY, double deltaAngle)
        {
            // update labels
            Controller inputController = new Controller(rawStickX, rawStickY);
            lbl_Magnitude.Text = $"{inputController.stickMag}";
            lbl_Angle.Text = $"{(float)(inputController.stickAngle * (180 / Math.PI))}";

            double angle = inputController.stickAngle;

            double maxAngle = angle + deltaAngle;
            double minAngle = angle - deltaAngle;

            // do max coords for new angle
            double r = 48; // max speedkick magnitude

            int maxX = (int)Math.Ceiling(r * Math.Cos(maxAngle) - 6);
            int minX = (int)Math.Ceiling(r * Math.Cos(minAngle) + 6);

            int maxY = (int)Math.Ceiling(r * Math.Sin(maxAngle) + 6);
            int minY = (int)Math.Ceiling(r * Math.Sin(minAngle) - 6);

            // find max Mag
            List<Controller> controllerList = new List<Controller>();

            // the minimum and maximum angle bounds
            var maxTangent = Math.Atan2(maxY, maxX);
            var minTangent = Math.Atan2(minY, minX);

            // list all angles in range
            for (int x = 0; x <= minX; x++)
                for (int y = 0; y <= maxY; y++)
                {
                    var theta = Math.Atan2(y, x);

                    if (theta >= minTangent && theta <= maxTangent) // if (x, y) is in regioned angle bounds
                    {
                        var c = new Controller(x, y);
                        if (c.stickMag <= r)
                            controllerList.Add(c);
                    }
                }

            List<Controller> SortedMagList = controllerList.OrderByDescending(o => o.stickMag).ToList();

            // put data in datagrid
            foreach (var item in SortedMagList)
                dataGrid_StickOutput.Rows.Add(new object[] { item.rawStickX, item.rawStickY, (float)(item.stickAngle * (180 / Math.PI)), (float)((item.stickAngle - inputController.stickAngle) * (180 / Math.PI)), (float)item.stickMag });

            // sort datagrid
            dataGrid_StickOutput.Sort(dataGrid_StickOutput.Columns["stickMag"], ListSortDirection.Descending);

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
