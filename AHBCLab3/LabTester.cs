using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace AHBCLab3
{
    class LabTester
    {

        //Return true if int is even, false if odd
        private bool TestEvenOrOdd(int x)
        {
            return (x % 2) == 0 ? true : false;
        }


        //Validates user string input
        //Returns false and tells user an invalid entry was entered if incorrect input was received
        public bool ValidateInput(string input)
        {
            if (int.TryParse(input, out int userNumber))
            {
                if (userNumber > 0 && userNumber <= 100)
                {
                    return true;
                }
            }

            if (input.Equals("y", StringComparison.CurrentCultureIgnoreCase)|| input.Equals("n", StringComparison.CurrentCultureIgnoreCase))
            {
                return true;
            }

            Console.WriteLine("Invalid entry. Please try again");
            return false;
        }


        //Returns correct text output based on user requirements
        public string ProcessToOutput(int x)
        {
            if (TestEvenOrOdd(x))
            {
                if (x < 25) return "Even and lass than 25";
                else if (x <= 60) return "Even";
                else return $"{x} is Even";
            }
            else
            {
                return $"{x} is Odd";
            }
        }
    }
}
