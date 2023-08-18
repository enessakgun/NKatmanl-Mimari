using Northwind.Business.Abstract;
using Northwind.Business.Concrete;
using Northwind.Data.Access.Concrete.EntityFramework;
using System;
using System.Collections.Generic;
using System.ComponentModel;
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
        }
        private IProductService _ProductService;

        private void Form1_Load(object sender, EventArgs e)
        {
           
            dgwProduct.DataSource = _ProductService.GetAll();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
