using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductCatalogue
{

    // The type is the Product class (aka the constraint)
    // The constraint is used to bound type Product to catalogue
    // This means we can only make a catalogue of products
    // https://stackoverflow.com/questions/3786774/in-c-sharp-what-does-where-t-class-mean
    
    
    // Q. Generics in use? yes
    internal class Catalogue<T> where T: Product
    {
        // Create a new list to add Product objects
        // catalogue is not a list, but list inside a catalogue
        
        // STORAGE of catalogue and what it's going to look like
        // Is this a constructor
        public List<T> DigitalCatalogue = new List<T>();

        // Adding Product objects to the List: DigitalCatalogue
        // Takes in a Product
        public void AddProduct(T product)
        {
            DigitalCatalogue.Add(product);
        }


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
    }
}
