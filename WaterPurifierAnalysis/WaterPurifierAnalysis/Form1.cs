using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.IO.Ports;
using System.Threading;

using SMData;
using CreateExcelFile;

namespace WaterPurifierAnalysis
{
    public partial class Form1 : Form
    {
        //SpreadSheetData xdata;
        string sheetName = DateTime.Now.ToString("MMMM", System.Globalization.CultureInfo.CreateSpecificCulture("id-ID"));
        char decimalSparator = Thread.CurrentThread.CurrentCulture.NumberFormat.NumberDecimalSeparator[0];

        Boolean time2read = false;
        SQLiteData adata;

        private Thread chartThread;
        private double[] suhu_inArray = new double[60];
        private double[] suhu_outArray = new double[60];
        private double[] TDS_inArray = new double[60];
        private double[] TDS_outArray = new double[60];
        private double[] PH_inArray = new double[60];
        private double[] PH_outArray = new double[60];

        String tglHariIni = DateTime.Now.ToString("yyyy-MM-dd");

        // delegate is used to write to a UI control from a non-UI thread  
        private delegate void SetTextDeleg(string text);

        public Form1()
        {
            InitializeComponent();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (!createSQLLiteDB())
                return;



            DateTime dtNow = DateTime.Now;
            string strNow = dtNow.ToOADate().ToString(System.Globalization.CultureInfo.InvariantCulture);

            try
            {
                String[] nomorTerakhir = adata.ExecQuery("SELECT no FROM maintable ORDER BY no DESC LIMIT 1");
                try
                {
                    if (nomorTerakhir[0] != null)
                        this.nomorTerakhir = int.Parse(nomorTerakhir[0]);
                }
                catch
                {
                    this.nomorTerakhir = 0;
                }
            }
            catch (Exception err)
            {
                MessageBox.Show("File data tidak dapat dibuka dibuka. " + Environment.NewLine + "Silahkan tutup file rekap dan buka aplikasi kembali!" + err.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly);
                this.Close();
                return;
            }
            //var ports = SerialPort.GetPortNames();
            //comboBox1.DataSource = ports;
            timer1.Enabled = true;
        }

        private bool createSQLLiteDB()
        {
            try
            {

                adata = new SQLiteData(tglHariIni,
                    @"CREATE TABLE `wqms_data` (
	                    `id`	INTEGER NOT NULL DEFAULT 0 PRIMARY KEY AUTOINCREMENT,
	                    `datetime`	INTEGER NOT NULL,
	                    `inTemp`	REAL NOT NULL,
	                    `inTDS`	REAL NOT NULL,
	                    `inPH`	REAL NOT NULL,
	                    `outTemp`	REAL,
	                    `outTDS`	REAL,
	                    `outPH`	REAL); ", Application.ProductName
                    );
            }
            catch (Exception err)
            {
                MessageBox.Show("File System.Data.SQLite.dll tidak ditemukan" + err.HelpLink, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly);
                this.Close();
                return false;
            }
            return true;
        }

