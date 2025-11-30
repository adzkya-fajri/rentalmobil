using System.Drawing;
using System.Windows.Forms;

namespace RentalMobil
{
    partial class FormStruk
    {
        private System.ComponentModel.IContainer components = null;
        private Label lblStruk;
        private Button btnPrint;
        private Button btnSaveImage;

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
            this.lblStruk = new Label();
            this.btnPrint = new Button();
            this.btnSaveImage = new Button();
            this.SuspendLayout();

            // lblStruk
            this.lblStruk.BorderStyle = BorderStyle.FixedSingle;
            this.lblStruk.Font = new Font("Courier New", 10);
            this.lblStruk.Location = new Point(12, 12);
            this.lblStruk.Size = new Size(460, 300);
            this.lblStruk.Text = "";

            // btnPrint
            this.btnPrint.Text = "Print";
            this.btnPrint.Location = new Point(370, 330);
            this.btnPrint.Size = new Size(100, 30);
            this.btnPrint.Click += BtnPrint_Click;

            // btnSaveImage
            this.btnSaveImage.Text = "Simpan Gambar";
            this.btnSaveImage.Location = new Point(250, 330);
            this.btnSaveImage.Size = new Size(110, 30);
            this.btnSaveImage.Click += BtnSaveImage_Click;

            // FormStruk
            this.ClientSize = new Size(485, 375);
            this.Controls.Add(this.btnSaveImage);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.lblStruk);
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Text = "Struk Rental";
            this.ResumeLayout(false);
        }
    }
}