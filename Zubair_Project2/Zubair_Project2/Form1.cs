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
    
    //checks for access ID. its the first form
    public partial class frmEnterAccessID : Form
    {
        private int tryCount = 1;
        public frmEnterAccessID()
        {
            InitializeComponent();
        }

        private void frmEnterAccessID_Load(object sender, EventArgs e)
        {
            Globals.BookStore.EmployeeList.initializeEntireList();
        }

        private void btnFindMe_Click(object sender, EventArgs e)
        {
            tryCount += 1;
            string employeeAccessIDString = txtAccessID.Text;
            int employeeAccessID;



            if (employeeAccessIDString.Length != Globals.objEmp.getHiddenAccessIdLength())
            {
                MessageBox.Show("AccessID must be a 5 digit integer. Please Re-enter", "Invalid AccessID", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                if (tryCount > Globals.BookStore.getHiddenTryCountMax())
                {
                    MessageBox.Show("Incorrect Employee Access ID entered for the third time. Please see bookstore manager.", "Third Time Invalid Entry.", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    this.Close();
                    return;
                }
                txtAccessID.Clear();
                txtAccessID.Focus();
                return;
            }

            try
            {
                employeeAccessID = Convert.ToInt32(employeeAccessIDString);
            }
            catch (Exception ex)
            {

                MessageBox.Show("Account must be a 5 digit integer. Please Re-enter", "Account is invalid", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                if (tryCount > Globals.BookStore.getHiddenTryCountMax())
                {
                    MessageBox.Show("Incorrect Employee Access ID entered for the third time. Please see bookstore manager.", "Third Time Invalid Entry.", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    this.Close();
                    return;
                }
                txtAccessID.Clear();
                txtAccessID.Focus();
                return;
            }

            Boolean accessIDMatchFound = false;


            accessIDMatchFound = Globals.objEmp.checkEmployeeID(employeeAccessID);
            if (!accessIDMatchFound)
            {
                MessageBox.Show("Employee Access ID can't be found. Please Re-enter", "Employee AccessID is not found", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                if (tryCount > Globals.BookStore.getHiddenTryCountMax())
                {
                    MessageBox.Show("Incorrect Employee Access ID entered for the third time. Please see bookstore manager.", "Third Time Invalid Entry.", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    this.Close();
                    return;
                }
                txtAccessID.Clear();
                txtAccessID.Focus();
                //Globals.BookStore.rewindFiles();
                return;
            }

            if (accessIDMatchFound)
            {
                MessageBox.Show("Employee Access ID found.", "Employee AccessID is found", MessageBoxButtons.OK);
                //txtAccessID.Clear();
                txtAccessID.Focus();
                Form PinIDEntryform = new frmEmployeePinEntry();
                PinIDEntryform.ShowDialog();
                this.Visible = false;
                this.Close();

                //Globals.BookStore.rewindFiles();
                return;
            }
        }
    }
}
