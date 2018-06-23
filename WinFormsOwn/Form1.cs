using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsOwn
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("You click on button");
        }

        public void button1_Press(object sender, KeyPressEventArgs e)
        {
            MessageBox.Show("You press button");
        }

        public void button1_MouseClick(object sender, EventArgs e)
        {
            MessageBox.Show("You click on button by mouse");
        }

        public void button1_Move(object sender, MouseEventArgs e)
        {
            button1.BackColor = Color.Green;
            Console.WriteLine(" button1_Move");
        }

    }
}
