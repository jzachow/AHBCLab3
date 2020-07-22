using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace AHBCLab3
{
    class LabTester
    {

        /// <summary>
        /// Tests if an integer is odd or even
        /// </summary>
        /// <param name="userInteger">The integer to be tested</param>
        /// <returns>Returns true if the integer is even, odd if the integer is false</returns>
        private static bool TestEvenOrOdd(int userInteger  )
        {
            return (userInteger % 2 == 0);
        }


        /// <summary>
        /// Tests if the user has entered appropriate input
        /// </summary>
        /// <param name="input">String to be validated</param>
        /// <returns>True if the user input is valid. Returns false and displays a message to the user if invalid data is entered</returns>
        public static bool ValidateInput(string input)
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


        /// <summary>
        /// Determines the appropriate text output based on the entered integer
        /// </summary>
        /// <param name="userInteger"></param>
        /// <returns>A string with the appropriate format</returns>
        public static string ProcessToOutput(int userInteger)
        {
            if (TestEvenOrOdd(userInteger))
            {
                if (userInteger < 25) return "Even and lass than 25";
                else if (userInteger <= 60) return "Even";
                else return $"{userInteger} is Even";
            }
            else
            {
                return $"{userInteger} is Odd";
            }
        }
    }
}
