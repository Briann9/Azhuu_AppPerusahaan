namespace Azhuu_AppPerusahaan
{
    partial class LandingPage
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
            this.butVehicle = new System.Windows.Forms.Button();
            this.butRute = new System.Windows.Forms.Button();
            this.butUpcoming = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tBoxAlamat = new System.Windows.Forms.TextBox();
            this.tBoxNomorTlpn = new System.Windows.Forms.TextBox();
            this.tBoxEmail = new System.Windows.Forms.TextBox();
            this.tBoxNama = new System.Windows.Forms.TextBox();
            this.tBoxID = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.butDelete = new System.Windows.Forms.Button();
            this.butSave = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // butVehicle
            // 
            this.butVehicle.BackColor = System.Drawing.Color.White;
            this.butVehicle.Location = new System.Drawing.Point(122, 307);
            this.butVehicle.Margin = new System.Windows.Forms.Padding(4);
            this.butVehicle.Name = "butVehicle";
            this.butVehicle.Size = new System.Drawing.Size(217, 56);
            this.butVehicle.TabIndex = 0;
            this.butVehicle.Text = "Vehicle List";
            this.butVehicle.UseVisualStyleBackColor = false;
            this.butVehicle.Click += new System.EventHandler(this.butVehicle_Click);
            // 
            // butRute
            // 
            this.butRute.BackColor = System.Drawing.Color.White;
            this.butRute.Location = new System.Drawing.Point(122, 415);
            this.butRute.Margin = new System.Windows.Forms.Padding(4);
            this.butRute.Name = "butRute";
            this.butRute.Size = new System.Drawing.Size(217, 56);
            this.butRute.TabIndex = 1;
            this.butRute.Text = "Rute List";
            this.butRute.UseVisualStyleBackColor = false;
            // 
            // butUpcoming
            // 
            this.butUpcoming.BackColor = System.Drawing.Color.White;
            this.butUpcoming.Location = new System.Drawing.Point(122, 540);
            this.butUpcoming.Margin = new System.Windows.Forms.Padding(4);
            this.butUpcoming.Name = "butUpcoming";
            this.butUpcoming.Size = new System.Drawing.Size(217, 56);
            this.butUpcoming.TabIndex = 2;
            this.butUpcoming.Text = "Upcoming Trip";
            this.butUpcoming.UseVisualStyleBackColor = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(485, 434);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 17);
            this.label5.TabIndex = 55;
            this.label5.Text = "Address : ";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(485, 370);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 17);
            this.label4.TabIndex = 54;
            this.label4.Text = "Telp :";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(485, 308);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 17);
            this.label3.TabIndex = 53;
            this.label3.Text = "Email";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(485, 251);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 17);
            this.label2.TabIndex = 52;
            this.label2.Text = "PO BUS Name : ";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(486, 182);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 17);
            this.label1.TabIndex = 51;
            this.label1.Text = "PO BUS ID :";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // tBoxAlamat
            // 
            this.tBoxAlamat.ForeColor = System.Drawing.Color.Black;
            this.tBoxAlamat.Location = new System.Drawing.Point(489, 452);
            this.tBoxAlamat.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tBoxAlamat.Name = "tBoxAlamat";
            this.tBoxAlamat.Size = new System.Drawing.Size(394, 22);
            this.tBoxAlamat.TabIndex = 50;
            this.tBoxAlamat.TextChanged += new System.EventHandler(this.tBoxAlamat_TextChanged);
            // 
            // tBoxNomorTlpn
            // 
            this.tBoxNomorTlpn.ForeColor = System.Drawing.Color.Black;
            this.tBoxNomorTlpn.Location = new System.Drawing.Point(489, 388);
            this.tBoxNomorTlpn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tBoxNomorTlpn.Name = "tBoxNomorTlpn";
            this.tBoxNomorTlpn.Size = new System.Drawing.Size(394, 22);
            this.tBoxNomorTlpn.TabIndex = 49;
            this.tBoxNomorTlpn.TextChanged += new System.EventHandler(this.tBoxNomorTlpn_TextChanged);
            // 
            // tBoxEmail
            // 
            this.tBoxEmail.ForeColor = System.Drawing.Color.Black;
            this.tBoxEmail.Location = new System.Drawing.Point(489, 327);
            this.tBoxEmail.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tBoxEmail.Name = "tBoxEmail";
            this.tBoxEmail.Size = new System.Drawing.Size(394, 22);
            this.tBoxEmail.TabIndex = 48;
            this.tBoxEmail.TextChanged += new System.EventHandler(this.tBoxEmail_TextChanged);
            // 
            // tBoxNama
            // 
            this.tBoxNama.ForeColor = System.Drawing.Color.Black;
            this.tBoxNama.Location = new System.Drawing.Point(489, 269);
            this.tBoxNama.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tBoxNama.Name = "tBoxNama";
            this.tBoxNama.Size = new System.Drawing.Size(394, 22);
            this.tBoxNama.TabIndex = 47;
            this.tBoxNama.TextChanged += new System.EventHandler(this.tBoxNama_TextChanged);
            // 
            // tBoxID
            // 
            this.tBoxID.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.tBoxID.Enabled = false;
            this.tBoxID.ForeColor = System.Drawing.Color.Black;
            this.tBoxID.Location = new System.Drawing.Point(488, 212);
            this.tBoxID.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tBoxID.Name = "tBoxID";
            this.tBoxID.Size = new System.Drawing.Size(168, 22);
            this.tBoxID.TabIndex = 46;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.White;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(117, 238);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(222, 29);
            this.label6.TabIndex = 56;
            this.label6.Text = "Welcome, Harjayy";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // butDelete
            // 
            this.butDelete.BackColor = System.Drawing.Color.White;
            this.butDelete.Location = new System.Drawing.Point(524, 613);
            this.butDelete.Margin = new System.Windows.Forms.Padding(4);
            this.butDelete.Name = "butDelete";
            this.butDelete.Size = new System.Drawing.Size(305, 54);
            this.butDelete.TabIndex = 57;
            this.butDelete.Text = "Delete Account";
            this.butDelete.UseVisualStyleBackColor = false;
            this.butDelete.Click += new System.EventHandler(this.butDelete_Click);
            // 
            // butSave
            // 
            this.butSave.BackColor = System.Drawing.Color.White;
            this.butSave.Enabled = false;
            this.butSave.Location = new System.Drawing.Point(525, 523);
            this.butSave.Margin = new System.Windows.Forms.Padding(4);
            this.butSave.Name = "butSave";
            this.butSave.Size = new System.Drawing.Size(305, 53);
            this.butSave.TabIndex = 58;
            this.butSave.Text = "Save Change";
            this.butSave.UseVisualStyleBackColor = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Azhuu_AppPerusahaan.Properties.Resources._3423432;
            this.pictureBox1.Location = new System.Drawing.Point(-5, -4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1694, 846);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 59;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // LandingPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1685, 838);
            this.Controls.Add(this.butSave);
            this.Controls.Add(this.butDelete);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tBoxAlamat);
            this.Controls.Add(this.tBoxNomorTlpn);
            this.Controls.Add(this.tBoxEmail);
            this.Controls.Add(this.tBoxNama);
            this.Controls.Add(this.tBoxID);
            this.Controls.Add(this.butUpcoming);
            this.Controls.Add(this.butRute);
            this.Controls.Add(this.butVehicle);
            this.Controls.Add(this.pictureBox1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "LandingPage";
            this.Text = "LandingPage";
            this.Load += new System.EventHandler(this.LandingPage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button butVehicle;
        private System.Windows.Forms.Button butRute;
        private System.Windows.Forms.Button butUpcoming;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tBoxAlamat;
        private System.Windows.Forms.TextBox tBoxNomorTlpn;
        private System.Windows.Forms.TextBox tBoxEmail;
        private System.Windows.Forms.TextBox tBoxNama;
        private System.Windows.Forms.TextBox tBoxID;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button butDelete;
        private System.Windows.Forms.Button butSave;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}