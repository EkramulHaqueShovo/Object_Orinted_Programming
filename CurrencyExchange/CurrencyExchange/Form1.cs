using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CurrencyExchange
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox_Input_TextChanged(object sender, EventArgs e)
        {
            if(double.TryParse(textBox_Input.Text,out double bdt))
            {
                double usd = bdt / 105.5;
                double eur = bdt / 99.8;
                double gbp = bdt / 117.5;
                double ind = bdt / 1.29;
                double nep = bdt / 0.81;
                double pkt = bdt / 1.23;

                USD_label.Text = usd.ToString("N2");
                EUR_label.Text = eur.ToString("N2");
                GBP_label.Text = gbp.ToString("N2");
                indi_label2.Text = ind.ToString("N2");
                Nepal_label3.Text = nep.ToString("N2");
                Pakistani_label.Text = pkt.ToString("N2");


            }
            else
            {
                USD_label.Text = "";
                EUR_label.Text = "";
                GBP_label.Text = "";
                indi_label2.Text = "";
                Nepal_label3.Text = "";
                Pakistani_label.Text = " ";
            }
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void EUR_label_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
