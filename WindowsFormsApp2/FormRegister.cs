using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace RentalMobil
{
    public partial class FormRegister : Form
    {
        public FormRegister()
        {
            InitializeComponent();
        }

        private void chkShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            bool show = chkShowPassword.Checked;

            txtPassword.PasswordChar = show ? '\0' : '●';
            txtConfirmPassword.PasswordChar = show ? '\0' : '●';
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            // Validasi
            if (txtFullName.Text == "" || txtUsername.Text == "" || txtPassword.Text == "" || txtConfirmPassword.Text == "")
            {
                MessageBox.Show("Semua field harus diisi!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (txtPassword.Text != txtConfirmPassword.Text)
            {
                MessageBox.Show("Password dan konfirmasi password tidak cocok!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Simpan akun (contoh dummy)
            MessageBox.Show("Registrasi berhasil!\nAkun Anda telah dibuat.", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);

            // Kembali ke login
            FormLogin login = new FormLogin();
            login.Show();
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lblLoginNow_Click(object sender, EventArgs e)
        {
            FormLogin login = new FormLogin();
            login.Show();
            this.Close();
        }
    }
}