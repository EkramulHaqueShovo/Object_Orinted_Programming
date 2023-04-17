using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Grade_Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void CalculateButton_Click(object sender, EventArgs e)
        {
            if(!int.TryParse(testScoreTextBox.Text, out int testScore))
            {
                MessageBox.Show("invalid test score. please enter valid test score!");
                return;
            }
            string grade;
            if(testScore>=95)
            {
                grade = "A+";

            }
            else if (testScore>=90)
            {
                grade = "A";
            }
            else if(testScore>=80){

                grade = "B";
            }
            else if(testScore>=70){
                grade = "C";

            }
            else if (testScore >= 60)
            {
                grade = "D";
            }
            else
            {
                grade = "F";
            }
            MessageBox.Show($"your Grade is {grade}");

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
