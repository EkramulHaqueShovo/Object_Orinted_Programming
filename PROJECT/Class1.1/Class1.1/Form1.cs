namespace Class1._1
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

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            if(textBox1.Text != ""&& textBox2.Text != "")
            {
                double num1 = double.Parse(textBox1.Text);
                double num2 = double.Parse(textBox2.Text);
                double result = num1 + num2;
                textBox3.Text = result.ToString();
                button1.BackColor = Color.Red;
                MessageBox.Show("application submitted !");

            }
            else
            {
                MessageBox.Show("applicaation not submitted!");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "" && textBox2.Text != "")
            {
                double num1 = double.Parse(textBox1.Text);
                double num2 = double.Parse(textBox2.Text);
                double result = num1 - num2;
                textBox3.Text = result.ToString();
                button2.BackColor = Color.Red;
                // MessageBox.Show("application submitted !");
                MessageBox.Show(result.ToString());

            }
            else
            {
                MessageBox.Show("applicaation not submitted!");
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "" && textBox2.Text != "")
            {
                double num1 = double.Parse(textBox1.Text);
                double num2 = double.Parse(textBox2.Text);
                double result = num1 * num2;
                textBox3.Text = result.ToString();
                button3.BackColor = Color.Red;
               // MessageBox.Show("application submitted !");
                MessageBox.Show(result.ToString());

            }
            else
            {
                MessageBox.Show("applicaation not submitted!");
            }

        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "" && textBox2.Text != "")
            {
                double num1 = double.Parse(textBox1.Text);
                double num2 = double.Parse(textBox2.Text);
                double result = num1 /num2;
                textBox3.Text = result.ToString();
                button4.BackColor = Color.Red;
                //MessageBox.Show("application submitted !");
                MessageBox.Show(result.ToString());

            }
            else
            {
                MessageBox.Show("applicaation not submitted!");
            }

        }
    }
}