// Classical CD Class
// This node is inherited by the Classical Orchestra CD and Classical Chamber Music CD classes
// Responsible for all processing related to a Classical Music CD

// Written in VB by Joseph Jupin     Fall 2009
// Converted to CSharp by Frank Friedman     Spring 2016

// Revised June 17, 2017 by Frank Friedman
// Revised June 16, 2019 by Frank Friedman

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
// For serialization
using System.Runtime.Serialization.Formatters.Binary;
// using BookCDDVDShop.Classes;

namespace BookCDDVDShop.Classes
{
    // CDClassical inherits the data and methods in Product
    [Serializable()]
    public abstract class CDClassical : Product
    {
        private string hiddenLabel;
        private string hiddenArtists;

        // Parameterless Constructor
        public CDClassical()
        {
            hiddenLabel = "";
            hiddenArtists = "";

        } // end CDClassical Parameterless Constructor


        // Parameterized Constructor
        public CDClassical(int UPC, decimal price, string title, int quantity,
            string label, string artists) : base(UPC, price, title, quantity)    //uses the base class Product's parameterized constructor
        {
            hiddenLabel = label;
            hiddenArtists = artists;
        }  // end Employee Parameterized Constructor


        // Accessor/mutator for CD Label
        public string CDClassicalLabel
        {
            get
            {
                return hiddenLabel;
            }  // end get
            set   // (string value)
            {
                hiddenLabel = value;
            }  // end get
        }  // end Property


        // Accessor/mutator for CD Artists
        public string CDClassicalArtists
        {
            get
            {
                return hiddenArtists;
            }  // end get
            set   // (string value)
            {
                hiddenArtists = value;
            }  // end get
        }  // end Property


        // Save data from form to object
        // base.Save(f) will save the data that is inherited from the Product class; 
        // the override will additionally save data unique to CDClassical objects
        public override void Save(frmBookCDDVDShop f)
        {
            base.Save(f);
            hiddenLabel = f.txtCDClassicalLabel.Text;
            hiddenArtists = f.txtCDClassicalArtists.Text;
        } // end Save


        // Display data in object on form
        public override void Display(frmBookCDDVDShop f)
        {
            base.Display(f);
            f.txtCDClassicalLabel.Text = hiddenLabel;
            f.txtCDClassicalArtists.Text = hiddenArtists.ToString();
        }  // end Display


        // This toString function overrides the Product toString fuction
        // The base refers to Product because this class inherits Produt by default.
        public override string ToString()
        {
            string s = base.ToString() + "\n";
            s += "CDClassical Label: " + hiddenLabel + "\nCDClassical Artists: " + hiddenArtists;
            return s;
        }  // end ToString

    }  // end CDClassical class
}  // end namespace  
