namespace CheckScoresTryCatch
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                double[] marks = new double[4];
                marks[0] = Convert.ToDouble(textBox1.Text);
                marks[1] = Convert.ToDouble(textBox2.Text);
                marks[2] = Convert.ToDouble(textBox3.Text);
                marks[3] = Convert.ToDouble(textBox4.Text);

                double sum = 0;
                for (int i = 0; i < marks.Length; i++)
                {
                    sum += marks[i];
                }

                double avg = sum / marks.Length;
                label7.Text = avg.ToString();
            }
            catch
            {
                MessageBox.Show("Error: your input must be a Nomber!");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox1.Focus();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}