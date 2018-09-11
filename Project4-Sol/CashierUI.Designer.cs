namespace Project4_Sol
{
    partial class CashierUI
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
            this.enter = new System.Windows.Forms.Button();
            this.userInfo = new System.Windows.Forms.TextBox();
            this.prompter = new System.Windows.Forms.Label();
            this.confirmName = new System.Windows.Forms.Button();
            this.confirmMonth = new System.Windows.Forms.Button();
            this.monthTextBox = new System.Windows.Forms.TextBox();
            this.dateTextBox = new System.Windows.Forms.TextBox();
            this.confirmDate = new System.Windows.Forms.Button();
            this.confirmProductName = new System.Windows.Forms.Button();
            this.productName = new System.Windows.Forms.TextBox();
            this.confirmProductPrice = new System.Windows.Forms.Button();
            this.productPrice = new System.Windows.Forms.TextBox();
            this.finished = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // enter
            // 
            this.enter.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.enter.Location = new System.Drawing.Point(182, 12);
            this.enter.Name = "enter";
            this.enter.Size = new System.Drawing.Size(273, 38);
            this.enter.TabIndex = 0;
            this.enter.Text = "Enter Transaction";
            this.enter.UseVisualStyleBackColor = true;
            this.enter.Click += new System.EventHandler(this.button1_Click);
            // 
            // userInfo
            // 
            this.userInfo.Location = new System.Drawing.Point(340, 109);
            this.userInfo.Name = "userInfo";
            this.userInfo.Size = new System.Drawing.Size(206, 22);
            this.userInfo.TabIndex = 1;
            this.userInfo.Visible = false;
            // 
            // prompter
            // 
            this.prompter.AutoSize = true;
            this.prompter.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.prompter.Location = new System.Drawing.Point(49, 62);
            this.prompter.Name = "prompter";
            this.prompter.Size = new System.Drawing.Size(53, 20);
            this.prompter.TabIndex = 2;
            this.prompter.Text = "label1";
            this.prompter.Visible = false;
            // 
            // confirmName
            // 
            this.confirmName.Location = new System.Drawing.Point(108, 107);
            this.confirmName.Name = "confirmName";
            this.confirmName.Size = new System.Drawing.Size(205, 27);
            this.confirmName.TabIndex = 3;
            this.confirmName.Text = "Enter";
            this.confirmName.UseVisualStyleBackColor = true;
            this.confirmName.Visible = false;
            this.confirmName.Click += new System.EventHandler(this.confirmName_Click);
            // 
            // confirmMonth
            // 
            this.confirmMonth.Location = new System.Drawing.Point(108, 154);
            this.confirmMonth.Name = "confirmMonth";
            this.confirmMonth.Size = new System.Drawing.Size(205, 23);
            this.confirmMonth.TabIndex = 4;
            this.confirmMonth.Text = "Enter";
            this.confirmMonth.UseVisualStyleBackColor = true;
            this.confirmMonth.Visible = false;
            this.confirmMonth.Click += new System.EventHandler(this.confirmMonth_Click);
            // 
            // monthTextBox
            // 
            this.monthTextBox.Location = new System.Drawing.Point(340, 155);
            this.monthTextBox.Name = "monthTextBox";
            this.monthTextBox.Size = new System.Drawing.Size(206, 22);
            this.monthTextBox.TabIndex = 5;
            this.monthTextBox.Visible = false;
            // 
            // dateTextBox
            // 
            this.dateTextBox.Location = new System.Drawing.Point(340, 198);
            this.dateTextBox.Name = "dateTextBox";
            this.dateTextBox.Size = new System.Drawing.Size(206, 22);
            this.dateTextBox.TabIndex = 6;
            this.dateTextBox.Visible = false;
            // 
            // confirmDate
            // 
            this.confirmDate.Location = new System.Drawing.Point(108, 197);
            this.confirmDate.Name = "confirmDate";
            this.confirmDate.Size = new System.Drawing.Size(205, 23);
            this.confirmDate.TabIndex = 7;
            this.confirmDate.Text = "Enter";
            this.confirmDate.UseVisualStyleBackColor = true;
            this.confirmDate.Visible = false;
            this.confirmDate.Click += new System.EventHandler(this.confirmDate_Click);
            // 
            // confirmProductName
            // 
            this.confirmProductName.Location = new System.Drawing.Point(108, 240);
            this.confirmProductName.Name = "confirmProductName";
            this.confirmProductName.Size = new System.Drawing.Size(205, 23);
            this.confirmProductName.TabIndex = 8;
            this.confirmProductName.Text = "Enter";
            this.confirmProductName.UseVisualStyleBackColor = true;
            this.confirmProductName.Visible = false;
            this.confirmProductName.Click += new System.EventHandler(this.confirmProductName_Click);
            // 
            // productName
            // 
            this.productName.Location = new System.Drawing.Point(340, 240);
            this.productName.Name = "productName";
            this.productName.Size = new System.Drawing.Size(206, 22);
            this.productName.TabIndex = 9;
            this.productName.Visible = false;
            // 
            // confirmProductPrice
            // 
            this.confirmProductPrice.Location = new System.Drawing.Point(108, 279);
            this.confirmProductPrice.Name = "confirmProductPrice";
            this.confirmProductPrice.Size = new System.Drawing.Size(205, 23);
            this.confirmProductPrice.TabIndex = 10;
            this.confirmProductPrice.Text = "Enter";
            this.confirmProductPrice.UseVisualStyleBackColor = true;
            this.confirmProductPrice.Visible = false;
            this.confirmProductPrice.Click += new System.EventHandler(this.confirmProductPrice_Click);
            // 
            // productPrice
            // 
            this.productPrice.Location = new System.Drawing.Point(340, 279);
            this.productPrice.Name = "productPrice";
            this.productPrice.Size = new System.Drawing.Size(206, 22);
            this.productPrice.TabIndex = 11;
            this.productPrice.Visible = false;
            // 
            // finished
            // 
            this.finished.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.finished.Location = new System.Drawing.Point(182, 320);
            this.finished.Name = "finished";
            this.finished.Size = new System.Drawing.Size(294, 36);
            this.finished.TabIndex = 12;
            this.finished.Text = "Complete Transaction";
            this.finished.UseVisualStyleBackColor = true;
            this.finished.Visible = false;
            this.finished.Click += new System.EventHandler(this.finished_Click);
            // 
            // CashierUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(632, 375);
            this.Controls.Add(this.finished);
            this.Controls.Add(this.productPrice);
            this.Controls.Add(this.confirmProductPrice);
            this.Controls.Add(this.productName);
            this.Controls.Add(this.confirmProductName);
            this.Controls.Add(this.confirmDate);
            this.Controls.Add(this.dateTextBox);
            this.Controls.Add(this.monthTextBox);
            this.Controls.Add(this.confirmMonth);
            this.Controls.Add(this.confirmName);
            this.Controls.Add(this.prompter);
            this.Controls.Add(this.userInfo);
            this.Controls.Add(this.enter);
            this.Name = "CashierUI";
            this.Text = "Cashier";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button enter;
        private System.Windows.Forms.TextBox userInfo;
        private System.Windows.Forms.Label prompter;
        private System.Windows.Forms.Button confirmName;
        private System.Windows.Forms.Button confirmMonth;
        private System.Windows.Forms.TextBox monthTextBox;
        private System.Windows.Forms.TextBox dateTextBox;
        private System.Windows.Forms.Button confirmDate;
        private System.Windows.Forms.Button confirmProductName;
        private System.Windows.Forms.TextBox productName;
        private System.Windows.Forms.Button confirmProductPrice;
        private System.Windows.Forms.TextBox productPrice;
        private System.Windows.Forms.Button finished;
    }
}