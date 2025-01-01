using SP.DBLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SP.Main
{
    public partial class UserControlStockAccept : UserControl
    {
        public UserControlStockAccept()
        {
            InitializeComponent();
        }

        private void cMenuStripProduct_Opening(object sender, CancelEventArgs e)
        {
           
        }

        private void MenuItemProductProperty_Click(object sender, EventArgs e)
        {
            FormProductEdit formProductEdit = new FormProductEdit();
            formProductEdit.ShowDialog();
        }

        private void textBoxProductBarcode_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode==Keys.Enter && !string.IsNullOrEmpty(textBoxProductBarcode.Text))
            {
               var product= DBHelper.GetProductByBarcode(textBoxProductBarcode.Text);

                if (product == null)
                {
                    FormProductEdit formProductEdit = new FormProductEdit();
                    if (formProductEdit.ShowDialog() == DialogResult.OK)
                    {

                    }

                }
            }
        }
    }
}
