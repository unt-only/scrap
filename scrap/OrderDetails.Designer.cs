namespace scrap
{
    partial class OrderDetails
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OrderDetails));
            this.orderIdLabel = new System.Windows.Forms.Label();
            this.dateLabel = new System.Windows.Forms.Label();
            this.statusLabel = new System.Windows.Forms.Label();
            this.customerLabel = new System.Windows.Forms.Label();
            this.orderItemsDataGridView = new System.Windows.Forms.DataGridView();
            this.lbllocation = new System.Windows.Forms.Label();
            this.lblcomment = new System.Windows.Forms.Label();
            this.completeButton = new Guna.UI2.WinForms.Guna2Button();
            this.btnbck = new Guna.UI2.WinForms.Guna2Button();
            ((System.ComponentModel.ISupportInitialize)(this.orderItemsDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // orderIdLabel
            // 
            this.orderIdLabel.AutoSize = true;
            this.orderIdLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.orderIdLabel.Location = new System.Drawing.Point(12, 60);
            this.orderIdLabel.Name = "orderIdLabel";
            this.orderIdLabel.Size = new System.Drawing.Size(27, 29);
            this.orderIdLabel.TabIndex = 0;
            this.orderIdLabel.Text = "1";
            // 
            // dateLabel
            // 
            this.dateLabel.AutoSize = true;
            this.dateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dateLabel.Location = new System.Drawing.Point(12, 158);
            this.dateLabel.Name = "dateLabel";
            this.dateLabel.Size = new System.Drawing.Size(27, 29);
            this.dateLabel.TabIndex = 1;
            this.dateLabel.Text = "1";
            // 
            // statusLabel
            // 
            this.statusLabel.AutoSize = true;
            this.statusLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.statusLabel.Location = new System.Drawing.Point(12, 271);
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(27, 29);
            this.statusLabel.TabIndex = 2;
            this.statusLabel.Text = "1";
            // 
            // customerLabel
            // 
            this.customerLabel.AutoSize = true;
            this.customerLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.customerLabel.Location = new System.Drawing.Point(12, 369);
            this.customerLabel.Name = "customerLabel";
            this.customerLabel.Size = new System.Drawing.Size(27, 29);
            this.customerLabel.TabIndex = 3;
            this.customerLabel.Text = "1";
            // 
            // orderItemsDataGridView
            // 
            this.orderItemsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.orderItemsDataGridView.Location = new System.Drawing.Point(716, 12);
            this.orderItemsDataGridView.Name = "orderItemsDataGridView";
            this.orderItemsDataGridView.Size = new System.Drawing.Size(1176, 758);
            this.orderItemsDataGridView.TabIndex = 4;
            // 
            // lbllocation
            // 
            this.lbllocation.AutoSize = true;
            this.lbllocation.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbllocation.Location = new System.Drawing.Point(12, 479);
            this.lbllocation.Name = "lbllocation";
            this.lbllocation.Size = new System.Drawing.Size(27, 29);
            this.lbllocation.TabIndex = 10;
            this.lbllocation.Text = "1";
            // 
            // lblcomment
            // 
            this.lblcomment.AutoSize = true;
            this.lblcomment.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblcomment.Location = new System.Drawing.Point(12, 575);
            this.lblcomment.Name = "lblcomment";
            this.lblcomment.Size = new System.Drawing.Size(27, 29);
            this.lblcomment.TabIndex = 11;
            this.lblcomment.Text = "1";
            // 
            // completeButton
            // 
            this.completeButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.completeButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.completeButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.completeButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.completeButton.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.completeButton.ForeColor = System.Drawing.Color.White;
            this.completeButton.Location = new System.Drawing.Point(716, 914);
            this.completeButton.Name = "completeButton";
            this.completeButton.Size = new System.Drawing.Size(386, 89);
            this.completeButton.TabIndex = 12;
            this.completeButton.Text = "Выполнить";
            this.completeButton.Click += new System.EventHandler(this.completeButton_Click_1);
            // 
            // btnbck
            // 
            this.btnbck.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnbck.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnbck.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnbck.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnbck.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnbck.ForeColor = System.Drawing.Color.White;
            this.btnbck.Location = new System.Drawing.Point(1506, 914);
            this.btnbck.Name = "btnbck";
            this.btnbck.Size = new System.Drawing.Size(386, 89);
            this.btnbck.TabIndex = 13;
            this.btnbck.Text = "Назад";
            this.btnbck.Click += new System.EventHandler(this.btnbck_Click);
            // 
            // OrderDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1904, 1041);
            this.Controls.Add(this.btnbck);
            this.Controls.Add(this.completeButton);
            this.Controls.Add(this.lblcomment);
            this.Controls.Add(this.lbllocation);
            this.Controls.Add(this.orderItemsDataGridView);
            this.Controls.Add(this.customerLabel);
            this.Controls.Add(this.statusLabel);
            this.Controls.Add(this.dateLabel);
            this.Controls.Add(this.orderIdLabel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "OrderDetails";
            this.Text = "Детали заказа";
            ((System.ComponentModel.ISupportInitialize)(this.orderItemsDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label orderIdLabel;
        private System.Windows.Forms.Label dateLabel;
        private System.Windows.Forms.Label statusLabel;
        private System.Windows.Forms.Label customerLabel;
        private System.Windows.Forms.DataGridView orderItemsDataGridView;
        private System.Windows.Forms.Label lbllocation;
        private System.Windows.Forms.Label lblcomment;
        private Guna.UI2.WinForms.Guna2Button completeButton;
        private Guna.UI2.WinForms.Guna2Button btnbck;
    }
}