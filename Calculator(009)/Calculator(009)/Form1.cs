using System.Windows.Forms.VisualStyles;

namespace Calculator_009_
{
    public partial class Form1 : Form
    {
        String num1;
        String num2;
        String op;
        bool n=false;
        public Form1()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (n == true)
            {
                textBox1.Clear();
                textBox1.Text = textBox1.Text + "9";
            }
            else
            {
                textBox1.Text = textBox1.Text + "9";
            }
        }
        private void button11_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "1";
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "8";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            
                textBox1.Text = textBox1.Text + "7";
            
        }

        private void button6_Click(object sender, EventArgs e)
        {
            
                textBox1.Text = textBox1.Text + "6";
            
        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "5";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "4";
        }
        private void button9_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "3";
        }

        private void button10_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "2";
        }

        private void button14_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "0";
        }

        private void button15_Click(object sender, EventArgs e)
        {
            num1 = textBox1.Text;
            textBox1.Clear();
            op = "add";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            n = true;
            num2 = textBox1.Text;
            double b = double.Parse(num2);
            double d = (b * (Math.PI)) / 180;
            if (op == "sin")
            {
                
                double f = Math.Sin(b);
                textBox1.Text = f.ToString();
            }
            else if(op == "cos") {
                double f = Math.Cos(b);
                textBox1.Text = f.ToString();
            }
            else
            {

                double a = double.Parse(num1);


                if (op == "add")
                {

                    double sum = a + b;
                    textBox1.Text = sum.ToString();
                }


                else if (op == "sub")
                {
                    double sum = a - b;
                    textBox1.Text = sum.ToString();
                }
                else if (op == "mul")
                {
                    double sum = a * b;
                    textBox1.Text = sum.ToString();
                }
                else if (op == "div")
                {
                    double sum = a / b;
                    textBox1.Text = sum.ToString();
                }

                else
                {
                    textBox1.Text = "Press Valid Keys";
                }

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            num2 = "";
            num1 = "";
            op = "";
        }

        private void button16_Click(object sender, EventArgs e)
        {
            num1 = textBox1.Text;
            textBox1.Clear();
            op = "sub";
        }

        private void button17_Click(object sender, EventArgs e)
        {
            num1 = textBox1.Text;
            textBox1.Clear();
            op = "mul";
        }

        private void button12_Click(object sender, EventArgs e)
        {

        }

        private void button18_Click(object sender, EventArgs e)
        {
            num1 = textBox1.Text;
            textBox1.Clear();
            op = "div";
        }

        private void button13_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            op = "sin";
        }

        private void button19_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            op = "cos";
        }
    }
}