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
    public partial class FormMessageOk : Form
    {
        public FormMessageOk(string message)
        {
            InitializeComponent();
            labelMessage.Text = message;
        }

        private void buttonOk_Click(object sender, EventArgs e)
        {

            DialogResult = DialogResult.OK;
        }
    }
}
