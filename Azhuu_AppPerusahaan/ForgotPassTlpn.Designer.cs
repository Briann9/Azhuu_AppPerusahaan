
namespace Azhuu_AppPerusahaan
{
    partial class FormForgotPassTlpn
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
            this.buttonContinue = new System.Windows.Forms.Button();
            this.tBoxNoTelp = new System.Windows.Forms.TextBox();
            this.labelMasukkanTlpn = new System.Windows.Forms.Label();
            this.labelForgotPassword = new System.Windows.Forms.Label();
            this.labelNoTlpnSalah = new System.Windows.Forms.Label();
            this.buttonBack = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonContinue
            // 
            this.buttonContinue.Location = new System.Drawing.Point(532, 477);
            this.buttonContinue.Margin = new System.Windows.Forms.Padding(4);
            this.buttonContinue.Name = "buttonContinue";
            this.buttonContinue.Size = new System.Drawing.Size(242, 28);
            this.buttonContinue.TabIndex = 35;
            this.buttonContinue.Text = "CONTINUE";
            this.buttonContinue.UseVisualStyleBackColor = true;
            this.buttonContinue.Click += new System.EventHandler(this.buttonContinue_Click);
            // 
            // tBoxNoTelp
            // 
            this.tBoxNoTelp.Location = new System.Drawing.Point(388, 396);
            this.tBoxNoTelp.Margin = new System.Windows.Forms.Padding(4);
            this.tBoxNoTelp.Name = "tBoxNoTelp";
            this.tBoxNoTelp.Size = new System.Drawing.Size(521, 22);
            this.tBoxNoTelp.TabIndex = 34;
            // 
            // labelMasukkanTlpn
            // 
            this.labelMasukkanTlpn.AutoSize = true;
            this.labelMasukkanTlpn.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMasukkanTlpn.Location = new System.Drawing.Point(553, 363);
            this.labelMasukkanTlpn.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelMasukkanTlpn.Name = "labelMasukkanTlpn";
            this.labelMasukkanTlpn.Size = new System.Drawing.Size(204, 29);
            this.labelMasukkanTlpn.TabIndex = 33;
            this.labelMasukkanTlpn.Text = "MASUKAN NO TELP";
            // 
            // labelForgotPassword
            // 
            this.labelForgotPassword.AutoSize = true;
            this.labelForgotPassword.Font = new System.Drawing.Font("Copperplate Gothic Bold", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelForgotPassword.Location = new System.Drawing.Point(378, 254);
            this.labelForgotPassword.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelForgotPassword.Name = "labelForgotPassword";
            this.labelForgotPassword.Size = new System.Drawing.Size(531, 55);
            this.labelForgotPassword.TabIndex = 32;
            this.labelForgotPassword.Text = "Forgot Password";
            // 
            // labelNoTlpnSalah
            // 
            this.labelNoTlpnSalah.AutoSize = true;
            this.labelNoTlpnSalah.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNoTlpnSalah.ForeColor = System.Drawing.Color.Red;
            this.labelNoTlpnSalah.Location = new System.Drawing.Point(528, 529);
            this.labelNoTlpnSalah.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelNoTlpnSalah.Name = "labelNoTlpnSalah";
            this.labelNoTlpnSalah.Size = new System.Drawing.Size(241, 24);
            this.labelNoTlpnSalah.TabIndex = 36;
            this.labelNoTlpnSalah.Text = "* NOMOR TELEPON SALAH !";
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
            // FormForgotPassTlpn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1262, 673);
            this.Controls.Add(this.buttonBack);
            this.Controls.Add(this.labelNoTlpnSalah);
            this.Controls.Add(this.buttonContinue);
            this.Controls.Add(this.tBoxNoTelp);
            this.Controls.Add(this.labelMasukkanTlpn);
            this.Controls.Add(this.labelForgotPassword);
            this.Name = "FormForgotPassTlpn";
            this.Text = "Forgot Password Telepon";
            this.Load += new System.EventHandler(this.FormForgotPassTlpn_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonContinue;
        private System.Windows.Forms.TextBox tBoxNoTelp;
        private System.Windows.Forms.Label labelMasukkanTlpn;
        private System.Windows.Forms.Label labelForgotPassword;
        private System.Windows.Forms.Label labelNoTlpnSalah;
        private System.Windows.Forms.Button buttonBack;
    }
}