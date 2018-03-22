using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Zubair_Project2
{
    class EmployeeListClass
    {//employee list class lists all the employees and checks to see if the employee works (used in form 1 and 2)
        public List<EmployeeClass> InternalList = new List<EmployeeClass>();

        public int getCount()
        {
            return InternalList.Count;
        }
        public Boolean initializeEntireList()
        {
            string nextRecord;
            Boolean isEndOfFile = true;
            Boolean success;
            int countProcessedRecords = 0;


            nextRecord = BookStoreClass.currentEmployeeFile.getNextRecord(ref isEndOfFile);
            while (!isEndOfFile)
            {
                countProcessedRecords++;
                EmployeeClass emp = new EmployeeClass();
                success = emp.createEmployeeObject(nextRecord);
                if (success != true)
                {
                    MessageBox.Show
                       ("Unable to create an Employee Object.  Employee list not created.",
                        "Employee List Creation Failed", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    return false;
                }
                InternalList.Add(emp);
                nextRecord = BookStoreClass.currentEmployeeFile.getNextRecord(ref isEndOfFile);
            } //end While

            if (countProcessedRecords > 0)
                return true;
            else
                return false;
        }  // end initializeEntireList

        public void updateEmployeeObject()
        {
            Globals.objEmp.updateEmployeeTransactionDate();
        }

        public Boolean verifyPin(int txtPin)
        {
            return (Globals.objEmp.verifyPin(txtPin));
        }

        public void writeEntireList()
        {
            foreach (var emp in Globals.BookStore.EmployeeList.InternalList)
            {
                if (Globals.objEmp.getHiddenAccessIdLength() == emp.getHiddenAccessIdLength())
                    BookStoreClass.updatedEmployeeFile.putNextRecord("\n" + Globals.objEmp.getHiddenAccessIdLength() + " * " + Globals.objEmp.getHiddenNameLength() + " * " + Globals.objEmp.getHiddenAccessPinLength() + " * " + Globals.objEmp.getHiddenAnnualPayLength() + " * " + Globals.objEmp.gethiddenLastDateAccessLength());
                else
                    BookStoreClass.updatedEmployeeFile.putNextRecord("\n" + emp.getHiddenAccessIdLength() + " * " + emp.getHiddenNameLength() + " * " + emp.getHiddenAccessPinLength() + " * " + emp.getHiddenAnnualPayLength() + " * " + emp.gethiddenLastDateAccessLength());

            }
            BookStoreClass.updatedEmployeeFile.closeFile();
        }
    }
}