        private void jalurToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void port_click(object sender, MouseEventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (cmbSampling.SelectedItem != null)
            {
                int.TryParse(cmbSampling.SelectedItem.ToString(), out durasiSampling);
            }
            if (durasiSampling == 0)
                durasiSampling = 5;


            if (serialPort != null)
            {
                if (serialPort.IsOpen)
                {
                    try { serialPort.Close(); }
                    catch (Exception err)
                    {
                        MessageBox.Show(err.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }
            }
            else
            {
                serialPort = new SerialPort();
            }

            if (button1.Text == "Stop")
            {
                timer2.Enabled = false;
                chartThread.Abort();
                button1.Text = "Start";
                return;
            }
            else
            {
                startAllChart();
            }

            if (serialPort.IsOpen)
            {
                MessageBox.Show("Jalur digunakan oleh aplikasi lain!", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (!comboBox1.Text.Contains("COM"))
            {
                if (comboBox1.Text == "")
                {
                    MessageBox.Show("Jalur tidak ditemukan!", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("Nama jalur tidak sesuai!", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                return;
            }
            serialPort.PortName = comboBox1.Text;
            serialPort.BaudRate = 9600;

            try
            {
                serialPort.Open();
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            button1.Text = "Stop";
            timer2.Interval = durasiSampling * 1000;
            timer2.Enabled = true;
            time2read = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            var ports = SerialPort.GetPortNames();
            if (ports.Length == comboBox1.Items.Count) return;
            comboBox1.Text = "";
            comboBox1.DataSource = ports;

        }


        private void UpdateSuhuChart()
        {
            suhuChart.Series[0].Points.Clear();
            suhuChart.Series[1].Points.Clear();

            for (int i = 0; i < suhu_inArray.Length - 1; ++i)
            {
                suhuChart.Series[0].Points.AddY(suhu_inArray[i]);
                suhuChart.Series[1].Points.AddY(suhu_outArray[i]);
            }
        }
        private void UpdateTDSChart()
        {
            TDSChart.Series[0].Points.Clear();
            TDSChart.Series[1].Points.Clear();

            for (int i = 0; i < suhu_inArray.Length - 1; ++i)
            {
                TDSChart.Series[0].Points.AddY(TDS_inArray[i]);
                TDSChart.Series[1].Points.AddY(TDS_outArray[i]);
            }
        }
        private void UpdatePHChart()
        {
            PHChart.Series[0].Points.Clear();
            PHChart.Series[1].Points.Clear();

            for (int i = 0; i < suhu_inArray.Length - 1; ++i)
            {
                PHChart.Series[0].Points.AddY(PH_inArray[i]);
                PHChart.Series[1].Points.AddY(PH_outArray[i]);
            }
        }
        string data;
        private int durasiSampling = 0;
        private int nomorTerakhir;

        private void startAllChart()
        {
            chartThread = new Thread(new ThreadStart(this.getSerialData));
            chartThread.IsBackground = true;
            chartThread.Start();

        }

        private void getSerialData()
        {
            while (true)
            {
                if (!time2read) continue;
                if (data == null)
                    continue;
                data = data.Replace('.', decimalSparator);
                string[] dataArr = data.Split('$');
                if (dataArr.Length < 1)
                {
                    continue;
                }

                int i = 0; string[] dataStringArr = new string[6];
                for (; i < dataArr.Length; i++)
                {
                    dataArr[i].TrimEnd('\r');
                    dataStringArr = dataArr[i].Split(';');
                    if (dataStringArr.Length == 6)
                        break;
                }

                if (dataStringArr.Length < 6)
                    continue;

                time2read = false;

                double suhu_in = 0;
                double.TryParse(dataStringArr[0], out suhu_in);
                suhu_inArray[suhu_inArray.Length - 1] = suhu_in;
                Array.Copy(suhu_inArray, 1, suhu_inArray, 0, suhu_inArray.Length - 1);

                double suhu_out = 0;
                double.TryParse(dataStringArr[3], out suhu_out);
                suhu_outArray[suhu_outArray.Length - 1] = suhu_out;
                Array.Copy(suhu_outArray, 1, suhu_outArray, 0, suhu_outArray.Length - 1);

                double TDS_in = 0;
                double.TryParse(dataStringArr[1], out TDS_in);
                TDS_inArray[TDS_inArray.Length - 1] = TDS_in;
                Array.Copy(TDS_inArray, 1, TDS_inArray, 0, TDS_inArray.Length - 1);

                double TDS_out = 0;
                double.TryParse(dataStringArr[4], out TDS_out);
                TDS_outArray[TDS_outArray.Length - 1] = TDS_out;
                Array.Copy(TDS_outArray, 1, TDS_outArray, 0, TDS_outArray.Length - 1);

                double PH_in = 0;
                double.TryParse(dataStringArr[2], out PH_in);
                PH_inArray[PH_inArray.Length - 1] = PH_in;
                Array.Copy(PH_inArray, 1, PH_inArray, 0, PH_inArray.Length - 1);

                double PH_out = 0;
                double.TryParse(dataStringArr[5], out PH_out);
                PH_outArray[PH_outArray.Length - 1] = PH_out;
                Array.Copy(PH_outArray, 1, PH_outArray, 0, PH_outArray.Length - 1);



                if (suhuChart.IsHandleCreated)
                {
                    try
                    {
                        if (!this.Disposing)
                        {
                            this.Invoke((MethodInvoker)delegate { UpdateAllChart(); });
                        }
                    }
                    catch { }
                }
                else
                {
                    //......
                }

                //for (int id = 0; id < durasiSampling; id++)
                {
                    Thread.Sleep(100);
                }

            }
        }

        private void UpdateAllChart()
        {
            String kueri = @"insert into wqms_data (datetime, inTemp, inTDS, inPH, outTemp, outTDS, outPH) values (strftime('%s','now'), " + suhu_inArray[59].ToString().Replace(',', '.') + ", " + TDS_inArray[59].ToString().Replace(',', '.') + ", " + PH_inArray[59].ToString().Replace(',', '.') + ", " + suhu_outArray[59].ToString().Replace(',', '.') + ", " + TDS_outArray[59].ToString().Replace(',', '.') + ", " + PH_outArray[59].ToString().Replace(',', '.') + ")";
            adata.ExecQuery(kueri);
            UpdateSuhuChart();
            UpdatePHChart();
            UpdateTDSChart();
        }

        private void serialPort_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            if (serialPort.IsOpen)
            {
                SerialPort sdata = sender as SerialPort;
                try
                {
                    data = sdata.ReadLine();
                    this.BeginInvoke(new SetTextDeleg(si_DataReceived), new object[] { data });
                }
                catch { }
                //for (int id = 0; id < durasiSampling; id++)
                //{
                //    Thread.Sleep(1000);
                //}

            }
        }
        private void si_DataReceived(string data) { listBox1.Items.Add(data); }

        private void Form1_Shown(object sender, EventArgs e)
        {
            suhuChart.Width = (Width - 100) / 2;
            suhuChart.Height = (Height - 100 - 100) / 2;

            TDSChart.Width = suhuChart.Width;
            TDSChart.Height = suhuChart.Height;

            PHChart.Width = suhuChart.Width;
            PHChart.Height = suhuChart.Height;

            TDSChart.Top = suhuChart.Top;
            TDSChart.Left = suhuChart.Left + suhuChart.Width + 50;

            PHChart.Top = suhuChart.Top + suhuChart.Height + 50;
            PHChart.Left = suhuChart.Left;
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            time2read = true;
        }

        private void exportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (button1.Text == "Stop")
            {
                DialogResult jawab = MessageBox.Show("Sampling process should be paused for a moment to avoid data corruption.  Do you want to stop sampling proccess for a moment?", Application.ProductName, MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly);
                if (jawab == DialogResult.No)
                {
                    return;
                }
             button1_Click(sender, e);
           }


            exportData();

        }
        public enum CellValues
        {
            Boolean = 0,
            Number = 1,
            Error = 2,
            SharedString = 3,
            String = 4,
            InlineString = 5,
            Date = 6
        }
        private void exportData()
        {


            string xlsFileName = "";
            string xlsFolderName = "";
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.Filter = "Excel File|*.xlsx";
            saveFileDialog1.Title = "Save an Excel File";
            saveFileDialog1.ShowDialog();
            string mydpath = System.Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            mydpath += "\\" + Application.ProductName;
            saveFileDialog1.InitialDirectory = mydpath;

            // If the file name is not an empty string open it for saving.
            if (saveFileDialog1.FileName != "")
            {
                System.IO.FileInfo fi = new System.IO.FileInfo(saveFileDialog1.FileName);
                xlsFileName = fi.Name.Replace(fi.Extension,"");
                xlsFolderName = fi.DirectoryName;
            }
            else {
                if (button1.Text == "Start") {
                    button1_Click(null, null);
                    return;
                }
            }

            /*
            try
            {
                //Buat file jika tidak ada
                //xdata = new SpreadSheetData(sheetName, xlsFileName, Application.ProductName);
                xdata = new SpreadSheetData(sheetName, saveFileDialog1.FileName);
                waitForFile(xdata.IsFileReady(), "file digunakan aplikasi lain");
                if (xdata.isNewFileAndSheetCreated) createSheetHeader();
                waitForFile(xdata.IsFileReady(), "pembuatan header tidak tuntas");
                //Jika file belum ada sheet, tambahkan sheet
                bool isNewSheet = xdata.InsertWorksheetIfNotAvailable(sheetName);
                waitForFile(xdata.IsFileReady(), "pembuatan sheet tidak tuntas");
                //Jika sheet belum ada dan berhasil ditambahkan 
                if (isNewSheet)
                {
                    createSheetHeader();
                    waitForFile(xdata.IsFileReady(), "pembuatan header tidak tuntas");
                }

                String[][] recordSisaAntrian = adata.ExecQueryStrings("SELECT datetime, inTemp, inTDS, inPH, outTemp, outTDS, outPH FROM wqms_data LIMIT 10");

                if (decimalSparator == ',')
                {
                    for (int i = 0; i < recordSisaAntrian.Length; i++)
                    {
                        for (int j = 0; j < recordSisaAntrian[0].Length; j++)
                        {
                            recordSisaAntrian[i][j] = recordSisaAntrian[i][j].Replace(',', '.');
                            
                        }
                    }
                }

                for (int i = 0; i < recordSisaAntrian.Length; i++) {
                    var epoch = new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc);
                    double unixTime = 0;
                    double.TryParse(recordSisaAntrian[i][0], out unixTime);
                    epoch = epoch.AddSeconds(unixTime);
                    recordSisaAntrian[i][0] = epoch.ToString();
                }

                try
                {
                    uint row = 0; //add on last row    
                    string[] cols = { "A", "B", "C", "D", "E", "F", "G" };
                    
                    uint[] cellType = { 6, 1, 1, 1, 1, 1, 1 };
                    for (int x = 0; x < recordSisaAntrian.Length; x++)
                    {
                        string[] vals = recordSisaAntrian[x];
                        xdata.InsertValues(sheetName, row, cols, recordSisaAntrian, cellType);
                    }
                    waitForFile(xdata.IsFileReady(), "pengisian data");

                }
                catch (Exception err)
                {
                    MessageBox.Show("File rekap sedang dibuka, Err: "+err.Message + Environment.NewLine + "Silahkan tutup file rekap dan buka aplikasi kembali!" + err.HelpLink, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly);
                    this.Close();
                    return;
                }

            }
            catch (Exception err)
            {
                MessageBox.Show("File rekap excell gagal dibuka: " + err.Message + Environment.NewLine + "Silahkan tutup file rekap dan buka aplikasi kembali!" + Environment.NewLine, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly);
                this.Close();
                return;
            }
            */
            String[][] recordSisaAntrian = adata.ExecQueryStrings("SELECT datetime, inTemp, inTDS, inPH, outTemp, outTDS, outPH FROM wqms_data");
            List<Package> packages = new List<Package> { };

            for (int i = 0; i < recordSisaAntrian.Length; i++)
            {
                var epoch = new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc);
                double unixTime = 0;
                double.TryParse(recordSisaAntrian[i][0], out unixTime);
                epoch = epoch.AddSeconds(unixTime);

                double inTemp = 0;
                double.TryParse(recordSisaAntrian[i][1], out inTemp);

                double inTDS = 0;
                double.TryParse(recordSisaAntrian[i][2], out inTDS);

                double inPH = 0;
                double.TryParse(recordSisaAntrian[i][3], out inPH);

                double outTemp = 0;
                double.TryParse(recordSisaAntrian[i][4], out outTemp);

                double outTDS = 0;
                double.TryParse(recordSisaAntrian[i][5], out outTDS);

                double outPH = 0;
                double.TryParse(recordSisaAntrian[i][6], out outPH);

                packages.Add(new Package { Tanggal = epoch, InputTemp = inTemp, InputTDS = inTDS, InputPH = inPH, OutputTemp = outTemp, OutputTDS = outTDS, OutputPH = outPH });
            }

            //GeneratedClass gc = new GeneratedClass();
            //gc.CreatePackage(saveFileDialog1.FileName);

            ExcelFacade excelFacade = new ExcelFacade();
            List<string> headerNames = new List<string> { "Sampling DateTime", "Input Temp", "Input TDS", "Input PH", "Output Temp", "Output TDS", "Output PH" };
            excelFacade.Create<Package>(saveFileDialog1.FileName, packages, "Packages", headerNames);

            MessageBox.Show("File has been already writen to " + saveFileDialog1.FileName, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly);

        }
        private void waitForFile(bool condition, string message)
        {
            System.Diagnostics.Stopwatch sw = new System.Diagnostics.Stopwatch();
            sw.Start();
            while (!condition)
            {
                if (sw.ElapsedMilliseconds > 5000) throw new TimeoutException(message);
            }

            //for (int i = 0; i <= 30000; i++) { if (condition) break; if (i == 30000) { MessageBox.Show("File open timed out :" + message); throw new Exception(message); } }
        }

        private void createSheetHeader()
        {
            /*
            //insert header
            uint row = 1; //add on last row    
            string[] cols = { "A", "B", "C", "D", "E", "F", "G" };
            string[] vals = { "Waktu", "Inlet Temp", "Inlet TDS", "Inlet pH", "Outlet Temp", "Outlet TDS", "Outlet pH" };
            xdata.InsertValues(sheetName, row, cols, vals);
            waitForFile(xdata.IsFileReady(), "pembuatan header");
            */
        }
    }
    public class Package
    {
        public DateTime Tanggal { get; set; }
        public double InputTemp { get; set; }
        public double InputTDS { get; set; }
        public double InputPH { get; set; }
        public double OutputTemp { get; set; }
        public double OutputTDS { get; set; }
        public double OutputPH { get; set; }
    }
}