namespace iTune
{
    partial class iTune
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
            this.portSelection = new System.Windows.Forms.ComboBox();
            this.updateButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.connectButton = new System.Windows.Forms.Button();
            this.controlType = new System.Windows.Forms.TabControl();
            this.basicPage = new System.Windows.Forms.TabPage();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.highFrictionLabel = new System.Windows.Forms.Label();
            this.lowFrictionLabel = new System.Windows.Forms.Label();
            this.rolloverProtectionBox = new System.Windows.Forms.CheckBox();
            this.midairLevelingBox = new System.Windows.Forms.CheckBox();
            this.sendBasicButton = new System.Windows.Forms.Button();
            this.controlGainLabel = new System.Windows.Forms.Label();
            this.wheelFrictionLabel = new System.Windows.Forms.Label();
            this.wheelFriction = new System.Windows.Forms.TrackBar();
            this.controlGain = new System.Windows.Forms.TrackBar();
            this.advancedPage = new System.Windows.Forms.TabPage();
            this.PID1Label = new System.Windows.Forms.Label();
            this.disconnectButton = new System.Windows.Forms.Button();
            this.shapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.lineShape1 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.kP1Value = new System.Windows.Forms.NumericUpDown();
            this.kP1Label = new System.Windows.Forms.Label();
            this.kI1Value = new System.Windows.Forms.NumericUpDown();
            this.kD1Value = new System.Windows.Forms.NumericUpDown();
            this.kI1Label = new System.Windows.Forms.Label();
            this.kD1Label = new System.Windows.Forms.Label();
            this.kD2Label = new System.Windows.Forms.Label();
            this.kI2Label = new System.Windows.Forms.Label();
            this.kD2Value = new System.Windows.Forms.NumericUpDown();
            this.kI2Value = new System.Windows.Forms.NumericUpDown();
            this.kP2Label = new System.Windows.Forms.Label();
            this.kP2Value = new System.Windows.Forms.NumericUpDown();
            this.PID2Label = new System.Windows.Forms.Label();
            this.kD3Label = new System.Windows.Forms.Label();
            this.kI3Label = new System.Windows.Forms.Label();
            this.kD3Value = new System.Windows.Forms.NumericUpDown();
            this.kI3Value = new System.Windows.Forms.NumericUpDown();
            this.kP3Label = new System.Windows.Forms.Label();
            this.kP3Value = new System.Windows.Forms.NumericUpDown();
            this.PID3Label = new System.Windows.Forms.Label();
            this.rolloverProtectionBox2 = new System.Windows.Forms.CheckBox();
            this.midairLevelingBox2 = new System.Windows.Forms.CheckBox();
            this.advancedSendButton = new System.Windows.Forms.Button();
            this.controlType.SuspendLayout();
            this.basicPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.wheelFriction)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.controlGain)).BeginInit();
            this.advancedPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kP1Value)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kI1Value)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kD1Value)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kD2Value)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kI2Value)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kP2Value)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kD3Value)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kI3Value)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kP3Value)).BeginInit();
            this.SuspendLayout();
            // 
            // portSelection
            // 
            this.portSelection.FormattingEnabled = true;
            this.portSelection.Location = new System.Drawing.Point(48, 12);
            this.portSelection.Name = "portSelection";
            this.portSelection.Size = new System.Drawing.Size(75, 21);
            this.portSelection.TabIndex = 0;
            // 
            // updateButton
            // 
            this.updateButton.Location = new System.Drawing.Point(129, 10);
            this.updateButton.Name = "updateButton";
            this.updateButton.Size = new System.Drawing.Size(75, 23);
            this.updateButton.TabIndex = 1;
            this.updateButton.Text = "Update";
            this.updateButton.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Port";
            // 
            // connectButton
            // 
            this.connectButton.Location = new System.Drawing.Point(129, 37);
            this.connectButton.Name = "connectButton";
            this.connectButton.Size = new System.Drawing.Size(75, 23);
            this.connectButton.TabIndex = 3;
            this.connectButton.Text = "Connect";
            this.connectButton.UseVisualStyleBackColor = true;
            this.connectButton.Click += new System.EventHandler(this.connectButton_Click);
            // 
            // controlType
            // 
            this.controlType.Controls.Add(this.basicPage);
            this.controlType.Controls.Add(this.advancedPage);
            this.controlType.Location = new System.Drawing.Point(12, 66);
            this.controlType.Name = "controlType";
            this.controlType.SelectedIndex = 0;
            this.controlType.Size = new System.Drawing.Size(557, 332);
            this.controlType.TabIndex = 4;
            // 
            // basicPage
            // 
            this.basicPage.Controls.Add(this.label3);
            this.basicPage.Controls.Add(this.label2);
            this.basicPage.Controls.Add(this.highFrictionLabel);
            this.basicPage.Controls.Add(this.lowFrictionLabel);
            this.basicPage.Controls.Add(this.rolloverProtectionBox);
            this.basicPage.Controls.Add(this.midairLevelingBox);
            this.basicPage.Controls.Add(this.sendBasicButton);
            this.basicPage.Controls.Add(this.controlGainLabel);
            this.basicPage.Controls.Add(this.wheelFrictionLabel);
            this.basicPage.Controls.Add(this.wheelFriction);
            this.basicPage.Controls.Add(this.controlGain);
            this.basicPage.Location = new System.Drawing.Point(4, 22);
            this.basicPage.Name = "basicPage";
            this.basicPage.Padding = new System.Windows.Forms.Padding(3);
            this.basicPage.Size = new System.Drawing.Size(549, 306);
            this.basicPage.TabIndex = 0;
            this.basicPage.Text = "Basic Tuning";
            this.basicPage.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(514, 179);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "High";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 179);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Low";
            // 
            // highFrictionLabel
            // 
            this.highFrictionLabel.AutoSize = true;
            this.highFrictionLabel.Location = new System.Drawing.Point(516, 75);
            this.highFrictionLabel.Name = "highFrictionLabel";
            this.highFrictionLabel.Size = new System.Drawing.Size(29, 13);
            this.highFrictionLabel.TabIndex = 8;
            this.highFrictionLabel.Text = "High";
            // 
            // lowFrictionLabel
            // 
            this.lowFrictionLabel.AutoSize = true;
            this.lowFrictionLabel.Location = new System.Drawing.Point(10, 75);
            this.lowFrictionLabel.Name = "lowFrictionLabel";
            this.lowFrictionLabel.Size = new System.Drawing.Size(27, 13);
            this.lowFrictionLabel.TabIndex = 7;
            this.lowFrictionLabel.Text = "Low";
            // 
            // rolloverProtectionBox
            // 
            this.rolloverProtectionBox.AutoSize = true;
            this.rolloverProtectionBox.Location = new System.Drawing.Point(10, 281);
            this.rolloverProtectionBox.Name = "rolloverProtectionBox";
            this.rolloverProtectionBox.Size = new System.Drawing.Size(116, 17);
            this.rolloverProtectionBox.TabIndex = 6;
            this.rolloverProtectionBox.Text = "Rollover Protection";
            this.rolloverProtectionBox.UseVisualStyleBackColor = true;
            // 
            // midairLevelingBox
            // 
            this.midairLevelingBox.AutoSize = true;
            this.midairLevelingBox.Location = new System.Drawing.Point(10, 258);
            this.midairLevelingBox.Name = "midairLevelingBox";
            this.midairLevelingBox.Size = new System.Drawing.Size(97, 17);
            this.midairLevelingBox.TabIndex = 5;
            this.midairLevelingBox.Text = "Midair Leveling";
            this.midairLevelingBox.UseVisualStyleBackColor = true;
            // 
            // sendBasicButton
            // 
            this.sendBasicButton.Location = new System.Drawing.Point(468, 277);
            this.sendBasicButton.Name = "sendBasicButton";
            this.sendBasicButton.Size = new System.Drawing.Size(75, 23);
            this.sendBasicButton.TabIndex = 4;
            this.sendBasicButton.Text = "Send";
            this.sendBasicButton.UseVisualStyleBackColor = true;
            this.sendBasicButton.Click += new System.EventHandler(this.sendBasicButton_Click);
            // 
            // controlGainLabel
            // 
            this.controlGainLabel.AutoSize = true;
            this.controlGainLabel.Location = new System.Drawing.Point(3, 115);
            this.controlGainLabel.Name = "controlGainLabel";
            this.controlGainLabel.Size = new System.Drawing.Size(65, 13);
            this.controlGainLabel.TabIndex = 3;
            this.controlGainLabel.Text = "Control Gain";
            // 
            // wheelFrictionLabel
            // 
            this.wheelFrictionLabel.AutoSize = true;
            this.wheelFrictionLabel.Location = new System.Drawing.Point(3, 3);
            this.wheelFrictionLabel.Name = "wheelFrictionLabel";
            this.wheelFrictionLabel.Size = new System.Drawing.Size(75, 13);
            this.wheelFrictionLabel.TabIndex = 2;
            this.wheelFrictionLabel.Text = "Wheel Friction";
            // 
            // wheelFriction
            // 
            this.wheelFriction.Location = new System.Drawing.Point(6, 23);
            this.wheelFriction.Name = "wheelFriction";
            this.wheelFriction.Size = new System.Drawing.Size(537, 45);
            this.wheelFriction.TabIndex = 1;
            // 
            // controlGain
            // 
            this.controlGain.Location = new System.Drawing.Point(6, 131);
            this.controlGain.Name = "controlGain";
            this.controlGain.Size = new System.Drawing.Size(537, 45);
            this.controlGain.TabIndex = 0;
            // 
            // advancedPage
            // 
            this.advancedPage.Controls.Add(this.advancedSendButton);
            this.advancedPage.Controls.Add(this.rolloverProtectionBox2);
            this.advancedPage.Controls.Add(this.midairLevelingBox2);
            this.advancedPage.Controls.Add(this.kD3Label);
            this.advancedPage.Controls.Add(this.kI3Label);
            this.advancedPage.Controls.Add(this.kD3Value);
            this.advancedPage.Controls.Add(this.kI3Value);
            this.advancedPage.Controls.Add(this.kP3Label);
            this.advancedPage.Controls.Add(this.kP3Value);
            this.advancedPage.Controls.Add(this.PID3Label);
            this.advancedPage.Controls.Add(this.kD2Label);
            this.advancedPage.Controls.Add(this.kI2Label);
            this.advancedPage.Controls.Add(this.kD2Value);
            this.advancedPage.Controls.Add(this.kI2Value);
            this.advancedPage.Controls.Add(this.kP2Label);
            this.advancedPage.Controls.Add(this.kP2Value);
            this.advancedPage.Controls.Add(this.PID2Label);
            this.advancedPage.Controls.Add(this.kD1Label);
            this.advancedPage.Controls.Add(this.kI1Label);
            this.advancedPage.Controls.Add(this.kD1Value);
            this.advancedPage.Controls.Add(this.kI1Value);
            this.advancedPage.Controls.Add(this.kP1Label);
            this.advancedPage.Controls.Add(this.kP1Value);
            this.advancedPage.Controls.Add(this.PID1Label);
            this.advancedPage.Controls.Add(this.shapeContainer1);
            this.advancedPage.Location = new System.Drawing.Point(4, 22);
            this.advancedPage.Name = "advancedPage";
            this.advancedPage.Padding = new System.Windows.Forms.Padding(3);
            this.advancedPage.Size = new System.Drawing.Size(549, 306);
            this.advancedPage.TabIndex = 1;
            this.advancedPage.Text = "Advanced Tuning";
            this.advancedPage.UseVisualStyleBackColor = true;
            // 
            // PID1Label
            // 
            this.PID1Label.AutoSize = true;
            this.PID1Label.Location = new System.Drawing.Point(6, 8);
            this.PID1Label.Name = "PID1Label";
            this.PID1Label.Size = new System.Drawing.Size(78, 13);
            this.PID1Label.TabIndex = 6;
            this.PID1Label.Text = "Midair Leveling";
            // 
            // disconnectButton
            // 
            this.disconnectButton.Enabled = false;
            this.disconnectButton.Location = new System.Drawing.Point(48, 37);
            this.disconnectButton.Name = "disconnectButton";
            this.disconnectButton.Size = new System.Drawing.Size(75, 23);
            this.disconnectButton.TabIndex = 5;
            this.disconnectButton.Text = "Disconnect";
            this.disconnectButton.UseVisualStyleBackColor = true;
            this.disconnectButton.Click += new System.EventHandler(this.disconnectButton_Click);
            // 
            // shapeContainer1
            // 
            this.shapeContainer1.Location = new System.Drawing.Point(3, 3);
            this.shapeContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer1.Name = "shapeContainer1";
            this.shapeContainer1.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.lineShape1});
            this.shapeContainer1.Size = new System.Drawing.Size(543, 300);
            this.shapeContainer1.TabIndex = 7;
            this.shapeContainer1.TabStop = false;
            // 
            // lineShape1
            // 
            this.lineShape1.Name = "lineShape1";
            this.lineShape1.X1 = 722;
            this.lineShape1.X2 = 150;
            this.lineShape1.Y1 = 469;
            this.lineShape1.Y2 = 504;
            // 
            // kP1Value
            // 
            this.kP1Value.Increment = new decimal(new int[] {
            1,
            0,
            0,
            262144});
            this.kP1Value.Location = new System.Drawing.Point(113, 6);
            this.kP1Value.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.kP1Value.Minimum = new decimal(new int[] {
            1000,
            0,
            0,
            -2147483648});
            this.kP1Value.Name = "kP1Value";
            this.kP1Value.Size = new System.Drawing.Size(75, 20);
            this.kP1Value.TabIndex = 8;
            // 
            // kP1Label
            // 
            this.kP1Label.AutoSize = true;
            this.kP1Label.Location = new System.Drawing.Point(90, 8);
            this.kP1Label.Name = "kP1Label";
            this.kP1Label.Size = new System.Drawing.Size(20, 13);
            this.kP1Label.TabIndex = 9;
            this.kP1Label.Text = "kP";
            // 
            // kI1Value
            // 
            this.kI1Value.Increment = new decimal(new int[] {
            1,
            0,
            0,
            262144});
            this.kI1Value.Location = new System.Drawing.Point(113, 32);
            this.kI1Value.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.kI1Value.Minimum = new decimal(new int[] {
            1000,
            0,
            0,
            -2147483648});
            this.kI1Value.Name = "kI1Value";
            this.kI1Value.Size = new System.Drawing.Size(75, 20);
            this.kI1Value.TabIndex = 10;
            // 
            // kD1Value
            // 
            this.kD1Value.Increment = new decimal(new int[] {
            1,
            0,
            0,
            262144});
            this.kD1Value.Location = new System.Drawing.Point(113, 58);
            this.kD1Value.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.kD1Value.Minimum = new decimal(new int[] {
            1000,
            0,
            0,
            -2147483648});
            this.kD1Value.Name = "kD1Value";
            this.kD1Value.Size = new System.Drawing.Size(75, 20);
            this.kD1Value.TabIndex = 11;
            // 
            // kI1Label
            // 
            this.kI1Label.AutoSize = true;
            this.kI1Label.Location = new System.Drawing.Point(90, 34);
            this.kI1Label.Name = "kI1Label";
            this.kI1Label.Size = new System.Drawing.Size(16, 13);
            this.kI1Label.TabIndex = 12;
            this.kI1Label.Text = "kI";
            // 
            // kD1Label
            // 
            this.kD1Label.AutoSize = true;
            this.kD1Label.Location = new System.Drawing.Point(90, 60);
            this.kD1Label.Name = "kD1Label";
            this.kD1Label.Size = new System.Drawing.Size(21, 13);
            this.kD1Label.TabIndex = 13;
            this.kD1Label.Text = "kD";
            // 
            // kD2Label
            // 
            this.kD2Label.AutoSize = true;
            this.kD2Label.Location = new System.Drawing.Point(445, 60);
            this.kD2Label.Name = "kD2Label";
            this.kD2Label.Size = new System.Drawing.Size(21, 13);
            this.kD2Label.TabIndex = 20;
            this.kD2Label.Text = "kD";
            this.kD2Label.Click += new System.EventHandler(this.label6_Click);
            // 
            // kI2Label
            // 
            this.kI2Label.AutoSize = true;
            this.kI2Label.Location = new System.Drawing.Point(445, 34);
            this.kI2Label.Name = "kI2Label";
            this.kI2Label.Size = new System.Drawing.Size(16, 13);
            this.kI2Label.TabIndex = 19;
            this.kI2Label.Text = "kI";
            this.kI2Label.Click += new System.EventHandler(this.label7_Click);
            // 
            // kD2Value
            // 
            this.kD2Value.Increment = new decimal(new int[] {
            1,
            0,
            0,
            262144});
            this.kD2Value.Location = new System.Drawing.Point(468, 58);
            this.kD2Value.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.kD2Value.Minimum = new decimal(new int[] {
            1000,
            0,
            0,
            -2147483648});
            this.kD2Value.Name = "kD2Value";
            this.kD2Value.Size = new System.Drawing.Size(75, 20);
            this.kD2Value.TabIndex = 18;
            this.kD2Value.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // kI2Value
            // 
            this.kI2Value.Increment = new decimal(new int[] {
            1,
            0,
            0,
            262144});
            this.kI2Value.Location = new System.Drawing.Point(468, 32);
            this.kI2Value.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.kI2Value.Minimum = new decimal(new int[] {
            1000,
            0,
            0,
            -2147483648});
            this.kI2Value.Name = "kI2Value";
            this.kI2Value.Size = new System.Drawing.Size(75, 20);
            this.kI2Value.TabIndex = 17;
            this.kI2Value.ValueChanged += new System.EventHandler(this.numericUpDown2_ValueChanged);
            // 
            // kP2Label
            // 
            this.kP2Label.AutoSize = true;
            this.kP2Label.Location = new System.Drawing.Point(445, 8);
            this.kP2Label.Name = "kP2Label";
            this.kP2Label.Size = new System.Drawing.Size(20, 13);
            this.kP2Label.TabIndex = 16;
            this.kP2Label.Text = "kP";
            this.kP2Label.Click += new System.EventHandler(this.label8_Click);
            // 
            // kP2Value
            // 
            this.kP2Value.Increment = new decimal(new int[] {
            1,
            0,
            0,
            262144});
            this.kP2Value.Location = new System.Drawing.Point(468, 6);
            this.kP2Value.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.kP2Value.Minimum = new decimal(new int[] {
            1000,
            0,
            0,
            -2147483648});
            this.kP2Value.Name = "kP2Value";
            this.kP2Value.Size = new System.Drawing.Size(75, 20);
            this.kP2Value.TabIndex = 15;
            this.kP2Value.ValueChanged += new System.EventHandler(this.numericUpDown3_ValueChanged);
            // 
            // PID2Label
            // 
            this.PID2Label.AutoSize = true;
            this.PID2Label.Location = new System.Drawing.Point(298, 8);
            this.PID2Label.Name = "PID2Label";
            this.PID2Label.Size = new System.Drawing.Size(141, 13);
            this.PID2Label.TabIndex = 14;
            this.PID2Label.Text = "Rollover Protection Minimum";
            this.PID2Label.Click += new System.EventHandler(this.label9_Click);
            // 
            // kD3Label
            // 
            this.kD3Label.AutoSize = true;
            this.kD3Label.Location = new System.Drawing.Point(445, 138);
            this.kD3Label.Name = "kD3Label";
            this.kD3Label.Size = new System.Drawing.Size(21, 13);
            this.kD3Label.TabIndex = 27;
            this.kD3Label.Text = "kD";
            // 
            // kI3Label
            // 
            this.kI3Label.AutoSize = true;
            this.kI3Label.Location = new System.Drawing.Point(445, 112);
            this.kI3Label.Name = "kI3Label";
            this.kI3Label.Size = new System.Drawing.Size(16, 13);
            this.kI3Label.TabIndex = 26;
            this.kI3Label.Text = "kI";
            // 
            // kD3Value
            // 
            this.kD3Value.Increment = new decimal(new int[] {
            1,
            0,
            0,
            262144});
            this.kD3Value.Location = new System.Drawing.Point(468, 136);
            this.kD3Value.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.kD3Value.Minimum = new decimal(new int[] {
            1000,
            0,
            0,
            -2147483648});
            this.kD3Value.Name = "kD3Value";
            this.kD3Value.Size = new System.Drawing.Size(75, 20);
            this.kD3Value.TabIndex = 25;
            // 
            // kI3Value
            // 
            this.kI3Value.Increment = new decimal(new int[] {
            1,
            0,
            0,
            262144});
            this.kI3Value.Location = new System.Drawing.Point(468, 110);
            this.kI3Value.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.kI3Value.Minimum = new decimal(new int[] {
            1000,
            0,
            0,
            -2147483648});
            this.kI3Value.Name = "kI3Value";
            this.kI3Value.Size = new System.Drawing.Size(75, 20);
            this.kI3Value.TabIndex = 24;
            // 
            // kP3Label
            // 
            this.kP3Label.AutoSize = true;
            this.kP3Label.Location = new System.Drawing.Point(445, 86);
            this.kP3Label.Name = "kP3Label";
            this.kP3Label.Size = new System.Drawing.Size(20, 13);
            this.kP3Label.TabIndex = 23;
            this.kP3Label.Text = "kP";
            // 
            // kP3Value
            // 
            this.kP3Value.Increment = new decimal(new int[] {
            1,
            0,
            0,
            262144});
            this.kP3Value.Location = new System.Drawing.Point(468, 84);
            this.kP3Value.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.kP3Value.Minimum = new decimal(new int[] {
            1000,
            0,
            0,
            -2147483648});
            this.kP3Value.Name = "kP3Value";
            this.kP3Value.Size = new System.Drawing.Size(75, 20);
            this.kP3Value.TabIndex = 22;
            // 
            // PID3Label
            // 
            this.PID3Label.AutoSize = true;
            this.PID3Label.Location = new System.Drawing.Point(298, 86);
            this.PID3Label.Name = "PID3Label";
            this.PID3Label.Size = new System.Drawing.Size(144, 13);
            this.PID3Label.TabIndex = 21;
            this.PID3Label.Text = "Rollover Protection Maximum";
            // 
            // rolloverProtectionBox2
            // 
            this.rolloverProtectionBox2.AutoSize = true;
            this.rolloverProtectionBox2.Location = new System.Drawing.Point(301, 163);
            this.rolloverProtectionBox2.Name = "rolloverProtectionBox2";
            this.rolloverProtectionBox2.Size = new System.Drawing.Size(116, 17);
            this.rolloverProtectionBox2.TabIndex = 29;
            this.rolloverProtectionBox2.Text = "Rollover Protection";
            this.rolloverProtectionBox2.UseVisualStyleBackColor = true;
            // 
            // midairLevelingBox2
            // 
            this.midairLevelingBox2.AutoSize = true;
            this.midairLevelingBox2.Location = new System.Drawing.Point(9, 85);
            this.midairLevelingBox2.Name = "midairLevelingBox2";
            this.midairLevelingBox2.Size = new System.Drawing.Size(97, 17);
            this.midairLevelingBox2.TabIndex = 28;
            this.midairLevelingBox2.Text = "Midair Leveling";
            this.midairLevelingBox2.UseVisualStyleBackColor = true;
            // 
            // advancedSendButton
            // 
            this.advancedSendButton.Location = new System.Drawing.Point(468, 277);
            this.advancedSendButton.Name = "advancedSendButton";
            this.advancedSendButton.Size = new System.Drawing.Size(75, 23);
            this.advancedSendButton.TabIndex = 30;
            this.advancedSendButton.Text = "Send";
            this.advancedSendButton.UseVisualStyleBackColor = true;
            // 
            // iTune
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(581, 410);
            this.Controls.Add(this.disconnectButton);
            this.Controls.Add(this.controlType);
            this.Controls.Add(this.connectButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.updateButton);
            this.Controls.Add(this.portSelection);
            this.Name = "iTune";
            this.Text = "iTune";
            this.controlType.ResumeLayout(false);
            this.basicPage.ResumeLayout(false);
            this.basicPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.wheelFriction)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.controlGain)).EndInit();
            this.advancedPage.ResumeLayout(false);
            this.advancedPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kP1Value)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kI1Value)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kD1Value)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kD2Value)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kI2Value)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kP2Value)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kD3Value)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kI3Value)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kP3Value)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox portSelection;
        private System.Windows.Forms.Button updateButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button connectButton;
        private System.Windows.Forms.TabControl controlType;
        private System.Windows.Forms.TabPage basicPage;
        private System.Windows.Forms.Label controlGainLabel;
        private System.Windows.Forms.Label wheelFrictionLabel;
        private System.Windows.Forms.TrackBar wheelFriction;
        private System.Windows.Forms.TrackBar controlGain;
        private System.Windows.Forms.TabPage advancedPage;
        private System.Windows.Forms.Button sendBasicButton;
        private System.Windows.Forms.Button disconnectButton;
        private System.Windows.Forms.Label lowFrictionLabel;
        private System.Windows.Forms.CheckBox rolloverProtectionBox;
        private System.Windows.Forms.CheckBox midairLevelingBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label highFrictionLabel;
        private System.Windows.Forms.Label PID1Label;
        private System.Windows.Forms.Label kD2Label;
        private System.Windows.Forms.Label kI2Label;
        private System.Windows.Forms.NumericUpDown kD2Value;
        private System.Windows.Forms.NumericUpDown kI2Value;
        private System.Windows.Forms.Label kP2Label;
        private System.Windows.Forms.NumericUpDown kP2Value;
        private System.Windows.Forms.Label PID2Label;
        private System.Windows.Forms.Label kD1Label;
        private System.Windows.Forms.Label kI1Label;
        private System.Windows.Forms.NumericUpDown kD1Value;
        private System.Windows.Forms.NumericUpDown kI1Value;
        private System.Windows.Forms.Label kP1Label;
        private System.Windows.Forms.NumericUpDown kP1Value;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape1;
        private System.Windows.Forms.CheckBox rolloverProtectionBox2;
        private System.Windows.Forms.CheckBox midairLevelingBox2;
        private System.Windows.Forms.Label kD3Label;
        private System.Windows.Forms.Label kI3Label;
        private System.Windows.Forms.NumericUpDown kD3Value;
        private System.Windows.Forms.NumericUpDown kI3Value;
        private System.Windows.Forms.Label kP3Label;
        private System.Windows.Forms.NumericUpDown kP3Value;
        private System.Windows.Forms.Label PID3Label;
        private System.Windows.Forms.Button advancedSendButton;
    }
}

