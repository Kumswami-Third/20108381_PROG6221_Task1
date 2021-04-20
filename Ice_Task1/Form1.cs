using BudgetApp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ice_Task1
{
    public partial class BudgetForm : Form
    {
        bool allCorrect = true; // boolean used to check all label inputs are in correct format
        int currentExpense = 0; // index used to store how many users have used the app during run time. Used for displaying from list
        
        
        public BudgetForm()
        {
            InitializeComponent();
            this.MaximizeBox = false;
            
        }

        private void txbInput_TextChanged(object sender, EventArgs e)
        {
           allCorrect = Validation.validateCurrency(lblGrossIncAlert,txbGrossMonInc.Text); 
            //validates label input. All labels that use the "Validation.ValidateCurrency" do this aswell
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (rbBuy.Checked == true) // checks if buying rb is selected and makes gui visibility adjustments
            {
                pnlRentProperty.Visible = false;
                pnlBuyProperty.Visible = true;
            }
            else
            {
                txbPropPrice.Text = "";
                lblPropertyPriceAlert.Text = "";
                txbTotDeposit.Text = "";
                lblTotDepositAlert.Text = "";
                numericUpDownInterestRate.Value = 0;
                numericUpDownMonRepay.Value = 240;
                pnlBuyProperty.Visible = false;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void lblOtherAlert_Click(object sender, EventArgs e)
        {

        }

        private void txbTaxDed_TextChanged(object sender, EventArgs e)
        {
            allCorrect = Validation.validateCurrency(lblMonthlyDeductAlert, txbTaxDed.Text);
        }

        private void txbGroc_TextChanged(object sender, EventArgs e)
        {
            allCorrect = Validation.validateCurrency(lblGroceriesAlert, txbGroc.Text);
        }

        private void txbWaterLights_TextChanged(object sender, EventArgs e)
        {
            allCorrect = Validation.validateCurrency(lblWaterLightsAlert, txbWaterLights.Text);
        }

        private void txbTravel_TextChanged(object sender, EventArgs e)
        {
            allCorrect = Validation.validateCurrency(lblTravelCostAlert, txbTravel.Text);
        }

        private void txbCellTell_TextChanged(object sender, EventArgs e)
        {
           allCorrect = Validation.validateCurrency(lblCellTellAlert, txbCellTell.Text);
        }

        private void txbOther_TextChanged(object sender, EventArgs e)
        {
             allCorrect = Validation.validateCurrency(lblOtherAlert, txbOther.Text);
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pnlBuyProperty_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void txbPropPrice_TextChanged(object sender, EventArgs e)
        {
            allCorrect = Validation.validateCurrency(lblPropertyPriceAlert, txbPropPrice.Text);
        }

        private void txbTotDeposit_TextChanged(object sender, EventArgs e)
        {
            allCorrect = Validation.validateCurrency(lblTotDepositAlert, txbTotDeposit.Text);
        }

        private void txbInterestRate_TextChanged(object sender, EventArgs e)
        {
          
        }

        private void txbMonRepay_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void pnlProperty_Paint(object sender, PaintEventArgs e)
        {
        
        }

        private void txbMonRent_TextChanged(object sender, EventArgs e)
        {
            allCorrect = Validation.validateCurrency(lblMonRentAlert, txbMonRent.Text);
        }

        private void rbRent_CheckedChanged(object sender, EventArgs e)
        {
            if (rbRent.Checked == true)// checks if Renting rb is selected and makes gui visibility adjustments
            {
                pnlBuyProperty.Visible = false;
                pnlRentProperty.Visible = true;
            }
            else
            {
                txbMonRent.Text = "";
                lblMonRentAlert.Text = "";
                pnlRentProperty.Visible = false;
            }
        }

        private void txbOutput_TextChanged(object sender, EventArgs e)
        {
        
        }
        private void clear() // clears all gui components
        {
            txbFullName.Text = "";
            txbGrossMonInc.Text = "";
            lblGrossIncAlert.Text = "";
            txbTaxDed.Text = "";
            lblMonthlyDeductAlert.Text = "";
            txbGroc.Text = "";
            lblGroceriesAlert.Text = "";
            txbWaterLights.Text = "";
            lblWaterLightsAlert.Text = "";
            txbTravel.Text = "";
            lblTravelCostAlert.Text = "";
            txbCellTell.Text = "";
            lblCellTellAlert.Text = "";
            txbTaxDed.Text = "";
            lblMonthlyDeductAlert.Text = "";
            txbOther.Text = "";
            lblOtherAlert.Text = "";
            txbFullName.Text = "";
            lblFullNameAlert.Text = "";
            rbRent.Checked = false;
            rbBuy.Checked = false;
           
        }
        public void checkNull() // checks that all relevant inputs are not nul
        {
            if (txbFullName.Text == "")
            {
                allCorrect = false;
            }
            else
            {
                if (txbGrossMonInc.Text == "")
                {
                    allCorrect = false;
                }
                else
                {
                    if (txbTaxDed.Text == "")
                    {
                        allCorrect = false;
                    }
                    else
                    {
                        if (txbGroc.Text == "")
                        {
                            allCorrect = false;
                        }
                        else
                        {
                            if (txbWaterLights.Text == "")
                            {
                                allCorrect = false;
                            }
                            else
                            {
                                if (txbTravel.Text == "")
                                {
                                    allCorrect = false;
                                }
                                else
                                {
                                    if (txbCellTell.Text == "")
                                    {
                                        allCorrect = false;
                                    }
                                    else
                                    {
                                        if (txbOther.Text == "")
                                        {
                                            allCorrect = false;
                                           
                                        }
                                        else
                                        {
                                            if (rbRent.Checked == true)// checks if Renting rb is selected
                                            {
                                                if (txbMonRent.Text == "")
                                                {
                                                    allCorrect = false;
                                                }
                                            }
                                            if (rbBuy.Checked == true)// checks if Renting rb is selected 
                                            {
                                                if (txbPropPrice.Text == "")
                                                {
                                                    allCorrect = false;
                                                }
                                                else
                                                {
                                                    if (txbTotDeposit.Text == "")
                                                    {
                                                        allCorrect = false;
                                                    }
                                                }
                                            }
                                        }
                                        
                                    }
                                }
                            }
                        }
                        
                    }
                }
            }
        }
        private void btnCheckBud_Click(object sender, EventArgs e)
        {
            checkNull();
            if (allCorrect == true && (rbRent.Checked || rbBuy.Checked))//checks that all values entered are in correct format
            {

                    string name = txbFullName.Text;
                    double grossMonInc = double.Parse(Validation.alterCurrency(txbGrossMonInc.Text));
                    double taxDed = double.Parse(Validation.alterCurrency(txbTaxDed.Text));
                    double groc = double.Parse(Validation.alterCurrency(txbGroc.Text));
                    double waterLights = double.Parse(Validation.alterCurrency(txbWaterLights.Text));
                    double travel = double.Parse(Validation.alterCurrency(txbTravel.Text));
                    double cellTell = double.Parse(Validation.alterCurrency(txbCellTell.Text));
                    double other = double.Parse(Validation.alterCurrency(txbOther.Text));
                  //gets all generic expenses
                    if (rbRent.Checked)
                    {
                     double monRent = double.Parse(Validation.alterCurrency(txbMonRent.Text));
                    // gets all renting expenses
                      Rent_Expense newExpense = new Rent_Expense(taxDed, groc, waterLights, travel, cellTell, other,monRent);
                    //makes rent expense
                      UserDetails newUser= new UserDetails(name,grossMonInc,newExpense);
                    //makes user details
                      UserDetailList.addUser(newUser);
                    //adds to user details list
                      txbOutput.Text = UserDetailList.displaySingleUserDetails(currentExpense);
                    //display current users details from list
                      currentExpense++;//increases index used for list display
                      clear();
                    }
                    else
                    {
                        if (rbBuy.Checked)
                        {
                           double propPrice = double.Parse(Validation.alterCurrency(txbPropPrice.Text));
                           double totDeposit = double.Parse(Validation.alterCurrency(txbTotDeposit.Text));
                          double interestRate = double.Parse(numericUpDownInterestRate.Value + "");
                          double  monRepay = double.Parse(numericUpDownMonRepay.Value + "");
                          // gets all values for buying expense
                          Buy_Expense newExpense = new Buy_Expense(taxDed, groc, waterLights, travel, cellTell, other, propPrice, 
                              totDeposit, interestRate, monRepay) ;
                        // makes buying expense
                          UserDetails newUser = new UserDetails(name, grossMonInc, newExpense);
                          // makes user details
                          UserDetailList.addUser(newUser);
                        //adds to user details list
                        txbOutput.Text = UserDetailList.displaySingleUserDetails(currentExpense);
                        //display current users details from list
                        highlightMessages();
                        currentExpense++;//increases index used for list display
                        clear();
                    }
                    }
                
               
            }
            else
            {
                if (!(allCorrect) && !(rbRent.Checked) && !(rbBuy.Checked))
                {
                    MessageBox.Show(allCorrect + "\r\n"+ rbRent.Checked + "\r\n"+ rbBuy.Checked + "\r\n");
                    // MessageBox.Show("Not all Values are correct and Buy or Rent is not selected. Please go back and adjust", "Input incorrect and Rent or Buy is not selected", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    //Line 328,366 & 342 Adapted from: https://stackoverflow.com/questions/2109441/how-to-show-error-warning-message-box-in-net-how-to-customize-messagebox
                    //Author: Tides
                    //Date accessed: 29 April 2021
                }
                else
                {
                    if (allCorrect == false) // displays message if a value is in incorrect format
                    {
                        MessageBox.Show("Not all Values are correct.Please go back and adjust", "Input incorrect", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    if (!(rbRent.Checked || rbBuy.Checked)) //displays message if buying or renting is not selected
                    {
                        MessageBox.Show("Please select to Buy or Rent a property", "Rent or buy not selected", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                
                
            }
        }

        private void lblTravelCost_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_2(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
          allCorrect = Validation.validateName(lblFullNameAlert, txbFullName.Text);
            
        }

        private void numericUpDownInterestRate_ValueChanged(object sender, EventArgs e)
        {

        }
        private void highlightMessages()//finds home loan alert messages and makes it red
        {
            //Method Adapted from:https://stackoverflow.com/questions/27217884/highlighting-a-line-of-text-in-a-richtextbox
            //Author: dbc
            //Date accessed: 18 April 2021
            string[] lines = txbOutput.Lines;

            for (int i = 0; i < lines.Length; i++)
            {
                string line = lines[i];
                string message = "Home Loan exceeds 30% of income. Approval unlikely!";//
                if (line.StartsWith(message) == true)
                { 
                    int index = txbOutput.GetFirstCharIndexFromLine(i);
                    txbOutput.Select(index,message.Length);
                    txbOutput.SelectionColor = Color.Red;

                }
            }
            
        }
        private void txbReport_Click(object sender, EventArgs e)
        {
            
           txbOutput.Text = UserDetailList.displayAllUserDetails();//displays all user details
            highlightMessages();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            
        }
    }
}
