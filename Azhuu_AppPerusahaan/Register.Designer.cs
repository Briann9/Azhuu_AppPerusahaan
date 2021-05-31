
namespace Azhuu_AppPerusahaan
{
    partial class FormRegister
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tBoxID = new System.Windows.Forms.TextBox();
            this.tBoxNama = new System.Windows.Forms.TextBox();
            this.tBoxEmail = new System.Windows.Forms.TextBox();
            this.tBoxNomorTlpn = new System.Windows.Forms.TextBox();
            this.tBoxAlamat = new System.Windows.Forms.TextBox();
            this.tBoxPassword = new System.Windows.Forms.TextBox();
            this.tBoxConfirmPassword = new System.Windows.Forms.TextBox();
            this.buttonRegister = new System.Windows.Forms.Button();
            this.labelAlreadyHaveAcc = new System.Windows.Forms.Label();
            this.labelHereSignIn = new System.Windows.Forms.Label();
            this.labelEmailSudahTerpakai = new System.Windows.Forms.Label();
            this.buttonBack = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tBoxID
            // 
            this.tBoxID.Enabled = false;
            this.tBoxID.ForeColor = System.Drawing.Color.Gray;
            this.tBoxID.Location = new System.Drawing.Point(1065, 64);
            this.tBoxID.Name = "tBoxID";
            this.tBoxID.Size = new System.Drawing.Size(168, 22);
            this.tBoxID.TabIndex = 0;
            this.tBoxID.Text = "PO BUS ID";
            // 
            // tBoxNama
            // 
            this.tBoxNama.ForeColor = System.Drawing.Color.Gray;
            this.tBoxNama.Location = new System.Drawing.Point(858, 114);
            this.tBoxNama.Name = "tBoxNama";
            this.tBoxNama.Size = new System.Drawing.Size(375, 22);
            this.tBoxNama.TabIndex = 1;
            this.tBoxNama.Text = " PO Bus Name";
            // 
            // tBoxEmail
            // 
            this.tBoxEmail.ForeColor = System.Drawing.Color.Gray;
            this.tBoxEmail.Location = new System.Drawing.Point(858, 165);
            this.tBoxEmail.Name = "tBoxEmail";
            this.tBoxEmail.Size = new System.Drawing.Size(375, 22);
            this.tBoxEmail.TabIndex = 2;
            this.tBoxEmail.Text = " Email";
            // 
            // tBoxNomorTlpn
            // 
            this.tBoxNomorTlpn.ForeColor = System.Drawing.Color.Gray;
            this.tBoxNomorTlpn.Location = new System.Drawing.Point(858, 214);
            this.tBoxNomorTlpn.Name = "tBoxNomorTlpn";
            this.tBoxNomorTlpn.Size = new System.Drawing.Size(375, 22);
            this.tBoxNomorTlpn.TabIndex = 3;
            this.tBoxNomorTlpn.Text = " MOBILE NUMBER";
            // 
            // tBoxAlamat
            // 
            this.tBoxAlamat.ForeColor = System.Drawing.Color.Gray;
            this.tBoxAlamat.Location = new System.Drawing.Point(858, 264);
            this.tBoxAlamat.Name = "tBoxAlamat";
            this.tBoxAlamat.Size = new System.Drawing.Size(375, 22);
            this.tBoxAlamat.TabIndex = 4;
            this.tBoxAlamat.Text = " Address";
            // 
            // tBoxPassword
            // 
            this.tBoxPassword.ForeColor = System.Drawing.Color.Gray;
            this.tBoxPassword.Location = new System.Drawing.Point(858, 312);
            this.tBoxPassword.Name = "tBoxPassword";
            this.tBoxPassword.Size = new System.Drawing.Size(375, 22);
            this.tBoxPassword.TabIndex = 5;
            this.tBoxPassword.Text = " Password";
            // 
            // tBoxConfirmPassword
            // 
            this.tBoxConfirmPassword.ForeColor = System.Drawing.Color.Gray;
            this.tBoxConfirmPassword.Location = new System.Drawing.Point(858, 362);
            this.tBoxConfirmPassword.Name = "tBoxConfirmPassword";
            this.tBoxConfirmPassword.Size = new System.Drawing.Size(375, 22);
            this.tBoxConfirmPassword.TabIndex = 6;
            this.tBoxConfirmPassword.Text = " Confirm Password";
            // 
            // buttonRegister
            // 
            this.buttonRegister.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRegister.Location = new System.Drawing.Point(958, 513);
            this.buttonRegister.Name = "buttonRegister";
            this.buttonRegister.Size = new System.Drawing.Size(217, 32);
            this.buttonRegister.TabIndex = 8;
            this.buttonRegister.Text = "Register";
            this.buttonRegister.UseVisualStyleBackColor = true;
            this.buttonRegister.Click += new System.EventHandler(this.buttonRegister_Click);
            // 
            // labelAlreadyHaveAcc
            // 
            this.labelAlreadyHaveAcc.AutoSize = true;
            this.labelAlreadyHaveAcc.Location = new System.Drawing.Point(13, 622);
            this.labelAlreadyHaveAcc.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelAlreadyHaveAcc.Name = "labelAlreadyHaveAcc";
            this.labelAlreadyHaveAcc.Size = new System.Drawing.Size(200, 17);
            this.labelAlreadyHaveAcc.TabIndex = 18;
            this.labelAlreadyHaveAcc.Text = "Already have account? Sign in";
            // 
            // labelHereSignIn
            // 
            this.labelHereSignIn.AutoSize = true;
            this.labelHereSignIn.ForeColor = System.Drawing.Color.DarkOrange;
            this.labelHereSignIn.Location = new System.Drawing.Point(209, 622);
            this.labelHereSignIn.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelHereSignIn.Name = "labelHereSignIn";
            this.labelHereSignIn.Size = new System.Drawing.Size(39, 17);
            this.labelHereSignIn.TabIndex = 19;
            this.labelHereSignIn.Text = "Here";
            this.labelHereSignIn.Click += new System.EventHandler(this.labelHereSignIn_Click);
            // 
            // labelEmailSudahTerpakai
            // 
            this.labelEmailSudahTerpakai.AutoSize = true;
            this.labelEmailSudahTerpakai.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEmailSudahTerpakai.ForeColor = System.Drawing.Color.Red;
            this.labelEmailSudahTerpakai.Location = new System.Drawing.Point(854, 430);
            this.labelEmailSudahTerpakai.Name = "labelEmailSudahTerpakai";
            this.labelEmailSudahTerpakai.Size = new System.Drawing.Size(182, 20);
            this.labelEmailSudahTerpakai.TabIndex = 20;
            this.labelEmailSudahTerpakai.Text = "Email Sudah Terpakai !";
            // 
            // buttonBack
            // 
            this.buttonBack.Location = new System.Drawing.Point(13, 13);
            this.buttonBack.Margin = new System.Windows.Forms.Padding(4);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(39, 28);
            this.buttonBack.TabIndex = 40;
            this.buttonBack.Text = "<";
            this.buttonBack.UseVisualStyleBackColor = true;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // FormRegister
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1262, 673);
            this.Controls.Add(this.buttonBack);
            this.Controls.Add(this.labelEmailSudahTerpakai);
            this.Controls.Add(this.labelHereSignIn);
            this.Controls.Add(this.labelAlreadyHaveAcc);
            this.Controls.Add(this.buttonRegister);
            this.Controls.Add(this.tBoxConfirmPassword);
            this.Controls.Add(this.tBoxPassword);
            this.Controls.Add(this.tBoxAlamat);
            this.Controls.Add(this.tBoxNomorTlpn);
            this.Controls.Add(this.tBoxEmail);
            this.Controls.Add(this.tBoxNama);
            this.Controls.Add(this.tBoxID);
            this.Name = "FormRegister";
            this.Text = "Register";
            this.Load += new System.EventHandler(this.FormRegister_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tBoxID;
        private System.Windows.Forms.TextBox tBoxNama;
        private System.Windows.Forms.TextBox tBoxEmail;
        private System.Windows.Forms.TextBox tBoxNomorTlpn;
        private System.Windows.Forms.TextBox tBoxAlamat;
        private System.Windows.Forms.TextBox tBoxPassword;
        private System.Windows.Forms.TextBox tBoxConfirmPassword;
        private System.Windows.Forms.Button buttonRegister;
        private System.Windows.Forms.Label labelAlreadyHaveAcc;
        private System.Windows.Forms.Label labelHereSignIn;
        private System.Windows.Forms.Label labelEmailSudahTerpakai;
        private System.Windows.Forms.Button buttonBack;
    }
}