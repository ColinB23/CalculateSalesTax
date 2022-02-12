using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SalesTaxCalc___Colin_Brodnik
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void myClearButton_Click(object sender, EventArgs e)
        {
            //Author-Colin Brodnik
            //ID:626281
            //Date-2/18/20
            //Goal-Calculate the tax of the input and show how much the tax was and the total cost.
            mySalesText.Text = ("");
            myTaxAnswerLabel.Text = ("");
            myTotalAnsLabel.Text = ("");
            // this clears the numbers on the application

        }

        private void myCalcButton_Click(object sender, EventArgs e)
        {
            //holds the numeric version of what is typed
            decimal SalesIn = 0;
            decimal TaxPercent = 6.75m;

            //holds the results of the calculations
            decimal SalesTaxResult = 0;
            decimal TotalResult = 0;

            //Takes the input from the textbox and converts it to numeric data
            SalesIn = decimal.Parse(mySalesText.Text);

            //The calculation to get the result
            SalesTaxResult = SalesIn * TaxPercent / 100;
            TotalResult = (SalesIn * TaxPercent / 100) + SalesIn;

            //Converts the data to text to show
            myTaxAnswerLabel.Text = SalesTaxResult.ToString();
            myTotalAnsLabel.Text = TotalResult.ToString();
        }

       
        
    }
}
