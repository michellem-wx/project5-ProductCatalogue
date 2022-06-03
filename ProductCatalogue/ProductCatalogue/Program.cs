using System;
using System.Collections.Generic;

namespace ProductCatalogue 
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("PRODUCT DATA LIBRARY");
            Menu menu = new Menu();
            menu.selectOptionFromMenu();
            

            #region Pseudo coding
            // PSEUDO CODING:
            // Display menu options for user to select an option:

            //menu.displayMenuOptions(); //this would be a method

            // If the user selects 1 (create new product) THEN invoke 'createNewProduct' method

            // If the user selects 2 (view a catalogue) THEN invoke 'displayProductCatalogue' method



            //CreateNewBagItem.CreateNewBag();

            // If the user selects 3 (Add a product to a catalogue) THEN invoke 'removeProductFromCatalogue' method

            // If the user selects 4 (remove a catalogue) THEN invoke 'removeCatalogue' method

            // ELSE remain on display menu screen 
            #endregion

            #region OG notes
            //Bag gymBag = new Bag("Black medium gym bag", 33, "Nike", "Black", 30, 60, 20, "Gym");
            //gymBag.CalculateTax(gymBag.Price);
            //Console.WriteLine(gymBag);

            //// bag objects:
            //Bag handbag = new Bag("Black medium gym bag", 33, "Nike", "Black", 30, 60, 20, "Gym");
            //Bag travelBag = new Bag("Black medium gym bag", 33, "Nike", "Black", 30, 60, 20, "Gym");
            //Shoe heels = new Shoe("heels", 30, "LV", "black", "party");


            //// THIS IS CREATING A NEW CATALOGUE CALLED SHIRTS
            //Catalogue<Product> shirtsCatalogue = new Catalogue<Product>();

            //// FOR EACH LOOP TO GO THROUGH THE SHIRTS CATALOGUE

            ////For every item in Shirts in shirt catalogue list
            //// shirt catalogue class and going into the catalogue list
            //foreach (Product item in shirtsCatalogue.DigitalCatalogue)
            //{
            //    Console.WriteLine(item.ProductName);
            //}

            #endregion

        }
    }
}

