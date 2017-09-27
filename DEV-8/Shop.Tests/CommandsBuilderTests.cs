using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Shop.Tests
{
    [TestClass]
    public class CommandsBuilderTests
    {
        const string type1 = "type 1";
        private const string name1 = "name 1";
        private const int quantity1 = 1;
        private const decimal price1 = 1.1M;

        const string type2 = "type 2";
        private const string name2 = "name 2";
        private const int quantity2 = 2;
        private const decimal price2 = 2.2M;

        const string type3 = "type 3";
        private const string name3 = "name 3";
        private const int quantity3 = 3;
        private const decimal price3 = 3.3M;

        private const string type4 = "type 1";
        private const string name4 = "name 4";
        private const int quantity4 = 4;
        private const decimal price4 = 4.4M;

        private Purchase purchase1 = new Purchase(type1, name2, quantity1, price1);
        private Purchase purchase2 = new Purchase(type2, name2, quantity2, price2);
        private Purchase purchase3 = new Purchase(type3, name3, quantity3, price3);
        private Purchase purchase4 = new Purchase(type4, name4, quantity4, price4);

        [TestMethod]
        public void BuildCommandTest_COUNT_TYPES_COMMAND_3returned()
        {
            //arrange
            PurchaseBuilder purchaseBuilder = new PurchaseBuilder();
            string command = "count types";
            string expected = "3";
            string actual = String.Empty;

            //act
            List<Purchase> purchaseArrayQuantityTypesTest = new List<Purchase> { purchase1, purchase2, purchase3 };
            CommandsBuilder commandBuilder = new CommandsBuilder();
            actual = commandBuilder.BuildCommands(command, purchaseArrayQuantityTypesTest);

            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void BuildCommandTest_All_QUANTITY_COMMAND_6returned()
        {
            //arrange
            PurchaseBuilder purchaseBuilder = new PurchaseBuilder();
            string command = "count all";
            string expected = "6";
            string actual = String.Empty;

            //act
            List<Purchase> purchaseArrayAllQuantityTest = new List<Purchase> { purchase1, purchase2, purchase3 };
            CommandsBuilder commandBuilder = new CommandsBuilder();
            actual = commandBuilder.BuildCommands(command, purchaseArrayAllQuantityTest);

            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void BuildCommandTest_AVERAGE_PRICE_COMMAND_2_2returned()
        {
            //arrange
            PurchaseBuilder purchaseBuilder = new PurchaseBuilder();
            string command = "average price";
            string expected = "2,2";
            string actual = String.Empty;

            //act
            List<Purchase> purchaseArrayAveragePriceTest = new List<Purchase> { purchase1, purchase2, purchase3 };
            CommandsBuilder commandBuilder = new CommandsBuilder();
            actual = commandBuilder.BuildCommands(command, purchaseArrayAveragePriceTest);

            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void BuildCommandTest_AVERAGE_PRICE_TYPE_COMMAND_2_75returned()
        {
            //arrange
            PurchaseBuilder purchaseBuilder = new PurchaseBuilder();
            string command = "average price type 1";
            string expected = "2,75";
            string actual = String.Empty;

            //act
            List<Purchase> purchaseArrayAveragePriceTypeTest = new List<Purchase> { purchase1, purchase2, purchase3, purchase4 };
            CommandsBuilder commandBuilder = new CommandsBuilder();
            actual = commandBuilder.BuildCommands(command, purchaseArrayAveragePriceTypeTest);

            //assert
            Assert.AreEqual(expected, actual);
        }
    }
}
