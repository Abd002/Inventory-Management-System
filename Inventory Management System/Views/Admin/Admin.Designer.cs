namespace Inventory_Management_System.Views.Admin
{
    partial class Admin
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
            this.btnAddAdmin = new MetroSet_UI.Controls.MetroSetButton();
            this.SuspendLayout();
            // 
            // btnAddAdmin
            // 
            this.btnAddAdmin.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.btnAddAdmin.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.btnAddAdmin.DisabledForeColor = System.Drawing.Color.Gray;
            this.btnAddAdmin.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnAddAdmin.HoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(207)))), ((int)(((byte)(255)))));
            this.btnAddAdmin.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(207)))), ((int)(((byte)(255)))));
            this.btnAddAdmin.HoverTextColor = System.Drawing.Color.White;
            this.btnAddAdmin.IsDerivedStyle = true;
            this.btnAddAdmin.Location = new System.Drawing.Point(312, 371);
            this.btnAddAdmin.Name = "btnAddAdmin";
            this.btnAddAdmin.NormalBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.btnAddAdmin.NormalColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.btnAddAdmin.NormalTextColor = System.Drawing.Color.White;
            this.btnAddAdmin.PressBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(147)))), ((int)(((byte)(195)))));
            this.btnAddAdmin.PressColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(147)))), ((int)(((byte)(195)))));
            this.btnAddAdmin.PressTextColor = System.Drawing.Color.White;
            this.btnAddAdmin.Size = new System.Drawing.Size(174, 23);
            this.btnAddAdmin.Style = MetroSet_UI.Enums.Style.Light;
            this.btnAddAdmin.StyleManager = null;
            this.btnAddAdmin.TabIndex = 1;
            this.btnAddAdmin.Text = "Add Admin";
            this.btnAddAdmin.ThemeAuthor = "Narwin";
            this.btnAddAdmin.ThemeName = "MetroLite";
            // 
            // Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnAddAdmin);
            this.Name = "Admin";
            this.Text = "Admin";
            this.ResumeLayout(false);

        }

        #endregion
        private MetroSet_UI.Controls.MetroSetButton btnAddAdmin;
    }
}