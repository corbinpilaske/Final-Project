using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Final_Project
{
    public partial class InvoicesFrm : Form
    {
        public InvoicesFrm()
        {
            InitializeComponent();
        }

        private void invoicesBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.invoicesBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.customersDataSet1);

        }

        private void Invoices_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'customersDataSet1.Invoices' table. You can move, or remove it, as needed.
            this.invoicesTableAdapter.Fill(this.customersDataSet1.Invoices);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Closes the Invoices form
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Creates the Invoices Data form
            InvoicesDataFrm myinvoicesData = new InvoicesDataFrm();
            myinvoicesData.ShowDialog();
        }


    }
}
