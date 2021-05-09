using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Windows.Forms.DataVisualization.Charting;
using NationalInstruments.NI4882;
using CA200SRVRLib;

namespace SourceMeter_ColorAnalyzer
{
    public partial class Form1 : Form
    {
        int irow = 0;
        bool isSourceMeterOpened = false;
        bool isVoltageMode = false;
        Device sourceMeter;
        string times;
        string currs;
        string sweeps;
        string volts;

        bool isColorAnalyzerOpened = false;
        Ca200 objCa200 = new Ca200();
        Form2 f = new Form2();

        bool isAborted = false;
        public Form1()
        {
            InitializeComponent();
        }

        private void OpenBtn_Click(object sender, EventArgs e)
        {
            try
            {
                // connect sourcemter
                sourceMeter = new Device(0, 24);
                sourceMeter.Write("*IDN?");
                Logbox.Items.Add(sourceMeter.ReadString());
                isSourceMeterOpened = true;
                OpenStatus.Text = "Current mode!!";
                // change to current mode
                sourceMeter.Write(":SOURce:CLEAr:IMMediate");
                sourceMeter.Write(":SOURce:FUNCtion:MODE CURR");
                //sourceMeter.Write(":SENSe:FUNCtion 'CURRent");
                sourceMeter.Write(":SENSe:VOLTage:PROTection 150");
                //sourceMeter.Write(":SENSe:FUNCtion:OFF VOLTage");
                Logbox.Items.Add("Voltage Protection 150V");
            }
            catch (Exception ex)
            {
                Logbox.Items.Add(ex.Message);
            }
        }

