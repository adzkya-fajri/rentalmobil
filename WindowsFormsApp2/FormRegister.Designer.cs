using System.Windows.Forms;

namespace RentalMobil
{
    partial class FormRegister
    {
        private System.ComponentModel.IContainer components = null;

        private Panel panelLeft;
        private Panel panelRight;
        private PictureBox picLogo;
        private Label lblTitle;
        private Label lblSubtitle;

        private Label lblRegisterTitle;
        private Label lblFullName;
        private TextBox txtFullName;

        private Label lblUsername;
        private TextBox txtUsername;

        private Label lblPassword;
        private TextBox txtPassword;

        private Label lblConfirmPassword;
        private TextBox txtConfirmPassword;

        private CheckBox chkShowPassword;

        private Button btnRegister;
        private Button btnCancel;

        private Label lblHaveAccount;
        private Label lblLoginNow;

        protected override void Dispose(bool disposing)
        {
            if (disposing && components != null)
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.panelLeft = new Panel();
            this.picLogo = new PictureBox();
            this.lblTitle = new Label();
            this.lblSubtitle = new Label();

            this.panelRight = new Panel();
            this.lblRegisterTitle = new Label();
            this.lblFullName = new Label();
            this.txtFullName = new TextBox();

            this.lblUsername = new Label();
            this.txtUsername = new TextBox();

            this.lblPassword = new Label();
            this.txtPassword = new TextBox();

            this.lblConfirmPassword = new Label();
            this.txtConfirmPassword = new TextBox();

            this.chkShowPassword = new CheckBox();

            this.btnRegister = new Button();
            this.btnCancel = new Button();

            this.lblHaveAccount = new Label();
            this.lblLoginNow = new Label();

            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).BeginInit();
            this.panelLeft.SuspendLayout();
            this.panelRight.SuspendLayout();
            this.SuspendLayout();

            // PANEL LEFT
            this.panelLeft.BackColor = System.Drawing.Color.FromArgb(25, 25, 28);
            this.panelLeft.Dock = DockStyle.Left;
            this.panelLeft.Size = new System.Drawing.Size(350, 500);
            this.panelLeft.Controls.Add(this.picLogo);
            this.panelLeft.Controls.Add(this.lblTitle);
            this.panelLeft.Controls.Add(this.lblSubtitle);

            // LOGO
            this.picLogo.BackColor = System.Drawing.Color.FromArgb(0, 120, 215);
            this.picLogo.Size = new System.Drawing.Size(100, 100);
            this.picLogo.Location = new System.Drawing.Point(125, 80);
            this.picLogo.SizeMode = PictureBoxSizeMode.CenterImage;

            // TITLE
            this.lblTitle.Text = "RENTAL MOBIL";
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.lblTitle.Location = new System.Drawing.Point(40, 200);
            this.lblTitle.Size = new System.Drawing.Size(270, 40);
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            // SUBTITLE
            this.lblSubtitle.Text = "Sistem Manajemen Rental Kendaraan";
            this.lblSubtitle.ForeColor = System.Drawing.Color.FromArgb(180, 180, 180);
            this.lblSubtitle.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblSubtitle.Location = new System.Drawing.Point(40, 240);
            this.lblSubtitle.Size = new System.Drawing.Size(270, 40);
            this.lblSubtitle.TextAlign = System.Drawing.ContentAlignment.TopCenter;

            // PANEL RIGHT
            this.panelRight.BackColor = System.Drawing.Color.FromArgb(35, 35, 38);
            this.panelRight.Dock = DockStyle.Fill;

            // REGISTER TITLE
            this.lblRegisterTitle.Text = "Daftar Akun Baru";
            this.lblRegisterTitle.ForeColor = System.Drawing.Color.White;
            this.lblRegisterTitle.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold);
            this.lblRegisterTitle.Location = new System.Drawing.Point(40, 40);
            this.lblRegisterTitle.Size = new System.Drawing.Size(270, 40);

            // FULL NAME
            this.lblFullName.Text = "Nama Lengkap";
            this.lblFullName.ForeColor = System.Drawing.Color.White;
            this.lblFullName.Location = new System.Drawing.Point(40, 110);

            this.txtFullName.BackColor = System.Drawing.Color.FromArgb(50, 50, 55);
            this.txtFullName.ForeColor = System.Drawing.Color.White;
            this.txtFullName.BorderStyle = BorderStyle.FixedSingle;
            this.txtFullName.Location = new System.Drawing.Point(40, 130);
            this.txtFullName.Size = new System.Drawing.Size(270, 25);

            // USERNAME
            this.lblUsername.Text = "Username";
            this.lblUsername.ForeColor = System.Drawing.Color.White;
            this.lblUsername.Location = new System.Drawing.Point(40, 170);

            this.txtUsername.BackColor = System.Drawing.Color.FromArgb(50, 50, 55);
            this.txtUsername.ForeColor = System.Drawing.Color.White;
            this.txtUsername.BorderStyle = BorderStyle.FixedSingle;
            this.txtUsername.Location = new System.Drawing.Point(40, 190);
            this.txtUsername.Size = new System.Drawing.Size(270, 25);

