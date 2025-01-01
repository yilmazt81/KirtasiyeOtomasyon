namespace SP.Main
{
    partial class UserControlUserDefination
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
            this.listViewUser = new System.Windows.Forms.ListView();
            this.HId = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.HUserName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.HFullName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cMenuStripUser = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.MenuItemNew = new System.Windows.Forms.ToolStripMenuItem();
            this.silToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cMenuStripUser.SuspendLayout();
            this.SuspendLayout();
            // 
            // listViewUser
            // 
            this.listViewUser.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listViewUser.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.HId,
            this.HUserName,
            this.HFullName});
            this.listViewUser.ContextMenuStrip = this.cMenuStripUser;
            this.listViewUser.FullRowSelect = true;
            this.listViewUser.GridLines = true;
            this.listViewUser.HideSelection = false;
            this.listViewUser.Location = new System.Drawing.Point(14, 38);
            this.listViewUser.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.listViewUser.Name = "listViewUser";
            this.listViewUser.Size = new System.Drawing.Size(843, 523);
            this.listViewUser.TabIndex = 4;
            this.listViewUser.UseCompatibleStateImageBehavior = false;
            this.listViewUser.View = System.Windows.Forms.View.Details;
            // 
            // HId
            // 
            this.HId.Text = "Id";
            this.HId.Width = 200;
            // 
            // HUserName
            // 
            this.HUserName.Text = "Kullanıcı Adı";
            this.HUserName.Width = 171;
            // 
            // HFullName
            // 
            this.HFullName.Text = "Tam Adı";
            this.HFullName.Width = 224;
            // 
            // cMenuStripUser
            // 
            this.cMenuStripUser.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.cMenuStripUser.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuItemNew,
            this.silToolStripMenuItem});
            this.cMenuStripUser.Name = "cMenuStripUser";
            this.cMenuStripUser.Size = new System.Drawing.Size(106, 52);
            // 
            // MenuItemNew
            // 
            this.MenuItemNew.Name = "MenuItemNew";
            this.MenuItemNew.Size = new System.Drawing.Size(210, 24);
            this.MenuItemNew.Text = "Ekle";
            // 
            // silToolStripMenuItem
            // 
            this.silToolStripMenuItem.Name = "silToolStripMenuItem";
            this.silToolStripMenuItem.Size = new System.Drawing.Size(210, 24);
            this.silToolStripMenuItem.Text = "Sil";
            // 
            // UserControlUserDefination
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.listViewUser);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "UserControlUserDefination";
            this.Size = new System.Drawing.Size(861, 565);
            this.cMenuStripUser.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView listViewUser;
        private System.Windows.Forms.ColumnHeader HId;
        private System.Windows.Forms.ColumnHeader HUserName;
        private System.Windows.Forms.ColumnHeader HFullName;
        private System.Windows.Forms.ContextMenuStrip cMenuStripUser;
        private System.Windows.Forms.ToolStripMenuItem MenuItemNew;
        private System.Windows.Forms.ToolStripMenuItem silToolStripMenuItem;
    }
}
