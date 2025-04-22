namespace scrap
{
    partial class Orders
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Orders));
            this.titleLabel = new System.Windows.Forms.Label();
            this.ordersDataGridView = new System.Windows.Forms.DataGridView();
            this.refreshButton = new Guna.UI2.WinForms.Guna2Button();
            this.btnbck = new Guna.UI2.WinForms.Guna2Button();
            ((System.ComponentModel.ISupportInitialize)(this.ordersDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.titleLabel.Location = new System.Drawing.Point(807, 27);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(519, 73);
            this.titleLabel.TabIndex = 2;
            this.titleLabel.Text = "Список заказов";
            // 
            // ordersDataGridView
            // 
            this.ordersDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ordersDataGridView.Location = new System.Drawing.Point(12, 115);
            this.ordersDataGridView.Name = "ordersDataGridView";
            this.ordersDataGridView.ReadOnly = true;
            this.ordersDataGridView.Size = new System.Drawing.Size(1899, 774);
            this.ordersDataGridView.TabIndex = 0;
            this.ordersDataGridView.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ordersDataGridView_CellDoubleClick);
            // 
            // refreshButton
            // 
            this.refreshButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.refreshButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.refreshButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.refreshButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.refreshButton.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.refreshButton.ForeColor = System.Drawing.Color.White;
            this.refreshButton.Location = new System.Drawing.Point(12, 940);
            this.refreshButton.Name = "refreshButton";
            this.refreshButton.Size = new System.Drawing.Size(386, 89);
            this.refreshButton.TabIndex = 5;
            this.refreshButton.Text = "Обновить";
            this.refreshButton.Click += new System.EventHandler(this.refreshButton_Click);
            // 
            // btnbck
            // 
            this.btnbck.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnbck.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnbck.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnbck.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnbck.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnbck.ForeColor = System.Drawing.Color.White;
            this.btnbck.Location = new System.Drawing.Point(1525, 940);
            this.btnbck.Name = "btnbck";
            this.btnbck.Size = new System.Drawing.Size(386, 89);
            this.btnbck.TabIndex = 6;
            this.btnbck.Text = "Назад";
            this.btnbck.Click += new System.EventHandler(this.btnbck_Click);
            // 
            // Orders
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1904, 1041);
            this.Controls.Add(this.btnbck);
            this.Controls.Add(this.refreshButton);
            this.Controls.Add(this.titleLabel);
            this.Controls.Add(this.ordersDataGridView);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Orders";
            this.Text = "Заказы";
            ((System.ComponentModel.ISupportInitialize)(this.ordersDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.DataGridView ordersDataGridView;
        private Guna.UI2.WinForms.Guna2Button refreshButton;
        private Guna.UI2.WinForms.Guna2Button btnbck;
    }
}