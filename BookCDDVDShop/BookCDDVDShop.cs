/*Modified by:
 * Nkem Ohanenye, Tracy Lan
 * CIS 3309 Section 001
 * Date: 4/13/2020
 * BookCDDVDShop - Main Form class
 */


// Code behind Main Form for BookDVDCDShop Project
// Written in 2008 by Joe Jupin

// Modified April 27, 2016 by Frank Friedman   Ver 20
// Updated 11/18/2016 by Elliot Stoner Ver 21
// Uodated 06/17/2017 by Frank Friedman Ver 42
// Updated 06/27/2018 by Frank Friedman Ver 50
// Updated 06/18/2019 by Frank Friedman Ver 51

// Manages all activities behind all controls on the Project form.

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
// using System.IO;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BookCDDVDShop.Classes;

// To serialize a persistant object
using System.Runtime.Serialization.Formatters.Binary;

namespace BookCDDVDShop
{
    public partial class frmBookCDDVDShop : Form
    {
        // This is a class object that manages a List of Products		
        ProductList thisProductList = new ProductList();

        // This index keeps track of the current Product
        int currentIndex = -1;

        int recordsProcessedCount = 0;
        // File to read or write to
        string FileName = "PersistentObject.bin";

        // Database methods and attributes stored here
        // ProductDB dbFunctions = new ProductDB();// Parameterless Constructor for fmrEmpMan
        public frmBookCDDVDShop()
        {
            InitializeComponent();
        }  // end frmEmpMan Parameterless Constructor


        // Tooltip messages
        string ttCreateCDChamber = "Click to enter Make CDChamber mode to add a CDChamber to the List of Products.";
        string ttCreateCDOrchestra = "Click to enter Make CDOrchestra mode to add a CDOrchestra to the List of Products.";
        string ttCreateBook = "Click to enter Make Book mode to add a Book to the List of Products.";
        string ttCreateBookCIS = "Click to enter Make BookCIS mode to add a BookCIS to the List of Products.";
        string ttCreateDVD = "Click to enter Make DVD mode to add a DVD to the List of Products.";
        string ttSaveCDChamber = "Click to Save a CDChamber object to the List of Products.";
        string ttSaveCDOrchestra = "Click to Save a CDOrchestra object to the List of Products.";
        string ttSaveBookCIS = "Click to Save a BookCIS object to the list of Products.";
        string ttSaveBook = "Click to Save the Book object to the List of Products.";
        string ttSaveDVD = "Click to Save the DVD to the List of Products.";
        string ttClear = "Click to Clear Form.";
        string ttFind = "Click to Find a Product in the List of Products.";
        string ttDelete = "Click to Delete Product from the List of Products.";
        string ttEdit = "Click to Edit a Product's data.";
        string ttExit = "Click to exit application.";

        // ?????????? Fix The Specs (in red) for Each Item ??????????

        string ttProductUPC = "Enter a 5 digit integer - no leading zeros";
        string ttProductPrice = "Enter dollars and cents >= 0.0. NO $. Exactly two decimal digits";
        string ttProductTitle = "Enter a string of words (all letters) separated by blanks for any item in the shop";
        string ttProductQuantity = "Enter any integer greater than or equal to 0";
        string ttBookISBN = "Enter Book ISBN in format nnn-nnn)";
        string ttBookAuthor = "Enter Book Author first and last names (all letters) separated by a blank";
        string ttBookPages = "Enter Book page count as an integer greater than 0.";
        string ttDVDLeadActor = "Enter DVD Lead Actor with first and last names (all letters) separated by a blank.";
        string ttDVDReleaseDate = "Enter DVD Release Date in form mm/dd/yyyy between Jan 1 1980 and Dec 31 2019. Use date picker.";
        string ttDVDRunTime = "Enter DVD run time in minutes. Must be a positive integer.";
        string ttBookCISCISArea = "Enter valid CIS area of study using a drop-down menu.";
        string ttCDClassicalLabel = "Enter any sequence of words (all letters) separated by blanks.";
        string ttCDClassicalArtists = "Enter soloists last names separated by a blank";
        string ttCDChamberInstrumentList = "Enter Instrument names separated by a blank";
        string ttCDOrchestraConductor = "Enter Conductor last name with all letters and one blank or one hyphen";

