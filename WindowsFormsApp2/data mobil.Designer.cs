using System.Windows.Forms;

namespace RentalMobil
{
    partial class FormDataMobil
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.TextBox txtIDMobil;
        private System.Windows.Forms.TextBox txtMerk;
        private System.Windows.Forms.TextBox txtModel;
        private System.Windows.Forms.TextBox txtTahun;
        private System.Windows.Forms.TextBox txtWarna;
        private System.Windows.Forms.TextBox txtNoPlat;
        private System.Windows.Forms.ComboBox cmbJenisBahanBakar;
        private System.Windows.Forms.ComboBox cmbTransmisi;
        private System.Windows.Forms.TextBox txtKapasitasMesin;
        private System.Windows.Forms.TextBox txtKapasitasPenumpang;
        private System.Windows.Forms.TextBox txtHargaSewa;
        private System.Windows.Forms.ComboBox cmbStatus;
        private System.Windows.Forms.DataGridView dgvData;
        private System.Windows.Forms.Button btnTambah;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnHapus;
        private System.Windows.Forms.Button btnBersihkan;
        private System.Windows.Forms.TextBox txtCari;
        private System.Windows.Forms.Button btnCari;
        private System.Windows.Forms.Button btnReset;

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
            this.txtIDMobil = new System.Windows.Forms.TextBox();
            this.txtMerk = new System.Windows.Forms.TextBox();
            this.txtModel = new System.Windows.Forms.TextBox();
            this.txtTahun = new System.Windows.Forms.TextBox();
            this.txtWarna = new System.Windows.Forms.TextBox();
            this.txtNoPlat = new System.Windows.Forms.TextBox();
            this.cmbJenisBahanBakar = new System.Windows.Forms.ComboBox();
            this.cmbTransmisi = new System.Windows.Forms.ComboBox();
            this.txtKapasitasMesin = new System.Windows.Forms.TextBox();
            this.txtKapasitasPenumpang = new System.Windows.Forms.TextBox();
            this.txtHargaSewa = new System.Windows.Forms.TextBox();
            this.cmbStatus = new System.Windows.Forms.ComboBox();
            this.dgvData = new System.Windows.Forms.DataGridView();
            this.btnTambah = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnHapus = new System.Windows.Forms.Button();
            this.btnBersihkan = new System.Windows.Forms.Button();
            this.txtCari = new System.Windows.Forms.TextBox();
            this.btnCari = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvData)).BeginInit();
            this.SuspendLayout();
            // 
            // txtIDMobil
            // 
            this.txtIDMobil.Location = new System.Drawing.Point(120, 20);
            this.txtIDMobil.Name = "txtIDMobil";
            this.txtIDMobil.Size = new System.Drawing.Size(200, 20);
            this.txtIDMobil.TabIndex = 18;
            // 
            // txtMerk
            // 
            this.txtMerk.Location = new System.Drawing.Point(120, 50);
            this.txtMerk.Name = "txtMerk";
            this.txtMerk.Size = new System.Drawing.Size(200, 20);
            this.txtMerk.TabIndex = 17;
            // 
            // txtModel
            // 
            this.txtModel.Location = new System.Drawing.Point(120, 80);
            this.txtModel.Name = "txtModel";
            this.txtModel.Size = new System.Drawing.Size(200, 20);
            this.txtModel.TabIndex = 16;
            // 
            // txtTahun
            // 
            this.txtTahun.Location = new System.Drawing.Point(120, 110);
            this.txtTahun.Name = "txtTahun";
            this.txtTahun.Size = new System.Drawing.Size(200, 20);
            this.txtTahun.TabIndex = 15;
            // 
            // txtWarna
            // 
            this.txtWarna.Location = new System.Drawing.Point(120, 140);
            this.txtWarna.Name = "txtWarna";
            this.txtWarna.Size = new System.Drawing.Size(200, 20);
            this.txtWarna.TabIndex = 14;
            // 
            // txtNoPlat
            // 
            this.txtNoPlat.Location = new System.Drawing.Point(120, 170);
            this.txtNoPlat.Name = "txtNoPlat";
            this.txtNoPlat.Size = new System.Drawing.Size(200, 20);
            this.txtNoPlat.TabIndex = 13;
            // 
            // cmbJenisBahanBakar
            // 
            this.cmbJenisBahanBakar.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbJenisBahanBakar.Items.AddRange(new object[] {
            "Bensin",
            "Diesel",
            "Hybrid",
            "Listrik"});
            this.cmbJenisBahanBakar.Location = new System.Drawing.Point(120, 200);
            this.cmbJenisBahanBakar.Name = "cmbJenisBahanBakar";
            this.cmbJenisBahanBakar.Size = new System.Drawing.Size(200, 21);
            this.cmbJenisBahanBakar.TabIndex = 12;
            // 
            // cmbTransmisi
            // 
            this.cmbTransmisi.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTransmisi.Items.AddRange(new object[] {
            "Manual",
            "Otomatis"});
            this.cmbTransmisi.Location = new System.Drawing.Point(120, 230);
            this.cmbTransmisi.Name = "cmbTransmisi";
            this.cmbTransmisi.Size = new System.Drawing.Size(200, 21);
            this.cmbTransmisi.TabIndex = 11;
            // 
            // txtKapasitasMesin
            // 
            this.txtKapasitasMesin.Location = new System.Drawing.Point(120, 260);
            this.txtKapasitasMesin.Name = "txtKapasitasMesin";
            this.txtKapasitasMesin.Size = new System.Drawing.Size(200, 20);
            this.txtKapasitasMesin.TabIndex = 10;
            // 
            // txtKapasitasPenumpang
            // 
            this.txtKapasitasPenumpang.Location = new System.Drawing.Point(120, 290);
            this.txtKapasitasPenumpang.Name = "txtKapasitasPenumpang";
            this.txtKapasitasPenumpang.Size = new System.Drawing.Size(200, 20);
            this.txtKapasitasPenumpang.TabIndex = 9;
            // 
            // txtHargaSewa
            // 
            this.txtHargaSewa.Location = new System.Drawing.Point(120, 320);
            this.txtHargaSewa.Name = "txtHargaSewa";
            this.txtHargaSewa.Size = new System.Drawing.Size(200, 20);
            this.txtHargaSewa.TabIndex = 8;
            // 
            // cmbStatus
            // 
            this.cmbStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbStatus.Items.AddRange(new object[] {
            "Tersedia",
            "Disewa"});
            this.cmbStatus.Location = new System.Drawing.Point(120, 350);
            this.cmbStatus.Name = "cmbStatus";
            this.cmbStatus.Size = new System.Drawing.Size(200, 21);
            this.cmbStatus.TabIndex = 7;
            // 
            // dgvData
            // 
            this.dgvData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvData.Location = new System.Drawing.Point(350, 20);
            this.dgvData.Name = "dgvData";
            this.dgvData.Size = new System.Drawing.Size(650, 350);
            this.dgvData.TabIndex = 0;
            // 
            // btnTambah
            // 
            this.btnTambah.Location = new System.Drawing.Point(20, 390);
            this.btnTambah.Name = "btnTambah";
            this.btnTambah.Size = new System.Drawing.Size(75, 23);
            this.btnTambah.TabIndex = 6;
            this.btnTambah.Text = "Tambah";
            this.btnTambah.UseVisualStyleBackColor = true;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(110, 390);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate.TabIndex = 5;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            // 
            // btnHapus
            // 
            this.btnHapus.Location = new System.Drawing.Point(200, 390);
            this.btnHapus.Name = "btnHapus";
            this.btnHapus.Size = new System.Drawing.Size(75, 23);
            this.btnHapus.TabIndex = 4;
            this.btnHapus.Text = "Hapus";
            this.btnHapus.UseVisualStyleBackColor = true;
            // 
            // btnBersihkan
            // 
            this.btnBersihkan.Location = new System.Drawing.Point(290, 390);
            this.btnBersihkan.Name = "btnBersihkan";
            this.btnBersihkan.Size = new System.Drawing.Size(75, 23);
            this.btnBersihkan.TabIndex = 3;
            this.btnBersihkan.Text = "Bersihkan";
            this.btnBersihkan.UseVisualStyleBackColor = true;
            // 
            // txtCari
            // 
            this.txtCari.Location = new System.Drawing.Point(395, 393);
            this.txtCari.Name = "txtCari";
            this.txtCari.Size = new System.Drawing.Size(200, 20);
            this.txtCari.TabIndex = 2;
            // 
            // btnCari
            // 
            this.btnCari.Location = new System.Drawing.Point(621, 390);
            this.btnCari.Name = "btnCari";
            this.btnCari.Size = new System.Drawing.Size(75, 23);
            this.btnCari.TabIndex = 1;
            this.btnCari.Text = "Cari";
            this.btnCari.UseVisualStyleBackColor = true;
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(712, 390);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(75, 23);
            this.btnReset.TabIndex = 0;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            // 
            // FormDataMobil
            // 
            this.ClientSize = new System.Drawing.Size(1020, 450);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnCari);
            this.Controls.Add(this.txtCari);
            this.Controls.Add(this.btnBersihkan);
            this.Controls.Add(this.btnHapus);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnTambah);
            this.Controls.Add(this.dgvData);
            this.Controls.Add(this.cmbStatus);
            this.Controls.Add(this.txtHargaSewa);
            this.Controls.Add(this.txtKapasitasPenumpang);
            this.Controls.Add(this.txtKapasitasMesin);
            this.Controls.Add(this.cmbTransmisi);
            this.Controls.Add(this.cmbJenisBahanBakar);
            this.Controls.Add(this.txtNoPlat);
            this.Controls.Add(this.txtWarna);
            this.Controls.Add(this.txtTahun);
            this.Controls.Add(this.txtModel);
            this.Controls.Add(this.txtMerk);
            this.Controls.Add(this.txtIDMobil);
            this.Name = "FormDataMobil";
            this.Text = "Data Mobil";
            ((System.ComponentModel.ISupportInitialize)(this.dgvData)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}