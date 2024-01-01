namespace BestBooks
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string[] books = new string[3];

            books[0] = Convert.ToString(textBox1.Text);
            books[1] = Convert.ToString(textBox4.Text);
            books[2] = Convert.ToString(textBox5.Text);

            foreach (string s in books)
            {
                MessageBox.Show(s, "Books Check");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            textBox1.Focus();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}