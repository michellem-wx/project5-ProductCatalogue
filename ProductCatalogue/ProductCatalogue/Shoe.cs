using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductCatalogue
{
    public class Shoe : Product
    {
        public int ShoeSize;

        public Shoe(string productName, double price, string brand, string colour, int size)
        {
            ProductName = productName;
            Price = price;
            Brand = brand;
            Colour = colour;
            ShoeSize = size;
        }

        // Create a method that uses the constructor Shoe
        //public static Shoe CreateAShoe(string productName, double price, string brand, string colour, int size)
        //{
        //    Shoe shoeItem = new Shoe(productName, price, brand, colour, size);

        //    return shoeItem;
        //}

        public override string ToString()
        {
            return
                $"Product Name: {ProductName}\n" +
                $"Price: ${Price}\n" +
                $"Brand: {Brand}\n" +
                $"Colour: {Colour}\n" +
                $"Size: {ShoeSize}\n\n\n";
        }

    }
}
