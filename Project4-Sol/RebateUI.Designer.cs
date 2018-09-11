namespace Project4_Sol
{
    partial class RebateUI
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
            this.EnterTransactionNumber = new System.Windows.Forms.Button();
            this.prompter = new System.Windows.Forms.Label();
            this.confirmTrans = new System.Windows.Forms.Button();
            this.transInfo = new System.Windows.Forms.TextBox();
            this.confirmMonth = new System.Windows.Forms.Button();
            this.confirmDay = new System.Windows.Forms.Button();
            this.generateButton = new System.Windows.Forms.Button();
            this.monthInfo = new System.Windows.Forms.TextBox();
            this.dayInfo = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // EnterTransactionNumber
            // 
            this.EnterTransactionNumber.Location = new System.Drawing.Point(11, 11);
            this.EnterTransactionNumber.Margin = new System.Windows.Forms.Padding(2);
            this.EnterTransactionNumber.Name = "EnterTransactionNumber";
            this.EnterTransactionNumber.Size = new System.Drawing.Size(368, 49);
            this.EnterTransactionNumber.TabIndex = 0;
            this.EnterTransactionNumber.Text = "Enter a Rebate";
            this.EnterTransactionNumber.UseVisualStyleBackColor = true;
            this.EnterTransactionNumber.Click += new System.EventHandler(this.EnterTransactionNumber_Click);
            // 
            // prompter
            // 
            this.prompter.AutoSize = true;
            this.prompter.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.prompter.Location = new System.Drawing.Point(34, 73);
            this.prompter.Name = "prompter";
            this.prompter.Size = new System.Drawing.Size(46, 17);
            this.prompter.TabIndex = 1;
            this.prompter.Text = "label1";
            this.prompter.Visible = false;
            // 
            // confirmTrans
            // 
            this.confirmTrans.Location = new System.Drawing.Point(12, 105);
            this.confirmTrans.Name = "confirmTrans";
            this.confirmTrans.Size = new System.Drawing.Size(107, 23);
            this.confirmTrans.TabIndex = 2;
            this.confirmTrans.Text = "Enter";
            this.confirmTrans.UseVisualStyleBackColor = true;
            this.confirmTrans.Visible = false;
            this.confirmTrans.Click += new System.EventHandler(this.confirmTrans_Click);
            // 
            // transInfo
            // 
            this.transInfo.Location = new System.Drawing.Point(176, 107);
            this.transInfo.Name = "transInfo";
            this.transInfo.Size = new System.Drawing.Size(203, 20);
            this.transInfo.TabIndex = 3;
            this.transInfo.Visible = false;
            // 
            // confirmMonth
            // 
            this.confirmMonth.Location = new System.Drawing.Point(12, 159);
            this.confirmMonth.Name = "confirmMonth";
            this.confirmMonth.Size = new System.Drawing.Size(107, 23);
            this.confirmMonth.TabIndex = 4;
            this.confirmMonth.Text = "Enter";
            this.confirmMonth.UseVisualStyleBackColor = true;
            this.confirmMonth.Visible = false;
            this.confirmMonth.Click += new System.EventHandler(this.confirmMonth_Click);
            // 
            // confirmDay
            // 
            this.confirmDay.Location = new System.Drawing.Point(12, 209);
            this.confirmDay.Name = "confirmDay";
            this.confirmDay.Size = new System.Drawing.Size(107, 28);
            this.confirmDay.TabIndex = 5;
            this.confirmDay.Text = "Enter";
            this.confirmDay.UseVisualStyleBackColor = true;
            this.confirmDay.Visible = false;
            this.confirmDay.Click += new System.EventHandler(this.confirmDay_Click);
            // 
            // generateButton
            // 
            this.generateButton.Location = new System.Drawing.Point(12, 283);
            this.generateButton.Name = "generateButton";
            this.generateButton.Size = new System.Drawing.Size(367, 72);
            this.generateButton.TabIndex = 6;
            this.generateButton.Text = "Generate Rebate Check";
            this.generateButton.UseVisualStyleBackColor = true;
            this.generateButton.Visible = false;
            this.generateButton.Click += new System.EventHandler(this.generateButton_Click);
            // 
            // monthInfo
            // 
            this.monthInfo.Location = new System.Drawing.Point(176, 161);
            this.monthInfo.Name = "monthInfo";
            this.monthInfo.Size = new System.Drawing.Size(203, 20);
            this.monthInfo.TabIndex = 7;
            this.monthInfo.Visible = false;
            // 
            // dayInfo
            // 
            this.dayInfo.Location = new System.Drawing.Point(176, 209);
            this.dayInfo.Name = "dayInfo";
            this.dayInfo.Size = new System.Drawing.Size(203, 20);
            this.dayInfo.TabIndex = 8;
            this.dayInfo.Visible = false;
            // 
            // RebateUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(397, 383);
            this.Controls.Add(this.dayInfo);
            this.Controls.Add(this.monthInfo);
            this.Controls.Add(this.generateButton);
            this.Controls.Add(this.confirmDay);
            this.Controls.Add(this.confirmMonth);
            this.Controls.Add(this.transInfo);
            this.Controls.Add(this.confirmTrans);
            this.Controls.Add(this.prompter);
            this.Controls.Add(this.EnterTransactionNumber);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "RebateUI";
            this.Text = "RebateUI";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button EnterTransactionNumber;
        private System.Windows.Forms.Label prompter;
        private System.Windows.Forms.Button confirmTrans;
        private System.Windows.Forms.TextBox transInfo;
        private System.Windows.Forms.Button confirmMonth;
        private System.Windows.Forms.Button confirmDay;
        private System.Windows.Forms.Button generateButton;
        private System.Windows.Forms.TextBox monthInfo;
        private System.Windows.Forms.TextBox dayInfo;
    }
}