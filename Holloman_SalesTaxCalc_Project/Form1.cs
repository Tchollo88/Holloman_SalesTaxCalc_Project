using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.AxHost;

namespace Holloman_SalesTaxCalc_Project
{
   /*
          Programming I - IT111  
          Todd Holloman                                 Holloman_SalesTaxCalc

          Comment - I had a lot of fun putting this together, it wav very interesting to work with 
          window designs forms and work it together to make this sales tax calculator. I wanted to 
          add a larger variety to the states and make it a little more like you would find into the
          world. At a later date I was planning on adding a cost change based on the type of vehicle 
          you choose, just need to do more research on the affect it would normmaly cause to the price 
          on an average.

          Let me know what you think of my code and program, 
          I really look forward to hear what you think.
   */

    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        /**Main Program**/

        //Key Press - not used
        private void txtPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
        
        }

        //Once presses exits program
        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


        //Clears all veriable in data fields
        private void btnClear_Click(object sender, EventArgs e)
        {
            if(
               txtPrice.Text != "" && 
               lstState.SelectedIndex != -1 && 
               cboVType.SelectedIndex != -1 && 
               cboWarranty.SelectedIndex != -1
              )
            {
                txtPrice.Text = "";
                lstState.SelectedIndex = -1;
                cboVType.SelectedIndex = -1;
                cboWarranty.SelectedIndex = -1;
                lblTotalln1.Text = "";
                lblTotalln2.Text = "";
            }
            else if(
                    txtPrice.Text == "" && 
                    lstState.SelectedIndex == -1 && 
                    cboVType.SelectedIndex == -1 && 
                    cboWarranty.SelectedIndex == -1
                   )
            {
                lblTotalln1.Text = "";
                lblTotalln2.Text = "";
            }
            else if (
                     txtPrice.Text != "" &&
                     lstState.SelectedIndex == -1 &&
                     cboVType.SelectedIndex == -1 &&
                     cboWarranty.SelectedIndex == -1 ||
                     txtPrice.Text == "" &&
                     lstState.SelectedIndex != -1 &&
                     cboVType.SelectedIndex == -1 &&
                     cboWarranty.SelectedIndex == -1 ||
                     txtPrice.Text == "" &&
                     lstState.SelectedIndex == -1 &&
                     cboVType.SelectedIndex != -1 &&
                     cboWarranty.SelectedIndex == -1 ||
                     txtPrice.Text == "" &&
                     lstState.SelectedIndex == -1 &&
                     cboVType.SelectedIndex == -1 &&
                     cboWarranty.SelectedIndex != -1
                    )
            {
                txtPrice.Text = "";
                lstState.SelectedIndex = -1;
                cboVType.SelectedIndex = -1;
                cboWarranty.SelectedIndex = -1;
                lblTotalln1.Text = "";
                lblTotalln2.Text = "";
            }
            else if(
                     txtPrice.Text != "" &&
                     lstState.SelectedIndex != -1 &&
                     cboVType.SelectedIndex == -1 &&
                     cboWarranty.SelectedIndex == -1 ||
                     txtPrice.Text != "" &&
                     lstState.SelectedIndex == -1 &&
                     cboVType.SelectedIndex != -1 &&
                     cboWarranty.SelectedIndex == -1 ||
                     txtPrice.Text != "" &&
                     lstState.SelectedIndex == -1 &&
                     cboVType.SelectedIndex == -1 &&
                     cboWarranty.SelectedIndex != -1 ||
                     txtPrice.Text == "" &&
                     lstState.SelectedIndex == -1 &&
                     cboVType.SelectedIndex != -1 &&
                     cboWarranty.SelectedIndex != -1 ||
                     txtPrice.Text == "" &&
                     lstState.SelectedIndex != -1 &&
                     cboVType.SelectedIndex == -1 &&
                     cboWarranty.SelectedIndex != -1 ||
                     txtPrice.Text == "" &&
                     lstState.SelectedIndex != -1 &&
                     cboVType.SelectedIndex != -1 &&
                     cboWarranty.SelectedIndex == -1
                   )
            {
                txtPrice.Text = "";
                lstState.SelectedIndex = -1;
                cboVType.SelectedIndex = -1;
                cboWarranty.SelectedIndex = -1;
                lblTotalln1.Text = "";
                lblTotalln2.Text = "";
            }
            else if(
                     txtPrice.Text != "" &&
                     lstState.SelectedIndex != -1 &&
                     cboVType.SelectedIndex != -1 &&
                     cboWarranty.SelectedIndex == -1 ||
                     txtPrice.Text != "" &&
                     lstState.SelectedIndex == -1 &&
                     cboVType.SelectedIndex != -1 &&
                     cboWarranty.SelectedIndex != -1 ||
                     txtPrice.Text != "" &&
                     lstState.SelectedIndex != -1 &&
                     cboVType.SelectedIndex == -1 &&
                     cboWarranty.SelectedIndex != -1 ||
                     txtPrice.Text == "" &&
                     lstState.SelectedIndex != -1 &&
                     cboVType.SelectedIndex != -1 &&
                     cboWarranty.SelectedIndex != -1
                   )
            {
                txtPrice.Text = "";
                lstState.SelectedIndex = -1;
                cboVType.SelectedIndex = -1;
                cboWarranty.SelectedIndex = -1;
                lblTotalln1.Text = "";
                lblTotalln2.Text = "";
            }
        }

        //Runs math, and builds sentence to state total calculations
        private void btnTotalCheck_Click(object sender, EventArgs e)
        {
            if (
                lstState.SelectedIndex != -1 &&
                cboVType.SelectedIndex != -1 &&
                cboWarranty.SelectedIndex != -1 &&
                txtPrice.Text != ""
               )
            {
                lblTotalln1.Text = "The chosen " + cboVType.SelectedItem.ToString() + " with ";
                lblTotalln2.Text = cboWarranty.SelectedItem.ToString() + " warranty, will cost " + PriceTotal(CalcPrice(price(), warrantyvalue()));
            }
            else if(
                    txtPrice.Text == "" &&
                    lstState.SelectedIndex == -1 &&
                    cboVType.SelectedIndex == -1 &&
                    cboWarranty.SelectedIndex == -1
                   )
            {
                lblTotalln1.Text = "The form is NOT filled out correctly, ";
                lblTotalln2.Text = "please re-evaluate the form and dill it in correctly.";
            }
            else if (
                     txtPrice.Text != "" &&
                     lstState.SelectedIndex == -1 &&
                     cboVType.SelectedIndex == -1 &&
                     cboWarranty.SelectedIndex == -1 ||
                     txtPrice.Text == "" &&
                     lstState.SelectedIndex != -1 &&
                     cboVType.SelectedIndex == -1 &&
                     cboWarranty.SelectedIndex == -1 ||
                     txtPrice.Text == "" &&
                     lstState.SelectedIndex == -1 &&
                     cboVType.SelectedIndex != -1 &&
                     cboWarranty.SelectedIndex == -1 ||
                     txtPrice.Text == "" &&
                     lstState.SelectedIndex == -1 &&
                     cboVType.SelectedIndex == -1 &&
                     cboWarranty.SelectedIndex != -1
                    )
            {
                lblTotalln1.Text = "The form is NOT filled out correctly, ";
                lblTotalln2.Text = "please re-evaluate the form and dill it in correctly.";
            }
            else if (
                     txtPrice.Text != "" &&
                     lstState.SelectedIndex != -1 &&
                     cboVType.SelectedIndex == -1 &&
                     cboWarranty.SelectedIndex == -1 ||
                     txtPrice.Text != "" &&
                     lstState.SelectedIndex == -1 &&
                     cboVType.SelectedIndex != -1 &&
                     cboWarranty.SelectedIndex == -1 ||
                     txtPrice.Text != "" &&
                     lstState.SelectedIndex == -1 &&
                     cboVType.SelectedIndex == -1 &&
                     cboWarranty.SelectedIndex != -1 ||
                     txtPrice.Text == "" &&
                     lstState.SelectedIndex == -1 &&
                     cboVType.SelectedIndex != -1 &&
                     cboWarranty.SelectedIndex != -1 ||
                     txtPrice.Text == "" &&
                     lstState.SelectedIndex != -1 &&
                     cboVType.SelectedIndex == -1 &&
                     cboWarranty.SelectedIndex != -1 ||
                     txtPrice.Text == "" &&
                     lstState.SelectedIndex != -1 &&
                     cboVType.SelectedIndex != -1 &&
                     cboWarranty.SelectedIndex == -1
                   )
            {
                lblTotalln1.Text = "The form is NOT filled out correctly, ";
                lblTotalln2.Text = "please re-evaluate the form and dill it in correctly.";
            }
            else if (
                     txtPrice.Text != "" &&
                     lstState.SelectedIndex != -1 &&
                     cboVType.SelectedIndex != -1 &&
                     cboWarranty.SelectedIndex == -1 ||
                     txtPrice.Text != "" &&
                     lstState.SelectedIndex == -1 &&
                     cboVType.SelectedIndex != -1 &&
                     cboWarranty.SelectedIndex != -1 ||
                     txtPrice.Text != "" &&
                     lstState.SelectedIndex != -1 &&
                     cboVType.SelectedIndex == -1 &&
                     cboWarranty.SelectedIndex != -1 ||
                     txtPrice.Text == "" &&
                     lstState.SelectedIndex != -1 &&
                     cboVType.SelectedIndex != -1 &&
                     cboWarranty.SelectedIndex != -1
                   )
            {
                lblTotalln1.Text = "The form is NOT filled out correctly, ";
                lblTotalln2.Text = "please re-evaluate the form and dill it in correctly.";
            }
        }


        /**Utilitarian Methods**/
        
        //Grabs user input for price
        public string price()
        {
            return txtPrice.Text;
        }

        //Adds warrenty costs to price, then calculates the total price
        public decimal CalcPrice(string price, decimal warranty)
        {
            decimal calcprice = 0m;
            decimal totalprice = 0m;
            decimal ncalcprice = 0m;
            decimal stax = 0m;

            calcprice = decimal.Parse(price);
            ncalcprice = calcprice + warranty; 

            if(lstState.SelectedIndex == 0)
            {
                stax = 7.25m;
                stax = (ncalcprice * stax) / 100m;

                stax = Trunc(stax);

                return totalprice = ncalcprice + stax;
            }
            if(lstState.SelectedIndex == 1)
            {
                stax = 1m;
                return totalprice = ncalcprice + stax;
            }
            if(lstState.SelectedIndex == 2)
            {
                stax = 4.7m;
                stax = (ncalcprice * stax) / 100m;

                stax = Trunc(stax);

                return totalprice = ncalcprice + stax;
            }
            if(lstState.SelectedIndex == 3)
            {
                stax = 8.6m;
                stax = (ncalcprice * stax) / 100m;

                stax = Trunc(stax);

                return totalprice = ncalcprice + stax;
            }
            if(lstState.SelectedIndex == 4)
            {
                stax = 4m;
                stax = (ncalcprice * stax) / 100m;

                stax = Trunc(stax);

                return totalprice = ncalcprice + stax;
            }
           
            return totalprice;
        }

        //Converts the calculated price into a currency string
        public string PriceTotal(decimal Cal)
        {
            string PriceTotal = Cal.ToString("C2");
            return PriceTotal;
        }

        //Truncates decimal value to the hundreths value
        public decimal Trunc(decimal stax)
        {
            stax = stax * 100;
            stax = Math.Truncate(stax);
            return stax = stax / 100;
        }

        //Builds the warranty value
        public decimal warrantyvalue()
        {
            decimal val = 0;
            if (cboWarranty.SelectedIndex == 0)
            {
                return val;
            }
            else if (cboWarranty.SelectedIndex == 1)
            {
                val = 1000m;
            }
            else if (cboWarranty.SelectedIndex == 2)
            {
                return val = 2000m;
            }
            else if (cboWarranty.SelectedIndex == 3)
            {
                return val = 3000m;
            }

            return val;
        }


    }

}


