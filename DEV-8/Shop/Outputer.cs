using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop
{
    class Outputer
    {
        const string COUNT_TYPES = "To count all types of products enter 'count types'";
        const string COUNT_QUANTITY = "To count quantity of all products enter 'count all'";
        const string AVERAGE_PRICE = "To count the average price of all products enter 'average price'";
        const string AVERAGE_PRICE_TYPE = "To count the average price of the product of the specific type enter 'average price TYPE'";
        public void OutputPurchase(PurchaseBuilder purchaseBuilder)
        {
            foreach (Purchase purchase in purchaseBuilder.ArrayPurchaseBuild()) 
            {
                 Console.WriteLine(purchase.OutputPurchase());
            }
        }
        public void OutputCommands()
        {
            Console.WriteLine(COUNT_TYPES);
            Console.WriteLine(COUNT_QUANTITY);
            Console.WriteLine(AVERAGE_PRICE);
            Console.WriteLine(AVERAGE_PRICE_TYPE);
        }
        public void OutputQuantityAndTypes(int number)
        {
            Console.WriteLine(number);
        }
        public void OutpurPrice(decimal price)
        {
            Console.WriteLine(price);
        }
    }
}
