using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop
{
    class Outputer
    {
        const string EXISTENR_COMMANDS = "NEXT COMMANDS ARE AVAILABLE FOR THIS PRODUCT LIST: ";
        const string COUNT_TYPES = "\nCOMMAND1. To count all types of products enter 'count types'";
        const string COUNT_QUANTITY = "\nCOMMAND2. To count quantity of all products enter 'count all'";
        const string AVERAGE_PRICE = "\nCOMMANDS3. To count the average price of all products enter 'average price'";
        const string AVERAGE_PRICE_TYPE = "\nCOMMAND4. To count the average price of the product of the specific TYPE " +
                                          "\nenter 'average price TYPE'";
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
