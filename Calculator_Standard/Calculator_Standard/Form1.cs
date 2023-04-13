using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Calculator_Standard
{
    public partial class Form1 : Form
    {


        public Form1()
        {
            InitializeComponent();
        }
        float num, ans;
        int count;
        public void disable()
        {
            textBoxOut.Enabled = false;
            b0.Enabled = false;
            b1.Enabled = false;
            b2.Enabled = false;
            b3.Enabled = false;
            b4.Enabled = false;
            b6.Enabled = false;
            b7.Enabled = false;
            b8.Enabled = false;
            b9.Enabled = false;
            div.Enabled = false;
            mal.Enabled = false;
            sub.Enabled = false;
            add.Enabled = false;
            backspace.Enabled = false;
            point.Enabled = false;
            clear.Enabled = false;
            result.Enabled = false;




        }

        public void enable()
        {
            textBoxOut.Enabled = true;
            b0.Enabled = true;
            b1.Enabled = true;
            b2.Enabled = true;
            b3.Enabled = true;
            b4.Enabled = true;
            b5.Enabled = true;
            b6.Enabled = true;
            b7.Enabled = true;
            b8.Enabled = true;
            b9.Enabled = true;
            add.Enabled = true;
            clear.Enabled = true;
            backspace.Enabled = true;
            result.Enabled = true;
            div.Enabled = true;
            sub.Enabled = true;
            mal.Enabled = true;
            point.Enabled = true;
        }


        private void button_Click(object sender, EventArgs e)
        {

        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void CB3_Click(object sender, EventArgs e)
        {
            textBoxOut.Text = "";
        }

        private void CB2_Click(object sender, EventArgs e)
        {

        }

        private void button17_Click(object sender, EventArgs e)
        {
            compute();
            label1.Text = "";
        }

        private void b9_Click(object sender, EventArgs e)
        {
            textBoxOut.Text = textBoxOut.Text + 9;
        }

        private void button7_Click(object sender, EventArgs e)
        {

            textBoxOut.Text = textBoxOut.Text + 8;

        }

        private void button8_Click(object sender, EventArgs e)
        {

            textBoxOut.Text = textBoxOut.Text + 7;
        }

        private void button10_Click(object sender, EventArgs e)
        {

            textBoxOut.Text = textBoxOut.Text + 6;
        }

        private void button11_Click(object sender, EventArgs e)
        {

            textBoxOut.Text = textBoxOut.Text + 5;
        }

        private void button12_Click(object sender, EventArgs e)
        {

            textBoxOut.Text = textBoxOut.Text + 4;
        }

        private void button14_Click(object sender, EventArgs e)
        {

            textBoxOut.Text = textBoxOut.Text + 3;
        }

        private void button15_Click(object sender, EventArgs e)
        {

            textBoxOut.Text = textBoxOut.Text + 2;
        }

        private void button16_Click(object sender, EventArgs e)
        {

            textBoxOut.Text = textBoxOut.Text + 1;
        }

        private void button19_Click(object sender, EventArgs e)
        {

            textBoxOut.Text = textBoxOut.Text + 0;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            num = float.Parse(textBoxOut.Text);
            textBoxOut.Clear();
            textBoxOut.Focus();
            count = 2;
            label1.Text = num.ToString() + "-";
        }

        private void add_Click(object sender, EventArgs e)
        {
            num = float.Parse(textBoxOut.Text);
            textBoxOut.Clear();
            textBoxOut.Focus();
            count = 1;
            label1.Text = num.ToString() + "+";

        }

        private void div_Click(object sender, EventArgs e)
        {
            num = float.Parse(textBoxOut.Text);
            textBoxOut.Clear();
            textBoxOut.Focus();
            count = 4;
            label1.Text = num.ToString() + "/";

        }

        private void mal_Click(object sender, EventArgs e)
        {
            num = float.Parse(textBoxOut.Text);
            textBoxOut.Clear();
            textBoxOut.Focus();
            count = 3;
            label1.Text = num.ToString() + "*";
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        public void compute()
        {
            switch (count)
            {
                case 1:

                    ans = num + float.Parse(textBoxOut.Text);
                    textBoxOut.Text = ans.ToString();
                    break;
                case 2:
                    ans = num - float.Parse(textBoxOut.Text);
                    textBoxOut.Text = ans.ToString();
                    break;
                case 3:
                    ans = num * float.Parse(textBoxOut.Text);
                    textBoxOut.Text = ans.ToString();
                    break;
                case 4:
                    ans = num / float.Parse(textBoxOut.Text);
                    textBoxOut.Text = ans.ToString();
                    break;
                default:
                    break;


            }
        }
    }
}
