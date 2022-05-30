using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductCatalogue
{

    // Product is your ABSTRACT class
    // It will be the base class in which derived classes will inherit everything in here

    internal class Product
    {
        public double Price;
        public string ProductName;
        public string Brand;
        public string Colour;


        public virtual double CalculateTax(double Price)
        {
            return Math.Round((Price * 1.1),2);

        }
    }
}


