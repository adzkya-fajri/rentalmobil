using System.Windows.Forms;

namespace RentalMobil
{
    partial class FormRental
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Label lblIDPenyewa;
        private System.Windows.Forms.TextBox txtIDPenyewa;
        private System.Windows.Forms.Label lblNamaPenyewa;
        private System.Windows.Forms.TextBox txtNamaPenyewa;
        private System.Windows.Forms.Label lblTanggalRental;
        private System.Windows.Forms.DateTimePicker dtpTanggalRental;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lblIDMobil;
        private System.Windows.Forms.TextBox txtIDMobil;
        private System.Windows.Forms.Label lblNamaMobil;
        private System.Windows.Forms.TextBox txtNamaMobil;
        private System.Windows.Forms.Label lblHargaSewa;
        private System.Windows.Forms.TextBox txtHargaSewa;
        private System.Windows.Forms.Button btnSimpan;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnHapus;
        private System.Windows.Forms.Button btnBatal;
        private System.Windows.Forms.DataGridView dgvData;
        private System.Windows.Forms.Button btnCetak;

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
            this.lblIDPenyewa = new System.Windows.Forms.Label();
            this.txtIDPenyewa = new System.Windows.Forms.TextBox();
            this.lblNamaPenyewa = new System.Windows.Forms.Label();
            this.txtNamaPenyewa = new System.Windows.Forms.TextBox();
            this.lblTanggalRental = new System.Windows.Forms.Label();
            this.dtpTanggalRental = new System.Windows.Forms.DateTimePicker();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblIDMobil = new System.Windows.Forms.Label();
            this.txtIDMobil = new System.Windows.Forms.TextBox();
            this.lblNamaMobil = new System.Windows.Forms.Label();
            this.txtNamaMobil = new System.Windows.Forms.TextBox();
            this.lblHargaSewa = new System.Windows.Forms.Label();
            this.txtHargaSewa = new System.Windows.Forms.TextBox();
            this.btnSimpan = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnHapus = new System.Windows.Forms.Button();
            this.btnBatal = new System.Windows.Forms.Button();
            this.dgvData = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvData)).BeginInit();
            this.SuspendLayout();

            // lblIDPenyewa
            this.lblIDPenyewa.AutoSize = true;
            this.lblIDPenyewa.Location = new System.Drawing.Point(20, 20);
            this.lblIDPenyewa.Name = "lblIDPenyewa";
            this.lblIDPenyewa.Size = new System.Drawing.Size(63, 13);
            this.lblIDPenyewa.Text = "ID Penyewa";

            // txtIDPenyewa
            this.txtIDPenyewa.Location = new System.Drawing.Point(120, 17);
            this.txtIDPenyewa.Name = "txtIDPenyewa";
            this.txtIDPenyewa.Size = new System.Drawing.Size(200, 20);

            // lblNamaPenyewa
            this.lblNamaPenyewa.AutoSize = true;
            this.lblNamaPenyewa.Location = new System.Drawing.Point(20, 50);
            this.lblNamaPenyewa.Name = "lblNamaPenyewa";
            this.lblNamaPenyewa.Size = new System.Drawing.Size(82, 13);
            this.lblNamaPenyewa.Text = "Nama Penyewa";

            // txtNamaPenyewa
            this.txtNamaPenyewa.Location = new System.Drawing.Point(120, 47);
            this.txtNamaPenyewa.Name = "txtNamaPenyewa";
            this.txtNamaPenyewa.Size = new System.Drawing.Size(200, 20);

            // lblTanggalRental
            this.lblTanggalRental.AutoSize = true;
            this.lblTanggalRental.Location = new System.Drawing.Point(20, 80);
            this.lblTanggalRental.Name = "lblTanggalRental";
            this.lblTanggalRental.Size = new System.Drawing.Size(77, 13);
            this.lblTanggalRental.Text = "Tanggal Rental";

            // dtpTanggalRental
            this.dtpTanggalRental.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpTanggalRental.Location = new System.Drawing.Point(120, 77);
            this.dtpTanggalRental.Name = "dtpTanggalRental";
            this.dtpTanggalRental.Size = new System.Drawing.Size(200, 20);

            // lblEmail
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(20, 110);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(32, 13);
            this.lblEmail.Text = "Email";

            // txtEmail
            this.txtEmail.Location = new System.Drawing.Point(120, 107);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(200, 20);

            // lblIDMobil
            this.lblIDMobil.AutoSize = true;
            this.lblIDMobil.Location = new System.Drawing.Point(20, 140);
            this.lblIDMobil.Name = "lblIDMobil";
            this.lblIDMobil.Size = new System.Drawing.Size(45, 13);
            this.lblIDMobil.Text = "ID Mobil";

            // txtIDMobil
            this.txtIDMobil.Location = new System.Drawing.Point(120, 137);
            this.txtIDMobil.Name = "txtIDMobil";
            this.txtIDMobil.Size = new System.Drawing.Size(200, 20);

            // lblNamaMobil
            this.lblNamaMobil.AutoSize = true;
            this.lblNamaMobil.Location = new System.Drawing.Point(20, 170);
            this.lblNamaMobil.Name = "lblNamaMobil";
            this.lblNamaMobil.Size = new System.Drawing.Size(67, 13);
            this.lblNamaMobil.Text = "Nama Mobil";

            // txtNamaMobil
            this.txtNamaMobil.Location = new System.Drawing.Point(120, 167);
            this.txtNamaMobil.Name = "txtNamaMobil";
            this.txtNamaMobil.Size = new System.Drawing.Size(200, 20);

            // lblHargaSewa
            this.lblHargaSewa.AutoSize = true;
            this.lblHargaSewa.Location = new System.Drawing.Point(20, 200);
            this.lblHargaSewa.Name = "lblHargaSewa";
            this.lblHargaSewa.Size = new System.Drawing.Size(63, 13);
            this.lblHargaSewa.Text = "Harga Sewa";

            // txtHargaSewa
            this.txtHargaSewa.Location = new System.Drawing.Point(120, 197);
            this.txtHargaSewa.Name = "txtHargaSewa";
            this.txtHargaSewa.Size = new System.Drawing.Size(200, 20);

            // btnSimpan
            this.btnSimpan.Location = new System.Drawing.Point(20, 230);
            this.btnSimpan.Name = "btnSimpan";
            this.btnSimpan.Size = new System.Drawing.Size(75, 23);
            this.btnSimpan.Text = "Simpan";
            this.btnSimpan.UseVisualStyleBackColor = true;
            this.btnSimpan.Click += new System.EventHandler(this.BtnSimpan_Click);

            // btnUpdate
            this.btnUpdate.Location = new System.Drawing.Point(100, 230);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.BtnUpdate_Click);

            // btnHapus
            this.btnHapus.Location = new System.Drawing.Point(180, 230);
            this.btnHapus.Name = "btnHapus";
            this.btnHapus.Size = new System.Drawing.Size(75, 23);
            this.btnHapus.Text = "Hapus";
            this.btnHapus.UseVisualStyleBackColor = true;
            this.btnHapus.Click += new System.EventHandler(this.BtnHapus_Click);

            // btnBatal
            this.btnBatal.Location = new System.Drawing.Point(260, 230);
            this.btnBatal.Name = "btnBatal";
            this.btnBatal.Size = new System.Drawing.Size(75, 23);
            this.btnBatal.Text = "Batal";
            this.btnBatal.UseVisualStyleBackColor = true;
            this.btnBatal.Click += new System.EventHandler(this.BtnBatal_Click);

            // dgvData
            this.dgvData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvData.Location = new System.Drawing.Point(20, 270);
            this.dgvData.Name = "dgvData";
            this.dgvData.Size = new System.Drawing.Size(760, 200);
            this.dgvData.TabIndex = 0;

            // FormRental
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 500);
            this.Controls.Add(this.dgvData);
            this.Controls.Add(this.btnBatal);
            this.Controls.Add(this.btnHapus);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnSimpan);
            this.Controls.Add(this.txtHargaSewa);
            this.Controls.Add(this.lblHargaSewa);
            this.Controls.Add(this.txtNamaMobil);
            this.Controls.Add(this.lblNamaMobil);
            this.Controls.Add(this.txtIDMobil);
            this.Controls.Add(this.lblIDMobil);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.dtpTanggalRental);
            this.Controls.Add(this.lblTanggalRental);
            this.Controls.Add(this.txtNamaPenyewa);
            this.Controls.Add(this.lblNamaPenyewa);
            this.Controls.Add(this.txtIDPenyewa);
            this.Controls.Add(this.lblIDPenyewa);
            this.Name = "FormRental";
            this.Text = "Form Rental";
            ((System.ComponentModel.ISupportInitialize)(this.dgvData)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

            // btnCetak
            this.btnCetak = new Button();
            this.btnCetak.Text = "Cetak Struk";
            this.btnCetak.Location = new System.Drawing.Point(350, 230);
            this.btnCetak.Size = new System.Drawing.Size(90, 23);
            this.btnCetak.UseVisualStyleBackColor = true;
            this.btnCetak.Click += BtnCetak_Click;
            this.Controls.Add(this.btnCetak);
        }
    }
}