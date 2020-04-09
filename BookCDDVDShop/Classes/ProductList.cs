/*
 * Nkem Ohanenye, Tracy Lan
 * CIS 3309 Section 001
 * Date: 4/8/2020
 * BookCDDVDShop - Product List class
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// For serialization
using System.Runtime.Serialization.Formatters.Binary;

namespace BookCDDVDShop.Classes
{
    // used to contain a list of Product objects
    [Serializable()]
    public class ProductList
    {
        private List<Product> hiddenProductList = new List<Product>();

        // parameterless constructor
        public ProductList()
        {

        }// end parameterless constructor


        // adds a product to the list
        public void Add(Product p)
        {
            hiddenProductList.Add(p);
        }// end add method


        // get the number of products in the list (?)
    }
}
