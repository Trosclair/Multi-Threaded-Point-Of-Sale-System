namespace Project4_Sol
{
    partial class CustomerServiceUI
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
            this.ItemList = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.EndTransaction = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.TransactionIDTextBox = new System.Windows.Forms.TextBox();
            this.StartReturn = new System.Windows.Forms.Button();
            this.ReturnItemButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ItemList
            // 
            this.ItemList.Location = new System.Drawing.Point(164, 36);
            this.ItemList.Multiline = true;
            this.ItemList.Name = "ItemList";
            this.ItemList.ReadOnly = true;
            this.ItemList.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.ItemList.Size = new System.Drawing.Size(322, 293);
            this.ItemList.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(309, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Item List";
            // 
            // EndTransaction
            // 
            this.EndTransaction.Enabled = false;
            this.EndTransaction.Location = new System.Drawing.Point(12, 264);
            this.EndTransaction.Name = "EndTransaction";
            this.EndTransaction.Size = new System.Drawing.Size(131, 65);
            this.EndTransaction.TabIndex = 6;
            this.EndTransaction.Text = "Complete Transaction";
            this.EndTransaction.UseVisualStyleBackColor = true;
            this.EndTransaction.Click += new System.EventHandler(this.EndTransaction_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 132);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(134, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Enter Item To Be Returned";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(12, 155);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(131, 20);
            this.textBox3.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 13);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(101, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Enter Transaction #";
            // 
            // TransactionIDTextBox
            // 
            this.TransactionIDTextBox.Location = new System.Drawing.Point(12, 29);
            this.TransactionIDTextBox.Name = "TransactionIDTextBox";
            this.TransactionIDTextBox.Size = new System.Drawing.Size(131, 20);
            this.TransactionIDTextBox.TabIndex = 10;
            // 
            // StartReturn
            // 
            this.StartReturn.Location = new System.Drawing.Point(12, 55);
            this.StartReturn.Name = "StartReturn";
            this.StartReturn.Size = new System.Drawing.Size(131, 41);
            this.StartReturn.TabIndex = 11;
            this.StartReturn.Text = "Start Return:";
            this.StartReturn.UseVisualStyleBackColor = true;
            this.StartReturn.Click += new System.EventHandler(this.StartReturn_Click);
            // 
            // ReturnItemButton
            // 
            this.ReturnItemButton.Enabled = false;
            this.ReturnItemButton.Location = new System.Drawing.Point(15, 193);
            this.ReturnItemButton.Name = "ReturnItemButton";
            this.ReturnItemButton.Size = new System.Drawing.Size(128, 39);
            this.ReturnItemButton.TabIndex = 12;
            this.ReturnItemButton.Text = "Return Item";
            this.ReturnItemButton.UseVisualStyleBackColor = true;
            this.ReturnItemButton.Click += new System.EventHandler(this.ReturnItem_Click);
            // 
            // CustomerServiceUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(498, 341);
            this.Controls.Add(this.ReturnItemButton);
            this.Controls.Add(this.StartReturn);
            this.Controls.Add(this.TransactionIDTextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.EndTransaction);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ItemList);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CustomerServiceUI";
            this.Text = "CustomerServiceUI";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox ItemList;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button EndTransaction;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TransactionIDTextBox;
        private System.Windows.Forms.Button StartReturn;
        private System.Windows.Forms.Button ReturnItemButton;
    }
}