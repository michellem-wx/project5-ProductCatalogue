using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductCatalogue
{
     internal class Shoes : Product
    {
        // Properties unique to the Shoes class
        public string Occasion;

        // Constructor for Shoes
        // Used to create instances of Shoes
        public Shoes(string productName, double price, string brand, string colour, string occasion)
        {
            ProductName = productName;
            Price = price;
            Brand = brand;
            Colour = colour;
            Occasion = occasion;
        }

        //Q. Should we be using all properties of the abstract class?

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
