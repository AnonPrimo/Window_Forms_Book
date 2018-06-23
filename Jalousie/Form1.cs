using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Jalousie
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;

            string[] ar = { "пластик", "алюміній", "бамбук", "соломка", "текстиль" };

            List<String> s = new List<string>();
            s.Add("пластик");
            s.Add("алюміній");
            s.Add("бамбук");
            s.Add("соломка");
            s.Add("текстиль");

           comboBox1.DataSource = s;

           // comboBox1.Items.AddRange(ar);
            
            comboBox1.SelectedIndex = 0;
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar >= '0' && e.KeyChar <= '9')
                return;

            if(Char.IsControl(e.KeyChar))
            {
                if(e.KeyChar == (char)Keys.Enter)
                {
                    if (sender.Equals(textBox1))
                        textBox2.Focus();
                    else
                        comboBox1.Focus();
                }
                return;
            }
            e.Handled = true;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text.Length == 0 || textBox2.Text.Length == 0)
                button1.Enabled = false;
            else 
                button1.Enabled = true;
            label4.Text = "";
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            label4.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double w;
            double h;
            double cena = 0;
            double sum;

            w = Convert.ToDouble(textBox1.Text);
            h = Convert.ToDouble(textBox2.Text);

            switch(comboBox1.SelectedIndex)
            {
                case 0: cena = 50; break;
                case 1: cena = 100; break;
                case 2: cena = 75; break;
                case 3: cena = 70; break;
                case 4: cena = 60; break;
            }

            sum = (w * h) / 10000 * cena;
            label4.Text = "Розмір" + w + "х" + h + "см.\n" + "Ціна (р./м.кв.): " + cena.ToString("c") + "\nСума: " + sum.ToString("c");
        }

      
    }
}
