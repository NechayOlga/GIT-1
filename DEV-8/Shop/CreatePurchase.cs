using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop
{
    public class CreatePurchase
    {
        const string INPUT_TYPE = "Input type: ";
        const string INPUT_NAME = "\nInput name: ";
        const string INPUT_QUANTITY = "\nInput quantity: ";
        const string INPUT_PRICE = "\nInput price: ";
        const string CONTINUE_INPUT = "\nEnter STOP to exit";
        const string NEGATIVE_QUANTITY_EXCEPTION = "Quantity can't be negative, try again";
        const string NEGATIVE_PRICE_EXCEPTION = "Price can't be negative, try again";
        Inputer inputer = new Inputer();
        public Purchase InputPurchase()
        {
            {
                Console.WriteLine(INPUT_TYPE);
                string type = inputer.InputStrings();
                Console.WriteLine(INPUT_NAME);
                string name = inputer.InputStrings();
                Console.WriteLine(INPUT_QUANTITY);
                int quantity = inputer.InputQuantity();
                if (quantity < 0)
                {
                    throw new NegativeQuantityException(NEGATIVE_QUANTITY_EXCEPTION);
                }
                Console.WriteLine(INPUT_PRICE);
                decimal price = inputer.InputPrice();
                if (price < 0)
                {
                    throw new NegativePriceException(NEGATIVE_PRICE_EXCEPTION);
                }
                Purchase purchase = new Purchase(type, name, quantity, price);
                return purchase;
            }
        }
    }
}
