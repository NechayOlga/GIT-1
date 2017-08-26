using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop
{
    public class AddPurchase
    {
        public void PurchaseAdder(Purchase purchase, List<Purchase> arrayPurchase)
        { 
            arrayPurchase.Add(purchase);
        }
    }
}
