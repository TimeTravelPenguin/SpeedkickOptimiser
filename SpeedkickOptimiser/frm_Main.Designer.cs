namespace SpeedkickOptimiser
{
    partial class frm_Main
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Main));
            this.numStickY = new System.Windows.Forms.NumericUpDown();
            this.numStickX = new System.Windows.Forms.NumericUpDown();
            this.lblX = new System.Windows.Forms.Label();
            this.lblY = new System.Windows.Forms.Label();
            this.btn_Calculate = new System.Windows.Forms.Button();
            this.lblA = new System.Windows.Forms.Label();
            this.numAngle = new System.Windows.Forms.NumericUpDown();
            this.dataGrid_StickOutput = new System.Windows.Forms.DataGridView();
            this.lblM = new System.Windows.Forms.Label();
            this.lbl_Magnitude = new System.Windows.Forms.Label();
            this.lblA2 = new System.Windows.Forms.Label();
            this.lbl_Angle = new System.Windows.Forms.Label();
            this.groupBox_SelectedInformation = new System.Windows.Forms.GroupBox();
            this.lblSelectedDelta = new System.Windows.Forms.Label();
            this.lblSelectedAngle = new System.Windows.Forms.Label();
            this.lblSelected_Delta = new System.Windows.Forms.Label();
            this.lblSelected_Angle = new System.Windows.Forms.Label();
            this.lblSelected_Mag = new System.Windows.Forms.Label();
            this.lblSelectedMag = new System.Windows.Forms.Label();
            this.stickX = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stickY = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stickAngle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stickAngleDelta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stickMag = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.numStickY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numStickX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numAngle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid_StickOutput)).BeginInit();
            this.groupBox_SelectedInformation.SuspendLayout();
            this.SuspendLayout();
            // 
            // numStickY
            // 
            this.numStickY.Location = new System.Drawing.Point(85, 35);
            this.numStickY.Maximum = new decimal(new int[] {
            128,
            0,
            0,
            0});
            this.numStickY.Name = "numStickY";
            this.numStickY.Size = new System.Drawing.Size(155, 20);
            this.numStickY.TabIndex = 2;
            // 
            // numStickX
            // 
            this.numStickX.Location = new System.Drawing.Point(85, 9);
            this.numStickX.Maximum = new decimal(new int[] {
            128,
            0,
            0,
            0});
            this.numStickX.Name = "numStickX";
            this.numStickX.Size = new System.Drawing.Size(155, 20);
            this.numStickX.TabIndex = 1;
            // 
            // lblX
            // 
            this.lblX.AutoSize = true;
            this.lblX.Location = new System.Drawing.Point(9, 11);
            this.lblX.Name = "lblX";
            this.lblX.Size = new System.Drawing.Size(44, 13);
            this.lblX.TabIndex = 6;
            this.lblX.Text = "Stick X:";
            // 
            // lblY
            // 
            this.lblY.AutoSize = true;
            this.lblY.Location = new System.Drawing.Point(9, 37);
            this.lblY.Name = "lblY";
            this.lblY.Size = new System.Drawing.Size(44, 13);
            this.lblY.TabIndex = 7;
            this.lblY.Text = "Stick Y:";
            // 
            // btn_Calculate
            // 
            this.btn_Calculate.Location = new System.Drawing.Point(12, 87);
            this.btn_Calculate.Name = "btn_Calculate";
            this.btn_Calculate.Size = new System.Drawing.Size(228, 23);
            this.btn_Calculate.TabIndex = 4;
            this.btn_Calculate.Text = "Calculate";
            this.btn_Calculate.UseVisualStyleBackColor = true;
            this.btn_Calculate.Click += new System.EventHandler(this.btn_Calculate_Click);
            // 
            // lblA
            // 
            this.lblA.AutoSize = true;
            this.lblA.Location = new System.Drawing.Point(9, 63);
            this.lblA.Name = "lblA";
            this.lblA.Size = new System.Drawing.Size(60, 13);
            this.lblA.TabIndex = 0;
            this.lblA.Text = "Deg Angle:";
            // 
            // numAngle
            // 
            this.numAngle.Location = new System.Drawing.Point(85, 61);
            this.numAngle.Maximum = new decimal(new int[] {
            90,
            0,
            0,
            0});
            this.numAngle.Name = "numAngle";
            this.numAngle.Size = new System.Drawing.Size(155, 20);
            this.numAngle.TabIndex = 3;
            this.numAngle.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // dataGrid_StickOutput
            // 
            this.dataGrid_StickOutput.AllowUserToAddRows = false;
            this.dataGrid_StickOutput.AllowUserToDeleteRows = false;
            this.dataGrid_StickOutput.AllowUserToResizeRows = false;
            this.dataGrid_StickOutput.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGrid_StickOutput.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.stickX,
            this.stickY,
            this.stickAngle,
            this.stickAngleDelta,
            this.stickMag});
            this.dataGrid_StickOutput.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGrid_StickOutput.Location = new System.Drawing.Point(0, 116);
            this.dataGrid_StickOutput.Name = "dataGrid_StickOutput";
            this.dataGrid_StickOutput.ReadOnly = true;
            this.dataGrid_StickOutput.RowHeadersVisible = false;
            this.dataGrid_StickOutput.RowHeadersWidth = 50;
            this.dataGrid_StickOutput.RowTemplate.ReadOnly = true;
            this.dataGrid_StickOutput.Size = new System.Drawing.Size(485, 162);
            this.dataGrid_StickOutput.TabIndex = 5;
            this.dataGrid_StickOutput.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGrid_StickOutput_CellClick);
            // 
            // lblM
            // 
            this.lblM.AutoSize = true;
            this.lblM.Location = new System.Drawing.Point(252, 9);
            this.lblM.Name = "lblM";
            this.lblM.Size = new System.Drawing.Size(68, 13);
            this.lblM.TabIndex = 8;
            this.lblM.Text = "Current Mag:";
            // 
            // lbl_Magnitude
            // 
            this.lbl_Magnitude.AutoSize = true;
            this.lbl_Magnitude.Location = new System.Drawing.Point(345, 9);
            this.lbl_Magnitude.Name = "lbl_Magnitude";
            this.lbl_Magnitude.Size = new System.Drawing.Size(13, 13);
            this.lbl_Magnitude.TabIndex = 8;
            this.lbl_Magnitude.Text = "0";
            // 
            // lblA2
            // 
            this.lblA2.AutoSize = true;
            this.lblA2.Location = new System.Drawing.Point(252, 26);
            this.lblA2.Name = "lblA2";
            this.lblA2.Size = new System.Drawing.Size(76, 13);
            this.lblA2.TabIndex = 8;
            this.lblA2.Text = "Current Deg θ:";
            // 
            // lbl_Angle
            // 
            this.lbl_Angle.AutoSize = true;
            this.lbl_Angle.Location = new System.Drawing.Point(345, 26);
            this.lbl_Angle.Name = "lbl_Angle";
            this.lbl_Angle.Size = new System.Drawing.Size(13, 13);
            this.lbl_Angle.TabIndex = 8;
            this.lbl_Angle.Text = "0";
            // 
            // groupBox_SelectedInformation
            // 
            this.groupBox_SelectedInformation.Controls.Add(this.lblSelectedDelta);
            this.groupBox_SelectedInformation.Controls.Add(this.lblSelectedAngle);
            this.groupBox_SelectedInformation.Controls.Add(this.lblSelected_Delta);
            this.groupBox_SelectedInformation.Controls.Add(this.lblSelected_Angle);
            this.groupBox_SelectedInformation.Controls.Add(this.lblSelected_Mag);
            this.groupBox_SelectedInformation.Controls.Add(this.lblSelectedMag);
            this.groupBox_SelectedInformation.Location = new System.Drawing.Point(246, 42);
            this.groupBox_SelectedInformation.Name = "groupBox_SelectedInformation";
            this.groupBox_SelectedInformation.Size = new System.Drawing.Size(227, 68);
            this.groupBox_SelectedInformation.TabIndex = 9;
            this.groupBox_SelectedInformation.TabStop = false;
            this.groupBox_SelectedInformation.Text = "Selected Information";
            // 
            // lblSelectedDelta
            // 
            this.lblSelectedDelta.AutoSize = true;
            this.lblSelectedDelta.Location = new System.Drawing.Point(6, 50);
            this.lblSelectedDelta.Name = "lblSelectedDelta";
            this.lblSelectedDelta.Size = new System.Drawing.Size(23, 13);
            this.lblSelectedDelta.TabIndex = 8;
            this.lblSelectedDelta.Text = "Δθ:";
            // 
            // lblSelectedAngle
            // 
            this.lblSelectedAngle.AutoSize = true;
            this.lblSelectedAngle.Location = new System.Drawing.Point(6, 33);
            this.lblSelectedAngle.Name = "lblSelectedAngle";
            this.lblSelectedAngle.Size = new System.Drawing.Size(84, 13);
            this.lblSelectedAngle.TabIndex = 8;
            this.lblSelectedAngle.Text = "Selected Deg θ:";
            // 
            // lblSelected_Delta
            // 
            this.lblSelected_Delta.AutoSize = true;
            this.lblSelected_Delta.Location = new System.Drawing.Point(99, 50);
            this.lblSelected_Delta.Name = "lblSelected_Delta";
            this.lblSelected_Delta.Size = new System.Drawing.Size(13, 13);
            this.lblSelected_Delta.TabIndex = 8;
            this.lblSelected_Delta.Text = "0";
            // 
            // lblSelected_Angle
            // 
            this.lblSelected_Angle.AutoSize = true;
            this.lblSelected_Angle.Location = new System.Drawing.Point(99, 33);
            this.lblSelected_Angle.Name = "lblSelected_Angle";
            this.lblSelected_Angle.Size = new System.Drawing.Size(13, 13);
            this.lblSelected_Angle.TabIndex = 8;
            this.lblSelected_Angle.Text = "0";
            // 
            // lblSelected_Mag
            // 
            this.lblSelected_Mag.AutoSize = true;
            this.lblSelected_Mag.Location = new System.Drawing.Point(99, 16);
            this.lblSelected_Mag.Name = "lblSelected_Mag";
            this.lblSelected_Mag.Size = new System.Drawing.Size(13, 13);
            this.lblSelected_Mag.TabIndex = 8;
            this.lblSelected_Mag.Text = "0";
            // 
            // lblSelectedMag
            // 
            this.lblSelectedMag.AutoSize = true;
            this.lblSelectedMag.Location = new System.Drawing.Point(6, 16);
            this.lblSelectedMag.Name = "lblSelectedMag";
            this.lblSelectedMag.Size = new System.Drawing.Size(76, 13);
            this.lblSelectedMag.TabIndex = 8;
            this.lblSelectedMag.Text = "Selected Mag:";
            // 
            // stickX
            // 
            this.stickX.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.stickX.HeaderText = "Raw Stick X";
            this.stickX.Name = "stickX";
            this.stickX.ReadOnly = true;
            this.stickX.ToolTipText = "The X value needed to be used in the TAS Tool";
            // 
            // stickY
            // 
            this.stickY.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.stickY.HeaderText = "Raw Stick Y";
            this.stickY.Name = "stickY";
            this.stickY.ReadOnly = true;
            this.stickY.ToolTipText = "The Y value needed to be used in the TAS Tool";
            // 
            // stickAngle
            // 
            this.stickAngle.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.stickAngle.HeaderText = "Deg θ";
            this.stickAngle.Name = "stickAngle";
            this.stickAngle.ReadOnly = true;
            this.stickAngle.ToolTipText = "The angle made by the processed inputs, post game logic";
            // 
            // stickAngleDelta
            // 
            this.stickAngleDelta.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.stickAngleDelta.HeaderText = "Δθ";
            this.stickAngleDelta.Name = "stickAngleDelta";
            this.stickAngleDelta.ReadOnly = true;
            this.stickAngleDelta.ToolTipText = "The angle amount that this point strays from the original input angle";
            // 
            // stickMag
            // 
            this.stickMag.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.stickMag.HeaderText = "Stick Mag";
            this.stickMag.Name = "stickMag";
            this.stickMag.ReadOnly = true;
            this.stickMag.ToolTipText = "The magnitude of the point. To speedkick, you need 48 or less.";
            // 
            // frm_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(485, 278);
            this.Controls.Add(this.dataGrid_StickOutput);
            this.Controls.Add(this.groupBox_SelectedInformation);
            this.Controls.Add(this.lbl_Angle);
            this.Controls.Add(this.lblA2);
            this.Controls.Add(this.lbl_Magnitude);
            this.Controls.Add(this.lblM);
            this.Controls.Add(this.numAngle);
            this.Controls.Add(this.lblA);
            this.Controls.Add(this.btn_Calculate);
            this.Controls.Add(this.lblY);
            this.Controls.Add(this.lblX);
            this.Controls.Add(this.numStickX);
            this.Controls.Add(this.numStickY);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_Main";
            this.Text = "Speedkick Optimizer";
            ((System.ComponentModel.ISupportInitialize)(this.numStickY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numStickX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numAngle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid_StickOutput)).EndInit();
            this.groupBox_SelectedInformation.ResumeLayout(false);
            this.groupBox_SelectedInformation.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown numStickY;
        private System.Windows.Forms.NumericUpDown numStickX;
        private System.Windows.Forms.Label lblX;
        private System.Windows.Forms.Label lblY;
        private System.Windows.Forms.Button btn_Calculate;
        private System.Windows.Forms.Label lblA;
        private System.Windows.Forms.NumericUpDown numAngle;
        private System.Windows.Forms.DataGridView dataGrid_StickOutput;
        private System.Windows.Forms.Label lblM;
        private System.Windows.Forms.Label lbl_Magnitude;
        private System.Windows.Forms.Label lblA2;
        private System.Windows.Forms.Label lbl_Angle;
        private System.Windows.Forms.GroupBox groupBox_SelectedInformation;
        private System.Windows.Forms.Label lblSelectedDelta;
        private System.Windows.Forms.Label lblSelectedAngle;
        private System.Windows.Forms.Label lblSelected_Delta;
        private System.Windows.Forms.Label lblSelectedMag;
        private System.Windows.Forms.Label lblSelected_Angle;
        private System.Windows.Forms.Label lblSelected_Mag;
        private System.Windows.Forms.DataGridViewTextBoxColumn stickX;
        private System.Windows.Forms.DataGridViewTextBoxColumn stickY;
        private System.Windows.Forms.DataGridViewTextBoxColumn stickAngle;
        private System.Windows.Forms.DataGridViewTextBoxColumn stickAngleDelta;
        private System.Windows.Forms.DataGridViewTextBoxColumn stickMag;
    }
}

