namespace iNterface
{
    partial class iNterface
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
            this.components = new System.ComponentModel.Container();
            this.portSelection = new System.Windows.Forms.ComboBox();
            this.portLabel = new System.Windows.Forms.Label();
            this.updateButton = new System.Windows.Forms.Button();
            this.connectButton = new System.Windows.Forms.Button();
            this.disconnectButton = new System.Windows.Forms.Button();
            this.baudLabel = new System.Windows.Forms.Label();
            this.baudSelection = new System.Windows.Forms.ComboBox();
            this.newPlotButton = new System.Windows.Forms.Button();
            this.saveButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.saveDialog = new System.Windows.Forms.SaveFileDialog();
            this.serial = new System.IO.Ports.SerialPort(this.components);
            this.dataPointsLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // portSelection
            // 
            this.portSelection.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.portSelection.FormattingEnabled = true;
            this.portSelection.Items.AddRange(new object[] {
            "COM1",
            "COM2",
            "COM3",
            "COM4",
            "COM5",
            "COM6",
            "COM7",
            "COM8",
            "COM9"});
            this.portSelection.Location = new System.Drawing.Point(47, 6);
            this.portSelection.Name = "portSelection";
            this.portSelection.Size = new System.Drawing.Size(75, 21);
            this.portSelection.TabIndex = 14;
            this.portSelection.SelectedIndexChanged += new System.EventHandler(this.portSelection_SelectedIndexChanged);
            // 
            // portLabel
            // 
            this.portLabel.AutoSize = true;
            this.portLabel.Location = new System.Drawing.Point(12, 9);
            this.portLabel.Name = "portLabel";
            this.portLabel.Size = new System.Drawing.Size(29, 13);
            this.portLabel.TabIndex = 15;
            this.portLabel.Text = "Port:";
            // 
            // updateButton
            // 
            this.updateButton.Location = new System.Drawing.Point(128, 6);
            this.updateButton.Name = "updateButton";
            this.updateButton.Size = new System.Drawing.Size(75, 23);
            this.updateButton.TabIndex = 16;
            this.updateButton.Text = "Update";
            this.updateButton.UseVisualStyleBackColor = true;
            this.updateButton.Click += new System.EventHandler(this.updateButton_Click);
            // 
            // connectButton
            // 
            this.connectButton.Location = new System.Drawing.Point(209, 6);
            this.connectButton.Name = "connectButton";
            this.connectButton.Size = new System.Drawing.Size(75, 23);
            this.connectButton.TabIndex = 17;
            this.connectButton.Text = "Connect";
            this.connectButton.UseVisualStyleBackColor = true;
            this.connectButton.Click += new System.EventHandler(this.connectButton_Click);
            // 
            // disconnectButton
            // 
            this.disconnectButton.Enabled = false;
            this.disconnectButton.Location = new System.Drawing.Point(209, 33);
            this.disconnectButton.Name = "disconnectButton";
            this.disconnectButton.Size = new System.Drawing.Size(75, 23);
            this.disconnectButton.TabIndex = 18;
            this.disconnectButton.Text = "Disconnect";
            this.disconnectButton.UseVisualStyleBackColor = true;
            this.disconnectButton.Click += new System.EventHandler(this.disconnectButton_Click);
            // 
            // baudLabel
            // 
            this.baudLabel.AutoSize = true;
            this.baudLabel.Location = new System.Drawing.Point(6, 36);
            this.baudLabel.Name = "baudLabel";
            this.baudLabel.Size = new System.Drawing.Size(35, 13);
            this.baudLabel.TabIndex = 19;
            this.baudLabel.Text = "Baud:";
            // 
            // baudSelection
            // 
            this.baudSelection.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.baudSelection.FormattingEnabled = true;
            this.baudSelection.Items.AddRange(new object[] {
            "COM1",
            "COM2",
            "COM3",
            "COM4",
            "COM5",
            "COM6",
            "COM7",
            "COM8",
            "COM9"});
            this.baudSelection.Location = new System.Drawing.Point(47, 33);
            this.baudSelection.Name = "baudSelection";
            this.baudSelection.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.baudSelection.Size = new System.Drawing.Size(75, 21);
            this.baudSelection.TabIndex = 20;
            this.baudSelection.SelectedIndexChanged += new System.EventHandler(this.baudSelection_SelectedIndexChanged);
            // 
            // newPlotButton
            // 
            this.newPlotButton.Location = new System.Drawing.Point(209, 91);
            this.newPlotButton.Name = "newPlotButton";
            this.newPlotButton.Size = new System.Drawing.Size(75, 23);
            this.newPlotButton.TabIndex = 22;
            this.newPlotButton.Text = "New Plot";
            this.newPlotButton.UseVisualStyleBackColor = true;
            this.newPlotButton.Click += new System.EventHandler(this.newPlotButton_Click);
            // 
            // saveButton
            // 
            this.saveButton.Enabled = false;
            this.saveButton.Location = new System.Drawing.Point(209, 62);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(75, 23);
            this.saveButton.TabIndex = 23;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // clearButton
            // 
            this.clearButton.Enabled = false;
            this.clearButton.Location = new System.Drawing.Point(128, 62);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(75, 23);
            this.clearButton.TabIndex = 24;
            this.clearButton.Text = "Clear";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // serial
            // 
            this.serial.BaudRate = 115200;
            this.serial.ReadTimeout = 2;
            this.serial.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serial_DataReceived);
            // 
            // dataPointsLabel
            // 
            this.dataPointsLabel.AutoSize = true;
            this.dataPointsLabel.Location = new System.Drawing.Point(6, 96);
            this.dataPointsLabel.Name = "dataPointsLabel";
            this.dataPointsLabel.Size = new System.Drawing.Size(71, 13);
            this.dataPointsLabel.TabIndex = 25;
            this.dataPointsLabel.Text = "0 Data Points";
            // 
            // iNterface
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(294, 126);
            this.Controls.Add(this.dataPointsLabel);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.newPlotButton);
            this.Controls.Add(this.baudSelection);
            this.Controls.Add(this.baudLabel);
            this.Controls.Add(this.disconnectButton);
            this.Controls.Add(this.connectButton);
            this.Controls.Add(this.updateButton);
            this.Controls.Add(this.portLabel);
            this.Controls.Add(this.portSelection);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "iNterface";
            this.Text = "iNterface";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(iNterface_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox portSelection;
        private System.Windows.Forms.Label portLabel;
        private System.Windows.Forms.Button updateButton;
        private System.Windows.Forms.Button connectButton;
        private System.Windows.Forms.Button disconnectButton;
        private System.Windows.Forms.Label baudLabel;
        private System.Windows.Forms.ComboBox baudSelection;
        private System.Windows.Forms.Button newPlotButton;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.SaveFileDialog saveDialog;
        private System.IO.Ports.SerialPort serial;
        private System.Windows.Forms.Label dataPointsLabel;
    }
}

