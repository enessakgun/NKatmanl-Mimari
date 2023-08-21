using Northwind.Business.Abstract; 
using Northwind.Business.Concrete;
using Northwind.Data.Access.Concrete.EntityFramework;
using Northwind.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Northwind.WebForms.uı
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
           _ProductService =new ProductManager(new EfProductDal()); 
            _CategoryService = new CategoryManager(new EfCategoryDal());
        }
        private IProductService _ProductService;
        private ICategoryService _CategoryService;

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadProducts();
            LoadCategories();
        }

        private void LoadCategories()  
        {
            cbxcategory.DataSource = _CategoryService.GetAll();
            cbxcategory.DisplayMember = "CategoryName";
            cbxcategory.ValueMember = "CategoryID";

            cbxCategoryId.DataSource = _CategoryService.GetAll();
            cbxCategoryId.DisplayMember = "CategoryName";
            cbxCategoryId.ValueMember = "CategoryID";

            cbxCategoryIdUpdate.DataSource = _CategoryService.GetAll();
            cbxCategoryIdUpdate.DisplayMember = "CategoryName";
            cbxCategoryIdUpdate.ValueMember = "CategoryID";
        }

        private void LoadProducts()
        {
            dgwProduct.DataSource = _ProductService.GetAll();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void cbxcategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                dgwProduct.DataSource = _ProductService.GetProductsByCategory(Convert.ToInt32(cbxcategory.SelectedValue));
            }
            catch 
            {

                
            }
           
        }

        private void tbxProductName_TextChanged(object sender, EventArgs e)
        {
            if(!string .IsNullOrEmpty(tbxProductName.Text))
            {
                dgwProduct.DataSource = _ProductService.GetProductsByProductName(tbxProductName.Text);
            }
            else
            {
                LoadProducts();
            }



          
        }

        private void aaa_Click(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                _ProductService.Add(new Product
                {
                    CategoryID = Convert.ToInt32(cbxCategoryId.SelectedValue),
                    ProductName = tbxProductName2.Text,
                    QuantityPerUnit = tbxQuantityPerUnit.Text,
                    UnitPrice = Convert.ToDecimal(tbxUnitPrice.Text),
                    UnitsInStock = Convert.ToInt16(tbxStock.Text),


                });
                MessageBox.Show("ürün Eklendi");
                LoadProducts();
            }
            catch (Exception exception)
            {

                MessageBox.Show(exception.Message);
            }
        }

        private void groupBox1_Enter_1(object sender, EventArgs e)
        {

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                _ProductService.Update(new Product
                {
                    ProductID = Convert.ToInt32(dgwProduct.CurrentRow.Cells[0].Value),
                    ProductName = tbxUpdateProductName.Text,
                    CategoryID = Convert.ToInt32(cbxCategoryIdUpdate.SelectedValue),
                    //
                    UnitsInStock = Convert.ToInt16(tbxUnitStockUpdate.Text),
                    QuantityPerUnit = tbxQuantityPerUnitUpdate.Text,
                    UnitPrice = Convert.ToDecimal(tbxUnitPriceUpdate.Text),

                });
                MessageBox.Show("ürün Güncellendi");
                LoadProducts();
            }
            catch (Exception exception)
            {

                MessageBox.Show(exception.Message);
            }
        }

        private void dgwProduct_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var row = dgwProduct.CurrentRow;
            tbxUpdateProductName.Text=row.Cells[1].Value.ToString();
            cbxCategoryIdUpdate.SelectedValue = row.Cells[2].Value;
            tbxUnitPriceUpdate.Text = row.Cells[3].Value.ToString();
            tbxQuantityPerUnitUpdate.Text = row.Cells[4].Value.ToString();
            tbxUnitStockUpdate.Text = row.Cells[5].Value.ToString();

        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (dgwProduct.CurrentRow != null)
            {
                try
                {
                    _ProductService.Delete(new Product
                    {
                        ProductID = Convert.ToInt32(dgwProduct.CurrentRow.Cells[0].Value)
                    });

                    MessageBox.Show("ürün Silindi");
                    LoadProducts();

                }
                catch (Exception exception)
                {
                    MessageBox.Show(exception.Message);
                }
              

            }
          
        }
    }
}

