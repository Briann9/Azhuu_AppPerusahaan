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
            this.dTimeBerangkat = new System.Windows.Forms.DateTimePicker();
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
            ((System.ComponentModel.ISupportInitialize)(this.dgvRute)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvRute
            // 
            this.dgvRute.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRute.Location = new System.Drawing.Point(53, 102);
            this.dgvRute.Name = "dgvRute";
            this.dgvRute.Size = new System.Drawing.Size(373, 547);
            this.dgvRute.TabIndex = 0;
            // 
            // tboxIDRute
            // 
            this.tboxIDRute.Enabled = false;
            this.tboxIDRute.Location = new System.Drawing.Point(521, 102);
            this.tboxIDRute.Name = "tboxIDRute";
            this.tboxIDRute.Size = new System.Drawing.Size(88, 20);
            this.tboxIDRute.TabIndex = 1;
            // 
            // rbutDari
            // 
            this.rbutDari.AutoSize = true;
            this.rbutDari.Location = new System.Drawing.Point(521, 147);
            this.rbutDari.Name = "rbutDari";
            this.rbutDari.Size = new System.Drawing.Size(44, 17);
            this.rbutDari.TabIndex = 2;
            this.rbutDari.TabStop = true;
            this.rbutDari.Text = "Dari";
            this.rbutDari.UseVisualStyleBackColor = true;
            this.rbutDari.CheckedChanged += new System.EventHandler(this.rbutDari_CheckedChanged);
            // 
            // rbutKe
            // 
            this.rbutKe.AutoSize = true;
            this.rbutKe.Location = new System.Drawing.Point(628, 147);
            this.rbutKe.Name = "rbutKe";
            this.rbutKe.Size = new System.Drawing.Size(38, 17);
            this.rbutKe.TabIndex = 3;
            this.rbutKe.TabStop = true;
            this.rbutKe.Text = "Ke";
            this.rbutKe.UseVisualStyleBackColor = true;
            this.rbutKe.CheckedChanged += new System.EventHandler(this.rbutKe_CheckedChanged);
            // 
            // tboxDestination
            // 
            this.tboxDestination.Location = new System.Drawing.Point(521, 257);
            this.tboxDestination.Name = "tboxDestination";
            this.tboxDestination.Size = new System.Drawing.Size(145, 20);
            this.tboxDestination.TabIndex = 4;
            this.tboxDestination.TextChanged += new System.EventHandler(this.tboxDestination_TextChanged);
            // 
            // cboxBandara
            // 
            this.cboxBandara.FormattingEnabled = true;
            this.cboxBandara.Location = new System.Drawing.Point(521, 196);
            this.cboxBandara.Name = "cboxBandara";
            this.cboxBandara.Size = new System.Drawing.Size(145, 21);
            this.cboxBandara.TabIndex = 5;
            this.cboxBandara.SelectedIndexChanged += new System.EventHandler(this.cboxBandara_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(738, 147);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Bandara";
            // 
            // labKeDari
            // 
            this.labKeDari.AutoSize = true;
            this.labKeDari.Location = new System.Drawing.Point(518, 241);
            this.labKeDari.Name = "labKeDari";
            this.labKeDari.Size = new System.Drawing.Size(20, 13);
            this.labKeDari.TabIndex = 7;
            this.labKeDari.Text = "Ke";
            // 
            // dTimeBerangkat
            // 
            this.dTimeBerangkat.Location = new System.Drawing.Point(521, 314);
            this.dTimeBerangkat.Name = "dTimeBerangkat";
            this.dTimeBerangkat.Size = new System.Drawing.Size(145, 20);
            this.dTimeBerangkat.TabIndex = 8;
            // 
            // cboxKendaraan
            // 
            this.cboxKendaraan.FormattingEnabled = true;
            this.cboxKendaraan.Location = new System.Drawing.Point(521, 376);
            this.cboxKendaraan.Name = "cboxKendaraan";
            this.cboxKendaraan.Size = new System.Drawing.Size(145, 21);
            this.cboxKendaraan.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(521, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "ID Rute";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(521, 180);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Bandara";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(521, 298);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(30, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Time";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(521, 360);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Kendaraan";
            // 
            // tboxPrice
            // 
            this.tboxPrice.Location = new System.Drawing.Point(521, 474);
            this.tboxPrice.Name = "tboxPrice";
            this.tboxPrice.Size = new System.Drawing.Size(145, 20);
            this.tboxPrice.TabIndex = 14;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(521, 458);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(36, 13);
            this.label6.TabIndex = 15;
            this.label6.Text = "Harga";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(49, 64);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(73, 20);
            this.label7.TabIndex = 16;
            this.label7.Text = "Rute List";
            // 
            // butBack
            // 
            this.butBack.Location = new System.Drawing.Point(53, 12);
            this.butBack.Name = "butBack";
            this.butBack.Size = new System.Drawing.Size(46, 23);
            this.butBack.TabIndex = 17;
            this.butBack.Text = "<";
            this.butBack.UseVisualStyleBackColor = true;
            // 
            // labError
            // 
            this.labError.AutoSize = true;
            this.labError.Location = new System.Drawing.Point(520, 514);
            this.labError.Name = "labError";
            this.labError.Size = new System.Drawing.Size(10, 13);
            this.labError.TabIndex = 20;
            this.labError.Text = "-";
            // 
            // butDelete
            // 
            this.butDelete.Enabled = false;
            this.butDelete.Location = new System.Drawing.Point(655, 546);
            this.butDelete.Name = "butDelete";
            this.butDelete.Size = new System.Drawing.Size(94, 23);
            this.butDelete.TabIndex = 19;
            this.butDelete.Text = "Delete Rute";
            this.butDelete.UseVisualStyleBackColor = true;
            // 
            // butInsert
            // 
            this.butInsert.Location = new System.Drawing.Point(523, 546);
            this.butInsert.Name = "butInsert";
            this.butInsert.Size = new System.Drawing.Size(91, 23);
            this.butInsert.TabIndex = 18;
            this.butInsert.Text = "Insert Rute";
            this.butInsert.UseVisualStyleBackColor = true;
            this.butInsert.Click += new System.EventHandler(this.butInsert_Click);
            // 
            // RuteList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 681);
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
            this.Controls.Add(this.dTimeBerangkat);
            this.Controls.Add(this.labKeDari);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cboxBandara);
            this.Controls.Add(this.tboxDestination);
            this.Controls.Add(this.rbutKe);
            this.Controls.Add(this.rbutDari);
            this.Controls.Add(this.tboxIDRute);
            this.Controls.Add(this.dgvRute);
            this.Name = "RuteList";
            this.Text = "RuteList";
            this.Load += new System.EventHandler(this.RuteList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRute)).EndInit();
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
        private System.Windows.Forms.DateTimePicker dTimeBerangkat;
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
    }
}