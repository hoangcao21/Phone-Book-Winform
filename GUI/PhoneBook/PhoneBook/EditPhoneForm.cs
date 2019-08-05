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
    public partial class EditPhoneForm : MetroSetForm
    {
        string a;
        MainForm ParentMainForm { get; set; }
        List<string> SearchDetails { get; set; }
        public EditPhoneForm(MainForm parent, List<string> search, string phoneNumber, string firstName, string lastName, string address)
        {
            InitializeComponent();
            ParentMainForm = parent;
            txbPhoneNumber.Text = phoneNumber;
            a = phoneNumber.Replace(" ", ""); //moi sua;
            txbFirstName.Text = firstName;
            txbLastName.Text = lastName;
            txbAddress.Text = address;
            SearchDetails = search;
        }

        private void EditPhoneForm_Load(object sender, EventArgs e)
        {

        }

        private void BtnEdit_Click(object sender, EventArgs e)
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
                    MessageBox.Show("Your name must contain alphabet only", "Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    bool success = false;
                    string formedPhoneNumber = phoneNumber.Replace(" ", ""); //moi sua  
                    if (formedPhoneNumber.Equals(a))
                    {
                        DataAccess.Delete(a);
                        if (DataAccess.Insert(formedPhoneNumber, firstName, lastName, address) == 1)
                        {
                            success = true;
                        }
                    }
                    else
                    {
                        if (DataAccess.Insert(formedPhoneNumber, firstName, lastName, address) == 1)
                        {
                            DataAccess.Delete(a);
                            success = true;
                        }
                    }

                    if (success)
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
