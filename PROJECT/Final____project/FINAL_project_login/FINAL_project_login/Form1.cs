using Microsoft.VisualBasic;

namespace FINAL_project_login
{
    public partial class Loginpanel : Form
    {
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
           
            if(UserName_textbox1.Text!=" " && Password_textbox2.Text!="" ) {
                UserName_textbox1.Clear();
                Password_textbox2.Clear();
                MessageBox.Show("Submitted");
            
            }
        }

        private void Login_textbox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void Login_textbox2_TextChanged_1(object sender, EventArgs e)
        {

        }
    }

        
}