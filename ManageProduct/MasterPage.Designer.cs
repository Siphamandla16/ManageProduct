
namespace ManageProduct
{
    partial class MasterPage
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
            this.btnManageProduct = new System.Windows.Forms.Button();
            this.Supplier = new System.Windows.Forms.Button();
            this.btnCatergory = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnManageProduct
            // 
            this.btnManageProduct.Location = new System.Drawing.Point(38, 19);
            this.btnManageProduct.Name = "btnManageProduct";
            this.btnManageProduct.Size = new System.Drawing.Size(197, 32);
            this.btnManageProduct.TabIndex = 0;
            this.btnManageProduct.Text = "Manage Products";
            this.btnManageProduct.UseVisualStyleBackColor = true;
            this.btnManageProduct.Click += new System.EventHandler(this.btnManageProduct_Click);
            // 
            // Supplier
            // 
            this.Supplier.Location = new System.Drawing.Point(411, 19);
            this.Supplier.Name = "Supplier";
            this.Supplier.Size = new System.Drawing.Size(226, 32);
            this.Supplier.TabIndex = 1;
            this.Supplier.Text = "Supplier";
            this.Supplier.UseVisualStyleBackColor = true;
            this.Supplier.Click += new System.EventHandler(this.Supplier_Click);
            // 
            // btnCatergory
            // 
            this.btnCatergory.Location = new System.Drawing.Point(754, 19);
            this.btnCatergory.Name = "btnCatergory";
            this.btnCatergory.Size = new System.Drawing.Size(219, 32);
            this.btnCatergory.TabIndex = 2;
            this.btnCatergory.Text = "Catergory";
            this.btnCatergory.UseVisualStyleBackColor = true;
            this.btnCatergory.Click += new System.EventHandler(this.btnCatergory_Click);
            // 
            // MasterPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(997, 161);
            this.Controls.Add(this.btnCatergory);
            this.Controls.Add(this.Supplier);
            this.Controls.Add(this.btnManageProduct);
            this.Name = "MasterPage";
            this.Text = "MasterPage";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnManageProduct;
        private System.Windows.Forms.Button Supplier;
        private System.Windows.Forms.Button btnCatergory;
    }
}