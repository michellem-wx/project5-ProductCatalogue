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


            // bag objects:
            var handbag = new Bag("Black medium gym bag", 33, "Nike", "Black", 30, 60, 20, "Gym");
            var travelBag = new Bag("Black medium gym bag", 33, "Nike", "Black", 30, 60, 20, "Gym");
            var heels = new Shoes("heels", 30, "LV", "black", "party");


            // THIS IS CREATING A NEW CATALOGUE CALLED SHIRTS
            Catalogue<Product> shirtsCatalogue = new Catalogue<Product>();

            // FOR EACH LOOP TO GO THROUGH THE SHIRTS CATALOGUE

            //For every item in Shirts in shirt catalogue list
            // shirt catalogue class and going into the catalogue list
            foreach (Product item in shirtsCatalogue.DigitalCatalogue)
            {
                Console.WriteLine(item.ProductName);
            }

            // this is the new catalogue, has to be the same <t> (type)

/*            //YAO:
            var bagsCatalogue = new Catalogue<Product>();

            // add get and set
            // AddProduct is our method
            // bagsCatalogue 
            bagsCatalogue.AddProduct(heels);
            bagsCatalogue.AddProduct(gymBag);
            bagsCatalogue.AddProduct(travelBag);
            bagsCatalogue.AddProduct(handbag);*/

            // YAO
            // Bags = Class: Bags
            // bags = variable
            // bagsCatalogue = the new catalogue you created
            // DigitalCatalogue = is the List storing the Products
            //foreach (Product item in bagsCatalogue.DigitalCatalogue)
            //{
            //    Console.WriteLine(item);

            //}

            


        }
    }
}