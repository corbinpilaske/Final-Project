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


        }

        private void PartsFrm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'partsDataSet.Parts' table. You can move, or remove it, as needed.


        }
    }
}
