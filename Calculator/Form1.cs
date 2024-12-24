using System.Runtime.CompilerServices;

namespace Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string x = "";
        string y = "";
        bool ymode = false;
        string mode = "";
        private void button1_Click(object sender, EventArgs e)
        {
            if (ymode == false)
            {
                x = x + "1";
                label1.Text = x;
            }
            else
            {
                y = y + "1";
                label1.Text = y;
            }
        }


        private void button11_Click(object sender, EventArgs e)
        {
            if (ymode == true && y != "" && mode != "")
            {
                if (mode == "+")
                {
                    x = Convert.ToString(decimal.Parse(x) + decimal.Parse(y));
                    label1.Text = x;
                    y = "";
                    ymode = false;
                    mode = "";
                }
                if (mode == "-")
                {
                    x = Convert.ToString(decimal.Parse(x) - decimal.Parse(y));
                    label1.Text = x;
                    y = "";
                    ymode = false;
                    mode = "";
                }
                if (mode == "x")
                {
                    x = Convert.ToString(decimal.Parse(x) * decimal.Parse(y));
                    label1.Text = x;
                    y = "";
                    ymode = false;
                    mode = "";
                }
                if (mode == "/")
                {
                    x = Convert.ToString(decimal.Parse(x) / decimal.Parse(y));
                    label1.Text = x;
                    y = "";
                    ymode = false;
                    mode = "";
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (ymode == false)
            {
                x = x + "2";
                label1.Text = x;
            }
            else
            {
                y = y + "2";
                label1.Text = y;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (ymode == false)
            {
                x = x + "3";
                label1.Text = x;
            }
            else
            {
                y = y + "3";
                label1.Text = y;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (ymode == false)
            {
                x = x + "4";
                label1.Text = x;
            }
            else
            {
                y = y + "4";
                label1.Text = y;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (ymode == false)
            {
                x = x + "5";
                label1.Text = x;
            }
            else
            {
                y = y + "5";
                label1.Text = y;
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (ymode == false)
            {
                x = x + "6";
                label1.Text = x;
            }
            else
            {
                y = y + "6";
                label1.Text = y;
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (ymode == false)
            {
                x = x + "7";
                label1.Text = x;
            }
            else
            {
                y = y + "7";
                label1.Text = y;
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (ymode == false)
            {
                x = x + "8";
                label1.Text = x;
            }
            else
            {
                y = y + "8";
                label1.Text = y;
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (ymode == false)
            {
                x = x + "9";
                label1.Text = x;
            }
            else
            {
                y = y + "9";
                label1.Text = y;
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (ymode == false)
            {
                x = x + "0";
                label1.Text = x;
            }
            else
            {
                y = y + "0";
                label1.Text = y;
            }
        }

        private void button12_Click(object sender, EventArgs e)
        {
            if (ymode == false)
            {
                if (x.Length != 0)
                {
                    x = x.Remove(x.Length - 1);
                }
                if (x.Length == 0) { x = ""; }
                label1.Text = x;
            }
            else
            {
                if (y.Length != 0)
                {
                    y = y.Remove(y.Length - 1);
                }
                if (y.Length == 0) { y = ""; }
                label1.Text = y;
            }
        }
        private void button16_Click(object sender, EventArgs e)
        {
            if (ymode == false && x != "")
            {
                label1.Text = "+";
                ymode = true;
                mode = "+";
            }
        }

        private void button17_Click(object sender, EventArgs e)
        {
            x = "";
            y = "";
            ymode = false;
            mode = "";
            label1.Text = "";
        }

        private void button15_Click(object sender, EventArgs e)
        {
            if (ymode == false && x != "")
            {
                label1.Text = "-";
                ymode = true;
                mode = "-";
            }
        }

        private void button14_Click(object sender, EventArgs e)
        {
            if (ymode == false && x != "")
            {
                label1.Text = "x";
                ymode = true;
                mode = "x";
            }
        }

        private void button13_Click(object sender, EventArgs e)
        {
            if (ymode == false && x != "")
            {
                label1.Text = "/";
                ymode = true;
                mode = "/";
            }
        }

        private void button18_Click(object sender, EventArgs e)
        {
            if (ymode == false)
            {
                x = x + ".";
                label1.Text = x;
            }
            else
            {
                y = y + ".";
                label1.Text = y;
            }
        }

        private void button19_Click(object sender, EventArgs e)
        {
            if (ymode == false)
            {
                x = x + "-";
                label1.Text = x;
            }
            else
            {
                y = y + "-";
                label1.Text = y;
            }
        }
    }
}
