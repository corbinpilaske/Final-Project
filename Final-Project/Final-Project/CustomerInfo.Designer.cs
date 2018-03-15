namespace Final_Project
{
    partial class CustomerInfo
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
            this.nameLbl = new System.Windows.Forms.Label();
            this.addressLbl = new System.Windows.Forms.Label();
            this.phoneNumberLbl = new System.Windows.Forms.Label();
            this.emailLbl = new System.Windows.Forms.Label();
            this.customerPictureBox = new System.Windows.Forms.PictureBox();
            this.customerCarPictureBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.customerPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerCarPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // nameLbl
            // 
            this.nameLbl.Location = new System.Drawing.Point(12, 8);
            this.nameLbl.Name = "nameLbl";
            this.nameLbl.Size = new System.Drawing.Size(38, 24);
            this.nameLbl.TabIndex = 0;
            this.nameLbl.Text = "Name:";
            this.nameLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // addressLbl
            // 
            this.addressLbl.AutoSize = true;
            this.addressLbl.Location = new System.Drawing.Point(12, 32);
            this.addressLbl.Name = "addressLbl";
            this.addressLbl.Size = new System.Drawing.Size(48, 13);
            this.addressLbl.TabIndex = 1;
            this.addressLbl.Text = "Address:";
            // 
            // phoneNumberLbl
            // 
            this.phoneNumberLbl.AutoSize = true;
            this.phoneNumberLbl.Font = new System.Drawing.Font("Lucida Sans", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.phoneNumberLbl.Location = new System.Drawing.Point(13, 77);
            this.phoneNumberLbl.Name = "phoneNumberLbl";
            this.phoneNumberLbl.Size = new System.Drawing.Size(93, 12);
            this.phoneNumberLbl.TabIndex = 2;
            this.phoneNumberLbl.Text = "Phone Number:";
            // 
            // emailLbl
            // 
            this.emailLbl.AutoSize = true;
            this.emailLbl.Font = new System.Drawing.Font("Lucida Sans", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emailLbl.Location = new System.Drawing.Point(239, 77);
            this.emailLbl.Name = "emailLbl";
            this.emailLbl.Size = new System.Drawing.Size(37, 14);
            this.emailLbl.TabIndex = 3;
            this.emailLbl.Text = "Email:";
            // 
            // customerPictureBox
            // 
            this.customerPictureBox.Location = new System.Drawing.Point(149, 8);
            this.customerPictureBox.Name = "customerPictureBox";
            this.customerPictureBox.Size = new System.Drawing.Size(100, 50);
            this.customerPictureBox.TabIndex = 4;
            this.customerPictureBox.TabStop = false;
            // 
            // customerCarPictureBox
            // 
            this.customerCarPictureBox.Location = new System.Drawing.Point(274, 8);
            this.customerCarPictureBox.Name = "customerCarPictureBox";
            this.customerCarPictureBox.Size = new System.Drawing.Size(100, 50);
            this.customerCarPictureBox.TabIndex = 5;
            this.customerCarPictureBox.TabStop = false;
            // 
            // CustomerInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(386, 107);
            this.Controls.Add(this.customerCarPictureBox);
            this.Controls.Add(this.customerPictureBox);
            this.Controls.Add(this.emailLbl);
            this.Controls.Add(this.phoneNumberLbl);
            this.Controls.Add(this.addressLbl);
            this.Controls.Add(this.nameLbl);
            this.Name = "CustomerInfo";
            this.Text = "CustomerInfo";
            ((System.ComponentModel.ISupportInitialize)(this.customerPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerCarPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label nameLbl;
        private System.Windows.Forms.Label addressLbl;
        private System.Windows.Forms.Label phoneNumberLbl;
        private System.Windows.Forms.Label emailLbl;
        private System.Windows.Forms.PictureBox customerPictureBox;
        private System.Windows.Forms.PictureBox customerCarPictureBox;
    }
}