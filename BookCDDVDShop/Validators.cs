// Validators Class
// Responsible for all validation processing.  Includes validators that are part of VB but not CSHarp 
// Written in CSharp by Frank Friedman     Spring 2016

// Revised: June 16, 2017
// Revised: June 27, 2018

// This class contains "static" methods to handle required data validations for this Temple Owl project
//
// Last Modified by: Nkem Ohanenye, Tracy Lan
//
// Date: May 5, 2020

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
                MessageBox.Show("Product UPC began with a 0. Re-enter.", "Product UPC Error");
                return false;
            }

            // Using Regex to validate the Product UPC text box to contain exactly 5 digits 
            if (!System.Text.RegularExpressions.Regex.IsMatch(UPC, @"^[0-9]{5}$"))
            {
                MessageBox.Show("Product UPC must be a 5 digit value with no leading zeros. Re-enter.",
                    "Regex Product UPC Error");
                return false;
            }  // end Product UPC Regex test

            if (Convert.ToInt32(UPC) <= 0)
            {
                MessageBox.Show("Product UPC was less than ot equal to 0. Re-enter.", "Product UPC Error");
                return false;
            }
            return true;   // Passed all tests
        }  // end Validate ProductUPC

        // Validate Product Price
        public static bool ValidateProductPrice
            (string price) // IN: Product's price (must be greater than 0, a number and can only have 2 decimal points)
        {
            if (price == "" || price == " ")
            {
                MessageBox.Show("Product price was blank. Re-enter.", "Product Price Error");
                return false;
            }

            // removes the if it was entered, it will be added later
            if (price[0] == '$')
            {
                price = price.Remove(0); 
            }

            // using Regex to validate the Product price text box to contain only digits and can only have 2 decimal points
            if (!System.Text.RegularExpressions.Regex.IsMatch(price, @"^[0-9]\d{0,2}(\.\d{1,2})?$"))
            {
                MessageBox.Show("Product price must be all numbers and have 2 numbers after the decimal. Reenter.",
                    "Regex Product Price Error");
                return false;
            } // end Product price Regex test

            if (Convert.ToDecimal(price) <= 0)
            {
                MessageBox.Show("Product price was less than or equal to 0. Re-enter.", "Product Price Error");
                return false;
            }
            return true; // Passed all tests
        } // end Validate ProductPrice

        // Validate Product Title
        public static bool ValidateProductTitle
            (string title) // IN: Product's title (can't be blank)
        {
            string pattern = "[^\\w]"; // gets all spaces and other sentence endings
            // puts all the words into an array
            string[] words = System.Text.RegularExpressions.Regex.Split(title, pattern, System.Text.RegularExpressions.RegexOptions.IgnoreCase);
            int count = 0;

            // used to count how many words were placed in the array
            for (int i = words.GetLowerBound(0); i <= words.GetUpperBound(0); i++)
            {
                count = count + 1;
            }

            if (title == "" || count < 1)
            {
                MessageBox.Show("Product title was blank. Re-enter.", "Product Title Error");
                return false;
            }

            return true; // Passed all tests
        } // end Validate ProductTitle

        // Validate Product Quantity
        public static bool ValidateProductQuantity
            (string quantity) // IN: Product's quantity (can't be less than 0 and must be all digits)
        {
            if (quantity == "" || quantity == " ")
            {
                MessageBox.Show("Product quantity was blank. Re-enter.", "Product Quantity Error");
                return false;
            }

            // using Regex to validate the Product quantiy text box to contain only digits
            if (!System.Text.RegularExpressions.Regex.IsMatch(quantity, @"^[0-9]"))
            {
                MessageBox.Show("Product quantity must be all numbers. Re-enter.",
                    "Regex Product Quanity Error");
                return false;
            } // end Product quantity regex test

            if (Convert.ToInt32(quantity) <= 0)
            {
                MessageBox.Show("Product quantity was less than or equal to 0. Re-enter.", "Product quantity Error");
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
                MessageBox.Show("Book ISBN must be all numbers and of length 3. Re-enter.",
                    "Regex Book ISBN Error");
                return false;
            } // end Book ISBN Regex tests

            if (ISBNLeft[0] == '0')
            {
                MessageBox.Show("Book ISBNLeft began with a 0. Re-enter.", "Book ISBN Error");
                return false;
            }
            return true; // passed all tests
        } // end Validate BookISBN

        // Validate Book Author
        public static bool ValidateBookAuthor
            (string author) // IN: Book Author (cant be empty nor a digit)
        {
            string pattern = "[^\\w]"; // gets all spaces and other sentence endings
            // puts all the words into an array
            string[] words = System.Text.RegularExpressions.Regex.Split(author, pattern, System.Text.RegularExpressions.RegexOptions.IgnoreCase);
            int count = 0;

            // used to count how many words were placed in the array
            for (int i = words.GetLowerBound(0); i <= words.GetUpperBound(0); i++)
            {
                count = count + 1;
            }

            if (author == "" || count < 1)
            {
                MessageBox.Show("Book author was blank. Re-enter.", "Book Author Error");
                return false;
            }

            if (count >= 2 && !author.Contains(" "))
            {
                MessageBox.Show("Book Author words need to be seperated by a space. Re-enter.", "Book Author Error");
                return false;
            }

            if (author.Length <= 2)
            {
                MessageBox.Show("Book author was less than or equal to 2 characters. Re-enter.", "Book Author Error");
                return false;
            }

            // using Regex to validate if the author contains valid characters
            if (!System.Text.RegularExpressions.Regex.IsMatch(author, @"^[a-zA-Z-]"))
            {
                MessageBox.Show("Book author contains invalid characters. Re-enter.", "Book Author Error");
                return false;
            } // end Book Author Regex tests

            return true; // passed all tests
        } // end Validate BookuAuthor

        // Validate Book Pages
        public static bool ValidateBookPages
            (string pages) // IN: Book Pages (cant be laess than 0)
        {
            if (pages == "" || pages == " ")
            {
                MessageBox.Show("Book pages was blank. Re-enter.", "Book Author Error");
                return false;
            }

            // using Regex to validate if the pages is all digits
            if (!System.Text.RegularExpressions.Regex.IsMatch(pages, @"^[0-9]"))
            {
                MessageBox.Show("Book pages must be all numbers. Re-enter.",
                    "Regex Book Pages Error");
                return false;
            } // end Book pages Regex tests

            if (Convert.ToInt32(pages) <= 0)
            {
                MessageBox.Show("Book pages was less than or equal to 0. Re-enter.", "Book Pages Error");
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
            (string CISArea) // IN: CISArea (cant be empty, checks to see if there are a space between words)
        {
            string pattern = "[^\\w]"; // gets all spaces and other sentence endings
            // puts all the words into an array
            string[] words = System.Text.RegularExpressions.Regex.Split(CISArea, pattern, System.Text.RegularExpressions.RegexOptions.IgnoreCase);
            int count = 0;

            // used to count how many words were placed in the array
            for (int i = words.GetLowerBound(0); i <= words.GetUpperBound(0); i++)
            {
                count = count + 1;
            }

            if (CISArea == "" || count < 1)
            {
                MessageBox.Show("CISBook CISArea was blank. Re-enter.", "CISBook CISArea Error");
                return false;
            }

            if (count >= 2 && !CISArea.Contains(" "))
            {
                MessageBox.Show("CISBook CISArea words need to be seperated by a space. Re-enter.", "CISBook CISArea Error");
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
            string pattern = "[^\\w]"; // gets all spaces and other sentence endings
            // puts all the words into an array
            string[] words = System.Text.RegularExpressions.Regex.Split(leadActor, pattern, System.Text.RegularExpressions.RegexOptions.IgnoreCase);
            int count = 0;

            // used to count how many words were placed in the array
            for (int i = words.GetLowerBound(0); i <= words.GetUpperBound(0); i++)
            {
                count = count + 1;
            }

            if (leadActor == "" || count < 1)
            {
                MessageBox.Show("DVD leadActor was blank. Re-enter.", "DVD Lead Actor Error");
                return false;
            }

            if (count >= 2 && !leadActor.Contains(" "))
            {
                MessageBox.Show("DVD lead actor words need to be seperated by a space. Re-enter.", "DVD Lead Actor Error");
                return false;
            }

            if (leadActor.Length <= 2)
            {
                MessageBox.Show("DVD lead actor was less than or equal to 2 characters. Re-enter.", "DVD Lead Actor Error");
                return false;
            }

            // using Regex to validate if the leadActor contains valid characters
            if (!System.Text.RegularExpressions.Regex.IsMatch(leadActor, @"^[a-zA-Z-]"))
            {
                MessageBox.Show("DVD lead actor contains invalid characters. Re-enter.", "DVD Lead Actor Error");
                return false;
            } // end DVD Lead Actor Regex tests

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
                    MessageBox.Show("DVD releaseDate not valid (mm/dd/yyyy). Date must be after 1980 and before 2020. Re-enter.", "DVD Release Date Error");
                    return false;
                }
            }
            catch
            {
                MessageBox.Show("DVD releaseDate was not a valid date (mm/dd/yyyy). Re-enter.", "DVD Release Date Error");
                return false;
            }
            return true; // passed all tests
        }

        public static bool ValidateDVDRunTime
            (string runTime)  // IN: DVD runTime (has to be a number and greater than 0)
        {
            if (runTime == "" || runTime == " ")
            {
                MessageBox.Show("DVD runtime was blank. Re-enter.", "DVD Run Time Error");
                return false;
            }

            // using Regex to validate if the runTime is all digits
            if (!System.Text.RegularExpressions.Regex.IsMatch(runTime, @"^[0-9]"))
            {
                MessageBox.Show("DVD runtime must be all numbers. Re-enter.",
                    "Regex DVD Run Time Error");
                return false;
            } // end DVD runTIme Regex tests

            if (Convert.ToInt32(runTime) <= 0 || Convert.ToInt32(runTime) > 240)
            {
                MessageBox.Show("DVD runtime was either too high or too low. Must be greater than 0, less than 240. Re-enter.", "DVD Run Time Error");
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
            string pattern = "[^\\w]"; // gets all spaces and other sentence endings
            // puts all the words into an array
            string[] words = System.Text.RegularExpressions.Regex.Split(label, pattern, System.Text.RegularExpressions.RegexOptions.IgnoreCase);
            int count = 0;

            // used to count how many words were placed in the array
            for (int i = words.GetLowerBound(0); i <= words.GetUpperBound(0); i++)
            {
                count = count + 1;
            }

            if (label == "" || count < 1)
            {
                MessageBox.Show("CDClassical label was blank. Re-enter.", "CDClassical Label Error");
                return false;
            }
            return true; // passed all tests
        } // end Validate CDClassicalLabel

        // Validate CDClassical Artists 
        public static bool ValidateCDClassicalArtists
            (string artists) // IN: artists (cant be empty and are seperated by spaces)
        {
            string pattern = "[^\\w]"; // gets all spaces and other sentence endings
            // puts all the words into an array
            string[] words = System.Text.RegularExpressions.Regex.Split(artists, pattern, System.Text.RegularExpressions.RegexOptions.IgnoreCase);
            int count = 0;

            // used to count how many words were placed in the array
            for (int i = words.GetLowerBound(0); i <= words.GetUpperBound(0); i++)
            {
                count = count + 1;
            }

            if (artists == "" || count < 1)
            {
                MessageBox.Show("CDClassical artists was blank. Re-enter.", "CDClassical Artists Error");
                return false;
            }

            if (count >= 2 && !artists.Contains(" "))
            {
                MessageBox.Show("CDClassical artists' names need to be seperated by a space. Re-enter.", "CDClassical Artists Error");
                return false;
            }

            if (artists.Length <= 2)
            {
                MessageBox.Show("CDClassical artists was less than or equal to 2 characters. Re-enter.", "CDClassical Artists Error");
                return false;
            }

            // using Regex to validate that the artists contains no invalid characters
            if (!System.Text.RegularExpressions.Regex.IsMatch(artists, @"^[a-zA-Z,]"))
            {
                MessageBox.Show("CDClassical artists contains invalid characters. Re-enter.",
                    "Regex CDClassical Artists Error");
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
            string pattern = "[^\\w]"; // gets all spaces and other sentence endings
            // puts all the words into an array
            string[] words = System.Text.RegularExpressions.Regex.Split(conductor, pattern, System.Text.RegularExpressions.RegexOptions.IgnoreCase);
            int count = 0;

            // used to count how many words were placed in the array
            for (int i = words.GetLowerBound(0); i <= words.GetUpperBound(0); i++)
            {
                count = count + 1;
            }

            if (conductor == "" || count < 1)
            {
                MessageBox.Show("CDOrchestral conductor was blank. Re-enter.", "CDOrchestral Conductor Error");
                return false;
            }

            if (count >= 2 && !conductor.Contains(" "))
            {
                MessageBox.Show("CDClassical conductor names need to be seperated by a space. Re-enter.", "CDClassical Conductor Error");
                return false;
            }

            if (conductor.Length <= 2)
            {
                MessageBox.Show("CDClassical conductor was less than or equal to 2 characters. Re-enter.", "CDClassical Conductor Error");
                return false;
            }

            // using Regex to validate that the conductor contains valid characters
            if (!System.Text.RegularExpressions.Regex.IsMatch(conductor, @"^[a-zA-Z-]"))
            {
                MessageBox.Show("CDOrchestral conductor can't contain invalid characters. Re-enter.",
                    "Regex CDOrchestral Conductor Error");
                return false;
            } // end CDOrchestral conductor Regex test

            return true; // passed all tests
        } // end Validate CDOrchestralConductor

        // Validate Form data for a CDChamber
        public static bool ValidateCDChamber
            (string instruments)
        {
            if (ValidateCDChamberInstrumentsList(instruments))
                return true;
            else
                return false;
        } // end Validate CDChamber

        // Valicate CDChamberInstruments
        public static bool ValidateCDChamberInstrumentsList
            (string instruments) // IN: instruments list (cant be blank, seperated between commas)
        {
            string pattern = "[^\\w]"; // gets all spaces and other sentence endings
            // puts all the words into an array
            string[] words = System.Text.RegularExpressions.Regex.Split(instruments, pattern, System.Text.RegularExpressions.RegexOptions.IgnoreCase);
            int count = 0;

            // used to count how many words were placed in the array
            for (int i = words.GetLowerBound(0); i <= words.GetUpperBound(0); i++)
            {
                count = count + 1;
            }

            if (instruments == "" || count < 1)
            {
                MessageBox.Show("CDChamber instruments was blank. Re-enter.", "CDChamber Instruments Error");
                return false;
            }

            if (count >= 2 && !instruments.Contains(","))
            {
                MessageBox.Show("CDChamber instruments need to be seperated by commas. Re-enter.", "CDChamber Instruments Error");
                return false;
            }

            if (instruments.Length <= 2)
            {
                MessageBox.Show("CDChamber instruments was less than or equal to 2 characters. Re-enter.", "CDChamber Instruments Error");
                return false;
            }

            // using Regex to validate that the instruments contains valid characters
            if (!System.Text.RegularExpressions.Regex.IsMatch(instruments, @"^[a-zA-Z-,]"))
            {
                MessageBox.Show("CDChamber instruments can't contain invalid characters. Re-enter.",
                    "Regex CDChamber Instruments Error");
                return false;
            } // end CDChamber instruments Regex test
            return true;
        } // end Validate CDChamberInstruments
    } // end Validators class
} // end namespace