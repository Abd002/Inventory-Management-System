namespace Inventory_Management_System
{
    partial class Home
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.btnLogOut = new MetroSet_UI.Controls.MetroSetButton();
            this.btnProducts = new MetroSet_UI.Controls.MetroSetButton();
            this.btnReports = new MetroSet_UI.Controls.MetroSetButton();
            this.btnAdmin = new MetroSet_UI.Controls.MetroSetButton();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(20, 60);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(760, 370);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 4;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Controls.Add(this.btnLogOut, 3, 0);
            this.tableLayoutPanel2.Controls.Add(this.btnProducts, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.btnReports, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.btnAdmin, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 299);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(754, 68);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // btnLogOut
            // 
            this.btnLogOut.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.btnLogOut.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.btnLogOut.DisabledForeColor = System.Drawing.Color.Gray;
            this.btnLogOut.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnLogOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnLogOut.HoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(207)))), ((int)(((byte)(255)))));
            this.btnLogOut.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(207)))), ((int)(((byte)(255)))));
            this.btnLogOut.HoverTextColor = System.Drawing.Color.White;
            this.btnLogOut.IsDerivedStyle = true;
            this.btnLogOut.Location = new System.Drawing.Point(567, 3);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.NormalBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.btnLogOut.NormalColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.btnLogOut.NormalTextColor = System.Drawing.Color.White;
            this.btnLogOut.PressBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(147)))), ((int)(((byte)(195)))));
            this.btnLogOut.PressColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(147)))), ((int)(((byte)(195)))));
            this.btnLogOut.PressTextColor = System.Drawing.Color.White;
            this.btnLogOut.Size = new System.Drawing.Size(184, 62);
            this.btnLogOut.Style = MetroSet_UI.Enums.Style.Light;
            this.btnLogOut.StyleManager = null;
            this.btnLogOut.TabIndex = 4;
            this.btnLogOut.Text = "LogOut";
            this.btnLogOut.ThemeAuthor = "Narwin";
            this.btnLogOut.ThemeName = "MetroLite";
            this.btnLogOut.Click += new System.EventHandler(this.txtLogOut_Click);
            // 
            // btnProducts
            // 
            this.btnProducts.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.btnProducts.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.btnProducts.DisabledForeColor = System.Drawing.Color.Gray;
            this.btnProducts.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnProducts.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnProducts.HoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(207)))), ((int)(((byte)(255)))));
            this.btnProducts.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(207)))), ((int)(((byte)(255)))));
            this.btnProducts.HoverTextColor = System.Drawing.Color.White;
            this.btnProducts.IsDerivedStyle = true;
            this.btnProducts.Location = new System.Drawing.Point(379, 3);
            this.btnProducts.Name = "btnProducts";
            this.btnProducts.NormalBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.btnProducts.NormalColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.btnProducts.NormalTextColor = System.Drawing.Color.White;
            this.btnProducts.PressBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(147)))), ((int)(((byte)(195)))));
            this.btnProducts.PressColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(147)))), ((int)(((byte)(195)))));
            this.btnProducts.PressTextColor = System.Drawing.Color.White;
            this.btnProducts.Size = new System.Drawing.Size(182, 62);
            this.btnProducts.Style = MetroSet_UI.Enums.Style.Light;
            this.btnProducts.StyleManager = null;
            this.btnProducts.TabIndex = 2;
            this.btnProducts.Text = "Products";
            this.btnProducts.ThemeAuthor = "Narwin";
            this.btnProducts.ThemeName = "MetroLite";
            this.btnProducts.Click += new System.EventHandler(this.txtProducts_Click);
            // 
            // btnReports
            // 
            this.btnReports.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.btnReports.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.btnReports.DisabledForeColor = System.Drawing.Color.Gray;
            this.btnReports.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnReports.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnReports.HoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(207)))), ((int)(((byte)(255)))));
            this.btnReports.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(207)))), ((int)(((byte)(255)))));
            this.btnReports.HoverTextColor = System.Drawing.Color.White;
            this.btnReports.IsDerivedStyle = true;
            this.btnReports.Location = new System.Drawing.Point(191, 3);
            this.btnReports.Name = "btnReports";
            this.btnReports.NormalBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.btnReports.NormalColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.btnReports.NormalTextColor = System.Drawing.Color.White;
            this.btnReports.PressBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(147)))), ((int)(((byte)(195)))));
            this.btnReports.PressColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(147)))), ((int)(((byte)(195)))));
            this.btnReports.PressTextColor = System.Drawing.Color.White;
            this.btnReports.Size = new System.Drawing.Size(182, 62);
            this.btnReports.Style = MetroSet_UI.Enums.Style.Light;
            this.btnReports.StyleManager = null;
            this.btnReports.TabIndex = 1;
            this.btnReports.Text = "Reports";
            this.btnReports.ThemeAuthor = "Narwin";
            this.btnReports.ThemeName = "MetroLite";
            this.btnReports.Click += new System.EventHandler(this.txtReports_Click);
            // 
            // btnAdmin
            // 
            this.btnAdmin.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.btnAdmin.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.btnAdmin.DisabledForeColor = System.Drawing.Color.Gray;
            this.btnAdmin.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnAdmin.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnAdmin.HoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(207)))), ((int)(((byte)(255)))));
            this.btnAdmin.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(207)))), ((int)(((byte)(255)))));
            this.btnAdmin.HoverTextColor = System.Drawing.Color.White;
            this.btnAdmin.IsDerivedStyle = true;
            this.btnAdmin.Location = new System.Drawing.Point(3, 3);
            this.btnAdmin.Name = "btnAdmin";
            this.btnAdmin.NormalBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.btnAdmin.NormalColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.btnAdmin.NormalTextColor = System.Drawing.Color.White;
            this.btnAdmin.PressBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(147)))), ((int)(((byte)(195)))));
            this.btnAdmin.PressColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(147)))), ((int)(((byte)(195)))));
            this.btnAdmin.PressTextColor = System.Drawing.Color.White;
            this.btnAdmin.Size = new System.Drawing.Size(182, 62);
            this.btnAdmin.Style = MetroSet_UI.Enums.Style.Light;
            this.btnAdmin.StyleManager = null;
            this.btnAdmin.TabIndex = 0;
            this.btnAdmin.Text = "Admin";
            this.btnAdmin.ThemeAuthor = "Narwin";
            this.btnAdmin.ThemeName = "MetroLite";
            this.btnAdmin.Click += new System.EventHandler(this.txtAdmin_Click);
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Home";
            this.Text = "Home";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private MetroSet_UI.Controls.MetroSetButton btnAdmin;
        private MetroSet_UI.Controls.MetroSetButton btnLogOut;
        private MetroSet_UI.Controls.MetroSetButton btnProducts;
        private MetroSet_UI.Controls.MetroSetButton btnReports;
    }
}