        //*****This section has the forms load and closing events

        // This sub is called when the form is loaded
        private void frmBookCDDVDShop_Load(System.Object sender, System.EventArgs e)
        {
            // Read serialized binary data file
            SFManager.readFromFile(ref thisProductList, FileName);
            FormController.clear(this);

            // get initial Tooltips
            toolTip1.SetToolTip(btnCreateBookCIS, ttCreateBookCIS);
            toolTip1.SetToolTip(btnCreateBook, ttCreateBook);
            toolTip1.SetToolTip(btnCreateCDChamber, ttCreateCDOrchestra);
            toolTip1.SetToolTip(btnCreateCDOrchestra, ttCreateDVD);
            toolTip1.SetToolTip(btnCreateDVD, ttCreateCDChamber);

            toolTip1.SetToolTip(btnClear, ttClear);
            toolTip1.SetToolTip(btnDelete, ttDelete);
            toolTip1.SetToolTip(btnEdit, ttEdit);
            toolTip1.SetToolTip(btnFind, ttFind);
            toolTip1.SetToolTip(btnExit, ttExit);

            toolTip1.SetToolTip(txtProductUPC, ttProductUPC);
            toolTip1.SetToolTip(txtProductPrice, ttProductPrice);
            toolTip1.SetToolTip(txtProductQuantity, ttProductQuantity);
            toolTip1.SetToolTip(txtProductTitle, ttProductTitle);
            toolTip1.SetToolTip(txtCDOrchestraConductor, ttCDOrchestraConductor);
            toolTip1.SetToolTip(txtBookISBNLeft, ttBookISBN);
            toolTip1.SetToolTip(txtBookAuthor, ttBookAuthor);
            toolTip1.SetToolTip(txtBookPages, ttBookPages);
            toolTip1.SetToolTip(txtDVDLeadActor, ttDVDLeadActor);
            toolTip1.SetToolTip(txtDVDReleaseDate, ttDVDReleaseDate);
            toolTip1.SetToolTip(txtDVDRunTime, ttDVDRunTime);
            toolTip1.SetToolTip(txtCDClassicalLabel, ttCDClassicalLabel);
            toolTip1.SetToolTip(txtCDClassicalArtists, ttCDClassicalArtists);
            toolTip1.SetToolTip(txtCDOrchestraConductor, ttCDOrchestraConductor);
            toolTip1.SetToolTip(txtCDChamberInstrumentList, ttCDChamberInstrumentList);
            toolTip1.SetToolTip(txtBookCISCISArea, ttBookCISCISArea);
            toolTip1.SetToolTip(btnCreateBookCIS, ttCreateBookCIS);
        } // end frmEBookCDDVDShop_Load



        // Checks if Product List is empty and, if not, copies the data for the
        // ith Product to the appropriate group textboxes using the display sub.
        // Also checks to determine if the next button should be enabled.
        private void getItem(int i)
        {
            if (thisProductList.Count() == 0)
            {
                btnDelete.Enabled = false;
                btnEdit.Enabled = false;
                // btnToString.Enabled = false;
                lblUserMessage.Text = "Please select an operation";
            }
            else if (i < 0 || i >= thisProductList.Count())
            {
                MessageBox.Show("getItem error: index out of range");
                return;
            }
            else
            {
                currentIndex = i;
                thisProductList.getAnItem(i).Display(this);
                lblUserMessage.Text = "Object Type: " +
                   thisProductList.getAnItem(i).GetType().ToString() +
                   " List Index: " + i.ToString();
                btnFind.Enabled = true;
                btnDelete.Enabled = true;
                btnEdit.Enabled = true;
            }  // end else
        } // end getItem


        // Searches through the product list to find an item with the given UPC
        // Returns true if found and false otherwise
        private bool findAnItem(string s)
        {
            if (s.Equals("Edit/Update"))
            {
                int givenUPC = Convert.ToInt32(txtProductUPC.Text);
                foreach (Product p in thisProductList.getProductList)
                {
                    if (p.ProductUPC == givenUPC)
                    {
                        // sets currentIndex to the index where the found product is located in the list
                        currentIndex = thisProductList.getProductList.IndexOf(p);
                        displayRelevantFormPart(p);
                        return true;
                    }
                }// end foreach loop
            }// end if 
            return false;
        }// end findAnItem method


