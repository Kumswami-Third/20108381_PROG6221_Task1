using System;
using System.Collections.Generic;
using System.Text;

namespace BudgetApp
{
    class Rent_Expense: Expenses
    {
        //class for rent expenses
        private double monRent;

        public Rent_Expense( double taxDed, double groc, double waterLights, double travel, double cellTell,
                            double other, double monrent)
                             : base( taxDed, groc, waterLights, travel, cellTell, other)
        {
            monRent = monrent;
        }


        public double returnTotExpenses()//displays user details if user is buying
        {
            
            
            return TaxDed + Groc + WaterLights + Travel + CellTell + Other + MonRent;

 
            
        }

        public double MonRent { get => monRent;  }
       
    }
}
