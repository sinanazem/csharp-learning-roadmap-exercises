namespace CompareSegment
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double Point1_x = Convert.ToDouble(textBox1.Text);
            double Point1_y = Convert.ToDouble(textBox2.Text);
            double Point2_x = Convert.ToDouble(textBox3.Text);
            double Point2_y = Convert.ToDouble(textBox4.Text);
            double Point3_x = Convert.ToDouble(textBox5.Text);
            double Point3_y = Convert.ToDouble(textBox6.Text);
            double Point4_x = Convert.ToDouble(textBox7.Text);
            double Point4_y = Convert.ToDouble(textBox8.Text);

            double segment21 = Math.Sqrt(Math.Pow(Point2_x - Point1_x, 2) + Math.Pow(Point2_y - Point1_y,2));
            double segment43 = Math.Sqrt(Math.Pow(Point3_x - Point4_x, 2) + Math.Pow(Point3_y - Point4_y, 2));

            if (segment43 > segment21)
            {
                label11.Text = "segment43 bigger than segment21";
            }
            else if (segment43 == segment21)
            {
                label11.Text = "segment21 equal segment43";
            }
            else
            {
                label11.Text = "segment21 bigger than segment43";
            }
        }
    }
}