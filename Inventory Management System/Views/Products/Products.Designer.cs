namespace Inventory_Management_System.Views.Products
{
    partial class Products
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
            this.components = new System.ComponentModel.Container();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.tblAdmin = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.txtSupplier = new MetroSet_UI.Controls.MetroSetTextBox();
            this.metroLabel10 = new MetroFramework.Controls.MetroLabel();
            this.txtCategory = new MetroSet_UI.Controls.MetroSetTextBox();
            this.metroLabel9 = new MetroFramework.Controls.MetroLabel();
            this.txtPrice = new MetroSet_UI.Controls.MetroSetTextBox();
            this.metroLabel7 = new MetroFramework.Controls.MetroLabel();
            this.txtQuantity = new MetroSet_UI.Controls.MetroSetTextBox();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.txtDescription = new MetroSet_UI.Controls.MetroSetTextBox();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.txtName = new MetroSet_UI.Controls.MetroSetTextBox();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.txtID = new MetroSet_UI.Controls.MetroSetTextBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.btnEditOrAdd = new MetroSet_UI.Controls.MetroSetButton();
            this.btnDelete = new MetroSet_UI.Controls.MetroSetButton();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.btnBack = new MetroSet_UI.Controls.MetroSetButton();
            this.tableLayoutPanel6 = new System.Windows.Forms.TableLayoutPanel();
            this.metroLabel8 = new MetroFramework.Controls.MetroLabel();
            this.txtCategorySearch = new MetroSet_UI.Controls.MetroSetTextBox();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.txtNameSearch = new MetroSet_UI.Controls.MetroSetTextBox();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.btnSearch = new MetroSet_UI.Controls.MetroSetButton();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.productsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.comboBoxStock = new MetroSet_UI.Controls.MetroSetComboBox();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.tblAdmin.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel5.SuspendLayout();
            this.tableLayoutPanel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel3, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.dataGridView, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(20, 60);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1080, 627);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 1;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Controls.Add(this.tblAdmin, 0, 2);
            this.tableLayoutPanel3.Controls.Add(this.tableLayoutPanel5, 0, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(759, 3);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 3;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 66.66666F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(318, 621);
            this.tableLayoutPanel3.TabIndex = 2;
            // 
            // tblAdmin
            // 
            this.tblAdmin.ColumnCount = 1;
            this.tblAdmin.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblAdmin.Controls.Add(this.tableLayoutPanel2, 0, 0);
            this.tblAdmin.Controls.Add(this.btnEditOrAdd, 0, 1);
            this.tblAdmin.Controls.Add(this.btnDelete, 0, 2);
            this.tblAdmin.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblAdmin.Location = new System.Drawing.Point(3, 223);
            this.tblAdmin.Name = "tblAdmin";
            this.tblAdmin.RowCount = 3;
            this.tblAdmin.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 66.66666F));
            this.tblAdmin.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tblAdmin.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tblAdmin.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tblAdmin.Size = new System.Drawing.Size(312, 395);
            this.tblAdmin.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tableLayoutPanel2.Controls.Add(this.txtSupplier, 1, 6);
            this.tableLayoutPanel2.Controls.Add(this.metroLabel10, 0, 6);
            this.tableLayoutPanel2.Controls.Add(this.txtCategory, 1, 5);
            this.tableLayoutPanel2.Controls.Add(this.metroLabel9, 0, 5);
            this.tableLayoutPanel2.Controls.Add(this.txtPrice, 1, 4);
            this.tableLayoutPanel2.Controls.Add(this.metroLabel7, 0, 4);
            this.tableLayoutPanel2.Controls.Add(this.txtQuantity, 1, 3);
            this.tableLayoutPanel2.Controls.Add(this.metroLabel5, 0, 3);
            this.tableLayoutPanel2.Controls.Add(this.txtDescription, 1, 2);
            this.tableLayoutPanel2.Controls.Add(this.metroLabel3, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.txtName, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.metroLabel2, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.txtID, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.metroLabel1, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 7;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(306, 257);
            this.tableLayoutPanel2.TabIndex = 1;
            this.tableLayoutPanel2.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel2_Paint);
            // 
            // txtSupplier
            // 
            this.txtSupplier.AutoCompleteCustomSource = null;
            this.txtSupplier.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtSupplier.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtSupplier.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            this.txtSupplier.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.txtSupplier.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            this.txtSupplier.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            this.txtSupplier.Dock = System.Windows.Forms.DockStyle.Left;
            this.txtSupplier.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtSupplier.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.txtSupplier.Image = null;
            this.txtSupplier.IsDerivedStyle = true;
            this.txtSupplier.Lines = null;
            this.txtSupplier.Location = new System.Drawing.Point(94, 219);
            this.txtSupplier.MaxLength = 32767;
            this.txtSupplier.Multiline = false;
            this.txtSupplier.Name = "txtSupplier";
            this.txtSupplier.ReadOnly = false;
            this.txtSupplier.Size = new System.Drawing.Size(202, 35);
            this.txtSupplier.Style = MetroSet_UI.Enums.Style.Light;
            this.txtSupplier.StyleManager = null;
            this.txtSupplier.TabIndex = 13;
            this.txtSupplier.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtSupplier.ThemeAuthor = "Narwin";
            this.txtSupplier.ThemeName = "MetroLite";
            this.txtSupplier.UseSystemPasswordChar = false;
            this.txtSupplier.WatermarkText = "";
            // 
            // metroLabel10
            // 
            this.metroLabel10.AutoSize = true;
            this.metroLabel10.Dock = System.Windows.Forms.DockStyle.Right;
            this.metroLabel10.Location = new System.Drawing.Point(31, 216);
            this.metroLabel10.Name = "metroLabel10";
            this.metroLabel10.Size = new System.Drawing.Size(57, 41);
            this.metroLabel10.TabIndex = 12;
            this.metroLabel10.Text = "Supplier";
            this.metroLabel10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtCategory
            // 
            this.txtCategory.AutoCompleteCustomSource = null;
            this.txtCategory.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtCategory.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtCategory.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            this.txtCategory.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.txtCategory.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            this.txtCategory.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            this.txtCategory.Dock = System.Windows.Forms.DockStyle.Left;
            this.txtCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtCategory.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.txtCategory.Image = null;
            this.txtCategory.IsDerivedStyle = true;
            this.txtCategory.Lines = null;
            this.txtCategory.Location = new System.Drawing.Point(94, 183);
            this.txtCategory.MaxLength = 32767;
            this.txtCategory.Multiline = false;
            this.txtCategory.Name = "txtCategory";
            this.txtCategory.ReadOnly = false;
            this.txtCategory.Size = new System.Drawing.Size(202, 30);
            this.txtCategory.Style = MetroSet_UI.Enums.Style.Light;
            this.txtCategory.StyleManager = null;
            this.txtCategory.TabIndex = 11;
            this.txtCategory.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtCategory.ThemeAuthor = "Narwin";
            this.txtCategory.ThemeName = "MetroLite";
            this.txtCategory.UseSystemPasswordChar = false;
            this.txtCategory.WatermarkText = "";
            // 
            // metroLabel9
            // 
            this.metroLabel9.AutoSize = true;
            this.metroLabel9.Dock = System.Windows.Forms.DockStyle.Right;
            this.metroLabel9.Location = new System.Drawing.Point(24, 180);
            this.metroLabel9.Name = "metroLabel9";
            this.metroLabel9.Size = new System.Drawing.Size(64, 36);
            this.metroLabel9.TabIndex = 10;
            this.metroLabel9.Text = "Category";
            this.metroLabel9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtPrice
            // 
            this.txtPrice.AutoCompleteCustomSource = null;
            this.txtPrice.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtPrice.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtPrice.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            this.txtPrice.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.txtPrice.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            this.txtPrice.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            this.txtPrice.Dock = System.Windows.Forms.DockStyle.Left;
            this.txtPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtPrice.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.txtPrice.Image = null;
            this.txtPrice.IsDerivedStyle = true;
            this.txtPrice.Lines = null;
            this.txtPrice.Location = new System.Drawing.Point(94, 147);
            this.txtPrice.MaxLength = 32767;
            this.txtPrice.Multiline = false;
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.ReadOnly = false;
            this.txtPrice.Size = new System.Drawing.Size(202, 30);
            this.txtPrice.Style = MetroSet_UI.Enums.Style.Light;
            this.txtPrice.StyleManager = null;
            this.txtPrice.TabIndex = 9;
            this.txtPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtPrice.ThemeAuthor = "Narwin";
            this.txtPrice.ThemeName = "MetroLite";
            this.txtPrice.UseSystemPasswordChar = false;
            this.txtPrice.WatermarkText = "";
            // 
            // metroLabel7
            // 
            this.metroLabel7.AutoSize = true;
            this.metroLabel7.Dock = System.Windows.Forms.DockStyle.Right;
            this.metroLabel7.Location = new System.Drawing.Point(50, 144);
            this.metroLabel7.Name = "metroLabel7";
            this.metroLabel7.Size = new System.Drawing.Size(38, 36);
            this.metroLabel7.TabIndex = 8;
            this.metroLabel7.Text = "Price";
            this.metroLabel7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtQuantity
            // 
            this.txtQuantity.AutoCompleteCustomSource = null;
            this.txtQuantity.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtQuantity.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtQuantity.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            this.txtQuantity.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.txtQuantity.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            this.txtQuantity.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            this.txtQuantity.Dock = System.Windows.Forms.DockStyle.Left;
            this.txtQuantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtQuantity.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.txtQuantity.Image = null;
            this.txtQuantity.IsDerivedStyle = true;
            this.txtQuantity.Lines = null;
            this.txtQuantity.Location = new System.Drawing.Point(94, 111);
            this.txtQuantity.MaxLength = 32767;
            this.txtQuantity.Multiline = false;
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.ReadOnly = false;
            this.txtQuantity.Size = new System.Drawing.Size(202, 30);
            this.txtQuantity.Style = MetroSet_UI.Enums.Style.Light;
            this.txtQuantity.StyleManager = null;
            this.txtQuantity.TabIndex = 7;
            this.txtQuantity.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtQuantity.ThemeAuthor = "Narwin";
            this.txtQuantity.ThemeName = "MetroLite";
            this.txtQuantity.UseSystemPasswordChar = false;
            this.txtQuantity.WatermarkText = "";
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.Dock = System.Windows.Forms.DockStyle.Right;
            this.metroLabel5.Location = new System.Drawing.Point(30, 108);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(58, 36);
            this.metroLabel5.TabIndex = 6;
            this.metroLabel5.Text = "Quantity";
            this.metroLabel5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtDescription
            // 
            this.txtDescription.AutoCompleteCustomSource = null;
            this.txtDescription.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtDescription.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtDescription.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            this.txtDescription.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.txtDescription.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            this.txtDescription.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            this.txtDescription.Dock = System.Windows.Forms.DockStyle.Left;
            this.txtDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtDescription.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.txtDescription.Image = null;
            this.txtDescription.IsDerivedStyle = true;
            this.txtDescription.Lines = null;
            this.txtDescription.Location = new System.Drawing.Point(94, 75);
            this.txtDescription.MaxLength = 32767;
            this.txtDescription.Multiline = false;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.ReadOnly = false;
            this.txtDescription.Size = new System.Drawing.Size(202, 30);
            this.txtDescription.Style = MetroSet_UI.Enums.Style.Light;
            this.txtDescription.StyleManager = null;
            this.txtDescription.TabIndex = 5;
            this.txtDescription.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtDescription.ThemeAuthor = "Narwin";
            this.txtDescription.ThemeName = "MetroLite";
            this.txtDescription.UseSystemPasswordChar = false;
            this.txtDescription.WatermarkText = "";
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.metroLabel3.Location = new System.Drawing.Point(14, 72);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(74, 36);
            this.metroLabel3.TabIndex = 4;
            this.metroLabel3.Text = "Description";
            this.metroLabel3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtName
            // 
            this.txtName.AutoCompleteCustomSource = null;
            this.txtName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtName.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtName.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            this.txtName.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.txtName.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            this.txtName.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            this.txtName.Dock = System.Windows.Forms.DockStyle.Left;
            this.txtName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtName.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.txtName.Image = null;
            this.txtName.IsDerivedStyle = true;
            this.txtName.Lines = null;
            this.txtName.Location = new System.Drawing.Point(94, 39);
            this.txtName.MaxLength = 32767;
            this.txtName.Multiline = false;
            this.txtName.Name = "txtName";
            this.txtName.ReadOnly = false;
            this.txtName.Size = new System.Drawing.Size(202, 30);
            this.txtName.Style = MetroSet_UI.Enums.Style.Light;
            this.txtName.StyleManager = null;
            this.txtName.TabIndex = 3;
            this.txtName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtName.ThemeAuthor = "Narwin";
            this.txtName.ThemeName = "MetroLite";
            this.txtName.UseSystemPasswordChar = false;
            this.txtName.WatermarkText = "";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.metroLabel2.Location = new System.Drawing.Point(43, 36);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(45, 36);
            this.metroLabel2.TabIndex = 2;
            this.metroLabel2.Text = "Name";
            this.metroLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtID
            // 
            this.txtID.AutoCompleteCustomSource = null;
            this.txtID.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtID.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtID.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            this.txtID.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.txtID.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            this.txtID.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            this.txtID.Dock = System.Windows.Forms.DockStyle.Left;
            this.txtID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtID.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.txtID.Image = null;
            this.txtID.IsDerivedStyle = true;
            this.txtID.Lines = null;
            this.txtID.Location = new System.Drawing.Point(94, 3);
            this.txtID.MaxLength = 32767;
            this.txtID.Multiline = false;
            this.txtID.Name = "txtID";
            this.txtID.ReadOnly = false;
            this.txtID.Size = new System.Drawing.Size(202, 30);
            this.txtID.Style = MetroSet_UI.Enums.Style.Light;
            this.txtID.StyleManager = null;
            this.txtID.TabIndex = 0;
            this.txtID.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtID.ThemeAuthor = "Narwin";
            this.txtID.ThemeName = "MetroLite";
            this.txtID.UseSystemPasswordChar = false;
            this.txtID.WatermarkText = "";
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.metroLabel1.Location = new System.Drawing.Point(67, 0);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(21, 36);
            this.metroLabel1.TabIndex = 1;
            this.metroLabel1.Text = "ID";
            this.metroLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnEditOrAdd
            // 
            this.btnEditOrAdd.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.btnEditOrAdd.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.btnEditOrAdd.DisabledForeColor = System.Drawing.Color.Gray;
            this.btnEditOrAdd.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnEditOrAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnEditOrAdd.HoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(207)))), ((int)(((byte)(255)))));
            this.btnEditOrAdd.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(207)))), ((int)(((byte)(255)))));
            this.btnEditOrAdd.HoverTextColor = System.Drawing.Color.White;
            this.btnEditOrAdd.IsDerivedStyle = true;
            this.btnEditOrAdd.Location = new System.Drawing.Point(3, 266);
            this.btnEditOrAdd.Name = "btnEditOrAdd";
            this.btnEditOrAdd.NormalBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.btnEditOrAdd.NormalColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.btnEditOrAdd.NormalTextColor = System.Drawing.Color.White;
            this.btnEditOrAdd.PressBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(147)))), ((int)(((byte)(195)))));
            this.btnEditOrAdd.PressColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(147)))), ((int)(((byte)(195)))));
            this.btnEditOrAdd.PressTextColor = System.Drawing.Color.White;
            this.btnEditOrAdd.Size = new System.Drawing.Size(306, 50);
            this.btnEditOrAdd.Style = MetroSet_UI.Enums.Style.Light;
            this.btnEditOrAdd.StyleManager = null;
            this.btnEditOrAdd.TabIndex = 2;
            this.btnEditOrAdd.Text = "Edit/Add";
            this.btnEditOrAdd.ThemeAuthor = "Narwin";
            this.btnEditOrAdd.ThemeName = "MetroLite";
            this.btnEditOrAdd.Click += new System.EventHandler(this.btnEditOrAdd_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.btnDelete.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.btnDelete.DisabledForeColor = System.Drawing.Color.Gray;
            this.btnDelete.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnDelete.HoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(207)))), ((int)(((byte)(255)))));
            this.btnDelete.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(207)))), ((int)(((byte)(255)))));
            this.btnDelete.HoverTextColor = System.Drawing.Color.White;
            this.btnDelete.IsDerivedStyle = true;
            this.btnDelete.Location = new System.Drawing.Point(3, 331);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.NormalBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.btnDelete.NormalColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.btnDelete.NormalTextColor = System.Drawing.Color.White;
            this.btnDelete.PressBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(147)))), ((int)(((byte)(195)))));
            this.btnDelete.PressColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(147)))), ((int)(((byte)(195)))));
            this.btnDelete.PressTextColor = System.Drawing.Color.White;
            this.btnDelete.Size = new System.Drawing.Size(306, 50);
            this.btnDelete.Style = MetroSet_UI.Enums.Style.Light;
            this.btnDelete.StyleManager = null;
            this.btnDelete.TabIndex = 3;
            this.btnDelete.Text = "Delete";
            this.btnDelete.ThemeAuthor = "Narwin";
            this.btnDelete.ThemeName = "MetroLite";
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.ColumnCount = 1;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel5.Controls.Add(this.btnBack, 0, 2);
            this.tableLayoutPanel5.Controls.Add(this.tableLayoutPanel6, 0, 0);
            this.tableLayoutPanel5.Controls.Add(this.btnSearch, 0, 1);
            this.tableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel5.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 3;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 66.66666F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(312, 194);
            this.tableLayoutPanel5.TabIndex = 1;
            this.tableLayoutPanel5.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel5_Paint);
            // 
            // btnBack
            // 
            this.btnBack.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.btnBack.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.btnBack.DisabledForeColor = System.Drawing.Color.Gray;
            this.btnBack.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnBack.HoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(207)))), ((int)(((byte)(255)))));
            this.btnBack.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(207)))), ((int)(((byte)(255)))));
            this.btnBack.HoverTextColor = System.Drawing.Color.White;
            this.btnBack.IsDerivedStyle = true;
            this.btnBack.Location = new System.Drawing.Point(3, 164);
            this.btnBack.Name = "btnBack";
            this.btnBack.NormalBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.btnBack.NormalColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.btnBack.NormalTextColor = System.Drawing.Color.White;
            this.btnBack.PressBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(147)))), ((int)(((byte)(195)))));
            this.btnBack.PressColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(147)))), ((int)(((byte)(195)))));
            this.btnBack.PressTextColor = System.Drawing.Color.White;
            this.btnBack.Size = new System.Drawing.Size(306, 27);
            this.btnBack.Style = MetroSet_UI.Enums.Style.Light;
            this.btnBack.StyleManager = null;
            this.btnBack.TabIndex = 5;
            this.btnBack.Text = "Back";
            this.btnBack.ThemeAuthor = "Narwin";
            this.btnBack.ThemeName = "MetroLite";
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // tableLayoutPanel6
            // 
            this.tableLayoutPanel6.ColumnCount = 2;
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tableLayoutPanel6.Controls.Add(this.metroLabel8, 0, 2);
            this.tableLayoutPanel6.Controls.Add(this.txtCategorySearch, 1, 1);
            this.tableLayoutPanel6.Controls.Add(this.metroLabel6, 0, 1);
            this.tableLayoutPanel6.Controls.Add(this.txtNameSearch, 1, 0);
            this.tableLayoutPanel6.Controls.Add(this.metroLabel4, 0, 0);
            this.tableLayoutPanel6.Controls.Add(this.comboBoxStock, 1, 2);
            this.tableLayoutPanel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel6.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel6.Name = "tableLayoutPanel6";
            this.tableLayoutPanel6.RowCount = 3;
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tableLayoutPanel6.Size = new System.Drawing.Size(306, 123);
            this.tableLayoutPanel6.TabIndex = 0;
            // 
            // metroLabel8
            // 
            this.metroLabel8.AutoSize = true;
            this.metroLabel8.Dock = System.Windows.Forms.DockStyle.Right;
            this.metroLabel8.Location = new System.Drawing.Point(48, 81);
            this.metroLabel8.Name = "metroLabel8";
            this.metroLabel8.Size = new System.Drawing.Size(40, 42);
            this.metroLabel8.TabIndex = 7;
            this.metroLabel8.Text = "Stock";
            this.metroLabel8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtCategorySearch
            // 
            this.txtCategorySearch.AutoCompleteCustomSource = null;
            this.txtCategorySearch.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtCategorySearch.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtCategorySearch.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            this.txtCategorySearch.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.txtCategorySearch.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            this.txtCategorySearch.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            this.txtCategorySearch.Dock = System.Windows.Forms.DockStyle.Left;
            this.txtCategorySearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtCategorySearch.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.txtCategorySearch.Image = null;
            this.txtCategorySearch.IsDerivedStyle = true;
            this.txtCategorySearch.Lines = null;
            this.txtCategorySearch.Location = new System.Drawing.Point(94, 43);
            this.txtCategorySearch.MaxLength = 32767;
            this.txtCategorySearch.Multiline = false;
            this.txtCategorySearch.Name = "txtCategorySearch";
            this.txtCategorySearch.ReadOnly = false;
            this.txtCategorySearch.Size = new System.Drawing.Size(202, 35);
            this.txtCategorySearch.Style = MetroSet_UI.Enums.Style.Light;
            this.txtCategorySearch.StyleManager = null;
            this.txtCategorySearch.TabIndex = 6;
            this.txtCategorySearch.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtCategorySearch.ThemeAuthor = "Narwin";
            this.txtCategorySearch.ThemeName = "MetroLite";
            this.txtCategorySearch.UseSystemPasswordChar = false;
            this.txtCategorySearch.WatermarkText = "";
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.Dock = System.Windows.Forms.DockStyle.Right;
            this.metroLabel6.Location = new System.Drawing.Point(24, 40);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(64, 41);
            this.metroLabel6.TabIndex = 5;
            this.metroLabel6.Text = "Category";
            this.metroLabel6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtNameSearch
            // 
            this.txtNameSearch.AutoCompleteCustomSource = null;
            this.txtNameSearch.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtNameSearch.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtNameSearch.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            this.txtNameSearch.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.txtNameSearch.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            this.txtNameSearch.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            this.txtNameSearch.Dock = System.Windows.Forms.DockStyle.Left;
            this.txtNameSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtNameSearch.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.txtNameSearch.Image = null;
            this.txtNameSearch.IsDerivedStyle = true;
            this.txtNameSearch.Lines = null;
            this.txtNameSearch.Location = new System.Drawing.Point(94, 3);
            this.txtNameSearch.MaxLength = 32767;
            this.txtNameSearch.Multiline = false;
            this.txtNameSearch.Name = "txtNameSearch";
            this.txtNameSearch.ReadOnly = false;
            this.txtNameSearch.Size = new System.Drawing.Size(202, 34);
            this.txtNameSearch.Style = MetroSet_UI.Enums.Style.Light;
            this.txtNameSearch.StyleManager = null;
            this.txtNameSearch.TabIndex = 4;
            this.txtNameSearch.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtNameSearch.ThemeAuthor = "Narwin";
            this.txtNameSearch.ThemeName = "MetroLite";
            this.txtNameSearch.UseSystemPasswordChar = false;
            this.txtNameSearch.WatermarkText = "";
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Dock = System.Windows.Forms.DockStyle.Right;
            this.metroLabel4.Location = new System.Drawing.Point(43, 0);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(45, 40);
            this.metroLabel4.TabIndex = 2;
            this.metroLabel4.Text = "Name";
            this.metroLabel4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnSearch
            // 
            this.btnSearch.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.btnSearch.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.btnSearch.DisabledForeColor = System.Drawing.Color.Gray;
            this.btnSearch.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnSearch.HoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(207)))), ((int)(((byte)(255)))));
            this.btnSearch.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(207)))), ((int)(((byte)(255)))));
            this.btnSearch.HoverTextColor = System.Drawing.Color.White;
            this.btnSearch.IsDerivedStyle = true;
            this.btnSearch.Location = new System.Drawing.Point(3, 132);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.NormalBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.btnSearch.NormalColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.btnSearch.NormalTextColor = System.Drawing.Color.White;
            this.btnSearch.PressBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(147)))), ((int)(((byte)(195)))));
            this.btnSearch.PressColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(147)))), ((int)(((byte)(195)))));
            this.btnSearch.PressTextColor = System.Drawing.Color.White;
            this.btnSearch.Size = new System.Drawing.Size(306, 26);
            this.btnSearch.Style = MetroSet_UI.Enums.Style.Light;
            this.btnSearch.StyleManager = null;
            this.btnSearch.TabIndex = 1;
            this.btnSearch.Text = "Search";
            this.btnSearch.ThemeAuthor = "Narwin";
            this.btnSearch.ThemeName = "MetroLite";
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // dataGridView
            // 
            this.dataGridView.AllowUserToAddRows = false;
            this.dataGridView.AllowUserToDeleteRows = false;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView.Location = new System.Drawing.Point(3, 3);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.ReadOnly = true;
            this.dataGridView.Size = new System.Drawing.Size(750, 621);
            this.dataGridView.TabIndex = 3;
            // 
            // productsBindingSource
            // 
            this.productsBindingSource.DataMember = "Products";
            // 
            // comboBoxStock
            // 
            this.comboBoxStock.AllowDrop = true;
            this.comboBoxStock.ArrowColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.comboBoxStock.BackColor = System.Drawing.Color.Transparent;
            this.comboBoxStock.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.comboBoxStock.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.comboBoxStock.CausesValidation = false;
            this.comboBoxStock.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.comboBoxStock.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            this.comboBoxStock.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            this.comboBoxStock.Dock = System.Windows.Forms.DockStyle.Left;
            this.comboBoxStock.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.comboBoxStock.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxStock.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.comboBoxStock.FormattingEnabled = true;
            this.comboBoxStock.IsDerivedStyle = true;
            this.comboBoxStock.ItemHeight = 20;
            this.comboBoxStock.Items.AddRange(new object[] {
            "OUT OF STOCK",
            "LOW STOCK",
            "HIGH STOCK"});
            this.comboBoxStock.Location = new System.Drawing.Point(94, 84);
            this.comboBoxStock.Name = "comboBoxStock";
            this.comboBoxStock.SelectedItemBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.comboBoxStock.SelectedItemForeColor = System.Drawing.Color.White;
            this.comboBoxStock.Size = new System.Drawing.Size(202, 26);
            this.comboBoxStock.Style = MetroSet_UI.Enums.Style.Light;
            this.comboBoxStock.StyleManager = null;
            this.comboBoxStock.TabIndex = 8;
            this.comboBoxStock.ThemeAuthor = "Narwin";
            this.comboBoxStock.ThemeName = "MetroLite";
            // 
            // Products
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1120, 707);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Products";
            this.Text = "Products";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tblAdmin.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tableLayoutPanel5.ResumeLayout(false);
            this.tableLayoutPanel6.ResumeLayout(false);
            this.tableLayoutPanel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productsBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel6;
        private MetroSet_UI.Controls.MetroSetButton btnSearch;
        private MetroFramework.Controls.MetroLabel metroLabel8;
        private MetroSet_UI.Controls.MetroSetTextBox txtCategorySearch;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private MetroSet_UI.Controls.MetroSetTextBox txtNameSearch;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private System.Windows.Forms.BindingSource productsBindingSource;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.TableLayoutPanel tblAdmin;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private MetroSet_UI.Controls.MetroSetTextBox txtSupplier;
        private MetroFramework.Controls.MetroLabel metroLabel10;
        private MetroSet_UI.Controls.MetroSetTextBox txtCategory;
        private MetroFramework.Controls.MetroLabel metroLabel9;
        private MetroFramework.Controls.MetroLabel metroLabel7;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroSet_UI.Controls.MetroSetTextBox txtDescription;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroSet_UI.Controls.MetroSetTextBox txtName;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroSet_UI.Controls.MetroSetTextBox txtID;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroSet_UI.Controls.MetroSetButton btnEditOrAdd;
        private MetroSet_UI.Controls.MetroSetButton btnDelete;
        private MetroSet_UI.Controls.MetroSetButton btnBack;
        private MetroSet_UI.Controls.MetroSetTextBox txtPrice;
        private MetroSet_UI.Controls.MetroSetTextBox txtQuantity;
        private MetroSet_UI.Controls.MetroSetComboBox comboBoxStock;
    }
}