using System;
using System.Collections.Generic;
using System.Text;

namespace BudgetApp
{
       abstract class Expenses
    {
        //class for generic expenses
        private double taxDed;
        private double groc;
        private double waterLights;
        private double travel;
        private double cellTell;
        private double other;

       

        public Expenses( double taxDed, double groc, double waterLights, double travel, double cellTell, double other)
        {
           
            this.taxDed = taxDed;
            this.groc = groc;
            this.waterLights = waterLights;
            this.travel = travel;
            this.cellTell = cellTell;
            this.other = other;
        }
  
        protected double TaxDed { get => taxDed; }
        protected double Groc { get => groc; }
        protected double WaterLights { get => waterLights; }
        protected double Travel { get => travel; }
        protected double CellTell { get => cellTell; }
        protected double Other { get => other; }
    }
}
