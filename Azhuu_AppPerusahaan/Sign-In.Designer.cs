
namespace Azhuu_AppPerusahaan
{
    partial class FormSignIn
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
            this.tBoxEmail = new System.Windows.Forms.TextBox();
            this.tBoxPassword = new System.Windows.Forms.TextBox();
            this.buttonLogIn = new System.Windows.Forms.Button();
            this.buttonForgotPassword = new System.Windows.Forms.Button();
            this.labelError = new System.Windows.Forms.Label();
            this.labelHereRegister = new System.Windows.Forms.Label();
            this.labelDontHaveAcc = new System.Windows.Forms.Label();
            this.buttonBack = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tBoxEmail
            // 
            this.tBoxEmail.ForeColor = System.Drawing.Color.Gray;
            this.tBoxEmail.Location = new System.Drawing.Point(872, 243);
            this.tBoxEmail.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tBoxEmail.Name = "tBoxEmail";
            this.tBoxEmail.Size = new System.Drawing.Size(282, 20);
            this.tBoxEmail.TabIndex = 3;
            this.tBoxEmail.Text = " Email";
            // 
            // tBoxPassword
            // 
            this.tBoxPassword.ForeColor = System.Drawing.Color.Gray;
            this.tBoxPassword.Location = new System.Drawing.Point(872, 279);
            this.tBoxPassword.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tBoxPassword.Name = "tBoxPassword";
            this.tBoxPassword.Size = new System.Drawing.Size(282, 20);
            this.tBoxPassword.TabIndex = 6;
            this.tBoxPassword.Text = " Password";
            // 
            // buttonLogIn
            // 
            this.buttonLogIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLogIn.Location = new System.Drawing.Point(991, 380);
            this.buttonLogIn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonLogIn.Name = "buttonLogIn";
            this.buttonLogIn.Size = new System.Drawing.Size(163, 24);
            this.buttonLogIn.TabIndex = 9;
            this.buttonLogIn.Text = "Log-In";
            this.buttonLogIn.UseVisualStyleBackColor = true;
            this.buttonLogIn.Click += new System.EventHandler(this.buttonLogIn_Click);
            // 
            // buttonForgotPassword
            // 
            this.buttonForgotPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonForgotPassword.Location = new System.Drawing.Point(991, 414);
            this.buttonForgotPassword.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonForgotPassword.Name = "buttonForgotPassword";
            this.buttonForgotPassword.Size = new System.Drawing.Size(163, 24);
            this.buttonForgotPassword.TabIndex = 10;
            this.buttonForgotPassword.Text = "Forgot Password ?";
            this.buttonForgotPassword.UseVisualStyleBackColor = true;
            this.buttonForgotPassword.Click += new System.EventHandler(this.buttonForgotPassword_Click);
            // 
            // labelError
            // 
            this.labelError.AutoSize = true;
            this.labelError.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelError.ForeColor = System.Drawing.Color.Red;
            this.labelError.Location = new System.Drawing.Point(869, 317);
            this.labelError.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelError.Name = "labelError";
            this.labelError.Size = new System.Drawing.Size(13, 17);
            this.labelError.TabIndex = 21;
            this.labelError.Text = "-";
            // 
            // labelHereRegister
            // 
            this.labelHereRegister.AutoSize = true;
            this.labelHereRegister.ForeColor = System.Drawing.Color.DarkOrange;
            this.labelHereRegister.Location = new System.Drawing.Point(167, 645);
            this.labelHereRegister.Name = "labelHereRegister";
            this.labelHereRegister.Size = new System.Drawing.Size(30, 13);
            this.labelHereRegister.TabIndex = 23;
            this.labelHereRegister.Text = "Here";
            this.labelHereRegister.Click += new System.EventHandler(this.labelHereRegister_Click);
            // 
            // labelDontHaveAcc
            // 
            this.labelDontHaveAcc.AutoSize = true;
            this.labelDontHaveAcc.Location = new System.Drawing.Point(14, 645);
            this.labelDontHaveAcc.Name = "labelDontHaveAcc";
            this.labelDontHaveAcc.Size = new System.Drawing.Size(156, 13);
            this.labelDontHaveAcc.TabIndex = 22;
            this.labelDontHaveAcc.Text = "Don’t Have Account ? Register";
            // 
            // buttonBack
            // 
            this.buttonBack.Location = new System.Drawing.Point(10, 11);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(29, 23);
            this.buttonBack.TabIndex = 39;
            this.buttonBack.Text = "<";
            this.buttonBack.UseVisualStyleBackColor = true;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // FormSignIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.buttonBack);
            this.Controls.Add(this.labelHereRegister);
            this.Controls.Add(this.labelDontHaveAcc);
            this.Controls.Add(this.labelError);
            this.Controls.Add(this.buttonForgotPassword);
            this.Controls.Add(this.buttonLogIn);
            this.Controls.Add(this.tBoxPassword);
            this.Controls.Add(this.tBoxEmail);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FormSignIn";
            this.Text = "Sign-In";
            this.Load += new System.EventHandler(this.FormSignIn_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tBoxEmail;
        private System.Windows.Forms.TextBox tBoxPassword;
        private System.Windows.Forms.Button buttonLogIn;
        private System.Windows.Forms.Button buttonForgotPassword;
        private System.Windows.Forms.Label labelError;
        private System.Windows.Forms.Label labelHereRegister;
        private System.Windows.Forms.Label labelDontHaveAcc;
        private System.Windows.Forms.Button buttonBack;
    }
}