using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductCatalogue
{
    internal class Bag : Product
    {
        public int WidthDimension;
        public int HeightDimension;
        public int DepthDimension;
        public string BagCategory;
        
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
