using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
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



            DateTime currentTime = DateTime.Now;
            EMP_number.Text = "Current Time: " + currentTime.ToLongTimeString() + " " + currentTime.ToLongDateString();

            string connectionString = "Data Source=LUMARKIM;Initial Catalog=EMP_CRUD;Integrated Security=True";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                SqlCommand command = new SqlCommand("SELECT COUNT(*) FROM Admin_EMP2", connection);

                int count = (int)command.ExecuteScalar();

                Tmanagernum.Text = "Number Of Managers : " + count + "";

            }


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
            ef1 = new EmpForm();
            ef1.Show();
        }

        private void Taskbutton1_Click(object sender, EventArgs e)
        {
            this.Hide();
            tf = new TaskForm();
            tf.Show();

        }

        private void EMP_number_Click(object sender, EventArgs e)
        {

        }

        private void Manager_NumberCount_Click(object sender, EventArgs e)
        {



        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Tmanagernum_Click(object sender, EventArgs e)
        {
           

        }
    }
}
