using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Zubair_Project2
{
    class BookClass
    {// the purpose of the book class is that it adds all the books to the list creates the book object
        //modifys the book and finally display the book record. 
        public List<BookClass> BookList = new List<BookClass>();

        private string hiddenISBN = "";
        private string hiddenTitle = "";
        private string hiddenAuthor = "";
        private string hiddenPrice = "";
        private string hiddenQuantity = "";
        private string hiddenDateLastTransaction; //DateTime.Now.ToString("MM/dd/yyyy");

        public void setHiddenISBN(string isbn)
        {
            this.hiddenISBN = isbn;
        }
        public void setHiddenTitle(string title)
        {
            this.hiddenTitle = title;
        }
        public void setHiddenAuthor(string author)
        {
            this.hiddenAuthor = author;
        }
        public void setHiddenPrice(string price)
        {
            this.hiddenPrice = price;
        }
        public void setHiddennumberOnHand(string numberOnHand)
        {
            this.hiddenQuantity = numberOnHand;
        }
        public void setHiddendateLastTransaction(string dateLastTransaction)
        {
            this.hiddenDateLastTransaction = dateLastTransaction;
        }
        public string getHiddenISBN()
        {
            return this.hiddenISBN;
        }
        public string getHiddenTitle()
        {
            return this.hiddenTitle;
        }
        public string getHiddenAuthor()
        {
            return this.hiddenAuthor;
        }
        public string getHiddenPrice()
        {
            return this.hiddenPrice;
        }
        public string getHiddenQuantity()
        {
            return this.hiddenQuantity;
        }
        public string getHiddendateLastTransaction()
        {
            return this.hiddenDateLastTransaction;
        }

        public Boolean createBookObject(string s) // IN: string from the Book Text File
        {
            BookClass thisBook = this;
            string[] bookString = s.Split('*');

            bookString[0] = bookString[0].Trim();

            // Convert ISBN
            hiddenISBN = bookString[0];
            if (hiddenISBN == "" || hiddenISBN == " ")
            {
                MessageBox.Show(hiddenISBN +
                    ": ISBN cannot be blank. Book File Corrupt. Execution Terminated.",
                    "ISBN in Book File Invalid", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return false;
            }

            // title string to string (no conversion)
            // Checks for blank title

            hiddenTitle = bookString[1].Trim();
            if (hiddenTitle == " " || hiddenTitle == "")
            {
                MessageBox.Show(hiddenTitle +
                    ": Title string is empty or Blank. Book File Corrupt. Execution Terminated.",
                    "Title in Book File Invalid", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return false;
            }

            hiddenAuthor = bookString[2].Trim();
            // Convert author to string
            // Checks for blank author
            if (hiddenAuthor == " " || hiddenAuthor == "")
            {
                MessageBox.Show(hiddenAuthor +
                    ": Author cannot be blank. Book File Corrupt. Execution Terminated.",
                    "Author in Book File Invalid", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return false;
            }

            // Convert price to hiddenPrice
            hiddenPrice = bookString[3].Trim();
            if (hiddenPrice == " " || hiddenPrice == "")
            {
                MessageBox.Show(hiddenPrice +
                    ": Price cannot be blank. Book File Corrupt. Execution Terminated.",
                    "Price in Book File Invalid", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return false;
            }

            // Convert quantity to hiddenQuantity
            hiddenQuantity = bookString[4].Trim();
            if (hiddenQuantity == " " || hiddenQuantity == "")
            {
                MessageBox.Show(hiddenQuantity +
                    ": Quantity cannot be blank. Book File Corrupt. Execution Terminated.",
                    "Quantity in Book File Invalid", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return false;
            }
            // Convert Last Date of Access to a Date
            hiddenDateLastTransaction = bookString[5].Trim();
            if (hiddenDateLastTransaction == " " || hiddenDateLastTransaction == "")
            {
                MessageBox.Show(hiddenDateLastTransaction +
                    ": Date of Last Transaction cannot be blank. Book File Corrupt. Execution Terminated.",
                    "Date in Book File Invalid", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return false;
            }
            //if all data is valid
            return (true);
        }

        public void displayBookRecord()
        {
            MessageBox.Show("Book Record\n" + "\nISBN = " + Globals.BookStore.Book.getHiddenISBN() + "\nTitle = " + Globals.BookStore.Book.getHiddenTitle() +
                "\nAuthor = " + Globals.BookStore.Book.getHiddenAuthor() + string.Format("\nPrice = {0:C}", Globals.BookStore.Book.getHiddenPrice()) +
                "\nNummber On Hand = " + Globals.BookStore.Book.getHiddenQuantity() + "\nDate Last Transaction = " + Globals.BookStore.Book.getHiddendateLastTransaction(), "Book Record Updated");

        }

        public Boolean modifyBookRecord()
        {

            BookStoreClass.updatedBookFile.putNextRecord("\n" + Globals.BookStore.Book.getHiddenISBN() + " * " + Globals.BookStore.Book.getHiddenTitle() + " * " + Globals.BookStore.Book.getHiddenAuthor() + " * " + Globals.BookStore.Book.getHiddenPrice() + " * " + Globals.BookStore.Book.getHiddenQuantity() + " * " + DateTime.Now);

            BookStoreClass.updatedBookFile.closeFile();
            return true;
        }

    }
}

