using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectAkhirCapybaraA
{
    public partial class LoginForm : Form
    {
        // Simpan username dan password yang benar
        private string correctUsername = "Capybara";
        private string correctPassword = "123";

        public LoginForm()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            string password = txtPassword.Text;

            // Periksa apakah username dan password benar
            if (username == correctUsername && password == correctPassword)
            {
                // Jika benar, tampilkan pesan berhasil dan lanjut ke halaman utama
                MessageBox.Show("Login berhasil!");
                // Ganti "HomePageForm" dengan nama form halaman utama Anda
                OptionPageForm optionPage = new OptionPageForm();
                optionPage.Show();
                this.Hide();
            }
            else
            {
                // Jika salah, tampilkan pesan kesalahan
                MessageBox.Show("Username atau password salah. Silakan coba lagi.");
            }
        }
    }
}
