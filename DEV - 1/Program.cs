using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwapNumbers
{
    class Program
{
    static void Main(string[] args)
    {
       for (int n = 0; n <= 100; n++)
         {
            String numbers = n % 3 == 0 ? "3*" + n/3 : n.ToString();
            Console.Write(n + " ");
         }
        Console.ReadKey();
      }
    }
}
