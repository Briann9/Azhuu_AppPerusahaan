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
            ((System.ComponentModel.ISupportInitialize)(this.dgvUpcomingTrip)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDaftarPenumpang)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvUpcomingTrip
            // 
            this.dgvUpcomingTrip.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUpcomingTrip.Location = new System.Drawing.Point(34, 143);
            this.dgvUpcomingTrip.Name = "dgvUpcomingTrip";
            this.dgvUpcomingTrip.Size = new System.Drawing.Size(579, 511);
            this.dgvUpcomingTrip.TabIndex = 0;
            this.dgvUpcomingTrip.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvUpcomingTrip_CellClick);
            // 
            // butBack
            // 
            this.butBack.Location = new System.Drawing.Point(34, 23);
            this.butBack.Name = "butBack";
            this.butBack.Size = new System.Drawing.Size(75, 23);
            this.butBack.TabIndex = 1;
            this.butBack.Text = "<";
            this.butBack.UseVisualStyleBackColor = true;
            // 
            // dgvDaftarPenumpang
            // 
            this.dgvDaftarPenumpang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDaftarPenumpang.Location = new System.Drawing.Point(670, 143);
            this.dgvDaftarPenumpang.Name = "dgvDaftarPenumpang";
            this.dgvDaftarPenumpang.Size = new System.Drawing.Size(342, 511);
            this.dgvDaftarPenumpang.TabIndex = 2;
            this.dgvDaftarPenumpang.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDaftarPenumpang_CellClick);
            // 
            // butDone
            // 
            this.butDone.Location = new System.Drawing.Point(1116, 620);
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
            this.label1.Location = new System.Drawing.Point(31, 108);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Upcoming Trip";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(667, 108);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Daftar Penumpang";
            // 
            // UpcomingTrip
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.butDone);
            this.Controls.Add(this.dgvDaftarPenumpang);
            this.Controls.Add(this.butBack);
            this.Controls.Add(this.dgvUpcomingTrip);
            this.Name = "UpcomingTrip";
            this.Text = "UpcomingTrip";
            this.Load += new System.EventHandler(this.UpcomingTrip_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvUpcomingTrip)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDaftarPenumpang)).EndInit();
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
    }
}