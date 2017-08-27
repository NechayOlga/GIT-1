using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Shop.Tests
{
    [TestClass]
    public class CommandsTests
    {
        private const string type1 = "type 1";
        private const string name1 = "name 1";
        private const int quantity1 = 1;
        private const decimal price1 = 1.1M;

        private const string type2 = "type 2";
        private const string name2 = "name 2";
        private const int quantity2 = 2;
        private const decimal price2 = 2.2M;

        private const string type3 = "type 3";
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
        public void TestCountTypesCommand_type1_and_type2_and_type3_count_3returned()
        {
            //arrange
            List<Purchase> testCountTypesCommandList = new List<Purchase> { purchase1, purchase2, purchase3 };
            Commands commands = new Commands();

            //act
            int countTypes = commands.CountTypes(testCountTypesCommandList);
            int expected = 3;

            //assert
            Assert.AreEqual(expected, countTypes);
        }

        [TestMethod]
        public void TestCountQuantity_1_and_2_and_3_quantity_6returned()
        {
            //arrange
            List<Purchase> testCountQuantityCommandList = new List<Purchase> { purchase1, purchase2, purchase3 };
            Commands commands = new Commands();

            //act
            int countQuantity = commands.CountQuantity(testCountQuantityCommandList);
            int expected = 6;

            //assert
            Assert.AreEqual(expected, countQuantity);
        }

        [TestMethod]
        public void TestCountAveragePrice_1_1M_and_2_2M_and_3_3M_averagePrice_2_2returned()
        {
            //arrange
            List<Purchase> testCountAveragePriceCommandList = new List<Purchase> { purchase1, purchase2, purchase3 };
            Commands commands = new Commands();

            //act
            decimal countAveragePrice = commands.CountPrice(testCountAveragePriceCommandList);
            decimal expected = 2.2M;

            //assert
            Assert.AreEqual(expected, countAveragePrice);
        }

        [TestMethod]
        public void TestCountAveragePriceType_type1_and_type4_price1_and_price2_2_75returned()
        {
            //arrange
            List<Purchase> testCountAveragePriceCommandList = new List<Purchase> { purchase1, purchase2, purchase3, purchase4 };
            Commands commands = new Commands();
            string typeForAveragePrice = type1;

            //act
            decimal countAveragePriceType = commands.AverageCountPrice(typeForAveragePrice, testCountAveragePriceCommandList);
            decimal expected = 2.75M;

            //assert
            Assert.AreEqual(expected, countAveragePriceType);
        }
    }
}
