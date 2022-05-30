using System;
using System.Collections.Generic;

namespace ProductCatalogue 
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Bags gymBag = new Bags("Black medium gym bag", 33, "Nike", "Black", 30, 60, 20, "Gym");
            gymBag.CalculateTax(gymBag.Price);

            Console.WriteLine(gymBag);

            //Bags handbag = new Bags("Small handbag", 50, "red");
            //Console.WriteLine(handbag);

            //Console.WriteLine(handbag.CalculateTax(handbag.Price));
            
            
        }
    }
}