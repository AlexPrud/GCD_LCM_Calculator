using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GCD_LCM_Calculator
{
    public partial class Form1 : Form
    {

        private long Pgcd(long a, long b)
        {
            if (a == 0 && b == 0) return 1;
            if (b == 0) return a;
            return Pgcd(b, a % b);
        }

        private long Ppcm(long a, long b)
        {
            return checked(a * b / Pgcd(a, b));
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {

            textBox3.Text = "";
            textBox4.Text = "";

            try
            {
                long a = long.Parse(textBox1.Text);
                long b = long.Parse(textBox2.Text);
                textBox3.Text = Pgcd(a, b).ToString();
                textBox4.Text = Ppcm(a, b).ToString();
            }
            catch (FormatException) { }
            catch (OverflowException)
            {
                textBox4.Text = "Too big";
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
              sumButton.PerformClick();
            }
        }

        private void textBox2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                sumButton.PerformClick();
            }
        }
    }
}
