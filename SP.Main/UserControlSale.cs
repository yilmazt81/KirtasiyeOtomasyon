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
    public partial class UserControlSale : UserControl
    {
        public UserControlSale()
        {
            InitializeComponent();
        }

        private void buttonAddCustomer_Click(object sender, EventArgs e)
        {
            FormCustomerEdit formCustomerEdit = new FormCustomerEdit();
            formCustomerEdit.ShowDialog();
        }
    }
}
