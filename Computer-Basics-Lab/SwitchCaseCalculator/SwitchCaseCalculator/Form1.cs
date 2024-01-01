namespace SwitchCaseCalculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double num1 = Convert.ToDouble(textBox1.Text);
            double num2 = Convert.ToDouble(textBox2.Text);
            string op = textBox3.Text;

            switch (op)
            {
                case "+": label2.Text = Convert.ToString(num1 + num2); break;
                case "-": label2.Text = Convert.ToString(num1 - num2); break;
                case "*": label2.Text = Convert.ToString(num1 * num2); break;
                case "/": label2.Text = Convert.ToString(num1 / num2); break;
                default: label2.Text = "Acceptable Operations are (+, -, *, /)"; break;
            }


        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            label2.Text = "";
            textBox1.FindForm();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}