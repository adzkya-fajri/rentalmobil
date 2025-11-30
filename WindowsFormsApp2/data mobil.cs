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
            this.Paint += new PaintEventHandler(Form_Paint);
        }

        private void Form_Paint(object sender, PaintEventArgs e)
        {
            // Draw network pattern background
            Graphics g = e.Graphics;
            g.SmoothingMode = SmoothingMode.AntiAlias;

            Pen pen = new Pen(Color.FromArgb(30, 0, 150, 200), 1);
            Random rand = new Random(42);

            for (int i = 0; i < 60; i++)
            {
                int x1 = rand.Next(0, this.Width);
                int y1 = rand.Next(0, 260);
                int x2 = rand.Next(0, this.Width);
                int y2 = rand.Next(0, 260);
                g.DrawLine(pen, x1, y1, x2, y2);
            }
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            if (ValidateInput())
            {
                string jenisMobil = rbNoMobil.Checked ? "No Mobil" : "Jenis Mobil";

                dgvData.Rows.Add(
                    txtNoMobil.Text,
                    txtJenisMobil.Text,
                    txtMerkMobil.Text,
                    txtHargaSewa.Text,
                    jenisMobil
                );

                MessageBox.Show("Data mobil berhasil disimpan!", "Sukses",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClearForm();
            }
        }

        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            if (dgvData.SelectedRows.Count > 0 && ValidateInput())
            {
                int index = dgvData.SelectedRows[0].Index;
                string jenisMobil = rbNoMobil.Checked ? "No Mobil" : "Jenis Mobil";

                dgvData.Rows[index].Cells[0].Value = txtNoMobil.Text;
                dgvData.Rows[index].Cells[1].Value = txtJenisMobil.Text;
                dgvData.Rows[index].Cells[2].Value = txtMerkMobil.Text;
                dgvData.Rows[index].Cells[3].Value = txtHargaSewa.Text;
                dgvData.Rows[index].Cells[4].Value = jenisMobil;

                MessageBox.Show("Data mobil berhasil diupdate!", "Sukses",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClearForm();
            }
            else
            {
                MessageBox.Show("Pilih data yang akan diupdate!", "Peringatan",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            if (dgvData.SelectedRows.Count > 0)
            {
                DialogResult result = MessageBox.Show("Apakah Anda yakin ingin menghapus data ini?",
                    "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    dgvData.Rows.RemoveAt(dgvData.SelectedRows[0].Index);
                    MessageBox.Show("Data mobil berhasil dihapus!", "Sukses",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ClearForm();
                }
            }
            else
            {
                MessageBox.Show("Pilih data yang akan dihapus!", "Peringatan",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void BtnClear_Click(object sender, EventArgs e)
        {
            ClearForm();
        }

        private void DgvData_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvData.Rows[e.RowIndex];
                txtNoMobil.Text = row.Cells[0].Value?.ToString();
                txtJenisMobil.Text = row.Cells[1].Value?.ToString();
                txtMerkMobil.Text = row.Cells[2].Value?.ToString();
                txtHargaSewa.Text = row.Cells[3].Value?.ToString();

                string jenis = row.Cells[4].Value?.ToString();
                if (jenis == "No Mobil")
                    rbNoMobil.Checked = true;
                else
                    rbJenisMobil.Checked = true;
            }
        }

        private bool ValidateInput()
        {
            if (string.IsNullOrWhiteSpace(txtNoMobil.Text))
            {
                MessageBox.Show("No Mobil harus diisi!", "Peringatan",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtNoMobil.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtJenisMobil.Text))
            {
                MessageBox.Show("Jenis Mobil harus diisi!", "Peringatan",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtJenisMobil.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtMerkMobil.Text))
            {
                MessageBox.Show("Merk Mobil harus diisi!", "Peringatan",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMerkMobil.Focus();
                return false;
            }

            if (!rbNoMobil.Checked && !rbJenisMobil.Checked)
            {
                MessageBox.Show("Pilih kategori mobil!", "Peringatan",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            return true;
        }

        private void ClearForm()
        {
            txtNoMobil.Clear();
            txtJenisMobil.Clear();
            txtMerkMobil.Clear();
            txtHargaSewa.Clear();
            rbNoMobil.Checked = false;
            rbJenisMobil.Checked = false;
            dgvData.ClearSelection();
            txtNoMobil.Focus();
        }

        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FormDataMobil());
        }

        private void FormDataMobil_Load(object sender, EventArgs e)
        {

        }

        private void panelTop_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}