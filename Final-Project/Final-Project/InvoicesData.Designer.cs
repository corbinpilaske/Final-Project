namespace Final_Project
{
    partial class InvoicesDataFrm
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
            System.Windows.Forms.Label invoicesIDLabel;
            System.Windows.Forms.Label parts_UsedLabel;
            System.Windows.Forms.Label customerLabel;
            System.Windows.Forms.Label labor_CostsLabel;
            System.Windows.Forms.Label totalLabel;
            System.Windows.Forms.Label taxLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InvoicesDataFrm));
            System.Windows.Forms.Label label4;
            System.Windows.Forms.Label modelLabel;
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.invoicesBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.invoicesBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.invoicesIDTextBox = new System.Windows.Forms.TextBox();
            this.parts_UsedTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.checkBoxEstimate = new System.Windows.Forms.CheckBox();
            this.checkBoxInvoice = new System.Windows.Forms.CheckBox();
            this.checkBoxFC = new System.Windows.Forms.CheckBox();
            this.customerTextBox = new System.Windows.Forms.TextBox();
            this.invoiceSearch = new System.Windows.Forms.Button();
            this.textBoxInvoice = new System.Windows.Forms.TextBox();
            this.labor_CostsMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.totalMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.taxMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.invoicesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.customersDataSet1 = new Final_Project.CustomersDataSet1();
            this.invoicesTableAdapter = new Final_Project.CustomersDataSet1TableAdapters.InvoicesTableAdapter();
            this.tableAdapterManager = new Final_Project.CustomersDataSet1TableAdapters.TableAdapterManager();
            this.modelTextBox = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            invoicesIDLabel = new System.Windows.Forms.Label();
            parts_UsedLabel = new System.Windows.Forms.Label();
            customerLabel = new System.Windows.Forms.Label();
            labor_CostsLabel = new System.Windows.Forms.Label();
            totalLabel = new System.Windows.Forms.Label();
            taxLabel = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            modelLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.invoicesBindingNavigator)).BeginInit();
            this.invoicesBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.invoicesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customersDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // invoicesIDLabel
            // 
            invoicesIDLabel.AutoSize = true;
            invoicesIDLabel.Font = new System.Drawing.Font("Lucida Sans", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            invoicesIDLabel.Location = new System.Drawing.Point(12, 256);
            invoicesIDLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            invoicesIDLabel.Name = "invoicesIDLabel";
            invoicesIDLabel.Size = new System.Drawing.Size(83, 13);
            invoicesIDLabel.TabIndex = 17;
            invoicesIDLabel.Text = "Invoices ID:";
            // 
            // parts_UsedLabel
            // 
            parts_UsedLabel.AutoSize = true;
            parts_UsedLabel.Font = new System.Drawing.Font("Lucida Sans", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            parts_UsedLabel.Location = new System.Drawing.Point(15, 317);
            parts_UsedLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            parts_UsedLabel.Name = "parts_UsedLabel";
            parts_UsedLabel.Size = new System.Drawing.Size(80, 13);
            parts_UsedLabel.TabIndex = 21;
            parts_UsedLabel.Text = "Parts Used:";
            // 
            // customerLabel
            // 
            customerLabel.AutoSize = true;
            customerLabel.Font = new System.Drawing.Font("Lucida Sans", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            customerLabel.Location = new System.Drawing.Point(19, 227);
            customerLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            customerLabel.Name = "customerLabel";
            customerLabel.Size = new System.Drawing.Size(76, 13);
            customerLabel.TabIndex = 32;
            customerLabel.Text = "Customer:";
            // 
            // labor_CostsLabel
            // 
            labor_CostsLabel.AutoSize = true;
            labor_CostsLabel.Font = new System.Drawing.Font("Lucida Sans", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            labor_CostsLabel.Location = new System.Drawing.Point(4, 287);
            labor_CostsLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            labor_CostsLabel.Name = "labor_CostsLabel";
            labor_CostsLabel.Size = new System.Drawing.Size(90, 13);
            labor_CostsLabel.TabIndex = 36;
            labor_CostsLabel.Text = "Labor Costs:";
            // 
            // totalLabel
            // 
            totalLabel.AutoSize = true;
            totalLabel.Font = new System.Drawing.Font("Lucida Sans", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            totalLabel.Location = new System.Drawing.Point(49, 365);
            totalLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            totalLabel.Name = "totalLabel";
            totalLabel.Size = new System.Drawing.Size(46, 13);
            totalLabel.TabIndex = 37;
            totalLabel.Text = "Total:";
            // 
            // taxLabel
            // 
            taxLabel.AutoSize = true;
            taxLabel.Font = new System.Drawing.Font("Lucida Sans", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            taxLabel.Location = new System.Drawing.Point(62, 339);
            taxLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            taxLabel.Name = "taxLabel";
            taxLabel.Size = new System.Drawing.Size(33, 13);
            taxLabel.TabIndex = 38;
            taxLabel.Text = "Tax:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Lucida Sans", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(171, 39);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(189, 22);
            this.label2.TabIndex = 1;
            this.label2.Text = "Joe\'s Automotives";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(453, 464);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 23);
            this.button1.TabIndex = 16;
            this.button1.Text = "Close";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // invoicesBindingNavigator
            // 
            this.invoicesBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.invoicesBindingNavigator.BindingSource = this.invoicesBindingSource;
            this.invoicesBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.invoicesBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.invoicesBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.invoicesBindingNavigatorSaveItem});
            this.invoicesBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.invoicesBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.invoicesBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.invoicesBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.invoicesBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.invoicesBindingNavigator.Name = "invoicesBindingNavigator";
            this.invoicesBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.invoicesBindingNavigator.Size = new System.Drawing.Size(573, 25);
            this.invoicesBindingNavigator.TabIndex = 17;
            this.invoicesBindingNavigator.Text = "bindingNavigator1";
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
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(65, 23);
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
            // invoicesBindingNavigatorSaveItem
            // 
            this.invoicesBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.invoicesBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("invoicesBindingNavigatorSaveItem.Image")));
            this.invoicesBindingNavigatorSaveItem.Name = "invoicesBindingNavigatorSaveItem";
            this.invoicesBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.invoicesBindingNavigatorSaveItem.Text = "Save Data";
            this.invoicesBindingNavigatorSaveItem.Click += new System.EventHandler(this.invoicesBindingNavigatorSaveItem_Click);
            // 
            // invoicesIDTextBox
            // 
            this.invoicesIDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.invoicesBindingSource, "InvoicesID", true));
            this.invoicesIDTextBox.Location = new System.Drawing.Point(144, 256);
            this.invoicesIDTextBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.invoicesIDTextBox.Name = "invoicesIDTextBox";
            this.invoicesIDTextBox.Size = new System.Drawing.Size(245, 22);
            this.invoicesIDTextBox.TabIndex = 18;
            // 
            // parts_UsedTextBox
            // 
            this.parts_UsedTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.invoicesBindingSource, "Parts Used", true));
            this.parts_UsedTextBox.Location = new System.Drawing.Point(143, 310);
            this.parts_UsedTextBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.parts_UsedTextBox.Name = "parts_UsedTextBox";
            this.parts_UsedTextBox.Size = new System.Drawing.Size(245, 22);
            this.parts_UsedTextBox.TabIndex = 22;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lucida Sans", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(19, 76);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(166, 18);
            this.label1.TabIndex = 25;
            this.label1.Text = "Vehicle Information";
            // 
            // checkBoxEstimate
            // 
            this.checkBoxEstimate.AutoSize = true;
            this.checkBoxEstimate.Font = new System.Drawing.Font("Lucida Sans", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxEstimate.Location = new System.Drawing.Point(39, 404);
            this.checkBoxEstimate.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.checkBoxEstimate.Name = "checkBoxEstimate";
            this.checkBoxEstimate.Size = new System.Drawing.Size(86, 17);
            this.checkBoxEstimate.TabIndex = 26;
            this.checkBoxEstimate.Text = "Estimate";
            this.checkBoxEstimate.UseVisualStyleBackColor = true;
            // 
            // checkBoxInvoice
            // 
            this.checkBoxInvoice.AutoSize = true;
            this.checkBoxInvoice.Font = new System.Drawing.Font("Lucida Sans", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxInvoice.Location = new System.Drawing.Point(168, 404);
            this.checkBoxInvoice.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.checkBoxInvoice.Name = "checkBoxInvoice";
            this.checkBoxInvoice.Size = new System.Drawing.Size(73, 17);
            this.checkBoxInvoice.TabIndex = 27;
            this.checkBoxInvoice.Text = "Invoice";
            this.checkBoxInvoice.UseVisualStyleBackColor = true;
            // 
            // checkBoxFC
            // 
            this.checkBoxFC.AutoSize = true;
            this.checkBoxFC.Font = new System.Drawing.Font("Lucida Sans", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxFC.Location = new System.Drawing.Point(65, 150);
            this.checkBoxFC.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.checkBoxFC.Name = "checkBoxFC";
            this.checkBoxFC.Size = new System.Drawing.Size(164, 17);
            this.checkBoxFC.TabIndex = 28;
            this.checkBoxFC.Text = "Fluid Checkup $24.99";
            this.checkBoxFC.UseVisualStyleBackColor = true;
            // 
            // customerTextBox
            // 
            this.customerTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.invoicesBindingSource, "Customer", true));
            this.customerTextBox.Location = new System.Drawing.Point(143, 227);
            this.customerTextBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.customerTextBox.Name = "customerTextBox";
            this.customerTextBox.Size = new System.Drawing.Size(245, 22);
            this.customerTextBox.TabIndex = 33;
            // 
            // invoiceSearch
            // 
            this.invoiceSearch.Location = new System.Drawing.Point(176, 456);
            this.invoiceSearch.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.invoiceSearch.Name = "invoiceSearch";
            this.invoiceSearch.Size = new System.Drawing.Size(100, 23);
            this.invoiceSearch.TabIndex = 35;
            this.invoiceSearch.Text = "Search";
            this.invoiceSearch.UseVisualStyleBackColor = true;
            this.invoiceSearch.Click += new System.EventHandler(this.invoiceSearch_Click);
            // 
            // textBoxInvoice
            // 
            this.textBoxInvoice.Location = new System.Drawing.Point(16, 456);
            this.textBoxInvoice.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.textBoxInvoice.Name = "textBoxInvoice";
            this.textBoxInvoice.Size = new System.Drawing.Size(151, 22);
            this.textBoxInvoice.TabIndex = 36;
            // 
            // labor_CostsMaskedTextBox
            // 
            this.labor_CostsMaskedTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.invoicesBindingSource, "Labor Costs", true));
            this.labor_CostsMaskedTextBox.Location = new System.Drawing.Point(143, 284);
            this.labor_CostsMaskedTextBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.labor_CostsMaskedTextBox.Name = "labor_CostsMaskedTextBox";
            this.labor_CostsMaskedTextBox.Size = new System.Drawing.Size(245, 22);
            this.labor_CostsMaskedTextBox.TabIndex = 37;
            // 
            // totalMaskedTextBox
            // 
            this.totalMaskedTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.invoicesBindingSource, "Total", true));
            this.totalMaskedTextBox.Location = new System.Drawing.Point(143, 362);
            this.totalMaskedTextBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.totalMaskedTextBox.Name = "totalMaskedTextBox";
            this.totalMaskedTextBox.Size = new System.Drawing.Size(245, 22);
            this.totalMaskedTextBox.TabIndex = 38;
            // 
            // taxMaskedTextBox
            // 
            this.taxMaskedTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.invoicesBindingSource, "Tax", true));
            this.taxMaskedTextBox.Location = new System.Drawing.Point(143, 336);
            this.taxMaskedTextBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.taxMaskedTextBox.Name = "taxMaskedTextBox";
            this.taxMaskedTextBox.Size = new System.Drawing.Size(245, 22);
            this.taxMaskedTextBox.TabIndex = 39;
            // 
            // invoicesBindingSource
            // 
            this.invoicesBindingSource.DataMember = "Invoices";
            this.invoicesBindingSource.DataSource = this.customersDataSet1;
            // 
            // customersDataSet1
            // 
            this.customersDataSet1.DataSetName = "CustomersDataSet1";
            this.customersDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // invoicesTableAdapter
            // 
            this.invoicesTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.InvoicesTableAdapter = this.invoicesTableAdapter;
            this.tableAdapterManager.PartsTableAdapter = null;
            this.tableAdapterManager.TableTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Final_Project.CustomersDataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.VehicleTableAdapter = null;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new System.Drawing.Font("Lucida Sans", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label4.Location = new System.Drawing.Point(15, 186);
            label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(124, 18);
            label4.TabIndex = 40;
            label4.Text = "Customer Info";
            // 
            // modelLabel
            // 
            modelLabel.AutoSize = true;
            modelLabel.Location = new System.Drawing.Point(43, 114);
            modelLabel.Name = "modelLabel";
            modelLabel.Size = new System.Drawing.Size(52, 13);
            modelLabel.TabIndex = 40;
            modelLabel.Text = "Model:";
            // 
            // modelTextBox
            // 
            this.modelTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.invoicesBindingSource, "Model", true));
            this.modelTextBox.Location = new System.Drawing.Point(144, 111);
            this.modelTextBox.Name = "modelTextBox";
            this.modelTextBox.Size = new System.Drawing.Size(244, 22);
            this.modelTextBox.TabIndex = 41;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(290, 456);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(99, 23);
            this.btnSave.TabIndex = 42;
            this.btnSave.Text = "Save Invoice";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.button2_Click);
            // 
            // InvoicesDataFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCoral;
            this.ClientSize = new System.Drawing.Size(573, 507);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(modelLabel);
            this.Controls.Add(this.modelTextBox);
            this.Controls.Add(label4);
            this.Controls.Add(taxLabel);
            this.Controls.Add(this.taxMaskedTextBox);
            this.Controls.Add(totalLabel);
            this.Controls.Add(this.totalMaskedTextBox);
            this.Controls.Add(labor_CostsLabel);
            this.Controls.Add(this.labor_CostsMaskedTextBox);
            this.Controls.Add(this.textBoxInvoice);
            this.Controls.Add(this.invoiceSearch);
            this.Controls.Add(customerLabel);
            this.Controls.Add(this.customerTextBox);
            this.Controls.Add(this.checkBoxFC);
            this.Controls.Add(this.checkBoxInvoice);
            this.Controls.Add(this.checkBoxEstimate);
            this.Controls.Add(this.label1);
            this.Controls.Add(invoicesIDLabel);
            this.Controls.Add(this.invoicesIDTextBox);
            this.Controls.Add(parts_UsedLabel);
            this.Controls.Add(this.parts_UsedTextBox);
            this.Controls.Add(this.invoicesBindingNavigator);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Font = new System.Drawing.Font("Lucida Sans", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "InvoicesDataFrm";
            this.Text = "InvoicesData";
            this.Load += new System.EventHandler(this.InvoicesDataFrm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.invoicesBindingNavigator)).EndInit();
            this.invoicesBindingNavigator.ResumeLayout(false);
            this.invoicesBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.invoicesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customersDataSet1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private CustomersDataSet1 customersDataSet1;
        private System.Windows.Forms.BindingSource invoicesBindingSource;
        private CustomersDataSet1TableAdapters.InvoicesTableAdapter invoicesTableAdapter;
        private CustomersDataSet1TableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator invoicesBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton invoicesBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox invoicesIDTextBox;
        private System.Windows.Forms.TextBox parts_UsedTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox checkBoxEstimate;
        private System.Windows.Forms.CheckBox checkBoxInvoice;
        private System.Windows.Forms.CheckBox checkBoxFC;
        private System.Windows.Forms.TextBox customerTextBox;
        private System.Windows.Forms.Button invoiceSearch;
        private System.Windows.Forms.TextBox textBoxInvoice;
        private System.Windows.Forms.MaskedTextBox labor_CostsMaskedTextBox;
        private System.Windows.Forms.MaskedTextBox totalMaskedTextBox;
        private System.Windows.Forms.MaskedTextBox taxMaskedTextBox;
        private System.Windows.Forms.TextBox modelTextBox;
        private System.Windows.Forms.Button btnSave;
    }
}