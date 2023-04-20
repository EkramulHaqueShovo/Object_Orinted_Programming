using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FINAL_project_login
{
    public partial class Search_Panel : Form
    {
        Admin_panel a1;
        Loginpanel l1;
        Notice_panel np1;
        EmpForm ep1;
        public Search_Panel()
        {
            InitializeComponent();
        }

        private void SearchAdmin_button1_Click(object sender, EventArgs e)
        {

        }

       

        private void ExitAdmin_button1_Click(object sender, EventArgs e)
        {

            this.Hide();
            l1 = new Loginpanel();
            l1.Show();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Search_Panel_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            a1 = new Admin_panel();
            a1.Show();
        }

        private void HomeAdminS_button_Click(object sender, EventArgs e)
        {
            this.Hide();
            a1=new Admin_panel();
            a1.Show();
        }

        private void NoticeS_button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            np1 = new Notice_panel();
            np1.Show();
        }

        private void EMpS_button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            ep1 = new EmpForm();
            ep1.Show();
        }
    }
}
