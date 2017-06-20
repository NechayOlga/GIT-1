using System;

namespace SwapNumbers
{
    class Program
    {
        // Entrypoint programm
        static void Main(string[] args)
        {
            String numbers;
            for (int n = 0; n <= 100; n++)
            {
                numbers = n % 3 == 0 ? "3*" + n / 3 : n.ToString();
                Console.Write(numbers + " ");
            }
            Console.ReadKey();
        }
    }
}
