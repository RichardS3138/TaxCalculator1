using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TaxCalculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            decimal income = Convert.ToDecimal(txtIncome.Text);
            decimal incomeTax = CalculateTax(income);


            txtTax.Text = incomeTax.ToString();
        }
        private decimal CalculateTax(decimal incomeAmount)
        {

            decimal tax = 0m;           

            if (incomeAmount <= 9875)
                tax = (int)(incomeAmount * .10m);
            else if (incomeAmount > 9875 && incomeAmount <= 40125)
                tax = 987.5m + (int)((incomeAmount - 9875) * .12m);
            else if (incomeAmount > 40125 && incomeAmount <= 85525)
                tax = 4617.5m + (int)((incomeAmount - 40125) * .22m);
            else if (incomeAmount > 85525 && incomeAmount <= 163300)
                tax = 14605.5m + (int)((incomeAmount - 85525) * .24m);
            else if (incomeAmount > 163300 && incomeAmount <= 207350)
                tax = 33271.5m + (int)((incomeAmount - 163300) * .32m);
            else if (incomeAmount > 207351 && incomeAmount <= 518400)
                tax = 47367.5m + (int)((incomeAmount - 518400) * .35m);
            else if (incomeAmount > 518401)
                tax = 156235m + (int)((incomeAmount - 518400) * .37m);

            return tax;
        }


        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ClearCalculateTax(object sender, EventArgs e)
        {
            txtTax.Text = "";
        }
    }
}
