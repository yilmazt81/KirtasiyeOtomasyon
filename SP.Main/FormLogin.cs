﻿using SP.DBLayer;
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
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void buttonOk_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxUserName.Text))
            {
                FormMessageOk formMessageOk = new FormMessageOk("Kullanıcı adı Girmediniz");
                formMessageOk.ShowDialog();
                return;
            }
            if (string.IsNullOrEmpty(textBoxPassword.Text))
            {
                FormMessageOk formMessageOk = new FormMessageOk("Şifre Girmediniz");
                formMessageOk.ShowDialog();
                return;
            }
            try
            {
               if (!DBHelper.Login(textBoxUserName.Text, textBoxPassword.Text))
                {
                    FormMessageOk formMessageOk = new FormMessageOk("Kullanıcı Adı veya şifre yanlış");
                    formMessageOk.ShowDialog();
                    return;
                }
                DialogResult = DialogResult.OK;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Hata");
            }
        }
    }
}