using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductCatalogue
{
    internal class Shoe : Product
    {
        public string Occasion;

        public Shoe(string productName, double price, string brand, string colour, string occasion)
        {
            ProductName = productName;
            Price = price;
            Brand = brand;
            Colour = colour;
            Occasion = occasion;
        }

        public override string ToString()
        {
            return
                $"Product Name: {ProductName}\n" +
                $"Price: ${Price}\n" +
                $"Brand: {Brand}\n" +
                $"Colour: {Colour}\n" +
                $"Occasion: {Occasion}\n\n\n";
        }

    }
}
