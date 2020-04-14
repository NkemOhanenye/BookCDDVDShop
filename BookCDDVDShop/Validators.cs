// Validators Class
// Responsible for all validation processing.  Includes validators that are part of VB but not CSHarp 
// Written in CSharp by Frank Friedman     Spring 2016

// Revised: June 16, 2017
// Revised: June 27, 2018

// This class contains "static" methods to handle required data validations for this Temple Owl project

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BookCDDVDShop.Classes;

// To read and write files
using System.IO;
// To serialize a persistant object
using System.Runtime.Serialization.Formatters.Binary;

namespace BookCDDVDShop.Classes
{
    // This class cannot be instantiated
    // It contains a collection of methods called to validate all input data from our Form
    public static class Validators
    {
        // Validate Form data for a Product
        public static bool ValidateProduct
           (string UPC, string price, string title, string quantity)
        {
            if (ValidateProductUPC(UPC) && ValidateProductPrice(price) && ValidateProductTitle(title) && ValidateProductQuantity(quantity))
                return true;
            else
                return false;
        }  // end ValidateProduct


        // Validate Product UPC
        public static bool ValidateProductUPC
            (string UPC)    // IN: Product's UPC (must be a 5 digit value with no preceding 0)
        {
            if (UPC == "" || UPC.Length != 5)
            {
                MessageBox.Show("Product UPC was blank or not exactly 5 characters. Re-enter.", "Product UPC Error");
                return false;
            }  // end Product UP blank

            if (UPC[0] == '0')
            {
                MessageBox.Show("Product UPC was began with a 0. Re-enter.", "Product UPC Error");
                return false;
            }

            // Using Regex to validate the Product UPC text box to contain exactly 5 digits 
            if (!System.Text.RegularExpressions.Regex.IsMatch(UPC, @"^[0-9]{5}$"))
            {
                MessageBox.Show("Product UPC must be a 5 digit value with no leading zeros. Reenter.",
                    "Regex Product UPC Error");
                return false;
            }  // end Product UPC Regex test
            return true;   // Passed all tests
        }  // end Validate ProductUPC

        // Validate Product Price
        public static bool ValidateProductPrice
            (string price) // IN: Product's price (must be greater than 0, a number and can only have 2 decimal points)
        {
            if (price == "" || price == " ")
            {
                MessageBox.Show("Product price was blank. Re-enter.", "Product price Error");
                return false;
            }

            // using Regex to validate the Product price text box to contain only digits and can only have 2 decimal points
            if (!System.Text.RegularExpressions.Regex.IsMatch(price, @"^[0-9]\d{0,2}(\.\d{1,2})?$"))
            {
                MessageBox.Show("Product price must be all numbers. Reenter.",
                    "Regex Product price Error");
                return false;
            } // end Product price Regex test
            if (Convert.ToDecimal(price) <= 0)
            {
                MessageBox.Show("Product price was less than 0. Re-enter.", "Product price Error");
                return false;
            }
            return true; // Passed all tests
        } // end Validate ProductPrice

        // Validate Product Title
        public static bool ValidateProductTitle
            (string title) // IN: Product's title (can't be blank)
        {
            if (title == "")
            {
                MessageBox.Show("Product title was blank. Re-enter.", "Product title Error");
                return false;
            }

            // using Regex to validate the Product title text box to not contain digits
            if (System.Text.RegularExpressions.Regex.IsMatch(title, @"^[0-9]"))
            {
                MessageBox.Show("Product title can't contain digits. Reenter.",
                    "Regex Product title Error");
                return false;
            } // end Product title Regex test
            return true; // Passed all tests
        } // end Validate ProductTitle

        // Validate Product Quantity
        public static bool ValidateProductQuantity
            (string quantity) // IN: Product's quantity (can't be less than 0 and must be all digits)
        {
            if (quantity == "" || quantity == " ")
            {
                MessageBox.Show("Product quantity was blank. Re-enter.", "Product quantity Error");
                return false;
            }

            // using Regex to validate the Product quantiy text box to contain only digits
            if (!System.Text.RegularExpressions.Regex.IsMatch(quantity, @"^[0-9]"))
            {
                MessageBox.Show("Product quantity must be all numbers. Reenter.",
                    "Regex Product quanity Error");
                return false;
            } // end Product quantity regex test

            if (Convert.ToInt32(quantity) <= 0)
            {
                MessageBox.Show("Product quantity was less than 0. Re-enter.", "Product quantity Error");
                return false;
            }
            return true; // passed all tests
        } // end Validate ProductQuantity

        // Validate Form data for a Book
        public static bool ValidateBook
           (string ISBNLeft, string ISBNRight, string author, string pages)
        {
            if (ValidateBookISBN(ISBNLeft, ISBNRight) && ValidateBookAuthor(author) && ValidateBookPages(pages))
                return true;
            else
                return false;
        }  // end ValidateBook

