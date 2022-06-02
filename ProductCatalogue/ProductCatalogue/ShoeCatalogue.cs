using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductCatalogue
{
    public class ShoeCatalogue
    {
        //Catalogue<Bag> bagCatalogue = new Catalogue<Bag>();
        Catalogue<Shoe> shoeCatalogue = new Catalogue<Shoe>();

        public void ViewShoeCatalogue()
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

    }
}
