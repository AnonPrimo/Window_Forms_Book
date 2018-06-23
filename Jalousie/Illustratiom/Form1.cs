using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Illustratiom
{
    public partial class Form1 : Form
    {
        int pbw, pbh, pbX, pbY;

        string aPath;

        public Form1()
        {
            InitializeComponent();

            pbh = pictureBox1.Height;
            pbw = pictureBox1.Width;
            pbX = pictureBox1.Location.X;
            pbY = pictureBox1.Location.Y;

            listBox1.Sorted = true;

            DirectoryInfo di;

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
