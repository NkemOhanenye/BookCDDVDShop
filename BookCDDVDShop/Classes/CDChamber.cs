/*
 * Nkem Ohanenye, Tracy Lan
 * CIS 3309 Section 001
 * Date: 4/13/2020 (modified)
 * BookCDDVDShop - CDChamber class
 */



// CD Classical Chamber Music Class
// This is a node class (not inherited by any other class)
// Responsible for all processing related to a CD Classical Chamber Music

// Written in VB by Joseph Jupin     Fall 2009
// Converted to CSharp by Frank Friedman     Spring 2016

// Modified June 17, 2017 by Frank Friedman
// Modified June 24, 2018 by Frank Friedman
// Modified June 16, 2019 by Frank Friedman

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
// For serialization
using System.Runtime.Serialization.Formatters.Binary;

namespace BookCDDVDShop.Classes
{
    // CDClChamber inherits the data and methods in CDClassical and can be a serialized to a binary file
    [Serializable()]
    class CDChamber : CDClassical
    {
        private string hiddenInstrumentList;

        // Parameterless Constructor
        public CDChamber()
        {
            hiddenInstrumentList = "";
        }  // end Parameterless Constructor


        // Parameterized constructor
        public CDChamber(int UPC, decimal price, string title, int quantity,  // For Product Constructor
            string label, string artists, string instrumentList) : base(UPC, price, title, quantity, label, artists)
        {
            hiddenInstrumentList = instrumentList;
        }  // end parameterized constructor


        // Accessor/mutator for InstrumentList
        public string CDChamberInstrumentList
        {
            get
            {
                return hiddenInstrumentList;
            }  // end get
            set   // (string value)
            {
                hiddenInstrumentList = value;
            }  // end get
        }  // end Property


        // Save data from form to object
        public override void Save(frmBookCDDVDShop f)
        {
            base.Save(f);
            hiddenInstrumentList = f.txtCDChamberInstrumentList.Text;
        }  // end Save


        // Display data in object on form
        public override void Display(frmBookCDDVDShop f)
        {
            base.Display(f);
            f.txtCDChamberInstrumentList.Text = hiddenInstrumentList;
        }  // end Display


        // This toString function overrides the CDClassical toString function
        // The base refers to CDClassical because this class inherits CDClassical by definition 
        public override string ToString()
        {
            string s = base.ToString() + "\n";
            s += "Instrument List:  " + hiddenInstrumentList;
            return s;
        } //  end ToString

    }  // end CDChamber Class
}  // end namespace
