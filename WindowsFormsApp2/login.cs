using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace RentalMobil
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
            this.Paint += new PaintEventHandler(Form_Paint);
        }

        private void Form_Paint(object sender, PaintEventArgs e)
        {
            // Draw network pattern background
            Graphics g = e.Graphics;
            g.SmoothingMode = SmoothingMode.AntiAlias;

            Pen pen = new Pen(Color.FromArgb(30, 100, 150, 200), 1);
            Random rand = new Random(42);

            for (int i = 0; i < 40; i++)
            {
                int x1 = rand.Next(0, this.Width);
                int y1 = rand.Next(0, this.Height);
                int x2 = rand.Next(0, this.Width);
                int y2 = rand.Next(0, this.Height);
                g.DrawLine(pen, x1, y1, x2, y2);
            }
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text.Trim();

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Username dan Password harus diisi!", "Peringatan",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Validasi login sederhana (ganti dengan database di aplikasi real)
            if (username == "admin" && password == "admin")
            {
                MessageBox.Show("Login berhasil!\nSelamat datang, " + username, "Sukses",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Buka form utama
                this.Hide();
                // FormMain formMain = new FormMain();
                // formMain.ShowDialog();
                // this.Close();
            }
            else
            {
                MessageBox.Show("Username atau Password salah!", "Login Gagal",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtPassword.Clear();
                txtUsername.Focus();
            }
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Apakah Anda yakin ingin keluar?",
                "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void ChkShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            txtPassword.PasswordChar = chkShowPassword.Checked ? '\0' : '●';
        }

        private void TxtPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                BtnLogin_Click(sender, e);
            }
        }

        private void LblRegister_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Fitur registrasi belum tersedia.", "Info",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void LblForgotPassword_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Silakan hubungi administrator untuk reset password.", "Info",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click_1(object sender, EventArgs e)
        {

        }

        private void btnCancel_Click_1(object sender, EventArgs e)
        {

        }

        private void panelLeft_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lblRegister_Click_1(object sender, EventArgs e)
        { 
            FormRegister formRegister = new FormRegister();
            formRegister.ShowDialog();
        }
    
    }
}