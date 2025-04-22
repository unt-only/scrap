using System;
using System.Net.Mail;
using System.Net;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Text.RegularExpressions;
using Guna.UI2.WinForms;
using System.Drawing;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.WebControls;
using System.Windows.Forms.VisualStyles;
namespace scrap
{
    public partial class RegisterForm : Form
    {
        public RegisterForm()
        {
            InitializeComponent();

            MaximizeBox = false;
            this.BackColor = Color.FromArgb(18, 18, 18);
            this.MinimumSize = new Size(400, 300);
            //this.TopMost = true;
            this.WindowState = FormWindowState.Maximized;

            txtUsername.FillColor = Color.FromArgb(30, 30, 30);
            txtUsername.ForeColor = Color.White;
            txtUsername.PlaceholderText = "Введите имя пользователя";
            txtUsername.PlaceholderForeColor = Color.Gray;
            txtUsername.BorderRadius = 10;

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

            btnRegister.FillColor = Color.FromArgb(45, 45, 45);
            btnRegister.ForeColor = Color.White;
            btnRegister.BorderRadius = 15;
            btnRegister.HoverState.FillColor = Color.FromArgb(70, 70, 70);

            label1.ForeColor = Color.White; 
            label2.ForeColor = Color.White; 
            label3.ForeColor = Color.White; 

   
            linkLogin.LinkColor = Color.White;
            linkLogin.ActiveLinkColor = Color.Gray;
            linkLogin.VisitedLinkColor = Color.Gray;

            this.BackColor = Color.FromArgb(20, 20, 20); 
        }

        private string generatedCode;

        private void btnRegister_Click1(object sender, EventArgs e)
        {
            string username = txtUsername.Text.Trim();
            string email = txtEmail.Text.Trim();
            string password = txtPassword.Text;

            // Проверки
            if (username.Length < 3)
            {
                MessageBox.Show("Имя пользователя должно содержать не менее 3 символов.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!IsValidEmail(email))
            {
                MessageBox.Show("Некорректный формат email.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (password.Length < 6)
            {
                MessageBox.Show("Пароль должен быть минимум 6 символов.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (var conn = new MySqlConnection("Server=server244.hosting.reg.ru;Port=3310;Database=u3070435_default;User ID=u3070435_default;Password=x4Xv8P6sTFn7AmWe;Charset=utf8mb4;"))
            {
                conn.Open();

                // Проверка на уникальность email и username
                var checkUser = new MySqlCommand("SELECT COUNT(*) FROM users_main WHERE email = @e OR username = @u", conn);
                checkUser.Parameters.AddWithValue("@e", email);
                checkUser.Parameters.AddWithValue("@u", username);

                int exists = Convert.ToInt32(checkUser.ExecuteScalar());
                if (exists > 0)
                {
                    MessageBox.Show("Такой пользователь уже существует.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Генерируем код и отправляем письмо
                generatedCode = new Random().Next(100000, 999999).ToString();
                try
                {
                    SendVerificationEmail(email, generatedCode);

                    // Вставляем временную запись в БД (без is_verified)
                    var cmd = new MySqlCommand("INSERT INTO users_main (username, password, email, is_verified, verification_code) VALUES (@u, @p, @e, 0, @code)", conn);
                    cmd.Parameters.AddWithValue("@u", username);
                    cmd.Parameters.AddWithValue("@p", password); // потом можно добавить хэширование
                    cmd.Parameters.AddWithValue("@e", email);
                    cmd.Parameters.AddWithValue("@code", generatedCode);
                    cmd.ExecuteNonQuery();

                    // Переход на форму ввода кода
                    VerificationForm verificationForm = new VerificationForm(email);
                    this.Hide();
                    verificationForm.Show();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ошибка при отправке письма: " + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }


        }

        private bool IsValidEmail(string email)
        {
            return Regex.IsMatch(email, @"^[^@\s]+@[^@\s]+\.[^@\s]+$");
        }

        private void SendVerificationEmail(string toEmail, string code)
        {
            MailMessage mail = new MailMessage();
            mail.From = new MailAddress("atdnzkis@gmail.com", "SCRAP Verif CODE");
            mail.To.Add(toEmail);
            mail.Subject = "Код подтверждения";
            mail.Body = $"Ваш код подтверждения: {code}";

            SmtpClient smtp = new SmtpClient("smtp.gmail.com", 587);
            smtp.Credentials = new NetworkCredential("atdnzkis@gmail.com", "skjn bnnl ijvf xjto");
            smtp.EnableSsl = true;
            smtp.Send(mail);
        }

        private void linkLogin_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            LoginForm login = new LoginForm();
            this.Hide();
            login.Show();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text.Trim();
            string email = txtEmail.Text.Trim();
            string password = txtPassword.Text;

            // Проверки
            if (username.Length < 3)
            {
                MessageBox.Show("Имя пользователя должно содержать не менее 3 символов.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!IsValidEmail(email))
            {
                MessageBox.Show("Некорректный формат email.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (password.Length < 6)
            {
                MessageBox.Show("Пароль должен быть минимум 6 символов.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (var conn = new MySqlConnection("Server=server244.hosting.reg.ru;Port=3310;Database=u3070435_default;User ID=u3070435_default;Password=x4Xv8P6sTFn7AmWe;Charset=utf8mb4;"))
            {
                conn.Open();

                // Проверка на уникальность email и username
                var checkUser = new MySqlCommand("SELECT COUNT(*) FROM users_main WHERE email = @e OR username = @u", conn);
                checkUser.Parameters.AddWithValue("@e", email);
                checkUser.Parameters.AddWithValue("@u", username);

                int exists = Convert.ToInt32(checkUser.ExecuteScalar());
                if (exists > 0)
                {
                    MessageBox.Show("Такой пользователь уже существует.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Код
                generatedCode = new Random().Next(100000, 999999).ToString();
                try
                {
                    SendVerificationEmail(email, generatedCode);


                    var cmd = new MySqlCommand("INSERT INTO users_main (username, password, email, is_verified, verification_code) VALUES (@u, @p, @e, 0, @code)", conn);
                    cmd.Parameters.AddWithValue("@u", username);
                    cmd.Parameters.AddWithValue("@p", password); 
                    cmd.Parameters.AddWithValue("@e", email);
                    cmd.Parameters.AddWithValue("@code", generatedCode);
                    cmd.ExecuteNonQuery();


                    VerificationForm verificationForm = new VerificationForm(email);
                    this.Hide();
                    verificationForm.Show();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ошибка при отправке письма: " + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }
    }
}
