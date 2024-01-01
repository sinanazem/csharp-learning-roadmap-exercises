namespace APWinForm2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txt_num1.Text == "" )
            {
                txt_num1.BackColor = Color.Red;
            }
            if(txt_num2.Text == "")
            {
                txt_num2.BackColor = Color.Red;
            }
            if (txt_num3.Text == "")
            {
                txt_num3.BackColor = Color.Red;
            }
            if (txt_num4.Text == "")
            {
                txt_num4.BackColor = Color.Red;
            }
            else
            {
                try
                {


                    double num1 = Convert.ToDouble(txt_num1.Text);
                    double num2 = Convert.ToDouble(txt_num2.Text);
                    double num3 = Convert.ToDouble(txt_num3.Text);
                    double num4 = Convert.ToDouble(txt_num4.Text);

                    double result = (num1 + num2 + num3 + num4) / 4;
                    label5.Text = result.ToString();
                    MessageBox.Show(result.ToString());
                }
                catch
                {
                    MessageBox.Show("Error your input must be number!");
                }

               
            }
            
        }
    }
}