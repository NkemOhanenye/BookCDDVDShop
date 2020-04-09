/*
 * Nkem Ohanenye, Tracy Lan
 * CIS 3309 Section 001
 * Date: 4/8/2020
 * BookCDDVDShop - DVD class
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
    // inherits data and methods from the Product class and is serializable
    [Serializable()]
    class DVD : Product
    {
        private string hiddenLeadActor;
        private DateTime hiddenReleaseDate;
        private int hiddenRuntime;

        // parameterless constructor that sets the attributes as default values
        public DVD()
        {
            hiddenLeadActor = "";
            hiddenReleaseDate = DateTime.Now;
            hiddenRuntime = 0;
        }// end parameterless constructor


        // parameterized constructor sets attributes to input values
        public DVD(int UPC, decimal price, string title, int quantity,
            string actor, DateTime date, int runtime) : base(UPC, price, title, quantity)    //uses the base class Product's parameterized constructor
        {
            hiddenLeadActor = actor;
            hiddenReleaseDate = date;
            hiddenRuntime = runtime;
        }// end parameterized constructor


        // accessor/mutator for LeadActor
        public string DVDLeadActor
        {
            get                                 // to access after creating a DVD object --> objectname.DVDLeadActor
            {
                return hiddenLeadActor;
            }  
            set   // string value            // to set after creating a DVD object --> objectname.DVDLeadActor = "somevalue"
            {
                hiddenLeadActor = value;
            }  
        }// end LeadActor property

        
        // accessor/mutator for ReleaseDate
        public DateTime DVDReleaseDate
        {
            get
            {
                return hiddenReleaseDate;
            }
            set  // DateTime value
            {
                hiddenReleaseDate = value;
            }
        }// end ReleaseDate property


        // accessor/mutator for Runtime
        public int DVDRuntime
        {
            get
            {
                return hiddenRuntime;
            }
            set  // int value
            {
                hiddenRuntime = value;
            }
        }// end Runtime property


        // save data from form to object
        // base.Save(f) will save the data that is inherited from the Product class 
        // the override will additionally save data unique to DVD objects
        public override void Save(frmBookCDDVDShop f)
        {
            base.Save(f);
            hiddenLeadActor = f.txtDVDLeadActor.Text;
            hiddenReleaseDate = f.txtDVDReleaseDate.Text;
            hiddenRuntime = f.txtDVDRunTime.Text;
        } // end Save

          

        // display data in object on form
        public override void Display(frmBookCDDVDShop f)
        {
            base.Display(f);
            f.txtDVDLeadActor.Text = hiddenLeadActor;
            f.txtDVDReleaseDate.Text = hiddenReleaseDate.ToString();
            f.txtDVDRunTime.Text = hiddenRuntime.ToString();
        }  // end Display


        // this toString method overrides the Product toString method
        // the base refers to Product because this class inherits Produt by default
        public override string ToString()
        {
            string s = base.ToString() + "\n";
            s += "DVD Lead Actor: " + hiddenLeadActor + "\nDVD Release Date: " + hiddenReleaseDate + "\nDVD Runtime: " + hiddenRuntime;
            return s;
        }  // end ToString
    }
}
