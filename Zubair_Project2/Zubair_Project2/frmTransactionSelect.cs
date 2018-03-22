using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Zubair_Project2
{//Nabeel Zubair
    //3309 project 2

        //this is the third from where the employee can search isbn
        //they could add a new book
        //they could update an existing book from the file 
        //they could delete an existing book. 
    public partial class frmTransactionSelect : Form
    {
        public frmTransactionSelect()
        {
            InitializeComponent();
        }

        private void frmTransactionSelect_Load(object sender, EventArgs e)
        {

        }

        private void btnOkay_Click(object sender, EventArgs e)
        {
            Boolean matchFound = false;
            //lblSelectATransaction.Visible = true;
            btnAddBook.Visible = true;
            btnUpdateBook.Visible = true;
            btnDeleteBook.Visible = true;
            //pnlTransactionBook.Visible = true;
            //btnAdd.Visible = true;
            btnAddBook.Enabled = true;
            btnUpdateBook.Enabled = true;
            btnDeleteBook.Enabled = false;

            try
            {
                matchFound = Globals.BookStore.bookMatch(txtFirstThree.Text + lblhyphen.Text + txtLastThree.Text);
                if (matchFound)
                {
                    MessageBox.Show("Book already exists");

                    txtTitle.Text = Globals.BookStore.Book.getHiddenTitle();
                    txtAuthor.Text = Globals.BookStore.Book.getHiddenAuthor();
                    txtPrice.Text = Globals.BookStore.Book.getHiddenPrice().ToString();
                    txtOnHand.Text = Globals.BookStore.Book.getHiddenQuantity().ToString();
                    txtTransactionDate.Text = DateTime.Now.ToString();
                    txtISBN.Text = Globals.BookStore.Book.getHiddenISBN();
                }
                if (!matchFound)
                {
                    btnUpdateBook.Visible = false;
                    btnAddBook.Visible = true;
                    btnDeleteBook.Visible = false;
                }

                else
                {
                    String isbnTemp = txtFirstThree.Text + lblhyphen.Text + txtLastThree.Text;
                    txtISBN.Text = isbnTemp;
                }
               
            }
            catch
            {
                MessageBox.Show("please enter a valid number");
            }

        }
    
        private void btnAddBook_Click(object sender, EventArgs e)
        {
                        lblISBN.Visible = true;
                        txtFirstThree.Visible = true;
                        lblhyphen.Visible = true;
                        txtLastThree.Visible = true;
                        btnOkay.Visible = true;
                        pnlTransactionBook.Visible = true;
            txtTitle.Enabled = true;
            txtAuthor.Enabled = true;
            txtPrice.Enabled = true;
            txtOnHand.Enabled = true;
            txtTransactionDate.Enabled = true;
            btnUpdate.Visible = false;
            btnDelete.Visible = false;
         
                        txtISBN.Enabled = false;
                        btnAdd.Visible = true;
                        btnAddBook.Enabled = false;
                        btnUpdateBook.Enabled = false;
                        btnDeleteBook.Enabled = false;
                        btnDone.Enabled = true;
                        
                        bool matchFound = false;
           // String FileContent = File.ReadAllText("currentBookFile.txt");
            matchFound = Globals.BookStore.bookMatch(txtFirstThree.Text + lblhyphen.Text + txtLastThree.Text);
            if (matchFound)
            {
                MessageBox.Show("Book already exists", "Error");
                Globals.BookStore.Book.displayBookRecord();
                MessageBox.Show("Please enter book ISBN that is not in the currentFile and then click add book button.", "New Book Please.");
                txtFirstThree.Focus();
                txtFirstThree.Clear();
                txtLastThree.Clear();
                btnUpdateBook.Enabled = false;
                btnDeleteBook.Enabled = false;
                txtTransactionDate.Text = DateTime.Now.ToString();
                pnlTransactionBook.Visible = false;
               
            }
            else if (!matchFound)
            {
                
             

                String isbnTemp = txtFirstThree.Text + lblhyphen.Text + txtLastThree.Text;
                txtTransactionDate.Text = DateTime.Now.ToString();
                txtISBN.Text = isbnTemp;



                


            }
        }

        private void btnUpdateBook_Click(object sender, EventArgs e)
        {
            btnDelete.Visible = false;
            btnAdd.Visible = false;
            btnDeleteBook.Enabled = false;
            btnUpdateBook.Enabled = false;
            txtFirstThree.Enabled = false;
            txtLastThree.Enabled = false;
            btnOkay.Enabled = false;      
            pnlTransactionBook.Visible = true;
            txtISBN.Enabled = false;
            btnUpdate.Visible = true;
            txtTitle.Enabled = true;
            txtAuthor.Enabled = true;
            txtPrice.Enabled = true;
            txtOnHand.Enabled = true;
            txtTransactionDate.Enabled = true;
           
        }

        private void btnDeleteBook_Click(object sender, EventArgs e)
        {
            BookStoreClass.currentBookFile.deleteBook(txtISBN.Text);
            btnAdd.Visible = false;
            btnUpdate.Visible = false;

            lblISBN.Visible = true;
            txtFirstThree.Visible = true;
            lblhyphen.Visible = true;
            txtLastThree.Visible = true;
            btnOkay.Visible = true;
            pnlTransactionBook.Visible = true;
           
            txtISBN.Enabled = false;
            txtTitle.Enabled = false;
            txtAuthor.Enabled = false;
            txtPrice.Enabled = false;
            txtOnHand.Enabled = false;
            txtTransactionDate.Enabled = false;
          
            btnAddBook.Enabled = false;
            btnUpdateBook.Enabled = false;
            btnDeleteBook.Enabled = false;
            btnDone.Enabled = false;
            
        }

        private void btnYes_Click(object sender, EventArgs e)
        {
            
                       btnDone.Enabled = true;
                      
                       lblISBN.Enabled = false;
                       txtFirstThree.Enabled = false;
                       lblhyphen.Enabled = false;
                       txtLastThree.Enabled = false;
                       btnOkay.Enabled = false;
                       
        }

        private void btnNo_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Enter the ISBM for book you wish to delete.");
            txtFirstThree.Focus();
         
        }

        private void btnDone_Click(object sender, EventArgs e)
        {
            String ISBN = txtFirstThree.Text + "-" + txtLastThree.Text;
            String Title = txtTitle.Text;
            String Author = txtAuthor.Text;
            String Price = txtPrice.Text;
            String onHand = txtOnHand.Text;
            String transactionDate = txtTransactionDate.Text;

            BookStoreClass.currentBookFile.closeFile();
            updatedFileClass updatedCurrentBookFile = new
         updatedFileClass(Globals.BookStore.getCurrentBookFilePath());
            
            updatedCurrentBookFile.putNextRecord("\n" + "ISBN = " + ISBN + " * Title = " + Title + " * Author = " + Author + String.Format(" * Price = {0:C}", Price) +
                    " * Nummber On Hand = " + onHand + " * Date Last Transaction = " + transactionDate);
                    
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            String ISBN = txtFirstThree.Text + "-" + txtLastThree.Text;
            String Title = txtTitle.Text;
            String Author = txtAuthor.Text;
            String Price = txtPrice.Text;
            String onHand = txtOnHand.Text;
            String transactionDate = txtTransactionDate.Text;
            Globals.BookStore.Book.setHiddenISBN(ISBN);
            Globals.BookStore.Book.setHiddenAuthor(Author);
            Globals.BookStore.Book.setHiddenTitle(Title);
            Globals.BookStore.Book.setHiddenPrice(Price);
            Globals.BookStore.Book.setHiddennumberOnHand(onHand);
            Globals.BookStore.Book.setHiddendateLastTransaction(transactionDate);
            Globals.BookStore.Book.modifyBookRecord();
            BookStoreClass.updatedBookFile.putNextRecord("\n" + "ISBN = " + ISBN + " * Title = " + Title + " * Author = " + Author + String.Format(" * Price = {0:C}", Price) +
                    " * Nummber On Hand = " + onHand + " * Date Last Transaction = " + transactionDate);
            Globals.BookStore.Book.displayBookRecord();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            String isbnTemp = txtFirstThree.Text + lblhyphen.Text + txtLastThree.Text;
            txtISBN.Text = isbnTemp;
            Globals.BookStore.Book.setHiddenAuthor(txtAuthor.Text);
            Globals.BookStore.Book.setHiddenTitle(txtTitle.Text);
            Globals.BookStore.Book.setHiddenPrice(txtPrice.Text);
            Globals.BookStore.Book.setHiddennumberOnHand(txtOnHand.Text);
            Globals.BookStore.Book.setHiddendateLastTransaction(txtTransactionDate.Text);
            Globals.BookStore.Book.setHiddenISBN(txtISBN.Text);
            Boolean matchFound = false;
            matchFound = Globals.BookStore.Book.modifyBookRecord();
            if (matchFound)
            {
                MessageBox.Show("Book Updated");

            }
            else
            {
                MessageBox.Show("Could not find a book to update");
            }

            Globals.BookStore.Book.displayBookRecord();

            lblISBN.Visible = true;
            txtFirstThree.Visible = true;
            lblhyphen.Visible = true;
            txtLastThree.Visible = true;
            btnOkay.Visible = true;
            pnlTransactionBook.Visible = true;


            lblDeletebook.Visible = false;


            txtISBN.Enabled = false;

            btnAddBook.Enabled = false;
            btnUpdateBook.Enabled = false;
            btnDeleteBook.Enabled = false;
            btnDone.Enabled = true;
        }
        //creating an object
      //  updatedFileClass xyz = new updatedFileClass("updatedFile.txt");
        //currentFileClass abc = new currentFileClass("currentFile.txt");
        private void btnExit_Click(object sender, EventArgs e)
        {/*
            bool isEndOfFile = false;
            string nextRecord;
            BookStoreClass.currentBookFile.getNextRecord(ref isEndOfFile);
         


            while (!isEndOfFile)
            {
                xyz.putNextRecord("nextRecord");
                nextRecord = abc.getNextRecord(ref isEndOfFile);
                
                
            }*/
            this.Close();
            }
       // currentFileClass currentfile = new currentFileClass("currentFile.txt");
        private void btnDelete_Click(object sender, EventArgs e)
        {
            
            //currentfile.deleteBook("ISBN");
        }
    }
}
