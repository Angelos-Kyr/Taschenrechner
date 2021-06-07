using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calc
{
    public partial class frmTaschen : Form
    {
        private double zahlEins;
        private double zahlZwei;
        private string oper;

        public frmTaschen()
        {
            InitializeComponent();
        }

        private void btnGleich_Click(object sender, EventArgs e)
        {
            string eingabe = txtBxDisplay.Text;


            // 534+43534+6546+564
            var zahlen = eingabe.Split(oper.ToCharArray());
            zahlEins = Convert.ToDouble(zahlen[0]);
            zahlZwei = Convert.ToDouble(zahlen[1]);

            switch (oper)
            {
                case "+": txtBxDisplay.Text = (zahlEins + zahlZwei).ToString();break;
                case "*": txtBxDisplay.Text = (zahlEins * zahlZwei).ToString();break;
                case "-": txtBxDisplay.Text = (zahlEins - zahlZwei).ToString();break;
                case "/": txtBxDisplay.Text = (zahlEins / zahlZwei).ToString(); break;

                default:
                    txtBxDisplay.Text = "- - - FEHLER - - -";
                    break;
            }
        }

        private void btnNine_Click(object sender, EventArgs e)
        {
            txtBxDisplay.Text = txtBxDisplay.Text + "9";
            
        }

        private void btnEight_Click(object sender, EventArgs e)
        {
            txtBxDisplay.Text = txtBxDisplay.Text + "8";
        }

        private void btnSeven_Click(object sender, EventArgs e)
        {
            txtBxDisplay.Text = txtBxDisplay.Text + "7";
        }

        private void btnSix_Click(object sender, EventArgs e)
        {
            txtBxDisplay.Text = txtBxDisplay.Text + "6";
        }

        private void btnFive_Click(object sender, EventArgs e)
        {
            txtBxDisplay.Text = txtBxDisplay.Text + "5";
        }

        private void btnFour_Click(object sender, EventArgs e)
        {
            txtBxDisplay.Text = txtBxDisplay.Text + "4";
        }

        private void btnThree_Click(object sender, EventArgs e)
        {
            txtBxDisplay.Text = txtBxDisplay.Text + "3";
        }

        private void btnTwo_Click(object sender, EventArgs e)
        {
            txtBxDisplay.Text = txtBxDisplay.Text + "2";
        }

        private void btnOne_Click(object sender, EventArgs e)
        {
            txtBxDisplay.Text = txtBxDisplay.Text + "1";
        }

        private void btnZero_Click(object sender, EventArgs e)
        {
            txtBxDisplay.Text = txtBxDisplay.Text + "0";
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtBxDisplay.Text = "";
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            oper = "+";
            txtBxDisplay.Text = txtBxDisplay.Text + "+";
        }

        private void btnSub_Click(object sender, EventArgs e)
        {
            oper = "-";
            txtBxDisplay.Text = txtBxDisplay.Text + "-";
        }

        private void btnMult_Click(object sender, EventArgs e)
        {
            oper = "*";
            txtBxDisplay.Text = txtBxDisplay.Text + "*";
        }

        private void btnDiv_Click(object sender, EventArgs e)
        {
            oper = "/";
            txtBxDisplay.Text = txtBxDisplay.Text + "+"; 
        }
    }
}



////////////////////////////
/*
  using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calc
{
    public partial class frmTaschen : Form
    {
        private string eingabeEins;
        private string eingabeZwei;
        private double zahlEins;
        private double zahlZwei;
        private string oper;

        public frmTaschen()
        {
            InitializeComponent();
        }

        private void btnGleich_Click(object sender, EventArgs e)
        {
            eingabeZwei = txtBxDisplay.Text;
            zahlZwei = Convert.ToDouble(eingabeZwei);
            zahlEins = Convert.ToDouble(eingabeEins);

            switch (oper)
            {
                case "+": txtBxDisplay.Text = (zahlEins + zahlZwei).ToString();break;
                case "*": txtBxDisplay.Text = (zahlEins * zahlZwei).ToString();break;
                case "-": txtBxDisplay.Text = (zahlEins - zahlZwei).ToString();break;
                case "/": txtBxDisplay.Text = (zahlEins / zahlZwei).ToString(); break;

                default:
                    txtBxDisplay.Text = "- - - FEHLER - - -";
                    break;
            }
        }

        private void btnNine_Click(object sender, EventArgs e)
        {
            txtBxDisplay.Text = txtBxDisplay.Text + "9";
            
        }

        private void btnEight_Click(object sender, EventArgs e)
        {
            txtBxDisplay.Text = txtBxDisplay.Text + "8";
        }

        private void btnSeven_Click(object sender, EventArgs e)
        {
            txtBxDisplay.Text = txtBxDisplay.Text + "7";
        }

        private void btnSix_Click(object sender, EventArgs e)
        {
            txtBxDisplay.Text = txtBxDisplay.Text + "6";
        }

        private void btnFive_Click(object sender, EventArgs e)
        {
            txtBxDisplay.Text = txtBxDisplay.Text + "5";
        }

        private void btnFour_Click(object sender, EventArgs e)
        {
            txtBxDisplay.Text = txtBxDisplay.Text + "4";
        }

        private void btnThree_Click(object sender, EventArgs e)
        {
            txtBxDisplay.Text = txtBxDisplay.Text + "3";
        }

        private void btnTwo_Click(object sender, EventArgs e)
        {
            txtBxDisplay.Text = txtBxDisplay.Text + "2";
        }

        private void btnOne_Click(object sender, EventArgs e)
        {
            txtBxDisplay.Text = txtBxDisplay.Text + "1";
        }

        private void btnZero_Click(object sender, EventArgs e)
        {
            txtBxDisplay.Text = txtBxDisplay.Text + "0";
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtBxDisplay.Text = "";
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            eingabeEins = txtBxDisplay.Text;
            oper = "+";
            txtBxDisplay.Text = "";
        }

        private void btnSub_Click(object sender, EventArgs e)
        {
            eingabeEins = txtBxDisplay.Text;
            oper = "-";
            txtBxDisplay.Text = "";
        }

        private void btnMult_Click(object sender, EventArgs e)
        {
            eingabeEins = txtBxDisplay.Text;
            oper = "*";
            txtBxDisplay.Text = "";
        }

        private void btnDiv_Click(object sender, EventArgs e)
        {
            eingabeEins = txtBxDisplay.Text;
            oper = "/";
            txtBxDisplay.Text = "";
        }
    }
}
 
 */