using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO.Ports;
using System.Collections;

namespace iNterface {
    public partial class iNterface : Form {
        private List<Plot> plots;
        private Data data;

        public iNterface() {
            plots = new List<Plot>();
            data = new Data();

            InitializeComponent();
        }

        //Methods
        private void updatePorts() {
            string[] ports = SerialPort.GetPortNames();

            Console.Write("Updated Port List: ");
            foreach (string p in ports)
            {
                Console.Write(p + " ");
            }
            Console.WriteLine("");

            portSelection.Items.Clear();
            portSelection.Items.AddRange(ports);
        }
        private void updateBauds() {
            string[] bauds = new String[] { "2400", "4800", "9600", "19200", "38400", "57600", "115200" };

            Console.Write("Updated Baud List: ");
            foreach (string b in bauds)
            {
                Console.Write(b + " ");
            }
            Console.WriteLine("");

            baudSelection.Items.Clear();
            baudSelection.Items.AddRange(bauds);
            baudSelection.SelectedIndex = 6;
        }

        private void setPort() {
            string port = portSelection.SelectedItem.ToString();

            Console.WriteLine("Selected Port: " + port);

            serial.PortName = port;
        }
        private void setBaud() {
            int baud = Convert.ToInt32(baudSelection.SelectedItem.ToString());

            Console.WriteLine("Selected Baud: " + baud);

            serial.BaudRate = baud;
        }

        private void connect() {
            clearData();
            Console.Write("Connecting to " + serial.PortName + " at " + serial.BaudRate + " ... ");

            try {
                serial.Open();

                Console.WriteLine("Done");

                connectButton.Enabled = false;
                disconnectButton.Enabled = true;
                updateButton.Enabled = false;
                baudSelection.Enabled = false;
                portSelection.Enabled = false;
                saveButton.Enabled = true;
                clearButton.Enabled = true;
            }
            catch {
                Console.WriteLine("Failed");
            }
        }
        private void disconnect() {

            Console.Write("Disconnecting from " + serial.PortName + " ... ");

            try {
                serial.Close();
            }
            catch {
                serial.Dispose();

                serial = new SerialPort();
                setPort();
                setBaud();
            }
            Console.WriteLine("Done");

            connectButton.Enabled = true;
            disconnectButton.Enabled = false;
            updateButton.Enabled = true;
            baudSelection.Enabled = true;
            portSelection.Enabled = true;
            saveButton.Enabled = false;
            clearButton.Enabled = false;
        }

        private void clearData() {
            Console.WriteLine("Cleared Data");

            data = new Data();

            updatePlots();
            updateDataCount();
        }
        private void saveData() {
            saveDialog.Filter = "csv files (*.csv)|*.csv";

            if (saveDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK && saveDialog.FileName.Length > 0)
            {
                Console.WriteLine("Saved File: " + saveDialog.FileName);
                data.saveFile(saveDialog.FileName);
            }
            else
                Console.WriteLine("Save Failed");
        }

        private void newPlot() {
            Plot p = new Plot(data);
            p.Show();
            plots.Add(p);
        }

        private bool updateData() {
            try {
                string line = serial.ReadLine();
                if (!data.update(line)) {
                    Console.WriteLine(line);
                    return false;
                }
            }
            catch {
                return false;
            }
            return true;
        }
        private delegate void updatePlotsCallBack();
        private void updatePlots() {
            for (int i = 0; i < plots.Count; i++)
                if (!(plots[i]).IsDisposed)
                    (plots[i]).updateChart(data);
                else
                    plots.RemoveAt(i);
        }
        private delegate void updateDataCountCallBack();
        private void updateDataCount() {
            int count = data.getData()[0].Count;

            if(count != 1)
                dataPointsLabel.Text = count + " Data Points";
            else
                dataPointsLabel.Text = count + " Data Point";

        }

        //Event Handlers
        private void Form1_Load(object sender, EventArgs e) {
            this.updatePorts();
            this.updateBauds();
        }
        private void iNterface_FormClosing(object Sender, EventArgs e) {
            disconnect();
            serial.Dispose();
        }

        private void updateButton_Click(object sender, EventArgs e) {
            this.updatePorts();
        }

        private void connectButton_Click(object sender, EventArgs e) {
            connect();
        }
        private void disconnectButton_Click(object sender, EventArgs e) {
            disconnect();
        }

        private void portSelection_SelectedIndexChanged(object sender, EventArgs e) {
            setPort();
        }
        private void baudSelection_SelectedIndexChanged(object sender, EventArgs e) {
            setBaud();
        }

        private void newPlotButton_Click(object sender, EventArgs e) {
            newPlot();
        }

        private void clearButton_Click(object sender, EventArgs e) {
            clearData();
        }
        private void saveButton_Click(object sender, EventArgs e) {
            saveData();
        }

        private void serial_DataReceived(object sender, SerialDataReceivedEventArgs e) {
            if (updateData()) {
                this.BeginInvoke(new updatePlotsCallBack(updatePlots));
                this.BeginInvoke(new updateDataCountCallBack(updateDataCount));
            }
        }
    }
}
