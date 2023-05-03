using FINAL_project_login.Manager;
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
    public partial class Manager_Panel : Form
    {
        Loginpanel l2;

        EMP_MANAGER_Form EmF2;
        Notice_panel np2;
        TaskForm tf2;
        Search_Panel sp2;
      
    
        public Manager_Panel()
        {
            InitializeComponent();
        }

        private void NoticeAdmin_button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            np2 = new Notice_panel();
            np2.Show();
        }

        private void Taskbutton1_Click(object sender, EventArgs e)
        {
           
        }

        private void SearchAdmin_button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            sp2 = new Search_Panel();
            sp2.Show();
        }

        private void ExitAdmin_button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            l2 = new Loginpanel();
            l2.Show();
        }

        private void EMpADD_AdminS_button_Click(object sender, EventArgs e)
        {
            this.Hide();
            EmF2 = new EMP_MANAGER_Form();
            EmF2.Show();
        }
    }
}
