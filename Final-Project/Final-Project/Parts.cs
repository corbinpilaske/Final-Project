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
    public partial class PartsFrm : Form
    {
        public PartsFrm()
        {
            InitializeComponent();
        }

        private void partsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.partsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.customersDataSet1);

        }

        private void Parts_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'customersDataSet1.Parts' table. You can move, or remove it, as needed.
            this.partsTableAdapter.Fill(this.customersDataSet1.Parts);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Closes the Parts form
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Searches for Part
            this.partsTableAdapter.GetPartName(
                this.customersDataSet1.Parts, textBoxParts.Text);
        }
    }
}
