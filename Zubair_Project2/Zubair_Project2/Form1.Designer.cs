namespace Zubair_Project2
{
    partial class frmEnterAccessID
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
            this.lblAccessID = new System.Windows.Forms.Label();
            this.txtAccessID = new System.Windows.Forms.TextBox();
            this.btnFindMe = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblAccessID
            // 
            this.lblAccessID.AutoSize = true;
            this.lblAccessID.Location = new System.Drawing.Point(30, 48);
            this.lblAccessID.Name = "lblAccessID";
            this.lblAccessID.Size = new System.Drawing.Size(122, 13);
            this.lblAccessID.TabIndex = 0;
            this.lblAccessID.Text = "Enter five digit access id";
            // 
            // txtAccessID
            // 
            this.txtAccessID.Location = new System.Drawing.Point(33, 74);
            this.txtAccessID.MaxLength = 5;
            this.txtAccessID.Name = "txtAccessID";
            this.txtAccessID.Size = new System.Drawing.Size(100, 20);
            this.txtAccessID.TabIndex = 1;
            // 
            // btnFindMe
            // 
            this.btnFindMe.Location = new System.Drawing.Point(33, 123);
            this.btnFindMe.Name = "btnFindMe";
            this.btnFindMe.Size = new System.Drawing.Size(75, 23);
            this.btnFindMe.TabIndex = 2;
            this.btnFindMe.Text = "Find Me!";
            this.btnFindMe.UseVisualStyleBackColor = true;
            this.btnFindMe.Click += new System.EventHandler(this.btnFindMe_Click);
            // 
            // frmEnterAccessID
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.btnFindMe);
            this.Controls.Add(this.txtAccessID);
            this.Controls.Add(this.lblAccessID);
            this.Name = "frmEnterAccessID";
            this.Text = "Employee Access ID";
            this.Load += new System.EventHandler(this.frmEnterAccessID_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblAccessID;
        private System.Windows.Forms.TextBox txtAccessID;
        private System.Windows.Forms.Button btnFindMe;
    }
}

