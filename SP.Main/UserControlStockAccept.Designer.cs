namespace SP.Main
{
    partial class UserControlStockAccept
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserControlStockAccept));
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxProductBarcode = new System.Windows.Forms.TextBox();
            this.buttonAddProduct = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.buttonSave = new System.Windows.Forms.Button();
            this.HBarcode = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.HProductName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.HQuantity = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cMenuStripProduct = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.MenuItemProductProperty = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemRemove = new System.Windows.Forms.ToolStripMenuItem();
            this.cMenuStripProduct.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ürün Barkodu";
            // 
            // textBoxProductBarcode
            // 
            this.textBoxProductBarcode.Location = new System.Drawing.Point(155, 36);
            this.textBoxProductBarcode.Name = "textBoxProductBarcode";
            this.textBoxProductBarcode.Size = new System.Drawing.Size(396, 30);
            this.textBoxProductBarcode.TabIndex = 1;
            this.textBoxProductBarcode.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxProductBarcode_KeyDown);
            // 
            // buttonAddProduct
            // 
            this.buttonAddProduct.Image = ((System.Drawing.Image)(resources.GetObject("buttonAddProduct.Image")));
            this.buttonAddProduct.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonAddProduct.Location = new System.Drawing.Point(567, 37);
            this.buttonAddProduct.Name = "buttonAddProduct";
            this.buttonAddProduct.Size = new System.Drawing.Size(191, 29);
            this.buttonAddProduct.TabIndex = 2;
            this.buttonAddProduct.Text = "Ürün Ekle";
            this.buttonAddProduct.UseVisualStyleBackColor = true;
            // 
            // listView1
            // 
            this.listView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.HBarcode,
            this.HProductName,
            this.HQuantity});
            this.listView1.ContextMenuStrip = this.cMenuStripProduct;
            this.listView1.FullRowSelect = true;
            this.listView1.GridLines = true;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(22, 82);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(1027, 352);
            this.listView1.TabIndex = 3;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // buttonSave
            // 
            this.buttonSave.Image = ((System.Drawing.Image)(resources.GetObject("buttonSave.Image")));
            this.buttonSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonSave.Location = new System.Drawing.Point(773, 34);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(191, 32);
            this.buttonSave.TabIndex = 4;
            this.buttonSave.Text = "Kaydet";
            this.buttonSave.UseVisualStyleBackColor = true;
            // 
            // HBarcode
            // 
            this.HBarcode.Text = "Barkod";
            this.HBarcode.Width = 200;
            // 
            // HProductName
            // 
            this.HProductName.Text = "Ürün Adı";
            this.HProductName.Width = 500;
            // 
            // HQuantity
            // 
            this.HQuantity.Text = "Adet";
            this.HQuantity.Width = 100;
            // 
            // cMenuStripProduct
            // 
            this.cMenuStripProduct.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.cMenuStripProduct.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuItemProductProperty,
            this.MenuItemRemove});
            this.cMenuStripProduct.Name = "cMenuStripProduct";
            this.cMenuStripProduct.Size = new System.Drawing.Size(180, 52);
            this.cMenuStripProduct.Opening += new System.ComponentModel.CancelEventHandler(this.cMenuStripProduct_Opening);
            // 
            // MenuItemProductProperty
            // 
            this.MenuItemProductProperty.Name = "MenuItemProductProperty";
            this.MenuItemProductProperty.Size = new System.Drawing.Size(210, 24);
            this.MenuItemProductProperty.Text = "Ürün Özellikleri";
            this.MenuItemProductProperty.Click += new System.EventHandler(this.MenuItemProductProperty_Click);
            // 
            // MenuItemRemove
            // 
            this.MenuItemRemove.Name = "MenuItemRemove";
            this.MenuItemRemove.Size = new System.Drawing.Size(179, 24);
            this.MenuItemRemove.Text = "Sil";
            // 
            // UserControlStockAccept
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.buttonAddProduct);
            this.Controls.Add(this.textBoxProductBarcode);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "UserControlStockAccept";
            this.Size = new System.Drawing.Size(1072, 479);
            this.cMenuStripProduct.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxProductBarcode;
        private System.Windows.Forms.Button buttonAddProduct;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.ColumnHeader HBarcode;
        private System.Windows.Forms.ColumnHeader HProductName;
        private System.Windows.Forms.ColumnHeader HQuantity;
        private System.Windows.Forms.ContextMenuStrip cMenuStripProduct;
        private System.Windows.Forms.ToolStripMenuItem MenuItemProductProperty;
        private System.Windows.Forms.ToolStripMenuItem MenuItemRemove;
    }
}
