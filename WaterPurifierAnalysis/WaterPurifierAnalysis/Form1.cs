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

namespace WaterPurifierAnalysis
{
    public partial class Form1 : Form
    {
        SerialPort serialPort;

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
            //var ports = SerialPort.GetPortNames();
            //comboBox1.DataSource = ports;
            timer1.Enabled = true;
        }

        private void jalurToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void port_click(object sender, MouseEventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (serialPort != null)
            {
                if (serialPort.IsOpen)
                {
                    try { serialPort.Close(); }
                    catch (Exception err)
                    {
                        MessageBox.Show( err.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }
            }
            else
            {
                serialPort = new SerialPort();
            }
            if (serialPort.IsOpen) {
                MessageBox.Show( "Jalur digunakan oleh aplikasi lain!", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (!comboBox1.Text.Contains("COM")) {
                if (comboBox1.Text == "") {
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
                MessageBox.Show( err.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            var ports = SerialPort.GetPortNames();
            if (ports.Length == comboBox1.Items.Count) return;
            //comboBox1.Items.Clear();
            comboBox1.Text = "";
            comboBox1.DataSource = ports;

        }
    }
}
