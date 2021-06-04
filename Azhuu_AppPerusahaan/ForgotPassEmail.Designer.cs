
namespace Azhuu_AppPerusahaan
{
    partial class FormForgotPassEmail
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
            this.butttonContinue = new System.Windows.Forms.Button();
            this.tBoxEmail = new System.Windows.Forms.TextBox();
            this.labelMasukkanEmail = new System.Windows.Forms.Label();
            this.labelForgotPassword = new System.Windows.Forms.Label();
            this.buttonBack = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // butttonContinue
            // 
            this.butttonContinue.Location = new System.Drawing.Point(721, 679);
            this.butttonContinue.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.butttonContinue.Name = "butttonContinue";
            this.butttonContinue.Size = new System.Drawing.Size(243, 28);
            this.butttonContinue.TabIndex = 29;
            this.butttonContinue.Text = "CONTINUE";
            this.butttonContinue.UseVisualStyleBackColor = true;
            this.butttonContinue.Click += new System.EventHandler(this.butttonContinue_Click);
            // 
            // tBoxEmail
            // 
            this.tBoxEmail.Location = new System.Drawing.Point(577, 598);
            this.tBoxEmail.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tBoxEmail.Name = "tBoxEmail";
            this.tBoxEmail.Size = new System.Drawing.Size(521, 22);
            this.tBoxEmail.TabIndex = 28;
            // 
            // labelMasukkanEmail
            // 
            this.labelMasukkanEmail.AutoSize = true;
            this.labelMasukkanEmail.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMasukkanEmail.Location = new System.Drawing.Point(742, 565);
            this.labelMasukkanEmail.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelMasukkanEmail.Name = "labelMasukkanEmail";
            this.labelMasukkanEmail.Size = new System.Drawing.Size(196, 29);
            this.labelMasukkanEmail.TabIndex = 27;
            this.labelMasukkanEmail.Text = "MASUKKAN EMAIL";
            // 
            // labelForgotPassword
            // 
            this.labelForgotPassword.AutoSize = true;
            this.labelForgotPassword.Font = new System.Drawing.Font("Copperplate Gothic Bold", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelForgotPassword.Location = new System.Drawing.Point(568, 455);
            this.labelForgotPassword.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelForgotPassword.Name = "labelForgotPassword";
            this.labelForgotPassword.Size = new System.Drawing.Size(531, 55);
            this.labelForgotPassword.TabIndex = 26;
            this.labelForgotPassword.Text = "Forgot Password";
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
            this.pictureBox1.Image = global::Azhuu_AppPerusahaan.Properties.Resources.forgot_password;
            this.pictureBox1.Location = new System.Drawing.Point(-4, -8);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1694, 846);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 41;
            this.pictureBox1.TabStop = false;
            // 
            // FormForgotPassEmail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1685, 838);
            this.Controls.Add(this.buttonBack);
            this.Controls.Add(this.butttonContinue);
            this.Controls.Add(this.tBoxEmail);
            this.Controls.Add(this.labelMasukkanEmail);
            this.Controls.Add(this.labelForgotPassword);
            this.Controls.Add(this.pictureBox1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FormForgotPassEmail";
            this.Text = "Forgot Password Email";
            this.Load += new System.EventHandler(this.FormForgotPassEmail_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button butttonContinue;
        private System.Windows.Forms.TextBox tBoxEmail;
        private System.Windows.Forms.Label labelMasukkanEmail;
        private System.Windows.Forms.Label labelForgotPassword;
        private System.Windows.Forms.Button buttonBack;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}