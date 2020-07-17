using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace AHBCLab3
{
    class LabTester
    {

        private bool TestEvenOrOdd(int x)
        {
            return (x % 2) == 0 ? true : false;
        }

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
