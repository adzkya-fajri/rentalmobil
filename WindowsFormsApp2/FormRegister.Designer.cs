using System.Windows.Forms;

namespace RentalMobil
{
    partial class FormRegister
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Panel panelLeft;
        private System.Windows.Forms.Panel panelRight;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblSubtitle;
        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.Label lblFullName;
        private System.Windows.Forms.TextBox txtFullName;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label lblConfirmPassword;
        private System.Windows.Forms.TextBox txtConfirmPassword;
        private System.Windows.Forms.CheckBox chkShowPassword;
        private System.Windows.Forms.CheckBox chkTerms;
        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label lblLogin;
        private System.Windows.Forms.Label lblHaveAccount;
        private System.Windows.Forms.PictureBox picLogo;

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
            this.SuspendLayout();
            // 
            // FormRegister
            // 
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Name = "FormRegister";
            this.Load += new System.EventHandler(this.FormRegister_Load);
            this.ResumeLayout(false);

        }

        private Label CreateLabel(string text, int y)
        {
            Label lbl = new Label();
            lbl.Text = text;
            lbl.Font = new System.Drawing.Font("Segoe UI", 9F);
            lbl.ForeColor = System.Drawing.Color.White;
            lbl.Location = new System.Drawing.Point(40, y);
            lbl.Size = new System.Drawing.Size(370, 20);
            return lbl;
        }

        private TextBox CreateTextBox(int y)
        {
            TextBox txt = new TextBox();
            txt.Location = new System.Drawing.Point(40, y);
            txt.Size = new System.Drawing.Size(370, 30);
            txt.BackColor = System.Drawing.Color.FromArgb(50, 50, 55);
            txt.ForeColor = System.Drawing.Color.White;
            txt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            txt.Font = new System.Drawing.Font("Segoe UI", 10F);
            return txt;
        }
    }
}