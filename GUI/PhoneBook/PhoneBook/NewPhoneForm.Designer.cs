namespace PhoneBook
{
    partial class NewPhoneForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NewPhoneForm));
            this.btnNew = new MetroSet_UI.Controls.MetroSetButton();
            this.txbAddress = new MetroSet_UI.Controls.MetroSetTextBox();
            this.metroSetLabel4 = new MetroSet_UI.Controls.MetroSetLabel();
            this.txbLastName = new MetroSet_UI.Controls.MetroSetTextBox();
            this.metroSetLabel3 = new MetroSet_UI.Controls.MetroSetLabel();
            this.txbFirstName = new MetroSet_UI.Controls.MetroSetTextBox();
            this.metroSetLabel2 = new MetroSet_UI.Controls.MetroSetLabel();
            this.txbPhoneNumber = new MetroSet_UI.Controls.MetroSetTextBox();
            this.metroSetLabel1 = new MetroSet_UI.Controls.MetroSetLabel();
            this.metroSetControlBox1 = new MetroSet_UI.Controls.MetroSetControlBox();
            this.metroSetTile1 = new MetroSet_UI.Controls.MetroSetTile();
            this.SuspendLayout();
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
            this.btnNew.Location = new System.Drawing.Point(14, 248);
            this.btnNew.Name = "btnNew";
            this.btnNew.NormalBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.btnNew.NormalColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.btnNew.NormalTextColor = System.Drawing.Color.White;
            this.btnNew.PressBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(147)))), ((int)(((byte)(195)))));
            this.btnNew.PressColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(147)))), ((int)(((byte)(195)))));
            this.btnNew.PressTextColor = System.Drawing.Color.White;
            this.btnNew.Size = new System.Drawing.Size(508, 23);
            this.btnNew.Style = MetroSet_UI.Design.Style.Light;
            this.btnNew.StyleManager = null;
            this.btnNew.TabIndex = 17;
            this.btnNew.Text = "New";
            this.btnNew.ThemeAuthor = "Narwin";
            this.btnNew.ThemeName = "MetroLite";
            this.btnNew.Click += new System.EventHandler(this.BtnNew_Click);
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
            this.txbAddress.Location = new System.Drawing.Point(286, 186);
            this.txbAddress.MaxLength = 100;
            this.txbAddress.Multiline = false;
            this.txbAddress.Name = "txbAddress";
            this.txbAddress.ReadOnly = false;
            this.txbAddress.Size = new System.Drawing.Size(235, 30);
            this.txbAddress.Style = MetroSet_UI.Design.Style.Light;
            this.txbAddress.StyleManager = null;
            this.txbAddress.TabIndex = 16;
            this.txbAddress.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txbAddress.ThemeAuthor = "Narwin";
            this.txbAddress.ThemeName = "MetroLite";
            this.txbAddress.UseSystemPasswordChar = false;
            this.txbAddress.WatermarkText = "";
            // 
            // metroSetLabel4
            // 
            this.metroSetLabel4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.metroSetLabel4.Location = new System.Drawing.Point(286, 159);
            this.metroSetLabel4.Name = "metroSetLabel4";
            this.metroSetLabel4.Size = new System.Drawing.Size(100, 23);
            this.metroSetLabel4.Style = MetroSet_UI.Design.Style.Light;
            this.metroSetLabel4.StyleManager = null;
            this.metroSetLabel4.TabIndex = 15;
            this.metroSetLabel4.Text = "Address";
            this.metroSetLabel4.ThemeAuthor = "Narwin";
            this.metroSetLabel4.ThemeName = "MetroLite";
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
            this.txbLastName.Location = new System.Drawing.Point(286, 110);
            this.txbLastName.MaxLength = 20;
            this.txbLastName.Multiline = false;
            this.txbLastName.Name = "txbLastName";
            this.txbLastName.ReadOnly = false;
            this.txbLastName.Size = new System.Drawing.Size(235, 30);
            this.txbLastName.Style = MetroSet_UI.Design.Style.Light;
            this.txbLastName.StyleManager = null;
            this.txbLastName.TabIndex = 14;
            this.txbLastName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txbLastName.ThemeAuthor = "Narwin";
            this.txbLastName.ThemeName = "MetroLite";
            this.txbLastName.UseSystemPasswordChar = false;
            this.txbLastName.WatermarkText = "";
            // 
            // metroSetLabel3
            // 
            this.metroSetLabel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.metroSetLabel3.Location = new System.Drawing.Point(286, 84);
            this.metroSetLabel3.Name = "metroSetLabel3";
            this.metroSetLabel3.Size = new System.Drawing.Size(100, 23);
            this.metroSetLabel3.Style = MetroSet_UI.Design.Style.Light;
            this.metroSetLabel3.StyleManager = null;
            this.metroSetLabel3.TabIndex = 13;
            this.metroSetLabel3.Text = "Last Name";
            this.metroSetLabel3.ThemeAuthor = "Narwin";
            this.metroSetLabel3.ThemeName = "MetroLite";
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
            this.txbFirstName.Location = new System.Drawing.Point(15, 110);
            this.txbFirstName.MaxLength = 20;
            this.txbFirstName.Multiline = false;
            this.txbFirstName.Name = "txbFirstName";
            this.txbFirstName.ReadOnly = false;
            this.txbFirstName.Size = new System.Drawing.Size(235, 30);
            this.txbFirstName.Style = MetroSet_UI.Design.Style.Light;
            this.txbFirstName.StyleManager = null;
            this.txbFirstName.TabIndex = 12;
            this.txbFirstName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txbFirstName.ThemeAuthor = "Narwin";
            this.txbFirstName.ThemeName = "MetroLite";
            this.txbFirstName.UseSystemPasswordChar = false;
            this.txbFirstName.WatermarkText = "";
            // 
            // metroSetLabel2
            // 
            this.metroSetLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.metroSetLabel2.Location = new System.Drawing.Point(15, 83);
            this.metroSetLabel2.Name = "metroSetLabel2";
            this.metroSetLabel2.Size = new System.Drawing.Size(100, 23);
            this.metroSetLabel2.Style = MetroSet_UI.Design.Style.Light;
            this.metroSetLabel2.StyleManager = null;
            this.metroSetLabel2.TabIndex = 11;
            this.metroSetLabel2.Text = "First Name";
            this.metroSetLabel2.ThemeAuthor = "Narwin";
            this.metroSetLabel2.ThemeName = "MetroLite";
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
            this.txbPhoneNumber.Location = new System.Drawing.Point(15, 186);
            this.txbPhoneNumber.MaxLength = 20;
            this.txbPhoneNumber.Multiline = false;
            this.txbPhoneNumber.Name = "txbPhoneNumber";
            this.txbPhoneNumber.ReadOnly = false;
            this.txbPhoneNumber.Size = new System.Drawing.Size(235, 30);
            this.txbPhoneNumber.Style = MetroSet_UI.Design.Style.Light;
            this.txbPhoneNumber.StyleManager = null;
            this.txbPhoneNumber.TabIndex = 10;
            this.txbPhoneNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txbPhoneNumber.ThemeAuthor = "Narwin";
            this.txbPhoneNumber.ThemeName = "MetroLite";
            this.txbPhoneNumber.UseSystemPasswordChar = false;
            this.txbPhoneNumber.WatermarkText = "";
            // 
            // metroSetLabel1
            // 
            this.metroSetLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.metroSetLabel1.Location = new System.Drawing.Point(15, 159);
            this.metroSetLabel1.Name = "metroSetLabel1";
            this.metroSetLabel1.Size = new System.Drawing.Size(123, 23);
            this.metroSetLabel1.Style = MetroSet_UI.Design.Style.Light;
            this.metroSetLabel1.StyleManager = null;
            this.metroSetLabel1.TabIndex = 9;
            this.metroSetLabel1.Text = "Phone Number";
            this.metroSetLabel1.ThemeAuthor = "Narwin";
            this.metroSetLabel1.ThemeName = "MetroLite";
            // 
            // metroSetControlBox1
            // 
            this.metroSetControlBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.metroSetControlBox1.CloseHoverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.metroSetControlBox1.CloseHoverForeColor = System.Drawing.Color.White;
            this.metroSetControlBox1.CloseNormalForeColor = System.Drawing.Color.Gray;
            this.metroSetControlBox1.DisabledForeColor = System.Drawing.Color.DimGray;
            this.metroSetControlBox1.Location = new System.Drawing.Point(437, 0);
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
            this.metroSetControlBox1.TabIndex = 28;
            this.metroSetControlBox1.Text = "metroSetControlBox1";
            this.metroSetControlBox1.ThemeAuthor = "Narwin";
            this.metroSetControlBox1.ThemeName = "MetroLite";
            // 
            // metroSetTile1
            // 
            this.metroSetTile1.BackgroundImage = global::PhoneBook.Properties.Resources.New_icon;
            this.metroSetTile1.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.metroSetTile1.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            this.metroSetTile1.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            this.metroSetTile1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.metroSetTile1.HoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.metroSetTile1.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.metroSetTile1.HoverTextColor = System.Drawing.Color.White;
            this.metroSetTile1.Location = new System.Drawing.Point(159, 42);
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
            this.metroSetTile1.TabIndex = 29;
            this.metroSetTile1.ThemeAuthor = "Narwin";
            this.metroSetTile1.ThemeName = "MetroLite";
            this.metroSetTile1.TileAlign = MetroSet_UI.Enums.TileAlign.BottmLeft;
            // 
            // NewPhoneForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(536, 288);
            this.Controls.Add(this.metroSetTile1);
            this.Controls.Add(this.metroSetControlBox1);
            this.Controls.Add(this.btnNew);
            this.Controls.Add(this.txbAddress);
            this.Controls.Add(this.metroSetLabel4);
            this.Controls.Add(this.txbLastName);
            this.Controls.Add(this.metroSetLabel3);
            this.Controls.Add(this.txbFirstName);
            this.Controls.Add(this.metroSetLabel2);
            this.Controls.Add(this.txbPhoneNumber);
            this.Controls.Add(this.metroSetLabel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(536, 288);
            this.MinimumSize = new System.Drawing.Size(536, 288);
            this.Name = "NewPhoneForm";
            this.Text = "New Phone Detail";
            this.Load += new System.EventHandler(this.NewPhoneForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private MetroSet_UI.Controls.MetroSetButton btnNew;
        private MetroSet_UI.Controls.MetroSetTextBox txbAddress;
        private MetroSet_UI.Controls.MetroSetLabel metroSetLabel4;
        private MetroSet_UI.Controls.MetroSetTextBox txbLastName;
        private MetroSet_UI.Controls.MetroSetLabel metroSetLabel3;
        private MetroSet_UI.Controls.MetroSetTextBox txbFirstName;
        private MetroSet_UI.Controls.MetroSetLabel metroSetLabel2;
        private MetroSet_UI.Controls.MetroSetTextBox txbPhoneNumber;
        private MetroSet_UI.Controls.MetroSetLabel metroSetLabel1;
        private MetroSet_UI.Controls.MetroSetControlBox metroSetControlBox1;
        private MetroSet_UI.Controls.MetroSetTile metroSetTile1;
    }
}