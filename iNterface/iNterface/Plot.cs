using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace iNterface {

    public partial class Plot : Form {
        private bool[] checkState;
        private int updateCount;
        private int updateSet;

        public Plot(Data data) {
            string[] names = data.getNames();
            InitializeComponent();

            for (int i = 0; i < names.Length; i++) {
                System.Windows.Forms.DataVisualization.Charting.Series series = new System.Windows.Forms.DataVisualization.Charting.Series();
                series.ChartArea = "Default";
                series.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastLine;
                series.Legend = "Default";
                series.Name = names[i];
                this.chart.Series.Add(series);
            }
            this.chartSelection.Items.AddRange((object[]) names);
            checkState = new bool[names.Length];
            updateCheckState();
            updateCount = 0;
            updateSet = 5;
        }

        private void updateCheckState() {
            for(int i = 0; i < checkState.Length; i ++)
                checkState[i] = false;
            foreach(int i in chartSelection.CheckedIndices) {
                checkState[i] = true;
            }
        }

        private void Plot_Resize(object sender, EventArgs e) {
            if ((this.Size.Width > 146) && (this.Size.Height > 100)) {
                chart.Size = new Size(this.Size.Width - 146, this.Size.Height - 62);
                chartSelection.Size = new Size(chartSelection.Size.Width, this.Size.Height - 100);
            }
        }

        public void updateChart(Data data) {
            if (updateCount == updateSet) {
                updateCheckState();

                double minTime = ((double)data.getTime()[data.getTime().Count - 1]) - (double) timeSelection.Value*1000;
                int minTimeI = 0;

                for (int i = data.getTime().Count - 1; i >= 0; i--)
                    if (data.getTime()[i] < minTime) {
                        minTimeI = i;
                        break;
                    }

                for (int i = 0; i < checkState.Length; i++) {
                    chart.Series[i].Points.Clear();

                    if (checkState[i]) {
                        for (int j = minTimeI; j < data.getData()[i].Count; j++) {
                            double time = ((double)data.getTime()[j]) / 1000;
                            double y = (double)data.getData()[i][j];
                            chart.Series[i].Points.AddXY(time, y);
                        }
                    }
                }
                updateCount = 0;
            }
            else {
                updateCount++;
            }
        }
    }
}
