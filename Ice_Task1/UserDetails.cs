using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace BudgetApp
{
    class UserDetails
    {
        private string fullName;
        private double grossMonInc;
        private Expenses userExpense;

        public UserDetails(string fullName, double grossMonInc, Expenses userExpense)
        {
            this.fullName = fullName;
            this.grossMonInc = grossMonInc;
            this.userExpense = userExpense;
        }

       private string displayRentExpense()
        {
            string output = "********************************************************************************\r\n";
            Rent_Expense temp = (Rent_Expense)userExpense;
            double totExpenses = temp.returnTotExpenses();
            double remMoney = Math.Round(grossMonInc - totExpenses, 2);
            if (remMoney>=0)
            {
                output += $"Full Name: {fullName}\r\nGross Monthly Income: R{grossMonInc}\r\nTotal Expenses: R{totExpenses}\r\n" +
             $"Money Remaining: R{grossMonInc - totExpenses}";
            }
            else
            {
              
                output += $"{fullName}. Please note your Monthly Expenses exceed your Monthly income, you are in a deficit of R{-1*remMoney}";
            }
           
            return output;
        }

        private string displayBuyExpense()//displays user details if user is Renting
        {
            string output = "";
            Buy_Expense temp = (Buy_Expense)userExpense;
            double loanRep = temp.monRepayment();
            double totExpenses = temp.returnTotExpenses();
            double remMoney = Math.Round(grossMonInc - totExpenses, 2);
            if (remMoney >= 0.00)
            {
               

                output += "********************************************************************************\r\n";
                output += $"Full Name: {fullName}\r\nGross Monthly Income: R{grossMonInc}\r\nHome Loan Repayment: R{loanRep}" +
                          $"\r\nTotal Expenses: R{totExpenses}\r\n" + $"Money Remaining: R{remMoney}" +
                          $"{temp.repaymentMessage(grossMonInc)}" ;

               
                return output;
            }
            else
            {
                output = $"Your Monthly Expenses exceed your Monthly income, you are in a deficit of R{-1*remMoney}";
            }
            return output;


        }
        public string Display()//will check is user is renting or buying and call appropriate display method
        {
            String output = "";

            //Line 75 & 81 Adapted from: https://stackoverflow.com/questions/4774820/how-to-find-the-child-class-name-from-base-class
            //Author: tvanfosson
            //Date accessed: 3 April 2021
            if (userExpense.GetType() == typeof(Buy_Expense))
            {
               output = displayBuyExpense();
            }
            else
            {
                if (userExpense.GetType() == typeof(Rent_Expense))
                {
                   output = displayRentExpense();
                }
            }
            return output;
        }
    }
}
