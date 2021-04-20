using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace BudgetApp
{
    class UserDetailList
    {
        private static List<UserDetails> userDetailsList = new List<UserDetails>(); //stores multiple user details
       
        public static void addUser(UserDetails input)//adds user details to list
        {
            userDetailsList.Add(input);
        }
        
        public static string displaySingleUserDetails(int index)// displays given index of list
        {
            string output = "";
            if (userDetailsList != null)
            {
                output = userDetailsList[index].Display();
            }
            else
            {
                output = "Please enter a Budget before trying to display Budget";
            }
            return output;
        }
        
        public static string displayAllUserDetails()//displays all user details stored in list
        {
            string output = "";
            if (userDetailsList != null)
            {
                foreach (UserDetails temp in userDetailsList)
                {
                    output += temp.Display() + "\r\n";
                }

            }
            else
            {
                output = "Please enter a Budget before trying to display all Budgets";
              
            }
            return output;

        }
    }
}
