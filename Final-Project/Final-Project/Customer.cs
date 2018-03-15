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
    public partial class CustomerFrm : Form
    {
        public CustomerFrm()
        {
            InitializeComponent();
        }

        private void tableBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {


        }

        private void CustomerFrm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'customersDataSet1.Table' table. You can move, or remove it, as needed.
            this.tableTableAdapter.Fill(this.customersDataSet1.Table);

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void tableBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.tableBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.customersDataSet1);
        }

        private void tableBindingNavigatorSaveItem_Click_2(object sender, EventArgs e)
        {

            this.Validate();
            this.tableBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.customersDataSet1);
        }

        private void tableBindingNavigatorSaveItem_Click_3(object sender, EventArgs e)
        {

            this.Validate();
            this.tableBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.customersDataSet1);
        }

        private void tableBindingNavigatorSaveItem_Click_4(object sender, EventArgs e)
        {
            this.Validate();
            this.tableBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.customersDataSet1);

        }
    }
}
