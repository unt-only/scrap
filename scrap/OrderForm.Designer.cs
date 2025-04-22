namespace scrap
{
    partial class OrderForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OrderForm));
            this.nudQuantity = new System.Windows.Forms.NumericUpDown();
            this.nudPurchasePrice = new System.Windows.Forms.NumericUpDown();
            this.nudRetailPrice = new System.Windows.Forms.NumericUpDown();
            this.dtpPurchaseDate = new System.Windows.Forms.DateTimePicker();
            this.dataGridViewInvoice = new System.Windows.Forms.DataGridView();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.comboBoxSuppliers = new System.Windows.Forms.ComboBox();
            this.comboBoxCategories = new System.Windows.Forms.ComboBox();
            this.listBoxSupplierProducts = new System.Windows.Forms.ListBox();
            this.nudSupplierQuantity = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtProductName = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnAddToInvoice = new Guna.UI2.WinForms.Guna2Button();
            this.btnGenerateInvoice = new Guna.UI2.WinForms.Guna2Button();
            this.btnConfirmSupplier = new Guna.UI2.WinForms.Guna2Button();
            this.btnConfirmCategory = new Guna.UI2.WinForms.Guna2Button();
            this.btnAddFromSupplier = new Guna.UI2.WinForms.Guna2Button();
            this.btnbck = new Guna.UI2.WinForms.Guna2Button();
            ((System.ComponentModel.ISupportInitialize)(this.nudQuantity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPurchasePrice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudRetailPrice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewInvoice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSupplierQuantity)).BeginInit();
            this.SuspendLayout();
            // 
            // nudQuantity
            // 
            this.nudQuantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.nudQuantity.Location = new System.Drawing.Point(17, 475);
            this.nudQuantity.Name = "nudQuantity";
            this.nudQuantity.Size = new System.Drawing.Size(416, 35);
            this.nudQuantity.TabIndex = 1;
            // 
            // nudPurchasePrice
            // 
            this.nudPurchasePrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.nudPurchasePrice.Location = new System.Drawing.Point(17, 579);
            this.nudPurchasePrice.Name = "nudPurchasePrice";
            this.nudPurchasePrice.Size = new System.Drawing.Size(416, 35);
            this.nudPurchasePrice.TabIndex = 2;
            this.nudPurchasePrice.ValueChanged += new System.EventHandler(this.nudPurchasePrice_ValueChanged);
            // 
            // nudRetailPrice
            // 
            this.nudRetailPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.nudRetailPrice.Location = new System.Drawing.Point(17, 669);
            this.nudRetailPrice.Name = "nudRetailPrice";
            this.nudRetailPrice.Size = new System.Drawing.Size(416, 35);
            this.nudRetailPrice.TabIndex = 3;
            this.nudRetailPrice.ValueChanged += new System.EventHandler(this.nudRetailPrice_ValueChanged);
            // 
            // dtpPurchaseDate
            // 
            this.dtpPurchaseDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dtpPurchaseDate.Location = new System.Drawing.Point(17, 772);
            this.dtpPurchaseDate.Name = "dtpPurchaseDate";
            this.dtpPurchaseDate.Size = new System.Drawing.Size(416, 35);
            this.dtpPurchaseDate.TabIndex = 4;
            this.dtpPurchaseDate.ValueChanged += new System.EventHandler(this.dtpPurchaseDate_ValueChanged);
            // 
            // dataGridViewInvoice
            // 
            this.dataGridViewInvoice.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewInvoice.Location = new System.Drawing.Point(12, 12);
            this.dataGridViewInvoice.Name = "dataGridViewInvoice";
            this.dataGridViewInvoice.Size = new System.Drawing.Size(672, 315);
            this.dataGridViewInvoice.TabIndex = 6;
            // 
            // listBox1
            // 
            this.listBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 29;
            this.listBox1.Location = new System.Drawing.Point(690, 12);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(653, 990);
            this.listBox1.TabIndex = 8;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // comboBoxSuppliers
            // 
            this.comboBoxSuppliers.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBoxSuppliers.FormattingEnabled = true;
            this.comboBoxSuppliers.Location = new System.Drawing.Point(1415, 75);
            this.comboBoxSuppliers.Name = "comboBoxSuppliers";
            this.comboBoxSuppliers.Size = new System.Drawing.Size(386, 37);
            this.comboBoxSuppliers.TabIndex = 9;
            this.comboBoxSuppliers.SelectedIndexChanged += new System.EventHandler(this.comboBoxSuppliers_SelectedIndexChanged_1);
            // 
            // comboBoxCategories
            // 
            this.comboBoxCategories.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBoxCategories.FormattingEnabled = true;
            this.comboBoxCategories.Location = new System.Drawing.Point(1415, 265);
            this.comboBoxCategories.Name = "comboBoxCategories";
            this.comboBoxCategories.Size = new System.Drawing.Size(386, 37);
            this.comboBoxCategories.TabIndex = 10;
            this.comboBoxCategories.SelectedIndexChanged += new System.EventHandler(this.comboBoxCategories_SelectedIndexChanged_1);
            // 
            // listBoxSupplierProducts
            // 
            this.listBoxSupplierProducts.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.listBoxSupplierProducts.FormattingEnabled = true;
            this.listBoxSupplierProducts.ItemHeight = 29;
            this.listBoxSupplierProducts.Location = new System.Drawing.Point(1415, 569);
            this.listBoxSupplierProducts.Name = "listBoxSupplierProducts";
            this.listBoxSupplierProducts.Size = new System.Drawing.Size(386, 178);
            this.listBoxSupplierProducts.TabIndex = 11;
            this.listBoxSupplierProducts.SelectedIndexChanged += new System.EventHandler(this.listBoxSupplierProducts_SelectedIndexChanged);
            // 
            // nudSupplierQuantity
            // 
            this.nudSupplierQuantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.nudSupplierQuantity.Location = new System.Drawing.Point(1415, 467);
            this.nudSupplierQuantity.Name = "nudSupplierQuantity";
            this.nudSupplierQuantity.Size = new System.Drawing.Size(386, 35);
            this.nudSupplierQuantity.TabIndex = 13;
            this.nudSupplierQuantity.ValueChanged += new System.EventHandler(this.nudSupplierQuantity_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(1466, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(293, 29);
            this.label1.TabIndex = 17;
            this.label1.Text = "Выберите поставщика";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(1466, 228);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(276, 29);
            this.label2.TabIndex = 18;
            this.label2.Text = "Выберите категорию";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(1466, 426);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(289, 29);
            this.label3.TabIndex = 19;
            this.label3.Text = "Выберите количество";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(1499, 528);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(215, 29);
            this.label4.TabIndex = 20;
            this.label4.Text = "Выберите товар";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(12, 341);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(336, 29);
            this.label5.TabIndex = 21;
            this.label5.Text = "Введите название товара";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(12, 443);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(362, 29);
            this.label6.TabIndex = 22;
            this.label6.Text = "Введите количество товара";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(7, 547);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(387, 29);
            this.label7.TabIndex = 23;
            this.label7.Text = "Введите оптовую цену товара";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(12, 637);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(421, 29);
            this.label8.TabIndex = 24;
            this.label8.Text = "Введите розничную цену товара";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.Location = new System.Drawing.Point(12, 718);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(179, 29);
            this.label9.TabIndex = 25;
            this.label9.Text = "Введите дату";
            // 
            // txtProductName
            // 
            this.txtProductName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtProductName.DefaultText = "";
            this.txtProductName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtProductName.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtProductName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtProductName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtProductName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtProductName.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtProductName.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtProductName.Location = new System.Drawing.Point(17, 373);
            this.txtProductName.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txtProductName.Name = "txtProductName";
            this.txtProductName.PlaceholderText = "";
            this.txtProductName.SelectedText = "";
            this.txtProductName.Size = new System.Drawing.Size(416, 36);
            this.txtProductName.TabIndex = 26;
            // 
            // btnAddToInvoice
            // 
            this.btnAddToInvoice.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnAddToInvoice.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnAddToInvoice.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnAddToInvoice.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnAddToInvoice.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnAddToInvoice.ForeColor = System.Drawing.Color.White;
            this.btnAddToInvoice.Location = new System.Drawing.Point(17, 833);
            this.btnAddToInvoice.Name = "btnAddToInvoice";
            this.btnAddToInvoice.Size = new System.Drawing.Size(416, 89);
            this.btnAddToInvoice.TabIndex = 27;
            this.btnAddToInvoice.Text = "Добавить товар";
            this.btnAddToInvoice.Click += new System.EventHandler(this.btnAddToInvoice_Click);
            // 
            // btnGenerateInvoice
            // 
            this.btnGenerateInvoice.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnGenerateInvoice.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnGenerateInvoice.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnGenerateInvoice.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnGenerateInvoice.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnGenerateInvoice.ForeColor = System.Drawing.Color.White;
            this.btnGenerateInvoice.Location = new System.Drawing.Point(17, 928);
            this.btnGenerateInvoice.Name = "btnGenerateInvoice";
            this.btnGenerateInvoice.Size = new System.Drawing.Size(416, 89);
            this.btnGenerateInvoice.TabIndex = 28;
            this.btnGenerateInvoice.Text = "Создать накладную";
            this.btnGenerateInvoice.Click += new System.EventHandler(this.btnGenerateInvoice_Click);
            // 
            // btnConfirmSupplier
            // 
            this.btnConfirmSupplier.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnConfirmSupplier.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnConfirmSupplier.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnConfirmSupplier.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnConfirmSupplier.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnConfirmSupplier.ForeColor = System.Drawing.Color.White;
            this.btnConfirmSupplier.Location = new System.Drawing.Point(1415, 128);
            this.btnConfirmSupplier.Name = "btnConfirmSupplier";
            this.btnConfirmSupplier.Size = new System.Drawing.Size(386, 89);
            this.btnConfirmSupplier.TabIndex = 29;
            this.btnConfirmSupplier.Text = "Подтвердить";
            this.btnConfirmSupplier.Click += new System.EventHandler(this.btnConfirmSupplier_Click);
            // 
            // btnConfirmCategory
            // 
            this.btnConfirmCategory.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnConfirmCategory.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnConfirmCategory.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnConfirmCategory.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnConfirmCategory.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnConfirmCategory.ForeColor = System.Drawing.Color.White;
            this.btnConfirmCategory.Location = new System.Drawing.Point(1415, 319);
            this.btnConfirmCategory.Name = "btnConfirmCategory";
            this.btnConfirmCategory.Size = new System.Drawing.Size(386, 89);
            this.btnConfirmCategory.TabIndex = 30;
            this.btnConfirmCategory.Text = "Подтвердить";
            this.btnConfirmCategory.Click += new System.EventHandler(this.btnConfirmCategory_Click);
            // 
            // btnAddFromSupplier
            // 
            this.btnAddFromSupplier.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnAddFromSupplier.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnAddFromSupplier.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnAddFromSupplier.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnAddFromSupplier.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnAddFromSupplier.ForeColor = System.Drawing.Color.White;
            this.btnAddFromSupplier.Location = new System.Drawing.Point(1415, 788);
            this.btnAddFromSupplier.Name = "btnAddFromSupplier";
            this.btnAddFromSupplier.Size = new System.Drawing.Size(386, 89);
            this.btnAddFromSupplier.TabIndex = 31;
            this.btnAddFromSupplier.Text = "Добавить товар";
            this.btnAddFromSupplier.Click += new System.EventHandler(this.btnAddFromSupplier_Click);
            // 
            // btnbck
            // 
            this.btnbck.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnbck.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnbck.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnbck.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnbck.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnbck.ForeColor = System.Drawing.Color.White;
            this.btnbck.Location = new System.Drawing.Point(1415, 940);
            this.btnbck.Name = "btnbck";
            this.btnbck.Size = new System.Drawing.Size(386, 89);
            this.btnbck.TabIndex = 32;
            this.btnbck.Text = "Назад";
            this.btnbck.Click += new System.EventHandler(this.btnbck_Click);
            // 
            // OrderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1904, 1041);
            this.Controls.Add(this.btnbck);
            this.Controls.Add(this.btnAddFromSupplier);
            this.Controls.Add(this.btnConfirmCategory);
            this.Controls.Add(this.btnConfirmSupplier);
            this.Controls.Add(this.btnGenerateInvoice);
            this.Controls.Add(this.btnAddToInvoice);
            this.Controls.Add(this.txtProductName);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.nudSupplierQuantity);
            this.Controls.Add(this.listBoxSupplierProducts);
            this.Controls.Add(this.comboBoxCategories);
            this.Controls.Add(this.comboBoxSuppliers);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.dataGridViewInvoice);
            this.Controls.Add(this.dtpPurchaseDate);
            this.Controls.Add(this.nudRetailPrice);
            this.Controls.Add(this.nudPurchasePrice);
            this.Controls.Add(this.nudQuantity);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "OrderForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Заказ";
            this.Load += new System.EventHandler(this.OrderForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudQuantity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPurchasePrice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudRetailPrice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewInvoice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSupplierQuantity)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.NumericUpDown nudQuantity;
        private System.Windows.Forms.NumericUpDown nudPurchasePrice;
        private System.Windows.Forms.NumericUpDown nudRetailPrice;
        private System.Windows.Forms.DateTimePicker dtpPurchaseDate;
        private System.Windows.Forms.DataGridView dataGridViewInvoice;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.ComboBox comboBoxSuppliers;
        private System.Windows.Forms.ComboBox comboBoxCategories;
        private System.Windows.Forms.ListBox listBoxSupplierProducts;
        private System.Windows.Forms.NumericUpDown nudSupplierQuantity;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private Guna.UI2.WinForms.Guna2TextBox txtProductName;
        private Guna.UI2.WinForms.Guna2Button btnAddToInvoice;
        private Guna.UI2.WinForms.Guna2Button btnGenerateInvoice;
        private Guna.UI2.WinForms.Guna2Button btnConfirmSupplier;
        private Guna.UI2.WinForms.Guna2Button btnConfirmCategory;
        private Guna.UI2.WinForms.Guna2Button btnAddFromSupplier;
        private Guna.UI2.WinForms.Guna2Button btnbck;
    }
}