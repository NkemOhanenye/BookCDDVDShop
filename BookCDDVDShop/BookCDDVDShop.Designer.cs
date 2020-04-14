namespace BookCDDVDShop
{
    partial class frmBookCDDVDShop
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.lblDescription = new System.Windows.Forms.Label();
            this.lblControlDirections = new System.Windows.Forms.Label();
            this.grpCreateControls = new System.Windows.Forms.GroupBox();
            this.btnCreateCDChamber = new System.Windows.Forms.Button();
            this.btnCreateCDOrchestra = new System.Windows.Forms.Button();
            this.btnCreateDVD = new System.Windows.Forms.Button();
            this.btnCreateBookCIS = new System.Windows.Forms.Button();
            this.btnCreateBook = new System.Windows.Forms.Button();
            this.lblProductDirections = new System.Windows.Forms.Label();
            this.grpProduct = new System.Windows.Forms.GroupBox();
            this.grpCDClassical = new System.Windows.Forms.GroupBox();
            this.txtCDClassicalArtists = new System.Windows.Forms.TextBox();
            this.lblCDClassicalArtists = new System.Windows.Forms.Label();
            this.txtCDClassicalLabel = new System.Windows.Forms.TextBox();
            this.lblCDClassicalLabel = new System.Windows.Forms.Label();
            this.grpCDChamber = new System.Windows.Forms.GroupBox();
            this.txtCDChamberInstrumentList = new System.Windows.Forms.ComboBox();
            this.lblCDChamberInstruments = new System.Windows.Forms.Label();
            this.grpCDOrchestra = new System.Windows.Forms.GroupBox();
            this.txtCDOrchestraConductor = new System.Windows.Forms.TextBox();
            this.lblCDOrchestraConductor = new System.Windows.Forms.Label();
            this.grpDVD = new System.Windows.Forms.GroupBox();
            this.txtDVDRunTime = new System.Windows.Forms.TextBox();
            this.lblDVDRunTime = new System.Windows.Forms.Label();
            this.txtDVDReleaseDate = new System.Windows.Forms.TextBox();
            this.lblDVDReleaseDate = new System.Windows.Forms.Label();
            this.txtDVDLeadActor = new System.Windows.Forms.TextBox();
            this.lblDVDLeadActor = new System.Windows.Forms.Label();
            this.grpBookCIS = new System.Windows.Forms.GroupBox();
            this.txtBookCISCISArea = new System.Windows.Forms.ComboBox();
            this.lblBookCISCISArea = new System.Windows.Forms.Label();
            this.grpBook = new System.Windows.Forms.GroupBox();
            this.txtBookPages = new System.Windows.Forms.TextBox();
            this.lblBookPages = new System.Windows.Forms.Label();
            this.txtBookAuthor = new System.Windows.Forms.TextBox();
            this.lblBookAuthor = new System.Windows.Forms.Label();
            this.txtBookISBNRight = new System.Windows.Forms.TextBox();
            this.lblBookISBNHyphen = new System.Windows.Forms.Label();
            this.txtBookISBNLeft = new System.Windows.Forms.TextBox();
            this.lblBookISBN = new System.Windows.Forms.Label();
            this.txtProductQuantity = new System.Windows.Forms.TextBox();
            this.lblProductQuantity = new System.Windows.Forms.Label();
            this.txtProductTitle = new System.Windows.Forms.TextBox();
            this.lblProductTitle = new System.Windows.Forms.Label();
            this.lblProductPrice = new System.Windows.Forms.Label();
            this.lblProductUPC = new System.Windows.Forms.Label();
            this.txtProductPrice = new System.Windows.Forms.TextBox();
            this.txtProductUPC = new System.Windows.Forms.TextBox();
            this.grpFormDataControls = new System.Windows.Forms.GroupBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnSaveEditUpdate = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnFind = new System.Windows.Forms.Button();
            this.btnEnterUPC = new System.Windows.Forms.Button();
            this.lblFormDataControls = new System.Windows.Forms.Label();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.grpCreateControls.SuspendLayout();
            this.grpProduct.SuspendLayout();
            this.grpCDClassical.SuspendLayout();
            this.grpCDChamber.SuspendLayout();
            this.grpCDOrchestra.SuspendLayout();
            this.grpDVD.SuspendLayout();
            this.grpBookCIS.SuspendLayout();
            this.grpBook.SuspendLayout();
            this.grpFormDataControls.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lblDescription.Location = new System.Drawing.Point(400, 17);
            this.lblDescription.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(582, 31);
            this.lblDescription.TabIndex = 0;
            this.lblDescription.Text = "Data Entry and Display for Book CD DVD Shop";
            // 
            // lblControlDirections
            // 
            this.lblControlDirections.AutoSize = true;
            this.lblControlDirections.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lblControlDirections.ForeColor = System.Drawing.Color.Red;
            this.lblControlDirections.Location = new System.Drawing.Point(36, 69);
            this.lblControlDirections.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblControlDirections.Name = "lblControlDirections";
            this.lblControlDirections.Size = new System.Drawing.Size(1248, 26);
            this.lblControlDirections.TabIndex = 1;
            this.lblControlDirections.Text = "To CREATE a new Book, CIS Book, DVD, Orchestra CD or Chamber CD, always press a b" +
    "utton below before typing.";
            // 
            // grpCreateControls
            // 
            this.grpCreateControls.Controls.Add(this.btnCreateCDChamber);
            this.grpCreateControls.Controls.Add(this.btnCreateCDOrchestra);
            this.grpCreateControls.Controls.Add(this.btnCreateDVD);
            this.grpCreateControls.Controls.Add(this.btnCreateBookCIS);
            this.grpCreateControls.Controls.Add(this.btnCreateBook);
            this.grpCreateControls.Location = new System.Drawing.Point(98, 117);
            this.grpCreateControls.Margin = new System.Windows.Forms.Padding(6);
            this.grpCreateControls.Name = "grpCreateControls";
            this.grpCreateControls.Padding = new System.Windows.Forms.Padding(6);
            this.grpCreateControls.Size = new System.Drawing.Size(1250, 90);
            this.grpCreateControls.TabIndex = 2;
            this.grpCreateControls.TabStop = false;
            this.grpCreateControls.Text = "Controls for Creating a New Entry";
            // 
            // btnCreateCDChamber
            // 
            this.btnCreateCDChamber.Location = new System.Drawing.Point(1000, 33);
            this.btnCreateCDChamber.Margin = new System.Windows.Forms.Padding(6);
            this.btnCreateCDChamber.Name = "btnCreateCDChamber";
            this.btnCreateCDChamber.Size = new System.Drawing.Size(230, 44);
            this.btnCreateCDChamber.TabIndex = 4;
            this.btnCreateCDChamber.Text = "Create CD Chamber";
            this.btnCreateCDChamber.UseVisualStyleBackColor = true;
            this.btnCreateCDChamber.Click += new System.EventHandler(this.btnCreateCDChamber_Click);
            // 
            // btnCreateCDOrchestra
            // 
            this.btnCreateCDOrchestra.Location = new System.Drawing.Point(758, 33);
            this.btnCreateCDOrchestra.Margin = new System.Windows.Forms.Padding(6);
            this.btnCreateCDOrchestra.Name = "btnCreateCDOrchestra";
            this.btnCreateCDOrchestra.Size = new System.Drawing.Size(230, 44);
            this.btnCreateCDOrchestra.TabIndex = 3;
            this.btnCreateCDOrchestra.Text = "Create CD Orchestra";
            this.btnCreateCDOrchestra.UseVisualStyleBackColor = true;
            // 
            // btnCreateDVD
            // 
            this.btnCreateDVD.Location = new System.Drawing.Point(516, 33);
            this.btnCreateDVD.Margin = new System.Windows.Forms.Padding(6);
            this.btnCreateDVD.Name = "btnCreateDVD";
            this.btnCreateDVD.Size = new System.Drawing.Size(230, 44);
            this.btnCreateDVD.TabIndex = 2;
            this.btnCreateDVD.Text = "Create DVD";
            this.btnCreateDVD.UseVisualStyleBackColor = true;
            // 
            // btnCreateBookCIS
            // 
            this.btnCreateBookCIS.Location = new System.Drawing.Point(274, 33);
            this.btnCreateBookCIS.Margin = new System.Windows.Forms.Padding(6);
            this.btnCreateBookCIS.Name = "btnCreateBookCIS";
            this.btnCreateBookCIS.Size = new System.Drawing.Size(230, 44);
            this.btnCreateBookCIS.TabIndex = 1;
            this.btnCreateBookCIS.Text = "Create CIS Book";
            this.btnCreateBookCIS.UseVisualStyleBackColor = true;
            // 
            // btnCreateBook
            // 
            this.btnCreateBook.Location = new System.Drawing.Point(32, 33);
            this.btnCreateBook.Margin = new System.Windows.Forms.Padding(6);
            this.btnCreateBook.Name = "btnCreateBook";
            this.btnCreateBook.Size = new System.Drawing.Size(230, 44);
            this.btnCreateBook.TabIndex = 0;
            this.btnCreateBook.Text = "Create Book";
            this.btnCreateBook.UseVisualStyleBackColor = true;
            // 
            // lblProductDirections
            // 
            this.lblProductDirections.AutoSize = true;
            this.lblProductDirections.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lblProductDirections.ForeColor = System.Drawing.Color.Green;
            this.lblProductDirections.Location = new System.Drawing.Point(58, 231);
            this.lblProductDirections.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblProductDirections.Name = "lblProductDirections";
            this.lblProductDirections.Size = new System.Drawing.Size(1224, 26);
            this.lblProductDirections.TabIndex = 3;
            this.lblProductDirections.Text = "To Find/SEARCH, Edit/UPDATE or DELETE, enter Product UPC, and Select appropriate " +
    "control at bottom of form.";
            // 
            // grpProduct
            // 
            this.grpProduct.Controls.Add(this.grpCDClassical);
            this.grpProduct.Controls.Add(this.grpCDChamber);
            this.grpProduct.Controls.Add(this.grpCDOrchestra);
            this.grpProduct.Controls.Add(this.grpDVD);
            this.grpProduct.Controls.Add(this.grpBookCIS);
            this.grpProduct.Controls.Add(this.grpBook);
            this.grpProduct.Controls.Add(this.txtProductQuantity);
            this.grpProduct.Controls.Add(this.lblProductQuantity);
            this.grpProduct.Controls.Add(this.txtProductTitle);
            this.grpProduct.Controls.Add(this.lblProductTitle);
            this.grpProduct.Controls.Add(this.lblProductPrice);
            this.grpProduct.Controls.Add(this.lblProductUPC);
            this.grpProduct.Controls.Add(this.txtProductPrice);
            this.grpProduct.Controls.Add(this.txtProductUPC);
            this.grpProduct.Location = new System.Drawing.Point(98, 279);
            this.grpProduct.Margin = new System.Windows.Forms.Padding(6);
            this.grpProduct.Name = "grpProduct";
            this.grpProduct.Padding = new System.Windows.Forms.Padding(6);
            this.grpProduct.Size = new System.Drawing.Size(1132, 679);
            this.grpProduct.TabIndex = 4;
            this.grpProduct.TabStop = false;
            this.grpProduct.Text = "Product";
            // 
            // grpCDClassical
            // 
            this.grpCDClassical.Controls.Add(this.txtCDClassicalArtists);
            this.grpCDClassical.Controls.Add(this.lblCDClassicalArtists);
            this.grpCDClassical.Controls.Add(this.txtCDClassicalLabel);
            this.grpCDClassical.Controls.Add(this.lblCDClassicalLabel);
            this.grpCDClassical.Location = new System.Drawing.Point(32, 438);
            this.grpCDClassical.Margin = new System.Windows.Forms.Padding(6);
            this.grpCDClassical.Name = "grpCDClassical";
            this.grpCDClassical.Padding = new System.Windows.Forms.Padding(6);
            this.grpCDClassical.Size = new System.Drawing.Size(1088, 112);
            this.grpCDClassical.TabIndex = 13;
            this.grpCDClassical.TabStop = false;
            this.grpCDClassical.Text = "CD Classical";
            // 
            // txtCDClassicalArtists
            // 
            this.txtCDClassicalArtists.Location = new System.Drawing.Point(496, 42);
            this.txtCDClassicalArtists.Margin = new System.Windows.Forms.Padding(6);
            this.txtCDClassicalArtists.Name = "txtCDClassicalArtists";
            this.txtCDClassicalArtists.Size = new System.Drawing.Size(570, 31);
            this.txtCDClassicalArtists.TabIndex = 3;
            // 
            // lblCDClassicalArtists
            // 
            this.lblCDClassicalArtists.AutoSize = true;
            this.lblCDClassicalArtists.Location = new System.Drawing.Point(412, 50);
            this.lblCDClassicalArtists.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblCDClassicalArtists.Name = "lblCDClassicalArtists";
            this.lblCDClassicalArtists.Size = new System.Drawing.Size(72, 25);
            this.lblCDClassicalArtists.TabIndex = 2;
            this.lblCDClassicalArtists.Text = "Artists";
            // 
            // txtCDClassicalLabel
            // 
            this.txtCDClassicalLabel.Location = new System.Drawing.Point(124, 42);
            this.txtCDClassicalLabel.Margin = new System.Windows.Forms.Padding(6);
            this.txtCDClassicalLabel.Name = "txtCDClassicalLabel";
            this.txtCDClassicalLabel.Size = new System.Drawing.Size(252, 31);
            this.txtCDClassicalLabel.TabIndex = 1;
            // 
            // lblCDClassicalLabel
            // 
            this.lblCDClassicalLabel.AutoSize = true;
            this.lblCDClassicalLabel.Location = new System.Drawing.Point(44, 50);
            this.lblCDClassicalLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblCDClassicalLabel.Name = "lblCDClassicalLabel";
            this.lblCDClassicalLabel.Size = new System.Drawing.Size(65, 25);
            this.lblCDClassicalLabel.TabIndex = 0;
            this.lblCDClassicalLabel.Text = "Label";
            // 
            // grpCDChamber
            // 
            this.grpCDChamber.Controls.Add(this.txtCDChamberInstrumentList);
            this.grpCDChamber.Controls.Add(this.lblCDChamberInstruments);
            this.grpCDChamber.Location = new System.Drawing.Point(584, 562);
            this.grpCDChamber.Margin = new System.Windows.Forms.Padding(6);
            this.grpCDChamber.Name = "grpCDChamber";
            this.grpCDChamber.Padding = new System.Windows.Forms.Padding(6);
            this.grpCDChamber.Size = new System.Drawing.Size(532, 98);
            this.grpCDChamber.TabIndex = 12;
            this.grpCDChamber.TabStop = false;
            this.grpCDChamber.Text = "CD Chamber Music";
            // 
            // txtCDChamberInstrumentList
            // 
            this.txtCDChamberInstrumentList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.txtCDChamberInstrumentList.FormattingEnabled = true;
            this.txtCDChamberInstrumentList.Location = new System.Drawing.Point(178, 38);
            this.txtCDChamberInstrumentList.Margin = new System.Windows.Forms.Padding(6);
            this.txtCDChamberInstrumentList.Name = "txtCDChamberInstrumentList";
            this.txtCDChamberInstrumentList.Size = new System.Drawing.Size(312, 33);
            this.txtCDChamberInstrumentList.TabIndex = 1;
            // 
            // lblCDChamberInstruments
            // 
            this.lblCDChamberInstruments.AutoSize = true;
            this.lblCDChamberInstruments.Location = new System.Drawing.Point(44, 44);
            this.lblCDChamberInstruments.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblCDChamberInstruments.Name = "lblCDChamberInstruments";
            this.lblCDChamberInstruments.Size = new System.Drawing.Size(123, 25);
            this.lblCDChamberInstruments.TabIndex = 0;
            this.lblCDChamberInstruments.Text = "Instruments";
            // 
            // grpCDOrchestra
            // 
            this.grpCDOrchestra.Controls.Add(this.txtCDOrchestraConductor);
            this.grpCDOrchestra.Controls.Add(this.lblCDOrchestraConductor);
            this.grpCDOrchestra.Location = new System.Drawing.Point(32, 562);
            this.grpCDOrchestra.Margin = new System.Windows.Forms.Padding(6);
            this.grpCDOrchestra.Name = "grpCDOrchestra";
            this.grpCDOrchestra.Padding = new System.Windows.Forms.Padding(6);
            this.grpCDOrchestra.Size = new System.Drawing.Size(540, 98);
            this.grpCDOrchestra.TabIndex = 11;
            this.grpCDOrchestra.TabStop = false;
            this.grpCDOrchestra.Text = "CD Orchestral Music";
            // 
            // txtCDOrchestraConductor
            // 
            this.txtCDOrchestraConductor.Location = new System.Drawing.Point(156, 38);
            this.txtCDOrchestraConductor.Margin = new System.Windows.Forms.Padding(6);
            this.txtCDOrchestraConductor.Name = "txtCDOrchestraConductor";
            this.txtCDOrchestraConductor.Size = new System.Drawing.Size(312, 31);
            this.txtCDOrchestraConductor.TabIndex = 1;
            // 
            // lblCDOrchestraConductor
            // 
            this.lblCDOrchestraConductor.AutoSize = true;
            this.lblCDOrchestraConductor.Location = new System.Drawing.Point(36, 46);
            this.lblCDOrchestraConductor.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblCDOrchestraConductor.Name = "lblCDOrchestraConductor";
            this.lblCDOrchestraConductor.Size = new System.Drawing.Size(111, 25);
            this.lblCDOrchestraConductor.TabIndex = 0;
            this.lblCDOrchestraConductor.Text = "Conductor";
            // 
            // grpDVD
            // 
            this.grpDVD.Controls.Add(this.txtDVDRunTime);
            this.grpDVD.Controls.Add(this.lblDVDRunTime);
            this.grpDVD.Controls.Add(this.txtDVDReleaseDate);
            this.grpDVD.Controls.Add(this.lblDVDReleaseDate);
            this.grpDVD.Controls.Add(this.txtDVDLeadActor);
            this.grpDVD.Controls.Add(this.lblDVDLeadActor);
            this.grpDVD.Location = new System.Drawing.Point(32, 313);
            this.grpDVD.Margin = new System.Windows.Forms.Padding(6);
            this.grpDVD.Name = "grpDVD";
            this.grpDVD.Padding = new System.Windows.Forms.Padding(6);
            this.grpDVD.Size = new System.Drawing.Size(1084, 112);
            this.grpDVD.TabIndex = 10;
            this.grpDVD.TabStop = false;
            this.grpDVD.Text = "DVD";
            // 
            // txtDVDRunTime
            // 
            this.txtDVDRunTime.Location = new System.Drawing.Point(968, 37);
            this.txtDVDRunTime.Margin = new System.Windows.Forms.Padding(6);
            this.txtDVDRunTime.Name = "txtDVDRunTime";
            this.txtDVDRunTime.Size = new System.Drawing.Size(100, 31);
            this.txtDVDRunTime.TabIndex = 5;
            // 
            // lblDVDRunTime
            // 
            this.lblDVDRunTime.AutoSize = true;
            this.lblDVDRunTime.Location = new System.Drawing.Point(862, 44);
            this.lblDVDRunTime.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblDVDRunTime.Name = "lblDVDRunTime";
            this.lblDVDRunTime.Size = new System.Drawing.Size(104, 25);
            this.lblDVDRunTime.TabIndex = 4;
            this.lblDVDRunTime.Text = "Run Time";
            // 
            // txtDVDReleaseDate
            // 
            this.txtDVDReleaseDate.Location = new System.Drawing.Point(648, 37);
            this.txtDVDReleaseDate.Margin = new System.Windows.Forms.Padding(6);
            this.txtDVDReleaseDate.Name = "txtDVDReleaseDate";
            this.txtDVDReleaseDate.Size = new System.Drawing.Size(196, 31);
            this.txtDVDReleaseDate.TabIndex = 3;
            // 
            // lblDVDReleaseDate
            // 
            this.lblDVDReleaseDate.AutoSize = true;
            this.lblDVDReleaseDate.Location = new System.Drawing.Point(490, 44);
            this.lblDVDReleaseDate.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblDVDReleaseDate.Name = "lblDVDReleaseDate";
            this.lblDVDReleaseDate.Size = new System.Drawing.Size(142, 25);
            this.lblDVDReleaseDate.TabIndex = 2;
            this.lblDVDReleaseDate.Text = "Release Date";
            // 
            // txtDVDLeadActor
            // 
            this.txtDVDLeadActor.Location = new System.Drawing.Point(144, 37);
            this.txtDVDLeadActor.Margin = new System.Windows.Forms.Padding(6);
            this.txtDVDLeadActor.Name = "txtDVDLeadActor";
            this.txtDVDLeadActor.Size = new System.Drawing.Size(328, 31);
            this.txtDVDLeadActor.TabIndex = 1;
            // 
            // lblDVDLeadActor
            // 
            this.lblDVDLeadActor.AutoSize = true;
            this.lblDVDLeadActor.Location = new System.Drawing.Point(14, 44);
            this.lblDVDLeadActor.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblDVDLeadActor.Name = "lblDVDLeadActor";
            this.lblDVDLeadActor.Size = new System.Drawing.Size(116, 25);
            this.lblDVDLeadActor.TabIndex = 0;
            this.lblDVDLeadActor.Text = "Lead Actor";
            // 
            // grpBookCIS
            // 
            this.grpBookCIS.Controls.Add(this.txtBookCISCISArea);
            this.grpBookCIS.Controls.Add(this.lblBookCISCISArea);
            this.grpBookCIS.Location = new System.Drawing.Point(32, 210);
            this.grpBookCIS.Margin = new System.Windows.Forms.Padding(6);
            this.grpBookCIS.Name = "grpBookCIS";
            this.grpBookCIS.Padding = new System.Windows.Forms.Padding(6);
            this.grpBookCIS.Size = new System.Drawing.Size(1084, 90);
            this.grpBookCIS.TabIndex = 9;
            this.grpBookCIS.TabStop = false;
            this.grpBookCIS.Text = "CIS Book";
            // 
            // txtBookCISCISArea
            // 
            this.txtBookCISCISArea.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.txtBookCISCISArea.FormattingEnabled = true;
            this.txtBookCISCISArea.Location = new System.Drawing.Point(134, 33);
            this.txtBookCISCISArea.Margin = new System.Windows.Forms.Padding(6);
            this.txtBookCISCISArea.Name = "txtBookCISCISArea";
            this.txtBookCISCISArea.Size = new System.Drawing.Size(334, 33);
            this.txtBookCISCISArea.TabIndex = 1;
            // 
            // lblBookCISCISArea
            // 
            this.lblBookCISCISArea.AutoSize = true;
            this.lblBookCISCISArea.Location = new System.Drawing.Point(24, 38);
            this.lblBookCISCISArea.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblBookCISCISArea.Name = "lblBookCISCISArea";
            this.lblBookCISCISArea.Size = new System.Drawing.Size(97, 25);
            this.lblBookCISCISArea.TabIndex = 0;
            this.lblBookCISCISArea.Text = "CIS Area";
            // 
            // grpBook
            // 
            this.grpBook.Controls.Add(this.txtBookPages);
            this.grpBook.Controls.Add(this.lblBookPages);
            this.grpBook.Controls.Add(this.txtBookAuthor);
            this.grpBook.Controls.Add(this.lblBookAuthor);
            this.grpBook.Controls.Add(this.txtBookISBNRight);
            this.grpBook.Controls.Add(this.lblBookISBNHyphen);
            this.grpBook.Controls.Add(this.txtBookISBNLeft);
            this.grpBook.Controls.Add(this.lblBookISBN);
            this.grpBook.Location = new System.Drawing.Point(32, 100);
            this.grpBook.Margin = new System.Windows.Forms.Padding(6);
            this.grpBook.Name = "grpBook";
            this.grpBook.Padding = new System.Windows.Forms.Padding(6);
            this.grpBook.Size = new System.Drawing.Size(1084, 98);
            this.grpBook.TabIndex = 8;
            this.grpBook.TabStop = false;
            this.grpBook.Text = "Book";
            // 
            // txtBookPages
            // 
            this.txtBookPages.Location = new System.Drawing.Point(924, 37);
            this.txtBookPages.Margin = new System.Windows.Forms.Padding(6);
            this.txtBookPages.Name = "txtBookPages";
            this.txtBookPages.Size = new System.Drawing.Size(102, 31);
            this.txtBookPages.TabIndex = 7;
            // 
            // lblBookPages
            // 
            this.lblBookPages.AutoSize = true;
            this.lblBookPages.Location = new System.Drawing.Point(838, 44);
            this.lblBookPages.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblBookPages.Name = "lblBookPages";
            this.lblBookPages.Size = new System.Drawing.Size(73, 25);
            this.lblBookPages.TabIndex = 6;
            this.lblBookPages.Text = "Pages";
            // 
            // txtBookAuthor
            // 
            this.txtBookAuthor.Location = new System.Drawing.Point(438, 37);
            this.txtBookAuthor.Margin = new System.Windows.Forms.Padding(6);
            this.txtBookAuthor.Name = "txtBookAuthor";
            this.txtBookAuthor.Size = new System.Drawing.Size(356, 31);
            this.txtBookAuthor.TabIndex = 5;
            // 
            // lblBookAuthor
            // 
            this.lblBookAuthor.AutoSize = true;
            this.lblBookAuthor.Location = new System.Drawing.Point(348, 44);
            this.lblBookAuthor.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblBookAuthor.Name = "lblBookAuthor";
            this.lblBookAuthor.Size = new System.Drawing.Size(75, 25);
            this.lblBookAuthor.TabIndex = 4;
            this.lblBookAuthor.Text = "Author";
            // 
            // txtBookISBNRight
            // 
            this.txtBookISBNRight.Location = new System.Drawing.Point(218, 37);
            this.txtBookISBNRight.Margin = new System.Windows.Forms.Padding(6);
            this.txtBookISBNRight.Name = "txtBookISBNRight";
            this.txtBookISBNRight.Size = new System.Drawing.Size(86, 31);
            this.txtBookISBNRight.TabIndex = 3;
            // 
            // lblBookISBNHyphen
            // 
            this.lblBookISBNHyphen.AutoSize = true;
            this.lblBookISBNHyphen.Location = new System.Drawing.Point(192, 44);
            this.lblBookISBNHyphen.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblBookISBNHyphen.Name = "lblBookISBNHyphen";
            this.lblBookISBNHyphen.Size = new System.Drawing.Size(19, 25);
            this.lblBookISBNHyphen.TabIndex = 2;
            this.lblBookISBNHyphen.Text = "-";
            // 
            // txtBookISBNLeft
            // 
            this.txtBookISBNLeft.Location = new System.Drawing.Point(90, 37);
            this.txtBookISBNLeft.Margin = new System.Windows.Forms.Padding(6);
            this.txtBookISBNLeft.Name = "txtBookISBNLeft";
            this.txtBookISBNLeft.Size = new System.Drawing.Size(86, 31);
            this.txtBookISBNLeft.TabIndex = 1;
            // 
            // lblBookISBN
            // 
            this.lblBookISBN.AutoSize = true;
            this.lblBookISBN.Location = new System.Drawing.Point(18, 44);
            this.lblBookISBN.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblBookISBN.Name = "lblBookISBN";
            this.lblBookISBN.Size = new System.Drawing.Size(60, 25);
            this.lblBookISBN.TabIndex = 0;
            this.lblBookISBN.Text = "ISBN";
            // 
            // txtProductQuantity
            // 
            this.txtProductQuantity.Location = new System.Drawing.Point(1032, 33);
            this.txtProductQuantity.Margin = new System.Windows.Forms.Padding(6);
            this.txtProductQuantity.Name = "txtProductQuantity";
            this.txtProductQuantity.Size = new System.Drawing.Size(80, 31);
            this.txtProductQuantity.TabIndex = 7;
            // 
            // lblProductQuantity
            // 
            this.lblProductQuantity.AutoSize = true;
            this.lblProductQuantity.Location = new System.Drawing.Point(934, 40);
            this.lblProductQuantity.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblProductQuantity.Name = "lblProductQuantity";
            this.lblProductQuantity.Size = new System.Drawing.Size(92, 25);
            this.lblProductQuantity.TabIndex = 6;
            this.lblProductQuantity.Text = "Quantity";
            // 
            // txtProductTitle
            // 
            this.txtProductTitle.Location = new System.Drawing.Point(600, 33);
            this.txtProductTitle.Margin = new System.Windows.Forms.Padding(6);
            this.txtProductTitle.Name = "txtProductTitle";
            this.txtProductTitle.Size = new System.Drawing.Size(304, 31);
            this.txtProductTitle.TabIndex = 5;
            // 
            // lblProductTitle
            // 
            this.lblProductTitle.AutoSize = true;
            this.lblProductTitle.Location = new System.Drawing.Point(540, 40);
            this.lblProductTitle.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblProductTitle.Name = "lblProductTitle";
            this.lblProductTitle.Size = new System.Drawing.Size(53, 25);
            this.lblProductTitle.TabIndex = 4;
            this.lblProductTitle.Text = "Title";
            // 
            // lblProductPrice
            // 
            this.lblProductPrice.AutoSize = true;
            this.lblProductPrice.Location = new System.Drawing.Point(314, 40);
            this.lblProductPrice.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblProductPrice.Name = "lblProductPrice";
            this.lblProductPrice.Size = new System.Drawing.Size(61, 25);
            this.lblProductPrice.TabIndex = 3;
            this.lblProductPrice.Text = "Price";
            // 
            // lblProductUPC
            // 
            this.lblProductUPC.AutoSize = true;
            this.lblProductUPC.Location = new System.Drawing.Point(50, 40);
            this.lblProductUPC.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblProductUPC.Name = "lblProductUPC";
            this.lblProductUPC.Size = new System.Drawing.Size(56, 25);
            this.lblProductUPC.TabIndex = 2;
            this.lblProductUPC.Text = "UPC";
            // 
            // txtProductPrice
            // 
            this.txtProductPrice.Location = new System.Drawing.Point(382, 33);
            this.txtProductPrice.Margin = new System.Windows.Forms.Padding(6);
            this.txtProductPrice.Name = "txtProductPrice";
            this.txtProductPrice.Size = new System.Drawing.Size(122, 31);
            this.txtProductPrice.TabIndex = 1;
            // 
            // txtProductUPC
            // 
            this.txtProductUPC.Location = new System.Drawing.Point(112, 33);
            this.txtProductUPC.Margin = new System.Windows.Forms.Padding(6);
            this.txtProductUPC.Name = "txtProductUPC";
            this.txtProductUPC.Size = new System.Drawing.Size(170, 31);
            this.txtProductUPC.TabIndex = 0;
            // 
            // grpFormDataControls
            // 
            this.grpFormDataControls.Controls.Add(this.btnDelete);
            this.grpFormDataControls.Controls.Add(this.btnSaveEditUpdate);
            this.grpFormDataControls.Controls.Add(this.btnEdit);
            this.grpFormDataControls.Controls.Add(this.btnFind);
            this.grpFormDataControls.Controls.Add(this.btnEnterUPC);
            this.grpFormDataControls.Controls.Add(this.lblFormDataControls);
            this.grpFormDataControls.Location = new System.Drawing.Point(98, 969);
            this.grpFormDataControls.Margin = new System.Windows.Forms.Padding(6);
            this.grpFormDataControls.Name = "grpFormDataControls";
            this.grpFormDataControls.Padding = new System.Windows.Forms.Padding(6);
            this.grpFormDataControls.Size = new System.Drawing.Size(1132, 162);
            this.grpFormDataControls.TabIndex = 5;
            this.grpFormDataControls.TabStop = false;
            this.grpFormDataControls.Text = "Form Controls for Data Processing";
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(996, 98);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(6);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(124, 44);
            this.btnDelete.TabIndex = 5;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            // 
            // btnSaveEditUpdate
            // 
            this.btnSaveEditUpdate.Location = new System.Drawing.Point(758, 98);
            this.btnSaveEditUpdate.Margin = new System.Windows.Forms.Padding(6);
            this.btnSaveEditUpdate.Name = "btnSaveEditUpdate";
            this.btnSaveEditUpdate.Size = new System.Drawing.Size(206, 44);
            this.btnSaveEditUpdate.TabIndex = 4;
            this.btnSaveEditUpdate.Text = "Save Updates";
            this.btnSaveEditUpdate.UseVisualStyleBackColor = true;
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(546, 98);
            this.btnEdit.Margin = new System.Windows.Forms.Padding(6);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(182, 44);
            this.btnEdit.TabIndex = 3;
            this.btnEdit.Text = "Edit/Update";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnFind
            // 
            this.btnFind.Location = new System.Drawing.Point(330, 98);
            this.btnFind.Margin = new System.Windows.Forms.Padding(6);
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(182, 44);
            this.btnFind.TabIndex = 2;
            this.btnFind.Text = "Find/Display";
            this.btnFind.UseVisualStyleBackColor = true;
            // 
            // btnEnterUPC
            // 
            this.btnEnterUPC.BackColor = System.Drawing.Color.LimeGreen;
            this.btnEnterUPC.Location = new System.Drawing.Point(18, 98);
            this.btnEnterUPC.Margin = new System.Windows.Forms.Padding(6);
            this.btnEnterUPC.Name = "btnEnterUPC";
            this.btnEnterUPC.Size = new System.Drawing.Size(288, 44);
            this.btnEnterUPC.TabIndex = 1;
            this.btnEnterUPC.Text = "Click HERE to enter a UPC";
            this.btnEnterUPC.UseVisualStyleBackColor = false;
            // 
            // lblFormDataControls
            // 
            this.lblFormDataControls.AutoSize = true;
            this.lblFormDataControls.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lblFormDataControls.ForeColor = System.Drawing.Color.DarkOrange;
            this.lblFormDataControls.Location = new System.Drawing.Point(12, 31);
            this.lblFormDataControls.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblFormDataControls.Name = "lblFormDataControls";
            this.lblFormDataControls.Size = new System.Drawing.Size(987, 52);
            this.lblFormDataControls.TabIndex = 0;
            this.lblFormDataControls.Text = "These operations require entry of an Product UPC (see above) before they can be e" +
    "xecuted.\r\nPress CLEAR FORM when operation is complete.";
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.OrangeRed;
            this.btnClear.Location = new System.Drawing.Point(1272, 287);
            this.btnClear.Margin = new System.Windows.Forms.Padding(6);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(124, 88);
            this.btnClear.TabIndex = 6;
            this.btnClear.Text = "Clear Form";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.OrangeRed;
            this.btnExit.Location = new System.Drawing.Point(1272, 440);
            this.btnExit.Margin = new System.Windows.Forms.Padding(6);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(124, 88);
            this.btnExit.TabIndex = 7;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // frmBookCDDVDShop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1426, 1148);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.grpFormDataControls);
            this.Controls.Add(this.grpProduct);
            this.Controls.Add(this.lblProductDirections);
            this.Controls.Add(this.grpCreateControls);
            this.Controls.Add(this.lblControlDirections);
            this.Controls.Add(this.lblDescription);
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "frmBookCDDVDShop";
            this.Text = "Book CD DVD Shop";
            this.Load += new System.EventHandler(this.frmBookCDDVDShop_Load);
            this.grpCreateControls.ResumeLayout(false);
            this.grpProduct.ResumeLayout(false);
            this.grpProduct.PerformLayout();
            this.grpCDClassical.ResumeLayout(false);
            this.grpCDClassical.PerformLayout();
            this.grpCDChamber.ResumeLayout(false);
            this.grpCDChamber.PerformLayout();
            this.grpCDOrchestra.ResumeLayout(false);
            this.grpCDOrchestra.PerformLayout();
            this.grpDVD.ResumeLayout(false);
            this.grpDVD.PerformLayout();
            this.grpBookCIS.ResumeLayout(false);
            this.grpBookCIS.PerformLayout();
            this.grpBook.ResumeLayout(false);
            this.grpBook.PerformLayout();
            this.grpFormDataControls.ResumeLayout(false);
            this.grpFormDataControls.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.Label lblControlDirections;
        private System.Windows.Forms.GroupBox grpCreateControls;
        private System.Windows.Forms.Label lblProductDirections;
        private System.Windows.Forms.Label lblCDChamberInstruments;
        private System.Windows.Forms.Label lblCDOrchestraConductor;
        private System.Windows.Forms.Label lblDVDRunTime;
        private System.Windows.Forms.Label lblDVDReleaseDate;
        private System.Windows.Forms.Label lblDVDLeadActor;
        private System.Windows.Forms.Label lblBookCISCISArea;
        private System.Windows.Forms.Label lblBookPages;
        private System.Windows.Forms.Label lblBookAuthor;
        private System.Windows.Forms.Label lblBookISBNHyphen;
        private System.Windows.Forms.Label lblBookISBN;
        private System.Windows.Forms.Label lblProductQuantity;
        private System.Windows.Forms.Label lblProductTitle;
        private System.Windows.Forms.Label lblProductPrice;
        private System.Windows.Forms.Label lblProductUPC;
        private System.Windows.Forms.GroupBox grpFormDataControls;
        private System.Windows.Forms.Label lblFormDataControls;
        private System.Windows.Forms.Label lblCDClassicalArtists;
        private System.Windows.Forms.Label lblCDClassicalLabel;
        private System.Windows.Forms.ToolTip toolTip1;
        internal System.Windows.Forms.Button btnClear;
        internal System.Windows.Forms.Button btnExit;
        internal System.Windows.Forms.Button btnCreateCDChamber;
        internal System.Windows.Forms.Button btnCreateCDOrchestra;
        internal System.Windows.Forms.Button btnCreateDVD;
        internal System.Windows.Forms.Button btnCreateBookCIS;
        internal System.Windows.Forms.Button btnCreateBook;
        internal System.Windows.Forms.Button btnDelete;
        internal System.Windows.Forms.Button btnSaveEditUpdate;
        internal System.Windows.Forms.Button btnEdit;
        internal System.Windows.Forms.Button btnFind;
        internal System.Windows.Forms.Button btnEnterUPC;
        internal System.Windows.Forms.GroupBox grpProduct;
        internal System.Windows.Forms.GroupBox grpCDChamber;
        internal System.Windows.Forms.GroupBox grpCDOrchestra;
        internal System.Windows.Forms.GroupBox grpDVD;
        internal System.Windows.Forms.GroupBox grpBookCIS;
        internal System.Windows.Forms.GroupBox grpBook;
        internal System.Windows.Forms.GroupBox grpCDClassical;
        internal System.Windows.Forms.ComboBox txtCDChamberInstrumentList;
        internal System.Windows.Forms.TextBox txtCDOrchestraConductor;
        internal System.Windows.Forms.TextBox txtDVDRunTime;
        internal System.Windows.Forms.TextBox txtDVDReleaseDate;
        internal System.Windows.Forms.TextBox txtDVDLeadActor;
        internal System.Windows.Forms.ComboBox txtBookCISCISArea;
        internal System.Windows.Forms.TextBox txtBookPages;
        internal System.Windows.Forms.TextBox txtBookAuthor;
        internal System.Windows.Forms.TextBox txtBookISBNRight;
        internal System.Windows.Forms.TextBox txtBookISBNLeft;
        internal System.Windows.Forms.TextBox txtProductQuantity;
        internal System.Windows.Forms.TextBox txtProductTitle;
        internal System.Windows.Forms.TextBox txtProductPrice;
        internal System.Windows.Forms.TextBox txtCDClassicalArtists;
        internal System.Windows.Forms.TextBox txtCDClassicalLabel;
        internal System.Windows.Forms.TextBox txtProductUPC;
    }
}

