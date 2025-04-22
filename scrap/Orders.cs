using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using MySql.Data.MySqlClient; // Убедитесь, что установлен пакет MySql.Data

namespace scrap
{
    public partial class Orders : Form
    {
        private string connectionString = "Server=server244.hosting.reg.ru;Port=3310;Database=u3070435_default;User ID=u3070435_default;Password=x4Xv8P6sTFn7AmWe;Charset=utf8mb4;";

        public Orders()
        {
            InitializeComponent();
            LoadOrders();
            MaximizeBox = false;
            this.BackColor = Color.FromArgb(18, 18, 18);
            this.MinimumSize = new Size(400, 300);
            //this.TopMost = true;
            this.WindowState = FormWindowState.Maximized;
    
            this.BackColor = Color.FromArgb(20, 20, 20);
            titleLabel.ForeColor = Color.White;
            titleLabel.Font = new Font("Segoe UI", 16, FontStyle.Bold); 

            ordersDataGridView.BackgroundColor = Color.FromArgb(30, 30, 30);
            ordersDataGridView.GridColor = Color.FromArgb(45, 45, 45);
            ordersDataGridView.DefaultCellStyle.BackColor = Color.FromArgb(40, 40, 40);
            ordersDataGridView.DefaultCellStyle.ForeColor = Color.White;
            ordersDataGridView.DefaultCellStyle.SelectionBackColor = Color.FromArgb(70, 70, 70);
            ordersDataGridView.DefaultCellStyle.SelectionForeColor = Color.White;
            ordersDataGridView.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(45, 45, 45);
            ordersDataGridView.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            ordersDataGridView.EnableHeadersVisualStyles = false;
            ordersDataGridView.BorderStyle = BorderStyle.None;
            ordersDataGridView.RowHeadersVisible = false;

            foreach (DataGridViewColumn col in ordersDataGridView.Columns)
            {
                col.Width = 200;
            }

            refreshButton.FillColor = Color.FromArgb(45, 45, 45);
            refreshButton.ForeColor = Color.White;
            refreshButton.BorderRadius = 15;
            refreshButton.HoverState.FillColor = Color.FromArgb(70, 70, 70);

            btnbck.FillColor = Color.FromArgb(45, 45, 45);
            btnbck.ForeColor = Color.White;
            btnbck.BorderRadius = 15;
            btnbck.HoverState.FillColor = Color.FromArgb(70, 70, 70);

            ordersDataGridView.DefaultCellStyle.Font = new Font("Segoe UI", 25);
            ordersDataGridView.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 25, FontStyle.Bold);
            ordersDataGridView.RowTemplate.Height = 100;
            ordersDataGridView.ColumnHeadersHeight = 100;
        }

        private void LoadOrders()
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    string query = "SELECT id AS order_id, created_at AS order_date, status FROM orders ORDER BY created_at DESC";
                    MySqlDataAdapter adapter = new MySqlDataAdapter(query, connection);
                    DataTable table = new DataTable();
                    adapter.Fill(table);

                    ordersDataGridView.DataSource = table;

                    ordersDataGridView.Columns["order_id"].HeaderText = "Номер заказа";
                    ordersDataGridView.Columns["order_date"].HeaderText = "Дата заказа";
                    ordersDataGridView.Columns["status"].HeaderText = "Статус заказа";

                    foreach (DataGridViewColumn column in ordersDataGridView.Columns)
                    {
                        column.MinimumWidth = 630;  
                    }

                }
                catch (MySqlException ex)
                {
                    MessageBox.Show($"Ошибка загрузки заказов: {ex.Message}");
                }
            }
        }

        private void ordersDataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                int orderId = Convert.ToInt32(ordersDataGridView.Rows[e.RowIndex].Cells["order_id"].Value);
                OrderDetails detailsForm = new OrderDetails(orderId);
                this.Close(); 
                detailsForm.Show();
            }
        }

        private void btnbck_Click(object sender, EventArgs e)
        {
            MainForm main = new MainForm();
            this.Hide();
            main.Show();
        }

        private void refreshButton_Click(object sender, EventArgs e)
        {
            LoadOrders();
        }
    }
}