using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace RentalMobil
{
    public partial class FormRental : Form
    {
        public FormRental()
        {
            InitializeComponent();
            this.Paint += new PaintEventHandler(Form_Paint);
            dgvData.CellClick += DgvData_CellClick;
            LoadDummyData(); // Opsional: data awal
        }

        private void Form_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g.SmoothingMode = SmoothingMode.AntiAlias;
            Pen pen = new Pen(Color.FromArgb(30, 100, 150, 200), 1);
            Random rand = new Random(42);

            for (int i = 0; i < 60; i++)
            {
                int x1 = rand.Next(0, this.Width);
                int y1 = rand.Next(0, 140);
                int x2 = rand.Next(0, this.Width);
                int y2 = rand.Next(0, 140);
                g.DrawLine(pen, x1, y1, x2, y2);
            }
        }

        // 🔹 Tambah Data
        private void BtnSimpan_Click(object sender, EventArgs e)
        {
            if (!ValidateInput()) return;

            dgvData.Rows.Add(
                txtIDPenyewa.Text,
                txtNamaPenyewa.Text,
                dtpTanggalRental.Value.ToString("dd MMM yyyy"),
                txtEmail.Text,
                txtIDMobil.Text,
                txtNamaMobil.Text,
                txtHargaSewa.Text
            );

            MessageBox.Show("Data rental berhasil disimpan!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
            ClearForm();
        }

        // 🔹 Update Data
        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            if (dgvData.SelectedRows.Count == 0)
            {
                MessageBox.Show("Pilih data yang akan diupdate!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!ValidateInput()) return;

            int index = dgvData.SelectedRows[0].Index;
            dgvData.Rows[index].Cells[0].Value = txtIDPenyewa.Text;
            dgvData.Rows[index].Cells[1].Value = txtNamaPenyewa.Text;
            dgvData.Rows[index].Cells[2].Value = dtpTanggalRental.Value.ToString("dd MMM yyyy");
            dgvData.Rows[index].Cells[3].Value = txtEmail.Text;
            dgvData.Rows[index].Cells[4].Value = txtIDMobil.Text;
            dgvData.Rows[index].Cells[5].Value = txtNamaMobil.Text;
            dgvData.Rows[index].Cells[6].Value = txtHargaSewa.Text;

            MessageBox.Show("Data rental berhasil diupdate!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
            ClearForm();
        }

        // 🔹 Hapus Data
        private void BtnHapus_Click(object sender, EventArgs e)
        {
            if (dgvData.SelectedRows.Count == 0)
            {
                MessageBox.Show("Pilih data yang akan dihapus!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var confirm = MessageBox.Show("Yakin ingin menghapus data ini?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (confirm == DialogResult.Yes)
            {
                dgvData.Rows.RemoveAt(dgvData.SelectedRows[0].Index);
                MessageBox.Show("Data rental berhasil dihapus!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClearForm();
            }
        }

        // 🔹 Batal / Clear Form
        private void BtnBatal_Click(object sender, EventArgs e)
        {
            ClearForm();
        }

        // 🔹 Klik DataGridView → Isi Form
        private void DgvData_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvData.Rows[e.RowIndex];
                txtIDPenyewa.Text = row.Cells[0].Value?.ToString();
                txtNamaPenyewa.Text = row.Cells[1].Value?.ToString();
                dtpTanggalRental.Value = DateTime.TryParse(row.Cells[2].Value?.ToString(), out DateTime dt) ? dt : DateTime.Now;
                txtEmail.Text = row.Cells[3].Value?.ToString();
                txtIDMobil.Text = row.Cells[4].Value?.ToString();
                txtNamaMobil.Text = row.Cells[5].Value?.ToString();
                txtHargaSewa.Text = row.Cells[6].Value?.ToString();
            }
        }

        // 🔹 Validasi Input
        private bool ValidateInput()
        {
            if (string.IsNullOrWhiteSpace(txtIDPenyewa.Text))
            {
                MessageBox.Show("ID Penyewa wajib diisi!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtIDPenyewa.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtNamaPenyewa.Text))
            {
                MessageBox.Show("Nama Penyewa wajib diisi!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtNamaPenyewa.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtIDMobil.Text))
            {
                MessageBox.Show("ID Mobil wajib diisi!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtIDMobil.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtHargaSewa.Text))
            {
                MessageBox.Show("Harga Sewa wajib diisi!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtHargaSewa.Focus();
                return false;
            }

            return true;
        }

        // 🔹 Bersihkan Form
        private void ClearForm()
        {
            txtIDPenyewa.Clear();
            txtNamaPenyewa.Clear();
            txtEmail.Clear();
            txtIDMobil.Clear();
            txtNamaMobil.Clear();
            txtHargaSewa.Clear();
            dtpTanggalRental.Value = DateTime.Now;
            dgvData.ClearSelection();
        }

        // 🔹 Data Dummy (Opsional)
        private void LoadDummyData()
        {
            dgvData.Rows.Add("R001", "Budi Santoso", "01 Jun 2025", "budi@email.com", "M001", "Avanza", "300000");
            dgvData.Rows.Add("R002", "Siti Nurhaliza", "02 Jun 2025", "siti@email.com", "M002", "Xenia", "320000");
        }

        private void BtnCetak_Click(object sender, EventArgs e)
        {
            if (dgvData.SelectedRows.Count == 0)
            {
                MessageBox.Show("Pilih data rental yang ingin dicetak struknya.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DataGridViewRow row = dgvData.SelectedRows[0];

            FormStruk struk = new FormStruk
            {
                IDPenyewa = row.Cells[0].Value?.ToString(),
                NamaPenyewa = row.Cells[1].Value?.ToString(),
                Tanggal = row.Cells[2].Value?.ToString(),
                Email = row.Cells[3].Value?.ToString(),
                IDMobil = row.Cells[4].Value?.ToString(),
                NamaMobil = row.Cells[5].Value?.ToString(),
                Harga = row.Cells[6].Value?.ToString()
            };

            struk.ShowDialog();
        }
    }
}