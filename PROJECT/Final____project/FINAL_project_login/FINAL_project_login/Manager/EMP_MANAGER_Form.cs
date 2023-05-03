using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FINAL_project_login.Manager
{
    
    public partial class EMP_MANAGER_Form : Form
    {
        Manager_Panel mp2;
        Loginpanel lp2;

        public EMP_MANAGER_Form()
        {
            InitializeComponent();
        }

        private void EMpADD_AdminS_button_Click(object sender, EventArgs e)
        {
           this.Hide();
            mp2 = new Manager_Panel();
            mp2.Show();
        }

        private void MGExit_button1_Click(object sender, EventArgs e)
        { 
            this.Hide();
            lp2 = new Loginpanel();
            lp2.Show();

        }

        private void EMP_MANAGER_Form_Load(object sender, EventArgs e)
        {

        }

        private void toolTip1_Popup(object sender, PopupEventArgs e)
        {

        }
    }
}
