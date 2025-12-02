using System;
using System.Drawing;
using System.Collections.Generic;
using System.Windows.Forms;

namespace RentalMobilApp
{
    public partial class FormPelanggan : Form
    {
        List<Pelanggan> dataPelanggan = new List<Pelanggan>();

        public FormPelanggan()
        {
            InitializeComponent();
            GenerateId();
            LoadTable();
        }

        private void GenerateId()
        {
            txtId.Text = "PLG" + (dataPelanggan.Count + 1).ToString("000");
        }

        private void LoadTable()
        {
            dgvPelanggan.DataSource = null;
            dgvPelanggan.DataSource = dataPelanggan;
        }

        private void btnSimpan_Click(object sender, EventArgs e)
        {
            Pelanggan p = new Pelanggan()
            {
                Id = txtId.Text,
                Nama = txtNama.Text,
                Nik = txtNik.Text,
                Telepon = txtTelepon.Text,
                Alamat = txtAlamat.Text
            };

            dataPelanggan.Add(p);

            LoadTable();
            ResetForm();
        }

        private void dgvPelanggan_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = dgvPelanggan.CurrentRow.Index;

            txtId.Text = dataPelanggan[i].Id;
            txtNama.Text = dataPelanggan[i].Nama;
            txtNik.Text = dataPelanggan[i].Nik;
            txtTelepon.Text = dataPelanggan[i].Telepon;
            txtAlamat.Text = dataPelanggan[i].Alamat;
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            int i = dgvPelanggan.CurrentRow.Index;

            dataPelanggan[i].Nama = txtNama.Text;
            dataPelanggan[i].Nik = txtNik.Text;
            dataPelanggan[i].Telepon = txtTelepon.Text;
            dataPelanggan[i].Alamat = txtAlamat.Text;

            LoadTable();
            ResetForm();
        }

        private void btnHapus_Click(object sender, EventArgs e)
        {
            int i = dgvPelanggan.CurrentRow.Index;
            dataPelanggan.RemoveAt(i);

            LoadTable();
            ResetForm();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            ResetForm();
        }

        private void ResetForm()
        {
            txtNama.Text = "";
            txtNik.Text = "";
            txtTelepon.Text = "";
            txtAlamat.Text = "";
            GenerateId();
        }

        private void FormPelanggan_Load(object sender, EventArgs e)
        {

        }

        private void FormPelanggan_Load_1(object sender, EventArgs e)
        {

        }
    }

    public class Pelanggan
    {
        public string Id { get; set; }
        public string Nama { get; set; }
        public string Nik { get; set; }
        public string Telepon { get; set; }
        public string Alamat { get; set; }
    }
}