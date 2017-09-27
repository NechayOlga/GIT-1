using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop
{
    class Inputer
    {
        public string InputStrings()
        {
            string type = Console.ReadLine();
            return type;
        }
        public int InputQuantity()
        {
            int quantity = int.Parse(Console.ReadLine());
            return quantity;
        }
        public decimal InputPrice()
        {
            decimal price = decimal.Parse(Console.ReadLine());
            return price;
        }
    }
}