        // Validate Book ISBN
        public static bool ValidateBookISBN
            (string ISBNLeft, string ISBNRight) // IN: valid ISBN numbers (needs to be of length 3)
        {
            if (ISBNLeft == "" || ISBNLeft == " " || ISBNRight == "" || ISBNRight == " ")
            {
                MessageBox.Show("Book ISBN left or right was blank. Re-enter.", "Book ISBN Error");
                return false;
            }

            // using Regex to validate if the ISBN is all digits of length 3
            if (!System.Text.RegularExpressions.Regex.IsMatch(ISBNLeft, @"^[0-9]{3}$") ||
                !System.Text.RegularExpressions.Regex.IsMatch(ISBNRight, @"^[0-9]{3}$"))
            {
                MessageBox.Show("Book ISBN must be all numbers and of length 3. Reenter.",
                    "Regex Book ISBN Error");
                return false;
            } // end Book ISBN Regex tests
            return true; // passed all tests
        } // end Validate BookISBN

        // Validate Book Author
        public static bool ValidateBookAuthor
            (string author) // IN: Book Author (cant be empty nor a digit)
        {
            if (author == "")
            {
                MessageBox.Show("Book author was blank. Re-enter.", "Book author Error");
                return false;
            }

            // using Regex to validate if the author does not contain digits
            if (System.Text.RegularExpressions.Regex.IsMatch(author, @"^[0-9]"))
            {
                MessageBox.Show("Book author can't contain digits. Reenter.",
                    "Regex Book author Error");
                return false;
            } // end Book author Regex test
            return true; // passed all tests
        } // end Validate BookuAuthor

        // Validate Book Pages
        public static bool ValidateBookPages
            (string pages) // IN: Book Pages (cant be laess than 0)
        {
            if (pages == "" || pages == " ")
            {
                MessageBox.Show("Book pages was blank. Re-enter.", "Book author Error");
                return false;
            }

            // using Regex to validate if the pages is all digits
            if (!System.Text.RegularExpressions.Regex.IsMatch(pages, @"^[0-9]"))
            {
                MessageBox.Show("Book pages must be all numbers. Reenter.",
                    "Regex Book Pages Error");
                return false;
            } // end Book pages Regex tests

            if (Convert.ToInt32(pages) <= 0)
            {
                MessageBox.Show("Book pages was less than 0. Re-enter.", "Book pages Error");
                return false;
            }
            return true; // passed all tests
        } // end Validate BookPages

        // Validate Form data for a Book
        public static bool ValidateCISBook
           (string CISArea)
        {
            if (ValidateCISBookCISArea(CISArea))
                return true;
            else
                return false;
        }  // end ValidateCISBook

        // Validate CISBook CISArea
        public static bool ValidateCISBookCISArea
            (string CISArea) // IN: CISArea dropdown (cant be empty)
        {
            if (CISArea == "")
            {
                MessageBox.Show("CISBook CISArea was blank. Re-enter.", "CISBook CISArea Error");
                return false;
            }
            return true; // passed all tests
        } // end Validate CISBookCISArea

        // Validate Form data for a DVD
        public static bool ValidateDVD
            (string leadActor, string releaseDate, string runTime)
        {
            if (ValidateDVDLeadActor(leadActor) && ValidateDVDReleaseDate(releaseDate) && ValidateDVDRunTime(runTime))
                return true;
            else
                return false;
        } // end ValidateDVD

        // Validate DVD leadActor
        public static bool ValidateDVDLeadActor
            (string leadActor) // IN: DVD leadActor (cant be empty, seperated by spaces)
        {
            if (leadActor == "")
            {
                MessageBox.Show("DVD leadActor was blank. Re-enter.", "DVD leadActor Error");
                return false;
            }
            // using Regex to validate if the leadActor does not contain digits
            if (System.Text.RegularExpressions.Regex.IsMatch(leadActor, @"^[0-9]"))
            {
                MessageBox.Show("DVD leadActor can't contain digits. Reenter.",
                    "Regex DVD leadActor Error");
                return false;
            } // end Product title Regex test
            return true; // passed all tests
        } // end Validate DVDLeadActor

        // Validate DVD ReleaseDate 
        public static bool ValidateDVDReleaseDate
            (string releaseDate) // IN: DVD releaseDate (cannot be before the first release of a DVD and before 2020)
        {
            if (releaseDate == "" || releaseDate == " ")
            {
                MessageBox.Show("DVD releaseDate was blank. Re-enter.", "DVD releaseDate Error");
                return false;
            }
            // checks is the date entered is a valid date
            try
            {
                DateTime date = Convert.ToDateTime(releaseDate);
                if (date.Year < 1980 || (date.Year == 2019 && date.Month == 12 && date.Day == 31) || date.Year > 2019)
                {
                    MessageBox.Show("DVD releaseDate not valid. Re-enter.", "DVD releaseDate Error");
                    return false;
                }
            }
            catch
            {
                MessageBox.Show("DVD releaseDate was not a valid date. Re-enter.", "DVD releaseDate Error");
                return false;
            }
            return true; // passed all tests
        }

