using System;

namespace AHBCLab3
{
    class Program
    {
        static void Main(string[] args)
        {
            LabTester tester = new LabTester();


            Console.Write("Hello User! Please enter your name:  ");
            string userName = Console.ReadLine();
            Console.WriteLine("-----------------------------------");
            Console.WriteLine($"Welcome {userName}!");


            bool userContinue;
            do
            {

                bool validInput;
                string userInput;
                do
                {
                    Console.Write("\nPlease enter an integer between 1 and 100: ");
                    userInput = Console.ReadLine();
                    validInput = tester.ValidateInput(userInput);
                } while (!validInput);

                Console.WriteLine(tester.ProcessToOutput(int.Parse(userInput)));


                do
                {
                    Console.WriteLine($"\nWould you like to run the program again, {userName}? (y/n)");
                    userInput = Console.ReadLine();
                    validInput = tester.ValidateInput(userInput);
                } while (!validInput);


                userContinue = (userInput.Equals("y", StringComparison.InvariantCultureIgnoreCase) ? true : false);
                if (!userContinue)
                {
                    Console.WriteLine("\n-------------------------------------------");
                    Console.WriteLine($"Thanks for using my program, {userName}!");
                    Console.WriteLine("-------------------------------------------");
                }


            } while (userContinue);
        }
    }
}

