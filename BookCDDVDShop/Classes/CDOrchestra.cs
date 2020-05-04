/*
 * Nkem Ohanenye, Tracy Lan
 * CIS 3309 Section 001
 * Date: 4/13/2020
 * BookCDDVDShop - CDOrchestra class
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
    //inherits data and methods from CDClassical and is serializable
    [Serializable()]
    class CDOrchestra : CDClassical
    {
        private string hiddenConductor;

        // Parameterless Constructor
        public CDOrchestra()
        {
            hiddenConductor = "";
        }  // end Parameterless Constructor


        // Parameterized constructor
        public CDOrchestra(int UPC, decimal price, string title, int quantity,  
            string label, string artists, string conductor) : base(UPC, price, title, quantity, label, artists)
        {
            hiddenConductor = conductor;
        }  // end parameterized constructor


        // Accessor/mutator for hiddenConductor
        public string CDOrchestraConductor
        {
            get
            {
                return hiddenConductor;
            }  // end get
            set   // (string value)
            {
                hiddenConductor = value;
            }  // end get
        }  // end Property


        // Save data from form to object
        public override void Save(frmBookCDDVDShop f)
        {
            base.Save(f);
            hiddenConductor = f.txtCDOrchestraConductor.Text;
        }  // end Save


        // Display data in object on form
        public override void Display(frmBookCDDVDShop f)
        {
            base.Display(f);
            f.txtCDOrchestraConductor.Text = hiddenConductor;
        }  // end Display


        // This toString function overrides the CDClassical toString function
        // The base refers to CDClassical because this class inherits CDClassical by definition 
        public override string ToString()
        {
            string s = base.ToString() + "\n";
            s += "Conductor:\t\t" + hiddenConductor;
            return s;
        } //  end ToString

    }  // end CDOrchestra Class
}  // end namespace