        // Searches the product list to find a duplicate when user goes to create a new product object
        // Returns true if the given UPC matches one already in the product list and false if otherwise
        public bool lookForDuplicate(int givenUPC)
        {
            foreach (Product p in thisProductList.getProductList)
            {
                if (p.ProductUPC == givenUPC)
                {
                    // duplicate found
                    return true;
                }
            }
            // no duplicate
            return false;
        }


        // Displays the part of the form for CDChamber processing; btnCreateCDChamber click event calls this so user can enter data to be saved
        // Can be shortened using Form Controller deactivateAllBut (?)
        void DisplayCDChamberForm()
        {
            // Display form for Create/Insert or Find/SELECT or Edit/Update or Delete a Chamber Music CD
            /*  btnCreateCDChamber.Enabled = true;
              btnCreateCDChamber.Text = "Save CD Chamber";
              FormController.formAddMode(this);
              txtProductUPC.Enabled = true;
              txtProductPrice.Enabled = true;
              txtProductTitle.Enabled = true;
              txtProductQuantity.Enabled = true;
              txtDVDLeadActor.Enabled = false;
              txtDVDReleaseDate.Enabled = false;
              txtDVDRunTime.Enabled = false;
              txtBookISBNLeft.Enabled = false;
              txtBookISBNRight.Enabled = false;
              txtBookAuthor.Enabled = false;
              txtBookPages.Enabled = false;
              txtBookCISCISArea.Enabled = false;
              txtCDClassicalLabel.Enabled = true;
              txtCDClassicalArtists.Enabled = true;
              txtCDOrchestraConductor.Enabled = false;
              txtCDChamberInstrumentList.Enabled = true;

              btnCreateBookCIS.Enabled = false;
              btnCreateBook.Enabled = false;
              btnCreateDVD.Enabled = false;
              btnCreateCDOrchestra.Enabled = false;

              FormController.activateCDChamber(this);
              FormController.deactivateCDOrchestra(this);
              FormController.deactivateDVD(this);
              FormController.deactivateBook(this);
              FormController.deactivateBookCIS(this);
              toolTip1.SetToolTip(btnCreateCDChamber, ttSaveCDChamber);
              txtProductUPC.Focus();        */

            // alternative activate/deactivate
            btnCreateCDChamber.Text = "Save CD Chamber";
            FormController.formAddMode(this);
            FormController.activateProduct(this);
            FormController.activateCDChamber(this);
            FormController.deactivateAllButCDChamber(this);
            btnCreateCDChamber.Enabled = true;

        } // end DisplayCDChamberForm



        // Display CD Chamber, Book, CIS Book, CD Orchestra, or DVD Form Depending on Type of Object found
        void displayRelevantFormPart(Product p)
        {
            if (p.GetType() == typeof(CDChamber))
            {
                FormController.activateCDChamber(this);
                FormController.deactivateAllButCDChamber(this);
            }
            else if (p.GetType() == typeof(CDOrchestra))
            {
                FormController.activateCDOrchestra(this);
                FormController.deactivateAllButCDOrchestra(this);
            }
            else if (p.GetType() == typeof(Book))
            {
                FormController.activateBook(this);
                FormController.deactivateAllButBook(this);
                // FormController.deactivateAddButtons(this);
            }
            else if (p.GetType() == typeof(BookCIS))
            {
                FormController.activateBookCIS(this);
                FormController.deactivateAllButBookCIS(this);

            }  // end thisProduct if
            else if (p.GetType() == typeof(DVD))
            {
                FormController.activateDVD(this);
                FormController.deactivateAllButDVD(this);

            }  // end thisProduct if
        } // end displayRelevantFormPart



