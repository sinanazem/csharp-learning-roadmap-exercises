namespace Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            double num1, num2, result;
            num1 = Convert.ToDouble(textBox1.Text);
            num2 = Convert.ToDouble(textBox2.Text);

            result = num1 / num2;

            label3.Text = Convert.ToString(result);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            double num1, num2, result;
            num1 = Convert.ToDouble(textBox1.Text);
            num2 = Convert.ToDouble(textBox2.Text);

            result = num1 + num2;

            label3.Text = Convert.ToString(result);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            double num1, num2, result;
            num1 = Convert.ToDouble(textBox1.Text);
            num2 = Convert.ToDouble(textBox2.Text);

            result = num1 - num2;

            label3.Text = Convert.ToString(result);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            double num1, num2, result;
            num1 = Convert.ToDouble(textBox1.Text);
            num2 = Convert.ToDouble(textBox2.Text);

            result = num1 * num2;

            label3.Text = Convert.ToString(result);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label3.Text = "";
            textBox1.Text = "";
            textBox2.Text = "";
            textBox1.Focus();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox2.Text == "")
            {
                button3.Enabled = false;
                button4.Enabled = false;
                button5.Enabled = false;
                button6.Enabled = false;

            }
            else
            {
                button3.Enabled = true;
                button4.Enabled = true;
                button5.Enabled = true;
                button6.Enabled = true;
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            textBox1_TextChanged(null, null);
        }
    }
}