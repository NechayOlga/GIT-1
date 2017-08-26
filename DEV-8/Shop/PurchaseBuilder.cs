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
        const string CONTINUE_INPUT = "\nEnter STOP to exit";
        List<Purchase> arrayPurchaseBuild = new List<Purchase>();
        public void BuildPurchase()
        {        
            bool check = true;
            while (check)
            {
                CreatePurchase createPurchase = new CreatePurchase();
                Purchase purchase = createPurchase.InputPurchase();
                AddPurchase addPurchase = new AddPurchase();
                addPurchase.PurchaseAdder(purchase, arrayPurchaseBuild);
                //arrayPurchaseBuild.Add(purchase);
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
