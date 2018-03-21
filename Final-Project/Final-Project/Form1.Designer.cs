namespace Final_Project
{
    partial class MainFrm
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
            this.label1 = new System.Windows.Forms.Label();
            this.lblCustomer = new System.Windows.Forms.Label();
            this.lblInvoices = new System.Windows.Forms.Label();
            this.lblVehicle = new System.Windows.Forms.Label();
            this.lblParts = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Lucida Sans", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(12, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(231, 22);
            this.label1.TabIndex = 5;
            this.label1.Text = "Joe\'s Automotive CRM";
            // 
            // lblCustomer
            // 
            this.lblCustomer.AutoSize = true;
            this.lblCustomer.Font = new System.Drawing.Font("Lucida Sans", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCustomer.Location = new System.Drawing.Point(19, 76);
            this.lblCustomer.Name = "lblCustomer";
            this.lblCustomer.Size = new System.Drawing.Size(85, 18);
            this.lblCustomer.TabIndex = 7;
            this.lblCustomer.Text = "Customer";
            this.lblCustomer.Click += new System.EventHandler(this.lblCustomer_Click);
            // 
            // lblInvoices
            // 
            this.lblInvoices.AutoSize = true;
            this.lblInvoices.Font = new System.Drawing.Font("Lucida Sans", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInvoices.Location = new System.Drawing.Point(107, 100);
            this.lblInvoices.Name = "lblInvoices";
            this.lblInvoices.Size = new System.Drawing.Size(71, 18);
            this.lblInvoices.TabIndex = 8;
            this.lblInvoices.Text = "Invoices";
            this.lblInvoices.Click += new System.EventHandler(this.lblInvoices_Click);
            // 
            // lblVehicle
            // 
            this.lblVehicle.AutoSize = true;
            this.lblVehicle.Font = new System.Drawing.Font("Lucida Sans", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVehicle.Location = new System.Drawing.Point(19, 100);
            this.lblVehicle.Name = "lblVehicle";
            this.lblVehicle.Size = new System.Drawing.Size(66, 18);
            this.lblVehicle.TabIndex = 9;
            this.lblVehicle.Text = "Vehicle";
            this.lblVehicle.Click += new System.EventHandler(this.lblVehicle_Click);
            // 
            // lblParts
            // 
            this.lblParts.AutoSize = true;
            this.lblParts.Font = new System.Drawing.Font("Lucida Sans", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblParts.Location = new System.Drawing.Point(107, 76);
            this.lblParts.Name = "lblParts";
            this.lblParts.Size = new System.Drawing.Size(50, 18);
            this.lblParts.TabIndex = 10;
            this.lblParts.Text = "Parts";
            this.lblParts.Click += new System.EventHandler(this.lblParts_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.Transparent;
            this.btnExit.Font = new System.Drawing.Font("Lucida Sans", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(284, 100);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(67, 24);
            this.btnExit.TabIndex = 6;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // MainFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(363, 140);
            this.Controls.Add(this.lblParts);
            this.Controls.Add(this.lblVehicle);
            this.Controls.Add(this.lblInvoices);
            this.Controls.Add(this.lblCustomer);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "MainFrm";
            this.Text = "Home Page";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblCustomer;
        private System.Windows.Forms.Label lblInvoices;
        private System.Windows.Forms.Label lblVehicle;
        private System.Windows.Forms.Label lblParts;
        private System.Windows.Forms.Button btnExit;
    }
}

