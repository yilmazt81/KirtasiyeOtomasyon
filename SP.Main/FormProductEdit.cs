using SP.DBLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SP.Main
{
    public partial class FormProductEdit : Form
    {
        private string productPicture = string.Empty;
        public FormProductEdit()
        {
            InitializeComponent();
            LoadCategory();
        }
        public FormProductEdit(string barcode)
        {
            InitializeComponent();
            LoadCategory();
            textBoxBarcode.Text = barcode;
        }
        private void LoadCategory()
        {
            var category = DBHelper.GetProductCategory();
            comboBoxCategory.DisplayMember = "CategoryName";
            comboBoxCategory.ValueMember = "Id";
            comboBoxCategory.DataSource = category;

        }

        private void buttonAddPicture_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Image Dosyası|*.jpg";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                productPicture = ofd.FileName;
                pictureBox1.Load(ofd.FileName);
            }
        }

        private Product product;
        public Product EditProduct
        {
            get
            {
                if (product == null)
                {
                    product = new Product();
                }

                product.Picture = productPicture;
                if (!string.IsNullOrEmpty(productPicture))
                {
                    pictureBox1.Load(productPicture);
                }
                product.Barcode = textBoxBarcode.Text;
                product.Quantity = (int)nUpDownQuantity.Value;
                product.TaxValue = (int)nUpDownTax.Value;
                product.Description = textBoxDescription.Text;
                product.ProductName = textBoxName.Text;
                product.ProductCategoryId = (int)comboBoxCategory.SelectedValue;
                return product;
            }
            set
            {
                product = value;

                productPicture = product.Picture;
                textBoxBarcode.Text = product.Barcode;
                nUpDownQuantity.Value = (decimal)product.Quantity;
                nUpDownTax.Value = (decimal)product.TaxValue;
                textBoxDescription.Text = product.Description;
                textBoxName.Text = product.ProductName;
                comboBoxCategory.SelectedValue = product.ProductCategoryId;

            }
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void buttonOk_Click(object sender, EventArgs e)
        {

            DialogResult= DialogResult.OK;
        }
    }
}
