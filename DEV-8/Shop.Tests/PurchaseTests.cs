using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop.Tests
{
    class PurchaseTests
    {
        public void Purchase_NameRequired()
        {
            PurchaseBuilder purchaseBuilder = new PurchaseBuilder();  
            string type = "type";
            string name = "name";
            int quantity = 1;
            decimal price = 1.2M;
            Purchase purchase = new Purchase(type, name, quantity, price);
            purchaseBuilder.ArrayPurchase()

        }
    }
}
