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
    
    public partial class EmpForm : Form
    {
        Search_Panel sp1;
        Admin_panel ap1;
        Notice_panel np1;
        Loginpanel lp1;
        public EmpForm()
        {
            InitializeComponent();
        }

        private void SearchAdmin_button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            sp1= new Search_Panel();
            sp1.Show(this);

        }

        private void HomeAdminS_button_Click(object sender, EventArgs e)
        {
            this.Hide();
            ap1= new Admin_panel();
            ap1.Show(this);

        }

        private void NoticeAdmin_button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            np1 = new Notice_panel();
            np1.Show(this); 


        }

        private void ExitAdmin_button1_Click(object sender, EventArgs e)
        {

            this.Hide();
            lp1= new Loginpanel();
            lp1.Show(this);
        }
    }
}
