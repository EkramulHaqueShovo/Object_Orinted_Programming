﻿using System;
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
            this.Hide();
            l1 = new Loginpanel();
            l1.Show();

        }
    }
}
