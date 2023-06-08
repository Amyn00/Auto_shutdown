using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Auto_Shutdown
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void TimeOut_Tick(object sender, EventArgs e)
        {
            if (numericUpDown1.Value != 0)
            {
                numericUpDown1.Value -= 1;
            }
            else
            {
                TimeOut.Stop();
                Close();
            }
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            numericUpDown1.Value = 9;
            TimeOut.Start();
        }

    }
}
