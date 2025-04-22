using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Guna.UI2.WinForms;
using MySql.Data.MySqlClient;

namespace scrap
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();



            MaximizeBox = false;
            this.BackColor = Color.FromArgb(18, 18, 18);
            this.MinimumSize = new Size(400, 300);
            //this.TopMost = true;
            this.WindowState = FormWindowState.Maximized;

            this.BackColor = Color.FromArgb(20, 20, 20);


            label1.ForeColor = Color.White;
            label1.Font = new Font("Segoe UI", 14, FontStyle.Bold);
            label1.BackColor = Color.Transparent;

            dataGridViewProducts.BackgroundColor = Color.FromArgb(30, 30, 30);
            dataGridViewProducts.GridColor = Color.FromArgb(45, 45, 45);
            dataGridViewProducts.DefaultCellStyle.BackColor = Color.FromArgb(40, 40, 40);
            dataGridViewProducts.DefaultCellStyle.ForeColor = Color.White;
            dataGridViewProducts.DefaultCellStyle.SelectionBackColor = Color.FromArgb(70, 70, 70);
            dataGridViewProducts.DefaultCellStyle.SelectionForeColor = Color.White;
            dataGridViewProducts.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(45, 45, 45);
            dataGridViewProducts.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dataGridViewProducts.EnableHeadersVisualStyles = false;
            dataGridViewProducts.BorderStyle = BorderStyle.None;
            dataGridViewProducts.RowHeadersVisible = false;

            btnLoadInvoiceForm.FillColor = Color.FromArgb(45, 45, 45);
            btnLoadInvoiceForm.ForeColor = Color.White;
            btnLoadInvoiceForm.BorderRadius = 15;
            btnLoadInvoiceForm.HoverState.FillColor = Color.FromArgb(70, 70, 70);

            btnOpenOrderForm.FillColor = Color.FromArgb(45, 45, 45);
            btnOpenOrderForm.ForeColor = Color.White;
            btnOpenOrderForm.BorderRadius = 15;
            btnOpenOrderForm.HoverState.FillColor = Color.FromArgb(70, 70, 70);

            btnclients.FillColor = Color.FromArgb(45, 45, 45);
            btnclients.ForeColor = Color.White;
            btnclients.BorderRadius = 15;
            btnclients.HoverState.FillColor = Color.FromArgb(70, 70, 70);

            order.FillColor = Color.FromArgb(45, 45, 45);
            order.ForeColor = Color.White;
            order.BorderRadius = 15;
            order.HoverState.FillColor = Color.FromArgb(70, 70, 70);



            dataGridViewProducts.DefaultCellStyle.Font = new Font("Segoe UI", 25);
            dataGridViewProducts.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 25, FontStyle.Bold);
            dataGridViewProducts.RowTemplate.Height = 100;
            dataGridViewProducts.ColumnHeadersHeight = 100;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            LoadProducts();
        }
        private void LoadProducts()
        {
            using (var conn = new MySqlConnection("Server=server244.hosting.reg.ru;Port=3310;Database=u3070435_default;User ID=u3070435_default;Password=x4Xv8P6sTFn7AmWe;Charset=utf8mb4;"))
            {
                conn.Open();
                var adapter = new MySqlDataAdapter("SELECT name, quantity, purchase_price, retail_price, purchase_date FROM products_main", conn);
                DataTable table = new DataTable();
                adapter.Fill(table);

                dataGridViewProducts.DataSource = table;

                foreach (DataGridViewColumn column in dataGridViewProducts.Columns)
                {
                    column.MinimumWidth = 265;  
                }

                if (dataGridViewProducts.Columns.Contains("name"))
                    dataGridViewProducts.Columns["name"].HeaderText = "Название";

                if (dataGridViewProducts.Columns.Contains("quantity"))
                    dataGridViewProducts.Columns["quantity"].HeaderText = "Количество";

                if (dataGridViewProducts.Columns.Contains("purchase_price"))
                    dataGridViewProducts.Columns["purchase_price"].HeaderText = "Закупочная цена";

                if (dataGridViewProducts.Columns.Contains("retail_price"))
                    dataGridViewProducts.Columns["retail_price"].HeaderText = "Розничная цена";

                if (dataGridViewProducts.Columns.Contains("purchase_date"))
                    dataGridViewProducts.Columns["purchase_date"].HeaderText = "Дата покупки";
            }
        }






        private void btnOpenOrderForm_Click_1(object sender, EventArgs e)
        {
            OrderForm orderForm = new OrderForm();
            this.Hide();
            orderForm.Show();
        }

        private void btnLoadInvoiceForm_Click_1(object sender, EventArgs e)
        {
            LoadInvoiceForm loadInvoiceForm = new LoadInvoiceForm();
            this.Hide();
            loadInvoiceForm.Show();
        }

        private void order_Click_1(object sender, EventArgs e)
        {
            Orders orders = new Orders();
            this.Hide();
            orders.Show();
        }

        private void btnclients_Click_1(object sender, EventArgs e)
        {
            UsersForm users = new UsersForm();
            this.Hide();
            users.Show();
        }
    }
}
