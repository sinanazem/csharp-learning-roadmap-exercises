namespace AgeRange
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox3.Text = "";
            label3.Text = "";
            textBox1.Focus();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "" && textBox3.Text != "")
            {
                int age = Convert.ToInt32(textBox3.Text);
                if (age >= 1 && age < 10)
                {
                    label3.Text = "Dear " + textBox1.Text + "\nyour age range is: Children";
                }
                else if (age >= 10 && age < 18)
                {
                    label3.Text = "Dear " + textBox1.Text + "\nyour age range is: Teenager";
                }
                else if (age >= 18 && age < 30)
                {
                    label3.Text = "Dear " + textBox1.Text + "\nyour age range is: Young Adults";
                }
                else if (age >= 30 && age < 60)
                {
                    label3.Text = "Dear " + textBox1.Text + "\nyour age range is: Middle-aged Adults";
                }
                else if (age >= 60 && age < 130)
                {
                    label3.Text = "Dear  " + textBox1.Text + "\nyour age range is: Old Adults";
                }
                else
                {
                    label3.Text = "Error: Age must be between 1-130";
                }
            }
            else
            {
                MessageBox.Show("Please Compleat textbox!");
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}