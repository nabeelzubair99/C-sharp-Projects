namespace Zubair_Project2
{
    partial class frmTransactionSelect
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblEnterISBN = new System.Windows.Forms.Label();
            this.txtFirstThree = new System.Windows.Forms.TextBox();
            this.txtLastThree = new System.Windows.Forms.TextBox();
            this.lblhyphen = new System.Windows.Forms.Label();
            this.lblSelectATransaction = new System.Windows.Forms.Label();
            this.btnAddBook = new System.Windows.Forms.Button();
            this.btnUpdateBook = new System.Windows.Forms.Button();
            this.btnDeleteBook = new System.Windows.Forms.Button();
            this.pnlTransactionBook = new System.Windows.Forms.Panel();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.lblDeletebook = new System.Windows.Forms.Label();
            this.txtTransactionDate = new System.Windows.Forms.TextBox();
            this.lblTransactionDate = new System.Windows.Forms.Label();
            this.txtOnHand = new System.Windows.Forms.TextBox();
            this.lblOnHand = new System.Windows.Forms.Label();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.lblPrice = new System.Windows.Forms.Label();
            this.txtAuthor = new System.Windows.Forms.TextBox();
            this.lblAuthor = new System.Windows.Forms.Label();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.txtISBN = new System.Windows.Forms.TextBox();
            this.lblISBN = new System.Windows.Forms.Label();
            this.btnOkay = new System.Windows.Forms.Button();
            this.btnDone = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.pnlTransactionBook.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblEnterISBN
            // 
            this.lblEnterISBN.AutoSize = true;
            this.lblEnterISBN.Location = new System.Drawing.Point(13, 23);
            this.lblEnterISBN.Name = "lblEnterISBN";
            this.lblEnterISBN.Size = new System.Drawing.Size(202, 13);
            this.lblEnterISBN.TabIndex = 0;
            this.lblEnterISBN.Text = "Enter the ISBN for book (in form nnn-nnn)";
            // 
            // txtFirstThree
            // 
            this.txtFirstThree.Location = new System.Drawing.Point(222, 23);
            this.txtFirstThree.MaxLength = 3;
            this.txtFirstThree.Name = "txtFirstThree";
            this.txtFirstThree.Size = new System.Drawing.Size(52, 20);
            this.txtFirstThree.TabIndex = 1;
            // 
            // txtLastThree
            // 
            this.txtLastThree.Location = new System.Drawing.Point(296, 23);
            this.txtLastThree.MaxLength = 3;
            this.txtLastThree.Name = "txtLastThree";
            this.txtLastThree.Size = new System.Drawing.Size(51, 20);
            this.txtLastThree.TabIndex = 2;
            // 
            // lblhyphen
            // 
            this.lblhyphen.AutoSize = true;
            this.lblhyphen.Location = new System.Drawing.Point(280, 26);
            this.lblhyphen.Name = "lblhyphen";
            this.lblhyphen.Size = new System.Drawing.Size(10, 13);
            this.lblhyphen.TabIndex = 3;
            this.lblhyphen.Text = "-";
            // 
            // lblSelectATransaction
            // 
            this.lblSelectATransaction.AutoSize = true;
            this.lblSelectATransaction.Location = new System.Drawing.Point(16, 53);
            this.lblSelectATransaction.Name = "lblSelectATransaction";
            this.lblSelectATransaction.Size = new System.Drawing.Size(106, 13);
            this.lblSelectATransaction.TabIndex = 4;
            this.lblSelectATransaction.Text = "Select A Transaction";
            this.lblSelectATransaction.Visible = false;
            // 
            // btnAddBook
            // 
            this.btnAddBook.Location = new System.Drawing.Point(174, 65);
            this.btnAddBook.Name = "btnAddBook";
            this.btnAddBook.Size = new System.Drawing.Size(141, 23);
            this.btnAddBook.TabIndex = 5;
            this.btnAddBook.Text = "Add Book";
            this.btnAddBook.UseVisualStyleBackColor = true;
            this.btnAddBook.Visible = false;
            this.btnAddBook.Click += new System.EventHandler(this.btnAddBook_Click);
            // 
            // btnUpdateBook
            // 
            this.btnUpdateBook.Location = new System.Drawing.Point(174, 94);
            this.btnUpdateBook.Name = "btnUpdateBook";
            this.btnUpdateBook.Size = new System.Drawing.Size(141, 23);
            this.btnUpdateBook.TabIndex = 6;
            this.btnUpdateBook.Text = "Update Book";
            this.btnUpdateBook.UseVisualStyleBackColor = true;
            this.btnUpdateBook.Visible = false;
            this.btnUpdateBook.Click += new System.EventHandler(this.btnUpdateBook_Click);
            // 
            // btnDeleteBook
            // 
            this.btnDeleteBook.Location = new System.Drawing.Point(174, 123);
            this.btnDeleteBook.Name = "btnDeleteBook";
            this.btnDeleteBook.Size = new System.Drawing.Size(141, 23);
            this.btnDeleteBook.TabIndex = 7;
            this.btnDeleteBook.Text = "Delete Book";
            this.btnDeleteBook.UseVisualStyleBackColor = true;
            this.btnDeleteBook.Visible = false;
            this.btnDeleteBook.Click += new System.EventHandler(this.btnDeleteBook_Click);
            // 
            // pnlTransactionBook
            // 
            this.pnlTransactionBook.Controls.Add(this.btnDelete);
            this.pnlTransactionBook.Controls.Add(this.btnUpdate);
            this.pnlTransactionBook.Controls.Add(this.btnAdd);
            this.pnlTransactionBook.Controls.Add(this.lblDeletebook);
            this.pnlTransactionBook.Controls.Add(this.txtTransactionDate);
            this.pnlTransactionBook.Controls.Add(this.lblTransactionDate);
            this.pnlTransactionBook.Controls.Add(this.txtOnHand);
            this.pnlTransactionBook.Controls.Add(this.lblOnHand);
            this.pnlTransactionBook.Controls.Add(this.txtPrice);
            this.pnlTransactionBook.Controls.Add(this.lblPrice);
            this.pnlTransactionBook.Controls.Add(this.txtAuthor);
            this.pnlTransactionBook.Controls.Add(this.lblAuthor);
            this.pnlTransactionBook.Controls.Add(this.txtTitle);
            this.pnlTransactionBook.Controls.Add(this.lblTitle);
            this.pnlTransactionBook.Controls.Add(this.txtISBN);
            this.pnlTransactionBook.Controls.Add(this.lblISBN);
            this.pnlTransactionBook.Location = new System.Drawing.Point(19, 152);
            this.pnlTransactionBook.Name = "pnlTransactionBook";
            this.pnlTransactionBook.Size = new System.Drawing.Size(566, 149);
            this.pnlTransactionBook.TabIndex = 8;
            this.pnlTransactionBook.Visible = false;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(277, 106);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 15;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(107, 107);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate.TabIndex = 14;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(196, 107);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 13;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // lblDeletebook
            // 
            this.lblDeletebook.AutoSize = true;
            this.lblDeletebook.Location = new System.Drawing.Point(19, 107);
            this.lblDeletebook.Name = "lblDeletebook";
            this.lblDeletebook.Size = new System.Drawing.Size(0, 13);
            this.lblDeletebook.TabIndex = 12;
            // 
            // txtTransactionDate
            // 
            this.txtTransactionDate.Enabled = false;
            this.txtTransactionDate.Location = new System.Drawing.Point(301, 75);
            this.txtTransactionDate.Name = "txtTransactionDate";
            this.txtTransactionDate.Size = new System.Drawing.Size(100, 20);
            this.txtTransactionDate.TabIndex = 11;
            // 
            // lblTransactionDate
            // 
            this.lblTransactionDate.AutoSize = true;
            this.lblTransactionDate.Location = new System.Drawing.Point(194, 82);
            this.lblTransactionDate.Name = "lblTransactionDate";
            this.lblTransactionDate.Size = new System.Drawing.Size(89, 13);
            this.lblTransactionDate.TabIndex = 10;
            this.lblTransactionDate.Text = "Transaction Date";
            // 
            // txtOnHand
            // 
            this.txtOnHand.Enabled = false;
            this.txtOnHand.Location = new System.Drawing.Point(301, 46);
            this.txtOnHand.Name = "txtOnHand";
            this.txtOnHand.Size = new System.Drawing.Size(100, 20);
            this.txtOnHand.TabIndex = 9;
            // 
            // lblOnHand
            // 
            this.lblOnHand.AutoSize = true;
            this.lblOnHand.Location = new System.Drawing.Point(233, 53);
            this.lblOnHand.Name = "lblOnHand";
            this.lblOnHand.Size = new System.Drawing.Size(50, 13);
            this.lblOnHand.TabIndex = 8;
            this.lblOnHand.Text = "On Hand";
            // 
            // txtPrice
            // 
            this.txtPrice.Enabled = false;
            this.txtPrice.Location = new System.Drawing.Point(301, 14);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(100, 20);
            this.txtPrice.TabIndex = 7;
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Location = new System.Drawing.Point(243, 21);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(31, 13);
            this.lblPrice.TabIndex = 6;
            this.lblPrice.Text = "Price";
            // 
            // txtAuthor
            // 
            this.txtAuthor.Enabled = false;
            this.txtAuthor.Location = new System.Drawing.Point(82, 75);
            this.txtAuthor.Name = "txtAuthor";
            this.txtAuthor.Size = new System.Drawing.Size(100, 20);
            this.txtAuthor.TabIndex = 5;
            // 
            // lblAuthor
            // 
            this.lblAuthor.AutoSize = true;
            this.lblAuthor.Location = new System.Drawing.Point(19, 82);
            this.lblAuthor.Name = "lblAuthor";
            this.lblAuthor.Size = new System.Drawing.Size(38, 13);
            this.lblAuthor.TabIndex = 4;
            this.lblAuthor.Text = "Author";
            // 
            // txtTitle
            // 
            this.txtTitle.Enabled = false;
            this.txtTitle.Location = new System.Drawing.Point(82, 46);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(100, 20);
            this.txtTitle.TabIndex = 3;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Location = new System.Drawing.Point(24, 53);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(27, 13);
            this.lblTitle.TabIndex = 2;
            this.lblTitle.Text = "Title";
            // 
            // txtISBN
            // 
            this.txtISBN.Enabled = false;
            this.txtISBN.Location = new System.Drawing.Point(82, 14);
            this.txtISBN.Name = "txtISBN";
            this.txtISBN.Size = new System.Drawing.Size(100, 20);
            this.txtISBN.TabIndex = 1;
            // 
            // lblISBN
            // 
            this.lblISBN.AutoSize = true;
            this.lblISBN.Location = new System.Drawing.Point(19, 21);
            this.lblISBN.Name = "lblISBN";
            this.lblISBN.Size = new System.Drawing.Size(32, 13);
            this.lblISBN.TabIndex = 0;
            this.lblISBN.Text = "ISBN";
            // 
            // btnOkay
            // 
            this.btnOkay.Location = new System.Drawing.Point(376, 23);
            this.btnOkay.Name = "btnOkay";
            this.btnOkay.Size = new System.Drawing.Size(75, 23);
            this.btnOkay.TabIndex = 9;
            this.btnOkay.Text = "Okay";
            this.btnOkay.UseVisualStyleBackColor = true;
            this.btnOkay.Click += new System.EventHandler(this.btnOkay_Click);
            // 
            // btnDone
            // 
            this.btnDone.Location = new System.Drawing.Point(174, 312);
            this.btnDone.Name = "btnDone";
            this.btnDone.Size = new System.Drawing.Size(75, 23);
            this.btnDone.TabIndex = 10;
            this.btnDone.Text = "Done";
            this.btnDone.UseVisualStyleBackColor = true;
            this.btnDone.Visible = false;
            this.btnDone.Click += new System.EventHandler(this.btnDone_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(265, 312);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 11;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // frmTransactionSelect
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(649, 347);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnDone);
            this.Controls.Add(this.btnOkay);
            this.Controls.Add(this.pnlTransactionBook);
            this.Controls.Add(this.btnDeleteBook);
            this.Controls.Add(this.btnUpdateBook);
            this.Controls.Add(this.btnAddBook);
            this.Controls.Add(this.lblSelectATransaction);
            this.Controls.Add(this.lblhyphen);
            this.Controls.Add(this.txtLastThree);
            this.Controls.Add(this.txtFirstThree);
            this.Controls.Add(this.lblEnterISBN);
            this.Name = "frmTransactionSelect";
            this.Text = "frmTransactionSelect";
            this.Load += new System.EventHandler(this.frmTransactionSelect_Load);
            this.pnlTransactionBook.ResumeLayout(false);
            this.pnlTransactionBook.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblEnterISBN;
        private System.Windows.Forms.TextBox txtFirstThree;
        private System.Windows.Forms.TextBox txtLastThree;
        private System.Windows.Forms.Label lblhyphen;
        private System.Windows.Forms.Label lblSelectATransaction;
        private System.Windows.Forms.Button btnAddBook;
        private System.Windows.Forms.Button btnUpdateBook;
        private System.Windows.Forms.Button btnDeleteBook;
        private System.Windows.Forms.Panel pnlTransactionBook;
        private System.Windows.Forms.Label lblDeletebook;
        private System.Windows.Forms.TextBox txtTransactionDate;
        private System.Windows.Forms.Label lblTransactionDate;
        private System.Windows.Forms.TextBox txtOnHand;
        private System.Windows.Forms.Label lblOnHand;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.TextBox txtAuthor;
        private System.Windows.Forms.Label lblAuthor;
        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.TextBox txtISBN;
        private System.Windows.Forms.Label lblISBN;
        private System.Windows.Forms.Button btnOkay;
        private System.Windows.Forms.Button btnDone;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnExit;
    }
}