using System;

namespace SwapNumbersToTuttiFrutti
{
    class Program
    {
        // Entrypoint programm
        static void Main(string[] args)
        {
            for (int n = 0; n <= 100; n++)
            {
                String numbers = n.ToString();
                if (n % 3 == 0)
                {
                    numbers = "Tutti";
                }
                if (n % 5 == 0)
                {
                    numbers = "Frutti";
                }
                if ((n % 3 == 0) && (n % 5 == 0))
                {
                    numbers = "Tutti-Frutti";
                }

                Console.Write(numbers + " ");
            }
            Console.ReadKey();
        }
    }
}