            // PASSWORD
            this.lblPassword.Text = "Password";
            this.lblPassword.ForeColor = System.Drawing.Color.White;
            this.lblPassword.Location = new System.Drawing.Point(40, 230);

            this.txtPassword.BackColor = System.Drawing.Color.FromArgb(50, 50, 55);
            this.txtPassword.ForeColor = System.Drawing.Color.White;
            this.txtPassword.BorderStyle = BorderStyle.FixedSingle;
            this.txtPassword.Location = new System.Drawing.Point(40, 250);
            this.txtPassword.Size = new System.Drawing.Size(270, 25);
            this.txtPassword.PasswordChar = '●';

            // CONFIRM PASSWORD
            this.lblConfirmPassword.Text = "Konfirmasi Password";
            this.lblConfirmPassword.ForeColor = System.Drawing.Color.White;
            this.lblConfirmPassword.Location = new System.Drawing.Point(40, 290);

            this.txtConfirmPassword.BackColor = System.Drawing.Color.FromArgb(50, 50, 55);
            this.txtConfirmPassword.ForeColor = System.Drawing.Color.White;
            this.txtConfirmPassword.BorderStyle = BorderStyle.FixedSingle;
            this.txtConfirmPassword.Location = new System.Drawing.Point(40, 310);
            this.txtConfirmPassword.Size = new System.Drawing.Size(270, 25);
            this.txtConfirmPassword.PasswordChar = '●';

            // SHOW PASSWORD
            this.chkShowPassword.Text = "Tampilkan Password";
            this.chkShowPassword.ForeColor = System.Drawing.Color.White;
            this.chkShowPassword.Location = new System.Drawing.Point(40, 345);
            this.chkShowPassword.CheckedChanged += new System.EventHandler(this.chkShowPassword_CheckedChanged);

            // BUTTON REGISTER
            this.btnRegister.Text = "DAFTAR";
            this.btnRegister.BackColor = System.Drawing.Color.FromArgb(0, 120, 215);
            this.btnRegister.ForeColor = System.Drawing.Color.White;
            this.btnRegister.FlatStyle = FlatStyle.Flat;
            this.btnRegister.Location = new System.Drawing.Point(40, 380);
            this.btnRegister.Size = new System.Drawing.Size(270, 40);
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);

            // CANCEL BUTTON
            this.btnCancel.Text = "CANCEL";
            this.btnCancel.BackColor = System.Drawing.Color.FromArgb(60, 60, 65);
            this.btnCancel.ForeColor = System.Drawing.Color.White;
            this.btnCancel.FlatStyle = FlatStyle.Flat;
            this.btnCancel.Location = new System.Drawing.Point(40, 430);
            this.btnCancel.Size = new System.Drawing.Size(270, 40);
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);

            // HAVE ACCOUNT
            this.lblHaveAccount.Text = "Sudah punya akun?";
            this.lblHaveAccount.ForeColor = System.Drawing.Color.FromArgb(180, 180, 180);
            this.lblHaveAccount.Location = new System.Drawing.Point(70, 480);

            // LOGIN LABEL
            this.lblLoginNow.Text = "Login di sini";
            this.lblLoginNow.ForeColor = System.Drawing.Color.FromArgb(0, 150, 255);
            this.lblLoginNow.Location = new System.Drawing.Point(180, 480);
            this.lblLoginNow.Cursor = Cursors.Hand;
            this.lblLoginNow.Click += new System.EventHandler(this.lblLoginNow_Click);

            // ADD CONTROLS
            this.panelRight.Controls.Add(this.lblRegisterTitle);
            this.panelRight.Controls.Add(this.lblFullName);
            this.panelRight.Controls.Add(this.txtFullName);

            this.panelRight.Controls.Add(this.lblUsername);
            this.panelRight.Controls.Add(this.txtUsername);

            this.panelRight.Controls.Add(this.lblPassword);
            this.panelRight.Controls.Add(this.txtPassword);

            this.panelRight.Controls.Add(this.lblConfirmPassword);
            this.panelRight.Controls.Add(this.txtConfirmPassword);

            this.panelRight.Controls.Add(this.chkShowPassword);

            this.panelRight.Controls.Add(this.btnRegister);
            this.panelRight.Controls.Add(this.btnCancel);

            this.panelRight.Controls.Add(this.lblHaveAccount);
            this.panelRight.Controls.Add(this.lblLoginNow);

            // FORM SETTINGS
            this.BackColor = System.Drawing.Color.FromArgb(30, 30, 32);
            this.ClientSize = new System.Drawing.Size(700, 500);
            this.Controls.Add(this.panelRight);
            this.Controls.Add(this.panelLeft);
            this.FormBorderStyle = FormBorderStyle.None;
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Text = "Register";

            this.panelLeft.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).EndInit();
            this.panelRight.ResumeLayout(false);
            this.panelRight.PerformLayout();
            this.ResumeLayout(false);
        }
    }
}
