namespace Max2Babylon
{
    partial class CameraPropertiesForm
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ellipsoidControl = new Max2Babylon.Vector3Control();
            this.label3 = new System.Windows.Forms.Label();
            this.chkGravity = new System.Windows.Forms.CheckBox();
            this.chkCollisions = new System.Windows.Forms.CheckBox();
            this.butOK = new System.Windows.Forms.Button();
            this.butCancel = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.nupInertia = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.nupSpeed = new System.Windows.Forms.NumericUpDown();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.grpAutoAnimate = new System.Windows.Forms.GroupBox();
            this.chkLoop = new System.Windows.Forms.CheckBox();
            this.nupTo = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.nupFrom = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.chkAutoAnimate = new System.Windows.Forms.CheckBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.tagInput = new System.Windows.Forms.TextBox();
            this.tagLabel = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cbCameraType = new System.Windows.Forms.ComboBox();
            this.chkNoExport = new System.Windows.Forms.CheckBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nupInertia)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nupSpeed)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.grpAutoAnimate.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nupTo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nupFrom)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.ellipsoidControl);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.chkGravity);
            this.groupBox1.Controls.Add(this.chkCollisions);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox1.Location = new System.Drawing.Point(12, 110);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(319, 127);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Collisions";
            // 
            // ellipsoidControl
            // 
            this.ellipsoidControl.Location = new System.Drawing.Point(21, 88);
            this.ellipsoidControl.Name = "ellipsoidControl";
            this.ellipsoidControl.Size = new System.Drawing.Size(294, 26);
            this.ellipsoidControl.TabIndex = 14;
            this.ellipsoidControl.X = 0F;
            this.ellipsoidControl.Y = 0F;
            this.ellipsoidControl.Z = 0F;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 73);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 12);
            this.label3.TabIndex = 13;
            this.label3.Text = "Ellipsoid:";
            // 
            // chkGravity
            // 
            this.chkGravity.AutoSize = true;
            this.chkGravity.Location = new System.Drawing.Point(21, 47);
            this.chkGravity.Name = "chkGravity";
            this.chkGravity.Size = new System.Drawing.Size(102, 16);
            this.chkGravity.TabIndex = 12;
            this.chkGravity.Text = "Apply gravity";
            this.chkGravity.ThreeState = true;
            this.chkGravity.UseVisualStyleBackColor = true;
            // 
            // chkCollisions
            // 
            this.chkCollisions.AutoSize = true;
            this.chkCollisions.Location = new System.Drawing.Point(21, 26);
            this.chkCollisions.Name = "chkCollisions";
            this.chkCollisions.Size = new System.Drawing.Size(120, 16);
            this.chkCollisions.TabIndex = 11;
            this.chkCollisions.Text = "Check collisions";
            this.chkCollisions.ThreeState = true;
            this.chkCollisions.UseVisualStyleBackColor = true;
            // 
            // butOK
            // 
            this.butOK.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.butOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.butOK.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.butOK.Location = new System.Drawing.Point(93, 534);
            this.butOK.Name = "butOK";
            this.butOK.Size = new System.Drawing.Size(75, 21);
            this.butOK.TabIndex = 100;
            this.butOK.Text = "OK";
            this.butOK.UseVisualStyleBackColor = true;
            this.butOK.Click += new System.EventHandler(this.butOK_Click);
            // 
            // butCancel
            // 
            this.butCancel.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.butCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.butCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.butCancel.Location = new System.Drawing.Point(174, 534);
            this.butCancel.Name = "butCancel";
            this.butCancel.Size = new System.Drawing.Size(75, 21);
            this.butCancel.TabIndex = 101;
            this.butCancel.Text = "Cancel";
            this.butCancel.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.nupInertia);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.nupSpeed);
            this.groupBox2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox2.Location = new System.Drawing.Point(12, 243);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(319, 129);
            this.groupBox2.TabIndex = 20;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Control";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 12);
            this.label2.TabIndex = 23;
            this.label2.Text = "Inertia";
            // 
            // nupInertia
            // 
            this.nupInertia.DecimalPlaces = 2;
            this.nupInertia.Location = new System.Drawing.Point(24, 95);
            this.nupInertia.Name = "nupInertia";
            this.nupInertia.Size = new System.Drawing.Size(120, 21);
            this.nupInertia.TabIndex = 24;
            this.nupInertia.Value = new decimal(new int[] {
            9,
            0,
            0,
            65536});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 21;
            this.label1.Text = "Speed:";
            // 
            // nupSpeed
            // 
            this.nupSpeed.DecimalPlaces = 1;
            this.nupSpeed.Location = new System.Drawing.Point(24, 46);
            this.nupSpeed.Name = "nupSpeed";
            this.nupSpeed.Size = new System.Drawing.Size(120, 21);
            this.nupSpeed.TabIndex = 22;
            this.nupSpeed.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.grpAutoAnimate);
            this.groupBox3.Controls.Add(this.chkAutoAnimate);
            this.groupBox3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox3.Location = new System.Drawing.Point(12, 378);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(319, 144);
            this.groupBox3.TabIndex = 30;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Animations";
            // 
            // grpAutoAnimate
            // 
            this.grpAutoAnimate.Controls.Add(this.chkLoop);
            this.grpAutoAnimate.Controls.Add(this.nupTo);
            this.grpAutoAnimate.Controls.Add(this.label4);
            this.grpAutoAnimate.Controls.Add(this.nupFrom);
            this.grpAutoAnimate.Controls.Add(this.label5);
            this.grpAutoAnimate.Enabled = false;
            this.grpAutoAnimate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.grpAutoAnimate.Location = new System.Drawing.Point(21, 47);
            this.grpAutoAnimate.Name = "grpAutoAnimate";
            this.grpAutoAnimate.Size = new System.Drawing.Size(292, 91);
            this.grpAutoAnimate.TabIndex = 32;
            this.grpAutoAnimate.TabStop = false;
            // 
            // chkLoop
            // 
            this.chkLoop.AutoSize = true;
            this.chkLoop.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.chkLoop.Location = new System.Drawing.Point(9, 61);
            this.chkLoop.Name = "chkLoop";
            this.chkLoop.Size = new System.Drawing.Size(45, 16);
            this.chkLoop.TabIndex = 37;
            this.chkLoop.Text = "Loop";
            this.chkLoop.ThreeState = true;
            this.chkLoop.UseVisualStyleBackColor = true;
            // 
            // nupTo
            // 
            this.nupTo.Location = new System.Drawing.Point(47, 37);
            this.nupTo.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.nupTo.Name = "nupTo";
            this.nupTo.Size = new System.Drawing.Size(120, 21);
            this.nupTo.TabIndex = 36;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 39);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(23, 12);
            this.label4.TabIndex = 35;
            this.label4.Text = "To:";
            // 
            // nupFrom
            // 
            this.nupFrom.Location = new System.Drawing.Point(47, 13);
            this.nupFrom.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.nupFrom.Name = "nupFrom";
            this.nupFrom.Size = new System.Drawing.Size(120, 21);
            this.nupFrom.TabIndex = 34;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 15);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 12);
            this.label5.TabIndex = 33;
            this.label5.Text = "From:";
            // 
            // chkAutoAnimate
            // 
            this.chkAutoAnimate.AutoSize = true;
            this.chkAutoAnimate.Location = new System.Drawing.Point(21, 26);
            this.chkAutoAnimate.Name = "chkAutoAnimate";
            this.chkAutoAnimate.Size = new System.Drawing.Size(96, 16);
            this.chkAutoAnimate.TabIndex = 31;
            this.chkAutoAnimate.Text = "Auto animate";
            this.chkAutoAnimate.ThreeState = true;
            this.chkAutoAnimate.UseVisualStyleBackColor = true;
            this.chkAutoAnimate.CheckedChanged += new System.EventHandler(this.chkAutoAnimate_CheckedChanged);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.tagInput);
            this.groupBox4.Controls.Add(this.tagLabel);
            this.groupBox4.Controls.Add(this.label6);
            this.groupBox4.Controls.Add(this.cbCameraType);
            this.groupBox4.Controls.Add(this.chkNoExport);
            this.groupBox4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox4.Location = new System.Drawing.Point(12, 11);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(319, 93);
            this.groupBox4.TabIndex = 0;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Misc.";
            // 
            // tagInput
            // 
            this.tagInput.Location = new System.Drawing.Point(194, 23);
            this.tagInput.Name = "tagInput";
            this.tagInput.Size = new System.Drawing.Size(100, 21);
            this.tagInput.TabIndex = 3;
            // 
            // tagLabel
            // 
            this.tagLabel.AutoSize = true;
            this.tagLabel.Location = new System.Drawing.Point(159, 26);
            this.tagLabel.Name = "tagLabel";
            this.tagLabel.Size = new System.Drawing.Size(29, 12);
            this.tagLabel.TabIndex = 2;
            this.tagLabel.Text = "Tag:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(22, 51);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 12);
            this.label6.TabIndex = 4;
            this.label6.Text = "Type:";
            // 
            // cbCameraType
            // 
            this.cbCameraType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCameraType.FormattingEnabled = true;
            this.cbCameraType.Items.AddRange(new object[] {
            "AnaglyphArcRotateCamera",
            "AnaglyphFreeCamera",
            "ArcRotateCamera",
            "DeviceOrientationCamera",
            "FollowCamera",
            "FreeCamera",
            "GamepadCamera",
            "TouchCamera",
            "VirtualJoysticksCamera",
            "WebVRFreeCamera",
            "VRDeviceOrientationFreeCamera"});
            this.cbCameraType.Location = new System.Drawing.Point(22, 66);
            this.cbCameraType.Name = "cbCameraType";
            this.cbCameraType.Size = new System.Drawing.Size(290, 20);
            this.cbCameraType.TabIndex = 5;
            // 
            // chkNoExport
            // 
            this.chkNoExport.AutoSize = true;
            this.chkNoExport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.chkNoExport.Location = new System.Drawing.Point(21, 26);
            this.chkNoExport.Name = "chkNoExport";
            this.chkNoExport.Size = new System.Drawing.Size(99, 16);
            this.chkNoExport.TabIndex = 1;
            this.chkNoExport.Text = "Do not export";
            this.chkNoExport.ThreeState = true;
            this.chkNoExport.UseVisualStyleBackColor = true;
            // 
            // CameraPropertiesForm
            // 
            this.AcceptButton = this.butOK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.butCancel;
            this.ClientSize = new System.Drawing.Size(343, 566);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.butCancel);
            this.Controls.Add(this.butOK);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "CameraPropertiesForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Babylon.js - Camera Properties";
            this.Load += new System.EventHandler(this.CameraPropertiesForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nupInertia)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nupSpeed)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.grpAutoAnimate.ResumeLayout(false);
            this.grpAutoAnimate.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nupTo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nupFrom)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button butOK;
        private System.Windows.Forms.Button butCancel;
        private System.Windows.Forms.CheckBox chkCollisions;
        private System.Windows.Forms.CheckBox chkGravity;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown nupSpeed;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown nupInertia;
        private System.Windows.Forms.Label label3;
        private Vector3Control ellipsoidControl;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox grpAutoAnimate;
        private System.Windows.Forms.CheckBox chkLoop;
        private System.Windows.Forms.NumericUpDown nupTo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown nupFrom;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox chkAutoAnimate;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.CheckBox chkNoExport;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbCameraType;
        private System.Windows.Forms.TextBox tagInput;
        private System.Windows.Forms.Label tagLabel;
    }
}