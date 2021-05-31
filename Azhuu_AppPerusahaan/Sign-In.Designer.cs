
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
            this.labelSalahEmail = new System.Windows.Forms.Label();
            this.labelHereRegister = new System.Windows.Forms.Label();
            this.labelDontHaveAcc = new System.Windows.Forms.Label();
            this.buttonBack = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tBoxEmail
            // 
            this.tBoxEmail.ForeColor = System.Drawing.Color.Gray;
            this.tBoxEmail.Location = new System.Drawing.Point(783, 230);
            this.tBoxEmail.Name = "tBoxEmail";
            this.tBoxEmail.Size = new System.Drawing.Size(375, 22);
            this.tBoxEmail.TabIndex = 3;
            this.tBoxEmail.Text = " Email";
            // 
            // tBoxPassword
            // 
            this.tBoxPassword.ForeColor = System.Drawing.Color.Gray;
            this.tBoxPassword.Location = new System.Drawing.Point(783, 275);
            this.tBoxPassword.Name = "tBoxPassword";
            this.tBoxPassword.Size = new System.Drawing.Size(375, 22);
            this.tBoxPassword.TabIndex = 6;
            this.tBoxPassword.Text = " Password";
            // 
            // buttonLogIn
            // 
            this.buttonLogIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLogIn.Location = new System.Drawing.Point(941, 399);
            this.buttonLogIn.Name = "buttonLogIn";
            this.buttonLogIn.Size = new System.Drawing.Size(217, 30);
            this.buttonLogIn.TabIndex = 9;
            this.buttonLogIn.Text = "Log-In";
            this.buttonLogIn.UseVisualStyleBackColor = true;
            this.buttonLogIn.Click += new System.EventHandler(this.buttonLogIn_Click);
            // 
            // buttonForgotPassword
            // 
            this.buttonForgotPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonForgotPassword.Location = new System.Drawing.Point(941, 440);
            this.buttonForgotPassword.Name = "buttonForgotPassword";
            this.buttonForgotPassword.Size = new System.Drawing.Size(217, 30);
            this.buttonForgotPassword.TabIndex = 10;
            this.buttonForgotPassword.Text = "Forgot Password ?";
            this.buttonForgotPassword.UseVisualStyleBackColor = true;
            this.buttonForgotPassword.Click += new System.EventHandler(this.buttonForgotPassword_Click);
            // 
            // labelSalahEmail
            // 
            this.labelSalahEmail.AutoSize = true;
            this.labelSalahEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSalahEmail.ForeColor = System.Drawing.Color.Red;
            this.labelSalahEmail.Location = new System.Drawing.Point(779, 321);
            this.labelSalahEmail.Name = "labelSalahEmail";
            this.labelSalahEmail.Size = new System.Drawing.Size(197, 20);
            this.labelSalahEmail.TabIndex = 21;
            this.labelSalahEmail.Text = "Email / Password Salah !";
            // 
            // labelHereRegister
            // 
            this.labelHereRegister.AutoSize = true;
            this.labelHereRegister.ForeColor = System.Drawing.Color.DarkOrange;
            this.labelHereRegister.Location = new System.Drawing.Point(209, 622);
            this.labelHereRegister.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelHereRegister.Name = "labelHereRegister";
            this.labelHereRegister.Size = new System.Drawing.Size(39, 17);
            this.labelHereRegister.TabIndex = 23;
            this.labelHereRegister.Text = "Here";
            this.labelHereRegister.Click += new System.EventHandler(this.labelHereRegister_Click);
            // 
            // labelDontHaveAcc
            // 
            this.labelDontHaveAcc.AutoSize = true;
            this.labelDontHaveAcc.Location = new System.Drawing.Point(13, 622);
            this.labelDontHaveAcc.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelDontHaveAcc.Name = "labelDontHaveAcc";
            this.labelDontHaveAcc.Size = new System.Drawing.Size(202, 17);
            this.labelDontHaveAcc.TabIndex = 22;
            this.labelDontHaveAcc.Text = "Don’t Have Account ? Register";
            // 
            // buttonBack
            // 
            this.buttonBack.Location = new System.Drawing.Point(13, 13);
            this.buttonBack.Margin = new System.Windows.Forms.Padding(4);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(39, 28);
            this.buttonBack.TabIndex = 39;
            this.buttonBack.Text = "<";
            this.buttonBack.UseVisualStyleBackColor = true;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // FormSignIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1262, 673);
            this.Controls.Add(this.buttonBack);
            this.Controls.Add(this.labelHereRegister);
            this.Controls.Add(this.labelDontHaveAcc);
            this.Controls.Add(this.labelSalahEmail);
            this.Controls.Add(this.buttonForgotPassword);
            this.Controls.Add(this.buttonLogIn);
            this.Controls.Add(this.tBoxPassword);
            this.Controls.Add(this.tBoxEmail);
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
        private System.Windows.Forms.Label labelSalahEmail;
        private System.Windows.Forms.Label labelHereRegister;
        private System.Windows.Forms.Label labelDontHaveAcc;
        private System.Windows.Forms.Button buttonBack;
    }
}