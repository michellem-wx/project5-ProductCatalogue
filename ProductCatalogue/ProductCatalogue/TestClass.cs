using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductCatalogue
{
    public class TestClass
    {

        // Create a method to dynamically add items into the list
        public static void Run()
        {
            string userInput;
            bool addProduct = false;

            while (!addProduct)
            {
                Console.WriteLine("Create a new SHOE product:");
                Console.WriteLine("Add in the product name:");
                string productName = Console.ReadLine();

                Console.WriteLine("Add in price:");
                double price = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Add in brand name:");
                string brand = Console.ReadLine();

                Console.WriteLine("Add in colour:");
                string colour = Console.ReadLine();

                Console.WriteLine("Add in gender:");
                string gender = Console.ReadLine();

                Console.WriteLine("Add in width:");
                int width = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Add in height:");
                int height = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Add in depth:");
                int depth = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Add in category:");
                string category = Console.ReadLine();

                Bag.CreateABag(productName, price, brand, colour, width, height, depth, category);

                // add in the bag function here
                //Shoe newItem = new Shoe(productName, price, brand, colour, gender);
                break;

            }
        }
    }
}

