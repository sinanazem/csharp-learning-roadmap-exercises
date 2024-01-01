namespace DivisibleApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            int num1 = Convert.ToInt32(textBox1.Text);
            int num2 = Convert.ToInt32(textBox2.Text);

            for (int i = num1; i < num2; i++)
            {
                listBox1.Items.Add(i.ToString());
            }

            for (int i = num1; i < num2; i++)
            {
                if (i % 3 == 0)
                {
                    listBox2.Items.Add(i.ToString());
                }

            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = string.Empty;
            textBox2.Text = string.Empty;
            listBox1.Items.Clear();
            listBox2.Items.Clear();
            textBox1.Focus();
        }
    }
}