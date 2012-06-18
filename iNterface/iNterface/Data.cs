using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;
using System.Windows.Forms.DataVisualization.Charting;

namespace iNterface
{
    public class Data {
        int numData;
        private List<Int64> time;
        private List<Int32>[] data;
        private string[] names;

        public Data() {
            names = new string[] {
                "Roll",
                "Pitch",
                "Yaw",
                "Zero G",

                "Throttle",
                "Steering",

                "Series 1",
                "Series 2",
                "Series 3",
                "Series 4",
                "Series 5",

                "Series 6",
                "Series 7",
                "Series 8",
                "Series 9",
                "Series 10"};

            numData = names.Length + 1;

            time = new List<Int64>();
            data = new List<Int32>[numData - 1];
            for (int i = 0; i < data.Length; i++) {
                data[i] = new List<Int32>();
            }
        }

        public Boolean update(string line) {
            int numCount = 0;
            int commaLoc;
            string numS;
            char[] find = {','};
            foreach (char c in line) {
                if ((c != '0') && (c != '1') && (c != '2') && (c != '3') && (c != '4') && (c != '5') && (c != '6') && (c != '7') && (c != '8') && (c != '9') && (c != '-') && (c != ',') && (c != 12) && (c != 13))
                    return false;
                if(c == ',')
                    numCount ++;
            }
            if ((numCount < numData - 10) || (numCount > numData))
                return false;

            for (int i = 0; i < numCount; i++) {
                commaLoc = line.IndexOfAny(find, 0);
                numS = line.Substring(0, commaLoc);

                if (i == 0) {
                    if (time.Count != 0)
                        time.Add(time[time.Count - 1] + Convert.ToInt64(numS));
                    else
                        time.Add(Convert.ToInt64(numS));
                }
                else
                    data[i - 1].Add(Convert.ToInt32(numS));

                if(i != (numCount - 1))
                    line = line.Substring(commaLoc + 1, line.Length - commaLoc - 1);
            }
            for (int i = numCount; i < numData; i++)
                data[i - 1].Add(0);

            return true;
        }

        public void saveFile(string loc) {
            StringBuilder csv = new StringBuilder();

            csv.Append("Time,");
            foreach (string n in names)
                csv.Append(n + ",");
            csv.AppendLine("");
            for (int i = 0; i < time.Count; i ++ ) {
                csv.Append(time[i] + ", ");
                foreach (List<Int32> d in data)
                    if(i < d.Count)
                        csv.Append(d[i] + ", ");
                csv.AppendLine("");
            }
            using (StreamWriter outfile = new StreamWriter(loc))
                outfile.Write(csv.ToString());
        }

        public List<Int64> getTime() {
            return time;
        }
        public List<Int32>[] getData() {
            return data;
        }
        public string[] getNames() {
            return names;
        }
    }
}
