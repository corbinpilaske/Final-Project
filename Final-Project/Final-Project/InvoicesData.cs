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

namespace Final_Project
{
    public partial class InvoicesDataFrm : Form
    {
        public InvoicesDataFrm()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void invoicesBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.invoicesBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.customersDataSet1);

        }

        private void InvoicesDataFrm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'customersDataSet1.Invoices' table. You can move, or remove it, as needed.
            this.invoicesTableAdapter.Fill(this.customersDataSet1.Invoices);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Closes the Invoice Data form
            this.Close();
        }

        private void invoiceSearch_Click(object sender, EventArgs e)
        {
            // Searches Invoices
            this.invoicesTableAdapter.InvoiceName(
                this.customersDataSet1.Invoices, textBoxInvoice.Text);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            double total, fluidCheck, tax, laborCost, partsUsed;

            fluidCheck = 0;

            StreamWriter File = new StreamWriter("Invoice.txt");

            double.TryParse(labor_CostsMaskedTextBox.Text, out laborCost);
            double.TryParse(parts_UsedTextBox.Text, out partsUsed);

            if (checkBoxEstimate.Checked)
            {
                File.Write("Joe's Automotive Information Estimate \n");
            }
            else
            {
                File.Write("Joe's Automotive Information Invoice");
            }
            if (checkBoxFC.Checked)
            {
                fluidCheck = 24.99;
                File.Write("Fluid Checkup: $24.99 \n");
            }
            else
            {
                File.Write("Fluid Checkup: $0.00 \n");
            }
            tax = (fluidCheck + laborCost) * 0.06;
            total = fluidCheck + laborCost + tax;
            File.Write("Labor Costs: " + laborCost.ToString("c") + "\n");
            File.Write("Parts Used: " + partsUsed + "\n");
            File.Write("Total: " + total.ToString("c") + "\n");
            File.Write("Vehicle Information: " + modelTextBox.Text + "\n");
            File.Write("Customer Information: " + customerTextBox.Text);
            File.Close();
        }
    }
}
