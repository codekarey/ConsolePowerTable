using System;

namespace ConsolePowerTable
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Hello, welcome to Power Table.\n ");

            //loops if user wants
            bool yes = true;
            while (yes)
            {
            Console.WriteLine("Please enter a number you'd like to to the power table of.");
                //validate number to make table
                string checkNum = Console.ReadLine();
                try
                {
                    int num = int.Parse(checkNum);
                    Console.WriteLine("Number Table \n"+ "============");
                    for(int i = 1; i <= 10; i++) //shows powers 1-10
                    {
                        Console.WriteLine(num+" ^"+i+" = "+Math.Pow(num,i));
                    }
                    yes=Loop();
                }
                catch(FormatException) //not a number
                {
                    Console.WriteLine("Sorry that wasn't a number I understand.");
                    yes=Loop();
                }
                catch(OverflowException) //number is too big
                {
                    Console.WriteLine("Sorry, maybe try a smaller number?");
                    yes=Loop();
                }
            }      
        }
        public static bool Loop()
        {
            Console.WriteLine("Enter y to try again or any other key to exit.");
            string loop = Console.ReadLine().ToLower();
            if (loop == "y")
            {
                return true;
            }
            else
            {
            return false;
            }
        }
    }
}
