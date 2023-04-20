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
    public partial class Admin_panel : Form
    {
        Loginpanel l1;
        Search_Panel s1;
        Notice_panel np1;
        EmpForm ef1;
        TaskForm tf;
        public Admin_panel()
        {
            InitializeComponent();
        }

        private void Exit_button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            l1 = new Loginpanel();
            l1.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           

        }

      

        private void Admin_panel_Load(object sender, EventArgs e)
        {

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
            np1 = new Notice_panel();
            np1.Show();
        }

        private void EMpAdmin_button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            ef1= new EmpForm();
            ef1.Show();
        }

        private void Taskbutton1_Click(object sender, EventArgs e)
        {
            this.Hide();
            tf = new TaskForm();
            tf.Show();

        }
    }
}
