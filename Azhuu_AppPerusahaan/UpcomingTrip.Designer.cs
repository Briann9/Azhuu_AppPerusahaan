namespace Azhuu_AppPerusahaan
{
    partial class UpcomingTrip
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
            this.dgvUpcomingTrip = new System.Windows.Forms.DataGridView();
            this.butBack = new System.Windows.Forms.Button();
            this.dgvDaftarPenumpang = new System.Windows.Forms.DataGridView();
            this.butDone = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUpcomingTrip)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDaftarPenumpang)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvUpcomingTrip
            // 
            this.dgvUpcomingTrip.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUpcomingTrip.Location = new System.Drawing.Point(73, 176);
            this.dgvUpcomingTrip.Margin = new System.Windows.Forms.Padding(4);
            this.dgvUpcomingTrip.Name = "dgvUpcomingTrip";
            this.dgvUpcomingTrip.RowHeadersWidth = 51;
            this.dgvUpcomingTrip.Size = new System.Drawing.Size(772, 619);
            this.dgvUpcomingTrip.TabIndex = 0;
            this.dgvUpcomingTrip.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvUpcomingTrip_CellClick);
            // 
            // butBack
            // 
            this.butBack.Location = new System.Drawing.Point(73, 98);
            this.butBack.Margin = new System.Windows.Forms.Padding(4);
            this.butBack.Name = "butBack";
            this.butBack.Size = new System.Drawing.Size(100, 28);
            this.butBack.TabIndex = 1;
            this.butBack.Text = "<";
            this.butBack.UseVisualStyleBackColor = true;
            this.butBack.Click += new System.EventHandler(this.butBack_Click);
            // 
            // dgvDaftarPenumpang
            // 
            this.dgvDaftarPenumpang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDaftarPenumpang.Location = new System.Drawing.Point(1056, 176);
            this.dgvDaftarPenumpang.Margin = new System.Windows.Forms.Padding(4);
            this.dgvDaftarPenumpang.Name = "dgvDaftarPenumpang";
            this.dgvDaftarPenumpang.RowHeadersWidth = 51;
            this.dgvDaftarPenumpang.Size = new System.Drawing.Size(531, 597);
            this.dgvDaftarPenumpang.TabIndex = 2;
            this.dgvDaftarPenumpang.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDaftarPenumpang_CellClick);
            // 
            // butDone
            // 
            this.butDone.Location = new System.Drawing.Point(1401, 781);
            this.butDone.Margin = new System.Windows.Forms.Padding(4);
            this.butDone.Name = "butDone";
            this.butDone.Size = new System.Drawing.Size(160, 28);
            this.butDone.TabIndex = 3;
            this.butDone.Text = "Perjalanan Selesai";
            this.butDone.UseVisualStyleBackColor = true;
            this.butDone.Click += new System.EventHandler(this.butDone_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(70, 139);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Upcoming Trip";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(1064, 139);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(127, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Daftar Penumpang";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Azhuu_AppPerusahaan.Properties.Resources._1111111111111111111111;
            this.pictureBox1.Location = new System.Drawing.Point(-4, -5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1689, 844);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // UpcomingTrip
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1685, 838);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.butDone);
            this.Controls.Add(this.dgvDaftarPenumpang);
            this.Controls.Add(this.butBack);
            this.Controls.Add(this.dgvUpcomingTrip);
            this.Controls.Add(this.pictureBox1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "UpcomingTrip";
            this.Text = "UpcomingTrip";
            this.Load += new System.EventHandler(this.UpcomingTrip_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvUpcomingTrip)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDaftarPenumpang)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvUpcomingTrip;
        private System.Windows.Forms.Button butBack;
        private System.Windows.Forms.DataGridView dgvDaftarPenumpang;
        private System.Windows.Forms.Button butDone;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}