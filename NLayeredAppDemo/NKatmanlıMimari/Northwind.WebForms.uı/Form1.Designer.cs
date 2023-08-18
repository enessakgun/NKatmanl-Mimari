namespace Northwind.WebForms.uı
{
    partial class Form1
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
            this.dgwProduct = new System.Windows.Forms.DataGridView();
            this.gbxcategory = new System.Windows.Forms.GroupBox();
            this.gbxproductname = new System.Windows.Forms.GroupBox();
            this.lblcategory = new System.Windows.Forms.Label();
            this.LblProductName = new System.Windows.Forms.Label();
            this.tbxProductName = new System.Windows.Forms.TextBox();
            this.cbxcategory = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgwProduct)).BeginInit();
            this.gbxcategory.SuspendLayout();
            this.gbxproductname.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgwProduct
            // 
            this.dgwProduct.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwProduct.Location = new System.Drawing.Point(12, 325);
            this.dgwProduct.Name = "dgwProduct";
            this.dgwProduct.RowHeadersWidth = 51;
            this.dgwProduct.RowTemplate.Height = 24;
            this.dgwProduct.Size = new System.Drawing.Size(1078, 227);
            this.dgwProduct.TabIndex = 0;
            // 
            // gbxcategory
            // 
            this.gbxcategory.Controls.Add(this.cbxcategory);
            this.gbxcategory.Controls.Add(this.lblcategory);
            this.gbxcategory.Location = new System.Drawing.Point(12, 31);
            this.gbxcategory.Name = "gbxcategory";
            this.gbxcategory.Size = new System.Drawing.Size(1078, 120);
            this.gbxcategory.TabIndex = 1;
            this.gbxcategory.TabStop = false;
            this.gbxcategory.Text = "Katagoriye Göre Ara";
            this.gbxcategory.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // gbxproductname
            // 
            this.gbxproductname.Controls.Add(this.tbxProductName);
            this.gbxproductname.Controls.Add(this.LblProductName);
            this.gbxproductname.Location = new System.Drawing.Point(12, 157);
            this.gbxproductname.Name = "gbxproductname";
            this.gbxproductname.Size = new System.Drawing.Size(1078, 141);
            this.gbxproductname.TabIndex = 2;
            this.gbxproductname.TabStop = false;
            this.gbxproductname.Text = "Ürün AdınaGöre Ara";
            // 
            // lblcategory
            // 
            this.lblcategory.AutoSize = true;
            this.lblcategory.Location = new System.Drawing.Point(28, 52);
            this.lblcategory.Name = "lblcategory";
            this.lblcategory.Size = new System.Drawing.Size(57, 16);
            this.lblcategory.TabIndex = 0;
            this.lblcategory.Text = "Kategori";
            this.lblcategory.Click += new System.EventHandler(this.label1_Click);
            // 
            // LblProductName
            // 
            this.LblProductName.AutoSize = true;
            this.LblProductName.Location = new System.Drawing.Point(28, 77);
            this.LblProductName.Name = "LblProductName";
            this.LblProductName.Size = new System.Drawing.Size(58, 16);
            this.LblProductName.TabIndex = 0;
            this.LblProductName.Text = "Ürün Adı";
            // 
            // tbxProductName
            // 
            this.tbxProductName.Location = new System.Drawing.Point(127, 74);
            this.tbxProductName.Name = "tbxProductName";
            this.tbxProductName.Size = new System.Drawing.Size(310, 22);
            this.tbxProductName.TabIndex = 1;
            // 
            // cbxcategory
            // 
            this.cbxcategory.FormattingEnabled = true;
            this.cbxcategory.Location = new System.Drawing.Point(127, 52);
            this.cbxcategory.Name = "cbxcategory";
            this.cbxcategory.Size = new System.Drawing.Size(310, 24);
            this.cbxcategory.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1102, 578);
            this.Controls.Add(this.gbxproductname);
            this.Controls.Add(this.gbxcategory);
            this.Controls.Add(this.dgwProduct);
            this.Name = "Form1";
            this.Text = "Ürünler";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgwProduct)).EndInit();
            this.gbxcategory.ResumeLayout(false);
            this.gbxcategory.PerformLayout();
            this.gbxproductname.ResumeLayout(false);
            this.gbxproductname.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgwProduct;
        private System.Windows.Forms.GroupBox gbxcategory;
        private System.Windows.Forms.GroupBox gbxproductname;
        private System.Windows.Forms.ComboBox cbxcategory;
        private System.Windows.Forms.Label lblcategory;
        private System.Windows.Forms.TextBox tbxProductName;
        private System.Windows.Forms.Label LblProductName;
    }
}

