﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductCatalogue
{
    public class CreateNewBagItem
    {
        public static void CreateNewBag()
        {
            // string userInput;
            //bool addProduct = false;

            //while (!addProduct)
            //{

            Console.WriteLine("== NEW BAG ITEM ==");
            Console.WriteLine("Add in the product name:");
            string productName = Console.ReadLine();
            
            Console.WriteLine("Add in price (before tax):");
            double price = Convert.ToDouble(Console.ReadLine());
            
            //Console.WriteLine("Price including tax:");
            //Bag.CreateABag(Bag.Price);

            Console.WriteLine("Add in brand name:");
            string brand = Console.ReadLine();

            Console.WriteLine("Add in colour:");
            string colour = Console.ReadLine();

            Console.WriteLine("Add in width(cm):");
            int width = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Add in height(cm):");
            int height = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Add in depth(cm):");
            int depth = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Add in category(cm):");
            string category = Console.ReadLine();

            // this is using the Create a BAG constructor
            Bag.CreateABag(productName, price, brand, colour, width,height, depth, category);


                // QUESTION: HOW DO I SAVE THIS TO THE LIST

                // add in the bag function here
                //Shoe newItem = new Shoe(productName, price, brand, colour, gender);
                //break;

            //}
        }
    }
}