using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop
{
    public class CommandsBuilder
    {
        const string INVALID_COMMAND = "The command isn't exist. Try again";
        const string COMMAND_NOT_EXIST = "Such command doesn't exist, try again";
        const string COUNT_TYPES = "count types";
        const string COUNT_ALL = "count all";
        const string AVERAGE_PRICE = "average price";
//        const string AVERAGE_PRICE_SPACE = "average price ";
        const string QUANTITY_OF_TYPES = "QUANTITY OF TYPES IS: ";
        const string QUANTITY = "QUANTITY OF ALL PRODUCTS IS: ";
        const string AVERAGE_PRICE_ALL = "AVERAGE PRICE OF ALL PRODUCTS IS: ";
        const string AVERAGE_PRICE_TYPE = "AVERAGE PRICE OF TYPE ";
        const string IS = "IS ";
        const string SPACE = " ";

        public void BuildCommands(string inputedCommand, PurchaseBuilder purchaseBuilder)
        {
            Commands commands = new Commands();
            List<Purchase> purchaseArray = new List<Purchase>(purchaseBuilder.ArrayPurchaseBuild());
            if (inputedCommand.Equals(COUNT_TYPES))
            {
                Console.WriteLine(QUANTITY_OF_TYPES + SPACE + commands.CountTypes(purchaseArray));
            }
            else if (inputedCommand.Equals(COUNT_ALL))
            {
                Console.WriteLine(QUANTITY + SPACE + commands.CountQuantity(purchaseArray));
            }
            else if (inputedCommand.Equals(AVERAGE_PRICE))
            {
                Console.WriteLine(AVERAGE_PRICE_ALL + SPACE + commands.CountPrice(purchaseArray));
            }          
            else if(inputedCommand.Contains(AVERAGE_PRICE))
            {
                string averagePriceType = inputedCommand.Remove(0, 14);
                string averagePrice = string.Concat(AVERAGE_PRICE, SPACE, averagePriceType);
                string result = string.Concat(AVERAGE_PRICE_TYPE, averagePriceType, SPACE, IS);
                if (inputedCommand.Equals(averagePrice))
                {
                    Console.WriteLine(result + SPACE + commands.AverageCountPrice(averagePriceType, purchaseArray));
                }
            }
            else 
            {
                throw new NotExistentCommandException(COMMAND_NOT_EXIST);
            }
        }
    }
}
