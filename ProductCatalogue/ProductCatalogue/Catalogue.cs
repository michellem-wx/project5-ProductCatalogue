using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductCatalogue
{
    #region NTS
    // The type is the Product class (aka the constraint)
    // The constraint is used to bound type Product to catalogue
    // This means we can only make a catalogue of products
    // https://stackoverflow.com/questions/3786774/in-c-sharp-what-does-where-t-class-mean


    // Q. Generics in use? yes 
    #endregion
    public class Catalogue<T> where T : Product
    {

        // Properties of a catalogue
        // Declaring: the type is List, variable name is Digital catalogue, and it is creating a new (generic) list

        public List<T> DigitalCatalogue = new List<T>();

        //Constructor of catalogue
        public Catalogue()
        {
            DigitalCatalogue = new List<T>();
        }


        // ADDING PRODUCTS
        public void AddProduct(T product)
        {
            DigitalCatalogue.Add(product);
        }
    }
}
        // Create a method to dynamically add items into the list
        //public void Run()
        //{
        //    string userInput;
        //    bool addProduct = false;

        //    while (!addProduct)
        //    {
        //        Console.WriteLine("Add in the product name:");
        //        string productName = Console.ReadLine();

        //        Console.WriteLine("Add in price:");
        //        double price = Convert.ToDouble(Console.ReadLine());

        //        Console.WriteLine("Add in brand name:");
        //        string brand = Console.ReadLine();

        //        Console.WriteLine("Add in colour:");
        //        string colour = Console.ReadLine();

        //        Console.WriteLine("Add in gender:");
        //        string gender = Console.ReadLine();

        //        T newItem = new T(productName, price, brand, colour, gender);

        //        DigitalCatalogue.Add(T );
        //    }

        //do
        //{
        //    Console.WriteLine("Do you want to create new product to the Digital Catalogue?");
        //    Console.WriteLine("Add in the product name:");
        //    string productName = Console.ReadLine();

        //    Console.WriteLine("Add in price:");
        //    double price = Convert.ToDouble(Console.ReadLine());    

        //    Console.WriteLine("Add in brand name:");
        //    string brand = Console.ReadLine();

        //    Console.WriteLine("Add in colour:");
        //    string colour = Console.ReadLine();

        //    Console.WriteLine("Add in gender:");
        //    string gender = Console.ReadLine();

        //    Shoe newItem = new Shoe(productName, price, brand, colour, gender);
        //}




        // **METHOD TO BE ADDED** | CALCULATETOTAL

        // Calculate the total of each item in the catalogue
        // Use a method called: CalculateTotal()
        //public double CalculateTotal()
        //{
        //    double TotalAllItems = 0;
        //    foreach (Product item in DigitalCatalogue)
        //    {
        //        TotalAllItems += item.CalculateTax();
        //    }
        //    return TotalAllItems;
        //}

