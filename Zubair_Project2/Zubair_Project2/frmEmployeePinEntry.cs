using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Zubair_Project2
{//Nabeel Zubair
    //3309 project 2

        //purpose of this form is to ask employee to add their pin number once theyre verified. 
        //if the pin doesnt match 3 times, the program exits. 
    public partial class frmEmployeePinEntry : Form
    {
        private int tryPinCount = 1;
        public frmEmployeePinEntry()
        {
            InitializeComponent();
        }

        private void frmEmployeePinEntry_Load(object sender, EventArgs e)
        {

        }

        private void btnOkay_Click(object sender, EventArgs e)
        {
            tryPinCount += 1;
            string employeeAccessPinString = txtPin.Text;
            int employeeAccessPin;

            if (employeeAccessPinString.Length != Globals.objEmp.getHiddenAccessPinLength().ToString().Length)
            {
                MessageBox.Show("AccessPin must be a 4 digit integer. Please Re-enter", "Invalid AccessPin", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                if (tryPinCount > Globals.BookStore.getHiddenTryCountMax())
                {
                    MessageBox.Show("Incorrect Employee Access Pin entered for the third time. Please see bookstore manager.", "Third Time Invalid Entry.", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    this.Close();
                    return;
                }
                txtPin.Clear();
                txtPin.Focus();
                return;
            }

            try
            {
                employeeAccessPin = Convert.ToInt32(employeeAccessPinString);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Pin must be a 4 digit integer. Please Re-enter", "Pin is invalid", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                if (tryPinCount > Globals.BookStore.getHiddenTryCountMax())
                {
                    MessageBox.Show("Incorrect Employee Access Pin entered for the third time. Please see bookstore manager.", "Third Time Invalid Entry.", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    this.Close();
                    return;
                }
                txtPin.Clear();
                txtPin.Focus();
                return;
            }

            Boolean accessPinMatchFound = false;


            accessPinMatchFound = Globals.BookStore.EmployeeList.verifyPin(employeeAccessPin);
            if (!accessPinMatchFound)
            {
                MessageBox.Show("Pin invalid. Please Re-enter", "Incorrect pin", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                if (tryPinCount > Globals.BookStore.getHiddenTryCountMax())
                {
                    MessageBox.Show("Incorrect Employee Access Pin entered for the third time. Please see bookstore manager.", "Third Time Invalid Entry.", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    this.Close();
                    return;
                }
                txtPin.Clear();
                txtPin.Focus();
                //Globals.BookStore.rewindFiles();
                return;
            }

            if (accessPinMatchFound)
            {
                MessageBox.Show("Pin verified.", "Access granted", MessageBoxButtons.OK);
                //txtAccessID.Clear();
                txtPin.Focus();
                Globals.objEmp.updateEmployeeTransactionDate();
                Globals.objEmp.createStringToDisplay();
                Globals.BookStore.EmployeeList.writeEntireList();
                Form IsbnEntryform = new frmTransactionSelect();
                IsbnEntryform.ShowDialog();
                this.Visible = false;
                this.Close();

                //Globals.BookStore.rewindFiles();
                return;
            }


        }
    }
    }

