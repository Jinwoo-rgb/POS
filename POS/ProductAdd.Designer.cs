namespace POS_System
{
    partial class ProductAdd
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
            this.cbCat = new Guna.UI2.WinForms.Guna2ComboBox();
            this.crownLabel3 = new ReaLTaiizor.Controls.CrownLabel();
            this.txtPrice = new Guna.UI2.WinForms.Guna2TextBox();
            this.crownLabel2 = new ReaLTaiizor.Controls.CrownLabel();
            this.txtName = new Guna.UI2.WinForms.Guna2TextBox();
            this.crownLabel1 = new ReaLTaiizor.Controls.CrownLabel();
            this.txtPic = new Guna.UI2.WinForms.Guna2PictureBox();
            this.brwseBtn = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).BeginInit();
            this.guna2Panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtPic)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.Size = new System.Drawing.Size(953, 121);
            // 
            // bigLabel1
            // 
            this.bigLabel1.Size = new System.Drawing.Size(248, 46);
            this.bigLabel1.Text = "Product Details";
            // 
            // guna2PictureBox1
            // 
            this.guna2PictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.guna2PictureBox1.Image = global::POS_System.Properties.Resources.pngfind_com_package_png_1312918;
            this.guna2PictureBox1.ImageFlip = Guna.UI2.WinForms.Enums.FlipOrientation.Normal;
            this.guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.guna2PictureBox1.UseTransparentBackground = true;
            // 
            // guna2Panel2
            // 
            this.guna2Panel2.Location = new System.Drawing.Point(0, 531);
            this.guna2Panel2.Size = new System.Drawing.Size(953, 81);
            // 
            // SaveBtn
            // 
            this.SaveBtn.DialogResult = System.Windows.Forms.DialogResult.None;
            this.SaveBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.SaveBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.SaveBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.SaveBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.SaveBtn.HoverState.FillColor = System.Drawing.Color.Goldenrod;
            this.SaveBtn.HoverState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(51)))), ((int)(((byte)(63)))));
            // 
            // guna2Button1
            // 
            this.guna2Button1.DialogResult = System.Windows.Forms.DialogResult.None;
            this.guna2Button1.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button1.HoverState.FillColor = System.Drawing.Color.Goldenrod;
            this.guna2Button1.HoverState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(51)))), ((int)(((byte)(63)))));
            // 
            // cbCat
            // 
            this.cbCat.BackColor = System.Drawing.Color.Transparent;
            this.cbCat.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbCat.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCat.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbCat.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbCat.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.cbCat.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cbCat.ItemHeight = 30;
            this.cbCat.Items.AddRange(new object[] {
            "Drinks",
            "Burger",
            "Meal"});
            this.cbCat.Location = new System.Drawing.Point(36, 283);
            this.cbCat.Name = "cbCat";
            this.cbCat.Size = new System.Drawing.Size(301, 36);
            this.cbCat.TabIndex = 14;
            // 
            // crownLabel3
            // 
            this.crownLabel3.AutoSize = true;
            this.crownLabel3.BackColor = System.Drawing.SystemColors.Control;
            this.crownLabel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.crownLabel3.ForeColor = System.Drawing.Color.Goldenrod;
            this.crownLabel3.Location = new System.Drawing.Point(32, 260);
            this.crownLabel3.Name = "crownLabel3";
            this.crownLabel3.Size = new System.Drawing.Size(76, 20);
            this.crownLabel3.TabIndex = 13;
            this.crownLabel3.Text = "Category";
            // 
            // txtPrice
            // 
            this.txtPrice.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPrice.DefaultText = "";
            this.txtPrice.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtPrice.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtPrice.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPrice.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPrice.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPrice.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtPrice.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPrice.Location = new System.Drawing.Point(381, 170);
            this.txtPrice.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.PasswordChar = '\0';
            this.txtPrice.PlaceholderText = "";
            this.txtPrice.SelectedText = "";
            this.txtPrice.Size = new System.Drawing.Size(301, 48);
            this.txtPrice.TabIndex = 10;
            // 
            // crownLabel2
            // 
            this.crownLabel2.AutoSize = true;
            this.crownLabel2.BackColor = System.Drawing.SystemColors.Control;
            this.crownLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.crownLabel2.ForeColor = System.Drawing.Color.Goldenrod;
            this.crownLabel2.Location = new System.Drawing.Point(377, 146);
            this.crownLabel2.Name = "crownLabel2";
            this.crownLabel2.Size = new System.Drawing.Size(48, 20);
            this.crownLabel2.TabIndex = 12;
            this.crownLabel2.Text = "Price";
            // 
            // txtName
            // 
            this.txtName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtName.DefaultText = "";
            this.txtName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtName.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtName.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtName.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtName.Location = new System.Drawing.Point(36, 170);
            this.txtName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtName.Name = "txtName";
            this.txtName.PasswordChar = '\0';
            this.txtName.PlaceholderText = "";
            this.txtName.SelectedText = "";
            this.txtName.Size = new System.Drawing.Size(301, 48);
            this.txtName.TabIndex = 9;
            // 
            // crownLabel1
            // 
            this.crownLabel1.AutoSize = true;
            this.crownLabel1.BackColor = System.Drawing.SystemColors.Control;
            this.crownLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.crownLabel1.ForeColor = System.Drawing.Color.Goldenrod;
            this.crownLabel1.Location = new System.Drawing.Point(32, 146);
            this.crownLabel1.Name = "crownLabel1";
            this.crownLabel1.Size = new System.Drawing.Size(53, 20);
            this.crownLabel1.TabIndex = 11;
            this.crownLabel1.Text = "Name";
            // 
            // txtPic
            // 
            this.txtPic.Image = global::POS_System.Properties.Resources.shopping_bag_icon_5;
            this.txtPic.ImageRotate = 0F;
            this.txtPic.Location = new System.Drawing.Point(744, 170);
            this.txtPic.Name = "txtPic";
            this.txtPic.Size = new System.Drawing.Size(168, 149);
            this.txtPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.txtPic.TabIndex = 15;
            this.txtPic.TabStop = false;
            // 
            // brwseBtn
            // 
            this.brwseBtn.AutoRoundedCorners = true;
            this.brwseBtn.BorderRadius = 21;
            this.brwseBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.brwseBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.brwseBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.brwseBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.brwseBtn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.brwseBtn.ForeColor = System.Drawing.Color.White;
            this.brwseBtn.Location = new System.Drawing.Point(744, 343);
            this.brwseBtn.Name = "brwseBtn";
            this.brwseBtn.Size = new System.Drawing.Size(168, 45);
            this.brwseBtn.TabIndex = 16;
            this.brwseBtn.Text = "BROWSE";
            this.brwseBtn.Click += new System.EventHandler(this.brwseBtn_Click);
            // 
            // ProductAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(953, 612);
            this.Controls.Add(this.brwseBtn);
            this.Controls.Add(this.txtPic);
            this.Controls.Add(this.cbCat);
            this.Controls.Add(this.crownLabel3);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.crownLabel2);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.crownLabel1);
            this.Name = "ProductAdd";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ProductAdd";
            this.Load += new System.EventHandler(this.ProductAdd_Load);
            this.Controls.SetChildIndex(this.guna2Panel1, 0);
            this.Controls.SetChildIndex(this.guna2Panel2, 0);
            this.Controls.SetChildIndex(this.crownLabel1, 0);
            this.Controls.SetChildIndex(this.txtName, 0);
            this.Controls.SetChildIndex(this.crownLabel2, 0);
            this.Controls.SetChildIndex(this.txtPrice, 0);
            this.Controls.SetChildIndex(this.crownLabel3, 0);
            this.Controls.SetChildIndex(this.cbCat, 0);
            this.Controls.SetChildIndex(this.txtPic, 0);
            this.Controls.SetChildIndex(this.brwseBtn, 0);
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).EndInit();
            this.guna2Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txtPic)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public Guna.UI2.WinForms.Guna2ComboBox cbCat;
        private ReaLTaiizor.Controls.CrownLabel crownLabel3;
        public Guna.UI2.WinForms.Guna2TextBox txtPrice;
        private ReaLTaiizor.Controls.CrownLabel crownLabel2;
        public Guna.UI2.WinForms.Guna2TextBox txtName;
        private ReaLTaiizor.Controls.CrownLabel crownLabel1;
        private Guna.UI2.WinForms.Guna2PictureBox txtPic;
        private Guna.UI2.WinForms.Guna2Button brwseBtn;
    }
}