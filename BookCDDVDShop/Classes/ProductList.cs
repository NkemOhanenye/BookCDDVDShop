/*
 * Nkem Ohanenye, Tracy Lan
 * CIS 3309 Section 001
 * Date: 5/3/2020
 * BookCDDVDShop - Product List class
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
// For serialization
using System.Runtime.Serialization.Formatters.Binary;


namespace BookCDDVDShop.Classes
{
    // Used to contain a list of Product objects
    [Serializable()]
    public class ProductList
    {
        private List<Product> hiddenProductList = new List<Product>();

        // Parameterless constructor
        public ProductList()
        {

        }// end parameterless constructor


        // Accessor for ProductList
        public List<Product> getProductList
        {
            get
            {
                return hiddenProductList;
            }
        }// end getProductList property


        // Adds a product to the list
        public void Add(Product p)
        {
            hiddenProductList.Add(p);
        }// end add method


        // Returns the number of products in the list 
        public int Count()
        {
            return hiddenProductList.Count;
        }


        // Deletes an item from the list given the item's index
        public void removeItem(int i)
        {
            hiddenProductList.Remove(hiddenProductList[i]);
        }


        // Get or set an item in the List
        public Product getAnItem(int i)
        {
            return hiddenProductList[i];
        } // end getAnItem

        public void setAnItem(int i, Product value)
        {
            hiddenProductList[i] = value;
        } // end set


        // Displays the products in the list in a MessageBox
        public void displayProductList()
        {
            string itemsInList = "";

            foreach(Product item in hiddenProductList)
            {
                itemsInList += item.ToString() + "\n\n";
            }
            MessageBox.Show(itemsInList, "List of Products");

        }// end displayProductList method

    }// end ProductList class

}// end namespace
