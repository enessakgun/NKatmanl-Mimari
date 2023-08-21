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
            this.gbxProductAdd = new System.Windows.Forms.GroupBox();
            this.lblProductName2 = new System.Windows.Forms.Label();
            this.lblCategoryId = new System.Windows.Forms.Label();
            this.lblUnitPrice = new System.Windows.Forms.Label();
            this.lblStock = new System.Windows.Forms.Label();
            this.lblQuantityPerUnit = new System.Windows.Forms.Label();
            this.tbxProductName2 = new System.Windows.Forms.TextBox();
            this.cbxCategoryId = new System.Windows.Forms.ComboBox();
            this.tbxStock = new System.Windows.Forms.TextBox();
            this.tbxQuantityPerUnit = new System.Windows.Forms.TextBox();
            this.tbxUnitPrice = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.tbxUnitPriceUpdate = new System.Windows.Forms.TextBox();
            this.tbxQuantityPerUnitUpdate = new System.Windows.Forms.TextBox();
            this.tbxUnitStockUpdate = new System.Windows.Forms.TextBox();
            this.cbxCategoryIdUpdate = new System.Windows.Forms.ComboBox();
            this.tbxUpdateProductName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnRemove = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgwProduct)).BeginInit();
            this.gbxcategory.SuspendLayout();
            this.gbxproductname.SuspendLayout();
            this.gbxProductAdd.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgwProduct
            // 
            this.dgwProduct.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwProduct.Location = new System.Drawing.Point(12, 304);
            this.dgwProduct.Name = "dgwProduct";
            this.dgwProduct.RowHeadersWidth = 51;
            this.dgwProduct.RowTemplate.Height = 24;
            this.dgwProduct.Size = new System.Drawing.Size(1078, 119);
            this.dgwProduct.TabIndex = 0;
            this.dgwProduct.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgwProduct_CellClick);
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
            this.tbxProductName.TextChanged += new System.EventHandler(this.tbxProductName_TextChanged);
            // 
            // cbxcategory
            // 
            this.cbxcategory.FormattingEnabled = true;
            this.cbxcategory.Location = new System.Drawing.Point(127, 52);
            this.cbxcategory.Name = "cbxcategory";
            this.cbxcategory.Size = new System.Drawing.Size(310, 24);
            this.cbxcategory.TabIndex = 1;
            this.cbxcategory.SelectedIndexChanged += new System.EventHandler(this.cbxcategory_SelectedIndexChanged);
            // 
            // gbxProductAdd
            // 
            this.gbxProductAdd.Controls.Add(this.btnAdd);
            this.gbxProductAdd.Controls.Add(this.tbxUnitPrice);
            this.gbxProductAdd.Controls.Add(this.tbxQuantityPerUnit);
            this.gbxProductAdd.Controls.Add(this.tbxStock);
            this.gbxProductAdd.Controls.Add(this.cbxCategoryId);
            this.gbxProductAdd.Controls.Add(this.tbxProductName2);
            this.gbxProductAdd.Controls.Add(this.lblQuantityPerUnit);
            this.gbxProductAdd.Controls.Add(this.lblStock);
            this.gbxProductAdd.Controls.Add(this.lblUnitPrice);
            this.gbxProductAdd.Controls.Add(this.lblCategoryId);
            this.gbxProductAdd.Controls.Add(this.lblProductName2);
            this.gbxProductAdd.Location = new System.Drawing.Point(13, 469);
            this.gbxProductAdd.Name = "gbxProductAdd";
            this.gbxProductAdd.Size = new System.Drawing.Size(1077, 193);
            this.gbxProductAdd.TabIndex = 3;
            this.gbxProductAdd.TabStop = false;
            this.gbxProductAdd.Text = "Yeni Ürün Ekle ";
            // 
            // lblProductName2
            // 
            this.lblProductName2.AutoSize = true;
            this.lblProductName2.Location = new System.Drawing.Point(27, 41);
            this.lblProductName2.Name = "lblProductName2";
            this.lblProductName2.Size = new System.Drawing.Size(58, 16);
            this.lblProductName2.TabIndex = 0;
            this.lblProductName2.Text = "Ürün Adı";
            // 
            // lblCategoryId
            // 
            this.lblCategoryId.AutoSize = true;
            this.lblCategoryId.Location = new System.Drawing.Point(27, 93);
            this.lblCategoryId.Name = "lblCategoryId";
            this.lblCategoryId.Size = new System.Drawing.Size(57, 16);
            this.lblCategoryId.TabIndex = 1;
            this.lblCategoryId.Text = "Kategori";
            // 
            // lblUnitPrice
            // 
            this.lblUnitPrice.AutoSize = true;
            this.lblUnitPrice.Location = new System.Drawing.Point(27, 147);
            this.lblUnitPrice.Name = "lblUnitPrice";
            this.lblUnitPrice.Size = new System.Drawing.Size(36, 16);
            this.lblUnitPrice.TabIndex = 2;
            this.lblUnitPrice.Text = "Fiyat";
            // 
            // lblStock
            // 
            this.lblStock.AutoSize = true;
            this.lblStock.Location = new System.Drawing.Point(598, 41);
            this.lblStock.Name = "lblStock";
            this.lblStock.Size = new System.Drawing.Size(73, 16);
            this.lblStock.TabIndex = 3;
            this.lblStock.Text = "Stok Adedi";
            this.lblStock.Click += new System.EventHandler(this.aaa_Click);
            // 
            // lblQuantityPerUnit
            // 
            this.lblQuantityPerUnit.AutoSize = true;
            this.lblQuantityPerUnit.Location = new System.Drawing.Point(595, 93);
            this.lblQuantityPerUnit.Name = "lblQuantityPerUnit";
            this.lblQuantityPerUnit.Size = new System.Drawing.Size(76, 16);
            this.lblQuantityPerUnit.TabIndex = 4;
            this.lblQuantityPerUnit.Text = "Birim Adedi";
            // 
            // tbxProductName2
            // 
            this.tbxProductName2.Location = new System.Drawing.Point(121, 41);
            this.tbxProductName2.Name = "tbxProductName2";
            this.tbxProductName2.Size = new System.Drawing.Size(255, 22);
            this.tbxProductName2.TabIndex = 5;
            // 
            // cbxCategoryId
            // 
            this.cbxCategoryId.FormattingEnabled = true;
            this.cbxCategoryId.Location = new System.Drawing.Point(121, 84);
            this.cbxCategoryId.Name = "cbxCategoryId";
            this.cbxCategoryId.Size = new System.Drawing.Size(255, 24);
            this.cbxCategoryId.TabIndex = 6;
            // 
            // tbxStock
            // 
            this.tbxStock.Location = new System.Drawing.Point(697, 40);
            this.tbxStock.Name = "tbxStock";
            this.tbxStock.Size = new System.Drawing.Size(258, 22);
            this.tbxStock.TabIndex = 7;
            // 
            // tbxQuantityPerUnit
            // 
            this.tbxQuantityPerUnit.Location = new System.Drawing.Point(697, 93);
            this.tbxQuantityPerUnit.Name = "tbxQuantityPerUnit";
            this.tbxQuantityPerUnit.Size = new System.Drawing.Size(258, 22);
            this.tbxQuantityPerUnit.TabIndex = 8;
            // 
            // tbxUnitPrice
            // 
            this.tbxUnitPrice.Location = new System.Drawing.Point(121, 141);
            this.tbxUnitPrice.Name = "tbxUnitPrice";
            this.tbxUnitPrice.Size = new System.Drawing.Size(255, 22);
            this.tbxUnitPrice.TabIndex = 9;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(697, 147);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(244, 38);
            this.btnAdd.TabIndex = 10;
            this.btnAdd.Text = "Ekle";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnUpdate);
            this.groupBox1.Controls.Add(this.tbxUnitPriceUpdate);
            this.groupBox1.Controls.Add(this.tbxQuantityPerUnitUpdate);
            this.groupBox1.Controls.Add(this.tbxUnitStockUpdate);
            this.groupBox1.Controls.Add(this.cbxCategoryIdUpdate);
            this.groupBox1.Controls.Add(this.tbxUpdateProductName);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Location = new System.Drawing.Point(13, 707);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1077, 191);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ürün Güncelle";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter_1);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(697, 147);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(244, 38);
            this.btnUpdate.TabIndex = 10;
            this.btnUpdate.Text = "Güncelle";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // tbxUnitPriceUpdate
            // 
            this.tbxUnitPriceUpdate.Location = new System.Drawing.Point(121, 141);
            this.tbxUnitPriceUpdate.Name = "tbxUnitPriceUpdate";
            this.tbxUnitPriceUpdate.Size = new System.Drawing.Size(255, 22);
            this.tbxUnitPriceUpdate.TabIndex = 9;
            // 
            // tbxQuantityPerUnitUpdate
            // 
            this.tbxQuantityPerUnitUpdate.Location = new System.Drawing.Point(697, 93);
            this.tbxQuantityPerUnitUpdate.Name = "tbxQuantityPerUnitUpdate";
            this.tbxQuantityPerUnitUpdate.Size = new System.Drawing.Size(258, 22);
            this.tbxQuantityPerUnitUpdate.TabIndex = 8;
            // 
            // tbxUnitStockUpdate
            // 
            this.tbxUnitStockUpdate.Location = new System.Drawing.Point(697, 40);
            this.tbxUnitStockUpdate.Name = "tbxUnitStockUpdate";
            this.tbxUnitStockUpdate.Size = new System.Drawing.Size(258, 22);
            this.tbxUnitStockUpdate.TabIndex = 7;
            // 
            // cbxCategoryIdUpdate
            // 
            this.cbxCategoryIdUpdate.FormattingEnabled = true;
            this.cbxCategoryIdUpdate.Location = new System.Drawing.Point(121, 84);
            this.cbxCategoryIdUpdate.Name = "cbxCategoryIdUpdate";
            this.cbxCategoryIdUpdate.Size = new System.Drawing.Size(255, 24);
            this.cbxCategoryIdUpdate.TabIndex = 6;
            // 
            // tbxUpdateProductName
            // 
            this.tbxUpdateProductName.Location = new System.Drawing.Point(121, 41);
            this.tbxUpdateProductName.Name = "tbxUpdateProductName";
            this.tbxUpdateProductName.Size = new System.Drawing.Size(255, 22);
            this.tbxUpdateProductName.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(595, 93);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "Birim Adedi";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(598, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Stok Adedi";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 147);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Fiyat";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(27, 93);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 16);
            this.label4.TabIndex = 1;
            this.label4.Text = "Kategori";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(27, 41);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 16);
            this.label5.TabIndex = 0;
            this.label5.Text = "Ürün Adı";
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(901, 440);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(189, 23);
            this.btnRemove.TabIndex = 5;
            this.btnRemove.Text = "sil";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1108, 1006);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gbxProductAdd);
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
            this.gbxProductAdd.ResumeLayout(false);
            this.gbxProductAdd.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
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
        private System.Windows.Forms.GroupBox gbxProductAdd;
        private System.Windows.Forms.Label lblStock;
        private System.Windows.Forms.Label lblUnitPrice;
        private System.Windows.Forms.Label lblCategoryId;
        private System.Windows.Forms.Label lblProductName2;
        private System.Windows.Forms.Label lblQuantityPerUnit;
        private System.Windows.Forms.TextBox tbxUnitPrice;
        private System.Windows.Forms.TextBox tbxQuantityPerUnit;
        private System.Windows.Forms.TextBox tbxStock;
        private System.Windows.Forms.ComboBox cbxCategoryId;
        private System.Windows.Forms.TextBox tbxProductName2;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.TextBox tbxUnitPriceUpdate;
        private System.Windows.Forms.TextBox tbxQuantityPerUnitUpdate;
        private System.Windows.Forms.TextBox tbxUnitStockUpdate;
        private System.Windows.Forms.ComboBox cbxCategoryIdUpdate;
        private System.Windows.Forms.TextBox tbxUpdateProductName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnRemove;
    }
}

