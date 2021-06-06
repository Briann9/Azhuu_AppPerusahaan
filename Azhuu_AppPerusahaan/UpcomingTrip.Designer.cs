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
            this.dgvListTrip = new System.Windows.Forms.DataGridView();
            this.butDone = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dgvListPenumpang = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUpcomingTrip)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListTrip)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListPenumpang)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvUpcomingTrip
            // 
            this.dgvUpcomingTrip.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUpcomingTrip.Location = new System.Drawing.Point(55, 143);
            this.dgvUpcomingTrip.Name = "dgvUpcomingTrip";
            this.dgvUpcomingTrip.RowHeadersWidth = 51;
            this.dgvUpcomingTrip.Size = new System.Drawing.Size(579, 503);
            this.dgvUpcomingTrip.TabIndex = 0;
            this.dgvUpcomingTrip.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvUpcomingTrip_CellClick);
            // 
            // butBack
            // 
            this.butBack.Location = new System.Drawing.Point(55, 80);
            this.butBack.Name = "butBack";
            this.butBack.Size = new System.Drawing.Size(75, 23);
            this.butBack.TabIndex = 1;
            this.butBack.Text = "<";
            this.butBack.UseVisualStyleBackColor = true;
            this.butBack.Click += new System.EventHandler(this.butBack_Click);
            // 
            // dgvListTrip
            // 
            this.dgvListTrip.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListTrip.Location = new System.Drawing.Point(792, 80);
            this.dgvListTrip.Name = "dgvListTrip";
            this.dgvListTrip.RowHeadersWidth = 51;
            this.dgvListTrip.Size = new System.Drawing.Size(398, 240);
            this.dgvListTrip.TabIndex = 2;
            this.dgvListTrip.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvListTrip_CellClick);
            // 
            // butDone
            // 
            this.butDone.Location = new System.Drawing.Point(1051, 635);
            this.butDone.Name = "butDone";
            this.butDone.Size = new System.Drawing.Size(120, 23);
            this.butDone.TabIndex = 3;
            this.butDone.Text = "Perjalanan Selesai";
            this.butDone.UseVisualStyleBackColor = true;
            this.butDone.Click += new System.EventHandler(this.butDone_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(52, 113);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Upcoming Trip";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(789, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Trip Date";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Azhuu_AppPerusahaan.Properties.Resources._1111111111111111111111;
            this.pictureBox1.Location = new System.Drawing.Point(-3, -4);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1267, 686);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(789, 342);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Daftar Penumpang";
            // 
            // dgvListPenumpang
            // 
            this.dgvListPenumpang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListPenumpang.Location = new System.Drawing.Point(792, 369);
            this.dgvListPenumpang.Name = "dgvListPenumpang";
            this.dgvListPenumpang.RowHeadersWidth = 51;
            this.dgvListPenumpang.Size = new System.Drawing.Size(398, 240);
            this.dgvListPenumpang.TabIndex = 8;
            // 
            // UpcomingTrip
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.dgvListPenumpang);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.butDone);
            this.Controls.Add(this.dgvListTrip);
            this.Controls.Add(this.butBack);
            this.Controls.Add(this.dgvUpcomingTrip);
            this.Controls.Add(this.pictureBox1);
            this.Name = "UpcomingTrip";
            this.Text = "UpcomingTrip";
            this.Load += new System.EventHandler(this.UpcomingTrip_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvUpcomingTrip)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListTrip)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListPenumpang)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvUpcomingTrip;
        private System.Windows.Forms.Button butBack;
        private System.Windows.Forms.DataGridView dgvListTrip;
        private System.Windows.Forms.Button butDone;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dgvListPenumpang;
    }
}