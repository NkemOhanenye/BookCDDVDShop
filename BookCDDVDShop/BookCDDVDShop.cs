/*Modified by:
 * Nkem Ohanenye, Tracy Lan
 * CIS 3309 Section 001
 * Date: 5/4/2020
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
//
// Search Database base code was given by Wilson Diaz and reformatted to fix our code

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
        ProductDB dbFunctions = new ProductDB();

        public frmBookCDDVDShop()  // Parameterless Constructor for frmBookCDDVDShop
        {
            InitializeComponent();
        }  // end frmBookCDDVDShop Parameterless Constructor


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
                // lblUserMessage.Text = "Please select an operation";
            }
            else if (i < 0 || i >= thisProductList.Count())
            {
                MessageBox.Show("getItem error: index out of range");
                return;
            }
            else
            {
                currentIndex = i;
                thisProductList.getAnItem(currentIndex).Display(this);
                // lblUserMessage.Text = "Object Type: " +
                //  thisProductList.getAnItem(i).GetType().ToString() +
                //" List Index: " + i.ToString();
                // btnFind.Enabled = true;
                btnDelete.Enabled = true;
                btnEdit.Enabled = true;
            }  // end else
        } // end getItem


        // Searches through the product list to find an item with the given UPC
        // Returns true if found and false otherwise
        private bool findAnItem(string s)
        {
            int i = -1;
            int givenUPC = Convert.ToInt32(txtProductUPC.Text);

            foreach (Product p in thisProductList.getProductList)
            {
                if (p.ProductUPC == givenUPC)
                {
                    if (s.Equals("Find/Display"))
                    {
                        i = thisProductList.getProductList.IndexOf(p);
                        getItem(i);
                    }
                    else if (s.Equals("Edit/Update"))
                    {
                        // sets currentIndex to the index where the found product is located in the list
                        currentIndex = thisProductList.getProductList.IndexOf(p);
                        // displayRelevantFormPart(p);
                    }

                    return true;
                } // end outer if

            }// end foreach loop

            return false;
        }// end findAnItem method


        // Searches the product list to find a duplicate when user goes to create a new product object
        // Returns true if the given UPC matches one already in the product list and false if otherwise
        private bool lookForDuplicate(int givenUPC)
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

        // Checks to see if there are duplicate ISBNs
        private bool lookForDuplicateISBN(int givenISBNLeft, int givenISBNRight)
        {
            foreach (Book b in thisProductList.getProductList)
            {
                if (b.BookISBNLeft == givenISBNLeft && b.BookISBNRight == givenISBNRight)
                {
                    // dublicate found
                    return true;
                }
            }
            // no duplicate
            return false;
        }

        // ******************************************** Display form methods **************************************************************************

        // Displays the part of the form for CDChamber processing; btnCreateCDChamber click event calls this so user can enter data to be saved
        private void displayCDChamberForm()
        {
            btnCreateCDChamber.Text = "Save CD Chamber";
            FormController.formAddMode(this);
            FormController.activateProduct(this);
            FormController.activateCDChamber(this);
            FormController.deactivateAllButCDChamber(this);
            btnCreateCDChamber.Enabled = true;
            toolTip1.SetToolTip(btnCreateCDChamber, ttSaveCDChamber);
            txtProductUPC.Focus();
        } // end displayCDChamberForm


        // Displays the part of the form for CDOrchestra processing; btnCreateCDOrchestra click event calls this so user can enter data to be saved
        private void displayCDOrchestraForm()
        {
            btnCreateCDOrchestra.Text = "Save CD Orchestra";
            FormController.formAddMode(this);
            FormController.activateProduct(this);
            FormController.activateCDOrchestra(this);
            FormController.deactivateAllButCDOrchestra(this);
            btnCreateCDOrchestra.Enabled = true;
            toolTip1.SetToolTip(btnCreateCDOrchestra, ttSaveCDOrchestra);
            txtProductUPC.Focus();
        } // end displayCDOrchestraForm


        // Displays the part of the form for Book processing; btnCreateBook click event calls this so user can enter data for a new book to be saved
        private void displayBookForm()
        {
            btnCreateBook.Text = "Save Book";
            FormController.formAddMode(this);
            FormController.activateProduct(this);
            FormController.activateBook(this);
            FormController.deactivateAllButBook(this);
            btnCreateBook.Enabled = true;
            toolTip1.SetToolTip(btnCreateBook, ttSaveBook);
            txtProductUPC.Focus();
        } //  end displayBookForm


        // Displays the part of the form for Book CIS processing; called by the btnCreateBookCIS handler
        private void displayBookCISForm()
        {
            btnCreateBookCIS.Text = "Save Book CIS";
            FormController.formAddMode(this);
            FormController.activateProduct(this);
            FormController.activateBookCIS(this);
            FormController.deactivateAllButBookCIS(this);
            btnCreateBookCIS.Enabled = true;
            toolTip1.SetToolTip(btnCreateBookCIS, ttSaveBookCIS);
            txtProductUPC.Focus();
        } // end displayBookCISForm


        // Displays the part of the form for DVD processing; called by the btnCreateDVD handler
        private void displayDVDForm()
        {
            btnCreateDVD.Text = "Save DVD";
            FormController.formAddMode(this);
            FormController.activateProduct(this);
            FormController.activateDVD(this);
            FormController.deactivateAllButDVD(this);
            btnCreateDVD.Enabled = true;
            toolTip1.SetToolTip(btnCreateDVD, ttSaveDVD);
            txtProductUPC.Focus();
        } // end displayDVDForm


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

        // ******************************* End display forms methods ********************************************************************************


        // ****************************** Buttons for Creating Objects of our 5 Types ***************************************************************

        // Handler for creating a CD Chamber Music Object and saving the object to the ProductList if data is valid
        private void btnCreateCDChamber_Click(object sender, EventArgs e)
        {
            txtProductUPC.Focus();
            btnEnterUPC.Enabled = false;
            if (btnCreateCDChamber.Text == "Create CD Chamber")
            {
                // Set up form for CDChamberForm processing; will change button text to "Save CD Chamber" so that this button 
                // can be clicked again and this handler can be used again for saving data at the end if everything is valid
                displayCDChamberForm();
            }
            else
            {
                if (Validators.ValidateProduct(txtProductUPC.Text, txtProductPrice.Text,
                txtProductTitle.Text, txtProductQuantity.Text) == false)
                {
                    txtProductUPC.Text = "";
                    txtProductPrice.Text = "";
                    txtProductTitle.Text = "";
                    txtProductQuantity.Text = "";
                    txtProductUPC.Focus();
                    return;
                }
                // Look for duplicate boolean method
                if (lookForDuplicate(Convert.ToInt32(txtProductUPC.Text)))
                {
                    MessageBox.Show("Duplicates not allowed in this application.", "Duplicates Not Allowed",
                        MessageBoxButtons.OK);
                    txtProductUPC.Text = "";
                    return;
                }
                // Save if data is OK
                // if (ValidateProduct() == false) return;
                if (Validators.ValidateCDClassical(txtCDClassicalLabel.Text, txtCDClassicalArtists.Text) == false)
                {
                    txtCDClassicalLabel.Text = "";
                    txtCDClassicalArtists.Text = "";
                    txtCDClassicalLabel.Focus();
                    MessageBox.Show("Please check that all data is entered and valid.");
                    return;
                }
                if (Validators.ValidateCDChamber(txtCDChamberInstrumentList.Text) == false)
                {
                    txtCDChamberInstrumentList.Text = "";
                    txtCDChamberInstrumentList.Focus();
                    MessageBox.Show("Please check that all data is entered and valid.");
                    return;
                }  // end inner if then

                // all data is valid so new CDChamber object created and saved to Database
                dbFunctions.InsertProduct(Convert.ToInt32(txtProductUPC.Text), Convert.ToDecimal(txtProductPrice.Text),
                    txtProductTitle.Text, Convert.ToInt32(txtProductQuantity.Text), "CD Chamber");
                dbFunctions.InsertCDClassical(Convert.ToInt32(txtProductUPC.Text), txtCDClassicalLabel.Text,
                    txtCDClassicalArtists.Text);
                dbFunctions.InsertCDChamber(Convert.ToInt32(txtProductUPC.Text), txtCDChamberInstrumentList.Text);

                // all data is valid so new CDChamber object created and saved to product list
                CDChamber thisCDChamberObject = new CDChamber();
                thisCDChamberObject.Save(this);
                thisProductList.Add(thisCDChamberObject);
                recordsProcessedCount++;
                FormController.clear(this);
                MessageBox.Show("CDChamber " + ((Product)thisCDChamberObject).ProductTitle +
                    " Added to DB and Serializable File. Press OK to continue.",
                    "Transaction Complete", MessageBoxButtons.OK);
                toolTip1.SetToolTip(btnCreateCDChamber, ttCreateCDChamber);
            }  // end outer else
        }  // end Create CD Chamber Music Object


        // Handler for creating a CD Orchestra Object and saving the object to the ProductList if its data is valid
        private void btnCreateCDOrchestra_Click(object sender, EventArgs e)
        {
            txtProductUPC.Focus();
            btnEnterUPC.Enabled = false;
            if (btnCreateCDOrchestra.Text == "Create CD Orchestra")
            {
                // Set up form for CDOrchestraForm processing; will change button text to "Save CD Orchestra" so that this button 
                // can be clicked again and this handler can be used again for saving data at the end if everything is valid
                displayCDOrchestraForm();
            }
            else
            {
                if (Validators.ValidateProduct(txtProductUPC.Text, txtProductPrice.Text,
                txtProductTitle.Text, txtProductQuantity.Text) == false)
                {
                    txtProductUPC.Text = "";
                    txtProductPrice.Text = "";
                    txtProductTitle.Text = "";
                    txtProductQuantity.Text = "";
                    txtProductUPC.Focus();
                    return;
                }
                // Look for duplicate boolean method
                if (lookForDuplicate(Convert.ToInt32(txtProductUPC.Text)))
                {
                    MessageBox.Show("Duplicates not allowed in this application.", "Duplicates Not Allowed",
                        MessageBoxButtons.OK);
                    txtProductUPC.Text = "";
                    return;
                }
                // Save if data is OK
                // if (ValidateProduct() == false) return;
                if (Validators.ValidateCDClassical(txtCDClassicalLabel.Text, txtCDClassicalArtists.Text) == false)
                {
                    txtCDClassicalLabel.Text = "";
                    txtCDClassicalArtists.Text = "";
                    txtCDClassicalLabel.Focus();
                    MessageBox.Show("Please check that all data is entered and valid.");
                    return;
                }
                if (Validators.ValidateCDOrchestral(txtCDOrchestraConductor.Text) == false)
                {
                    txtCDChamberInstrumentList.Text = "";
                    txtCDChamberInstrumentList.Focus();
                    MessageBox.Show("Please check that all data is entered and valid.");
                    return;
                } // end inner if-then

                // all data is valid so new CDOrchestra object created and saved to Database
                dbFunctions.InsertProduct(Convert.ToInt32(txtProductUPC.Text), Convert.ToDecimal(txtProductPrice.Text),
                    txtProductTitle.Text, Convert.ToInt32(txtProductQuantity.Text), "CD Orchestra");
                dbFunctions.InsertCDClassical(Convert.ToInt32(txtProductUPC.Text), txtCDClassicalLabel.Text,
                    txtCDClassicalArtists.Text);
                dbFunctions.InsertCDOrchestra(Convert.ToInt32(txtProductUPC.Text), txtCDOrchestraConductor.Text);

                // all data is valid so new CDOrchestra object created and saved to product list
                CDOrchestra thisCDOrchestraObject = new CDOrchestra();
                thisCDOrchestraObject.Save(this);
                thisProductList.Add(thisCDOrchestraObject);
                recordsProcessedCount++;
                FormController.clear(this);
                MessageBox.Show("CDOrchestra " + ((Product)thisCDOrchestraObject).ProductTitle +
                    " Added to DB and Serializable File. Press OK to continue.",
                    "Transaction Complete", MessageBoxButtons.OK);
                toolTip1.SetToolTip(btnCreateCDOrchestra, ttCreateCDOrchestra);
            } // end outer else
        } // end btnCreateCDOrchestra click event


        // Handler for creating a Book Object and saving the object to the ProductList if its data is valid
        private void btnCreateBook_Click(object sender, EventArgs e)
        {
            txtProductUPC.Focus();
            btnEnterUPC.Enabled = false;
            if (btnCreateBook.Text == "Create Book")
            {
                // Set up form for BookForm processing; will change button text to "Save Book" so that this button 
                // can be clicked again and this handler can be used again for saving data at the end if everything is valid
                displayBookForm();
            }
            else
            {
                if (Validators.ValidateProduct(txtProductUPC.Text, txtProductPrice.Text,
                txtProductTitle.Text, txtProductQuantity.Text) == false)
                {
                    txtProductUPC.Text = "";
                    txtProductPrice.Text = "";
                    txtProductTitle.Text = "";
                    txtProductQuantity.Text = "";
                    txtProductUPC.Focus();
                    return;
                }
                // Look for duplicate boolean method
                if (lookForDuplicate(Convert.ToInt32(txtProductUPC.Text)))
                {
                    MessageBox.Show("Duplicates not allowed in this application.", "Duplicates Not Allowed",
                        MessageBoxButtons.OK);
                    txtProductUPC.Text = "";
                    return;
                }
                if (Validators.ValidateBook(txtBookISBNLeft.Text, txtBookISBNRight.Text, txtBookAuthor.Text, txtBookPages.Text) == false)
                {
                    txtBookISBNLeft.Text = "";
                    txtBookISBNRight.Text = "";
                    txtBookAuthor.Text = "";
                    txtBookPages.Text = "";
                    txtBookISBNLeft.Focus();
                    MessageBox.Show("Please check that all data is entered and valid.");
                    return;
                }
                // Look for duplicate ISBN method
                if (lookForDuplicateISBN(Convert.ToInt32(txtBookISBNLeft.Text),
                    Convert.ToInt32(txtBookISBNRight.Text)))
                {
                    MessageBox.Show("A book already has this ISBN.", "Duplicate ISBNs Not Allowed",
                        MessageBoxButtons.OK);
                    txtBookISBNLeft.Text = "";
                    txtBookISBNRight.Text = "";
                    return;
                } // end inner if-then

                // all data is valid so new Book object created and saved to Database
                string ISBN = txtBookISBNLeft.Text + txtBookISBNRight.Text;
                dbFunctions.InsertProduct(Convert.ToInt32(txtProductUPC.Text), Convert.ToDecimal(txtProductPrice.Text),
                    txtProductTitle.Text, Convert.ToInt32(txtProductQuantity.Text), "Book");
                dbFunctions.InsertBook(Convert.ToInt32(txtProductUPC.Text), Convert.ToInt32(ISBN),
                    txtBookAuthor.Text, Convert.ToInt32(txtBookPages.Text));

                // all data is valid so new Book object created and saved to product list
                Book thisBookObject = new Book();
                thisBookObject.Save(this);
                thisProductList.Add(thisBookObject);
                recordsProcessedCount++;
                FormController.clear(this);
                MessageBox.Show("Book " + ((Product)thisBookObject).ProductTitle +
                    " Added to DB and Serializable File. Press OK to continue.",
                    "Transaction Complete", MessageBoxButtons.OK);
                toolTip1.SetToolTip(btnCreateBook, ttCreateBook);
            } // end outer else
        } // end btnCreateBook


        // Handler for creating a new CIS Book object and saving the object to the product list if all data is valid
        private void btnCreateBookCIS_Click(object sender, EventArgs e)
        {
            txtProductUPC.Focus();
            btnEnterUPC.Enabled = false;
            if (btnCreateBookCIS.Text == "Create Book CIS")
            {
                // Set up form for BookCISForm processing; will change button text to "Save CIS Book" so that this button 
                // can be clicked again and this handler can be used again for saving data at the end if everything is valid
                displayBookCISForm();
            }
            else
            {
                if (Validators.ValidateProduct(txtProductUPC.Text, txtProductPrice.Text,
                txtProductTitle.Text, txtProductQuantity.Text) == false)
                {
                    txtProductUPC.Text = "";
                    txtProductPrice.Text = "";
                    txtProductTitle.Text = "";
                    txtProductQuantity.Text = "";
                    txtProductUPC.Focus();
                    return;
                }
                // Look for duplicate boolean method
                if (lookForDuplicate(Convert.ToInt32(txtProductUPC.Text)))
                {
                    MessageBox.Show("Duplicates not allowed in this application.", "Duplicates Not Allowed",
                        MessageBoxButtons.OK);
                    txtProductUPC.Text = "";
                    return;
                }
                if (Validators.ValidateBook(txtBookISBNLeft.Text, txtBookISBNRight.Text, txtBookAuthor.Text, txtBookPages.Text) == false)
                {
                    txtBookISBNLeft.Text = "";
                    txtBookISBNRight.Text = "";
                    txtBookAuthor.Text = "";
                    txtBookPages.Text = "";
                    txtBookISBNLeft.Focus();
                    MessageBox.Show("Please check that all data is entered and valid.");
                    return;
                }
                // Look for duplicate ISBN method
                if (lookForDuplicateISBN(Convert.ToInt32(txtBookISBNLeft.Text),
                    Convert.ToInt32(txtBookISBNRight.Text)))
                {
                    MessageBox.Show("A book already has this ISBN.", "Duplicate ISBNs Not Allowed",
                        MessageBoxButtons.OK);
                    txtBookISBNLeft.Text = "";
                    txtBookISBNRight.Text = "";
                    return;
                }
                if (Validators.ValidateCISBook(txtBookCISCISArea.Text) == false)
                {
                    txtBookCISCISArea.Text = "";
                    txtBookCISCISArea.Focus();
                    MessageBox.Show("Please check that all data is entered and valid.");
                    return;
                } // end inner if-then

                // all data is valid so new BookCIS object created and saved to Database
                string ISBN = txtBookISBNLeft.Text + txtBookISBNRight.Text;
                dbFunctions.InsertProduct(Convert.ToInt32(txtProductUPC.Text), Convert.ToDecimal(txtProductPrice.Text),
                    txtProductTitle.Text, Convert.ToInt32(txtProductQuantity.Text), "Book CIS");
                dbFunctions.InsertBook(Convert.ToInt32(txtProductUPC.Text), Convert.ToInt32(ISBN),
                    txtBookAuthor.Text, Convert.ToInt32(txtBookPages.Text));
                dbFunctions.InsertBookCIS(Convert.ToInt32(txtProductUPC.Text), txtBookCISCISArea.Text);

                // all data is valid so new Book object created and saved to product list
                BookCIS thisBookCISObject = new BookCIS();
                thisBookCISObject.Save(this);
                thisProductList.Add(thisBookCISObject);
                recordsProcessedCount++;
                FormController.clear(this);
                MessageBox.Show("CIS Book " + ((Product)thisBookCISObject).ProductTitle +
                    " Added to DB and Serializable File. Press OK to continue.",
                    "Transaction Complete", MessageBoxButtons.OK);
                toolTip1.SetToolTip(btnCreateBookCIS, ttCreateBookCIS);
            } // end outer else
        } // end btnCreateBookCIS


        // Hander for creating a new DVD object and saving it to the product list if the data is valid
        private void btnCreateDVD_Click(object sender, EventArgs e)
        {
            txtProductUPC.Focus();
            btnEnterUPC.Enabled = false;
            if (btnCreateDVD.Text == "Create DVD")
            {
                // Set up form for DVDForm processing; will change button text to "Save DVD" so that this button 
                // can be clicked again and this handler can be used again for saving data at the end if everything is valid
                displayDVDForm();
            }
            else
            {
                if (Validators.ValidateProduct(txtProductUPC.Text, txtProductPrice.Text,
                txtProductTitle.Text, txtProductQuantity.Text) == false)
                {
                    txtProductUPC.Text = "";
                    txtProductPrice.Text = "";
                    txtProductTitle.Text = "";
                    txtProductQuantity.Text = "";
                    txtProductUPC.Focus();
                    return;
                }
                // Look for duplicate boolean method
                if (lookForDuplicate(Convert.ToInt32(txtProductUPC.Text)))
                {
                    MessageBox.Show("Duplicates not allowed in this application.", "Duplicates Not Allowed",
                        MessageBoxButtons.OK);
                    txtProductUPC.Text = "";
                    return;
                }
                if (Validators.ValidateDVD(txtDVDLeadActor.Text, txtDVDReleaseDate.Text, txtDVDRunTime.Text) == false)
                {
                    txtDVDLeadActor.Text = "";
                    txtDVDReleaseDate.Text = "";
                    txtDVDRunTime.Text = "";
                    txtDVDLeadActor.Focus();
                    MessageBox.Show("Please check that all data is entered and valid.");
                    return;
                } // end inner if-then

                // all data is valid so new DVD object created and saved to Database
                dbFunctions.InsertProduct(Convert.ToInt32(txtProductUPC.Text), Convert.ToDecimal(txtProductPrice.Text),
                    txtProductTitle.Text, Convert.ToInt32(txtProductQuantity.Text), "DVD");
                dbFunctions.InsertDVD(Convert.ToInt32(txtProductUPC.Text), txtDVDLeadActor.Text, 
                    Convert.ToDateTime(txtDVDReleaseDate), Convert.ToInt32(txtDVDRunTime.Text));

                // all data is valid so new DVD object created and saved to product list
                DVD thisDVDObject = new DVD();
                thisDVDObject.Save(this);
                thisProductList.Add(thisDVDObject);
                recordsProcessedCount++;
                FormController.clear(this);
                MessageBox.Show("DVD " + ((Product)thisDVDObject).ProductTitle +
                    " Added to DB and Serializable File. Press OK to continue.",
                    "Transaction Complete", MessageBoxButtons.OK);
                toolTip1.SetToolTip(btnCreateDVD, ttCreateDVD);
            } // end outer else
        } // end btnCreateDVD

        // ****************************** End of event handlers for buttons for Creating Objects of our 5 Types *******************************************


        // Clear textboxes
        private void btnClear_Click(System.Object sender, System.EventArgs e)
        {
            FormController.clear(this);
        }  // end btnClear_Click


        // Handler for the Enter UPC button which enables UPC entry and search
        private void btnEnterUPC_Click(object sender, EventArgs e)
        {
            txtProductUPC.Enabled = true;
            btnFind.Enabled = true;
            FormController.deactivateAddButtons(this);
        }

        // Handler for the Find/Display button which finds the product with the given UPC and displays its contents
        private void btnFind_Click(object sender, EventArgs e)
        {
            btnEnterUPC.Enabled = false;
            string s = "Find/Display";

            if (Validators.ValidateProductUPC(txtProductUPC.Text) == false)
            {
                txtProductUPC.Text = "";
                txtProductUPC.Focus();
            }
            else if (findAnItem(s) == false)
            {
                MessageBox.Show("The product does not exist. Please enter another UPC.", "Product Not Found");
                txtProductUPC.Text = "";
                txtProductUPC.Focus();
            }
            else
            {
                findAnItem(s);  // will call getItem which will display data on the form
                txtProductUPC.Enabled = false;   // to prevent user from changing the UPC when editing
                MessageBox.Show("The product with the given UPC is found.", "Product Found");
            }
            bool found; // boolean reference for search success
            string pstring; // Product string updated upon product DB search call.
            Product p;

            //  this returns an OleDbDataReader object, but you don't really need to use it
            //  the boolean flag and string that are returned are important
            //  pstring will hold the attributes of a product from the database in a single string, separated by newline characters
            //  split it below 

            OleDbDataReader odb = dbFunctions.SelectProductFromProduct(Convert.ToInt32(txtProductUPC.Text), out found, out pstring);

            if (!found) //not found
            {
                MessageBox.Show("Product not found");
                txtProductUPC.Clear();
                txtProductUPC.Focus();

            } // Creates a new product to display in form.
            else
            {
                string[] attributes = pstring.Split('\n'); // splits product attributes into array

                for (int i = 0; i < attributes.Length; i++)
                {
                    attributes[i] = attributes[i].Trim('\r'); // clears "junk" from each field
                }

                string pType = attributes[4]; // gets the product type from this attribute and then creates new product to display in form

                if (pType == "DVD")
                {
                    p = new DVD(Convert.ToInt32(attributes[0]), Convert.ToDecimal(attributes[1]), attributes[2], Convert.ToInt32(attributes[3]),
                        attributes[5], DateTime.Parse(attributes[6]), Convert.ToInt32(attributes[7]));
                    p.Display(this);
                    txtProductUPC.Enabled = false;   // to prevent user from changing the UPC when editing
                }
                else if (pType == "Book")
                {
                    p = new Book(Convert.ToInt32(attributes[0]), Convert.ToDecimal(attributes[1]), attributes[2],
                        Convert.ToInt32(attributes[3]), Convert.ToInt32(attributes[4]), Convert.ToInt32(attributes[5]),
                        attributes[6], Convert.ToInt32(attributes[7]));
                    p.Display(this);
                    txtProductUPC.Enabled = false;   // to prevent user from changing the UPC when editing
                }
                else if (pType == "Book CIS")
                {
                    p = new BookCIS(Convert.ToInt32(attributes[0]), Convert.ToDecimal(attributes[1]), attributes[2],
                        Convert.ToInt32(attributes[3]), Convert.ToInt32(attributes[4]), Convert.ToInt32(attributes[5]),
                        attributes[6], Convert.ToInt32(attributes[7]), attributes[8]);
                    p.Display(this);
                    txtProductUPC.Enabled = false;   // to prevent user from changing the UPC when editing
                }
                else if (pType == "CD Chamber")
                {
                    p = new CDChamber(Convert.ToInt32(attributes[0]), Convert.ToDecimal(attributes[1]), attributes[2],
                        Convert.ToInt32(attributes[3]), attributes[4], attributes[5], attributes[6]);
                    p.Display(this);
                    txtProductUPC.Enabled = false;   // to prevent user from changing the UPC when editing
                }
                else if (pType == "CD Orchestra")
                {
                    p = new CDOrchestra(Convert.ToInt32(attributes[0]), Convert.ToDecimal(attributes[1]), attributes[2],
                        Convert.ToInt32(attributes[3]), attributes[4], attributes[5], attributes[6]);
                    p.Display(this);
                    txtProductUPC.Enabled = false;   // to prevent user from changing the UPC when editing
                }
                else
                {
                    MessageBox.Show("The product does not exist. Please enter another UPC.", "Product Not Found");
                    txtProductUPC.Text = "";
                    txtProductUPC.Focus();
                }
            }
        }


        // Handler for the Delete button which will confirm with the user that the found product is the one
        // they want to be deleted. Won't be enabled until the Find/Display button click finds the product
        private void btnDelete_Click(object sender, EventArgs e)
        {
            btnFind.Enabled = false;
            btnEdit.Enabled = false;
            string productString = thisProductList.getAnItem(currentIndex).ToString();
            DialogResult result = MessageBox.Show("Are you sure you want to delete this product: \n\n" + productString,
                "Confirm Delete", MessageBoxButtons.YesNo);

            if (result == DialogResult.Yes)
            {
                // The found item is deleted from the database
                dbFunctions.Delete(Convert.ToInt32(txtProductUPC.Text));

                thisProductList.removeItem(currentIndex);
                recordsProcessedCount++;
                MessageBox.Show("Please clear the form for another transaction.", "Clear Form");
                btnDelete.Enabled = false;
                btnClear.Focus();
            }
            else   // user clicked No
            {
                MessageBox.Show("Clear the form and click button to enter a UPC.", "Clear and Re-enter UPC");
                btnDelete.Enabled = false;
                btnClear.Focus();
            }
        }

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
                btnEdit.Enabled = false;

                Product p = thisProductList.getAnItem(currentIndex);
                txtProductPrice.Text = p.ProductPrice.ToString();
                txtProductUPC.Text = p.ProductUPC.ToString();
                txtProductQuantity.Text = p.ProductQuantity.ToString();
                txtProductTitle.Text = p.ProductTitle.ToString();

                string productString = p.ToString();
                DialogResult result = MessageBox.Show("Are you sure you want to update this product: \n\n " + productString,
                    "Confirm Product to be Updated", MessageBoxButtons.YesNo);

                if (result == DialogResult.No)
                {
                    txtProductUPC.Enabled = false;
                    MessageBox.Show("Clear the form and click button to enter a UPC.", "Clear and Re-enter UPC");
                    btnClear.Focus();
                }
                else
                {
                    MessageBox.Show("Edit/UPDATE current Product (as shown). Press Save Updates Button", "Edit/Update Notice",
                        MessageBoxButtons.OK);
                    if (p.GetType() == typeof(CDChamber))
                    {
                        FormController.activateCDChamber(this);
                        FormController.deactivateAllButCDChamber(this);
                        FormController.deactivateAddButtons(this);

                        txtProductUPC.Enabled = false;
                        txtCDClassicalLabel.Text = ((CDClassical)p).CDClassicalLabel;
                        txtCDClassicalArtists.Text = ((CDClassical)p).CDClassicalArtists;
                        txtCDChamberInstrumentList.Text = ((CDChamber)p).CDChamberInstrumentList;
                    }
                    else if (p.GetType() == typeof(CDOrchestra))
                    {
                        FormController.activateCDOrchestra(this);
                        FormController.deactivateAllButCDOrchestra(this);

                        txtProductUPC.Enabled = false;
                        txtCDClassicalLabel.Text = ((CDClassical)p).CDClassicalLabel;
                        txtCDClassicalArtists.Text = ((CDClassical)p).CDClassicalArtists;
                        txtCDOrchestraConductor.Text = ((CDOrchestra)p).CDOrchestraConductor;
                    }
                    else if (p.GetType() == typeof(Book))
                    {
                        FormController.activateBook(this);
                        FormController.deactivateAllButBook(this);
                        FormController.deactivateAddButtons(this);

                        txtProductUPC.Enabled = false;
                        txtBookISBNLeft.Enabled = false;
                        txtBookISBNRight.Enabled = false;
                        txtBookISBNLeft.Text = (((Book)p).BookISBNLeft).ToString();
                        txtBookISBNRight.Text = (((Book)p).BookISBNRight).ToString();
                        txtBookAuthor.Text = ((Book)p).BookAuthor;
                        txtBookPages.Text = ((Book)p).BookPages.ToString();
                    }
                    else if (p.GetType() == typeof(BookCIS))
                    {
                        FormController.activateBookCIS(this);
                        FormController.deactivateAllButBookCIS(this);

                        txtProductUPC.Enabled = false;
                        txtBookISBNLeft.Enabled = false;
                        txtBookISBNRight.Enabled = false;
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

                        txtProductUPC.Enabled = false;
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

                } // end outer else (when user confirms this is the product to be updated)

            }  // end if on success

            btnSaveEditUpdate.Enabled = true;
        }  // end btnEdit_Click


        // Handler for the Save Updates button which will make sure that all data is validated again before saving
        private void btnSaveEditUpdate_Click(object sender, EventArgs e)
        {
            Product p = thisProductList.getAnItem(currentIndex);
            if (Validators.ValidateProduct(txtProductUPC.Text, txtProductPrice.Text,
                txtProductTitle.Text, txtProductQuantity.Text) == false)
            {
                MessageBox.Show("Please make sure your edits for the product price, title, and quantity.", "Invalid Data");
                return;
            }
            else  // when all product data is valid
            {
                if (p.GetType() == typeof(CDChamber))
                {
                    if (Validators.ValidateCDClassical(txtCDClassicalLabel.Text, txtCDClassicalArtists.Text) == false
                        | Validators.ValidateCDChamber(txtCDChamberInstrumentList.Text) == false)
                    {
                        MessageBox.Show("Please make sure your edited CD Chamber data is valid.", "Invalid CD Chamber Data");
                        return;
                    }
                    // all data is valid so CDChamber object updated to Database
                    dbFunctions.UpdateProduct(Convert.ToInt32(txtProductUPC.Text), Convert.ToDecimal(txtProductPrice.Text),
                        txtProductTitle.Text, Convert.ToInt32(txtProductQuantity.Text));
                    dbFunctions.UpdateCDClassical(Convert.ToInt32(txtProductUPC.Text), txtCDClassicalLabel.Text,
                        txtCDClassicalArtists.Text);
                    dbFunctions.UpdateCDChamber(Convert.ToInt32(txtProductUPC.Text), txtCDChamberInstrumentList.Text);
                } // end if for CD Chamber
                else if (p.GetType() == typeof(CDOrchestra))
                {
                    if (Validators.ValidateCDClassical(txtCDClassicalLabel.Text, txtCDClassicalArtists.Text) == false
                        | Validators.ValidateCDOrchestral(txtCDOrchestraConductor.Text) == false)
                    {
                        MessageBox.Show("Please make sure your edited CD Orchestra data is valid.", "Invalid CD Chamber Data");
                        return;
                    }
                    // all data is valid so CDOrchestra object updated to Database
                    dbFunctions.UpdateProduct(Convert.ToInt32(txtProductUPC.Text), Convert.ToDecimal(txtProductPrice.Text),
                        txtProductTitle.Text, Convert.ToInt32(txtProductQuantity.Text));
                    dbFunctions.UpdateCDClassical(Convert.ToInt32(txtProductUPC.Text), txtCDClassicalLabel.Text,
                        txtCDClassicalArtists.Text);
                    dbFunctions.UpdateCDOrchestra(Convert.ToInt32(txtProductUPC.Text), txtCDOrchestraConductor.Text);
                } // end if for CD Orchestra
                else if (p.GetType() == typeof(Book))
                {
                    if (Validators.ValidateBook(txtBookISBNLeft.Text, txtBookISBNRight.Text, txtBookAuthor.Text, txtBookPages.Text) == false)
                    {
                        MessageBox.Show("Please make sure your edited Book data is valid.", "Invalid Book Data");
                        return;
                    }
                    // all data is valid so Book object updated to Database
                    string ISBN = txtBookISBNLeft.Text + txtBookISBNRight.Text;
                    dbFunctions.UpdateProduct(Convert.ToInt32(txtProductUPC.Text), Convert.ToDecimal(txtProductPrice.Text),
                        txtProductTitle.Text, Convert.ToInt32(txtProductQuantity.Text));
                    dbFunctions.UpdateBook(Convert.ToInt32(txtProductUPC.Text), Convert.ToInt32(ISBN),
                        txtBookAuthor.Text, Convert.ToInt32(txtBookPages.Text));
                } // end if for Book
                else if (p.GetType() == typeof(BookCIS))
                {
                    if (Validators.ValidateBook(txtBookISBNLeft.Text, txtBookISBNRight.Text, txtBookAuthor.Text, txtBookPages.Text) == false
                        | Validators.ValidateCISBook(txtBookCISCISArea.Text) == false)
                    {
                        MessageBox.Show("Please make sure your edited CIS Book data is valid.", "Invalid CIS Book Data");
                        return;
                    }
                    // all data is valid so BookCIS object updated to Database
                    string ISBN = txtBookISBNLeft.Text + txtBookISBNRight.Text;
                    dbFunctions.UpdateProduct(Convert.ToInt32(txtProductUPC.Text), Convert.ToDecimal(txtProductPrice.Text),
                        txtProductTitle.Text, Convert.ToInt32(txtProductQuantity.Text));
                    dbFunctions.UpdateBook(Convert.ToInt32(txtProductUPC.Text), Convert.ToInt32(ISBN),
                        txtBookAuthor.Text, Convert.ToInt32(txtBookPages.Text));
                    dbFunctions.UpdateBookCIS(Convert.ToInt32(txtProductUPC.Text), txtBookCISCISArea.Text);
                } // end if for Book CIS
                else if (p.GetType() == typeof(DVD))
                {
                    if (Validators.ValidateDVD(txtDVDLeadActor.Text, txtDVDReleaseDate.Text, txtDVDRunTime.Text) == false)
                    {
                        MessageBox.Show("Please make sure your edited DVD data is valid.", "Invalid DVD Data");
                    }
                    // all data is valid so DVD object updated to Database
                    dbFunctions.UpdateProduct(Convert.ToInt32(txtProductUPC.Text), Convert.ToDecimal(txtProductPrice.Text),
                        txtProductTitle.Text, Convert.ToInt32(txtProductQuantity.Text));
                    dbFunctions.UpdateDVD(Convert.ToInt32(txtProductUPC.Text), txtDVDLeadActor.Text, 
                        Convert.ToDateTime(txtDVDReleaseDate.Text), Convert.ToInt32(txtDVDRunTime.Text));
                } // end inner if-else

                // save the edited data for this product
                p.Save(this);
                btnSaveEditUpdate.Enabled = false;
                recordsProcessedCount++;

                string itemSaved = p.ToString();
                MessageBox.Show("Product updated as shown: \n\n" + itemSaved, "Product Updated and Saved");
                MessageBox.Show("Please clear the form for another transaction.", "Clear Form");
                btnClear.Focus();
                
            } // end outer else (when product data is valid)

        }

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