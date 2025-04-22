using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using Mysqlx.Crud;

namespace scrap
{
    public partial class OrderDetails : Form
    {
        private string connectionString = "Server=server244.hosting.reg.ru;Port=3310;Database=u3070435_default;User ID=u3070435_default;Password=x4Xv8P6sTFn7AmWe;Charset=utf8mb4;";
        private int orderId;

        public OrderDetails(int orderId)
        {
            InitializeComponent();
            this.orderId = orderId;
            LoadOrderDetails();


            this.MinimumSize = new Size(400, 300);

            //this.TopMost = true;

            this.WindowState = FormWindowState.Maximized;

            this.BackColor = Color.FromArgb(20, 20, 20);

            orderIdLabel.ForeColor = Color.White;
            dateLabel.ForeColor = Color.White;
            statusLabel.ForeColor = Color.White;
            customerLabel.ForeColor = Color.White;
            lbllocation.ForeColor = Color.White;
            lblcomment.ForeColor = Color.White;


            orderItemsDataGridView.BackgroundColor = Color.FromArgb(30, 30, 30);
            orderItemsDataGridView.GridColor = Color.FromArgb(45, 45, 45);
            orderItemsDataGridView.DefaultCellStyle.BackColor = Color.FromArgb(40, 40, 40);
            orderItemsDataGridView.DefaultCellStyle.ForeColor = Color.White;
            orderItemsDataGridView.DefaultCellStyle.SelectionBackColor = Color.FromArgb(70, 70, 70);
            orderItemsDataGridView.DefaultCellStyle.SelectionForeColor = Color.White;
            orderItemsDataGridView.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(45, 45, 45);
            orderItemsDataGridView.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            orderItemsDataGridView.EnableHeadersVisualStyles = false;
            orderItemsDataGridView.BorderStyle = BorderStyle.None;
            orderItemsDataGridView.RowHeadersVisible = false;

            foreach (DataGridViewColumn col in orderItemsDataGridView.Columns)
            {
                col.Width = 200;
            }

            completeButton.FillColor = Color.FromArgb(45, 45, 45);
            completeButton.ForeColor = Color.White;
            completeButton.BorderRadius = 15;
            completeButton.HoverState.FillColor = Color.FromArgb(70, 70, 70);

            btnbck.FillColor = Color.FromArgb(45, 45, 45);
            btnbck.ForeColor = Color.White;
            btnbck.BorderRadius = 15;
            btnbck.HoverState.FillColor = Color.FromArgb(70, 70, 70);

            orderItemsDataGridView.DefaultCellStyle.Font = new Font("Segoe UI", 25);
            orderItemsDataGridView.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 25, FontStyle.Bold);
            orderItemsDataGridView.RowTemplate.Height = 100;
            orderItemsDataGridView.ColumnHeadersHeight = 100;


        }

        private void LoadOrderDetails()
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    // Загрузка информации о заказе
                    string orderQuery = @"SELECT o.id AS order_id, o.created_at AS order_date, o.status, 
                             oi.first_name, oi.last_name, oi.phone, 
                             oi.address, oi.city, oi.postal_code, oi.notes
                      FROM orders o 
                      JOIN order_info oi ON o.id = oi.order_id 
                      WHERE o.id = @orderId";


                    MySqlCommand orderCmd = new MySqlCommand(orderQuery, connection);
                    orderCmd.Parameters.AddWithValue("@orderId", orderId);

                    connection.Open();
                    MySqlDataReader orderReader = orderCmd.ExecuteReader();

                    if (orderReader.Read())
                    {
                        orderIdLabel.Text = $"Заказ #{orderReader["order_id"]}";
                        dateLabel.Text = $"Дата: {orderReader["order_date"]}";
                        statusLabel.Text = $"Статус: {orderReader["status"]}";
                        customerLabel.Text = $"Клиент: {orderReader["first_name"]} {orderReader["last_name"]}, тел: {orderReader["phone"]}";

                        completeButton.Enabled = orderReader["status"].ToString() == "pending";

                        lbllocation.Text = $"Адрес: {orderReader["address"]}, {orderReader["city"]}, {orderReader["postal_code"]}";
                        lblcomment.Text = $"Комментарий: {orderReader["notes"]}";
                    }

