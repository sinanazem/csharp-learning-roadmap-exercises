namespace MultiplicationTable
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double i, j, m;

            for (i = 1; i <= 10; i++)
            {
                for (j = 1; j <= 10; j++)
                {
                    m = i * j;
                    listView1.Items.Add(m.ToString());
                }
            }
        }
    }
}