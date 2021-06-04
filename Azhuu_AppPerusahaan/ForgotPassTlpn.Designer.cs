
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonContinue
            // 
            this.buttonContinue.Location = new System.Drawing.Point(731, 663);
            this.buttonContinue.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonContinue.Name = "buttonContinue";
            this.buttonContinue.Size = new System.Drawing.Size(243, 28);
            this.buttonContinue.TabIndex = 35;
            this.buttonContinue.Text = "CONTINUE";
            this.buttonContinue.UseVisualStyleBackColor = true;
            this.buttonContinue.Click += new System.EventHandler(this.buttonContinue_Click);
            // 
            // tBoxNoTelp
            // 
            this.tBoxNoTelp.Location = new System.Drawing.Point(587, 582);
            this.tBoxNoTelp.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tBoxNoTelp.Name = "tBoxNoTelp";
            this.tBoxNoTelp.Size = new System.Drawing.Size(521, 22);
            this.tBoxNoTelp.TabIndex = 34;
            // 
            // labelMasukkanTlpn
            // 
            this.labelMasukkanTlpn.AutoSize = true;
            this.labelMasukkanTlpn.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMasukkanTlpn.Location = new System.Drawing.Point(753, 548);
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
            this.labelForgotPassword.Location = new System.Drawing.Point(590, 462);
            this.labelForgotPassword.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelForgotPassword.Name = "labelForgotPassword";
            this.labelForgotPassword.Size = new System.Drawing.Size(531, 55);
            this.labelForgotPassword.TabIndex = 32;
            this.labelForgotPassword.Text = "Forgot Password";
            // 
            // labelError
            // 
            this.labelError.AutoSize = true;
            this.labelError.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelError.ForeColor = System.Drawing.Color.Red;
            this.labelError.Location = new System.Drawing.Point(709, 542);
            this.labelError.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelError.Name = "labelError";
            this.labelError.Size = new System.Drawing.Size(16, 24);
            this.labelError.TabIndex = 36;
            this.labelError.Text = "-";
            // 
            // buttonBack
            // 
            this.buttonBack.Location = new System.Drawing.Point(13, 14);
            this.buttonBack.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(39, 28);
            this.buttonBack.TabIndex = 40;
            this.buttonBack.Text = "<";
            this.buttonBack.UseVisualStyleBackColor = true;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Azhuu_AppPerusahaan.Properties.Resources.phone_number;
            this.pictureBox1.Location = new System.Drawing.Point(-5, -4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1694, 846);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 42;
            this.pictureBox1.TabStop = false;
            // 
            // FormForgotPassTlpn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1685, 838);
            this.Controls.Add(this.buttonBack);
            this.Controls.Add(this.labelError);
            this.Controls.Add(this.buttonContinue);
            this.Controls.Add(this.tBoxNoTelp);
            this.Controls.Add(this.labelMasukkanTlpn);
            this.Controls.Add(this.labelForgotPassword);
            this.Controls.Add(this.pictureBox1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FormForgotPassTlpn";
            this.Text = "Forgot Password Telepon";
            this.Load += new System.EventHandler(this.FormForgotPassTlpn_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
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
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}