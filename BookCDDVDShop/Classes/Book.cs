/*
 * Nkem Ohanenye, Tracy Lan
 * CIS 3309 Section 001
 * Date: 5/3/2020
 * BookCDDVDShop - Book class
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
    // Inherits data and methods from Product class and is serializable
    [Serializable()]
    class Book : Product
    {
        private int hiddenISBNLeft;
        private int hiddenISBNRight;
        private string hiddenAuthor;
        private int hiddenPages;

        // Parameterless constructor
        public Book()
        {
            hiddenISBNLeft = 0;
            hiddenISBNRight = 0;
            hiddenAuthor = "";
            hiddenPages = 0;
        }// end parameterless constructor


        // Parameterized constructor
        public Book(int UPC, decimal price, string title, int quantity, int ISBNLeft, int ISBNRight,
            string author, int pages) : base(UPC, price, title, quantity)
        {
            hiddenISBNLeft = ISBNLeft;
            hiddenISBNRight = ISBNRight;
            hiddenAuthor = author;
            hiddenPages = pages;
        }// end parameterized constructor


        // Accessors/mutators for Book attributes
        public int BookISBNLeft
        {
            get                                 
            {
                return hiddenISBNLeft;
            }
            set  // int value
            {
                hiddenISBNLeft = value;
            }
        }// end BookISBNLeft property

        public int BookISBNRight
        {
            get
            {
                return hiddenISBNRight;
            }
            set  // int value
            {
                hiddenISBNRight = value;
            }
        }// end BooKISBNRight property

        public string BookAuthor
        {
            get
            {
                return hiddenAuthor;
            }
            set  // string value
            {
                hiddenAuthor = value;
            }
        }// end BookAuthor property

        public int BookPages
        {
            get
            {
                return hiddenPages;
            }
            set  // int value
            {
                hiddenPages = value;
            }
        }// end BookPages property


        // Save data from form to object
        // base.Save(f) will save the data that is inherited from the Product class 
        // The override will additionally save data unique to Book objects
        public override void Save(frmBookCDDVDShop f)
        {
            base.Save(f);
            hiddenISBNLeft = Convert.ToInt32(f.txtBookISBNLeft.Text);
            hiddenISBNRight = Convert.ToInt32(f.txtBookISBNRight.Text);
            hiddenAuthor = f.txtBookAuthor.Text;
            hiddenPages = Convert.ToInt32(f.txtBookPages.Text);
        } // end Save


        // Display data in object on form
        public override void Display(frmBookCDDVDShop f)
        {
            base.Display(f);
            f.txtBookISBNLeft.Text = hiddenISBNLeft.ToString();
            f.txtBookISBNRight.Text = hiddenISBNRight.ToString();
            f.txtBookAuthor.Text = hiddenAuthor;
            f.txtBookPages.Text = hiddenPages.ToString();
        } // end Display


        // This toString method overrides the Product toString method
        // The base refers to Product because this class inherits Produt by default
        public override string ToString()
        {
            string s = base.ToString() + "\n";
            s += "Book ISBN:\t\t" + hiddenISBNLeft + "-" + hiddenISBNRight + "\n";
            s += "Book Author:\t\t" + hiddenAuthor + "\n"; 
            s += "Number of Pages:\t\t" + hiddenPages;
            return s;
        }  // end ToString

    }// end Book class

}// end namespace
