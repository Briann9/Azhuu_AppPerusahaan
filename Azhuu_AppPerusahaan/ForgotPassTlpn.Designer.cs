
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
            this.labelError = new System.Windows.Forms.Label();
            this.buttonBack = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonContinue
            // 
            this.buttonContinue.Location = new System.Drawing.Point(535, 398);
            this.buttonContinue.Name = "buttonContinue";
            this.buttonContinue.Size = new System.Drawing.Size(182, 23);
            this.buttonContinue.TabIndex = 35;
            this.buttonContinue.Text = "CONTINUE";
            this.buttonContinue.UseVisualStyleBackColor = true;
            this.buttonContinue.Click += new System.EventHandler(this.buttonContinue_Click);
            // 
            // tBoxNoTelp
            // 
            this.tBoxNoTelp.Location = new System.Drawing.Point(427, 332);
            this.tBoxNoTelp.Name = "tBoxNoTelp";
            this.tBoxNoTelp.Size = new System.Drawing.Size(392, 20);
            this.tBoxNoTelp.TabIndex = 34;
            // 
            // labelMasukkanTlpn
            // 
            this.labelMasukkanTlpn.AutoSize = true;
            this.labelMasukkanTlpn.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMasukkanTlpn.Location = new System.Drawing.Point(551, 305);
            this.labelMasukkanTlpn.Name = "labelMasukkanTlpn";
            this.labelMasukkanTlpn.Size = new System.Drawing.Size(160, 23);
            this.labelMasukkanTlpn.TabIndex = 33;
            this.labelMasukkanTlpn.Text = "MASUKAN NO TELP";
            // 
            // labelForgotPassword
            // 
            this.labelForgotPassword.AutoSize = true;
            this.labelForgotPassword.Font = new System.Drawing.Font("Copperplate Gothic Bold", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelForgotPassword.Location = new System.Drawing.Point(420, 216);
            this.labelForgotPassword.Name = "labelForgotPassword";
            this.labelForgotPassword.Size = new System.Drawing.Size(427, 44);
            this.labelForgotPassword.TabIndex = 32;
            this.labelForgotPassword.Text = "Forgot Password";
            // 
            // labelError
            // 
            this.labelError.AutoSize = true;
            this.labelError.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelError.ForeColor = System.Drawing.Color.Red;
            this.labelError.Location = new System.Drawing.Point(532, 440);
            this.labelError.Name = "labelError";
            this.labelError.Size = new System.Drawing.Size(14, 19);
            this.labelError.TabIndex = 36;
            this.labelError.Text = "-";
            // 
            // buttonBack
            // 
            this.buttonBack.Location = new System.Drawing.Point(10, 11);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(29, 23);
            this.buttonBack.TabIndex = 40;
            this.buttonBack.Text = "<";
            this.buttonBack.UseVisualStyleBackColor = true;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // FormForgotPassTlpn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.buttonBack);
            this.Controls.Add(this.labelError);
            this.Controls.Add(this.buttonContinue);
            this.Controls.Add(this.tBoxNoTelp);
            this.Controls.Add(this.labelMasukkanTlpn);
            this.Controls.Add(this.labelForgotPassword);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
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
        private System.Windows.Forms.Label labelError;
        private System.Windows.Forms.Button buttonBack;
    }
}