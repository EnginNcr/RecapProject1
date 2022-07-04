using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RecapProject1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ListProducts();
            ListCategories();
        }

        private void ListProducts()
        {
            using (NorthwindContext context = new NorthwindContext())
            {
                dgwproduct.DataSource = context.Products.ToList();

            }

        }
       

        private void ListCategories()
        {
            using (NorthwindContext context = new NorthwindContext())
            {
                cbxkategori.DataSource = context.Categories.ToList();
                cbxkategori.DisplayMember = "CategoryName";
                cbxkategori.ValueMember = "CategoryId";


            }
        }
        private void ListProductByCategory(int categoryId)
        {
            using (NorthwindContext context = new NorthwindContext())
            {
                dgwproduct.DataSource = context.Products.Where(p=>p.CategoryId==categoryId).ToList();

            }
        }

        private void cbxkategori_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                ListProductByCategory(Convert.ToInt32(cbxkategori.SelectedValue));
            }
            catch (Exception)
            {

               
            }

        }
        private void ListProductByProductName(string key)
        {
            using (NorthwindContext context = new NorthwindContext())
            {
                dgwproduct.DataSource = context.Products.Where(p => p.ProductName.ToLower().Contains(key.ToLower())).ToList();

            }
        }

        private void tbxsearch_TextChanged(object sender, EventArgs e)
        {
            ListProductByProductName(tbxsearch.Text);
            string key=tbxsearch.Text;
            if (string.IsNullOrEmpty(key))
            {
                ListProducts();

            }
            else
            {
                ListProductByProductName(tbxsearch.Text);
            }
        }
    }
}
