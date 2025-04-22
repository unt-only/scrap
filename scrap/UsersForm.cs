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
    public partial class UsersForm: Form
    {
        private string connectionString = "Server=server244.hosting.reg.ru;Port=3310;Database=u3070435_default;User ID=u3070435_default;Password=x4Xv8P6sTFn7AmWe;Charset=utf8mb4;";
        public UsersForm()
        {
            InitializeComponent();
            LoadUsers();

            MaximizeBox = false;
            this.BackColor = Color.FromArgb(18, 18, 18);
            this.MinimumSize = new Size(400, 300);
            //this.TopMost = true;
            this.WindowState = FormWindowState.Maximized;
            this.BackColor = Color.FromArgb(20, 20, 20);


            usersDataGridView.BackgroundColor = Color.FromArgb(30, 30, 30);
            usersDataGridView.GridColor = Color.FromArgb(45, 45, 45);
            usersDataGridView.DefaultCellStyle.BackColor = Color.FromArgb(40, 40, 40);
            usersDataGridView.DefaultCellStyle.ForeColor = Color.White;
            usersDataGridView.DefaultCellStyle.SelectionBackColor = Color.FromArgb(70, 70, 70);
            usersDataGridView.DefaultCellStyle.SelectionForeColor = Color.White;
            usersDataGridView.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(45, 45, 45);
            usersDataGridView.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            usersDataGridView.EnableHeadersVisualStyles = false;
            usersDataGridView.BorderStyle = BorderStyle.None;
            usersDataGridView.RowHeadersVisible = false;

            btnbck.FillColor = Color.FromArgb(45, 45, 45);
            btnbck.ForeColor = Color.White;
            btnbck.BorderRadius = 15;
            btnbck.HoverState.FillColor = Color.FromArgb(70, 70, 70);

            usersDataGridView.DefaultCellStyle.Font = new Font("Segoe UI", 25);
            usersDataGridView.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 30, FontStyle.Bold);
            usersDataGridView.RowTemplate.Height = 200;
            usersDataGridView.ColumnHeadersHeight = 200;
        }

        private void LoadUsers()
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    string query = @"
                        SELECT 
                            id, 
                            first_name AS Имя, 
                            last_name AS Фамилия, 
                            email AS Email, 
                            CASE 
                                WHEN email_verified = 1 THEN 'Верифицирован' 
                                ELSE 'Не верифицирован' 
                            END AS Верификация
                        FROM users";

                    MySqlDataAdapter adapter = new MySqlDataAdapter(query, connection);
                    DataTable table = new DataTable();
                    adapter.Fill(table);

                    usersDataGridView.DataSource = table;

                    usersDataGridView.Columns["id"].HeaderText = "ID";
                    usersDataGridView.Columns["Имя"].HeaderText = "Имя";
                    usersDataGridView.Columns["Фамилия"].HeaderText = "Фамилия";
                    usersDataGridView.Columns["Email"].HeaderText = "Email";
                    usersDataGridView.Columns["Верификация"].HeaderText = "Верификация";

                    foreach (DataGridViewColumn col in usersDataGridView.Columns)
                    {
                        col.Width = 384;
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Ошибка при загрузке пользователей: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
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
