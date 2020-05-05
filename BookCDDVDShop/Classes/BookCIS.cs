/*
 * Nkem Ohanenye, Tracy Lan
 * CIS 3309 Section 001
 * Date: 5/3/2020
 * BookCDDVDShop - BookCIS class
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
    // inherits from the Book class and is serializable
    [Serializable()]
    class BookCIS : Book
    {
        private string hiddenCISArea;

        // Parameterless constructor
        public BookCIS()
        {
            hiddenCISArea = "";
        }// end parameterless constructor


        // Parameterized constructor
        public BookCIS(int UPC, decimal price, string title, int quantity, int ISBNLeft, int ISBNRight, string author,
            int pages, string CISArea) : base(UPC, price, title, quantity, ISBNLeft, ISBNRight, author, pages)
        {
            hiddenCISArea = CISArea;

        }// end parameterized constructor


        // Accessor/mutator for hiddenCISArea
        public string BookCISCISArea
        {
            get
            {
                return hiddenCISArea;
            }
            set  // string value
            {
                hiddenCISArea = value;
            }
        }// end BookISBNLeft property


        // Save data from form to object
        // base.Save(f) will save the data that is inherited from the Book class 
        // The override will additionally save data unique to BookCIS objects
        public override void Save(frmBookCDDVDShop f)
        {
            base.Save(f);
            hiddenCISArea = f.txtBookCISCISArea.Text;
        } // end Save


        // Display data in object on form
        public override void Display(frmBookCDDVDShop f)
        {
            base.Display(f);
            f.txtBookCISCISArea.Text = hiddenCISArea;

        } // end Display


        // This toString method overrides the Product toString method
        // The base refers to Product because this class inherits Produt by default
        public override string ToString()
        {
            string s = base.ToString() + "\n";
            s += "BookCIS CIS Area:\t\t" + hiddenCISArea;
            return s;
        }  // end ToString

    }// end Book class

}// end namespace


