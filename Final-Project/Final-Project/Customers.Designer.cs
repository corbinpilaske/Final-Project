namespace Final_Project
{
    partial class CustomersFrm
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label nameLabel;
            System.Windows.Forms.Label addressLabel;
            System.Windows.Forms.Label phone_NumberLabel;
            System.Windows.Forms.Label emailLabel;
            System.Windows.Forms.Label vehicleLabel;
            System.Windows.Forms.Label invoicesLabel;
            System.Windows.Forms.Label alternate_Phone_NumberLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CustomersFrm));
            this.customersDataSet1 = new Final_Project.CustomersDataSet1();
            this.tableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tableTableAdapter = new Final_Project.CustomersDataSet1TableAdapters.TableTableAdapter();
            this.tableAdapterManager = new Final_Project.CustomersDataSet1TableAdapters.TableAdapterManager();
            this.tableBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.tableBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.addressTextBox = new System.Windows.Forms.TextBox();
            this.phone_NumberMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.emailTextBox = new System.Windows.Forms.TextBox();
            this.vehicleTextBox = new System.Windows.Forms.TextBox();
            this.invoicesTextBox = new System.Windows.Forms.TextBox();
            this.alternate_Phone_NumberMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.Customerlbl = new System.Windows.Forms.Label();
            this.CustExitbtn = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.searchTextBox = new System.Windows.Forms.TextBox();
            nameLabel = new System.Windows.Forms.Label();
            addressLabel = new System.Windows.Forms.Label();
            phone_NumberLabel = new System.Windows.Forms.Label();
            emailLabel = new System.Windows.Forms.Label();
            vehicleLabel = new System.Windows.Forms.Label();
            invoicesLabel = new System.Windows.Forms.Label();
            alternate_Phone_NumberLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.customersDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableBindingNavigator)).BeginInit();
            this.tableBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Location = new System.Drawing.Point(18, 92);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new System.Drawing.Size(38, 13);
            nameLabel.TabIndex = 1;
            nameLabel.Text = "Name:";
            // 
            // addressLabel
            // 
            addressLabel.AutoSize = true;
            addressLabel.Location = new System.Drawing.Point(18, 118);
            addressLabel.Name = "addressLabel";
            addressLabel.Size = new System.Drawing.Size(48, 13);
            addressLabel.TabIndex = 3;
            addressLabel.Text = "Address:";
            // 
            // phone_NumberLabel
            // 
            phone_NumberLabel.AutoSize = true;
            phone_NumberLabel.Location = new System.Drawing.Point(18, 144);
            phone_NumberLabel.Name = "phone_NumberLabel";
            phone_NumberLabel.Size = new System.Drawing.Size(81, 13);
            phone_NumberLabel.TabIndex = 5;
            phone_NumberLabel.Text = "Phone Number:";
            // 
            // emailLabel
            // 
            emailLabel.AutoSize = true;
            emailLabel.Location = new System.Drawing.Point(18, 170);
            emailLabel.Name = "emailLabel";
            emailLabel.Size = new System.Drawing.Size(35, 13);
            emailLabel.TabIndex = 7;
            emailLabel.Text = "Email:";
            // 
            // vehicleLabel
            // 
            vehicleLabel.AutoSize = true;
            vehicleLabel.Location = new System.Drawing.Point(18, 196);
            vehicleLabel.Name = "vehicleLabel";
            vehicleLabel.Size = new System.Drawing.Size(45, 13);
            vehicleLabel.TabIndex = 9;
            vehicleLabel.Text = "Vehicle:";
            // 
            // invoicesLabel
            // 
            invoicesLabel.AutoSize = true;
            invoicesLabel.Location = new System.Drawing.Point(18, 222);
            invoicesLabel.Name = "invoicesLabel";
            invoicesLabel.Size = new System.Drawing.Size(50, 13);
            invoicesLabel.TabIndex = 11;
            invoicesLabel.Text = "Invoices:";
            // 
            // alternate_Phone_NumberLabel
            // 
            alternate_Phone_NumberLabel.AutoSize = true;
            alternate_Phone_NumberLabel.Location = new System.Drawing.Point(18, 248);
            alternate_Phone_NumberLabel.Name = "alternate_Phone_NumberLabel";
            alternate_Phone_NumberLabel.Size = new System.Drawing.Size(126, 13);
            alternate_Phone_NumberLabel.TabIndex = 13;
            alternate_Phone_NumberLabel.Text = "Alternate Phone Number:";
            // 
            // customersDataSet1
            // 
            this.customersDataSet1.DataSetName = "CustomersDataSet1";
            this.customersDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tableBindingSource
            // 
            this.tableBindingSource.DataMember = "Table";
            this.tableBindingSource.DataSource = this.customersDataSet1;
            // 
            // tableTableAdapter
            // 
            this.tableTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.InvoicesTableAdapter = null;
            this.tableAdapterManager.PartsTableAdapter = null;
            this.tableAdapterManager.TableTableAdapter = this.tableTableAdapter;
            this.tableAdapterManager.UpdateOrder = Final_Project.CustomersDataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.VehicleTableAdapter = null;
            // 
            // tableBindingNavigator
            // 
            this.tableBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.tableBindingNavigator.BindingSource = this.tableBindingSource;
            this.tableBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.tableBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.tableBindingNavigator.Dock = System.Windows.Forms.DockStyle.None;
            this.tableBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.tableBindingNavigatorSaveItem});
            this.tableBindingNavigator.Location = new System.Drawing.Point(9, 61);
            this.tableBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.tableBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.tableBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.tableBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.tableBindingNavigator.Name = "tableBindingNavigator";
            this.tableBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.tableBindingNavigator.Size = new System.Drawing.Size(278, 25);
            this.tableBindingNavigator.TabIndex = 0;
            this.tableBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 22);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // tableBindingNavigatorSaveItem
            // 
            this.tableBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tableBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("tableBindingNavigatorSaveItem.Image")));
            this.tableBindingNavigatorSaveItem.Name = "tableBindingNavigatorSaveItem";
            this.tableBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.tableBindingNavigatorSaveItem.Text = "Save Data";
            this.tableBindingNavigatorSaveItem.Click += new System.EventHandler(this.tableBindingNavigatorSaveItem_Click);
            // 
            // nameTextBox
            // 
            this.nameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tableBindingSource, "Name", true));
            this.nameTextBox.Location = new System.Drawing.Point(150, 89);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(260, 20);
            this.nameTextBox.TabIndex = 2;
            // 
            // addressTextBox
            // 
            this.addressTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tableBindingSource, "Address", true));
            this.addressTextBox.Location = new System.Drawing.Point(150, 115);
            this.addressTextBox.Name = "addressTextBox";
            this.addressTextBox.Size = new System.Drawing.Size(260, 20);
            this.addressTextBox.TabIndex = 4;
            // 
            // phone_NumberMaskedTextBox
            // 
            this.phone_NumberMaskedTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tableBindingSource, "Phone Number", true));
            this.phone_NumberMaskedTextBox.Location = new System.Drawing.Point(150, 141);
            this.phone_NumberMaskedTextBox.Mask = "(999) 000-0000";
            this.phone_NumberMaskedTextBox.Name = "phone_NumberMaskedTextBox";
            this.phone_NumberMaskedTextBox.Size = new System.Drawing.Size(260, 20);
            this.phone_NumberMaskedTextBox.TabIndex = 6;
            // 
            // emailTextBox
            // 
            this.emailTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tableBindingSource, "Email", true));
            this.emailTextBox.Location = new System.Drawing.Point(150, 167);
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.Size = new System.Drawing.Size(260, 20);
            this.emailTextBox.TabIndex = 8;
            // 
            // vehicleTextBox
            // 
            this.vehicleTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tableBindingSource, "Vehicle", true));
            this.vehicleTextBox.Location = new System.Drawing.Point(150, 193);
            this.vehicleTextBox.Name = "vehicleTextBox";
            this.vehicleTextBox.Size = new System.Drawing.Size(260, 20);
            this.vehicleTextBox.TabIndex = 10;
            // 
            // invoicesTextBox
            // 
            this.invoicesTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tableBindingSource, "Invoices", true));
            this.invoicesTextBox.Location = new System.Drawing.Point(150, 219);
            this.invoicesTextBox.Name = "invoicesTextBox";
            this.invoicesTextBox.Size = new System.Drawing.Size(260, 20);
            this.invoicesTextBox.TabIndex = 12;
            // 
            // alternate_Phone_NumberMaskedTextBox
            // 
            this.alternate_Phone_NumberMaskedTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tableBindingSource, "Alternate Phone Number", true));
            this.alternate_Phone_NumberMaskedTextBox.Location = new System.Drawing.Point(150, 245);
            this.alternate_Phone_NumberMaskedTextBox.Mask = "(999) 000-0000";
            this.alternate_Phone_NumberMaskedTextBox.Name = "alternate_Phone_NumberMaskedTextBox";
            this.alternate_Phone_NumberMaskedTextBox.Size = new System.Drawing.Size(260, 20);
            this.alternate_Phone_NumberMaskedTextBox.TabIndex = 14;
            // 
            // Customerlbl
            // 
            this.Customerlbl.AutoSize = true;
            this.Customerlbl.Font = new System.Drawing.Font("Lucida Sans", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Customerlbl.Location = new System.Drawing.Point(12, 9);
            this.Customerlbl.Name = "Customerlbl";
            this.Customerlbl.Size = new System.Drawing.Size(117, 22);
            this.Customerlbl.TabIndex = 15;
            this.Customerlbl.Text = "Customers";
            // 
            // CustExitbtn
            // 
            this.CustExitbtn.Font = new System.Drawing.Font("Lucida Sans", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CustExitbtn.Location = new System.Drawing.Point(381, 287);
            this.CustExitbtn.Name = "CustExitbtn";
            this.CustExitbtn.Size = new System.Drawing.Size(75, 23);
            this.CustExitbtn.TabIndex = 16;
            this.CustExitbtn.Text = "Close";
            this.CustExitbtn.UseVisualStyleBackColor = true;
            this.CustExitbtn.Click += new System.EventHandler(this.CustExitbtn_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(150, 284);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 17;
            this.button1.Text = "Search";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // searchTextBox
            // 
            this.searchTextBox.Location = new System.Drawing.Point(16, 286);
            this.searchTextBox.Name = "searchTextBox";
            this.searchTextBox.Size = new System.Drawing.Size(128, 20);
            this.searchTextBox.TabIndex = 18;
            // 
            // CustomersFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SandyBrown;
            this.ClientSize = new System.Drawing.Size(468, 322);
            this.Controls.Add(this.searchTextBox);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.CustExitbtn);
            this.Controls.Add(this.Customerlbl);
            this.Controls.Add(nameLabel);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(addressLabel);
            this.Controls.Add(this.addressTextBox);
            this.Controls.Add(phone_NumberLabel);
            this.Controls.Add(this.phone_NumberMaskedTextBox);
            this.Controls.Add(emailLabel);
            this.Controls.Add(this.emailTextBox);
            this.Controls.Add(vehicleLabel);
            this.Controls.Add(this.vehicleTextBox);
            this.Controls.Add(invoicesLabel);
            this.Controls.Add(this.invoicesTextBox);
            this.Controls.Add(alternate_Phone_NumberLabel);
            this.Controls.Add(this.alternate_Phone_NumberMaskedTextBox);
            this.Controls.Add(this.tableBindingNavigator);
            this.Name = "CustomersFrm";
            this.Text = "Customers";
            this.Load += new System.EventHandler(this.Customers_Load);
            ((System.ComponentModel.ISupportInitialize)(this.customersDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableBindingNavigator)).EndInit();
            this.tableBindingNavigator.ResumeLayout(false);
            this.tableBindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CustomersDataSet1 customersDataSet1;
        private System.Windows.Forms.BindingSource tableBindingSource;
        private CustomersDataSet1TableAdapters.TableTableAdapter tableTableAdapter;
        private CustomersDataSet1TableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator tableBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton tableBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.TextBox addressTextBox;
        private System.Windows.Forms.MaskedTextBox phone_NumberMaskedTextBox;
        private System.Windows.Forms.TextBox emailTextBox;
        private System.Windows.Forms.TextBox vehicleTextBox;
        private System.Windows.Forms.TextBox invoicesTextBox;
        private System.Windows.Forms.MaskedTextBox alternate_Phone_NumberMaskedTextBox;
        private System.Windows.Forms.Label Customerlbl;
        private System.Windows.Forms.Button CustExitbtn;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox searchTextBox;
    }
}