using System.Runtime.CompilerServices;

namespace Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        string x;
        string y;
        bool ymode = false;
        private void button1_Click(object sender, EventArgs e)
        {
            if (ymode == false)
            {
                x = x + "1";
                label1.Text = x;
            } else
            {
                y = y + "1";
                label1.Text = x;
            }
        }


        private void button11_Click(object sender, EventArgs e)
        {
            label1.Text = x;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            x = x + "2";
            label1.Text = x;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            x = x + "3";
            label1.Text = x;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            x = x + "4";
            label1.Text = x;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            x = x + "5";
            label1.Text = x;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            x = x + "6";
            label1.Text = x;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            x = x + "7";
            label1.Text = x;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            x = x + "8";
            label1.Text = x;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            x = x + "9";
            label1.Text = x;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            x = x + "0";
            label1.Text=x;
        }

        private void button12_Click(object sender, EventArgs e)
        {
            if (x.Length != 0)
            {
                x = x.Remove(x.Length - 1);
            }
            if (x.Length == 0) { x = ""; }
            label1.Text = x;
        }
    }
}
