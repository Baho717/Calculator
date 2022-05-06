using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {


            bool continueRunning = true;
            while (continueRunning)
            {
                continueRunning = programCalculation();
            }

            static bool programCalculation()
            {

                Console.WriteLine("What Form of Calculation Would you like to make?");
                Console.WriteLine("Press a to Add two numbers together");
                Console.WriteLine("Press s to Subtract two numbers together");
                Console.WriteLine("Press d to Divide two numbers together");
                Console.WriteLine("Press m to Multiply two numbers together");
                Console.WriteLine("Press e or any other key to Exit.");
                var userChoice = Console.ReadKey().KeyChar;


                switch (userChoice)

                {


                    case 'd':
                        {
                            Console.WriteLine("\nPlease enter your First number");
                            double firstDivided = Convert.ToDouble(Console.ReadLine());
                            Console.WriteLine("\nPlease enter your Second number");
                            double secondDivided = Convert.ToDouble(Console.ReadLine());
                            try
                            {
                                double totalDivided = firstDivided / secondDivided;
                                Console.WriteLine($"\n{firstDivided} divided by {secondDivided} = {totalDivided}");
                            }
                            catch
                            {
                                Console.WriteLine("\nPlease Enter a Valid Problem");
                            }
                            break;
                        }
                    case 'm':
                        {
                            Console.WriteLine("\nPlease enter your First number");
                            double firstTimes = Convert.ToDouble(Console.ReadLine());
                            Console.WriteLine("\nPlease enter your Second number");
                            double secondTimes = Convert.ToDouble(Console.ReadLine());
                            try
                            {
                                double totalTimes = firstTimes * secondTimes;
                                Console.WriteLine($"\n{firstTimes} multiplied by {secondTimes} = {totalTimes}");
                            }
                            catch
                            {
                                Console.WriteLine("\nPlease Enter a Valid Problem");
                            }
                            break;

                        }
                    case 's':
                        {
                            Console.WriteLine("\nPlease enter your First number");
                            double firstMinus = Convert.ToDouble(Console.ReadLine());
                            Console.WriteLine("\nPlease enter your Second number");
                            double secondMinus = Convert.ToDouble(Console.ReadLine());
                            try
                            {
                                double totalMinus = firstMinus - secondMinus;
                                Console.WriteLine($"\n{firstMinus} minus {secondMinus} = {totalMinus}");
                            }
                            catch
                            {
                                Console.WriteLine("\nPlease Enter a Valid Problem");
                            }
                            break;
                        }
                    case 'a':
                        {
                            Console.WriteLine("\nPlease enter your First number");
                            double firstAdded = Convert.ToDouble(Console.ReadLine());
                            Console.WriteLine("\nPlease enter your Second number");
                            double secondAdded = Convert.ToDouble(Console.ReadLine());
                            try
                            {
                                double totalAdded = firstAdded + secondAdded;
                                Console.WriteLine($"\n{firstAdded} added by {secondAdded} = {totalAdded}");
                            }
                            catch
                            {
                                Console.WriteLine("\nPlease Enter a Valid Problem");
                            }
                            break;
                        }
                    default:
                        {
                            Console.WriteLine("\nThank You For Using Our Services.");
                            return false;
                        }
                }

                return true;

            }
        }
    }
}

            

