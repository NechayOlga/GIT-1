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
        const string AVERAGE_PRICE_SPACE = "average price ";
        public void BuildCommands(string inputedCommand, PurchaseBuilder purchaseBuilder)
        {
            Commands commands = new Commands();
            if (inputedCommand.Equals(COUNT_TYPES))
            {
                Console.WriteLine(commands.CountTypes(purchaseBuilder));
            }
            else if (inputedCommand.Equals(COUNT_ALL))
            {
                Console.WriteLine(commands.CountQuantity(purchaseBuilder));
            }
            else if (inputedCommand.Equals(AVERAGE_PRICE))
            {
                Console.WriteLine(commands.CountPrice(purchaseBuilder));
            }          
            else if(inputedCommand.Contains(AVERAGE_PRICE_SPACE))
            {
                string averagePriceType = inputedCommand.Remove(0, 14);
                string averagePrice = string.Concat("average price ", averagePriceType);
                if (inputedCommand.Equals(averagePrice))
                {
                    Console.WriteLine(commands.AverageCountPrice(purchaseBuilder, averagePriceType));
                }
            }
            else 
            {
                throw new NotExistentCommandException(COMMAND_NOT_EXIST);
            }
        }
    }
}
