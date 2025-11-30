using System;
using System.Drawing;
using System.Drawing.Printing;
using System.Windows.Forms;

namespace RentalMobil
{
    public partial class FormStruk : Form
    {
        public string IDPenyewa { get; set; }
        public string NamaPenyewa { get; set; }
        public string Tanggal { get; set; }
        public string Email { get; set; }
        public string IDMobil { get; set; }
        public string NamaMobil { get; set; }
        public string Harga { get; set; }

        public FormStruk()
        {
            InitializeComponent();
            this.Load += FormStruk_Load;
        }

        private void FormStruk_Load(object sender, EventArgs e)
        {
            lblStruk.Text = $@"
========== STRUK RENTAL ==========
ID Penyewa : {IDPenyewa}
Nama       : {NamaPenyewa}
Tanggal    : {Tanggal}
Email      : {Email}
----------------------------------
ID Mobil   : {IDMobil}
Nama Mobil : {NamaMobil}
Harga      : Rp {Harga}
----------------------------------
Terima kasih telah menggunakan
layanan rental kami!
========== STRUK RENTAL ==========
";
        }

        private void BtnPrint_Click(object sender, EventArgs e)
        {
            PrintDocument pd = new PrintDocument();
            pd.PrintPage += PrintPage;

            PrintDialog pDialog = new PrintDialog
            {
                Document = pd
            };

            if (pDialog.ShowDialog() == DialogResult.OK)
            {
                pd.Print();
            }
        }

        private void PrintPage(object sender, PrintPageEventArgs e)
        {
            Font font = new Font("Courier New", 10);
            e.Graphics.DrawString(lblStruk.Text, font, Brushes.Black, 10, 10);
        }

        private void BtnSaveImage_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog sfd = new SaveFileDialog())
            {
                sfd.Filter = "PNG Image|*.png";
                sfd.FileName = $"Struk_{IDPenyewa}_{DateTime.Now:yyyyMMdd_HHmmss}";
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    Bitmap bmp = new Bitmap(lblStruk.Width, lblStruk.Height);
                    lblStruk.DrawToBitmap(bmp, new Rectangle(0, 0, lblStruk.Width, lblStruk.Height));
                    bmp.Save(sfd.FileName, System.Drawing.Imaging.ImageFormat.Png);
                    MessageBox.Show("Struk berhasil disimpan sebagai gambar!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
    }
}