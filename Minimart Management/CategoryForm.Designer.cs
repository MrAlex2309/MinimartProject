namespace Minimart_Management
{
    partial class CategoryForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label_logout = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.CatId_Textbox = new Guna.UI2.WinForms.Guna2TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.CatDelete_button = new System.Windows.Forms.Button();
            this.CatName_Textbox = new Guna.UI2.WinForms.Guna2TextBox();
            this.CatUpdate_Button = new System.Windows.Forms.Button();
            this.category_label = new System.Windows.Forms.Label();
            this.product_label = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.CatAdd_Button = new System.Windows.Forms.Button();
            this.CatDescription_Textbox = new Guna.UI2.WinForms.Guna2TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.guna2DataGridView_Cat = new Guna.UI2.WinForms.Guna2DataGridView();
            this.Seller_label = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2DataGridView_Cat)).BeginInit();
            this.SuspendLayout();
            // 
            // label_logout
            // 
            this.label_logout.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label_logout.AutoSize = true;
            this.label_logout.Font = new System.Drawing.Font("Sitka Display", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_logout.Location = new System.Drawing.Point(13, 574);
            this.label_logout.Name = "label_logout";
            this.label_logout.Size = new System.Drawing.Size(79, 35);
            this.label_logout.TabIndex = 42;
            this.label_logout.Text = "Logout";
            this.label_logout.Click += new System.EventHandler(this.label_logout_Click);
            this.label_logout.MouseEnter += new System.EventHandler(this.label_logout_MouseEnter);
            this.label_logout.MouseLeave += new System.EventHandler(this.label_logout_MouseLeave);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Sitka Heading", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(369, 1);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(257, 39);
            this.label6.TabIndex = 32;
            this.label6.Text = "MANAGE CATEGORY";
            // 
            // CatId_Textbox
            // 
            this.CatId_Textbox.BorderRadius = 15;
            this.CatId_Textbox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.CatId_Textbox.DefaultText = "";
            this.CatId_Textbox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.CatId_Textbox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.CatId_Textbox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.CatId_Textbox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.CatId_Textbox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.CatId_Textbox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.CatId_Textbox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.CatId_Textbox.Location = new System.Drawing.Point(130, 118);
            this.CatId_Textbox.Name = "CatId_Textbox";
            this.CatId_Textbox.PasswordChar = '\0';
            this.CatId_Textbox.PlaceholderText = "";
            this.CatId_Textbox.SelectedText = "";
            this.CatId_Textbox.Size = new System.Drawing.Size(200, 36);
            this.CatId_Textbox.TabIndex = 18;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Sitka Display", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(23, 117);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 35);
            this.label1.TabIndex = 17;
            this.label1.Text = "ID";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Sitka Display", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(23, 159);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 35);
            this.label5.TabIndex = 19;
            this.label5.Text = "Name";
            // 
            // CatDelete_button
            // 
            this.CatDelete_button.BackColor = System.Drawing.Color.NavajoWhite;
            this.CatDelete_button.FlatAppearance.BorderSize = 0;
            this.CatDelete_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CatDelete_button.Font = new System.Drawing.Font("Sitka Display", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CatDelete_button.Location = new System.Drawing.Point(243, 298);
            this.CatDelete_button.Name = "CatDelete_button";
            this.CatDelete_button.Size = new System.Drawing.Size(90, 37);
            this.CatDelete_button.TabIndex = 29;
            this.CatDelete_button.Text = "Delete";
            this.CatDelete_button.UseVisualStyleBackColor = false;
            this.CatDelete_button.Click += new System.EventHandler(this.CatDelete_button_Click);
            // 
            // CatName_Textbox
            // 
            this.CatName_Textbox.BorderRadius = 15;
            this.CatName_Textbox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.CatName_Textbox.DefaultText = "";
            this.CatName_Textbox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.CatName_Textbox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.CatName_Textbox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.CatName_Textbox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.CatName_Textbox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.CatName_Textbox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.CatName_Textbox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.CatName_Textbox.Location = new System.Drawing.Point(130, 160);
            this.CatName_Textbox.Name = "CatName_Textbox";
            this.CatName_Textbox.PasswordChar = '\0';
            this.CatName_Textbox.PlaceholderText = "";
            this.CatName_Textbox.SelectedText = "";
            this.CatName_Textbox.Size = new System.Drawing.Size(200, 36);
            this.CatName_Textbox.TabIndex = 20;
            // 
            // CatUpdate_Button
            // 
            this.CatUpdate_Button.BackColor = System.Drawing.Color.NavajoWhite;
            this.CatUpdate_Button.FlatAppearance.BorderSize = 0;
            this.CatUpdate_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CatUpdate_Button.Font = new System.Drawing.Font("Sitka Display", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CatUpdate_Button.Location = new System.Drawing.Point(147, 298);
            this.CatUpdate_Button.Name = "CatUpdate_Button";
            this.CatUpdate_Button.Size = new System.Drawing.Size(90, 37);
            this.CatUpdate_Button.TabIndex = 28;
            this.CatUpdate_Button.Text = "Update";
            this.CatUpdate_Button.UseVisualStyleBackColor = false;
            this.CatUpdate_Button.Click += new System.EventHandler(this.CatUpdate_Button_Click);
            // 
            // category_label
            // 
            this.category_label.AutoSize = true;
            this.category_label.Font = new System.Drawing.Font("Sitka Display", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.category_label.Location = new System.Drawing.Point(22, 145);
            this.category_label.Name = "category_label";
            this.category_label.Size = new System.Drawing.Size(99, 35);
            this.category_label.TabIndex = 40;
            this.category_label.Text = "Category";
            this.category_label.MouseEnter += new System.EventHandler(this.category_label_MouseEnter);
            this.category_label.MouseLeave += new System.EventHandler(this.category_label_MouseLeave);
            // 
            // product_label
            // 
            this.product_label.AutoSize = true;
            this.product_label.Font = new System.Drawing.Font("Sitka Display", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.product_label.Location = new System.Drawing.Point(27, 70);
            this.product_label.Name = "product_label";
            this.product_label.Size = new System.Drawing.Size(88, 35);
            this.product_label.TabIndex = 39;
            this.product_label.Text = "Product";
            this.product_label.Click += new System.EventHandler(this.product_label_Click);
            this.product_label.MouseEnter += new System.EventHandler(this.product_label_MouseEnter);
            this.product_label.MouseLeave += new System.EventHandler(this.product_label_MouseLeave);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Sitka Display", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(23, 201);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(123, 35);
            this.label2.TabIndex = 21;
            this.label2.Text = "Description";
            // 
            // CatAdd_Button
            // 
            this.CatAdd_Button.BackColor = System.Drawing.Color.NavajoWhite;
            this.CatAdd_Button.FlatAppearance.BorderSize = 0;
            this.CatAdd_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CatAdd_Button.Font = new System.Drawing.Font("Sitka Display", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CatAdd_Button.Location = new System.Drawing.Point(51, 298);
            this.CatAdd_Button.Name = "CatAdd_Button";
            this.CatAdd_Button.Size = new System.Drawing.Size(90, 37);
            this.CatAdd_Button.TabIndex = 27;
            this.CatAdd_Button.Text = "Add";
            this.CatAdd_Button.UseVisualStyleBackColor = false;
            this.CatAdd_Button.Click += new System.EventHandler(this.CatAdd_Button_Click);
            // 
            // CatDescription_Textbox
            // 
            this.CatDescription_Textbox.BorderRadius = 15;
            this.CatDescription_Textbox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.CatDescription_Textbox.DefaultText = "";
            this.CatDescription_Textbox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.CatDescription_Textbox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.CatDescription_Textbox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.CatDescription_Textbox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.CatDescription_Textbox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.CatDescription_Textbox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.CatDescription_Textbox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.CatDescription_Textbox.Location = new System.Drawing.Point(147, 202);
            this.CatDescription_Textbox.Name = "CatDescription_Textbox";
            this.CatDescription_Textbox.PasswordChar = '\0';
            this.CatDescription_Textbox.PlaceholderText = "";
            this.CatDescription_Textbox.SelectedText = "";
            this.CatDescription_Textbox.Size = new System.Drawing.Size(183, 36);
            this.CatDescription_Textbox.TabIndex = 22;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.NavajoWhite;
            this.panel1.Controls.Add(this.guna2DataGridView_Cat);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.CatId_Textbox);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.CatDelete_button);
            this.panel1.Controls.Add(this.CatName_Textbox);
            this.panel1.Controls.Add(this.CatUpdate_Button);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.CatAdd_Button);
            this.panel1.Controls.Add(this.CatDescription_Textbox);
            this.panel1.Location = new System.Drawing.Point(150, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(990, 623);
            this.panel1.TabIndex = 37;
            // 
            // guna2DataGridView_Cat
            // 
            this.guna2DataGridView_Cat.AllowUserToAddRows = false;
            this.guna2DataGridView_Cat.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.guna2DataGridView_Cat.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.guna2DataGridView_Cat.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.guna2DataGridView_Cat.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.guna2DataGridView_Cat.ColumnHeadersHeight = 24;
            this.guna2DataGridView_Cat.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.guna2DataGridView_Cat.DefaultCellStyle = dataGridViewCellStyle3;
            this.guna2DataGridView_Cat.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.guna2DataGridView_Cat.Location = new System.Drawing.Point(352, 109);
            this.guna2DataGridView_Cat.Name = "guna2DataGridView_Cat";
            this.guna2DataGridView_Cat.ReadOnly = true;
            this.guna2DataGridView_Cat.RowHeadersVisible = false;
            this.guna2DataGridView_Cat.Size = new System.Drawing.Size(635, 511);
            this.guna2DataGridView_Cat.TabIndex = 33;
            this.guna2DataGridView_Cat.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.guna2DataGridView_Cat.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.guna2DataGridView_Cat.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.guna2DataGridView_Cat.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.guna2DataGridView_Cat.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.guna2DataGridView_Cat.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.guna2DataGridView_Cat.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.guna2DataGridView_Cat.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.guna2DataGridView_Cat.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.guna2DataGridView_Cat.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2DataGridView_Cat.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.guna2DataGridView_Cat.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.guna2DataGridView_Cat.ThemeStyle.HeaderStyle.Height = 24;
            this.guna2DataGridView_Cat.ThemeStyle.ReadOnly = true;
            this.guna2DataGridView_Cat.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.guna2DataGridView_Cat.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.guna2DataGridView_Cat.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2DataGridView_Cat.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.guna2DataGridView_Cat.ThemeStyle.RowsStyle.Height = 22;
            this.guna2DataGridView_Cat.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.guna2DataGridView_Cat.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.guna2DataGridView_Cat.Click += new System.EventHandler(this.guna2DataGridView_Cat_Click);
            // 
            // Seller_label
            // 
            this.Seller_label.AutoSize = true;
            this.Seller_label.Font = new System.Drawing.Font("Sitka Display", 18F);
            this.Seller_label.Location = new System.Drawing.Point(36, 213);
            this.Seller_label.Name = "Seller_label";
            this.Seller_label.Size = new System.Drawing.Size(68, 35);
            this.Seller_label.TabIndex = 43;
            this.Seller_label.Text = "Seller";
            this.Seller_label.Click += new System.EventHandler(this.Seller_label_Click);
            this.Seller_label.MouseEnter += new System.EventHandler(this.Seller_label_MouseEnter);
            this.Seller_label.MouseLeave += new System.EventHandler(this.Seller_label_MouseLeave);
            // 
            // CategoryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1140, 625);
            this.Controls.Add(this.Seller_label);
            this.Controls.Add(this.label_logout);
            this.Controls.Add(this.category_label);
            this.Controls.Add(this.product_label);
            this.Controls.Add(this.panel1);
            this.Name = "CategoryForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CategoryForm";
            this.Load += new System.EventHandler(this.CategoryForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2DataGridView_Cat)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_logout;
        private System.Windows.Forms.Label label6;
        private Guna.UI2.WinForms.Guna2TextBox CatId_Textbox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button CatDelete_button;
        private Guna.UI2.WinForms.Guna2TextBox CatName_Textbox;
        private System.Windows.Forms.Button CatUpdate_Button;
        private System.Windows.Forms.Label category_label;
        private System.Windows.Forms.Label product_label;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button CatAdd_Button;
        private Guna.UI2.WinForms.Guna2TextBox CatDescription_Textbox;
        private System.Windows.Forms.Panel panel1;
        private Guna.UI2.WinForms.Guna2DataGridView guna2DataGridView_Cat;
        private System.Windows.Forms.Label Seller_label;
    }
}