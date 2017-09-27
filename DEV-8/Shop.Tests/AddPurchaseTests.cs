using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace Shop.Tests
{
    [TestClass]
    public class AddPurchaseTests
    {
        private const string type = "type";
        private const string name = "name";
        private const int quantity = 1;
        private const decimal price = 7.8M;

        [TestMethod]
        public void AddName_name_existent()
        {
            //arrange
            Purchase purchase = new Purchase(type, name, quantity, price);
            List<Purchase> testNameList = new List<Purchase>();
            AddPurchase addPurchase = new AddPurchase();
           
            //act
            addPurchase.PurchaseAdder(purchase, testNameList);

            //assert
            Assert.AreEqual(name, testNameList[0].Name);
        }

        [TestMethod]
        public void AddType_type_existent()
        {
            //arrange
            Purchase purchase = new Purchase(type, name, quantity, price);
            List<Purchase> testTypeList = new List<Purchase>();
            AddPurchase addPurchase = new AddPurchase();

            //act
            addPurchase.PurchaseAdder(purchase, testTypeList);

            //assert
            Assert.AreEqual(type, testTypeList[0].Type);
        }

        [TestMethod]
        public void AddQuantity_quantity_existent()
        {
            //arrange
            Purchase purchase = new Purchase(type, name, quantity, price);
            List<Purchase> testQuantityList = new List<Purchase>();
            AddPurchase addPurchase = new AddPurchase();

            //act
            addPurchase.PurchaseAdder(purchase, testQuantityList);

            //assert
            Assert.AreEqual(quantity, testQuantityList[0].Quantity);
        }

        [TestMethod]
        public void AddPrice_price_existent()
        {
            //arrange
            Purchase purchase = new Purchase(type, name, quantity, price);
            List<Purchase> testPriceList = new List<Purchase>();
            AddPurchase addPurchase = new AddPurchase();

            //act
            addPurchase.PurchaseAdder(purchase, testPriceList);

            //assert
            Assert.AreEqual(price, testPriceList[0].Price);
        }
    }
}
