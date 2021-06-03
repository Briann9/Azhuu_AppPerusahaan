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
            this.SuspendLayout();
            // 
            // butVehicle
            // 
            this.butVehicle.Location = new System.Drawing.Point(86, 161);
            this.butVehicle.Name = "butVehicle";
            this.butVehicle.Size = new System.Drawing.Size(90, 23);
            this.butVehicle.TabIndex = 0;
            this.butVehicle.Text = "Vehicle List";
            this.butVehicle.UseVisualStyleBackColor = true;
            this.butVehicle.Click += new System.EventHandler(this.butVehicle_Click);
            // 
            // butRute
            // 
            this.butRute.Location = new System.Drawing.Point(86, 274);
            this.butRute.Name = "butRute";
            this.butRute.Size = new System.Drawing.Size(90, 23);
            this.butRute.TabIndex = 1;
            this.butRute.Text = "Rute List";
            this.butRute.UseVisualStyleBackColor = true;
            this.butRute.Click += new System.EventHandler(this.butRute_Click);
            // 
            // butUpcoming
            // 
            this.butUpcoming.Location = new System.Drawing.Point(86, 402);
            this.butUpcoming.Name = "butUpcoming";
            this.butUpcoming.Size = new System.Drawing.Size(90, 23);
            this.butUpcoming.TabIndex = 2;
            this.butUpcoming.Text = "Upcoming Trip";
            this.butUpcoming.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(899, 351);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 13);
            this.label5.TabIndex = 55;
            this.label5.Text = "Address : ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(899, 299);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 13);
            this.label4.TabIndex = 54;
            this.label4.Text = "Telp :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(899, 249);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 53;
            this.label3.Text = "Email";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(899, 202);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 13);
            this.label2.TabIndex = 52;
            this.label2.Text = "PO BUS Name : ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1054, 161);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 51;
            this.label1.Text = "PO BUS ID :";
            // 
            // tBoxAlamat
            // 
            this.tBoxAlamat.ForeColor = System.Drawing.Color.Black;
            this.tBoxAlamat.Location = new System.Drawing.Point(902, 366);
            this.tBoxAlamat.Margin = new System.Windows.Forms.Padding(2);
            this.tBoxAlamat.Name = "tBoxAlamat";
            this.tBoxAlamat.Size = new System.Drawing.Size(282, 20);
            this.tBoxAlamat.TabIndex = 50;
            this.tBoxAlamat.TextChanged += new System.EventHandler(this.tBoxAlamat_TextChanged);
            // 
            // tBoxNomorTlpn
            // 
            this.tBoxNomorTlpn.ForeColor = System.Drawing.Color.Black;
            this.tBoxNomorTlpn.Location = new System.Drawing.Point(902, 314);
            this.tBoxNomorTlpn.Margin = new System.Windows.Forms.Padding(2);
            this.tBoxNomorTlpn.Name = "tBoxNomorTlpn";
            this.tBoxNomorTlpn.Size = new System.Drawing.Size(282, 20);
            this.tBoxNomorTlpn.TabIndex = 49;
            this.tBoxNomorTlpn.TextChanged += new System.EventHandler(this.tBoxNomorTlpn_TextChanged);
            // 
            // tBoxEmail
            // 
            this.tBoxEmail.ForeColor = System.Drawing.Color.Black;
            this.tBoxEmail.Location = new System.Drawing.Point(902, 264);
            this.tBoxEmail.Margin = new System.Windows.Forms.Padding(2);
            this.tBoxEmail.Name = "tBoxEmail";
            this.tBoxEmail.Size = new System.Drawing.Size(282, 20);
            this.tBoxEmail.TabIndex = 48;
            this.tBoxEmail.TextChanged += new System.EventHandler(this.tBoxEmail_TextChanged);
            // 
            // tBoxNama
            // 
            this.tBoxNama.ForeColor = System.Drawing.Color.Black;
            this.tBoxNama.Location = new System.Drawing.Point(902, 217);
            this.tBoxNama.Margin = new System.Windows.Forms.Padding(2);
            this.tBoxNama.Name = "tBoxNama";
            this.tBoxNama.Size = new System.Drawing.Size(282, 20);
            this.tBoxNama.TabIndex = 47;
            this.tBoxNama.TextChanged += new System.EventHandler(this.tBoxNama_TextChanged);
            // 
            // tBoxID
            // 
            this.tBoxID.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.tBoxID.Enabled = false;
            this.tBoxID.ForeColor = System.Drawing.Color.Black;
            this.tBoxID.Location = new System.Drawing.Point(1057, 176);
            this.tBoxID.Margin = new System.Windows.Forms.Padding(2);
            this.tBoxID.Name = "tBoxID";
            this.tBoxID.Size = new System.Drawing.Size(127, 20);
            this.tBoxID.TabIndex = 46;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(83, 84);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(93, 13);
            this.label6.TabIndex = 56;
            this.label6.Text = "Welcome, Harjayy";
            // 
            // butDelete
            // 
            this.butDelete.Location = new System.Drawing.Point(902, 496);
            this.butDelete.Name = "butDelete";
            this.butDelete.Size = new System.Drawing.Size(113, 23);
            this.butDelete.TabIndex = 57;
            this.butDelete.Text = "Delete Account";
            this.butDelete.UseVisualStyleBackColor = true;
            this.butDelete.Click += new System.EventHandler(this.butDelete_Click);
            // 
            // butSave
            // 
            this.butSave.Enabled = false;
            this.butSave.Location = new System.Drawing.Point(1071, 496);
            this.butSave.Name = "butSave";
            this.butSave.Size = new System.Drawing.Size(113, 23);
            this.butSave.TabIndex = 58;
            this.butSave.Text = "Save Change";
            this.butSave.UseVisualStyleBackColor = true;
            // 
            // LandingPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 681);
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
            this.Name = "LandingPage";
            this.Text = "LandingPage";
            this.Load += new System.EventHandler(this.LandingPage_Load);
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
    }
}