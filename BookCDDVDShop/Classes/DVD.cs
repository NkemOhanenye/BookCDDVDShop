/*
 * Nkem Ohanenye, Tracy Lan
 * CIS 3309 Section 001
 * Date: 5/3/2020
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
    // Inherits data and methods from the Product class and is serializable
    [Serializable()]
    class DVD : Product
    {
        private string hiddenLeadActor;
        private DateTime hiddenReleaseDate;
        private int hiddenRuntime;

        // Parameterless constructor that sets the attributes as default values
        public DVD()
        {
            hiddenLeadActor = "";
            hiddenReleaseDate = DateTime.Today;
            hiddenRuntime = 0;
        }// end parameterless constructor


        // Parameterized constructor sets attributes to input values
        public DVD(int UPC, decimal price, string title, int quantity,
            string actor, DateTime date, int runtime) : base(UPC, price, title, quantity)    //uses the base class Product's parameterized constructor
        {
            hiddenLeadActor = actor;
            hiddenReleaseDate = date;
            hiddenRuntime = runtime;
        }// end parameterized constructor


        // Accessor/mutator for LeadActor
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

        
        // Accessor/mutator for ReleaseDate
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


        // Accessor/mutator for Runtime
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


        // Save data from form to object
        // base.Save(f) will save the data that is inherited from the Product class 
        // The override will additionally save data unique to DVD objects
        public override void Save(frmBookCDDVDShop f)
        {
            base.Save(f);
            hiddenLeadActor = f.txtDVDLeadActor.Text;
            hiddenReleaseDate = Convert.ToDateTime(f.txtDVDReleaseDate.Text);
            hiddenRuntime = Convert.ToInt32(f.txtDVDRunTime.Text);
        } // end Save

          

        // Display data in object on form
        public override void Display(frmBookCDDVDShop f)
        {
            base.Display(f);
            f.txtDVDLeadActor.Text = hiddenLeadActor;
            f.txtDVDReleaseDate.Text = hiddenReleaseDate.ToShortDateString();  // only displays month, day, year
            f.txtDVDRunTime.Text = hiddenRuntime.ToString();
        }  // end Display


        // This toString method overrides the Product toString method
        // The base refers to Product because this class inherits Produt by default
        public override string ToString()
        {
            string s = base.ToString() + "\n";
            s += "DVD Lead Actor:\t\t" + hiddenLeadActor + "\n";
            s += "DVD Release Date:\t\t" + hiddenReleaseDate.ToShortDateString() + "\n";
            s += "DVD Runtime:\t\t" + hiddenRuntime;
            return s;
        }  // end ToString

    }// end class DVD

}// end namespace 
