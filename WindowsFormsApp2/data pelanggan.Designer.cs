using System.Windows.Forms;

namespace RentalMobilApp
{
    partial class FormPelanggan
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.Label labelId;
        private System.Windows.Forms.Label labelNama;
        private System.Windows.Forms.Label labelNik;
        private System.Windows.Forms.Label labelTelepon;
        private System.Windows.Forms.Label labelAlamat;

        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.TextBox txtNama;
        private System.Windows.Forms.TextBox txtNik;
        private System.Windows.Forms.TextBox txtTelepon;
        private System.Windows.Forms.RichTextBox txtAlamat;

        private System.Windows.Forms.Button btnSimpan;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnHapus;
        private System.Windows.Forms.Button btnReset;

        private System.Windows.Forms.DataGridView dgvPelanggan;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.panelHeader = new System.Windows.Forms.Panel();
            this.labelTitle = new System.Windows.Forms.Label();
            this.labelId = new System.Windows.Forms.Label();
            this.labelNama = new System.Windows.Forms.Label();
            this.labelNik = new System.Windows.Forms.Label();
            this.labelTelepon = new System.Windows.Forms.Label();
            this.labelAlamat = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.txtNama = new System.Windows.Forms.TextBox();
            this.txtNik = new System.Windows.Forms.TextBox();
            this.txtTelepon = new System.Windows.Forms.TextBox();
            this.txtAlamat = new System.Windows.Forms.RichTextBox();
            this.btnSimpan = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnHapus = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.dgvPelanggan = new System.Windows.Forms.DataGridView();
            this.panelHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPelanggan)).BeginInit();
            this.SuspendLayout();
            // 
            // panelHeader
            // 
            this.panelHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(58)))), ((int)(((byte)(147)))));
            this.panelHeader.Controls.Add(this.labelTitle);
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeader.Location = new System.Drawing.Point(0, 0);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(700, 55);
            this.panelHeader.TabIndex = 0;
            // 
            // labelTitle
            // 
            this.labelTitle.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.labelTitle.ForeColor = System.Drawing.Color.White;
            this.labelTitle.Location = new System.Drawing.Point(20, 12);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(100, 23);
            this.labelTitle.TabIndex = 0;
            this.labelTitle.Text = "Data Pelanggan";
            // 
            // labelId
            // 
            this.labelId.Location = new System.Drawing.Point(30, 80);
            this.labelId.Name = "labelId";
            this.labelId.Size = new System.Drawing.Size(100, 23);
            this.labelId.TabIndex = 1;
            this.labelId.Text = "ID Pelanggan";
            // 
            // labelNama
            // 
            this.labelNama.Location = new System.Drawing.Point(30, 120);
            this.labelNama.Name = "labelNama";
            this.labelNama.Size = new System.Drawing.Size(100, 23);
            this.labelNama.TabIndex = 2;
            this.labelNama.Text = "Nama Lengkap";
            // 
            // labelNik
            // 
            this.labelNik.Location = new System.Drawing.Point(30, 160);
            this.labelNik.Name = "labelNik";
            this.labelNik.Size = new System.Drawing.Size(100, 23);
            this.labelNik.TabIndex = 3;
            this.labelNik.Text = "NIK";
            // 
            // labelTelepon
            // 
            this.labelTelepon.Location = new System.Drawing.Point(30, 200);
            this.labelTelepon.Name = "labelTelepon";
            this.labelTelepon.Size = new System.Drawing.Size(100, 23);
            this.labelTelepon.TabIndex = 4;
            this.labelTelepon.Text = "No Telepon";
            // 
            // labelAlamat
            // 
            this.labelAlamat.Location = new System.Drawing.Point(30, 240);
            this.labelAlamat.Name = "labelAlamat";
            this.labelAlamat.Size = new System.Drawing.Size(100, 23);
            this.labelAlamat.TabIndex = 5;
            this.labelAlamat.Text = "Alamat";
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(150, 75);
            this.txtId.Name = "txtId";
            this.txtId.ReadOnly = true;
            this.txtId.Size = new System.Drawing.Size(180, 22);
            this.txtId.TabIndex = 6;
            // 
            // txtNama
            // 
            this.txtNama.Location = new System.Drawing.Point(150, 115);
            this.txtNama.Name = "txtNama";
            this.txtNama.Size = new System.Drawing.Size(250, 22);
            this.txtNama.TabIndex = 7;
            // 
            // txtNik
            // 
            this.txtNik.Location = new System.Drawing.Point(150, 155);
            this.txtNik.Name = "txtNik";
            this.txtNik.Size = new System.Drawing.Size(250, 22);
            this.txtNik.TabIndex = 8;
            // 
            // txtTelepon
            // 
            this.txtTelepon.Location = new System.Drawing.Point(150, 195);
            this.txtTelepon.Name = "txtTelepon";
            this.txtTelepon.Size = new System.Drawing.Size(250, 22);
            this.txtTelepon.TabIndex = 9;
            // 
            // txtAlamat
            // 
            this.txtAlamat.Location = new System.Drawing.Point(150, 235);
            this.txtAlamat.Name = "txtAlamat";
            this.txtAlamat.Size = new System.Drawing.Size(250, 80);
            this.txtAlamat.TabIndex = 10;
            this.txtAlamat.Text = "";
            // 
            // btnSimpan
            // 
            this.btnSimpan.Location = new System.Drawing.Point(30, 330);
            this.btnSimpan.Name = "btnSimpan";
            this.btnSimpan.Size = new System.Drawing.Size(90, 23);
            this.btnSimpan.TabIndex = 11;
            this.btnSimpan.Text = "Simpan";
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(130, 330);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(90, 23);
            this.btnEdit.TabIndex = 12;
            this.btnEdit.Text = "Edit";
            // 
            // btnHapus
            // 
            this.btnHapus.Location = new System.Drawing.Point(230, 330);
            this.btnHapus.Name = "btnHapus";
            this.btnHapus.Size = new System.Drawing.Size(90, 23);
            this.btnHapus.TabIndex = 13;
            this.btnHapus.Text = "Hapus";
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(330, 330);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(90, 23);
            this.btnReset.TabIndex = 14;
            this.btnReset.Text = "Reset";
            // 
            // dgvPelanggan
            // 
            this.dgvPelanggan.ColumnHeadersHeight = 29;
            this.dgvPelanggan.Location = new System.Drawing.Point(30, 380);
            this.dgvPelanggan.MultiSelect = false;
            this.dgvPelanggan.Name = "dgvPelanggan";
            this.dgvPelanggan.ReadOnly = true;
            this.dgvPelanggan.RowHeadersWidth = 51;
            this.dgvPelanggan.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPelanggan.Size = new System.Drawing.Size(600, 200);
            this.dgvPelanggan.TabIndex = 15;
            // 
            // FormPelanggan
            // 
            this.ClientSize = new System.Drawing.Size(700, 620);
            this.Controls.Add(this.panelHeader);
            this.Controls.Add(this.labelId);
            this.Controls.Add(this.labelNama);
            this.Controls.Add(this.labelNik);
            this.Controls.Add(this.labelTelepon);
            this.Controls.Add(this.labelAlamat);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.txtNama);
            this.Controls.Add(this.txtNik);
            this.Controls.Add(this.txtTelepon);
            this.Controls.Add(this.txtAlamat);
            this.Controls.Add(this.btnSimpan);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnHapus);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.dgvPelanggan);
            this.Name = "FormPelanggan";
            this.Text = "Form Pelanggan";
            this.Load += new System.EventHandler(this.FormPelanggan_Load_1);
            this.panelHeader.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPelanggan)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}
