using Microsoft.VisualBasic;

namespace FINAL_project_login
{
    public partial class Loginpanel : Form
    {
        Admin_panel A1;
        public Loginpanel()
        {
            InitializeComponent();
        }

        private void Login_textbox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Username_textbox1_Click(object sender, EventArgs e)
        {

        }

        private void Login_textbox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Password_textbox2.UseSystemPasswordChar = true;

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Exit_button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Login_button_Click(object sender, EventArgs e)
        {
           

            if ((UserName_textbox1.Text == "Admin") &&( Password_textbox2.Text == "Admin"))
            {
                this.Hide();
                A1 = new Admin_panel();
                A1.Show();

            }
            else
            {
                MessageBox.Show("Wrong password!");
            }


        }

        private void Login_textbox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void Login_textbox2_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void Registration_button_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void checkBox_showpassword_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBox_showpassword.Checked)
            {
                Password_textbox2.UseSystemPasswordChar = false;
            }
            else
            {
                Password_textbox2.UseSystemPasswordChar=true;
            }
        }
    }

        
}