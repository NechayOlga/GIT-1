using System;

namespace FibonacciNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                try
                {
                    Console.WriteLine("Enter your number");
                    int InputNumber = int.Parse(Console.ReadLine());
                    if (InputNumber < 0)
                    {
                        Console.WriteLine("Please, enter nonnegative numbers.");
                        continue;
                    }
                    else 
                    {
                        int NumberOfRow1;
                        int NumberOfRow2 = 0;
                        int Sum = 1;
                        bool FibonacciCheck = false;
                        for (int i = 1; i <= InputNumber; i++)
                        {
                            NumberOfRow1 = NumberOfRow2;
                            NumberOfRow2 = Sum;
                            Sum = NumberOfRow1 + NumberOfRow2;
                            if (Sum == InputNumber)
                            {
                                FibonacciCheck = true;
                                break;
                            }
                        }
                        if (FibonacciCheck == true)
                        {
                            Console.Write("Yes, the number you've entered is Fibonacci number");
                            Console.WriteLine("\nPress any key to exit");
                            Console.ReadKey();
                            break;
                        }
                        else
                        {
                            Console.Write("No, the number you've entered isn't Fibonacci number");
                            Console.WriteLine("\nPress any key to exit");
                            Console.ReadKey();
                            break;
                        }                       
                    }               
                }
                catch (FormatException)
                {
                    Console.WriteLine("Sorry, it's not a number, try again.");
                }
            }
        }
    }
}
