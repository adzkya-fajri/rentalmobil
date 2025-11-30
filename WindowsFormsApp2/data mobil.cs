using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace RentalMobil
{
    public partial class FormDataMobil : Form
    {
        public FormDataMobil()
        {
            InitializeComponent();
            this.Paint += Form_Paint;
            dgvData.CellClick += DgvData_CellClick;
            LoadDummyData(); // Opsional
        }

        private void Form_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g.SmoothingMode = SmoothingMode.AntiAlias;
            Pen pen = new Pen(Color.FromArgb(30, 100, 150, 200), 1);
            Random rand = new Random(42);

            for (int i = 0; i < 50; i++)
            {
                int x1 = rand.Next(0, this.Width);
                int y1 = rand.Next(0, 200);
                int x2 = rand.Next(0, this.Width);
                int y2 = rand.Next(0, 200);
                g.DrawLine(pen, x1, y1, x2, y2);
            }
        }

        private void BtnTambah_Click(object sender, EventArgs e)
        {
            if (!ValidateInput()) return;

            dgvData.Rows.Add(
                txtIDMobil.Text,
                txtMerk.Text,
                txtModel.Text,
                txtTahun.Text,
                txtWarna.Text,
                txtNoPlat.Text,
                cmbJenisBahanBakar.Text,
                cmbTransmisi.Text,
                txtKapasitasMesin.Text,
                txtKapasitasPenumpang.Text,
                txtHargaSewa.Text,
                cmbStatus.Text
            );

            MessageBox.Show("Data mobil berhasil ditambahkan!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
            ClearForm();
        }

        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            if (dgvData.SelectedRows.Count == 0)
            {
                MessageBox.Show("Pilih data yang akan diupdate!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!ValidateInput()) return;

            int index = dgvData.SelectedRows[0].Index;
            dgvData.Rows[index].Cells[0].Value = txtIDMobil.Text;
            dgvData.Rows[index].Cells[1].Value = txtMerk.Text;
            dgvData.Rows[index].Cells[2].Value = txtModel.Text;
            dgvData.Rows[index].Cells[3].Value = txtTahun.Text;
            dgvData.Rows[index].Cells[4].Value = txtWarna.Text;
            dgvData.Rows[index].Cells[5].Value = txtNoPlat.Text;
            dgvData.Rows[index].Cells[6].Value = cmbJenisBahanBakar.Text;
            dgvData.Rows[index].Cells[7].Value = cmbTransmisi.Text;
            dgvData.Rows[index].Cells[8].Value = txtKapasitasMesin.Text;
            dgvData.Rows[index].Cells[9].Value = txtKapasitasPenumpang.Text;
            dgvData.Rows[index].Cells[10].Value = txtHargaSewa.Text;
            dgvData.Rows[index].Cells[11].Value = cmbStatus.Text;

            MessageBox.Show("Data mobil berhasil diupdate!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
            ClearForm();
        }

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
                MessageBox.Show("Data mobil berhasil dihapus!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClearForm();
            }
        }

        private void BtnBersihkan_Click(object sender, EventArgs e)
        {
            ClearForm();
        }

        private void BtnCari_Click(object sender, EventArgs e)
        {
            string keyword = txtCari.Text.Trim().ToLower();
            if (string.IsNullOrEmpty(keyword))
            {
                MessageBox.Show("Masukkan kata kunci pencarian!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            bool found = false;
            foreach (DataGridViewRow row in dgvData.Rows)
            {
                bool visible = false;
                foreach (DataGridViewCell cell in row.Cells)
                {
                    if (cell.Value != null && cell.Value.ToString().ToLower().Contains(keyword))
                    {
                        visible = true;
                        found = true;
                        break;
                    }
                }
                row.Visible = visible;
            }

            if (!found)
                MessageBox.Show("Data tidak ditemukan!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void BtnReset_Click(object sender, EventArgs e)
        {
            txtCari.Clear();
            foreach (DataGridViewRow row in dgvData.Rows)
                row.Visible = true;
        }

        private void DgvData_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvData.Rows[e.RowIndex];
                txtIDMobil.Text = row.Cells[0].Value?.ToString();
                txtMerk.Text = row.Cells[1].Value?.ToString();
                txtModel.Text = row.Cells[2].Value?.ToString();
                txtTahun.Text = row.Cells[3].Value?.ToString();
                txtWarna.Text = row.Cells[4].Value?.ToString();
                txtNoPlat.Text = row.Cells[5].Value?.ToString();
                cmbJenisBahanBakar.Text = row.Cells[6].Value?.ToString();
                cmbTransmisi.Text = row.Cells[7].Value?.ToString();
                txtKapasitasMesin.Text = row.Cells[8].Value?.ToString();
                txtKapasitasPenumpang.Text = row.Cells[9].Value?.ToString();
                txtHargaSewa.Text = row.Cells[10].Value?.ToString();
                cmbStatus.Text = row.Cells[11].Value?.ToString();
            }
        }

        private bool ValidateInput()
        {
            if (string.IsNullOrWhiteSpace(txtIDMobil.Text))
            {
                MessageBox.Show("ID Mobil harus diisi!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtIDMobil.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtMerk.Text))
            {
                MessageBox.Show("Merk harus diisi!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMerk.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtModel.Text))
            {
                MessageBox.Show("Model harus diisi!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtModel.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtNoPlat.Text))
            {
                MessageBox.Show("No Plat harus diisi!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtNoPlat.Focus();
                return false;
            }

            if (cmbStatus.SelectedIndex == -1)
            {
                MessageBox.Show("Status harus dipilih!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cmbStatus.Focus();
                return false;
            }

            return true;
        }

        private void ClearForm()
        {
            txtIDMobil.Clear();
            txtMerk.Clear();
            txtModel.Clear();
            txtTahun.Clear();
            txtWarna.Clear();
            txtNoPlat.Clear();
            txtKapasitasMesin.Clear();
            txtKapasitasPenumpang.Clear();
            txtHargaSewa.Clear();
            txtCari.Clear();
            cmbJenisBahanBakar.SelectedIndex = -1;
            cmbTransmisi.SelectedIndex = -1;
            cmbStatus.SelectedIndex = -1;
            dgvData.ClearSelection();
            txtIDMobil.Focus();
        }

        private void LoadDummyData()
        {
            dgvData.Rows.Add("M001", "Toyota", "Avanza", "2020", "Hitam", "B1234ABC", "Bensin", "Manual", "1500", "7", "350000", "Tersedia");
            dgvData.Rows.Add("M002", "Honda", "BR-V", "2021", "Putih", "B5678DEF", "Bensin", "Otomatis", "1500", "7", "400000", "Tersedia");
        }
    }
}