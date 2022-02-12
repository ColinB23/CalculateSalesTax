namespace SalesTaxCalc___Colin_Brodnik
{
    partial class Form1
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
            this.myCalcButton = new System.Windows.Forms.Button();
            this.myClearButton = new System.Windows.Forms.Button();
            this.mySalesLabel = new System.Windows.Forms.Label();
            this.mySalesText = new System.Windows.Forms.TextBox();
            this.myTaxLabel = new System.Windows.Forms.Label();
            this.myTaxAnswerLabel = new System.Windows.Forms.Label();
            this.myTotalLabel = new System.Windows.Forms.Label();
            this.myTotalAnsLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // myCalcButton
            // 
            this.myCalcButton.Location = new System.Drawing.Point(211, 106);
            this.myCalcButton.Name = "myCalcButton";
            this.myCalcButton.Size = new System.Drawing.Size(82, 37);
            this.myCalcButton.TabIndex = 0;
            this.myCalcButton.Text = "Calculate";
            this.myCalcButton.UseVisualStyleBackColor = true;
            this.myCalcButton.Click += new System.EventHandler(this.myCalcButton_Click);
            // 
            // myClearButton
            // 
            this.myClearButton.Location = new System.Drawing.Point(211, 150);
            this.myClearButton.Name = "myClearButton";
            this.myClearButton.Size = new System.Drawing.Size(83, 23);
            this.myClearButton.TabIndex = 1;
            this.myClearButton.Text = "Clear";
            this.myClearButton.UseVisualStyleBackColor = true;
            this.myClearButton.Click += new System.EventHandler(this.myClearButton_Click);
            // 
            // mySalesLabel
            // 
            this.mySalesLabel.Location = new System.Drawing.Point(46, 33);
            this.mySalesLabel.Name = "mySalesLabel";
            this.mySalesLabel.Size = new System.Drawing.Size(133, 41);
            this.mySalesLabel.TabIndex = 2;
            this.mySalesLabel.Text = "Enter Slaes Amount:";
            this.mySalesLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // mySalesText
            // 
            this.mySalesText.Location = new System.Drawing.Point(62, 88);
            this.mySalesText.Name = "mySalesText";
            this.mySalesText.Size = new System.Drawing.Size(100, 22);
            this.mySalesText.TabIndex = 3;
            // 
            // myTaxLabel
            // 
            this.myTaxLabel.Location = new System.Drawing.Point(62, 117);
            this.myTaxLabel.Name = "myTaxLabel";
            this.myTaxLabel.Size = new System.Drawing.Size(100, 41);
            this.myTaxLabel.TabIndex = 4;
            this.myTaxLabel.Text = "Tax Amount at 6.75%:";
            this.myTaxLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // myTaxAnswerLabel
            // 
            this.myTaxAnswerLabel.BackColor = System.Drawing.SystemColors.Info;
            this.myTaxAnswerLabel.Location = new System.Drawing.Point(62, 162);
            this.myTaxAnswerLabel.Name = "myTaxAnswerLabel";
            this.myTaxAnswerLabel.Size = new System.Drawing.Size(100, 23);
            this.myTaxAnswerLabel.TabIndex = 5;
            // 
            // myTotalLabel
            // 
            this.myTotalLabel.Location = new System.Drawing.Point(62, 195);
            this.myTotalLabel.Name = "myTotalLabel";
            this.myTotalLabel.Size = new System.Drawing.Size(100, 22);
            this.myTotalLabel.TabIndex = 6;
            this.myTotalLabel.Text = "Total Amount:";
            // 
            // myTotalAnsLabel
            // 
            this.myTotalAnsLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.myTotalAnsLabel.Location = new System.Drawing.Point(65, 221);
            this.myTotalAnsLabel.Name = "myTotalAnsLabel";
            this.myTotalAnsLabel.Size = new System.Drawing.Size(100, 23);
            this.myTotalAnsLabel.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(353, 313);
            this.Controls.Add(this.myTotalAnsLabel);
            this.Controls.Add(this.myTotalLabel);
            this.Controls.Add(this.myTaxAnswerLabel);
            this.Controls.Add(this.myTaxLabel);
            this.Controls.Add(this.mySalesText);
            this.Controls.Add(this.mySalesLabel);
            this.Controls.Add(this.myClearButton);
            this.Controls.Add(this.myCalcButton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button myCalcButton;
        private System.Windows.Forms.Button myClearButton;
        internal System.Windows.Forms.Label mySalesLabel;
        private System.Windows.Forms.TextBox mySalesText;
        private System.Windows.Forms.Label myTaxLabel;
        private System.Windows.Forms.Label myTaxAnswerLabel;
        private System.Windows.Forms.Label myTotalLabel;
        private System.Windows.Forms.Label myTotalAnsLabel;
    }
}

