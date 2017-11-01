using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Clocks
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            ClockTimer.Text = DateTime.Now.ToString("HH:mm:ss");
        }
       
        private void Form1_Load_1(object sender, EventArgs e)
        {

        }

        private void ClockTimer_Click(object sender, EventArgs e)
        {
            ClockTimer.ForeColor = Color.Red;
            ClockTimer.Text = "Do not click this!";
        }

        private void ClockTimer_DoubleClick(object sender, EventArgs e)
        {
            ClockTimer.ForeColor = Color.Black;
        }

        private void ClockTimer_MarginChanged(object sender, EventArgs e)
        {

        }
    }
}
