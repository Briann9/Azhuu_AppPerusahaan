
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
            this.labelError = new System.Windows.Forms.Label();
            this.buttonBack = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // tBoxID
            // 
            this.tBoxID.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.tBoxID.Enabled = false;
            this.tBoxID.ForeColor = System.Drawing.Color.Black;
            this.tBoxID.Location = new System.Drawing.Point(1139, 321);
            this.tBoxID.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tBoxID.Name = "tBoxID";
            this.tBoxID.Size = new System.Drawing.Size(168, 22);
            this.tBoxID.TabIndex = 0;
            // 
            // tBoxNama
            // 
            this.tBoxNama.ForeColor = System.Drawing.Color.Black;
            this.tBoxNama.Location = new System.Drawing.Point(1140, 372);
            this.tBoxNama.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tBoxNama.Name = "tBoxNama";
            this.tBoxNama.Size = new System.Drawing.Size(375, 22);
            this.tBoxNama.TabIndex = 1;
            this.tBoxNama.TextChanged += new System.EventHandler(this.tBoxNama_TextChanged);
            // 
            // tBoxEmail
            // 
            this.tBoxEmail.ForeColor = System.Drawing.Color.Black;
            this.tBoxEmail.Location = new System.Drawing.Point(1140, 430);
            this.tBoxEmail.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tBoxEmail.Name = "tBoxEmail";
            this.tBoxEmail.Size = new System.Drawing.Size(375, 22);
            this.tBoxEmail.TabIndex = 2;
            // 
            // tBoxNomorTlpn
            // 
            this.tBoxNomorTlpn.ForeColor = System.Drawing.Color.Black;
            this.tBoxNomorTlpn.Location = new System.Drawing.Point(1140, 492);
            this.tBoxNomorTlpn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tBoxNomorTlpn.Name = "tBoxNomorTlpn";
            this.tBoxNomorTlpn.Size = new System.Drawing.Size(375, 22);
            this.tBoxNomorTlpn.TabIndex = 3;
            this.tBoxNomorTlpn.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tBoxNomorTlpn_KeyPress);
            // 
            // tBoxAlamat
            // 
            this.tBoxAlamat.ForeColor = System.Drawing.Color.Black;
            this.tBoxAlamat.Location = new System.Drawing.Point(1140, 556);
            this.tBoxAlamat.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tBoxAlamat.Name = "tBoxAlamat";
            this.tBoxAlamat.Size = new System.Drawing.Size(375, 22);
            this.tBoxAlamat.TabIndex = 4;
            // 
            // tBoxPassword
            // 
            this.tBoxPassword.ForeColor = System.Drawing.Color.Black;
            this.tBoxPassword.Location = new System.Drawing.Point(1140, 617);
            this.tBoxPassword.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tBoxPassword.Name = "tBoxPassword";
            this.tBoxPassword.Size = new System.Drawing.Size(375, 22);
            this.tBoxPassword.TabIndex = 5;
            this.tBoxPassword.TextChanged += new System.EventHandler(this.tBoxPassword_TextChanged);
            // 
            // tBoxConfirmPassword
            // 
            this.tBoxConfirmPassword.ForeColor = System.Drawing.Color.Black;
            this.tBoxConfirmPassword.Location = new System.Drawing.Point(1140, 681);
            this.tBoxConfirmPassword.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tBoxConfirmPassword.Name = "tBoxConfirmPassword";
            this.tBoxConfirmPassword.Size = new System.Drawing.Size(375, 22);
            this.tBoxConfirmPassword.TabIndex = 6;
            this.tBoxConfirmPassword.TextChanged += new System.EventHandler(this.tBoxConfirmPassword_TextChanged);
            // 
            // buttonRegister
            // 
            this.buttonRegister.BackColor = System.Drawing.Color.White;
            this.buttonRegister.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRegister.Location = new System.Drawing.Point(1224, 738);
            this.buttonRegister.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonRegister.Name = "buttonRegister";
            this.buttonRegister.Size = new System.Drawing.Size(217, 32);
            this.buttonRegister.TabIndex = 8;
            this.buttonRegister.Text = "Register";
            this.buttonRegister.UseVisualStyleBackColor = false;
            this.buttonRegister.Click += new System.EventHandler(this.buttonRegister_Click);
            // 
            // labelAlreadyHaveAcc
            // 
            this.labelAlreadyHaveAcc.AutoSize = true;
            this.labelAlreadyHaveAcc.Location = new System.Drawing.Point(9, 798);
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
            this.labelHereSignIn.Location = new System.Drawing.Point(205, 798);
            this.labelHereSignIn.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelHereSignIn.Name = "labelHereSignIn";
            this.labelHereSignIn.Size = new System.Drawing.Size(39, 17);
            this.labelHereSignIn.TabIndex = 19;
            this.labelHereSignIn.Text = "Here";
            this.labelHereSignIn.Click += new System.EventHandler(this.labelHereSignIn_Click);
            // 
            // labelError
            // 
            this.labelError.AutoSize = true;
            this.labelError.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelError.ForeColor = System.Drawing.Color.Red;
            this.labelError.Location = new System.Drawing.Point(1146, 705);
            this.labelError.Name = "labelError";
            this.labelError.Size = new System.Drawing.Size(15, 20);
            this.labelError.TabIndex = 20;
            this.labelError.Text = "-";
            // 
            // buttonBack
            // 
            this.buttonBack.Location = new System.Drawing.Point(13, 14);
            this.buttonBack.Margin = new System.Windows.Forms.Padding(4);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(39, 28);
            this.buttonBack.TabIndex = 40;
            this.buttonBack.Text = "<";
            this.buttonBack.UseVisualStyleBackColor = true;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1137, 292);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 17);
            this.label1.TabIndex = 41;
            this.label1.Text = "PO BUS ID :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(1136, 354);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 17);
            this.label2.TabIndex = 42;
            this.label2.Text = "PO BUS Name : ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(1136, 412);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 17);
            this.label3.TabIndex = 43;
            this.label3.Text = "Email";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(1136, 473);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 17);
            this.label4.TabIndex = 44;
            this.label4.Text = "Telp :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(1136, 537);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 17);
            this.label5.TabIndex = 45;
            this.label5.Text = "Address : ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(1136, 599);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(77, 17);
            this.label6.TabIndex = 46;
            this.label6.Text = "Password :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(1136, 663);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(129, 17);
            this.label7.TabIndex = 47;
            this.label7.Text = "Confirm Password :";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Azhuu_AppPerusahaan.Properties.Resources._12QW;
            this.pictureBox1.Location = new System.Drawing.Point(-3, -8);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1694, 862);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 48;
            this.pictureBox1.TabStop = false;
            // 
            // FormRegister
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1685, 838);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonBack);
            this.Controls.Add(this.labelError);
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
            this.Controls.Add(this.pictureBox1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FormRegister";
            this.Text = "Register";
            this.Load += new System.EventHandler(this.FormRegister_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
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
        private System.Windows.Forms.Label labelError;
        private System.Windows.Forms.Button buttonBack;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}