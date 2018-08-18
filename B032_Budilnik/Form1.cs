using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace B032_Budilnik
{
    public partial class Form1 : Form
    {
        [System.Runtime.InteropServices.DllImport("winmm.dll")]
        private static extern
            Boolean PlaySound(string lpszName, int hModule, int dwFlags);

        private DateTime alarm;

        public Form1()
        {
            InitializeComponent();

            numericUpDown_Hours.Maximum = 23;
            numericUpDown_Hours.Minimum = 0;

            numericUpDown_Min.Maximum = 59;
            numericUpDown_Min.Minimum = 0;

            numericUpDown_Hours.Value = DateTime.Now.Hour;
            numericUpDown_Min.Value = DateTime.Now.Minute;

            notifyIcon1.Visible = false;

            timer1.Interval = 1000;
            timer1.Enabled = true;

            label_TimeNow.Text = DateTime.Now.ToLongTimeString();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label_TimeNow.Text = DateTime.Now.ToLongTimeString();

            if(checkBox_OnOff.Checked)
            {
                if(DateTime.Compare(DateTime.Now, alarm) > 0)
                {
                    checkBox_OnOff.Checked = false;

                    PlaySound(Application.StartupPath + "\\ring.wav", 0, 1);

                    Form2 frm = new Form2();
                    frm.label_Time_F2.Text = DateTime.Now.ToShortTimeString();
                    frm.label_Text_F2.Text = this.textBox_Mess.Text;
                    frm.ShowDialog();

                    this.Show();

                }
            }
        }

        private void checkBox_OnOff_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBox_OnOff.Checked)
            {
                numericUpDown_Hours.Enabled = false;
                numericUpDown_Min.Enabled = false;

                alarm = new DateTime(DateTime.Now.Year, DateTime.Now.Month,
                    DateTime.Now.Day, Convert.ToInt16(numericUpDown_Hours.Value),
                    Convert.ToInt16(numericUpDown_Min.Value), 0, 0);

                if (DateTime.Compare(DateTime.Now, alarm) > 0)
                    alarm = alarm.AddDays(1);

                notifyIcon1.Text = alarm.ToShortTimeString() + "\n" + textBox_Mess.Text;

                button_Safe.Enabled = true;
            }
            else
            {
                numericUpDown_Hours.Enabled = true;
                numericUpDown_Min.Enabled = true;

                notifyIcon1.Text = "Будильник не встановлено";

                button_Safe.Enabled = false;
            }
        }

        private void button_Safe_Click(object sender, EventArgs e)
        {
            this.Hide();
            notifyIcon1.Visible = true;
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (this.Visible)
                this.Hide();
            else
            {
                this.Show();
                notifyIcon1.Visible = false;
            }
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