        private void CloseBtn_Click(object sender, EventArgs e)
        {
            try
            {
                sourceMeter.Dispose();
                Logbox.Items.Add("Source meter disposed.");
                isVoltageMode = false;
                isSourceMeterOpened = false;
                OpenStatus.Text = "source: Not Opened";
            }
            catch (Exception ex)
            {
                Logbox.Items.Add(ex.Message);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            currs = "0, 0, 0, 0";
            times = "2, 3, 4, 5";
            CurrTextBox.Text = currs;
            TimeTextBox.Text = times;
            
            volts = "5, 5, 5, 5";
            VoltageTextBox.Text = volts;

            sweeps = "0, 10, 1";
            SweepTextBox.Text = sweeps;
                        
            OutputDataGrid.ColumnCount = 7;
            OutputDataGrid.Columns[0].Name = "No.";
            OutputDataGrid.Columns[1].Name = "Time";
            OutputDataGrid.Columns[2].Name = "V [V]";
            OutputDataGrid.Columns[3].Name = "I [A]";
            OutputDataGrid.Columns[4].Name = "L [nit]";
            OutputDataGrid.Columns[5].Name = "x";
            OutputDataGrid.Columns[6].Name = "y";

            OutputDataGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
        }

        private void TimeTextBox_TextChanged(object sender, EventArgs e)
        {
            times = TimeTextBox.Text;
        }

        private void MeasureBtn_Click(object sender, EventArgs e)
        {
            try
            {
                f.Show();
                int measureInterval = 1000; // 1초당 1회 측정
                string[] t = times.Split(',');
                string[] current = currs.Split(',');
                string[] volt = volts.Split(',');

                if (t.Length == current.Length)
                {
                    StatusLabel.Text = "Measuring ... ...";
                    if (isSourceMeterOpened == true)
                    {
                        sourceMeter.Write(":SOURce:CURRent:LEVel:IMMediate:AMPLitude 0E -6");
                        sourceMeter.Write(":OUTPut:STATe 1");
                    }
                    if (isVoltageMode == true)
                    {
                        sourceMeter.Write(":SOURce:VOLTage:LEVel:IMMediate:AMPLitude 0");
                        sourceMeter.Write(":OUTPut:STATe 1");
                    }

                    OutputDataGrid.Rows.Add();

                    System.Diagnostics.Stopwatch sw = new System.Diagnostics.Stopwatch();
                    for (int i = 0; i < t.Length; i++)
                    {
                        int t0 = 0;
                        int tn = int.Parse(t[i]);
                        while (t0 < tn)
                        {
                            if (isAborted == true) // Check Abort
                            {
                                break;
                            }
                            sw.Reset();
                            sw.Start();

                            OutputDataGrid.Rows.Add();
                            OutputDataGrid.Rows[irow].Cells[0].Value = irow + 1;
                            OutputDataGrid.Rows[irow].Cells[1].Value = DateTime.Now;
                            if (isSourceMeterOpened == true)
                            {
                                sourceMeter.Write(":SOURce:CURRent:LEVel:IMMediate:AMPLitude " + current[i] + "E -6");
                                ReadSourceMeter();
                            }
                            if (isVoltageMode == true)
                            {
                                sourceMeter.Write(":SOURce:VOLTage:LEVel:IMMediate:AMPLitude " + volt[i]);
                                ReadSourceMeter();
                            }
                            if (isColorAnalyzerOpened == true)
                            {
                                ColorMeasure();
                            }
                            OutputDataGrid.FirstDisplayedScrollingRowIndex = OutputDataGrid.Rows.Count - 1;

                            sw.Stop();
                            int ts = (int)sw.ElapsedMilliseconds;

                            if (measureInterval - ts >= 0)
                            {
                                Wait(measureInterval - ts);
                            }
                            DrawGraph(); // update graph
                            irow++;
                            t0++;
                        }
                    }
                    if (isSourceMeterOpened == true | isVoltageMode == true)
                    {
                        sourceMeter.Write(":OUTPut:STATe 0");
                    }
                    StatusLabel.Text = "Done!!";
                    isAborted = false;
                }
                else
                {
                    MessageBox.Show("시간과 전류의 Length가 동일해야합니다.");
                }
            }
            catch (Exception ex)
            {
                Logbox.Items.Add(ex.Message);
            }
        }

        private void CurrTextBox_TextChanged(object sender, EventArgs e)
        {
            currs = CurrTextBox.Text;
        }
        private void ReadSourceMeter()
        {
            try
            {
                sourceMeter.Write(":READ?");
                string listData = sourceMeter.ReadString();
                string[] parsedData = listData.Split(',');
                if (isVoltageMode == true)
                {
                    OutputDataGrid.Rows[irow].Cells[2].Value = parsedData[0];
                }
                else
                {
                    OutputDataGrid.Rows[irow].Cells[2].Value = null;
                }
                OutputDataGrid.Rows[irow].Cells[3].Value = parsedData[1];
            }
            catch (Exception ex)
            {
                Logbox.Items.Add(ex.Message);
            }
        }
        public void Wait(int milliseconds)
        {
            var timer1 = new System.Windows.Forms.Timer();
            if (milliseconds == 0 || milliseconds < 0) return;
            
            timer1.Interval = milliseconds;
            timer1.Enabled = true;
            timer1.Start();

            timer1.Tick += (s, e) =>
            {
                timer1.Enabled = false;
                timer1.Stop();
            };

            while (timer1.Enabled)
            {
                System.Windows.Forms.Application.DoEvents();
            }
        }

        private void SAVEBtn_Click(object sender, EventArgs e)
        {
            if (OutputDataGrid.Rows.Count > 0)
            {
                SaveFileDialog sfd = new SaveFileDialog
                {
                    Filter = "CSV (*.csv)|*.csv",
                    FileName = "Output" + DateTime.Now.Hour + DateTime.Now.Minute + DateTime.Now.Second + ".csv"
                };
                bool fileError = false;
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    if (File.Exists(sfd.FileName))
                    {
                        try
                        {
                            File.Delete(sfd.FileName);
                        }
                        catch (IOException ex)
                        {
                            fileError = true;
                            MessageBox.Show("지울 수 없음: " + ex.Message);
                        }
                    }
                    if (!fileError)
                    {
                        try
                        {
                            OutputDataGrid.ClipboardCopyMode = DataGridViewClipboardCopyMode.EnableAlwaysIncludeHeaderText;

                            OutputDataGrid.SelectAll();
                            DataObject dataObject = OutputDataGrid.GetClipboardContent();

                            File.WriteAllText(sfd.FileName, dataObject.GetText(TextDataFormat.CommaSeparatedValue), Encoding.UTF8);
                            MessageBox.Show("완료 !!!", "Info");
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Error :" + ex.Message);
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("데이터 없음 !!!", "Info");
            }
        }

        private void ClearBtn_Click(object sender, EventArgs e)
        {
            OutputDataGrid.Rows.Clear();
            irow = 0;

            List<Form> openForms = new List<Form>();
            foreach (Form f in System.Windows.Forms.Application.OpenForms)
                openForms.Add(f);
            foreach (Form f in openForms)
            {
                if (f.Name != "Form1")
                    f.Hide();
            }
        }

        private void ZeroCalBtn_Click(object sender, EventArgs e)
        {
            try
            {
                objCa200.AutoConnect();
                Logbox.Items.Add("Connect");
                objCa200.SingleCa.CalZero();
                Logbox.Items.Add("zeroCal");

                objCa200.SingleCa.SyncMode = 3;
                objCa200.SingleCa.AveragingMode = 2;
                objCa200.SingleCa.SetAnalogRange(Convert.ToSingle(2.5), Convert.ToSingle(2.5));
                objCa200.SingleCa.DisplayMode = 0;
                objCa200.SingleCa.Memory.ChannelNO = 0;

                isColorAnalyzerOpened = true;
            }
            catch (Exception ex)
            {
                Logbox.Items.Add(ex.Message);
            }
        }
        private void ColorMeasure()
        {
            try
            {
                objCa200.SingleCa.Measure();

                //measurement result
                double Lv = 0.0;
                double sx = 0.0;
                double sy = 0.0;

                Lv = objCa200.SingleCa.SingleProbe.Lv;
                sx = objCa200.SingleCa.SingleProbe.sx;
                sy = objCa200.SingleCa.SingleProbe.sy;

                OutputDataGrid.Rows[irow].Cells[4].Value = Lv;
                OutputDataGrid.Rows[irow].Cells[5].Value = sx;
                OutputDataGrid.Rows[irow].Cells[6].Value = sy;
            }
            catch (Exception ex)
            {
                Logbox.Items.Add(ex.Message);
            }
        }

        private void AbortBtn_Click(object sender, EventArgs e)
        {
            isAborted = true;
        }
        private void DrawGraph()
        {
            if (irow == 0)
            {
                f.LumChart.Series.Clear();
                Series no = new Series();
                f.LumChart.Series.Add(no);
                f.LumChart.Series[0].Name = "Lum";
                f.LumChart.Series[0].ChartType = SeriesChartType.Line;

                f.LumChart.ChartAreas[0].AxisX.Title = "Time index";
                f.LumChart.ChartAreas[0].AxisY.Title = "L [nit]";
            }
            f.LumChart.Series[0].Points.AddXY(OutputDataGrid.Rows[irow].Cells[0].Value, OutputDataGrid.Rows[irow].Cells[4].Value);
        }
        private void DrawIV()
        {
            if (irow == 0)
            {
                f.LumChart.Series.Clear();
                Series no = new Series();
                f.LumChart.Series.Add(no);
                f.LumChart.Series[0].Name = "Current";
                f.LumChart.Series[0].ChartType = SeriesChartType.Line;

                f.LumChart.ChartAreas[0].AxisX.Title = "V [V]";
                f.LumChart.ChartAreas[0].AxisY.Title = "I [A]";
            }
            f.LumChart.Series[0].Points.AddXY(OutputDataGrid.Rows[irow].Cells[2].Value, OutputDataGrid.Rows[irow].Cells[3].Value);
        }
        private void OpenVoltageBtn_Click(object sender, EventArgs e)
        {
            try
            {
                // connect sourcemter
                sourceMeter = new Device(0, 24);
                sourceMeter.Write("*IDN?");
                Logbox.Items.Add(sourceMeter.ReadString());
                isVoltageMode = true;
                OpenStatus.Text = "Voltage mode!!";
                // change to current mode
                sourceMeter.Write(":SOURce:CLEAr:IMMediate");
                sourceMeter.Write(":SOURce:FUNCtion:MODE VOLT");
                Logbox.Items.Add("Voltage Mode");
            }
            catch (Exception ex)
            {
                Logbox.Items.Add(ex.Message);
            }
        }

        private void SweepTextBox_TextChanged(object sender, EventArgs e)
        {
            sweeps = SweepTextBox.Text;
        }

        private void SweepBtn_Click(object sender, EventArgs e)
        {
            f.Show();
            int delay = 500;
            try
            {
                string[] v = sweeps.Split(',');
                double[] voltage;

                int start = int.Parse(v[0]);
                int stop = int.Parse(v[1]);
                double step = double.Parse(v[2]);
                int length = (int)((stop - start) / step);

                voltage = (from i in Enumerable.Range(0, length) select i * step + start).ToArray();

                if (isVoltageMode == true)
                {
                    sourceMeter.Write(":SOURce:VOLTage:LEVel:IMMediate:AMPLitude 0");
                    sourceMeter.Write(":OUTPut:STATe 1");
                }

                for (int i = 0; i < voltage.Length; i++)
                {
                    OutputDataGrid.Rows.Add();
                    OutputDataGrid.Rows[irow].Cells[0].Value = irow + 1;
                    OutputDataGrid.Rows[irow].Cells[1].Value = DateTime.Now;
                    if (isVoltageMode == true)
                    {
                        sourceMeter.Write(":SOURce:VOLTage:LEVel:IMMediate:AMPLitude " + voltage[i]);
                        ReadSourceMeter();
                    }
                    if (isColorAnalyzerOpened == true)
                    {
                        ColorMeasure();
                    }
                    OutputDataGrid.FirstDisplayedScrollingRowIndex = OutputDataGrid.Rows.Count - 1;
                    DrawIV();
                    irow++;
                    Wait(delay);
                }
                if (isVoltageMode == true)
                {
                    sourceMeter.Write(":OUTPut:STATe 0");
                }
            }
            catch (Exception ex)
            {
                Logbox.Items.Add(ex.Message);
            }
        }
        private void VoltageTextBox_TextChanged(object sender, EventArgs e)
        {
            volts = VoltageTextBox.Text;
        }
    }
}