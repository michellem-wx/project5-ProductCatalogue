using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductCatalogue
{
    internal class Shirts : Product
    {

        // Properties unique to Shirts.cs
        public string Gender;

        public Shirts(string productName, double price, string brand, string colour, string gender)
        {
            ProductName = productName;
            Price = price;
            Brand = brand;
            Colour = colour;
            Gender = gender;    
        }

        public override string ToString()
        {
            return
                $"Product Name: {ProductName}\n" +
                $"Price: ${Price}\n" +
                $"Brand: {Brand}\n" +
                $"Colour: {Colour}\n" +
                $"Gender: {Gender}\n\n\n";
        }
    }
}
