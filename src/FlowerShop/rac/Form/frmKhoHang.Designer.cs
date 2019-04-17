namespace rac
{
    partial class frmKhoHang
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmKhoHang));
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Tuổi = new System.Windows.Forms.Label();
            this.grbChitiet = new System.Windows.Forms.GroupBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.tblSINHVIENBindingSource8 = new System.Windows.Forms.BindingSource(this.components);
            this.btnSua = new System.Windows.Forms.Button();
            this.dgvKhoHang = new System.Windows.Forms.DataGridView();
            this.txtSTT = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.xxx = new System.Windows.Forms.Label();
            this.txtSoLuong = new System.Windows.Forms.TextBox();
            this.txtNgayNhap = new System.Windows.Forms.MaskedTextBox();
            this.txtNgayHetHan = new System.Windows.Forms.MaskedTextBox();
            this.txtCBBTenSP = new System.Windows.Forms.ComboBox();
            this.STT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenSP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgayNhap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgayHetHan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoLuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            this.grbChitiet.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblSINHVIENBindingSource8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKhoHang)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox3
            // 
            this.groupBox3.Location = new System.Drawing.Point(21, 66);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(781, 46);
            this.groupBox3.TabIndex = 37;
            this.groupBox3.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(238, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(374, 31);
            this.label1.TabIndex = 34;
            this.label1.Text = "Quản Lý Thông Tin Kho Hàng";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(8, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 15);
            this.label2.TabIndex = 13;
            this.label2.Text = "Tên Sản Phẩm";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvKhoHang);
            this.groupBox1.Location = new System.Drawing.Point(274, 118);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(528, 329);
            this.groupBox1.TabIndex = 35;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Danh sách";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(9, 123);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 15);
            this.label4.TabIndex = 15;
            this.label4.Text = "Ngày Nhập";
            // 
            // Tuổi
            // 
            this.Tuổi.AutoSize = true;
            this.Tuổi.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Tuổi.Location = new System.Drawing.Point(8, 162);
            this.Tuổi.Name = "Tuổi";
            this.Tuổi.Size = new System.Drawing.Size(81, 15);
            this.Tuổi.TabIndex = 14;
            this.Tuổi.Text = "Ngày Hết Hạn";
            // 
            // grbChitiet
            // 
            this.grbChitiet.Controls.Add(this.txtCBBTenSP);
            this.grbChitiet.Controls.Add(this.txtNgayHetHan);
            this.grbChitiet.Controls.Add(this.txtNgayNhap);
            this.grbChitiet.Controls.Add(this.txtSTT);
            this.grbChitiet.Controls.Add(this.label6);
            this.grbChitiet.Controls.Add(this.txtSoLuong);
            this.grbChitiet.Controls.Add(this.xxx);
            this.grbChitiet.Controls.Add(this.label4);
            this.grbChitiet.Controls.Add(this.Tuổi);
            this.grbChitiet.Controls.Add(this.label2);
            this.grbChitiet.Location = new System.Drawing.Point(21, 119);
            this.grbChitiet.Name = "grbChitiet";
            this.grbChitiet.Size = new System.Drawing.Size(247, 328);
            this.grbChitiet.TabIndex = 36;
            this.grbChitiet.TabStop = false;
            this.grbChitiet.Text = "Thông tin chi tiết";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // btnLuu
            // 
            this.btnLuu.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLuu.ForeColor = System.Drawing.Color.Black;
            this.btnLuu.Image = ((System.Drawing.Image)(resources.GetObject("btnLuu.Image")));
            this.btnLuu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLuu.Location = new System.Drawing.Point(808, 316);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(78, 35);
            this.btnLuu.TabIndex = 32;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLuu.UseVisualStyleBackColor = true;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThoat.Image = ((System.Drawing.Image)(resources.GetObject("btnThoat.Image")));
            this.btnThoat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThoat.Location = new System.Drawing.Point(808, 368);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(78, 35);
            this.btnThoat.TabIndex = 33;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.ForeColor = System.Drawing.Color.Black;
            this.btnXoa.Image = ((System.Drawing.Image)(resources.GetObject("btnXoa.Image")));
            this.btnXoa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnXoa.Location = new System.Drawing.Point(808, 262);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(78, 35);
            this.btnXoa.TabIndex = 31;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnThem
            // 
            this.btnThem.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.Image = ((System.Drawing.Image)(resources.GetObject("btnThem.Image")));
            this.btnThem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThem.Location = new System.Drawing.Point(808, 163);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(78, 35);
            this.btnThem.TabIndex = 29;
            this.btnThem.Text = "Thêm";
            this.btnThem.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // tblSINHVIENBindingSource8
            // 
            this.tblSINHVIENBindingSource8.DataMember = "tblSINH_VIEN";
            // 
            // btnSua
            // 
            this.btnSua.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSua.Image = ((System.Drawing.Image)(resources.GetObject("btnSua.Image")));
            this.btnSua.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSua.Location = new System.Drawing.Point(808, 213);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(78, 35);
            this.btnSua.TabIndex = 30;
            this.btnSua.Text = "Sửa";
            this.btnSua.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // dgvKhoHang
            // 
            this.dgvKhoHang.AutoGenerateColumns = false;
            this.dgvKhoHang.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dgvKhoHang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvKhoHang.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.STT,
            this.TenSP,
            this.NgayNhap,
            this.NgayHetHan,
            this.SoLuong});
            this.dgvKhoHang.DataSource = this.tblSINHVIENBindingSource8;
            this.dgvKhoHang.Location = new System.Drawing.Point(7, 12);
            this.dgvKhoHang.Name = "dgvKhoHang";
            this.dgvKhoHang.Size = new System.Drawing.Size(514, 304);
            this.dgvKhoHang.TabIndex = 1;
            this.dgvKhoHang.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvKhoHang_CellClick);
            // 
            // txtSTT
            // 
            this.txtSTT.Location = new System.Drawing.Point(97, 35);
            this.txtSTT.Name = "txtSTT";
            this.txtSTT.Size = new System.Drawing.Size(133, 20);
            this.txtSTT.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(10, 35);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(31, 15);
            this.label6.TabIndex = 30;
            this.label6.Text = "STT";
            // 
            // xxx
            // 
            this.xxx.AutoSize = true;
            this.xxx.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xxx.Location = new System.Drawing.Point(8, 205);
            this.xxx.Name = "xxx";
            this.xxx.Size = new System.Drawing.Size(58, 15);
            this.xxx.TabIndex = 17;
            this.xxx.Text = "Số Lượng";
            // 
            // txtSoLuong
            // 
            this.txtSoLuong.Location = new System.Drawing.Point(95, 203);
            this.txtSoLuong.Name = "txtSoLuong";
            this.txtSoLuong.Size = new System.Drawing.Size(133, 20);
            this.txtSoLuong.TabIndex = 5;
            // 
            // txtNgayNhap
            // 
            this.txtNgayNhap.Location = new System.Drawing.Point(95, 121);
            this.txtNgayNhap.Mask = "00/00/0000";
            this.txtNgayNhap.Name = "txtNgayNhap";
            this.txtNgayNhap.Size = new System.Drawing.Size(133, 20);
            this.txtNgayNhap.TabIndex = 3;
            this.txtNgayNhap.ValidatingType = typeof(System.DateTime);
            // 
            // txtNgayHetHan
            // 
            this.txtNgayHetHan.Location = new System.Drawing.Point(95, 160);
            this.txtNgayHetHan.Mask = "00/00/0000";
            this.txtNgayHetHan.Name = "txtNgayHetHan";
            this.txtNgayHetHan.Size = new System.Drawing.Size(133, 20);
            this.txtNgayHetHan.TabIndex = 4;
            this.txtNgayHetHan.ValidatingType = typeof(System.DateTime);
            // 
            // txtCBBTenSP
            // 
            this.txtCBBTenSP.FormattingEnabled = true;
            this.txtCBBTenSP.Location = new System.Drawing.Point(95, 76);
            this.txtCBBTenSP.Name = "txtCBBTenSP";
            this.txtCBBTenSP.Size = new System.Drawing.Size(135, 21);
            this.txtCBBTenSP.TabIndex = 2;
            // 
            // STT
            // 
            this.STT.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.STT.DataPropertyName = "STT";
            this.STT.HeaderText = "STT";
            this.STT.Name = "STT";
            this.STT.Width = 50;
            // 
            // TenSP
            // 
            this.TenSP.DataPropertyName = "TenSP";
            this.TenSP.HeaderText = "Tên Sản Phẩm";
            this.TenSP.Name = "TenSP";
            this.TenSP.Width = 50;
            // 
            // NgayNhap
            // 
            this.NgayNhap.DataPropertyName = "NgayNhap";
            this.NgayNhap.HeaderText = "Ngày Nhập";
            this.NgayNhap.Name = "NgayNhap";
            this.NgayNhap.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.NgayNhap.Width = 150;
            // 
            // NgayHetHan
            // 
            this.NgayHetHan.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.NgayHetHan.DataPropertyName = "NgayHetHan";
            this.NgayHetHan.HeaderText = "Ngày Hết Hạn";
            this.NgayHetHan.Name = "NgayHetHan";
            this.NgayHetHan.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.NgayHetHan.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.NgayHetHan.Width = 150;
            // 
            // SoLuong
            // 
            this.SoLuong.DataPropertyName = "SoLuong";
            this.SoLuong.HeaderText = "Số Lượng";
            this.SoLuong.Name = "SoLuong";
            this.SoLuong.Width = 70;
            // 
            // frmKhoHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(907, 478);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.grbChitiet);
            this.Name = "frmKhoHang";
            this.Text = "frmKhoHang";
            this.Load += new System.EventHandler(this.frmKhoHang_Load);
            this.groupBox1.ResumeLayout(false);
            this.grbChitiet.ResumeLayout(false);
            this.grbChitiet.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblSINHVIENBindingSource8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKhoHang)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.BindingSource tblSINHVIENBindingSource8;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label Tuổi;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.GroupBox grbChitiet;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.DataGridView dgvKhoHang;
        private System.Windows.Forms.MaskedTextBox txtNgayHetHan;
        private System.Windows.Forms.MaskedTextBox txtNgayNhap;
        private System.Windows.Forms.TextBox txtSTT;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtSoLuong;
        private System.Windows.Forms.Label xxx;
        private System.Windows.Forms.ComboBox txtCBBTenSP;
        private System.Windows.Forms.DataGridViewTextBoxColumn STT;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenSP;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgayNhap;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgayHetHan;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoLuong;
    }
}