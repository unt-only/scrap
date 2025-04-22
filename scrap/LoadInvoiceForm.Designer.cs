namespace scrap
{
    partial class LoadInvoiceForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoadInvoiceForm));
            this.txtInvoiceCode = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnLoadInvoice = new Guna.UI2.WinForms.Guna2Button();
            this.btnbck = new Guna.UI2.WinForms.Guna2Button();
            this.btn = new Guna.UI2.WinForms.Guna2Button();
            this.SuspendLayout();
            // 
            // txtInvoiceCode
            // 
            this.txtInvoiceCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtInvoiceCode.Location = new System.Drawing.Point(643, 449);
            this.txtInvoiceCode.Name = "txtInvoiceCode";
            this.txtInvoiceCode.Size = new System.Drawing.Size(634, 62);
            this.txtInvoiceCode.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(633, 322);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(644, 55);
            this.label1.TabIndex = 3;
            this.label1.Text = "Введите номер накладной";
            // 
            // btnLoadInvoice
            // 
            this.btnLoadInvoice.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnLoadInvoice.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnLoadInvoice.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnLoadInvoice.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnLoadInvoice.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnLoadInvoice.ForeColor = System.Drawing.Color.White;
            this.btnLoadInvoice.Location = new System.Drawing.Point(643, 548);
            this.btnLoadInvoice.Name = "btnLoadInvoice";
            this.btnLoadInvoice.Size = new System.Drawing.Size(634, 89);
            this.btnLoadInvoice.TabIndex = 4;
            this.btnLoadInvoice.Text = "Загрузить накладную";
            this.btnLoadInvoice.Click += new System.EventHandler(this.btnLoadInvoice_Click);
            // 
            // btnbck
            // 
            this.btnbck.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnbck.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnbck.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnbck.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnbck.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnbck.ForeColor = System.Drawing.Color.White;
            this.btnbck.Location = new System.Drawing.Point(1470, 1117);
            this.btnbck.Name = "btnbck";
            this.btnbck.Size = new System.Drawing.Size(416, 89);
            this.btnbck.TabIndex = 5;
            this.btnbck.Text = "Назад";
            this.btnbck.Click += new System.EventHandler(this.btnbck_Click);
            // 
            // btn
            // 
            this.btn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn.ForeColor = System.Drawing.Color.White;
            this.btn.Location = new System.Drawing.Point(643, 685);
            this.btn.Name = "btn";
            this.btn.Size = new System.Drawing.Size(634, 89);
            this.btn.TabIndex = 6;
            this.btn.Text = "Назад";
            this.btn.Click += new System.EventHandler(this.btnbck_Click);
            // 
            // LoadInvoiceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1904, 1041);
            this.Controls.Add(this.btn);
            this.Controls.Add(this.btnbck);
            this.Controls.Add(this.btnLoadInvoice);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtInvoiceCode);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "LoadInvoiceForm";
            this.Text = "Загрузка накладной";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtInvoiceCode;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2Button btnLoadInvoice;
        private Guna.UI2.WinForms.Guna2Button btnbck;
        private Guna.UI2.WinForms.Guna2Button btn;
    }
}