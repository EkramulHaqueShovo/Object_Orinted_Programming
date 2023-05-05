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
    public partial class TaskForm : Form
    {
        EmpForm e1;
        Search_Panel s1;
        Notice_panel n1;
        Loginpanel n2;
        Admin_panel np2;
        public TaskForm()
        {
            InitializeComponent();
        }

        private void EMpAdmin_button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            e1 = new EmpForm();
            e1.Show();

        }

        private void SearchAdmin_button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            s1 = new Search_Panel();
            s1.Show();

        }

        private void NoticeAdmin_button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            n1 = new Notice_panel();
            n1.Show();

        }

        private void ExitAdmin_button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            n2 = new Loginpanel();
            n2.Show();
        }

        private void HomeAdminS_button_Click(object sender, EventArgs e)
        {
            this.Hide();
            np2 = new Admin_panel();
            np2.Show();
        }
    }
}