                    orderReader.Close();

                    string itemsQuery = @"
                SELECT 
                    COALESCE(pm.name, p.name) AS product_name,
                    oi.quantity AS ordered_quantity,
                    IFNULL(pm.quantity, 0) AS available_quantity
                FROM 
                    order_items oi
                LEFT JOIN 
                    products_main pm ON oi.product_id = pm.external_id
                LEFT JOIN 
                    products p ON oi.product_id = p.id
                WHERE 
                    oi.order_id = @orderId";

                    MySqlCommand itemsCmd = new MySqlCommand(itemsQuery, connection);
                    itemsCmd.Parameters.AddWithValue("@orderId", orderId);

                    MySqlDataAdapter adapter = new MySqlDataAdapter(itemsCmd);
                    DataTable table = new DataTable();
                    adapter.Fill(table);

                    orderItemsDataGridView.DataSource = table;

                    foreach (DataGridViewColumn column in orderItemsDataGridView.Columns)
                    {
                        column.MinimumWidth = 392;  
                    }

                    orderItemsDataGridView.Columns["product_name"].HeaderText = "Товар";
                    orderItemsDataGridView.Columns["ordered_quantity"].HeaderText = "Заказано";
                    orderItemsDataGridView.Columns["available_quantity"].HeaderText = "Остаток";
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show($"Ошибка при подключении к базе данных: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }


        private void btnbck_Click(object sender, EventArgs e)
        {
            Orders orders = new Orders();
            this.Hide();
            orders.Show();
        }

        private void completeButton_Click_1(object sender, EventArgs e)
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();
                MySqlTransaction transaction = connection.BeginTransaction();

                try
                {

                    string checkQuery = @"
                        SELECT 
        oi.product_id, 
        COALESCE(pm.name, p.name) AS product_name, 
        oi.quantity, 
        IFNULL(pm.quantity, 0) AS available
    FROM 
        order_items oi 
    LEFT JOIN 
        products_main pm ON oi.product_id = pm.external_id
    LEFT JOIN 
        products p ON oi.product_id = p.id
    WHERE 
        oi.order_id = @orderId";

                    MySqlCommand checkCmd = new MySqlCommand(checkQuery, connection, transaction);
                    checkCmd.Parameters.AddWithValue("@orderId", orderId);

                    MySqlDataReader reader = checkCmd.ExecuteReader();
                    bool canComplete = true;
                    string errorMessage = "";

                    while (reader.Read())
                    {
                        int required = Convert.ToInt32(reader["quantity"]);
                        int available = Convert.ToInt32(reader["available"]);

                        if (available < required)
                        {
                            canComplete = false;
                            errorMessage += $"Недостаточно товара: {reader["product_name"]} (нужно {required}, доступно {available})\n";
                        }
                    }
                    reader.Close();

                    if (!canComplete)
                    {
                        MessageBox.Show(errorMessage, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        transaction.Rollback();
                        return;
                    }

                    string updateQuery = @"
                        UPDATE products_main p
                        JOIN order_items oi ON p.external_id = oi.product_id
                        SET p.quantity = p.quantity - oi.quantity
                        WHERE oi.order_id = @orderId";

                    MySqlCommand updateCmd = new MySqlCommand(updateQuery, connection, transaction);
                    updateCmd.Parameters.AddWithValue("@orderId", orderId);
                    updateCmd.ExecuteNonQuery();

                    string statusQuery = "UPDATE orders SET status = 'Выполнен' WHERE id = @orderId";
                    MySqlCommand statusCmd = new MySqlCommand(statusQuery, connection, transaction);
                    statusCmd.Parameters.AddWithValue("@orderId", orderId);
                    statusCmd.ExecuteNonQuery();

                    transaction.Commit();

                    completeButton.Enabled = false;

                    MessageBox.Show("Заказ успешно выполнен!", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.DialogResult = DialogResult.OK;
                }
                catch (Exception ex)
                {
                    transaction.Rollback();
                    MessageBox.Show($"Ошибка при выполнении заказа: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
