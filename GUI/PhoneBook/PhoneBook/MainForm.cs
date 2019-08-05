using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MetroSet_UI.Forms;
using Excel = Microsoft.Office.Interop.Excel;
using System.IO;

namespace PhoneBook
{
    public partial class MainForm : MetroSetForm
    {
        public MainForm()
        {
            InitializeComponent();
            this.AcceptButton = btnSearchHidden; // Mới bổ sung
            btnSearchHidden.Click += btnSearch_Click; // Mới bổ sung
            btnSearchHidden.MouseClick += btnSearch_Click; // Mới bổ sung
        }

        public void refreshDataGridView(List<PhoneAddress> listPhoneAddress)
        {
            dgPhoneBook.Columns.Clear();
            dgPhoneBook.DataSource = null;
            dgPhoneBook.DataSource = listPhoneAddress;

            DataGridViewButtonColumn deleteCol = new DataGridViewButtonColumn();
            deleteCol.HeaderText = "Action";
            deleteCol.Name = "deleteCol";
            deleteCol.Text = "Delete";
            deleteCol.UseColumnTextForButtonValue = true;
            deleteCol.FlatStyle = FlatStyle.Flat;
            deleteCol.DefaultCellStyle = new DataGridViewCellStyle() { BackColor = Color.DarkRed, ForeColor = Color.White, Alignment = DataGridViewContentAlignment.MiddleCenter, SelectionBackColor = Color.DarkRed };

            dgPhoneBook.Columns.Add(deleteCol);

            dgPhoneBook.Columns[0].HeaderText = "Phone Number";
            dgPhoneBook.Columns[0].Width = 150;
            dgPhoneBook.Columns[1].HeaderText = "First Name";
            dgPhoneBook.Columns[2].HeaderText = "Last Name";
            dgPhoneBook.Columns[3].HeaderText = "Address";
            dgPhoneBook.Columns[3].Width = 310;

            dgPhoneBook.ScrollBars = ScrollBars.Vertical;
            dgPhoneBook.ClearSelection();
        }

        private void btnExportToExcel_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "Excel Documents (*.xls)|*.xls";

            if (sfd.ShowDialog() == DialogResult.OK)
            {
                // Copy DataGridView results to clipboard
                copyAlltoClipboard();

                object misValue = System.Reflection.Missing.Value;
                Excel.Application xlexcel = new Excel.Application();

                xlexcel.DisplayAlerts = false; // Without this you will get two confirm overwrite prompts
                Excel.Workbook xlWorkBook = xlexcel.Workbooks.Add(misValue);
                Excel.Worksheet xlWorkSheet = (Excel.Worksheet)xlWorkBook.Worksheets.get_Item(1);

                // Paste clipboard results to worksheet range
                Excel.Range CR = (Excel.Range)xlWorkSheet.Cells[1, 1];
                CR.Select();
                xlWorkSheet.PasteSpecial(CR, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, true);

                // For some reason column A is always blank in the worksheet.
                //// Delete blank column A and select cell A1
                Excel.Range delRng = xlWorkSheet.get_Range("A:A").Cells;
                delRng.Delete(Type.Missing);
                xlWorkSheet.get_Range("A1").Select();

                // Delete column "Action"
                Excel.Range delRng2 = xlWorkSheet.get_Range("E:E").Cells;
                delRng2.Delete(Type.Missing);

                // Format header column to BOLD
                Excel.Range formatRange;
                formatRange = xlWorkSheet.get_Range("A1");
                formatRange.EntireRow.Font.Bold = true;
                // Dong 1, cot 5
                //xlWorkSheet.Cells[1, 5] = "Bold";

                // Auto fit each cell
                ((Excel.Range)xlWorkSheet.Columns[1]).AutoFit();
                ((Excel.Range)xlWorkSheet.Columns[2]).AutoFit();
                ((Excel.Range)xlWorkSheet.Columns[3]).AutoFit();
                ((Excel.Range)xlWorkSheet.Columns[4]).AutoFit();

                // Save the excel file under the captured location from the SaveFileDialog
                xlWorkBook.SaveAs(sfd.FileName, Excel.XlFileFormat.xlWorkbookNormal, misValue, misValue, misValue, misValue, Excel.XlSaveAsAccessMode.xlExclusive, misValue, misValue, misValue, misValue, misValue);
                xlexcel.DisplayAlerts = true;
                xlWorkBook.Close(true, misValue, misValue);
                xlexcel.Quit();

                // Clear Clipboard and DataGridView selection
                Clipboard.Clear();
                dgPhoneBook.ClearSelection();

                // Open the newly saved excel file
                if (File.Exists(sfd.FileName))
                    System.Diagnostics.Process.Start(sfd.FileName);
            }
        }

