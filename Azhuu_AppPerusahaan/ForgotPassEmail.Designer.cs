
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
            this.SuspendLayout();
            // 
            // butttonContinue
            // 
            this.butttonContinue.Location = new System.Drawing.Point(534, 426);
            this.butttonContinue.Name = "butttonContinue";
            this.butttonContinue.Size = new System.Drawing.Size(182, 23);
            this.butttonContinue.TabIndex = 29;
            this.butttonContinue.Text = "CONTINUE";
            this.butttonContinue.UseVisualStyleBackColor = true;
            this.butttonContinue.Click += new System.EventHandler(this.butttonContinue_Click);
            // 
            // tBoxEmail
            // 
            this.tBoxEmail.Location = new System.Drawing.Point(426, 360);
            this.tBoxEmail.Name = "tBoxEmail";
            this.tBoxEmail.Size = new System.Drawing.Size(392, 20);
            this.tBoxEmail.TabIndex = 28;
            // 
            // labelMasukkanEmail
            // 
            this.labelMasukkanEmail.AutoSize = true;
            this.labelMasukkanEmail.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMasukkanEmail.Location = new System.Drawing.Point(550, 333);
            this.labelMasukkanEmail.Name = "labelMasukkanEmail";
            this.labelMasukkanEmail.Size = new System.Drawing.Size(155, 23);
            this.labelMasukkanEmail.TabIndex = 27;
            this.labelMasukkanEmail.Text = "MASUKKAN EMAIL";
            // 
            // labelForgotPassword
            // 
            this.labelForgotPassword.AutoSize = true;
            this.labelForgotPassword.Font = new System.Drawing.Font("Copperplate Gothic Bold", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelForgotPassword.Location = new System.Drawing.Point(419, 244);
            this.labelForgotPassword.Name = "labelForgotPassword";
            this.labelForgotPassword.Size = new System.Drawing.Size(427, 44);
            this.labelForgotPassword.TabIndex = 26;
            this.labelForgotPassword.Text = "Forgot Password";
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
            // FormForgotPassEmail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.buttonBack);
            this.Controls.Add(this.butttonContinue);
            this.Controls.Add(this.tBoxEmail);
            this.Controls.Add(this.labelMasukkanEmail);
            this.Controls.Add(this.labelForgotPassword);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FormForgotPassEmail";
            this.Text = "Forgot Password Email";
            this.Load += new System.EventHandler(this.FormForgotPassEmail_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button butttonContinue;
        private System.Windows.Forms.TextBox tBoxEmail;
        private System.Windows.Forms.Label labelMasukkanEmail;
        private System.Windows.Forms.Label labelForgotPassword;
        private System.Windows.Forms.Button buttonBack;
    }
}