        // Validates the data for Products
        private bool ValidateProduct()
        {
            if (Validators.ValidateProductUPC(txtProductUPC.Text) == false)
            {
                txtProductUPC.Text = "";
                txtProductUPC.Focus();
                MessageBox.Show("Product UPC not valid. Please check that all data is entered and valid.");
                return false;
            }  // end if
            if (Validators.ValidateProductPrice(txtProductPrice.Text) == false)
            {
                txtProductPrice.Text = "";
                txtProductPrice.Focus();
                MessageBox.Show("Product Price not valid.  Please check that all data is entered and valid.");
                return false;
            }  // end if
            if (Validators.ValidateProductTitle(txtProductTitle.Text) == false)
            {
                txtProductTitle.Text = "";
                txtProductTitle.Focus();
                MessageBox.Show("Product Title not valid.  Please check that all data is entered and valid.");
                return false;
            }  // end if
            if (Validators.ValidateProductQuantity(txtProductQuantity.Text) == false)
            {
                txtProductQuantity.Text = "";
                txtProductQuantity.Focus();
                MessageBox.Show("Product Quantity not valid.  Please check that all data is entered and valid.");
                return false;
            }  // end if
            return true;
        }   // end Validate Product data



        // ****************************** Buttons for Creating Objects of our 5 Types *******************************************

        // need handlers for btnCreateBook, btnCreateBookCIS, btnCreateDVD, btnCreateCDOrchestra

        // Handler for creating a CD Chamber Music Object and saving the object to the ProductList if data is valid
        private void btnCreateCDChamber_Click(object sender, EventArgs e)
        {
            txtProductUPC.Focus();
            btnEnterUPC.Enabled = false;
            if (btnCreateCDChamber.Text == "Create CD Chamber")
            {
                // Set up form for CDChamberForm processing; will change button text to "Save CD Chamber" so that this button 
                // can be clicked again and this handler can be used again for saving data at the end if everything is valid
                DisplayCDChamberForm();
                txtProductUPC.Focus();
            }
            else
            {
                if (ValidateProduct() == false) return;
                // Look for duplicate boolean method
                if (lookForDuplicate(Convert.ToInt32(txtProductUPC.Text)))
                {
                    MessageBox.Show("Duplicates not allowed in this application.", "Duplicates Not Allowed",
                        MessageBoxButtons.OK);
                    return;
                }
                // Save if data is OK
                // if (ValidateProduct() == false) return;
                if (Validators.ValidateCDChamberInstrumentList(txtCDChamberInstrumentList.Text) == false)
                {
                    txtCDChamberInstrumentList.Text = "";
                    txtCDChamberInstrumentList.Focus();
                    MessageBox.Show("Please check that all data is entered and valid.");
                    return;
                }  // end inner if then

                //  dbFunctions.InsertProduct(Convert.ToInt32(txtProductUPC.Text), Convert.ToDecimal(txtProductPrice.Text),
                //      txtProductTitle.Text, Convert.ToInt32(txtProductQuantity.Text));
                //  dbFunctions.InsertCDClassical(Convert.ToInt32(txtProductUPC.Text), txtCDClassicalLabel.Text,
                //      txtCDClassicalArtists.Text);
                //  dbFunctions.InsertCDChamber(Convert.ToInt32(txtProductUPC.Text), txtCDChamberInstrumentList.Text);


                // all data is valid so new CDChamber object created and saved to product list
                CDChamber thisCDChamberObject = new CDChamber();
                thisCDChamberObject.Save(this);
                thisProductList.Add(thisCDChamberObject);
                recordsProcessedCount++;
                FormController.clear(this);
                MessageBox.Show("CDChamber " + txtProductTitle.Text +
                    " Added to DB and Serializable File. Press OK to continue.",
                    "Transaction Complete", MessageBoxButtons.OK);
                toolTip1.SetToolTip(btnCreateCDChamber, ttCreateCDChamber);
            }  // end outer else
        }  // end Create CD Chamber Music Object



        // ****************************** End of event handlers for buttons for Creating Objects of our 5 Types *******************************************


        // Clear textboxes
        private void btnClear_Click(System.Object sender, System.EventArgs e)
        {
            FormController.clear(this);
        }  // end btnClear_Click


