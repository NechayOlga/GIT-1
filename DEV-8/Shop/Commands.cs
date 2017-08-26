using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop
{
    public class Commands
    {
        const string NOT_EXISTENT_TYPE = "Such type doesn't exist in your product list, try again";
        public int CountTypes(PurchaseBuilder purchaseBuilder)
        {
            List<Purchase> typesArray = new List<Purchase>(purchaseBuilder.ArrayPurchaseBuild());
            for(int i = 0; i < typesArray.Count; i++)
            {
                for(int j = ( i + 1 ); j < typesArray.Count; j++)
                {
                    if( typesArray[i].Type == typesArray[j].Type)
                    {
                        typesArray.Remove(typesArray[j]);
                        j--;
                    }           
                }              
            }
            int countTypes = typesArray.Count;
            return countTypes;
        }
        public int CountQuantity(PurchaseBuilder purchaseBuilder)
        {
            List<Purchase> quantityArray = new List<Purchase>(purchaseBuilder.ArrayPurchaseBuild());
            int quantity = 0;
            for(int i = 0; i < quantityArray.Count; i++)
            {
                quantity += quantityArray[i].Quantity;
            }
            return quantity;
        }
        public decimal CountPrice(PurchaseBuilder purchaseBuilder)
        {
            List<Purchase> priceArray = new List<Purchase>(purchaseBuilder.ArrayPurchaseBuild());
            decimal allPrice = 0;
            for(int i = 0; i < priceArray.Count; i++)
            {
                allPrice += priceArray[i].Price;
            }
            decimal averagePrice = allPrice / priceArray.Count;
            return averagePrice;
        }
        public decimal AverageCountPrice(PurchaseBuilder purchaseBuilder, string typeAveragePrice)
        {
            List<Purchase> averagePriceArray = new List<Purchase>(purchaseBuilder.ArrayPurchaseBuild());
            decimal averagePriceType = 0;
            int count = 0;
            for (int i = 0 ; i < averagePriceArray.Count; i++)
            {
                if (averagePriceArray[i].Type == typeAveragePrice)
                {
                    averagePriceType += averagePriceArray[i].Price;
                    count++;
                }
            }
            if(count == 0)
            {
                throw new NotExistentTypeAverageTypeCommandException(NOT_EXISTENT_TYPE);
            }
            decimal allAveragePriceType = averagePriceType / count;
            return allAveragePriceType;           
        }
    }
}
