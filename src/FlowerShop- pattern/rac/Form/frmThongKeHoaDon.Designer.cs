namespace rac
{
    partial class frmThongKeHoaDon
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
            this.dgvDSHoaDon = new System.Windows.Forms.DataGridView();
            this.STT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgayThanhToan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenNV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TongTien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TrangThai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSHoaDon)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvDSHoaDon
            // 
            this.dgvDSHoaDon.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dgvDSHoaDon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDSHoaDon.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.STT,
            this.NgayThanhToan,
            this.TenNV,
            this.TongTien,
            this.TrangThai});
            this.dgvDSHoaDon.Location = new System.Drawing.Point(6, 19);
            this.dgvDSHoaDon.Name = "dgvDSHoaDon";
            this.dgvDSHoaDon.Size = new System.Drawing.Size(519, 211);
            this.dgvDSHoaDon.TabIndex = 1;
            this.dgvDSHoaDon.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDSHoaDon_CellClick);
            // 
            // STT
            // 
            this.STT.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.STT.DataPropertyName = "STT";
            this.STT.HeaderText = "STT";
            this.STT.Name = "STT";
            this.STT.ReadOnly = true;
            this.STT.Width = 50;
            // 
            // NgayThanhToan
            // 
            this.NgayThanhToan.DataPropertyName = "NgayThanhToan";
            this.NgayThanhToan.HeaderText = "Ngày Thanh Toán";
            this.NgayThanhToan.Name = "NgayThanhToan";
            this.NgayThanhToan.ReadOnly = true;
            this.NgayThanhToan.Width = 120;
            // 
            // TenNV
            // 
            this.TenNV.DataPropertyName = "TenNV";
            this.TenNV.HeaderText = "Tên Nhân Viên";
            this.TenNV.Name = "TenNV";
            // 
            // TongTien
            // 
            this.TongTien.DataPropertyName = "TongTien";
            this.TongTien.HeaderText = "Tổng Tiền";
            this.TongTien.Name = "TongTien";
            // 
            // TrangThai
            // 
            this.TrangThai.DataPropertyName = "TrangThai";
            this.TrangThai.HeaderText = "Trạng Thái";
            this.TrangThai.Name = "TrangThai";
            this.TrangThai.ReadOnly = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(146, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(254, 31);
            this.label2.TabIndex = 51;
            this.label2.Text = "Danh Sách Hóa Đơn";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvDSHoaDon);
            this.groupBox1.Location = new System.Drawing.Point(17, 67);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(536, 237);
            this.groupBox1.TabIndex = 52;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Danh sách";
            // 
            // frmThongKeHoaDon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(571, 324);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmThongKeHoaDon";
            this.Text = "frmThongKeHoaDon";
            this.Load += new System.EventHandler(this.frmThongKeHoaDon_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSHoaDon)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvDSHoaDon;
        private System.Windows.Forms.DataGridViewTextBoxColumn STT;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgayThanhToan;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenNV;
        private System.Windows.Forms.DataGridViewTextBoxColumn TongTien;
        private System.Windows.Forms.DataGridViewTextBoxColumn TrangThai;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}