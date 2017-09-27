using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop
{
    public class Purchase
    {
        public string Type
        { get; set; }
        public string Name
        { get; set; }
        public int Quantity
        { get; set; }
        public decimal Price
        { get; set; }
        public Purchase(string type, string name, int quantity, decimal price)
        {
            Type = type;
            Name = name;
            Quantity = quantity;
            Price = price;
        }
        public string OutputPurchase()
        {
            return "\nTYPE: " + " " + Type.ToString() + "\nNAME : " + " "  + Name.ToString() + "\nQUANTITY: " + " " + Quantity.ToString() + "\nPRICE: " + " " + Price.ToString() + "\n";
        }
    }
}
