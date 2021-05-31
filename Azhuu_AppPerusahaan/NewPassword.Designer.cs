
namespace Azhuu_AppPerusahaan
{
    partial class FormNewPassword
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
            this.labelNewPassword = new System.Windows.Forms.Label();
            this.labelPassword = new System.Windows.Forms.Label();
            this.tBoxPassword = new System.Windows.Forms.TextBox();
            this.buttonContinue = new System.Windows.Forms.Button();
            this.tBoxConfirmPassword = new System.Windows.Forms.TextBox();
            this.labelConfirmPassword = new System.Windows.Forms.Label();
            this.buttonBack = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelNewPassword
            // 
            this.labelNewPassword.AutoSize = true;
            this.labelNewPassword.Font = new System.Drawing.Font("Copperplate Gothic Bold", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNewPassword.Location = new System.Drawing.Point(392, 176);
            this.labelNewPassword.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelNewPassword.Name = "labelNewPassword";
            this.labelNewPassword.Size = new System.Drawing.Size(449, 55);
            this.labelNewPassword.TabIndex = 42;
            this.labelNewPassword.Text = "New Password";
            // 
            // labelPassword
            // 
            this.labelPassword.AutoSize = true;
            this.labelPassword.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPassword.Location = new System.Drawing.Point(361, 285);
            this.labelPassword.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelPassword.Name = "labelPassword";
            this.labelPassword.Size = new System.Drawing.Size(166, 29);
            this.labelPassword.TabIndex = 43;
            this.labelPassword.Text = "New Password :";
            // 
            // tBoxPassword
            // 
            this.tBoxPassword.Location = new System.Drawing.Point(367, 317);
            this.tBoxPassword.Margin = new System.Windows.Forms.Padding(4);
            this.tBoxPassword.Name = "tBoxPassword";
            this.tBoxPassword.Size = new System.Drawing.Size(521, 22);
            this.tBoxPassword.TabIndex = 44;
            // 
            // buttonContinue
            // 
            this.buttonContinue.Location = new System.Drawing.Point(532, 477);
            this.buttonContinue.Margin = new System.Windows.Forms.Padding(4);
            this.buttonContinue.Name = "buttonContinue";
            this.buttonContinue.Size = new System.Drawing.Size(242, 28);
            this.buttonContinue.TabIndex = 45;
            this.buttonContinue.Text = "CONTINUE";
            this.buttonContinue.UseVisualStyleBackColor = true;
            // 
            // tBoxConfirmPassword
            // 
            this.tBoxConfirmPassword.Location = new System.Drawing.Point(367, 377);
            this.tBoxConfirmPassword.Margin = new System.Windows.Forms.Padding(4);
            this.tBoxConfirmPassword.Name = "tBoxConfirmPassword";
            this.tBoxConfirmPassword.Size = new System.Drawing.Size(521, 22);
            this.tBoxConfirmPassword.TabIndex = 48;
            // 
            // labelConfirmPassword
            // 
            this.labelConfirmPassword.AutoSize = true;
            this.labelConfirmPassword.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelConfirmPassword.Location = new System.Drawing.Point(361, 345);
            this.labelConfirmPassword.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelConfirmPassword.Name = "labelConfirmPassword";
            this.labelConfirmPassword.Size = new System.Drawing.Size(250, 29);
            this.labelConfirmPassword.TabIndex = 47;
            this.labelConfirmPassword.Text = "Confirm New Password :";
            // 
            // buttonBack
            // 
            this.buttonBack.Location = new System.Drawing.Point(13, 13);
            this.buttonBack.Margin = new System.Windows.Forms.Padding(4);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(39, 28);
            this.buttonBack.TabIndex = 49;
            this.buttonBack.Text = "<";
            this.buttonBack.UseVisualStyleBackColor = true;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // FormNewPassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1262, 673);
            this.Controls.Add(this.buttonBack);
            this.Controls.Add(this.tBoxConfirmPassword);
            this.Controls.Add(this.labelConfirmPassword);
            this.Controls.Add(this.buttonContinue);
            this.Controls.Add(this.tBoxPassword);
            this.Controls.Add(this.labelPassword);
            this.Controls.Add(this.labelNewPassword);
            this.Name = "FormNewPassword";
            this.Text = "New Password";
            this.Load += new System.EventHandler(this.FormNewPassword_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelNewPassword;
        private System.Windows.Forms.Label labelPassword;
        private System.Windows.Forms.TextBox tBoxPassword;
        private System.Windows.Forms.Button buttonContinue;
        private System.Windows.Forms.TextBox tBoxConfirmPassword;
        private System.Windows.Forms.Label labelConfirmPassword;
        private System.Windows.Forms.Button buttonBack;
    }
}