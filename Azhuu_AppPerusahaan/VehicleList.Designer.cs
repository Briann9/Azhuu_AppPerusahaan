namespace Azhuu_AppPerusahaan
{
    partial class VehicleList
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
            this.dgvVList = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.tboxV_ID = new System.Windows.Forms.TextBox();
            this.tboxBrand = new System.Windows.Forms.TextBox();
            this.tboxCapacity = new System.Windows.Forms.TextBox();
            this.tboxPlate = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.butInsert = new System.Windows.Forms.Button();
            this.butDelete = new System.Windows.Forms.Button();
            this.butBack = new System.Windows.Forms.Button();
            this.cboxType = new System.Windows.Forms.ComboBox();
            this.labError = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvVList
            // 
            this.dgvVList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVList.Location = new System.Drawing.Point(41, 121);
            this.dgvVList.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvVList.Name = "dgvVList";
            this.dgvVList.RowHeadersWidth = 51;
            this.dgvVList.Size = new System.Drawing.Size(814, 681);
            this.dgvVList.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(47, 82);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Vehicle List";
            // 
            // tboxV_ID
            // 
            this.tboxV_ID.Enabled = false;
            this.tboxV_ID.Location = new System.Drawing.Point(1115, 239);
            this.tboxV_ID.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tboxV_ID.Name = "tboxV_ID";
            this.tboxV_ID.Size = new System.Drawing.Size(171, 22);
            this.tboxV_ID.TabIndex = 2;
            // 
            // tboxBrand
            // 
            this.tboxBrand.Location = new System.Drawing.Point(1115, 296);
            this.tboxBrand.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tboxBrand.Name = "tboxBrand";
            this.tboxBrand.Size = new System.Drawing.Size(339, 22);
            this.tboxBrand.TabIndex = 3;
            this.tboxBrand.TextChanged += new System.EventHandler(this.tboxBrand_TextChanged);
            // 
            // tboxCapacity
            // 
            this.tboxCapacity.Location = new System.Drawing.Point(1115, 418);
            this.tboxCapacity.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tboxCapacity.Name = "tboxCapacity";
            this.tboxCapacity.Size = new System.Drawing.Size(339, 22);
            this.tboxCapacity.TabIndex = 5;
            this.tboxCapacity.TextChanged += new System.EventHandler(this.tboxCapacity_TextChanged);
            this.tboxCapacity.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tboxCapacity_KeyPress);
            // 
            // tboxPlate
            // 
            this.tboxPlate.Location = new System.Drawing.Point(1115, 487);
            this.tboxPlate.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tboxPlate.Name = "tboxPlate";
            this.tboxPlate.Size = new System.Drawing.Size(339, 22);
            this.tboxPlate.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(1111, 219);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 17);
            this.label2.TabIndex = 7;
            this.label2.Text = "Vehicle ID";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(1111, 276);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 17);
            this.label3.TabIndex = 8;
            this.label3.Text = "Brand";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(1111, 336);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 17);
            this.label4.TabIndex = 9;
            this.label4.Text = "Vehicle Type";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(1111, 398);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 17);
            this.label5.TabIndex = 10;
            this.label5.Text = "Capacity";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(1111, 467);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(93, 17);
            this.label6.TabIndex = 11;
            this.label6.Text = "License Plate";
            // 
            // butInsert
            // 
            this.butInsert.Location = new System.Drawing.Point(1115, 571);
            this.butInsert.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.butInsert.Name = "butInsert";
            this.butInsert.Size = new System.Drawing.Size(160, 34);
            this.butInsert.TabIndex = 12;
            this.butInsert.Text = "Insert Vehicle";
            this.butInsert.UseVisualStyleBackColor = true;
            this.butInsert.Click += new System.EventHandler(this.butInsert_Click);
            // 
            // butDelete
            // 
            this.butDelete.Location = new System.Drawing.Point(1291, 571);
            this.butDelete.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.butDelete.Name = "butDelete";
            this.butDelete.Size = new System.Drawing.Size(164, 34);
            this.butDelete.TabIndex = 13;
            this.butDelete.Text = "Delete Vehicle";
            this.butDelete.UseVisualStyleBackColor = true;
            // 
            // butBack
            // 
            this.butBack.Location = new System.Drawing.Point(46, 39);
            this.butBack.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.butBack.Name = "butBack";
            this.butBack.Size = new System.Drawing.Size(61, 28);
            this.butBack.TabIndex = 14;
            this.butBack.Text = "<";
            this.butBack.UseVisualStyleBackColor = true;
            // 
            // cboxType
            // 
            this.cboxType.FormattingEnabled = true;
            this.cboxType.Location = new System.Drawing.Point(1115, 357);
            this.cboxType.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cboxType.Name = "cboxType";
            this.cboxType.Size = new System.Drawing.Size(339, 24);
            this.cboxType.TabIndex = 15;
            // 
            // labError
            // 
            this.labError.AutoSize = true;
            this.labError.Location = new System.Drawing.Point(1111, 532);
            this.labError.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labError.Name = "labError";
            this.labError.Size = new System.Drawing.Size(13, 17);
            this.labError.TabIndex = 16;
            this.labError.Text = "-";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Azhuu_AppPerusahaan.Properties.Resources._11551;
            this.pictureBox1.Location = new System.Drawing.Point(-5, -12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1694, 862);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 50;
            this.pictureBox1.TabStop = false;
            // 
            // VehicleList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1685, 838);
            this.Controls.Add(this.labError);
            this.Controls.Add(this.cboxType);
            this.Controls.Add(this.butBack);
            this.Controls.Add(this.butDelete);
            this.Controls.Add(this.butInsert);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tboxPlate);
            this.Controls.Add(this.tboxCapacity);
            this.Controls.Add(this.tboxBrand);
            this.Controls.Add(this.tboxV_ID);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvVList);
            this.Controls.Add(this.pictureBox1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "VehicleList";
            this.Text = "VehicleList";
            this.Load += new System.EventHandler(this.VehicleList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvVList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvVList;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tboxV_ID;
        private System.Windows.Forms.TextBox tboxBrand;
        private System.Windows.Forms.TextBox tboxCapacity;
        private System.Windows.Forms.TextBox tboxPlate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button butInsert;
        private System.Windows.Forms.Button butDelete;
        private System.Windows.Forms.Button butBack;
        private System.Windows.Forms.ComboBox cboxType;
        private System.Windows.Forms.Label labError;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}