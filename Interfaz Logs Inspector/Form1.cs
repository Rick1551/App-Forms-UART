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

namespace Interfaz_Logs_Inspector
{
    public partial class Form1 : Form
    {
        private SerialPort _serialPort;
        public Form1()
        {
            InitializeComponent();

            _serialPort = new SerialPort();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Text = button1.Text;
            label1.Text = "Hola mundo";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = button2.Text;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
