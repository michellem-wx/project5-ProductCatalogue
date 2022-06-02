using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductCatalogue
{
    public class Menu
    {
        // Creating 2 pre-existing lists (based on the catalogue class)
        Catalogue<Bag> bagCatalogue = new Catalogue<Bag>();
        Catalogue<Shoe> shoeCatalogue = new Catalogue<Shoe>();

        //QUESTIONS:
        // Why should I add pre-existing lists/catalogues in Menu


        public void displayMenuOptions()
        {
            Console.WriteLine("PRODUCT DATA LIBRARY\n");
            Console.WriteLine("Please select an option from the menu\nby adding the number only:");
            Console.WriteLine("1) Create new product");
            Console.WriteLine("2) View a catalogue");
            Console.WriteLine("3) Add a product to a catalogue");
            Console.WriteLine("4) Remove a product");
            Console.WriteLine("5) Remove a catalogue\n");
        }

        public void selectOptionFromMenu()
        {
            // Add in the switch case
            // As a user, I should be able to select an option from the menu

            int userSelectedOption = Convert.ToInt32(Console.ReadLine());
            //int result = 0;
            
            switch (userSelectedOption)
            {
                case 1: // creating new product
                    Console.WriteLine("Select ONE of the options:");
                    Console.WriteLine("1) Create new bag product");
                    Console.WriteLine("2) Create new shoe product");
                    int userSelectedOptionForNewItem = Convert.ToInt32(Console.ReadLine());

                    if (userSelectedOptionForNewItem == 1)
                    {
                        CreateNewBagItem.CreateNewBag();
                    }
                    CreateNewShoeItem.CreateNewShoe();
                    break;

                case 2: // viewing catalogue
                    Console.WriteLine("View a catalogue");
                    Console.WriteLine("Select ONE of the options:");
                    Console.WriteLine("1) View BAG catalogue");
                    Console.WriteLine("2) View SHOE catalogue");
                    int userSelectedOptionForViewCatalogue = Convert.ToInt32(Console.ReadLine());

                    if (userSelectedOptionForViewCatalogue == 1)
                    {
                        foreach (Bag item in bagCatalogue.DigitalCatalogue)
                        {
                            Console.WriteLine(item.ProductName);
                        }
                    }
                    foreach (Shoe item in shoeCatalogue.DigitalCatalogue)
                    {
                        Console.WriteLine(item.ProductName);
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
                        foreach (Bag item in bagCatalogue.DigitalCatalogue)
                        {
                            Console.WriteLine(item.ProductName);
                        }
                    }
                    foreach (Shoe item in shoeCatalogue.DigitalCatalogue)
                    {
                        Console.WriteLine(item.ProductName);
                    }


                    break;
                case 4: // removing a product
                    Console.WriteLine("Remove a product");
                    break;
                case 5: // removing a catalogue
                    Console.WriteLine("Remove a catalogue\n");
                    break;
                default:
                    {
                        displayMenuOptions();
                        break;
                    }
            }
        }
    }
}