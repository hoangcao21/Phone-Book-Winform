namespace PhoneBook
{
    partial class MainForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.metroSetLabel1 = new MetroSet_UI.Controls.MetroSetLabel();
            this.txbPhoneNumber = new MetroSet_UI.Controls.MetroSetTextBox();
            this.txbFirstName = new MetroSet_UI.Controls.MetroSetTextBox();
            this.metroSetLabel2 = new MetroSet_UI.Controls.MetroSetLabel();
            this.txbLastName = new MetroSet_UI.Controls.MetroSetTextBox();
            this.metroSetLabel3 = new MetroSet_UI.Controls.MetroSetLabel();
            this.txbAddress = new MetroSet_UI.Controls.MetroSetTextBox();
            this.metroSetLabel4 = new MetroSet_UI.Controls.MetroSetLabel();
            this.btnSearch = new MetroSet_UI.Controls.MetroSetButton();
            this.metroSetControlBox1 = new MetroSet_UI.Controls.MetroSetControlBox();
            this.btnNew = new MetroSet_UI.Controls.MetroSetButton();
            this.btnEdit = new MetroSet_UI.Controls.MetroSetButton();
            this.metroSetTile1 = new MetroSet_UI.Controls.MetroSetTile();
            this.lbInfo = new MetroSet_UI.Controls.MetroSetLabel();
            this.dgPhoneBook = new System.Windows.Forms.DataGridView();
            this.btnSearchHidden = new System.Windows.Forms.Button();
            this.btnReset = new MetroSet_UI.Controls.MetroSetButton();
            this.btnExportToExcel = new MetroSet_UI.Controls.MetroSetButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgPhoneBook)).BeginInit();
            this.SuspendLayout();
            // 
            // metroSetLabel1
            // 
            this.metroSetLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.metroSetLabel1.Location = new System.Drawing.Point(16, 88);
            this.metroSetLabel1.Name = "metroSetLabel1";
            this.metroSetLabel1.Size = new System.Drawing.Size(123, 23);
            this.metroSetLabel1.Style = MetroSet_UI.Design.Style.Light;
            this.metroSetLabel1.StyleManager = null;
            this.metroSetLabel1.TabIndex = 0;
            this.metroSetLabel1.Text = "Phone Number";
            this.metroSetLabel1.ThemeAuthor = "Narwin";
            this.metroSetLabel1.ThemeName = "MetroLite";
            // 
            // txbPhoneNumber
            // 
            this.txbPhoneNumber.AutoCompleteCustomSource = null;
            this.txbPhoneNumber.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txbPhoneNumber.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txbPhoneNumber.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            this.txbPhoneNumber.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.txbPhoneNumber.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            this.txbPhoneNumber.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            this.txbPhoneNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txbPhoneNumber.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.txbPhoneNumber.Image = null;
            this.txbPhoneNumber.Lines = null;
            this.txbPhoneNumber.Location = new System.Drawing.Point(16, 115);
            this.txbPhoneNumber.MaxLength = 20;
            this.txbPhoneNumber.Multiline = false;
            this.txbPhoneNumber.Name = "txbPhoneNumber";
            this.txbPhoneNumber.ReadOnly = false;
            this.txbPhoneNumber.Size = new System.Drawing.Size(135, 30);
            this.txbPhoneNumber.Style = MetroSet_UI.Design.Style.Light;
            this.txbPhoneNumber.StyleManager = null;
            this.txbPhoneNumber.TabIndex = 1;
            this.txbPhoneNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txbPhoneNumber.ThemeAuthor = "Narwin";
            this.txbPhoneNumber.ThemeName = "MetroLite";
            this.txbPhoneNumber.UseSystemPasswordChar = false;
            this.txbPhoneNumber.WatermarkText = "";
            // 
            // txbFirstName
            // 
            this.txbFirstName.AutoCompleteCustomSource = null;
            this.txbFirstName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txbFirstName.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txbFirstName.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            this.txbFirstName.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.txbFirstName.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            this.txbFirstName.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            this.txbFirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txbFirstName.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.txbFirstName.Image = null;
            this.txbFirstName.Lines = null;
            this.txbFirstName.Location = new System.Drawing.Point(16, 190);
            this.txbFirstName.MaxLength = 20;
            this.txbFirstName.Multiline = false;
            this.txbFirstName.Name = "txbFirstName";
            this.txbFirstName.ReadOnly = false;
            this.txbFirstName.Size = new System.Drawing.Size(135, 30);
            this.txbFirstName.Style = MetroSet_UI.Design.Style.Light;
            this.txbFirstName.StyleManager = null;
            this.txbFirstName.TabIndex = 3;
            this.txbFirstName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txbFirstName.ThemeAuthor = "Narwin";
            this.txbFirstName.ThemeName = "MetroLite";
            this.txbFirstName.UseSystemPasswordChar = false;
            this.txbFirstName.WatermarkText = "";
            // 
            // metroSetLabel2
            // 
            this.metroSetLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.metroSetLabel2.Location = new System.Drawing.Point(16, 163);
            this.metroSetLabel2.Name = "metroSetLabel2";
            this.metroSetLabel2.Size = new System.Drawing.Size(100, 23);
            this.metroSetLabel2.Style = MetroSet_UI.Design.Style.Light;
            this.metroSetLabel2.StyleManager = null;
            this.metroSetLabel2.TabIndex = 2;
            this.metroSetLabel2.Text = "First Name";
            this.metroSetLabel2.ThemeAuthor = "Narwin";
            this.metroSetLabel2.ThemeName = "MetroLite";
            // 
            // txbLastName
            // 
            this.txbLastName.AutoCompleteCustomSource = null;
            this.txbLastName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txbLastName.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txbLastName.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            this.txbLastName.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.txbLastName.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            this.txbLastName.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            this.txbLastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txbLastName.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.txbLastName.Image = null;
            this.txbLastName.Lines = null;
            this.txbLastName.Location = new System.Drawing.Point(15, 268);
            this.txbLastName.MaxLength = 20;
            this.txbLastName.Multiline = false;
            this.txbLastName.Name = "txbLastName";
            this.txbLastName.ReadOnly = false;
            this.txbLastName.Size = new System.Drawing.Size(135, 30);
            this.txbLastName.Style = MetroSet_UI.Design.Style.Light;
            this.txbLastName.StyleManager = null;
            this.txbLastName.TabIndex = 5;
            this.txbLastName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txbLastName.ThemeAuthor = "Narwin";
            this.txbLastName.ThemeName = "MetroLite";
            this.txbLastName.UseSystemPasswordChar = false;
            this.txbLastName.WatermarkText = "";
            // 
            // metroSetLabel3
            // 
            this.metroSetLabel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.metroSetLabel3.Location = new System.Drawing.Point(15, 241);
            this.metroSetLabel3.Name = "metroSetLabel3";
            this.metroSetLabel3.Size = new System.Drawing.Size(100, 23);
            this.metroSetLabel3.Style = MetroSet_UI.Design.Style.Light;
            this.metroSetLabel3.StyleManager = null;
            this.metroSetLabel3.TabIndex = 4;
            this.metroSetLabel3.Text = "Last Name";
            this.metroSetLabel3.ThemeAuthor = "Narwin";
            this.metroSetLabel3.ThemeName = "MetroLite";
            // 
            // txbAddress
            // 
            this.txbAddress.AutoCompleteCustomSource = null;
            this.txbAddress.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txbAddress.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txbAddress.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            this.txbAddress.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.txbAddress.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            this.txbAddress.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            this.txbAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txbAddress.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.txbAddress.Image = null;
            this.txbAddress.Lines = null;
            this.txbAddress.Location = new System.Drawing.Point(15, 345);
            this.txbAddress.MaxLength = 100;
            this.txbAddress.Multiline = false;
            this.txbAddress.Name = "txbAddress";
            this.txbAddress.ReadOnly = false;
            this.txbAddress.Size = new System.Drawing.Size(135, 30);
            this.txbAddress.Style = MetroSet_UI.Design.Style.Light;
            this.txbAddress.StyleManager = null;
            this.txbAddress.TabIndex = 7;
            this.txbAddress.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txbAddress.ThemeAuthor = "Narwin";
            this.txbAddress.ThemeName = "MetroLite";
            this.txbAddress.UseSystemPasswordChar = false;
            this.txbAddress.WatermarkText = "";
            // 
            // metroSetLabel4
            // 
            this.metroSetLabel4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.metroSetLabel4.Location = new System.Drawing.Point(15, 318);
            this.metroSetLabel4.Name = "metroSetLabel4";
            this.metroSetLabel4.Size = new System.Drawing.Size(100, 23);
            this.metroSetLabel4.Style = MetroSet_UI.Design.Style.Light;
            this.metroSetLabel4.StyleManager = null;
            this.metroSetLabel4.TabIndex = 6;
            this.metroSetLabel4.Text = "Address";
            this.metroSetLabel4.ThemeAuthor = "Narwin";
            this.metroSetLabel4.ThemeName = "MetroLite";
            // 
            // btnSearch
            // 
            this.btnSearch.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.btnSearch.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.btnSearch.DisabledForeColor = System.Drawing.Color.Gray;
            this.btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnSearch.HoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(207)))), ((int)(((byte)(255)))));
            this.btnSearch.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(207)))), ((int)(((byte)(255)))));
            this.btnSearch.HoverTextColor = System.Drawing.Color.White;
            this.btnSearch.Location = new System.Drawing.Point(14, 392);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.NormalBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.btnSearch.NormalColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.btnSearch.NormalTextColor = System.Drawing.Color.White;
            this.btnSearch.PressBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(147)))), ((int)(((byte)(195)))));
            this.btnSearch.PressColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(147)))), ((int)(((byte)(195)))));
            this.btnSearch.PressTextColor = System.Drawing.Color.White;
            this.btnSearch.Size = new System.Drawing.Size(136, 23);
            this.btnSearch.Style = MetroSet_UI.Design.Style.Light;
            this.btnSearch.StyleManager = null;
            this.btnSearch.TabIndex = 8;
            this.btnSearch.Text = "Search";
            this.btnSearch.ThemeAuthor = "Narwin";
            this.btnSearch.ThemeName = "MetroLite";
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // metroSetControlBox1
            // 
            this.metroSetControlBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.metroSetControlBox1.CloseHoverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.metroSetControlBox1.CloseHoverForeColor = System.Drawing.Color.White;
            this.metroSetControlBox1.CloseNormalForeColor = System.Drawing.Color.Gray;
            this.metroSetControlBox1.DisabledForeColor = System.Drawing.Color.DimGray;
            this.metroSetControlBox1.Location = new System.Drawing.Point(900, 1);
            this.metroSetControlBox1.MaximizeBox = true;
            this.metroSetControlBox1.MaximizeHoverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.metroSetControlBox1.MaximizeHoverForeColor = System.Drawing.Color.Gray;
            this.metroSetControlBox1.MaximizeNormalForeColor = System.Drawing.Color.Gray;
            this.metroSetControlBox1.MinimizeBox = true;
            this.metroSetControlBox1.MinimizeHoverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.metroSetControlBox1.MinimizeHoverForeColor = System.Drawing.Color.Gray;
            this.metroSetControlBox1.MinimizeNormalForeColor = System.Drawing.Color.Gray;
            this.metroSetControlBox1.Name = "metroSetControlBox1";
            this.metroSetControlBox1.Size = new System.Drawing.Size(100, 25);
            this.metroSetControlBox1.Style = MetroSet_UI.Design.Style.Light;
            this.metroSetControlBox1.StyleManager = null;
            this.metroSetControlBox1.TabIndex = 10;
            this.metroSetControlBox1.Text = "metroSetControlBox1";
            this.metroSetControlBox1.ThemeAuthor = "Narwin";
            this.metroSetControlBox1.ThemeName = "MetroLite";
            // 
            // btnNew
            // 
            this.btnNew.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.btnNew.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.btnNew.DisabledForeColor = System.Drawing.Color.Gray;
            this.btnNew.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnNew.HoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(207)))), ((int)(((byte)(255)))));
            this.btnNew.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(207)))), ((int)(((byte)(255)))));
            this.btnNew.HoverTextColor = System.Drawing.Color.White;
            this.btnNew.Location = new System.Drawing.Point(818, 392);
            this.btnNew.Name = "btnNew";
            this.btnNew.NormalBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.btnNew.NormalColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.btnNew.NormalTextColor = System.Drawing.Color.White;
            this.btnNew.PressBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(147)))), ((int)(((byte)(195)))));
            this.btnNew.PressColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(147)))), ((int)(((byte)(195)))));
            this.btnNew.PressTextColor = System.Drawing.Color.White;
            this.btnNew.Size = new System.Drawing.Size(75, 23);
            this.btnNew.Style = MetroSet_UI.Design.Style.Light;
            this.btnNew.StyleManager = null;
            this.btnNew.TabIndex = 11;
            this.btnNew.Text = "New";
            this.btnNew.ThemeAuthor = "Narwin";
            this.btnNew.ThemeName = "MetroLite";
            this.btnNew.Click += new System.EventHandler(this.BtnNew_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.btnEdit.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.btnEdit.DisabledForeColor = System.Drawing.Color.Gray;
            this.btnEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnEdit.HoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(207)))), ((int)(((byte)(255)))));
            this.btnEdit.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(207)))), ((int)(((byte)(255)))));
            this.btnEdit.HoverTextColor = System.Drawing.Color.White;
            this.btnEdit.Location = new System.Drawing.Point(910, 392);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.NormalBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.btnEdit.NormalColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.btnEdit.NormalTextColor = System.Drawing.Color.White;
            this.btnEdit.PressBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(147)))), ((int)(((byte)(195)))));
            this.btnEdit.PressColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(147)))), ((int)(((byte)(195)))));
            this.btnEdit.PressTextColor = System.Drawing.Color.White;
            this.btnEdit.Size = new System.Drawing.Size(75, 23);
            this.btnEdit.Style = MetroSet_UI.Design.Style.Light;
            this.btnEdit.StyleManager = null;
            this.btnEdit.TabIndex = 12;
            this.btnEdit.Text = "Edit";
            this.btnEdit.ThemeAuthor = "Narwin";
            this.btnEdit.ThemeName = "MetroLite";
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // metroSetTile1
            // 
            this.metroSetTile1.BackgroundImage = global::PhoneBook.Properties.Resources.phonebook_icon;
            this.metroSetTile1.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.metroSetTile1.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            this.metroSetTile1.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            this.metroSetTile1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.metroSetTile1.HoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.metroSetTile1.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.metroSetTile1.HoverTextColor = System.Drawing.Color.White;
            this.metroSetTile1.Location = new System.Drawing.Point(116, 44);
            this.metroSetTile1.Name = "metroSetTile1";
            this.metroSetTile1.NormalBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.metroSetTile1.NormalColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.metroSetTile1.NormalTextColor = System.Drawing.Color.White;
            this.metroSetTile1.PressBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.metroSetTile1.PressColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.metroSetTile1.PressTextColor = System.Drawing.Color.White;
            this.metroSetTile1.Size = new System.Drawing.Size(34, 27);
            this.metroSetTile1.Style = MetroSet_UI.Design.Style.Light;
            this.metroSetTile1.StyleManager = null;
            this.metroSetTile1.TabIndex = 13;
            this.metroSetTile1.ThemeAuthor = "Narwin";
            this.metroSetTile1.ThemeName = "MetroLite";
            this.metroSetTile1.TileAlign = MetroSet_UI.Enums.TileAlign.BottmLeft;
            // 
            // lbInfo
            // 
            this.lbInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbInfo.Location = new System.Drawing.Point(496, 59);
            this.lbInfo.Name = "lbInfo";
            this.lbInfo.Size = new System.Drawing.Size(304, 23);
            this.lbInfo.Style = MetroSet_UI.Design.Style.Light;
            this.lbInfo.StyleManager = null;
            this.lbInfo.TabIndex = 14;
            this.lbInfo.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.lbInfo.ThemeAuthor = "Narwin";
            this.lbInfo.ThemeName = "MetroLite";
            this.lbInfo.Click += new System.EventHandler(this.lbInfo_Click);
            // 
            // dgPhoneBook
            // 
            this.dgPhoneBook.BackgroundColor = System.Drawing.Color.LightSkyBlue;
            this.dgPhoneBook.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgPhoneBook.GridColor = System.Drawing.SystemColors.ActiveBorder;
            this.dgPhoneBook.Location = new System.Drawing.Point(166, 88);
            this.dgPhoneBook.MultiSelect = false;
            this.dgPhoneBook.Name = "dgPhoneBook";
            this.dgPhoneBook.ReadOnly = true;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.dgPhoneBook.RowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgPhoneBook.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgPhoneBook.Size = new System.Drawing.Size(819, 287);
            this.dgPhoneBook.TabIndex = 9;
            this.dgPhoneBook.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgPhoneBook_CellClick);
            this.dgPhoneBook.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgPhoneBook_CellContentClick);
            // 
            // btnSearchHidden
            // 
            this.btnSearchHidden.BackColor = System.Drawing.Color.Transparent;
            this.btnSearchHidden.ForeColor = System.Drawing.Color.Transparent;
            this.btnSearchHidden.Location = new System.Drawing.Point(188, 379);
            this.btnSearchHidden.Name = "btnSearchHidden";
            this.btnSearchHidden.Size = new System.Drawing.Size(1, 1);
            this.btnSearchHidden.TabIndex = 15;
            this.btnSearchHidden.UseVisualStyleBackColor = false;
            // 
            // btnReset
            // 
            this.btnReset.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.btnReset.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.btnReset.DisabledForeColor = System.Drawing.Color.Gray;
            this.btnReset.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnReset.HoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(207)))), ((int)(((byte)(255)))));
            this.btnReset.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(207)))), ((int)(((byte)(255)))));
            this.btnReset.HoverTextColor = System.Drawing.Color.White;
            this.btnReset.Location = new System.Drawing.Point(166, 392);
            this.btnReset.Name = "btnReset";
            this.btnReset.NormalBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.btnReset.NormalColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.btnReset.NormalTextColor = System.Drawing.Color.White;
            this.btnReset.PressBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(147)))), ((int)(((byte)(195)))));
            this.btnReset.PressColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(147)))), ((int)(((byte)(195)))));
            this.btnReset.PressTextColor = System.Drawing.Color.White;
            this.btnReset.Size = new System.Drawing.Size(137, 23);
            this.btnReset.Style = MetroSet_UI.Design.Style.Light;
            this.btnReset.StyleManager = null;
            this.btnReset.TabIndex = 16;
            this.btnReset.Text = "Reset All";
            this.btnReset.ThemeAuthor = "Narwin";
            this.btnReset.ThemeName = "MetroLite";
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnExportToExcel
            // 
            this.btnExportToExcel.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.btnExportToExcel.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.btnExportToExcel.DisabledForeColor = System.Drawing.Color.Gray;
            this.btnExportToExcel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnExportToExcel.HoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(207)))), ((int)(((byte)(255)))));
            this.btnExportToExcel.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(207)))), ((int)(((byte)(255)))));
            this.btnExportToExcel.HoverTextColor = System.Drawing.Color.White;
            this.btnExportToExcel.Location = new System.Drawing.Point(818, 59);
            this.btnExportToExcel.Name = "btnExportToExcel";
            this.btnExportToExcel.NormalBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.btnExportToExcel.NormalColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.btnExportToExcel.NormalTextColor = System.Drawing.Color.White;
            this.btnExportToExcel.PressBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(147)))), ((int)(((byte)(195)))));
            this.btnExportToExcel.PressColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(147)))), ((int)(((byte)(195)))));
            this.btnExportToExcel.PressTextColor = System.Drawing.Color.White;
            this.btnExportToExcel.Size = new System.Drawing.Size(167, 23);
            this.btnExportToExcel.Style = MetroSet_UI.Design.Style.Light;
            this.btnExportToExcel.StyleManager = null;
            this.btnExportToExcel.TabIndex = 17;
            this.btnExportToExcel.Text = "Export results to Excel";
            this.btnExportToExcel.ThemeAuthor = "Narwin";
            this.btnExportToExcel.ThemeName = "MetroLite";
            this.btnExportToExcel.Click += new System.EventHandler(this.btnExportToExcel_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 428);
            this.Controls.Add(this.btnExportToExcel);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnSearchHidden);
            this.Controls.Add(this.lbInfo);
            this.Controls.Add(this.metroSetTile1);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnNew);
            this.Controls.Add(this.metroSetControlBox1);
            this.Controls.Add(this.dgPhoneBook);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txbAddress);
            this.Controls.Add(this.metroSetLabel4);
            this.Controls.Add(this.txbLastName);
            this.Controls.Add(this.metroSetLabel3);
            this.Controls.Add(this.txbFirstName);
            this.Controls.Add(this.metroSetLabel2);
            this.Controls.Add(this.txbPhoneNumber);
            this.Controls.Add(this.metroSetLabel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(1000, 428);
            this.MinimumSize = new System.Drawing.Size(1000, 428);
            this.Name = "MainForm";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "Phone Book";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgPhoneBook)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroSet_UI.Controls.MetroSetLabel metroSetLabel1;
        private MetroSet_UI.Controls.MetroSetTextBox txbPhoneNumber;
        private MetroSet_UI.Controls.MetroSetTextBox txbFirstName;
        private MetroSet_UI.Controls.MetroSetLabel metroSetLabel2;
        private MetroSet_UI.Controls.MetroSetTextBox txbLastName;
        private MetroSet_UI.Controls.MetroSetLabel metroSetLabel3;
        private MetroSet_UI.Controls.MetroSetTextBox txbAddress;
        private MetroSet_UI.Controls.MetroSetLabel metroSetLabel4;
        private MetroSet_UI.Controls.MetroSetButton btnSearch;
        private MetroSet_UI.Controls.MetroSetControlBox metroSetControlBox1;
        private MetroSet_UI.Controls.MetroSetButton btnNew;
        private MetroSet_UI.Controls.MetroSetButton btnEdit;
        private MetroSet_UI.Controls.MetroSetTile metroSetTile1;
        private MetroSet_UI.Controls.MetroSetLabel lbInfo;
        private System.Windows.Forms.DataGridView dgPhoneBook;
        private System.Windows.Forms.Button btnSearchHidden;
        private MetroSet_UI.Controls.MetroSetButton btnReset;
        private MetroSet_UI.Controls.MetroSetButton btnExportToExcel;
    }
}

