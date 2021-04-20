using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace Ice_Task1
{
    class Validation
    {
        public static bool validateCurrency(Label output, string input)//checks that input from label is a currency in real time
        {
            bool value = false;
            double temp;
            input.Replace(" ",""); //eliminates spaces so we  can parse to double
            string edited = input.Replace(".", ",");//replaces . with , so we can parse to double
            if (edited!="")
            {
                if (Double.TryParse(edited, out temp)) //checks input is double
                {
                    if (edited.Contains(","))// displays correct if no decimal. Runs if where theres a decimal point
                    {
                        if ((edited.Substring(edited.IndexOf(",")).Length <= 3) && !(edited.IndexOf(",")==edited.Length))
                            //makes sure decimal place is either 1,2 or none
                        {
                            output.ForeColor = System.Drawing.Color.Green;
                            //Line 25 Adapted from: https://stackoverflow.com/questions/15906090/change-color-of-label-in-c-sharp/15906135
                            //Author: musefan
                            //Date accessed: 15 March 2021
                            output.Text = "The value entered is correct";
                            value = true;
                        }
                        else
                        {
                            output.ForeColor = System.Drawing.Color.Red;
                            output.Text = "Max have 2 decimal Places!";
                        }
                    }
                    else
                    {
                        output.ForeColor = System.Drawing.Color.Green;
                        output.Text = "The value entered is correct";
                        value = true;
                    }
                }
                else
                {
                    output.ForeColor = System.Drawing.Color.Red;
                    output.Text = "Value is not a valid number";
                }
            }
            else
            {
                output.ForeColor = System.Drawing.Color.Red;
                output.Text = "Please enter a value!";
            }
           
            
            return value;

        }

        public static string alterCurrency(string input)//Alters input from label so its format can be parsed to a string without error
        {
            input.Replace(".", ",");
            input.Replace(" ", "") ;
            return input;
        }

        public static bool validateName(Label output, string input)//checks that an input is a name
        {
            bool value = false;
            foreach(char c in input)
            {
                
                if (Char.IsLetter(c) || c == ' ' )
                {
                    value = true;
                    output.ForeColor = System.Drawing.Color.Green;

                    output.Text = "The value entered is correct";
                }
                else
                {
                    output.ForeColor = System.Drawing.Color.Red;
                    output.Text = "Must only contain characters";
                }
            }
            return value;
        }
      

    }
}
