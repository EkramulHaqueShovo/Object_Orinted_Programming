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
    public partial class Notice_panel : Form
    {
        Loginpanel l1;
        Admin_panel ap1;
        Search_Panel sp1;
        EmpForm ep1;
        public Notice_panel()
        {
            InitializeComponent();
        }

        private void ExitAdmin_button1_Click(object sender, EventArgs e)
        {

            this.Hide();
            l1 = new Loginpanel();
            l1.Show();
        }

        private void Back_button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            ap1 = new Admin_panel();
            ap1.Show();

        }

        private void NoticeS_button1_Click(object sender, EventArgs e)
        {

        }

        private void SearchAdmin_button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            sp1= new Search_Panel();
            sp1.Show();
        }

        private void HomeAdminS_button_Click(object sender, EventArgs e)
        {
            this.Hide();
            ap1=new Admin_panel();
            ap1.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void EMpS_button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            ep1 = new EmpForm();
            ep1.Show();
            
        }
    }
}