        // This code executes if the Edit button is clicked
        private void btnEdit_Click(object sender, EventArgs e)
        {
            bool success;
            btnFind.Enabled = false;
            btnDelete.Enabled = false;
            btnSaveEditUpdate.Enabled = false;
            success = findAnItem("Edit/Update");   // boolean method that will return true if object is found in list or false otherwise
            if (success)
            {
                btnSaveEditUpdate.Enabled = true;
                btnEdit.Enabled = false;

                Product p = thisProductList.getAnItem(currentIndex);
                txtProductPrice.Text = p.ProductPrice.ToString();
                txtProductUPC.Text = p.ProductUPC.ToString();
                txtProductQuantity.Text = p.ProductQuantity.ToString();
                txtProductTitle.Text = p.ProductTitle.ToString();
                MessageBox.Show("Edit/UPDATE current Product (as shown). Press Save Updates Button", "Edit/Update Notice",
                    MessageBoxButtons.OK);
                if (p.GetType() == typeof(CDChamber))
                {
                    FormController.activateCDChamber(this);
                    FormController.deactivateAllButCDChamber(this);
                    FormController.deactivateAddButtons(this);

                    txtCDClassicalLabel.Text = ((CDClassical)p).CDClassicalLabel;
                    txtCDClassicalArtists.Text = ((CDClassical)p).CDClassicalArtists;
                    txtCDChamberInstrumentList.Text = ((CDChamber)p).CDChamberInstrumentList;
                }
                else if (p.GetType() == typeof(CDOrchestra))
                {
                    FormController.activateCDOrchestra(this);
                    FormController.deactivateAllButCDOrchestra(this);

                    txtCDClassicalLabel.Text = ((CDClassical)p).CDClassicalLabel;
                    txtCDClassicalArtists.Text = ((CDClassical)p).CDClassicalArtists;
                    txtCDOrchestraConductor.Text = ((CDOrchestra)p).CDOrchestraConductor;
                }
                else if (p.GetType() == typeof(Book))
                {
                    FormController.activateBook(this);
                    FormController.deactivateAllButBook(this);
                    FormController.deactivateAddButtons(this);

                    txtBookISBNLeft.Text = (((Book)p).BookISBNLeft).ToString();
                    txtBookISBNRight.Text = (((Book)p).BookISBNRight).ToString();
                    txtBookAuthor.Text = ((Book)p).BookAuthor;
                    txtBookPages.Text = ((Book)p).BookPages.ToString();
                }
                else if (p.GetType() == typeof(BookCIS))
                {
                    FormController.activateBookCIS(this);
                    FormController.deactivateAllButBookCIS(this);

                    txtBookISBNLeft.Text = (((Book)p).BookISBNLeft).ToString();
                    txtBookISBNRight.Text = (((Book)p).BookISBNRight).ToString();
                    txtBookAuthor.Text = ((Book)p).BookAuthor;
                    txtBookPages.Text = (((Book)p).BookPages).ToString();
                    txtBookCISCISArea.Text = ((BookCIS)p).BookCISCISArea; ;
                }  // end multiple alternative if

                else if (p.GetType() == typeof(DVD))
                {
                    FormController.activateDVD(this);
                    FormController.deactivateAllButDVD(this);

                    txtDVDLeadActor.Text = ((DVD)p).DVDLeadActor;
                    txtDVDReleaseDate.Text = ((DateTime)((DVD)p).DVDReleaseDate).ToString("mm/dd/yyyy");
                    txtDVDRunTime.Text = (((DVD)p).DVDRuntime).ToString();
                }
                else
                {
                    MessageBox.Show("Fatal error. Data type not Book, BookCIS, DVD, DC Chamber or CD Orchestra. Program Terminated. ",
                        "Mis-typed Object", MessageBoxButtons.OK);
                    this.Close();
                }  // end multiple alternative if
            }  // end if on success
        }  // end btnEdit_Click


        // Displays the records for the products, writes out to serialized file, closes form
        private void btnExit_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Number of records processed = " + recordsProcessedCount.ToString(), "Exit Message", MessageBoxButtons.OK);
            MessageBox.Show("The list entries are ...", "Display List Entries");
            thisProductList.displayProductList();

            // Save serialized binary file
            SFManager.writeToFile(thisProductList, FileName);

            this.Close();
        }// end Exit button click event


    } // end Form class
} // end namespace