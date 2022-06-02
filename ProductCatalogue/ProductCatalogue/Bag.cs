using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductCatalogue
{
    public class Bag : Product
    {
        public int WidthDimension;
        public int HeightDimension;
        public int DepthDimension;
        public string BagCategory;
        
        // Constructor is already creating an instance of the bag (you can return this)
        public Bag(string productName, double price, string brand, string colour, int width, int height, int depth, string category)
        {
            ProductName = productName;
            Price = price;
            Brand = brand;
            Colour = colour;
            WidthDimension = width;
            HeightDimension = height;
            DepthDimension = depth;
            BagCategory = category;
        }

        // Create a method that uses the constructor Bag
        //public static Bag CreateABag(string productName, double price, string brand, string colour, int width, int height, int depth, string category)
        //{
        //    return new Bag(productName, price, brand, colour, width, height, depth, category);

        //    //return bagItem;
        //}


        public override string ToString()
        {
            return
                $"Product Name: {ProductName}\n" +
                $"Price: ${Price}\n" +
                $"Brand: {Brand}\n" +
                $"Colour: {Colour}\n" +
                $"Width: ${WidthDimension}\n" +
                $"Height: {HeightDimension}\n" +
                $"Depth: {DepthDimension}\n" +
                $"Category: {BagCategory}\n\n\n";
        }
    }
}
