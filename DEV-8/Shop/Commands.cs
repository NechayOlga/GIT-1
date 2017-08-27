using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop
{
    public class Commands
    {
        const string NOT_EXISTENT_TYPE = "\nSuch type doesn't exist in your product list, try again";
        public int CountTypes(List<Purchase> typesArray)
        {
            //typesArray = new List<Purchase>(purchaseBuilder.ArrayPurchaseBuild());
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
        public int CountQuantity(List<Purchase> quantityArray)
        {
            int quantity = 0;
            for(int i = 0; i < quantityArray.Count; i++)
            {
                quantity += quantityArray[i].Quantity;
            }
            return quantity;
        }
        public decimal CountPrice(List<Purchase> priceArray)
        {
            decimal allPrice = 0;
            for(int i = 0; i < priceArray.Count; i++)
            {
                allPrice += priceArray[i].Price;
            }
            decimal averagePrice = allPrice / priceArray.Count;
            return averagePrice;
        }
        public decimal AverageCountPrice(string typeAveragePrice, List<Purchase> averagePriceArray)
        {
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
