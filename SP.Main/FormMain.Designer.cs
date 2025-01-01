namespace SP.Main
{
    partial class FormMain
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.buttonProductEnter = new System.Windows.Forms.Button();
            this.buttonSale = new System.Windows.Forms.Button();
            this.buttonUserDefination = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.button1);
            this.splitContainer1.Panel1.Controls.Add(this.buttonUserDefination);
            this.splitContainer1.Panel1.Controls.Add(this.buttonSale);
            this.splitContainer1.Panel1.Controls.Add(this.buttonProductEnter);
            this.splitContainer1.Size = new System.Drawing.Size(1542, 719);
            this.splitContainer1.SplitterDistance = 318;
            this.splitContainer1.SplitterWidth = 6;
            this.splitContainer1.TabIndex = 0;
            // 
            // buttonProductEnter
            // 
            this.buttonProductEnter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonProductEnter.Image = ((System.Drawing.Image)(resources.GetObject("buttonProductEnter.Image")));
            this.buttonProductEnter.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonProductEnter.Location = new System.Drawing.Point(4, 19);
            this.buttonProductEnter.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonProductEnter.Name = "buttonProductEnter";
            this.buttonProductEnter.Size = new System.Drawing.Size(294, 66);
            this.buttonProductEnter.TabIndex = 0;
            this.buttonProductEnter.Text = "Stok Girişi";
            this.buttonProductEnter.UseVisualStyleBackColor = true;
            this.buttonProductEnter.Click += new System.EventHandler(this.buttonProductEnter_Click);
            // 
            // buttonSale
            // 
            this.buttonSale.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSale.Image = ((System.Drawing.Image)(resources.GetObject("buttonSale.Image")));
            this.buttonSale.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonSale.Location = new System.Drawing.Point(4, 94);
            this.buttonSale.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonSale.Name = "buttonSale";
            this.buttonSale.Size = new System.Drawing.Size(294, 66);
            this.buttonSale.TabIndex = 1;
            this.buttonSale.Text = "Satış";
            this.buttonSale.UseVisualStyleBackColor = true;
            this.buttonSale.Click += new System.EventHandler(this.buttonSale_Click);
            // 
            // buttonUserDefination
            // 
            this.buttonUserDefination.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonUserDefination.Image = ((System.Drawing.Image)(resources.GetObject("buttonUserDefination.Image")));
            this.buttonUserDefination.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonUserDefination.Location = new System.Drawing.Point(4, 180);
            this.buttonUserDefination.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonUserDefination.Name = "buttonUserDefination";
            this.buttonUserDefination.Size = new System.Drawing.Size(294, 66);
            this.buttonUserDefination.TabIndex = 2;
            this.buttonUserDefination.Text = "Kullanıcı Tanımlama";
            this.buttonUserDefination.UseVisualStyleBackColor = true;
            this.buttonUserDefination.Click += new System.EventHandler(this.buttonUserDefination_Click);
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(4, 268);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(294, 66);
            this.button1.TabIndex = 3;
            this.button1.Text = "Çıkış";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1542, 719);
            this.Controls.Add(this.splitContainer1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FormMain";
            this.Text = "Kirtasiye Yönetim";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.splitContainer1.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Button buttonProductEnter;
        private System.Windows.Forms.Button buttonSale;
        private System.Windows.Forms.Button buttonUserDefination;
        private System.Windows.Forms.Button button1;
    }
}

