using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace BudgetApp
{
    class Buy_Expense : Expenses
    {
        //class for buying expense
        private double propPrice;
        private double totDeposit;
        private double interestRate;
        private double monRepay;



        public Buy_Expense( double taxDed, double groc, double waterLights, double travel, double cellTell, double other, 
                            double propPrice, double totDeposit, double interestRate, double monRepay)
                            :base( taxDed, groc, waterLights, travel, cellTell, other)
        {
            this.propPrice = propPrice;
            this.totDeposit = totDeposit;
            this.interestRate = interestRate;
            this.monRepay = monRepay;
        }

        public double PropPrice { get => propPrice;  }
        public double TotDeposit { get => totDeposit; }
        public double InterestRate { get => interestRate; }
        public double MonRepay { get => monRepay;  }

        public double monRepayment()
        {
            double HomeLoanRepayment = ((propPrice - totDeposit)*(1+(interestRate/100)*monRepay))/monRepay;
            return Math.Round(HomeLoanRepayment,2);
        }
        public string repaymentMessage(double grossMonInc)//return appropriate message based on repayment amount
        {
            string output = "";
            if (monRepayment()>(0.3*grossMonInc))
            {
                
                output = "\r\nHome Loan exceeds 30% of income. Approval unlikely!";
                
            }
            return output;
        }

        public double returnTotExpenses()
        {
            return TaxDed + Groc + WaterLights + Travel + CellTell + Other + monRepayment();
                                  
        }
       
    }
}
