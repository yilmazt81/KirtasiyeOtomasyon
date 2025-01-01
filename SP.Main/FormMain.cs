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
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void buttonProductEnter_Click(object sender, EventArgs e)
        {
            splitContainer1.Panel2.Controls.Clear();

            UserControlStockAccept userControlStockAccept = new UserControlStockAccept();
            splitContainer1.Panel2.Controls.Add(userControlStockAccept);
            userControlStockAccept.Dock = DockStyle.Fill;
        }

        private void buttonSale_Click(object sender, EventArgs e)
        {
            splitContainer1.Panel2.Controls.Clear();

            UserControlSale userControlSale = new UserControlSale();
            splitContainer1.Panel2.Controls.Add(userControlSale);
            userControlSale.Dock = DockStyle.Fill;
        }

        private void buttonUserDefination_Click(object sender, EventArgs e)
        {
            splitContainer1.Panel2.Controls.Clear();

            UserControlUserDefination userControlUser = new UserControlUserDefination();
            splitContainer1.Panel2.Controls.Add(userControlUser);
            userControlUser.Dock = DockStyle.Fill;
        }
    }
}
