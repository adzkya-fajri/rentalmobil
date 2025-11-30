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

        private void BtnRegister_Click(object sender, EventArgs e)
        {
            // Validasi input
            if (!ValidateInput())
            {
                return;
            }

            // Validasi password match
            if (txtPassword.Text != txtConfirmPassword.Text)
            {
                MessageBox.Show("Password dan Konfirmasi Password tidak sama!", "Peringatan",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtConfirmPassword.Focus();
                return;
            }

            // Validasi terms and conditions
            if (!chkTerms.Checked)
            {
                MessageBox.Show("Anda harus menyetujui syarat dan ketentuan!", "Peringatan",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Simpan data registrasi (ganti dengan database di aplikasi real)
            MessageBox.Show("Registrasi berhasil!\n\nUsername: " + txtUsername.Text +
                          "\nEmail: " + txtEmail.Text +
                          "\n\nSilakan login dengan akun Anda.",
                          "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);

            // Kembali ke form login
            this.Close();
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Batalkan registrasi?",
                "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void ChkShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            txtPassword.PasswordChar = chkShowPassword.Checked ? '\0' : '●';
            txtConfirmPassword.PasswordChar = chkShowPassword.Checked ? '\0' : '●';
        }

        private void LblLogin_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private bool ValidateInput()
        {
            if (string.IsNullOrWhiteSpace(txtFullName.Text))
            {
                MessageBox.Show("Nama Lengkap harus diisi!", "Peringatan",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtFullName.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtUsername.Text))
            {
                MessageBox.Show("Username harus diisi!", "Peringatan",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtUsername.Focus();
                return false;
            }

            if (txtUsername.Text.Length < 4)
            {
                MessageBox.Show("Username minimal 4 karakter!", "Peringatan",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtUsername.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtEmail.Text))
            {
                MessageBox.Show("Email harus diisi!", "Peringatan",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtEmail.Focus();
                return false;
            }

            if (!txtEmail.Text.Contains("@") || !txtEmail.Text.Contains("."))
            {
                MessageBox.Show("Format email tidak valid!", "Peringatan",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtEmail.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtPhone.Text))
            {
                MessageBox.Show("No. Telepon harus diisi!", "Peringatan",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtPhone.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtPassword.Text))
            {
                MessageBox.Show("Password harus diisi!", "Peringatan",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtPassword.Focus();
                return false;
            }

            if (txtPassword.Text.Length < 6)
            {
                MessageBox.Show("Password minimal 6 karakter!", "Peringatan",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtPassword.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtConfirmPassword.Text))
            {
                MessageBox.Show("Konfirmasi Password harus diisi!", "Peringatan",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtConfirmPassword.Focus();
                return false;
            }

            return true;
        } 

        private void FormRegister_Load(object sender, EventArgs e)
        {

        }
    }
}