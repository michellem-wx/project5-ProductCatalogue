using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductCatalogue
{
    public class Menu
    {
        //// Creating 2 pre-existing lists (based on the catalogue class)
        Catalogue<Bag> bagCatalogue = new Catalogue<Bag>();
        Catalogue<Shoe> shoeCatalogue = new Catalogue<Shoe>();

        public void displayMenuOptions()
        {
            Console.WriteLine("PRODUCT DATA LIBRARY\n");
            Console.WriteLine("Please select an option from the menu\nby adding the number only:");
            Console.WriteLine("1) Create new product");
            Console.WriteLine("2) View a catalogue");
            Console.WriteLine("3) Add a product to a catalogue");
            Console.WriteLine("4) Remove a product");
            //Console.WriteLine("5) Remove a catalogue");
            Console.WriteLine("6) Exit");

        }

        public void selectOptionFromMenu()
        {

            bool exit = false;
            Bag newBag = null;
            Shoe newShoe = null;

            while (!exit)
            {
                displayMenuOptions();
                int userSelectedOption = Convert.ToInt32(Console.ReadLine());

                switch (userSelectedOption)
                {
                    case 1: // creating new product
                        Console.WriteLine("Select ONE of the options:");
                        Console.WriteLine("1) Create new bag product");
                        Console.WriteLine("2) Create new shoe product");
                        int userSelectedOptionForNewItem = Convert.ToInt32(Console.ReadLine());

                        if (userSelectedOptionForNewItem == 1)
                        {
                            newBag = CreateNewBagItem.CreateNewBag();
                            // it's adding to the list
                            Console.WriteLine("Bag has been created");
                        }
                        else // without wrapping the else, it will always execute this line because there is no condition
                        {
                            newShoe = CreateNewShoeItem.CreateNewShoe();
                            //shoeCatalogue.AddProduct(newShoe);
                            Console.WriteLine("Shoe has been created");

                        }
                        break;

                    case 2: // viewing catalogue
                        Console.WriteLine("View a catalogue");
                        Console.WriteLine("Select ONE of the options:");
                        Console.WriteLine("1) View BAG catalogue");
                        Console.WriteLine("2) View SHOE catalogue");
                        int userSelectedOptionForViewCatalogue = Convert.ToInt32(Console.ReadLine());

                        if (userSelectedOptionForViewCatalogue == 1)
                        {
                            if (bagCatalogue.DigitalCatalogue.Count == 0)
                            {
                                Console.WriteLine("Bag catalogue is empty");
                            }
                            foreach (Bag item in bagCatalogue.DigitalCatalogue)
                            {
                                Console.WriteLine(item.ProductName);
                            }

                        }
                        else
                        {
                            if (shoeCatalogue.DigitalCatalogue.Count == 0)
                            {
                                Console.WriteLine("Shoe catalogue is empty");
                            }
                            foreach (Shoe item in shoeCatalogue.DigitalCatalogue)
                            {
                                Console.WriteLine(item.ProductName);
                            }
                        }
                        break;

                    //QUESTIONS
                    // I'm unclear as to WHY im using digital catalogue
                    // How do i ADD to these catalogues.. is that the next method
                    // next step: create these as methods

                    case 3: //add to catalogue
                        Console.WriteLine("Add a product to a catalogue");
                        Console.WriteLine("Select ONE of the options:");
                        Console.WriteLine("1) Add a bag product to the BAG catalogue");
                        Console.WriteLine("2) Add a shoe product to the SHOE catalogue");
                        int userSelectedOptionForAddToCatalogue = Convert.ToInt32(Console.ReadLine());

                        if (userSelectedOptionForAddToCatalogue == 1)
                        {
                            bagCatalogue.AddProduct(newBag);
                            Console.WriteLine("Bag has been added");
                        }
                        else
                        {
                            shoeCatalogue.AddProduct(newShoe);
                            Console.WriteLine("Shoe has been added");
                        }
                        break;

                    case 4: // removing a product
                        Console.WriteLine("Remove a product to a catalogue");
                        Console.WriteLine("Select ONE of the options:");
                        Console.WriteLine("1) Remove a bag product to the BAG catalogue");
                        Console.WriteLine("2) Remove a shoe product to the SHOE catalogue");
                        int userSelectedOptionForRemoval = Convert.ToInt32(Console.ReadLine());

                        if (userSelectedOptionForRemoval == 1)
                        {
                            Console.WriteLine("Enter bag name to REMOVE from the catalogue");
                            string bagName = Console.ReadLine();
                            bagCatalogue.RemoveProduct(bagName);
                            

                            // NTS: CONDITION TO  BE ADDED to know if its been reallly been removed
                            Console.WriteLine("Bag has been REMOVED");
                        }
                        else
                        {
                            Console.WriteLine("Enter shoe name to REMOVE from the catalogue");
                            string shoeName = Console.ReadLine();
                            shoeCatalogue.RemoveProduct(shoeName);
                            Console.WriteLine("Shoe has been REMOVED");
                        }

                        break;

                    //case 5: // removing a catalogue
                    //    Console.WriteLine("Remove a catalogue\n");
                    //    break;

                    case 6:
                        exit = true;
                        break;
                }
            }
        }
    }
}