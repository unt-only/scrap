using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace scrap
{
    public partial class LoadInvoiceForm : Form
    {
        public LoadInvoiceForm()
        {
            InitializeComponent();

            MaximizeBox = false;

            this.BackColor = Color.FromArgb(18, 18, 18);

            this.MinimumSize = new Size(400, 300);

            // this.TopMost = true;

            this.WindowState = FormWindowState.Maximized;

            label1.ForeColor = Color.White;

            btnLoadInvoice.FillColor = Color.FromArgb(45, 45, 45);
            btnLoadInvoice.ForeColor = Color.White;
            btnLoadInvoice.BorderRadius = 15;
            btnLoadInvoice.HoverState.FillColor = Color.FromArgb(70, 70, 70);

            btnbck.FillColor = Color.FromArgb(45, 45, 45);
            btnbck.ForeColor = Color.White;
            btnbck.BorderRadius = 15;
            btnbck.HoverState.FillColor = Color.FromArgb(70, 70, 70);

            btn.FillColor = Color.FromArgb(45, 45, 45);
            btn.ForeColor = Color.White;
            btn.BorderRadius = 15;
            btn.HoverState.FillColor = Color.FromArgb(70, 70, 70);
        }

        private void btnLoadInvoice_Click(object sender, EventArgs e)
        {
            string invoiceCode = txtInvoiceCode.Text;

            using (var connRead = new MySqlConnection("Server=server244.hosting.reg.ru;Port=3310;Database=u3070435_default;User ID=u3070435_default;Password=x4Xv8P6sTFn7AmWe;Charset=utf8mb4;"))
            {
                connRead.Open();

                // Товары из накладной
                var cmd = new MySqlCommand("SELECT ii.name, ii.quantity, ii.purchase_price, ii.retail_price, ii.purchase_date FROM invoice_items ii JOIN invoices i ON ii.invoice_id = i.id WHERE i.code = @code", connRead);
                cmd.Parameters.AddWithValue("@code", invoiceCode);

                using (var reader = cmd.ExecuteReader())  
                {
                    
                    using (var connWrite = new MySqlConnection("Server=server244.hosting.reg.ru;Port=3310;Database=u3070435_default;User ID=u3070435_default;Password=x4Xv8P6sTFn7AmWe;Charset=utf8mb4;"))
                    {
                        connWrite.Open();

                        while (reader.Read())
                        {
                            string productName = reader.GetString("name");
                            int quantity = reader.GetInt32("quantity");
                            decimal purchasePrice = reader.GetDecimal("purchase_price");
                            decimal retailPrice = reader.GetDecimal("retail_price");
                            DateTime purchaseDate = reader.GetDateTime("purchase_date");

                            var checkCmd = new MySqlCommand("SELECT quantity FROM products_main WHERE name = @name", connWrite);
                            checkCmd.Parameters.AddWithValue("@name", productName);

                            object existingQuantity = checkCmd.ExecuteScalar();

                            if (existingQuantity != null) 
                            {
                                
                                int newQuantity = Convert.ToInt32(existingQuantity) + quantity;
                                var updateCmd = new MySqlCommand("UPDATE products_main SET quantity = @quantity WHERE name = @name", connWrite);
                                updateCmd.Parameters.AddWithValue("@quantity", newQuantity);
                                updateCmd.Parameters.AddWithValue("@name", productName);
                                updateCmd.ExecuteNonQuery();
                            }
                            else 
                            {
                                var cmd2 = new MySqlCommand("INSERT INTO products_main (name, quantity, purchase_price, retail_price, purchase_date) VALUES (@name, @quantity, @purchasePrice, @retailPrice, @purchaseDate)", connWrite);
                                cmd2.Parameters.AddWithValue("@name", productName);
                                cmd2.Parameters.AddWithValue("@quantity", quantity);
                                cmd2.Parameters.AddWithValue("@purchasePrice", purchasePrice);
                                cmd2.Parameters.AddWithValue("@retailPrice", retailPrice);
                                cmd2.Parameters.AddWithValue("@purchaseDate", purchaseDate);
                                cmd2.ExecuteNonQuery();
                            }
                        }
                    }
                }

                MessageBox.Show("Накладная загружена.");
            }
        }

        private void btnbck_Click(object sender, EventArgs e)
        {
            MainForm main = new MainForm();
            this.Hide();
            main.Show();
        }
    }
}
