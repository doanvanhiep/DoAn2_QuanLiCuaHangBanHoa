namespace rac
{
    partial class frmXuatHang
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmXuatHang));
            this.label4 = new System.Windows.Forms.Label();
            this.txtTongtien = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNguoiXuat = new System.Windows.Forms.TextBox();
            this.txtGiaXuat = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnThem = new System.Windows.Forms.Button();
            this.txtCBBTenSP = new System.Windows.Forms.ComboBox();
            this.txtSoLuong = new System.Windows.Forms.TextBox();
            this.xxx = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.thanhtien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GiaNhap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoLuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenNV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenSP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.STT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvHoaDon = new System.Windows.Forms.DataGridView();
            this.btnLuu = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.grbChitiet = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHoaDon)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.grbChitiet.SuspendLayout();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(212, 241);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(21, 19);
            this.label4.TabIndex = 41;
            this.label4.Text = "Đ";
            // 
            // txtTongtien
            // 
            this.txtTongtien.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTongtien.Location = new System.Drawing.Point(95, 237);
            this.txtTongtien.Multiline = true;
            this.txtTongtien.Name = "txtTongtien";
            this.txtTongtien.ReadOnly = true;
            this.txtTongtien.Size = new System.Drawing.Size(111, 29);
            this.txtTongtien.TabIndex = 39;
            this.txtTongtien.Text = "0";
            this.txtTongtien.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(11, 241);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 19);
            this.label1.TabIndex = 40;
            this.label1.Text = "Tổng tiền";
            // 
            // txtNguoiXuat
            // 
            this.txtNguoiXuat.Location = new System.Drawing.Point(97, 70);
            this.txtNguoiXuat.Name = "txtNguoiXuat";
            this.txtNguoiXuat.ReadOnly = true;
            this.txtNguoiXuat.Size = new System.Drawing.Size(133, 20);
            this.txtNguoiXuat.TabIndex = 35;
            // 
            // txtGiaXuat
            // 
            this.txtGiaXuat.Location = new System.Drawing.Point(95, 155);
            this.txtGiaXuat.Name = "txtGiaXuat";
            this.txtGiaXuat.ReadOnly = true;
            this.txtGiaXuat.Size = new System.Drawing.Size(133, 20);
            this.txtGiaXuat.TabIndex = 33;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 157);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 15);
            this.label5.TabIndex = 34;
            this.label5.Text = "Giá Xuất";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(10, 72);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 15);
            this.label3.TabIndex = 32;
            this.label3.Text = "Người Xuất";
            // 
            // btnThem
            // 
            this.btnThem.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.Image = ((System.Drawing.Image)(resources.GetObject("btnThem.Image")));
            this.btnThem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThem.Location = new System.Drawing.Point(152, 181);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(78, 35);
            this.btnThem.TabIndex = 38;
            this.btnThem.Text = "Thêm";
            this.btnThem.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // txtCBBTenSP
            // 
            this.txtCBBTenSP.FormattingEnabled = true;
            this.txtCBBTenSP.Location = new System.Drawing.Point(95, 32);
            this.txtCBBTenSP.Name = "txtCBBTenSP";
            this.txtCBBTenSP.Size = new System.Drawing.Size(135, 21);
            this.txtCBBTenSP.TabIndex = 2;
            this.txtCBBTenSP.SelectedIndexChanged += new System.EventHandler(this.txtCBBTenSP_SelectedIndexChanged);
            // 
            // txtSoLuong
            // 
            this.txtSoLuong.Location = new System.Drawing.Point(95, 116);
            this.txtSoLuong.Name = "txtSoLuong";
            this.txtSoLuong.Size = new System.Drawing.Size(133, 20);
            this.txtSoLuong.TabIndex = 5;
            // 
            // xxx
            // 
            this.xxx.AutoSize = true;
            this.xxx.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xxx.Location = new System.Drawing.Point(12, 118);
            this.xxx.Name = "xxx";
            this.xxx.Size = new System.Drawing.Size(58, 15);
            this.xxx.TabIndex = 17;
            this.xxx.Text = "Số Lượng";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(8, 34);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(85, 15);
            this.label7.TabIndex = 13;
            this.label7.Text = "Tên Sản Phẩm";
            // 
            // thanhtien
            // 
            this.thanhtien.HeaderText = "Thành Tiền";
            this.thanhtien.Name = "thanhtien";
            this.thanhtien.ReadOnly = true;
            // 
            // GiaNhap
            // 
            this.GiaNhap.DataPropertyName = "GiaNhap";
            this.GiaNhap.HeaderText = "Giá ";
            this.GiaNhap.Name = "GiaNhap";
            this.GiaNhap.ReadOnly = true;
            // 
            // SoLuong
            // 
            this.SoLuong.DataPropertyName = "SoLuong";
            this.SoLuong.HeaderText = "Số Lượng";
            this.SoLuong.Name = "SoLuong";
            this.SoLuong.ReadOnly = true;
            this.SoLuong.Width = 70;
            // 
            // TenNV
            // 
            this.TenNV.DataPropertyName = "TenNV";
            this.TenNV.HeaderText = "Người Nhập";
            this.TenNV.Name = "TenNV";
            this.TenNV.ReadOnly = true;
            // 
            // TenSP
            // 
            this.TenSP.DataPropertyName = "TenSP";
            this.TenSP.HeaderText = "Tên Sản Phẩm";
            this.TenSP.Name = "TenSP";
            this.TenSP.ReadOnly = true;
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
            // dgvHoaDon
            // 
            this.dgvHoaDon.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dgvHoaDon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHoaDon.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.STT,
            this.TenSP,
            this.TenNV,
            this.SoLuong,
            this.GiaNhap,
            this.thanhtien});
            this.dgvHoaDon.Location = new System.Drawing.Point(0, 25);
            this.dgvHoaDon.Name = "dgvHoaDon";
            this.dgvHoaDon.Size = new System.Drawing.Size(562, 299);
            this.dgvHoaDon.TabIndex = 1;
            // 
            // btnLuu
            // 
            this.btnLuu.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLuu.ForeColor = System.Drawing.Color.Black;
            this.btnLuu.Image = ((System.Drawing.Image)(resources.GetObject("btnLuu.Image")));
            this.btnLuu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLuu.Location = new System.Drawing.Point(163, 364);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(113, 35);
            this.btnLuu.TabIndex = 46;
            this.btnLuu.Text = "Xuất hóa đơn";
            this.btnLuu.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLuu.UseVisualStyleBackColor = true;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(374, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(141, 31);
            this.label2.TabIndex = 47;
            this.label2.Text = "Xuất Hàng";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvHoaDon);
            this.groupBox1.Location = new System.Drawing.Point(282, 86);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(574, 324);
            this.groupBox1.TabIndex = 48;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Danh sách";
            // 
            // grbChitiet
            // 
            this.grbChitiet.Controls.Add(this.label4);
            this.grbChitiet.Controls.Add(this.txtTongtien);
            this.grbChitiet.Controls.Add(this.label1);
            this.grbChitiet.Controls.Add(this.txtNguoiXuat);
            this.grbChitiet.Controls.Add(this.txtGiaXuat);
            this.grbChitiet.Controls.Add(this.label5);
            this.grbChitiet.Controls.Add(this.label3);
            this.grbChitiet.Controls.Add(this.btnThem);
            this.grbChitiet.Controls.Add(this.txtCBBTenSP);
            this.grbChitiet.Controls.Add(this.txtSoLuong);
            this.grbChitiet.Controls.Add(this.xxx);
            this.grbChitiet.Controls.Add(this.label7);
            this.grbChitiet.Location = new System.Drawing.Point(29, 87);
            this.grbChitiet.Name = "grbChitiet";
            this.grbChitiet.Size = new System.Drawing.Size(247, 271);
            this.grbChitiet.TabIndex = 49;
            this.grbChitiet.TabStop = false;
            this.grbChitiet.Text = "Thông tin chi tiết";
            // 
            // frmXuatHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 450);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.grbChitiet);
            this.Name = "frmXuatHang";
            this.Text = "frmXuatHang";
            this.Load += new System.EventHandler(this.frmXuatHang_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvHoaDon)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.grbChitiet.ResumeLayout(false);
            this.grbChitiet.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtTongtien;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNguoiXuat;
        private System.Windows.Forms.TextBox txtGiaXuat;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.ComboBox txtCBBTenSP;
        private System.Windows.Forms.TextBox txtSoLuong;
        private System.Windows.Forms.Label xxx;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridViewTextBoxColumn thanhtien;
        private System.Windows.Forms.DataGridViewTextBoxColumn GiaNhap;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoLuong;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenNV;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenSP;
        private System.Windows.Forms.DataGridViewTextBoxColumn STT;
        private System.Windows.Forms.DataGridView dgvHoaDon;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox grbChitiet;
    }
}