        private void copyAlltoClipboard()
        {
            dgPhoneBook.MultiSelect = true;
            dgPhoneBook.SelectAll();
            dgPhoneBook.ClipboardCopyMode = DataGridViewClipboardCopyMode.EnableAlwaysIncludeHeaderText;
            DataObject dataObj = dgPhoneBook.GetClipboardContent();
            if (dataObj != null)
                Clipboard.SetDataObject(dataObj);
            dgPhoneBook.MultiSelect = false;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            refreshDataGridView(PhoneAddress.GetAllPhoneAddress());
        }

        private void dgPhoneBook_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                if (dgPhoneBook.Columns[e.ColumnIndex].Name == "deleteCol")
                {
                    string phoneNumber = dgPhoneBook.Rows[e.RowIndex].Cells[0].Value.ToString();
                    DialogResult result = MessageBox.Show("Do you want to delete?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (result == DialogResult.Yes)
                    {
                        PhoneAddress.DeletePhoneAddress(phoneNumber);
                        refreshDataGridView(PhoneAddress.SearchPhoneAddress(txbPhoneNumber.Text, txbFirstName.Text, txbLastName.Text, txbAddress.Text));
                        MessageBox.Show("Delete " + phoneNumber + " successfully!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        selectedRowIndex = -1;
                    }

                    return;
                }
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string phoneNumber = txbPhoneNumber.Text;
            string firstName = txbFirstName.Text;
            string lastName = txbLastName.Text;
            string address = txbAddress.Text;
            selectedRowIndex = -1;

            refreshDataGridView(PhoneAddress.SearchPhoneAddress(phoneNumber, firstName, lastName, address));
            //lbInfo.Text = "Your search is successful. Here is the result";
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (selectedRowIndex != -1)
            {
                DataGridViewRow selectedRow = dgPhoneBook.Rows[selectedRowIndex];
                string phoneNumber = selectedRow.Cells["PhoneNumber"].Value.ToString();
                string firstName = selectedRow.Cells["FirstName"].Value.ToString();
                string lastName = selectedRow.Cells["LastName"].Value.ToString();
                string address = selectedRow.Cells["Address"].Value.ToString();
                selectedRowIndex = -1;

                List<string> searchDetails = new List<string>();
                searchDetails.Add(txbPhoneNumber.Text);
                searchDetails.Add(txbFirstName.Text);
                searchDetails.Add(txbLastName.Text);
                searchDetails.Add(txbAddress.Text);
                new EditPhoneForm(this, searchDetails, phoneNumber, firstName, lastName, address).ShowDialog(); //moi sua
                dgPhoneBook.ClearSelection();

            }
            else
            {
                MessageBox.Show("Please select a cell or a full row!", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }

        int selectedRowIndex = -1;
        private void dgPhoneBook_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            selectedRowIndex = e.RowIndex;
        }

        private void BtnNew_Click(object sender, EventArgs e)
        {
            List<string> searchDetails = new List<string>();
            searchDetails.Add(txbPhoneNumber.Text);
            searchDetails.Add(txbFirstName.Text);
            searchDetails.Add(txbLastName.Text);
            searchDetails.Add(txbAddress.Text);
            new NewPhoneForm(this, searchDetails).ShowDialog();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txbPhoneNumber.Text = "";
            txbLastName.Text = "";
            txbFirstName.Text = "";
            txbAddress.Text = "";
            selectedRowIndex = -1;

            refreshDataGridView(PhoneAddress.GetAllPhoneAddress());
        }

        private void lbInfo_Click(object sender, EventArgs e)
        {

        }
    }
}
