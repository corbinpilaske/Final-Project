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
    public partial class MainFrm : Form
    {
        public MainFrm()
        {
            InitializeComponent();
        }

        private void lblCustomer_Click(object sender, EventArgs e)
        {
            // Creates the Customers form
            CustomersFrm myCustomersFrm = new CustomersFrm();
            myCustomersFrm.ShowDialog();
        
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            //Exits the program
            this.Close();
        }

        private void lblVehicle_Click(object sender, EventArgs e)
        {
            // Creates the Vehicles form
            VehiclesFrm myVehiclesFrm = new VehiclesFrm();
            myVehiclesFrm.ShowDialog();
        }

        private void lblParts_Click(object sender, EventArgs e)
        {
            // Creates the Parts form
            PartsFrm mypartsFrm = new PartsFrm();
            mypartsFrm.ShowDialog();
        }

        private void lblInvoices_Click(object sender, EventArgs e)
        {
            // Creates the Invoices form
            InvoicesFrm myinvoicesFrm = new InvoicesFrm();
            myinvoicesFrm.ShowDialog();
        }
    }
}
