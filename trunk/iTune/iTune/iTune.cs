using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO.Ports;

namespace iTune {
    public partial class iTune : Form {
        SerialPort serial;
        private void updatePorts() {
            string[] ports = SerialPort.GetPortNames();

            portSelection.Items.Clear();
            portSelection.Items.AddRange(ports);
        }
        private void connect() {
            try {
                serial = new SerialPort();
                serial.BaudRate = 9600;
                serial.PortName = portSelection.SelectedItem.ToString();
                serial.Open();

                connectButton.Enabled = false;
                disconnectButton.Enabled = true;
            }
            catch { }
        }
        private void disconnect() {
            try {
                serial.Close();
                serial.Dispose();

                connectButton.Enabled = true;
                disconnectButton.Enabled = false;
            }
            catch { }
        }

        public iTune() {
            InitializeComponent();
            updatePorts();
        }

        private void updateButton_Click(object sender, EventArgs e) {
            updatePorts();
        }

        private void connectButton_Click(object sender, EventArgs e) {
            connect();
        }
        private void disconnectButton_Click(object sender, EventArgs e) {
            disconnect();
        }

        private void sendBasicButton_Click(object sender, EventArgs e) {

        }

        

        private void sendAdvancedButton_Click(object sender, EventArgs e) {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void numericUpDown3_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}
