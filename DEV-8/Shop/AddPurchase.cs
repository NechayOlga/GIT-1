using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop
{
    public class AddPurchase
    {
        public void PurchaseAdder(Purchase purchase)
        {
            PurchaseBuilder purchaseBuilder = new PurchaseBuilder();
            List<Purchase> arrayPurchase = purchaseBuilder.ArrayPurchaseBuild();    
            arrayPurchase.Add(purchase);
        }
       /* public List<Purchase> ArrayPurchase()
        {
            return arrayPurchase;
        }*/
    }
}
