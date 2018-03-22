using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zubair_Project2
{
    class BookStoreClass
    { /*the purpose of the bookstore class that it finds the path in the bookstore and it matches the book
        if the book is currently in the current file class. if its not then it updates. 
         
         */
        // Books and the EmployeeList and all the text files belong to the Bookstore
        public BookClass Book = new BookClass();
        public EmployeeListClass EmployeeList = new EmployeeListClass();

        // The Files the Bookstore Owns
        private static string currentBookFilePath = "currentBookFile.txt";
        private static string updatedBookFilePath = "updatedBookFile.txt";
        private static string currentEmployeeFilePath = "currentEmployeeFile.txt";
        private static string updatedEmployeeFilePath = "updatedEmployeeFile.txt";

        public string getCurrentBookFilePath()
        {
            return currentBookFilePath;
        }
        public string getOutputPath()
        {
            return currentBookFilePath.Replace("currentBookFile", "output");
        }

        public static currentFileClass currentBookFile = new
            currentFileClass(currentBookFilePath);

        public static updatedFileClass updatedBookFile = new
          updatedFileClass(updatedBookFilePath);

        public static currentFileClass currentEmployeeFile = new
        currentFileClass(currentEmployeeFilePath);
        public static updatedFileClass updatedEmployeeFile = new
            updatedFileClass(updatedEmployeeFilePath);


        // Bookstore parameters (Named constants defined by the Bookstore)
        private int hiddenAccessIDLength = 5;   // Length of AccessNet ID
        private int hiddenISBNLeftLength = 3;   // Length of left part of ISBN
        private int hiddenISBNRightLength = 3;  // Length of right part of ISBN
        // Number of attempts BookStore allows a user before terminating an inventory 
        //    update session
        private int hiddenTryCountMax = 3;

        public Boolean bookMatch(string txtISBN)
        {
            Boolean endOfFileFlag = false;
            String bookDetails = "";
            BookStoreClass.currentBookFile.rewindFile();
            bookDetails = BookStoreClass.currentBookFile.getNextRecord(ref endOfFileFlag);
            while (!endOfFileFlag)
            {
                String[] bookSplit = bookDetails.Split('*');
                if (bookSplit[0].Contains(txtISBN))
                {
                    Book.setHiddenAuthor(bookSplit[2]);
                    Book.setHiddendateLastTransaction(bookSplit[5].Trim());
                    Book.setHiddenISBN(bookSplit[0]);
                    Book.setHiddennumberOnHand(bookSplit[4].Trim());
                    char[] charsToTrim = { '*', ' ', '$' };
                    String price = bookSplit[3].Trim(charsToTrim);
                   Book.setHiddenPrice(price);
                   Book.setHiddenTitle(bookSplit[1]);
                    return true;
                }
                bookDetails = BookStoreClass.currentBookFile.getNextRecord(ref endOfFileFlag);
            }
            return false;
        }


        public int getHiddenTryCountMax()
        {
            return this.hiddenTryCountMax;
        }







        // Displays the list of employees (After they were written to the Employee File)
        public void writeEntireEmployeeList()
        {
            // EmployeeList.displayEntireList();
        }   // end writeEntireEmploeeList

    }
}

