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
        const string QUANTITY_OF_TYPES = "QUANTITY OF TYPES IS: ";
        const string QUANTITY = "QUANTITY OF ALL PRODUCTS IS: ";
        const string AVERAGE_PRICE_ALL = "AVERAGE PRICE OF ALL PRODUCTS IS: ";
        const string AVERAGE_PRICE_TYPE = "AVERAGE PRICE OF TYPE ";
        const string IS = "IS ";
        const string SPACE = " ";
        public string BuildCommands(string inputedCommand, List<Purchase> purchaseArray)
        {
            PurchaseBuilder purchaseBuilder = new PurchaseBuilder();
            Commands commands = new Commands();
            string result = String.Empty;
            if (inputedCommand.Equals(COUNT_TYPES))
            {
                Console.Write(QUANTITY_OF_TYPES);
                result = Convert.ToString(commands.CountTypes(purchaseArray));
            }
            else if (inputedCommand.Equals(COUNT_ALL))
            {
                Console.Write(QUANTITY);
                result = Convert.ToString(commands.CountQuantity(purchaseArray));
            }
            else if (inputedCommand.Equals(AVERAGE_PRICE))
            {
                Console.Write(AVERAGE_PRICE_ALL);
                result = Convert.ToString(commands.CountPrice(purchaseArray));
            }          
            else if(inputedCommand.Contains(AVERAGE_PRICE))
            {
                string averagePriceType = inputedCommand.Remove(0, 14);
                string averagePrice = string.Concat(AVERAGE_PRICE, SPACE, averagePriceType);
                string resultAverageType = string.Concat(AVERAGE_PRICE_TYPE, averagePriceType, SPACE, IS);
                if (inputedCommand.Equals(averagePrice))
                {
                    Console.Write(resultAverageType);
                    result = Convert.ToString(commands.AverageCountPrice(averagePriceType, purchaseArray));
                }
            }           
            else 
            {
                throw new NotExistentCommandException(COMMAND_NOT_EXIST);
            }
            return result;
        }
    }
}
