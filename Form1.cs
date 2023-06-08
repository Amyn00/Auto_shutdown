using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;

namespace Auto_Shutdown
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult mydialog = MessageBox.Show("Your PC will stop at \'" + NHeur.Value + "H" + NMinute.Value + "Min" + NSeconde.Value + "Sec\' \n do you want to continue ?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
               if (DialogResult.Yes == mydialog) 
               {
                       TSecond.Start();
                       TMinute.Start();
                       THeur.Start();

                       NHeur.Enabled = false;
                       NMinute.Enabled = false;
                       NSeconde.Enabled = false;

                       button1.Enabled = false;
                       button3.Enabled = false;
                }
        }

        private void THeur_Tick(object sender, EventArgs e)
        {
            if (NHeur.Value != 0)
            {
                if (NMinute.Value == 0 & NSeconde.Value == 0 & NHeur.Value != 0)
                {
                    //NHeur.Value -= 1;
                    //NMinute.Value = 59;
                    TMinute.Start();
                }
            }
            else 
            {
                THeur.Stop();
            }
            
        }

        private void TMinute_Tick(object sender, EventArgs e)
        {
            if (NMinute.Value != 0 & NSeconde.Value == 0)
            {
                //NMinute.Value -= 1;
                //NSeconde.Value = 59;
                TSecond.Start();
            }
            else if(NSeconde.Value == 0 & NMinute.Value == 0 & NHeur.Value!=0)
            {
                //NHeur.Value -= 1;
                //NMinute.Value = 59;
                //NSeconde.Value = 59;
                TSecond.Start();
            }
            else
            {
                TMinute.Stop();
            }
        }

        private void TSecond_Tick(object sender, EventArgs e)
        {
            if (NSeconde.Value != 0)
            {
                NSeconde.Value -= 1;
                int i = 9;

                if (NSeconde.Value == 9 & NMinute.Value==0 & NHeur.Value==0)
                {
                    i -= 1;
                   Form2 f2 = new Form2();
                   f2.Show();
                }
            }
            else if (NSeconde.Value == 0 & NMinute.Value != 0)
            {
                NMinute.Value -= 1;
                NSeconde.Value = 59;
            }
            else if (NSeconde.Value == 0 & NMinute.Value == 0 & NHeur.Value != 0)
            {
                NHeur.Value -= 1;
                NMinute.Value = 59;
                NSeconde.Value = 59;
            } 
            else
            {
                TSecond.Stop();
                if (NSeconde.Value == 0 & NMinute.Value == 0 & NHeur.Value == 0)
                {
                    if (button2.Enabled == true)
                    {
                        Process p = new Process();
                        p.StartInfo.FileName = "cmd.exe";
                        p.StartInfo.Arguments = "/c shutdown -s -t 0";
                        p.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
                        p.Start();
                        //Process.Start("C:\\Program Files (x86)\\ANONYM X\\Auto_Shutdown\\shutdown.bat");
                    }
                    else if (button3.Enabled == true)
                    {
                        Process p = new Process();
                        p.StartInfo.FileName = "cmd.exe";
                        p.StartInfo.Arguments = "/c shutdown -r -t 0";
                        p.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
                        p.Start();
                        //Process.Start(@"C:\Program Files (x86)\ANONYM X\Auto_Shutdown\reboot.bat");
                    }
                    else if (button1.Enabled == true)
                    {
                        Process p = new Process();
                        p.StartInfo.FileName = "cmd.exe";
                        p.StartInfo.Arguments = "/c shutdown -l";
                        p.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
                        p.Start();
                        //Process.Start("D:\\COURS\\Projet Finie\\Auto_Shutdown\\Auto_Shutdown\\bin\\Debug\\Batch\\logOff.bat");
                    }

                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            TSecond.Stop();
            TMinute.Stop();
            THeur.Stop();

            NHeur.Enabled = true;
            NHeur.Value = 0;

            NMinute.Enabled = true;
            NMinute.Value = 0;

            NSeconde.Enabled = true;
            NSeconde.Value = 0;

            button1.Enabled = true;
            button2.Enabled = true;
            button3.Enabled = true;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DialogResult mydialog = MessageBox.Show("Your PC will Restart at \'" + NHeur.Value + "H" + NMinute.Value + "Min" + NSeconde.Value + "Sec\' \n do you want to continue ?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (DialogResult.Yes == mydialog)
                {
                    TSecond.Start();
                    TMinute.Start();
                    THeur.Start();

                    NHeur.Enabled = false;
                    NMinute.Enabled = false;
                    NSeconde.Enabled = false;

                    button1.Enabled = false;
                    button2.Enabled = false;
                }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            TSecond.Stop();
            TMinute.Stop();
            THeur.Stop();

            NHeur.Enabled = true;
            NMinute.Enabled = true;
            NSeconde.Enabled = true;

            button1.Enabled = true;
            button2.Enabled = true;
            button3.Enabled = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult mydialog = MessageBox.Show("Your Session will be closed at \'" + NHeur.Value + "H" + NMinute.Value + "Min" + NSeconde.Value + "Sec\' \n do you want to continue ?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (DialogResult.Yes == mydialog)
            {
                TSecond.Start();
                TMinute.Start();
                THeur.Start();

                NHeur.Enabled = false;
                NMinute.Enabled = false;
                NSeconde.Enabled = false;

                button2.Enabled = false;
                button3.Enabled = false;
            }
        }
    }
}
