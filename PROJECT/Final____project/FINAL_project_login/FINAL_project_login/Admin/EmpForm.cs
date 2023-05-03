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

        private void Admin_insert_Click(object sender, EventArgs e)
        {

          

            SqlConnection con = new SqlConnection("Data Source=LUMARKIM;Initial Catalog=EMP_CRUD;Integrated Security=True");
            con.Open();

            SqlCommand command = new SqlCommand("INSERT INTO Admin_EMP2 VALUES (@AdminName, @AdminId, @AdminDateTimePicker1, @AdminPhoneNumber, @AdminDepartment, @AdminSalary, @AdminPassword)", con);

            command.Parameters.AddWithValue("@AdminName", Admin_Name.Text);
            command.Parameters.AddWithValue("@AdminId", int.Parse(Admin_id.Text));
            command.Parameters.AddWithValue("@AdminDateTimePicker1", Admin_dateTimePicker1.Text);
            command.Parameters.AddWithValue("@AdminPhoneNumber", int.Parse(Admin_Phonenumber.Text));
            command.Parameters.AddWithValue("@AdminDepartment", Admindepartment_comboBox1.Text);
            command.Parameters.AddWithValue("@AdminSalary", int.Parse(Admin_salary.Text));
            command.Parameters.AddWithValue("@AdminPassword", Admin_Emp_passwordtextBox1.Text);

            command.ExecuteNonQuery();
            MessageBox.Show("Insert Successfully!");
            con.Close();





        }
    }
}
