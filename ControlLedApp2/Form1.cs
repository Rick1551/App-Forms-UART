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

namespace ControlLedApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            btnOpen.Enabled = false;
            btnClose.Enabled = false;
            btnLEDON.Enabled = false;
            btnLEDOFF.Enabled = false;
            comboBoxBAUD.Text = "9600";
            progressBarConexion.Value = 0;
            pictureBoxLED.Image = Properties.Resources.green_led_off_md;

            string[] portlist = SerialPort.GetPortNames();
            comboBoxCOM.Items.AddRange(portlist);

        }
    }
}
