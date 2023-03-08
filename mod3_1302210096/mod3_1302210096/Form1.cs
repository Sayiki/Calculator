namespace mod3_1302210096
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int a;
        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == null)
            {
                textBox1.Text = "1";
            }
            else
            {
                textBox1.Text += "1";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == null)
            {
                textBox1.Text = "2";
            }
            else
            {
                textBox1.Text += "2";
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == null)
            {
                textBox1.Text = "3";
            }
            else
            {
                textBox1.Text += "3";
            }
        }


        private void button4_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == null)
            {
                textBox1.Text = "4";
            }
            else
            {
                textBox1.Text += "4";
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == null)
            {
                textBox1.Text = "5";
            }
            else
            {
                textBox1.Text += "5";
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == null)
            {
                textBox1.Text = "6";
            }
            else
            {
                textBox1.Text += "6";
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == null)
            {
                textBox1.Text = "7";
            }
            else
            {
                textBox1.Text += "7";
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == null)
            {
                textBox1.Text = "8";
            }
            else
            {
                textBox1.Text += "8";
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == null)
            {
                textBox1.Text = "9";
            }
            else
            {
                textBox1.Text += "9";
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == null)
            {
                textBox1.Text = "0";
            }
            else
            {
                textBox1.Text += "0";
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            int tempa = int.Parse(textBox1.Text);
            a += tempa;
  
            textBox1.Text = null;



        }

        private void button12_Click(object sender, EventArgs e)
        {
            String b = Convert.ToString(a);
            textBox1.Text = b;
        }
    }
}