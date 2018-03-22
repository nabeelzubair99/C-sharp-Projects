namespace Zubair_Bingo
{
    partial class frmBingo
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
            this.lblHeading = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblReadytoPlay = new System.Windows.Forms.Label();
            this.btnYes = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.lblInstructions = new System.Windows.Forms.Label();
            this.txtDisplayNumber = new System.Windows.Forms.TextBox();
            this.btnDontHave = new System.Windows.Forms.Button();
            this.pnlcard = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // lblHeading
            // 
            this.lblHeading.AutoSize = true;
            this.lblHeading.Font = new System.Drawing.Font("Trebuchet MS", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeading.Location = new System.Drawing.Point(15, 11);
            this.lblHeading.Name = "lblHeading";
            this.lblHeading.Size = new System.Drawing.Size(401, 35);
            this.lblHeading.TabIndex = 0;
            this.lblHeading.Text = "Welcome to the game of Bingo";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(15, 63);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(202, 19);
            this.lblName.TabIndex = 1;
            this.lblName.Text = "Enter your name to the right:";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(223, 61);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(116, 21);
            this.txtName.TabIndex = 1;
            // 
            // lblReadytoPlay
            // 
            this.lblReadytoPlay.AutoSize = true;
            this.lblReadytoPlay.Enabled = false;
            this.lblReadytoPlay.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReadytoPlay.Location = new System.Drawing.Point(16, 102);
            this.lblReadytoPlay.Name = "lblReadytoPlay";
            this.lblReadytoPlay.Size = new System.Drawing.Size(155, 17);
            this.lblReadytoPlay.TabIndex = 3;
            this.lblReadytoPlay.Text = "Are you ready to play?";
            // 
            // btnYes
            // 
            this.btnYes.BackColor = System.Drawing.Color.Yellow;
            this.btnYes.Location = new System.Drawing.Point(188, 98);
            this.btnYes.Name = "btnYes";
            this.btnYes.Size = new System.Drawing.Size(103, 27);
            this.btnYes.TabIndex = 4;
            this.btnYes.Text = "Yes! Lets play.";
            this.btnYes.UseVisualStyleBackColor = false;
            this.btnYes.Click += new System.EventHandler(this.btnYes_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.Yellow;
            this.btnExit.Location = new System.Drawing.Point(306, 98);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(87, 27);
            this.btnExit.TabIndex = 5;
            this.btnExit.Text = "No, Exit";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click_1);
            // 
            // lblInstructions
            // 
            this.lblInstructions.AutoSize = true;
            this.lblInstructions.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInstructions.Location = new System.Drawing.Point(19, 132);
            this.lblInstructions.Name = "lblInstructions";
            this.lblInstructions.Size = new System.Drawing.Size(417, 60);
            this.lblInstructions.TabIndex = 6;
            this.lblInstructions.Text = "We call one number at a time.\r\n Check your card for that number and if found, cli" +
    "ck that cell.\r\n We will  do the rest.\r\n If you do not have the number click  the" +
    "re is no number button to the right.  ";
            this.lblInstructions.Visible = false;
            // 
            // txtDisplayNumber
            // 
            this.txtDisplayNumber.BackColor = System.Drawing.Color.SandyBrown;
            this.txtDisplayNumber.Location = new System.Drawing.Point(401, 135);
            this.txtDisplayNumber.Name = "txtDisplayNumber";
            this.txtDisplayNumber.ReadOnly = true;
            this.txtDisplayNumber.Size = new System.Drawing.Size(116, 21);
            this.txtDisplayNumber.TabIndex = 7;
            this.txtDisplayNumber.Visible = false;
            // 
            // btnDontHave
            // 
            this.btnDontHave.BackColor = System.Drawing.Color.Yellow;
            this.btnDontHave.Location = new System.Drawing.Point(437, 165);
            this.btnDontHave.Name = "btnDontHave";
            this.btnDontHave.Size = new System.Drawing.Size(87, 27);
            this.btnDontHave.TabIndex = 8;
            this.btnDontHave.Text = "Dont Have!";
            this.btnDontHave.UseVisualStyleBackColor = false;
            this.btnDontHave.Visible = false;
            this.btnDontHave.Click += new System.EventHandler(this.btnDontHave_Click);
            // 
            // pnlcard
            // 
            this.pnlcard.Location = new System.Drawing.Point(14, 210);
            this.pnlcard.Name = "pnlcard";
            this.pnlcard.Size = new System.Drawing.Size(850, 850);
            this.pnlcard.TabIndex = 9;
            this.pnlcard.Visible = false;
            // 
            // frmBingo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1017, 781);
            this.Controls.Add(this.pnlcard);
            this.Controls.Add(this.btnDontHave);
            this.Controls.Add(this.txtDisplayNumber);
            this.Controls.Add(this.lblInstructions);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnYes);
            this.Controls.Add(this.lblReadytoPlay);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.lblHeading);
            this.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "frmBingo";
            this.Text = "Bingo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblHeading;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblReadytoPlay;
        private System.Windows.Forms.Button btnYes;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label lblInstructions;
        private System.Windows.Forms.TextBox txtDisplayNumber;
        private System.Windows.Forms.Button btnDontHave;
        private System.Windows.Forms.Panel pnlcard;
    }
}

