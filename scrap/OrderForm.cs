using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace scrap
{
    public partial class OrderForm : Form
    {
        public OrderForm()
        {
            InitializeComponent();
            InitializeDataGridView();
            LoadSuppliers();
            LoadLastInvoices();




            MaximizeBox = false;
            // Настройка стиля формы
            this.BackColor = Color.FromArgb(18, 18, 18);


            this.MinimumSize = new Size(400, 300);

            //this.TopMost = true;

            this.WindowState = FormWindowState.Maximized;

            dataGridViewInvoice.BackgroundColor = Color.FromArgb(30, 30, 30);
            dataGridViewInvoice.GridColor = Color.FromArgb(45, 45, 45);
            dataGridViewInvoice.DefaultCellStyle.BackColor = Color.FromArgb(40, 40, 40);
            dataGridViewInvoice.DefaultCellStyle.ForeColor = Color.White;
            dataGridViewInvoice.DefaultCellStyle.SelectionBackColor = Color.FromArgb(70, 70, 70);
            dataGridViewInvoice.DefaultCellStyle.SelectionForeColor = Color.White;
            dataGridViewInvoice.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(45, 45, 45);
            dataGridViewInvoice.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dataGridViewInvoice.EnableHeadersVisualStyles = false;
            dataGridViewInvoice.BorderStyle = BorderStyle.None;
            dataGridViewInvoice.RowHeadersVisible = false;

            label5.ForeColor = Color.White;
            label6.ForeColor = Color.White;
            label7.ForeColor = Color.White;
            label8.ForeColor = Color.White;
            label9.ForeColor = Color.White;
            label1.ForeColor = Color.White;
            label2.ForeColor = Color.White;
            label3.ForeColor = Color.White;
            label4.ForeColor = Color.White;

            txtProductName.FillColor = Color.FromArgb(30, 30, 30);
            txtProductName.ForeColor = Color.White;
            txtProductName.PlaceholderText = "Введите название товара";
            txtProductName.PlaceholderForeColor = Color.Gray;
            txtProductName.BorderRadius = 10;

            nudQuantity.BackColor = Color.FromArgb(30, 30, 30);
            nudQuantity.ForeColor = Color.White;


            nudPurchasePrice.BackColor = Color.FromArgb(30, 30, 30);
            nudPurchasePrice.ForeColor = Color.White;

            nudRetailPrice.BackColor = Color.FromArgb(30, 30, 30);
            nudRetailPrice.ForeColor = Color.White;


            dtpPurchaseDate.Format = DateTimePickerFormat.Custom;
            dtpPurchaseDate.CustomFormat = "dd/MM/yyyy";

            btnAddToInvoice.FillColor = Color.FromArgb(45, 45, 45);
            btnAddToInvoice.ForeColor = Color.White;
            btnAddToInvoice.BorderRadius = 15;
            btnAddToInvoice.HoverState.FillColor = Color.FromArgb(70, 70, 70);

            btnGenerateInvoice.FillColor = Color.FromArgb(45, 45, 45);
            btnGenerateInvoice.ForeColor = Color.White;
            btnGenerateInvoice.BorderRadius = 15;
            btnGenerateInvoice.HoverState.FillColor = Color.FromArgb(70, 70, 70);

            btnConfirmSupplier.FillColor = Color.FromArgb(45, 45, 45);
            btnConfirmSupplier.ForeColor = Color.White;
            btnConfirmSupplier.BorderRadius = 15;
            btnConfirmSupplier.HoverState.FillColor = Color.FromArgb(70, 70, 70);

            btnConfirmCategory.FillColor = Color.FromArgb(45, 45, 45);
            btnConfirmCategory.ForeColor = Color.White;
            btnConfirmCategory.BorderRadius = 15;
            btnConfirmCategory.HoverState.FillColor = Color.FromArgb(70, 70, 70);

            btnAddFromSupplier.FillColor = Color.FromArgb(45, 45, 45);
            btnAddFromSupplier.ForeColor = Color.White;
            btnAddFromSupplier.BorderRadius = 15;
            btnAddFromSupplier.HoverState.FillColor = Color.FromArgb(70, 70, 70);

            btnbck.FillColor = Color.FromArgb(45, 45, 45);
            btnbck.ForeColor = Color.White;
            btnbck.BorderRadius = 15;
            btnbck.HoverState.FillColor = Color.FromArgb(70, 70, 70);

            listBoxSupplierProducts.BackColor = Color.FromArgb(30, 30, 30);
            listBoxSupplierProducts.ForeColor = Color.White;
            listBoxSupplierProducts.BorderStyle = BorderStyle.None;

            listBox1.BackColor = Color.FromArgb(30, 30, 30);
            listBox1.ForeColor = Color.White;
            listBox1.BorderStyle = BorderStyle.None;

            comboBoxSuppliers.BackColor = Color.FromArgb(30, 30, 30);
            comboBoxSuppliers.ForeColor = Color.White;

            comboBoxCategories.BackColor = Color.FromArgb(30, 30, 30);
            comboBoxCategories.ForeColor = Color.White;

            dataGridViewInvoice.DefaultCellStyle.Font = new Font("Segoe UI", 18);
            dataGridViewInvoice.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 18, FontStyle.Bold);
            dataGridViewInvoice.RowTemplate.Height = 100;
            dataGridViewInvoice.ColumnHeadersHeight = 100;
        }

        public class ComboBoxItem
        {
            public string Text { get; set; }
            public int Value { get; set; }

            public override string ToString()
            {
                return Text;
            }
        }
        private void InitializeDataGridView()
        {
            dataGridViewInvoice.Columns.Add("ProductName", "Название товара");
            dataGridViewInvoice.Columns.Add("Quantity", "Количество");
            dataGridViewInvoice.Columns.Add("PurchasePrice", "Закупочная цена");
            dataGridViewInvoice.Columns.Add("RetailPrice", "Розничная цена");
            dataGridViewInvoice.Columns.Add("PurchaseDate", "Дата покупки");
            foreach (DataGridViewColumn column in dataGridViewInvoice.Columns)
            {
                column.MinimumWidth = 134;  
            }
        }

        private void LoadSuppliers()
        {
            using (var conn = new MySqlConnection("Server=server244.hosting.reg.ru;Port=3310;Database=u3070435_default;User ID=u3070435_default;Password=x4Xv8P6sTFn7AmWe;Charset=utf8mb4;"))
            {
                conn.Open();

                var cmd = new MySqlCommand("SELECT id, name FROM suppliers", conn);
                var reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    comboBoxSuppliers.Items.Add(new ComboBoxItem
                    {
                        Text = reader.GetString("name"),
                        Value = reader.GetInt32("id")
                    });
                }
            }
        }

        private void comboBoxSuppliers_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxSuppliers.SelectedItem == null) return;

            int supplierId = ((ComboBoxItem)comboBoxSuppliers.SelectedItem).Value;

            Task.Run(() => LoadCategoriesAsync(supplierId));
        }

        private async void LoadCategoriesAsync(int supplierId)
        {
            try
            {
                this.Invoke((MethodInvoker)delegate
                {
                    comboBoxCategories.Items.Clear();
                    comboBoxCategories.Text = "Загрузка...";
                    comboBoxCategories.Enabled = false;
                });

                await Task.Delay(100); 

                using (var conn = new MySqlConnection("Server=server244.hosting.reg.ru;Port=3310;Database=u3070435_default;User ID=u3070435_default;Password=x4Xv8P6sTFn7AmWe;Charset=utf8mb4;"))
                {
                    await conn.OpenAsync();

                    string query = @"SELECT id, category_name 
                           FROM supplier_categories 
                           WHERE supplier_id = @supplierId";

                    using (var cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@supplierId", supplierId);

                        using (var reader = await cmd.ExecuteReaderAsync())
                        {
                            var categories = new List<ComboBoxItem>();

                            while (await reader.ReadAsync())
                            {
                                categories.Add(new ComboBoxItem
                                {
                                    Text = reader["category_name"].ToString(),
                                    Value = Convert.ToInt32(reader["id"])
                                });
                            }

                            this.Invoke((MethodInvoker)delegate
                            {
                                comboBoxCategories.Items.Clear();
                                comboBoxCategories.Items.AddRange(categories.ToArray());
                                comboBoxCategories.Enabled = true;

                                if (categories.Count > 0)
                                {
                                    comboBoxCategories.SelectedIndex = 0;
                                }
                                else
                                {
                                    comboBoxCategories.Text = "Нет категорий";
                                    MessageBox.Show("Для этого поставщика нет категорий.");
                                }
                            });
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                this.Invoke((MethodInvoker)delegate
                {
                    MessageBox.Show($"Ошибка: {ex.Message}");
                    comboBoxCategories.Text = "Ошибка загрузки";
                    comboBoxCategories.Enabled = true;
                });
            }
        }

        private void comboBoxCategories_SelectedIndexChanged(object sender, EventArgs e)
        {
            listBoxSupplierProducts.Items.Clear();
            if (comboBoxSuppliers.SelectedItem == null || comboBoxCategories.SelectedItem == null) return;

            int supplierId = ((ComboBoxItem)comboBoxSuppliers.SelectedItem).Value;
            int categoryId = ((ComboBoxItem)comboBoxCategories.SelectedItem).Value;

            LoadProducts(supplierId, categoryId);
        }

        private void LoadProducts(int supplierId, int categoryId)
        {
            using (var conn = new MySqlConnection("Server=server244.hosting.reg.ru;Port=3310;Database=u3070435_default;User ID=u3070435_default;Password=x4Xv8P6sTFn7AmWe;Charset=utf8mb4;"))
            {
                conn.Open();

                var cmd = new MySqlCommand(
                    "SELECT name, purchase_price, retail_price " +
                    "FROM supplier_products " +
                    "WHERE supplier_id = @supplierId AND category_id = @categoryId",
                    conn);

                cmd.Parameters.AddWithValue("@supplierId", supplierId);
                cmd.Parameters.AddWithValue("@categoryId", categoryId);

                var reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    var product = new Product(
                        reader.GetString("name"),
                        reader.GetDecimal("purchase_price"),
                        reader.GetDecimal("retail_price"));

                    listBoxSupplierProducts.Items.Add(product);
                }
            }
        }


        private void btnAddFromSupplier_Click(object sender, EventArgs e)
        {
            if (listBoxSupplierProducts.SelectedItem != null)
            {
                Product selectedProduct = (Product)listBoxSupplierProducts.SelectedItem;
                int quantity = (int)nudSupplierQuantity.Value;
                DateTime purchaseDate = DateTime.Now;

                dataGridViewInvoice.Rows.Add(
                    selectedProduct.Name,
                    quantity,
                    selectedProduct.PurchasePrice,
                    selectedProduct.RetailPrice,
                    purchaseDate);
            }
            else
            {
                MessageBox.Show("Пожалуйста, выберите товар.");
            }
        }

        public class Product
        {
            public string Name { get; set; }
            public decimal PurchasePrice { get; set; }
            public decimal RetailPrice { get; set; }

            public Product(string name, decimal purchasePrice, decimal retailPrice)
            {
                Name = name;
                PurchasePrice = purchasePrice;
                RetailPrice = retailPrice;
            }

            public override string ToString()
            {
                return Name;
            }
        }

        private void btnGenerateInvoice_Click(object sender, EventArgs e)
        {
            string invoiceCode = "E-" + new Random().Next(100000, 999999); 

            using (var conn = new MySqlConnection("Server=server244.hosting.reg.ru;Port=3310;Database=u3070435_default;User ID=u3070435_default;Password=x4Xv8P6sTFn7AmWe;Charset=utf8mb4;"))
            {
                conn.Open();

                var cmd = new MySqlCommand("INSERT INTO invoices (code) VALUES (@code)", conn);
                cmd.Parameters.AddWithValue("@code", invoiceCode);
                cmd.ExecuteNonQuery();

                int invoiceId = (int)cmd.LastInsertedId;

                foreach (DataGridViewRow row in dataGridViewInvoice.Rows)
                {
                    if (row.Cells[0].Value != null) 
                    {
                        string productName = row.Cells[0].Value.ToString();

                        if (row.Cells[1].Value != null && row.Cells[1].Value is int quantity &&
                            row.Cells[2].Value != null && row.Cells[2].Value is decimal purchasePrice &&
                            row.Cells[3].Value != null && row.Cells[3].Value is decimal retailPrice &&
                            row.Cells[4].Value != null && row.Cells[4].Value is DateTime purchaseDate)
                        {
                            var cmd2 = new MySqlCommand("INSERT INTO invoice_items (invoice_id, name, quantity, purchase_price, retail_price, purchase_date) VALUES (@invoiceId, @name, @quantity, @purchasePrice, @retailPrice, @purchaseDate)", conn);
                            cmd2.Parameters.AddWithValue("@invoiceId", invoiceId);
                            cmd2.Parameters.AddWithValue("@name", productName);
                            cmd2.Parameters.AddWithValue("@quantity", quantity);
                            cmd2.Parameters.AddWithValue("@purchasePrice", purchasePrice);
                            cmd2.Parameters.AddWithValue("@retailPrice", retailPrice);
                            cmd2.Parameters.AddWithValue("@purchaseDate", purchaseDate);
                            cmd2.ExecuteNonQuery();
                        }
                        else
                        {
                            MessageBox.Show("Ошибка данных в строке накладной. Пожалуйста, проверьте все поля.");
                            return;
                        }
                    }
                }
                MessageBox.Show($"Накладная создана. Код: {invoiceCode}");
                LoadLastInvoices();
            }
        }

        private void LoadLastInvoices()
        {
            listBox1.Items.Clear();

            using (var conn = new MySqlConnection("Server=server244.hosting.reg.ru;Port=3310;Database=u3070435_default;User ID=u3070435_default;Password=x4Xv8P6sTFn7AmWe;Charset=utf8mb4;"))
            {
                conn.Open();

                var cmd = new MySqlCommand("SELECT code FROM invoices ORDER BY created_at DESC LIMIT 10", conn);
                var reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    listBox1.Items.Add(reader.GetString("code"));
                }
            }
        }

        private void btnbck_Click(object sender, EventArgs e)
        {
            MainForm main = new MainForm();
            this.Hide();
            main.Show();
        }

        private void btnConfirmSupplier_Click(object sender, EventArgs e)
        {
            // Проверка, выбран ли поставщик
            if (comboBoxSuppliers.SelectedItem == null)
            {
                MessageBox.Show("Пожалуйста, выберите поставщика.");
                return;
            }

            comboBoxCategories.Items.Clear();

            int supplierId = ((ComboBoxItem)comboBoxSuppliers.SelectedItem).Value;

            Console.WriteLine($"Загружаем категории для поставщика с ID: {supplierId}");

            using (var conn = new MySqlConnection("Server=server244.hosting.reg.ru;Port=3310;Database=u3070435_default;User ID=u3070435_default;Password=x4Xv8P6sTFn7AmWe;Charset=utf8mb4;"))
            {
                conn.Open();

                var cmd = new MySqlCommand("SELECT id, category_name FROM supplier_categories WHERE supplier_id = @supplierId", conn);
                cmd.Parameters.AddWithValue("@supplierId", supplierId);

                var reader = cmd.ExecuteReader();
                int categoryCount = 0;

                while (reader.Read())
                {
                    categoryCount++;
                    Console.WriteLine($"Найдена категория: {reader.GetString("category_name")}");
                    comboBoxCategories.Items.Add(new ComboBoxItem
                    {
                        Text = reader.GetString("category_name"),
                        Value = reader.GetInt32("id")
                    });
                }

                if (categoryCount == 0)
                {
                    MessageBox.Show("Нет категорий для выбранного поставщика.");
                }
            }

        }

        private void btnConfirmCategory_Click(object sender, EventArgs e)
        {
            if (comboBoxSuppliers.SelectedItem == null)
            {
                MessageBox.Show("Пожалуйста, выберите поставщика.");
                return;
            }

            if (comboBoxCategories.SelectedItem == null)
            {
                MessageBox.Show("Пожалуйста, выберите категорию.");
                return;
            }

            listBoxSupplierProducts.Items.Clear();

            int supplierId = ((ComboBoxItem)comboBoxSuppliers.SelectedItem).Value;
            int categoryId = ((ComboBoxItem)comboBoxCategories.SelectedItem).Value;

            using (var conn = new MySqlConnection("Server=server244.hosting.reg.ru;Port=3310;Database=u3070435_default;User ID=u3070435_default;Password=x4Xv8P6sTFn7AmWe;Charset=utf8mb4;"))
            {
                conn.Open();
                var cmd = new MySqlCommand(
                    "SELECT name, purchase_price, retail_price " +
                    "FROM supplier_products " +
                    "WHERE supplier_id = @supplierId AND category_id = @categoryId",
                    conn);

                cmd.Parameters.AddWithValue("@supplierId", supplierId);
                cmd.Parameters.AddWithValue("@categoryId", categoryId);

                var reader = cmd.ExecuteReader();

                int productCount = 0;

                while (reader.Read())
                {
                    productCount++;
                    var product = new Product(
                        reader.GetString("name"),
                        reader.GetDecimal("purchase_price"),
                        reader.GetDecimal("retail_price"));

                    listBoxSupplierProducts.Items.Add(product);
                }

                if (productCount == 0)
                {
                    MessageBox.Show("Нет товаров для выбранной категории.");
                }
            }
        }

        private void nudPurchasePrice_ValueChanged(object sender, EventArgs e)
        {

        }

        private void nudRetailPrice_ValueChanged(object sender, EventArgs e)
        {

        }

        private void dtpPurchaseDate_ValueChanged(object sender, EventArgs e)
        {

        }

        private void btnAddToInvoice_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtProductName.Text))
            {
                MessageBox.Show("Введите название товара.");
                return;
            }

            if (nudQuantity.Value <= 0)
            {
                MessageBox.Show("Количество должно быть больше 0.");
                return;
            }

            if (nudPurchasePrice.Value <= 0)
            {
                MessageBox.Show("Закупочная цена должна быть больше 0.");
                return;
            }

            if (nudRetailPrice.Value <= 0)
            {
                MessageBox.Show("Розничная цена должна быть больше 0.");
                return;
            }

            string productName = txtProductName.Text.Trim();
            int quantity = (int)nudQuantity.Value;
            decimal purchasePrice = nudPurchasePrice.Value;
            decimal retailPrice = nudRetailPrice.Value;
            DateTime purchaseDate = dtpPurchaseDate.Value;

            dataGridViewInvoice.Rows.Add(
                productName,
                quantity,
                purchasePrice,
                retailPrice,
                purchaseDate
            );
            txtProductName.Clear();
            nudQuantity.Value = 1;
            nudPurchasePrice.Value = 0;
            nudRetailPrice.Value = 0;
            dtpPurchaseDate.Value = DateTime.Now;
        }


        private void comboBoxSuppliers_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void comboBoxCategories_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void nudSupplierQuantity_ValueChanged(object sender, EventArgs e)
        {

        }

        private void listBoxSupplierProducts_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void OrderForm_Load(object sender, EventArgs e)
        {
        }
    }
}
