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
    public partial class VerificationForm: Form
    {
        private string userEmail;
        public VerificationForm(string email)
        {
            InitializeComponent();
            userEmail = email;
            MaximizeBox = false;
            this.BackColor = Color.FromArgb(18, 18, 18);
            this.MinimumSize = new Size(400, 300);

            txtCode.FillColor = Color.FromArgb(30, 30, 30);
            txtCode.ForeColor = Color.White;
            txtCode.PlaceholderText = "Введите email";
            txtCode.PlaceholderForeColor = Color.Gray;
            txtCode.BorderRadius = 10;

            btnVerify.FillColor = Color.FromArgb(45, 45, 45);
            btnVerify.ForeColor = Color.White;
            btnVerify.BorderRadius = 15;
            btnVerify.HoverState.FillColor = Color.FromArgb(70, 70, 70);

            label1.ForeColor = Color.White;
            label1.ForeColor = Color.White;
        }

        private void btnVerify_Click(object sender, EventArgs e)
        {
            string inputCode = txtCode.Text.Trim();

            using (var conn = new MySqlConnection("Server=server244.hosting.reg.ru;Port=3310;Database=u3070435_default;User ID=u3070435_default;Password=x4Xv8P6sTFn7AmWe;"))
            {
                conn.Open();

                var cmd = new MySqlCommand("SELECT verification_code FROM users_main WHERE email = @e", conn);
                cmd.Parameters.AddWithValue("@e", userEmail);
                var code = cmd.ExecuteScalar()?.ToString();

                if (code == inputCode)
                {
                    var verifyCmd = new MySqlCommand("UPDATE users_main SET is_verified = 1, verification_code = NULL WHERE email = @e", conn);
                    verifyCmd.Parameters.AddWithValue("@e", userEmail);
                    verifyCmd.ExecuteNonQuery();

                    MessageBox.Show("Успешно подтверждено! Теперь вы можете войти.", "Готово", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    LoginForm login = new LoginForm();
                    this.Hide();
                    login.Show();
                }
                else
                {
                    MessageBox.Show("Неверный код подтверждения.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }
    }
}
