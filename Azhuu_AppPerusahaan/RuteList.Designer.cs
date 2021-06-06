namespace Azhuu_AppPerusahaan
{
    partial class RuteList
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
            this.dgvRute = new System.Windows.Forms.DataGridView();
            this.tboxIDRute = new System.Windows.Forms.TextBox();
            this.rbutDari = new System.Windows.Forms.RadioButton();
            this.rbutKe = new System.Windows.Forms.RadioButton();
            this.tboxDestination = new System.Windows.Forms.TextBox();
            this.cboxBandara = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.labKeDari = new System.Windows.Forms.Label();
            this.cboxKendaraan = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tboxPrice = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.butBack = new System.Windows.Forms.Button();
            this.labError = new System.Windows.Forms.Label();
            this.butDelete = new System.Windows.Forms.Button();
            this.butInsert = new System.Windows.Forms.Button();
            this.cboxJam = new System.Windows.Forms.ComboBox();
            this.cboxMenit = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRute)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvRute
            // 
            this.dgvRute.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRute.Location = new System.Drawing.Point(70, 130);
            this.dgvRute.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvRute.Name = "dgvRute";
            this.dgvRute.RowHeadersWidth = 51;
            this.dgvRute.Size = new System.Drawing.Size(1060, 664);
            this.dgvRute.TabIndex = 0;
            this.dgvRute.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvRute_CellClick);
            // 
            // tboxIDRute
            // 
            this.tboxIDRute.Enabled = false;
            this.tboxIDRute.Location = new System.Drawing.Point(1214, 129);
            this.tboxIDRute.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tboxIDRute.Name = "tboxIDRute";
            this.tboxIDRute.Size = new System.Drawing.Size(192, 22);
            this.tboxIDRute.TabIndex = 1;
            // 
            // rbutDari
            // 
            this.rbutDari.AutoSize = true;
            this.rbutDari.Location = new System.Drawing.Point(1214, 185);
            this.rbutDari.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rbutDari.Name = "rbutDari";
            this.rbutDari.Size = new System.Drawing.Size(55, 21);
            this.rbutDari.TabIndex = 2;
            this.rbutDari.TabStop = true;
            this.rbutDari.Text = "Dari";
            this.rbutDari.UseVisualStyleBackColor = true;
            this.rbutDari.CheckedChanged += new System.EventHandler(this.rbutDari_CheckedChanged);
            // 
            // rbutKe
            // 
            this.rbutKe.AutoSize = true;
            this.rbutKe.Location = new System.Drawing.Point(1357, 185);
            this.rbutKe.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rbutKe.Name = "rbutKe";
            this.rbutKe.Size = new System.Drawing.Size(46, 21);
            this.rbutKe.TabIndex = 3;
            this.rbutKe.TabStop = true;
            this.rbutKe.Text = "Ke";
            this.rbutKe.UseVisualStyleBackColor = true;
            this.rbutKe.CheckedChanged += new System.EventHandler(this.rbutKe_CheckedChanged);
            // 
            // tboxDestination
            // 
            this.tboxDestination.Location = new System.Drawing.Point(1214, 320);
            this.tboxDestination.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tboxDestination.Name = "tboxDestination";
            this.tboxDestination.Size = new System.Drawing.Size(192, 22);
            this.tboxDestination.TabIndex = 4;
            this.tboxDestination.TextChanged += new System.EventHandler(this.tboxDestination_TextChanged);
            // 
            // cboxBandara
            // 
            this.cboxBandara.FormattingEnabled = true;
            this.cboxBandara.Location = new System.Drawing.Point(1214, 245);
            this.cboxBandara.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cboxBandara.Name = "cboxBandara";
            this.cboxBandara.Size = new System.Drawing.Size(371, 24);
            this.cboxBandara.TabIndex = 5;
            this.cboxBandara.SelectedIndexChanged += new System.EventHandler(this.cboxBandara_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1504, 185);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 17);
            this.label1.TabIndex = 6;
            this.label1.Text = "Bandara";
            // 
            // labKeDari
            // 
            this.labKeDari.AutoSize = true;
            this.labKeDari.Location = new System.Drawing.Point(1210, 301);
            this.labKeDari.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labKeDari.Name = "labKeDari";
            this.labKeDari.Size = new System.Drawing.Size(25, 17);
            this.labKeDari.TabIndex = 7;
            this.labKeDari.Text = "Ke";
            // 
            // cboxKendaraan
            // 
            this.cboxKendaraan.FormattingEnabled = true;
            this.cboxKendaraan.Location = new System.Drawing.Point(1214, 504);
            this.cboxKendaraan.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cboxKendaraan.Name = "cboxKendaraan";
            this.cboxKendaraan.Size = new System.Drawing.Size(192, 24);
            this.cboxKendaraan.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(1214, 106);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 17);
            this.label2.TabIndex = 10;
            this.label2.Text = "ID Rute";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(1214, 225);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 17);
            this.label3.TabIndex = 11;
            this.label3.Text = "Bandara";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(1210, 371);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 17);
            this.label4.TabIndex = 12;
            this.label4.Text = "Time";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(1214, 484);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 17);
            this.label5.TabIndex = 13;
            this.label5.Text = "Kendaraan";
            // 
            // tboxPrice
            // 
            this.tboxPrice.Location = new System.Drawing.Point(1214, 662);
            this.tboxPrice.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tboxPrice.Name = "tboxPrice";
            this.tboxPrice.Size = new System.Drawing.Size(192, 22);
            this.tboxPrice.TabIndex = 14;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(1214, 643);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 17);
            this.label6.TabIndex = 15;
            this.label6.Text = "Harga";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(100, 98);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(87, 25);
            this.label7.TabIndex = 16;
            this.label7.Text = "Rute List";
            // 
            // butBack
            // 
            this.butBack.Location = new System.Drawing.Point(13, 13);
            this.butBack.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.butBack.Name = "butBack";
            this.butBack.Size = new System.Drawing.Size(61, 28);
            this.butBack.TabIndex = 17;
            this.butBack.Text = "<";
            this.butBack.UseVisualStyleBackColor = true;
            // 
            // labError
            // 
            this.labError.AutoSize = true;
            this.labError.Location = new System.Drawing.Point(1213, 712);
            this.labError.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labError.Name = "labError";
            this.labError.Size = new System.Drawing.Size(13, 17);
            this.labError.TabIndex = 20;
            this.labError.Text = "-";
            // 
            // butDelete
            // 
            this.butDelete.Enabled = false;
            this.butDelete.Location = new System.Drawing.Point(1393, 751);
            this.butDelete.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.butDelete.Name = "butDelete";
            this.butDelete.Size = new System.Drawing.Size(125, 28);
            this.butDelete.TabIndex = 19;
            this.butDelete.Text = "Delete Rute";
            this.butDelete.UseVisualStyleBackColor = true;
            this.butDelete.Click += new System.EventHandler(this.butDelete_Click);
            // 
            // butInsert
            // 
            this.butInsert.Location = new System.Drawing.Point(1217, 751);
            this.butInsert.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.butInsert.Name = "butInsert";
            this.butInsert.Size = new System.Drawing.Size(121, 28);
            this.butInsert.TabIndex = 18;
            this.butInsert.Text = "Insert Rute";
            this.butInsert.UseVisualStyleBackColor = true;
            this.butInsert.Click += new System.EventHandler(this.butInsert_Click);
            // 
            // cboxJam
            // 
            this.cboxJam.FormattingEnabled = true;
            this.cboxJam.Items.AddRange(new object[] {
            "01",
            "02",
            "03",
            "04",
            "05",
            "06",
            "07",
            "08",
            "09",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24"});
            this.cboxJam.Location = new System.Drawing.Point(1214, 422);
            this.cboxJam.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cboxJam.Name = "cboxJam";
            this.cboxJam.Size = new System.Drawing.Size(123, 24);
            this.cboxJam.TabIndex = 21;
            this.cboxJam.SelectedIndexChanged += new System.EventHandler(this.cboxJam_SelectedIndexChanged);
            // 
            // cboxMenit
            // 
            this.cboxMenit.FormattingEnabled = true;
            this.cboxMenit.Items.AddRange(new object[] {
            "00",
            "01",
            "02",
            "03",
            "04",
            "05",
            "06",
            "07",
            "08",
            "09",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28",
            "29",
            "30",
            "31",
            "32",
            "33",
            "34",
            "35",
            "36",
            "37",
            "38",
            "39",
            "40",
            "41",
            "42",
            "43",
            "44",
            "45",
            "46",
            "47",
            "48",
            "49",
            "50",
            "51",
            "52",
            "53",
            "54",
            "55",
            "56",
            "57",
            "58",
            "59"});
            this.cboxMenit.Location = new System.Drawing.Point(1412, 422);
            this.cboxMenit.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cboxMenit.Name = "cboxMenit";
            this.cboxMenit.Size = new System.Drawing.Size(123, 24);
            this.cboxMenit.TabIndex = 22;
            this.cboxMenit.SelectedIndexChanged += new System.EventHandler(this.cboxMenit_SelectedIndexChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(1214, 403);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(34, 17);
            this.label8.TabIndex = 23;
            this.label8.Text = "Jam";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(1408, 403);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(42, 17);
            this.label9.TabIndex = 24;
            this.label9.Text = "Menit";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Azhuu_AppPerusahaan.Properties.Resources._12143;
            this.pictureBox1.Location = new System.Drawing.Point(-2, -3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1689, 844);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 25;
            this.pictureBox1.TabStop = false;
            // 
            // RuteList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1685, 838);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.cboxMenit);
            this.Controls.Add(this.cboxJam);
            this.Controls.Add(this.labError);
            this.Controls.Add(this.butDelete);
            this.Controls.Add(this.butInsert);
            this.Controls.Add(this.butBack);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tboxPrice);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cboxKendaraan);
            this.Controls.Add(this.labKeDari);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cboxBandara);
            this.Controls.Add(this.tboxDestination);
            this.Controls.Add(this.rbutKe);
            this.Controls.Add(this.rbutDari);
            this.Controls.Add(this.tboxIDRute);
            this.Controls.Add(this.dgvRute);
            this.Controls.Add(this.pictureBox1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "RuteList";
            this.Text = "RuteList";
            this.Load += new System.EventHandler(this.RuteList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRute)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvRute;
        private System.Windows.Forms.TextBox tboxIDRute;
        private System.Windows.Forms.RadioButton rbutDari;
        private System.Windows.Forms.RadioButton rbutKe;
        private System.Windows.Forms.TextBox tboxDestination;
        private System.Windows.Forms.ComboBox cboxBandara;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labKeDari;
        private System.Windows.Forms.ComboBox cboxKendaraan;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tboxPrice;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button butBack;
        private System.Windows.Forms.Label labError;
        private System.Windows.Forms.Button butDelete;
        private System.Windows.Forms.Button butInsert;
        private System.Windows.Forms.ComboBox cboxJam;
        private System.Windows.Forms.ComboBox cboxMenit;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}