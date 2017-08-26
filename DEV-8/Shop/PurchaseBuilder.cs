using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop
{
    public class PurchaseBuilder
    {
        /*const string INPUT_TYPE = "Input type: ";
        const string INPUT_NAME = "\nInput name: ";
        const string INPUT_QUANTITY = "\nInput quantity: ";
        const string INPUT_PRICE = "\nInput price: ";
        const string CONTINUE_INPUT = "\nEnter STOP to exit";
        const string NEGATIVE_QUANTITY_EXCEPTION = "Quantity can't be negative, try again";
        const string NEGATIVE_PRICE_EXCEPTION = "Price can't be negative, try again";*/
        const string CONTINUE_INPUT = "\nEnter STOP to exit";
        // List<Purchase> arrayPurchase = new List<Purchase>();
        //Inputer inputer = new Inputer();
        List<Purchase> arrayPurchaseBuild = new List<Purchase>();
        public void BuildPurchase()
        {        
            bool check = true;
            while (check)
            {
            CreatePurchase createPurchase = new CreatePurchase();
            Purchase purchase = createPurchase.InputPurchase();
            arrayPurchaseBuild.Add(purchase);
            //arrayPurchase.Add(purchase);
            Console.WriteLine(CONTINUE_INPUT);
            if (Console.ReadLine().Equals("STOP"))
            {
                break;
            }
            continue;
        } 
        }
        public List<Purchase> ArrayPurchaseBuild()
        {
            return arrayPurchaseBuild;
        }
        
    }          
}
