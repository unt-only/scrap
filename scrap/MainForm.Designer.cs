namespace scrap
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.dataGridViewProducts = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.btnLoadInvoiceForm = new Guna.UI2.WinForms.Guna2Button();
            this.btnOpenOrderForm = new Guna.UI2.WinForms.Guna2Button();
            this.btnclients = new Guna.UI2.WinForms.Guna2Button();
            this.order = new Guna.UI2.WinForms.Guna2Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProducts)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewProducts
            // 
            this.dataGridViewProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewProducts.Location = new System.Drawing.Point(12, 126);
            this.dataGridViewProducts.Name = "dataGridViewProducts";
            this.dataGridViewProducts.Size = new System.Drawing.Size(1314, 903);
            this.dataGridViewProducts.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(726, 39);
            this.label1.TabIndex = 3;
            this.label1.Text = "Весь доступный товар на данный момент";
            // 
            // btnLoadInvoiceForm
            // 
            this.btnLoadInvoiceForm.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnLoadInvoiceForm.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnLoadInvoiceForm.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnLoadInvoiceForm.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnLoadInvoiceForm.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnLoadInvoiceForm.ForeColor = System.Drawing.Color.White;
            this.btnLoadInvoiceForm.Location = new System.Drawing.Point(1377, 302);
            this.btnLoadInvoiceForm.Name = "btnLoadInvoiceForm";
            this.btnLoadInvoiceForm.Size = new System.Drawing.Size(386, 89);
            this.btnLoadInvoiceForm.TabIndex = 6;
            this.btnLoadInvoiceForm.Text = "Выгрузить накладную";
            this.btnLoadInvoiceForm.Click += new System.EventHandler(this.btnLoadInvoiceForm_Click_1);
            // 
            // btnOpenOrderForm
            // 
            this.btnOpenOrderForm.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnOpenOrderForm.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnOpenOrderForm.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnOpenOrderForm.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnOpenOrderForm.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnOpenOrderForm.ForeColor = System.Drawing.Color.White;
            this.btnOpenOrderForm.Location = new System.Drawing.Point(1377, 126);
            this.btnOpenOrderForm.Name = "btnOpenOrderForm";
            this.btnOpenOrderForm.Size = new System.Drawing.Size(386, 89);
            this.btnOpenOrderForm.TabIndex = 7;
            this.btnOpenOrderForm.Text = "Заказать товар";
            this.btnOpenOrderForm.Click += new System.EventHandler(this.btnOpenOrderForm_Click_1);
            // 
            // btnclients
            // 
            this.btnclients.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnclients.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnclients.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnclients.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnclients.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnclients.ForeColor = System.Drawing.Color.White;
            this.btnclients.Location = new System.Drawing.Point(1377, 654);
            this.btnclients.Name = "btnclients";
            this.btnclients.Size = new System.Drawing.Size(386, 89);
            this.btnclients.TabIndex = 8;
            this.btnclients.Text = "Клиенты";
            this.btnclients.Click += new System.EventHandler(this.btnclients_Click_1);
            // 
            // order
            // 
            this.order.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.order.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.order.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.order.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.order.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.order.ForeColor = System.Drawing.Color.White;
            this.order.Location = new System.Drawing.Point(1377, 484);
            this.order.Name = "order";
            this.order.Size = new System.Drawing.Size(386, 89);
            this.order.TabIndex = 9;
            this.order.Text = "Заказы";
            this.order.Click += new System.EventHandler(this.order_Click_1);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1904, 1041);
            this.Controls.Add(this.order);
            this.Controls.Add(this.btnclients);
            this.Controls.Add(this.btnOpenOrderForm);
            this.Controls.Add(this.btnLoadInvoiceForm);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridViewProducts);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Главная";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProducts)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewProducts;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2Button btnLoadInvoiceForm;
        private Guna.UI2.WinForms.Guna2Button btnOpenOrderForm;
        private Guna.UI2.WinForms.Guna2Button btnclients;
        private Guna.UI2.WinForms.Guna2Button order;
    }
}