        public static bool ValidateDVDRunTime
            (string runTime)  // IN: DVD runTime (has to be a number and greater than 0)
        {
            if (runTime == "" || runTime == " ")
            {
                MessageBox.Show("DVD runTime was blank. Re-enter.", "DVD runTime Error");
                return false;
            }

            // using Regex to validate if the runTime is all digits
            if (!System.Text.RegularExpressions.Regex.IsMatch(runTime, @"^[0-9]"))
            {
                MessageBox.Show("DVD runTime must be all numbers. Reenter.",
                    "Regex DVD runTime Error");
                return false;
            } // end DVD runTIme Regex tests

            if (Convert.ToInt32(runTime) <= 0 || Convert.ToInt32(runTime) > 240)
            {
                MessageBox.Show("DVD runTime was either too high or too low. Re-enter.", "DVD runTime Error");
                return false;
            }
            return true; // passed all tests
        } // end Validate DVDRunTime

        // Validate Form data for a CDClassical
        public static bool ValidateCDClassical
            (string label, string artists)
        {
            if (ValidateCDClassicalLabel(label) && ValidateCDClassicalArtists(artists))
                return true;
            else
                return false;
        } // end ValidateCDClassical

        // Validate CDClassical label
        public static bool ValidateCDClassicalLabel
            (string label) // IN: label (needs to be a sequence of one or more words)
        {
            if (label == "")
            {
                MessageBox.Show("CDClassical label was blank. Re-enter.", "CDClassical label Error");
                return false;
            }

            // using Regex to validate that the label does not contain any digits
            if (System.Text.RegularExpressions.Regex.IsMatch(label, @"^[0-9]"))
            {
                MessageBox.Show("CDClassical label can't contain digits. Reenter.",
                    "Regex CDClassical label Error");
                return false;
            } // end CDClassical label Regex test
            return true; // passed all tests
        } // end Validate CDClassicalLabel

        // Validate CDClassical Artists 
        public static bool ValidateCDClassicalArtists
            (string artists) // IN: artists (cant be empty and are seperated by spaces)
        {
            if (artists == "")
            {
                MessageBox.Show("CDClassical artists was blank. Re-enter.", "CDClassical artists Error");
                return false;
            }
            // using Regex to validate that the artists contains no digits
            if (System.Text.RegularExpressions.Regex.IsMatch(artists, @"^[0-9]"))
            {
                MessageBox.Show("CDClassical artists can't contain digits. Reenter.",
                    "Regex CDClassical artists Error");
                return false;
            } // end CDClassical artists Regex test
            return true; // passed all tests 
        } // end Valicate CDClassicalArtists

        // Validate Form data for a CDOrchestral
        public static bool ValidateCDOrchestral
            (string conductor)
        {
            if (ValidateCDOrchestralConductor(conductor))
                return true;
            else
                return false;
        } // end ValidateCDOrchestral

        // Validate CD OrchestralConductor 
        public static bool ValidateCDOrchestralConductor
            (string conductor)  // IN: conductor (cannot be empty and seperated by spaces, last name can have hypen)
        {
            if (conductor == "")
            {
                MessageBox.Show("CDOrchestral conductor was blank. Re-enter.", "CDOrchestral conductor Error");
                return false;
            }
            // using Regex to validate that the conductor contains no digits
            if (System.Text.RegularExpressions.Regex.IsMatch(conductor, @"^[0-9]"))
            {
                MessageBox.Show("CDOrchestral conductor can't contain digits. Reenter.",
                    "Regex CDOrchestral conductor Error");
                return false;
            } // end Product title Regex test
            return true; // passed all tests
        } // end Validate CDOrchestralConductor

        // Validate Form data for a CDChamber
        public static bool ValidateCDChamber
            (string instruments)
        {
            if (ValidateCDChamberInstruments(instruments))
                return true;
            else
                return false;
        } // end Validate CDChamber

        // Valicate CDChamberInstruments
        public static bool ValidateCDChamberInstruments
            (string instruments) // IN: instruments list (seperated between commas)
        {
            if (instruments == "")
            {
                MessageBox.Show("CDChamber instruments was blank. Re-enter.", "CDChamber instruments Error");
                return false;
            }
            return true;
        } // end Validate CDChamberInstruments
    } // end Validators class
} // end namespace