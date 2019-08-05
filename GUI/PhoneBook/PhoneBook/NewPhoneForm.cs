using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MetroSet_UI.Forms;

namespace PhoneBook
{
    public partial class NewPhoneForm : MetroSetForm
    {
        MainForm ParentMainForm { get; set; }
        List<string> SearchDetails { get; set; }
        public NewPhoneForm(MainForm parent, List<string> search)
        {
            InitializeComponent();
            ParentMainForm = parent;
            SearchDetails = search;
        }

        private void NewPhoneForm_Load(object sender, EventArgs e)
        {
        }

        private void BtnNew_Click(object sender, EventArgs e)
        {
            try
            {
                string phoneNumber = txbPhoneNumber.Text;
                string firstName = txbFirstName.Text;
                string lastName = txbLastName.Text;
                string address = txbAddress.Text;
                if (PhoneAddress.checkPhoneNumber(phoneNumber) == false)
                {
                    MessageBox.Show("Wrong format at PhoneNumber field", "Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (PhoneAddress.checkName(firstName) == false || PhoneAddress.checkName(lastName) == false)
                {
                    MessageBox.Show("Your name must contain alphabet characters only", "Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    string formedPhoneNumber = phoneNumber.Replace(" ", ""); //moi sua
                    if (DataAccess.Insert(formedPhoneNumber, firstName, lastName, address) == 1)
                    {
                        DialogResult dr = MessageBox.Show("Success", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information); //can them event dong form khi click OK
                        if (dr == DialogResult.OK)
                        {
                            ParentMainForm.refreshDataGridView(PhoneAddress.SearchPhoneAddress(SearchDetails[0], SearchDetails[1], SearchDetails[2], SearchDetails[3]));
                            this.Close();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("This number are already existed", "Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

    }
}
