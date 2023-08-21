using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SerialPortTRR
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            foreach (string s in SerialPort.GetPortNames())
            {
                comboBoxPorts.Items.Add(s);
                comboBoxPorts2.Items.Add(s);
            }
            comboBoxPorts.SelectedIndex = 0;
            comboBoxPorts2.SelectedIndex = 1;
            buttonSend.Enabled = false;
            buttonDisconnect.Enabled = false;
            buttonDisconnect2.Enabled = false;
            buttonSend2.Enabled = false;
            buttonClear1.Enabled = true;
            buttonClear2.Enabled = true;
        }
        private void buttonConnect_Click(object sender, EventArgs e)
        {
            serialPort1.PortName = comboBoxPorts.Text;
            serialPort1.BaudRate = 9600;
            serialPort1.Parity = Parity.Even;
            serialPort1.StopBits = StopBits.One;
            serialPort1.DataBits = 8;
            try
            {
                serialPort1.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Seri port bağlantısı yapılamadı... \n Hata : " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            if(serialPort1.IsOpen)
            {
                buttonConnect.Enabled = false;
                buttonDisconnect.Enabled = true;
                buttonSend.Enabled = true;
            }
        }

        private void buttonDisconnect_Click(object sender, EventArgs e)
        {
            if(serialPort1.IsOpen)
            {
                serialPort1.Close();
                buttonDisconnect.Enabled = false;
                buttonConnect.Enabled = true;
                buttonSend.Enabled = false;
            }
        }

        private void buttonSend_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen)
            {
                serialPort1.Write(textBoxSend.Text);
                textBoxSend.Clear();
            }
        }
        public delegate void veriGoster(String s);
        public void textBoxYaz(String s)
        {
            textBoxRecevied.Text += s;
        }
        public void textBoxYaz2(String s)
        {
            textBoxRecevied2.Text += s;
        }

        private void serialPort1_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            String gelenVeri = serialPort1.ReadExisting();
            textBoxRecevied.Invoke(new veriGoster(textBoxYaz), gelenVeri);
        }

        private void buttonConnect2_Click(object sender, EventArgs e)
        {
            serialPort2.PortName = comboBoxPorts2.Text;
            serialPort2.BaudRate = 9600;
            serialPort2.Parity = Parity.Even;
            serialPort2.StopBits = StopBits.One;
            serialPort2.DataBits = 8;

            try
            {
                serialPort2.Open();
            }
            catch (Exception err)
            {
                MessageBox.Show("Seri port bağlantısı yapılamadı... \n Hata : " + err.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            if(serialPort2.IsOpen)
            {
                buttonConnect2.Enabled = false;
                buttonDisconnect2.Enabled = true;
                buttonSend2.Enabled = true;
            }
        }

        private void buttonDisconnect2_Click(object sender, EventArgs e)
        {
            if(serialPort2.IsOpen)
            {
                serialPort2.Close();
                buttonSend2.Enabled = false;
                buttonDisconnect2.Enabled = false;
                buttonConnect2.Enabled = true;
            }
        }

        private void buttonSend2_Click(object sender, EventArgs e)
        {
            if (serialPort2.IsOpen)
            {
                serialPort2.Write(textBoxSend2.Text);
                textBoxSend2.Clear();
            }
        }

        private void serialPort2_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            String gelenVeri = serialPort2.ReadExisting();
            textBoxRecevied2.Invoke(new veriGoster(textBoxYaz2), gelenVeri);
        }

        private void buttonClear1_Click(object sender, EventArgs e)
        {
            textBoxRecevied.Text = "";
        }

        private void buttonClear2_Click(object sender, EventArgs e)
        {
            textBoxRecevied2.Text = "";
        }
    }
}
