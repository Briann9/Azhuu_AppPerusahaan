
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // tBoxEmail
            // 
            this.tBoxEmail.ForeColor = System.Drawing.Color.Black;
            this.tBoxEmail.Location = new System.Drawing.Point(1061, 465);
            this.tBoxEmail.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tBoxEmail.Name = "tBoxEmail";
            this.tBoxEmail.Size = new System.Drawing.Size(375, 22);
            this.tBoxEmail.TabIndex = 3;
            // 
            // tBoxPassword
            // 
            this.tBoxPassword.ForeColor = System.Drawing.Color.Black;
            this.tBoxPassword.Location = new System.Drawing.Point(1061, 527);
            this.tBoxPassword.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tBoxPassword.Name = "tBoxPassword";
            this.tBoxPassword.Size = new System.Drawing.Size(375, 22);
            this.tBoxPassword.TabIndex = 6;
            this.tBoxPassword.TextChanged += new System.EventHandler(this.tBoxPassword_TextChanged);
            // 
            // buttonLogIn
            // 
            this.buttonLogIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLogIn.Location = new System.Drawing.Point(1147, 588);
            this.buttonLogIn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
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
            this.buttonForgotPassword.Location = new System.Drawing.Point(1147, 639);
            this.buttonForgotPassword.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonForgotPassword.Name = "buttonForgotPassword";
            this.buttonForgotPassword.Size = new System.Drawing.Size(217, 30);
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
            this.labelError.Location = new System.Drawing.Point(1057, 562);
            this.labelError.Name = "labelError";
            this.labelError.Size = new System.Drawing.Size(15, 20);
            this.labelError.TabIndex = 21;
            this.labelError.Text = "-";
            // 
            // labelHereRegister
            // 
            this.labelHereRegister.AutoSize = true;
            this.labelHereRegister.ForeColor = System.Drawing.Color.DarkOrange;
            this.labelHereRegister.Location = new System.Drawing.Point(1172, 704);
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
            this.labelDontHaveAcc.Location = new System.Drawing.Point(973, 704);
            this.labelDontHaveAcc.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelDontHaveAcc.Name = "labelDontHaveAcc";
            this.labelDontHaveAcc.Size = new System.Drawing.Size(202, 17);
            this.labelDontHaveAcc.TabIndex = 22;
            this.labelDontHaveAcc.Text = "Don’t Have Account ? Register";
            // 
            // buttonBack
            // 
            this.buttonBack.Location = new System.Drawing.Point(13, 14);
            this.buttonBack.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(39, 28);
            this.buttonBack.TabIndex = 39;
            this.buttonBack.Text = "<";
            this.buttonBack.UseVisualStyleBackColor = true;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1057, 436);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 17);
            this.label1.TabIndex = 40;
            this.label1.Text = "Email :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(1057, 508);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 17);
            this.label2.TabIndex = 41;
            this.label2.Text = "Password :";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Azhuu_AppPerusahaan.Properties.Resources.Black_Glow_in_the_Dark_Party_Facebook_Event_Cover;
            this.pictureBox1.Location = new System.Drawing.Point(-6, -12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1694, 862);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 49;
            this.pictureBox1.TabStop = false;
            // 
            // FormSignIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1685, 838);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonBack);
            this.Controls.Add(this.labelHereRegister);
            this.Controls.Add(this.labelDontHaveAcc);
            this.Controls.Add(this.labelError);
            this.Controls.Add(this.buttonForgotPassword);
            this.Controls.Add(this.buttonLogIn);
            this.Controls.Add(this.tBoxPassword);
            this.Controls.Add(this.tBoxEmail);
            this.Controls.Add(this.pictureBox1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FormSignIn";
            this.Text = "Sign-In";
            this.Load += new System.EventHandler(this.FormSignIn_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
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
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}