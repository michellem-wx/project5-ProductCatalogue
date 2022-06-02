using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductCatalogue
{
    #region Abstract NTS
    // Product is your ABSTRACT class of a PRODUCT
    // It will be the base class in which derived classes will inherit everything in here
    // Internal class to change to ABSTRACT class Product (done) 
    #endregion
    public abstract class Product //:Object
    {
        public double Price;
        public string ProductName;
        public string Brand;
        public string Colour;

        #region Questions
        // Q. if this is an abstract class, how come this method has a body?
        // Should this be: public abstract void double CalculateTax () 
        // Q. Not sure what parameters im supposed to pass..
        // Confused with generics 

        // THIS IS FINE (leave as is)
        // You can have bodys in an abstract method, just us 'virtual'
        #endregion
        public virtual double CalculateTax(double Price)
        {
            return Math.Round((Price * 1.1),2);

        }
    }
}


