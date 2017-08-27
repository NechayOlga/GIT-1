using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Shop.Tests
{
    [TestClass]
    public class PurchaseTests
    {
        [TestMethod]
        public void OutputPurchase_type_name_1_1_1returned()
        {
            //arrange
            const string type = "type";
            const string name = "name";
            const int quantity = 1;
            const decimal price = 1.1M;

            //act
            Purchase purchase = new Purchase(type, name, quantity, price);
            string actual = Convert.ToString("\nTYPE: " + " " + purchase.Type + "\nNAME : " + " " + purchase.Name + "\nQUANTITY: " + " " + purchase.Quantity + "\nPRICE: " + " " + purchase.Price + "\n");
            string expected = String.Empty;
            expected = purchase.OutputPurchase();

            //assert
            Assert.AreEqual(expected, actual);
        }
    }
}
