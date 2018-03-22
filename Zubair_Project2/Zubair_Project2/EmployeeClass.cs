using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Zubair_Project2
{
    class EmployeeClass
    {// employee class is helpful in form one and form two. it checks for the employee that works
        //if the employee doesnt exist it exist the program. 
        
        


        private int hiddenAccessID = 5;
        private string hiddenName = "";
        private int hiddenPin = 4;
        private decimal hiddenAnnualPay = 0m;
        private DateTime hiddenLastDateAccess; //DateTime.Now.ToString("MM/dd/yyyy");

        public int getHiddenAccessIdLength()
        {
            return this.hiddenAccessID;
        }
        public string getHiddenNameLength()
        {
            return this.hiddenName;
        }
        public int getHiddenAccessPinLength()
        {
            return this.hiddenPin;
        }
        public decimal getHiddenAnnualPayLength()
        {
            return this.hiddenAnnualPay;
        }
        public DateTime gethiddenLastDateAccessLength()
        {
            return this.hiddenLastDateAccess;
        }

        public Boolean checkEmployeeID(int txtAccessId)
        {
            foreach (var emp in Globals.BookStore.EmployeeList.InternalList)
            {
                if (emp.hiddenAccessID == txtAccessId)
                {
                    this.hiddenAccessID = emp.hiddenAccessID;
                    this.hiddenName = emp.hiddenName;
                    this.hiddenPin = emp.hiddenPin;
                    this.hiddenAnnualPay = emp.hiddenAnnualPay;
                    this.hiddenLastDateAccess = emp.hiddenLastDateAccess;
                    return true;
                }
            }
            return false;
        }

        public Boolean createEmployeeObject
         (string s)  // IN: string from the Employee Text File
        {

            EmployeeClass thisEmployee = this;
            string[] employeeString = s.Split('*');
            int i;

            int employeeStringSize = employeeString.GetLength(0);

            // Convert AccessID to an integer of required length
            if (employeeString[0].Trim(' ').Length != hiddenAccessID)
            {
                MessageBox.Show(employeeString[0]
                    + ": AccessID string is not exactly 5 characters. Employee File Corrupt. Execution Terminated.",
                      "AccessID in Employee File Invalid",
                      MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return false;
            }

            try
            {
                hiddenAccessID = Convert.ToInt32(employeeString[0]);
            }
            catch
            {
                MessageBox.Show(employeeString[0]
                    + " AccessID string is not a valid integer. Employee File Corrupt. Execution Terminated.",
                      "AccessID in Employee File Invalid",
                       MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return false;
            }

            // Name string to string (no conversion)
            hiddenName = employeeString[1];
            if (hiddenName == " " || hiddenName == "")
            {
                MessageBox.Show(hiddenName
                    + ": Name string is empty or Blank. Employee File Corrupt. Execution Terminated.",
                      "Name in Employee File Invalid",
                      MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return false;
            }

            // Convert Pin to an integer of required length
            if (employeeString[2].Trim(' ').Length != hiddenPin)
            {
                MessageBox.Show(employeeString[2]
                    + ": Pin string is not exactly 4 characters. Employee File Corrupt. Execution Terminated.",
                      "Pin in Employee File Invalid", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return false;
            }

            try
            {
                hiddenPin = Convert.ToInt32(employeeString[2]);
            }
            catch
            {
                MessageBox.Show(employeeString[2]
                    + ": Pin string is empty or Blank. Employee File Corrupt.  Execution Terminated.",
                      "Pin in Employee File Invalid", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return false;
            }

            // Convert annualPay to a positive decimal
            try
            {
                hiddenAnnualPay = Convert.ToDecimal(employeeString[3].Replace(",",
                    "").Replace("$", ""));
            }
            catch
            {
                MessageBox.Show(employeeString[3]
                    + ": Annual Pay string is not a valid decimal. Employee File Corrupt. Execution Terminated.",
                      "Annual pay in Employee File Invalid",
                      MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return false;
            }

            // Convert last Date of Access to a date
            try
            {
                hiddenLastDateAccess = DateTime.Parse(employeeString[4]);
            }
            catch
            {
                MessageBox.Show(employeeString[4]
                    + ": Date of Last Access string is not a valid date. Employee File Corrupt.  Execution Terminated.",
                      "Date of last access in Employee File Invalid",
                      MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return false;
            }

            // All data valid
            return (true);
        }  // end createEmployeeObject

        public void createStringToDisplay()
        {
            MessageBox.Show("Employee Record\n" + "\nAccessID = " + Globals.objEmp.hiddenAccessID + "\nName = " + Globals.objEmp.hiddenName +
                "\nPin = " + Globals.objEmp.hiddenPin + string.Format("\nAnnualPay = {0:C}", Globals.objEmp.hiddenAnnualPay) +
                "\nLastDateAccess = " + Globals.objEmp.hiddenLastDateAccess, "Employee Record Found");
        }

        public void updateEmployeeTransactionDate()
        {
            this.hiddenLastDateAccess = DateTime.Now;
        }

        public Boolean verifyPin(int txtPin)
        {
            if (Globals.objEmp.hiddenPin == txtPin)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

    }
}

