using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.WebControls;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
//using System.Windows.Forms.VisualStyles;
using Guna.UI2.WinForms;
using MySql.Data.MySqlClient;


namespace scrap
{
    public partial class LoginForm : Form
    {


        public LoginForm()
        {
            InitializeComponent();
            MaximizeBox = false;
            this.BackColor = Color.FromArgb(18, 18, 18);

            this.MinimumSize = new Size(400, 300);

            //this.TopMost = true;

            this.WindowState = FormWindowState.Maximized;

            txtEmail.FillColor = Color.FromArgb(30, 30, 30);
            txtEmail.ForeColor = Color.White;
            txtEmail.PlaceholderText = "Введите email";
            txtEmail.PlaceholderForeColor = Color.Gray;
            txtEmail.BorderRadius = 10;

            txtPassword.FillColor = Color.FromArgb(30, 30, 30);
            txtPassword.ForeColor = Color.White;
            txtPassword.PlaceholderText = "Введите пароль";
            txtPassword.PlaceholderForeColor = Color.Gray;
            txtPassword.BorderRadius = 10;
            txtPassword.UseSystemPasswordChar = true;

            btnLogin.FillColor = Color.FromArgb(45, 45, 45);
            btnLogin.ForeColor = Color.White;
            btnLogin.BorderRadius = 15;
            btnLogin.HoverState.FillColor = Color.FromArgb(70, 70, 70);

            guna2HtmlLabel1.ForeColor = Color.White;
            guna2HtmlLabel2.ForeColor = Color.White;

            linkRegister.LinkColor = Color.White;
            linkRegister.ActiveLinkColor = Color.Gray;
            linkRegister.VisitedLinkColor = Color.Gray;

        }

        private void linkRegister_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            RegisterForm registerForm = new RegisterForm();
            registerForm.Show();
            this.Hide(); 
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string email = txtEmail.Text.Trim();
            string password = txtPassword.Text;

            using (var conn = new MySqlConnection("Server=server244.hosting.reg.ru;Port=3310;Database=u3070435_default;User ID=u3070435_default;Password=x4Xv8P6sTFn7AmWe;"))
            {
                conn.Open();

                var checkEmailCmd = new MySqlCommand("SELECT * FROM users_main WHERE email = @e", conn);
                checkEmailCmd.Parameters.AddWithValue("@e", email);
                var reader = checkEmailCmd.ExecuteReader();

                if (!reader.Read())
                {
                    MessageBox.Show("Пользователь с таким email не найден.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                string dbPassword = reader["password"].ToString();
                bool isVerified = Convert.ToBoolean(reader["is_verified"]);
                reader.Close();

                if (dbPassword != password)
                {
                    MessageBox.Show("Неверный пароль.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (!isVerified)
                {
                    MessageBox.Show("Аккаунт не подтверждён. Завершите регистрацию через код на почте.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                MainForm main = new MainForm();
                this.Hide();
                main.Show();
            }
        }

    }
}
