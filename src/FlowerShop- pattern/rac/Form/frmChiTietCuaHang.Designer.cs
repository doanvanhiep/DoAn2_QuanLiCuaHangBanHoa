namespace rac
{
    partial class frmChiTietCuaHang
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmChiTietCuaHang));
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend4 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.chartDoanhThu = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtTangGiam = new System.Windows.Forms.Label();
            this.txtHoaDonBan = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtSoHoaDonHuy = new System.Windows.Forms.Label();
            this.txtHoaDonHuy = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.ptbHieuSuat = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtHieuSuat = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtGiaHoaDonBan = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtDoanhThu = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.chartSanPham = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.cbbDoanhThu = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.chartDoanhThu)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbHieuSuat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartSanPham)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // chartDoanhThu
            // 
            chartArea3.Name = "ChartArea1";
            this.chartDoanhThu.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            this.chartDoanhThu.Legends.Add(legend3);
            this.chartDoanhThu.Location = new System.Drawing.Point(6, 22);
            this.chartDoanhThu.Name = "chartDoanhThu";
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold);
            series3.Legend = "Legend1";
            series3.Name = "Gia";
            this.chartDoanhThu.Series.Add(series3);
            this.chartDoanhThu.Size = new System.Drawing.Size(363, 301);
            this.chartDoanhThu.TabIndex = 0;
            this.chartDoanhThu.Text = "chart1";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupBox1.Controls.Add(this.txtTangGiam);
            this.groupBox1.Controls.Add(this.txtHoaDonBan);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.txtSoHoaDonHuy);
            this.groupBox1.Controls.Add(this.txtHoaDonHuy);
            this.groupBox1.Controls.Add(this.pictureBox3);
            this.groupBox1.Controls.Add(this.ptbHieuSuat);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtHieuSuat);
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtGiaHoaDonBan);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(955, 100);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Kết Quả Bán Hàng Hôm Nay";
            // 
            // txtTangGiam
            // 
            this.txtTangGiam.AutoSize = true;
            this.txtTangGiam.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTangGiam.Location = new System.Drawing.Point(438, 22);
            this.txtTangGiam.Name = "txtTangGiam";
            this.txtTangGiam.Size = new System.Drawing.Size(45, 17);
            this.txtTangGiam.TabIndex = 15;
            this.txtTangGiam.Text = "Giảm";
            // 
            // txtHoaDonBan
            // 
            this.txtHoaDonBan.AutoSize = true;
            this.txtHoaDonBan.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHoaDonBan.Location = new System.Drawing.Point(157, 22);
            this.txtHoaDonBan.Name = "txtHoaDonBan";
            this.txtHoaDonBan.Size = new System.Drawing.Size(71, 17);
            this.txtHoaDonBan.TabIndex = 14;
            this.txtHoaDonBan.Text = "Hóa Đơn";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(693, 70);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(42, 15);
            this.label7.TabIndex = 13;
            this.label7.Text = "Bị Hủy";
            // 
            // txtSoHoaDonHuy
            // 
            this.txtSoHoaDonHuy.AutoSize = true;
            this.txtSoHoaDonHuy.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSoHoaDonHuy.ForeColor = System.Drawing.Color.Peru;
            this.txtSoHoaDonHuy.Location = new System.Drawing.Point(694, 44);
            this.txtSoHoaDonHuy.Name = "txtSoHoaDonHuy";
            this.txtSoHoaDonHuy.Size = new System.Drawing.Size(63, 20);
            this.txtSoHoaDonHuy.TabIndex = 12;
            this.txtSoHoaDonHuy.Text = "000000";
            // 
            // txtHoaDonHuy
            // 
            this.txtHoaDonHuy.AutoSize = true;
            this.txtHoaDonHuy.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHoaDonHuy.Location = new System.Drawing.Point(693, 22);
            this.txtHoaDonHuy.Name = "txtHoaDonHuy";
            this.txtHoaDonHuy.Size = new System.Drawing.Size(145, 17);
            this.txtHoaDonHuy.TabIndex = 11;
            this.txtHoaDonHuy.Text = "Số Lượng Hóa Đơn";
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(638, 22);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(50, 63);
            this.pictureBox3.TabIndex = 10;
            this.pictureBox3.TabStop = false;
            // 
            // ptbHieuSuat
            // 
            this.ptbHieuSuat.Image = global::rac.Properties.Resources.giam;
            this.ptbHieuSuat.Location = new System.Drawing.Point(380, 22);
            this.ptbHieuSuat.Name = "ptbHieuSuat";
            this.ptbHieuSuat.Size = new System.Drawing.Size(50, 63);
            this.ptbHieuSuat.TabIndex = 7;
            this.ptbHieuSuat.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(436, 70);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(92, 15);
            this.label5.TabIndex = 6;
            this.label5.Text = "So với hôm qua";
            // 
            // txtHieuSuat
            // 
            this.txtHieuSuat.AutoSize = true;
            this.txtHieuSuat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHieuSuat.ForeColor = System.Drawing.Color.IndianRed;
            this.txtHieuSuat.Location = new System.Drawing.Point(437, 44);
            this.txtHieuSuat.Name = "txtHieuSuat";
            this.txtHieuSuat.Size = new System.Drawing.Size(63, 20);
            this.txtHieuSuat.TabIndex = 5;
            this.txtHieuSuat.Text = "00,00%";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::rac.Properties.Resources.money_cash_usd_blue_currency_dollar;
            this.pictureBox1.Location = new System.Drawing.Point(99, 22);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(50, 63);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(157, 70);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 15);
            this.label4.TabIndex = 2;
            this.label4.Text = "Doanh thu";
            // 
            // txtGiaHoaDonBan
            // 
            this.txtGiaHoaDonBan.AutoSize = true;
            this.txtGiaHoaDonBan.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGiaHoaDonBan.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.txtGiaHoaDonBan.Location = new System.Drawing.Point(156, 44);
            this.txtGiaHoaDonBan.Name = "txtGiaHoaDonBan";
            this.txtGiaHoaDonBan.Size = new System.Drawing.Size(63, 20);
            this.txtGiaHoaDonBan.TabIndex = 1;
            this.txtGiaHoaDonBan.Text = "000000";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.txtDoanhThu);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(12, 118);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(415, 61);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Doanh Thu Tháng Này";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(11, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(147, 20);
            this.label2.TabIndex = 16;
            this.label2.Text = "Tổng Doanh Thu:";
            // 
            // txtDoanhThu
            // 
            this.txtDoanhThu.AutoSize = true;
            this.txtDoanhThu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDoanhThu.ForeColor = System.Drawing.Color.DarkRed;
            this.txtDoanhThu.Location = new System.Drawing.Point(156, 25);
            this.txtDoanhThu.Name = "txtDoanhThu";
            this.txtDoanhThu.Size = new System.Drawing.Size(59, 20);
            this.txtDoanhThu.TabIndex = 3;
            this.txtDoanhThu.Text = "00000";
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox3.Controls.Add(this.chartSanPham);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(433, 118);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(534, 377);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Sản Phẩm Bán Chạy Nhất";
            // 
            // chartSanPham
            // 
            chartArea4.Name = "ChartArea1";
            this.chartSanPham.ChartAreas.Add(chartArea4);
            legend4.Name = "Legend1";
            this.chartSanPham.Legends.Add(legend4);
            this.chartSanPham.Location = new System.Drawing.Point(93, 22);
            this.chartSanPham.Name = "chartSanPham";
            series4.ChartArea = "ChartArea1";
            series4.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Bar;
            series4.Legend = "Legend1";
            series4.Name = "Số Lượng";
            this.chartSanPham.Series.Add(series4);
            this.chartSanPham.Size = new System.Drawing.Size(467, 349);
            this.chartSanPham.TabIndex = 0;
            this.chartSanPham.Text = "chart1";
            // 
            // groupBox4
            // 
            this.groupBox4.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox4.Controls.Add(this.cbbDoanhThu);
            this.groupBox4.Controls.Add(this.chartDoanhThu);
            this.groupBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.Location = new System.Drawing.Point(12, 185);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(415, 310);
            this.groupBox4.TabIndex = 5;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Doanh Thu ";
            // 
            // cbbDoanhThu
            // 
            this.cbbDoanhThu.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbDoanhThu.FormattingEnabled = true;
            this.cbbDoanhThu.Items.AddRange(new object[] {
            "Tuần này và Tuần trước",
            "Tháng này và Tháng trước",
            "Năm này và Năm trước"});
            this.cbbDoanhThu.Location = new System.Drawing.Point(99, 0);
            this.cbbDoanhThu.Name = "cbbDoanhThu";
            this.cbbDoanhThu.Size = new System.Drawing.Size(316, 21);
            this.cbbDoanhThu.TabIndex = 6;
            this.cbbDoanhThu.Text = "select";
            this.cbbDoanhThu.SelectedIndexChanged += new System.EventHandler(this.cbbDoanhThu_SelectedIndexChanged);
            // 
            // frmChiTietCuaHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(979, 507);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmChiTietCuaHang";
            this.Text = "frmChiTietCuaHang";
            this.Load += new System.EventHandler(this.frmChiTietCuaHang_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chartDoanhThu)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbHieuSuat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chartSanPham)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chartDoanhThu;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox ptbHieuSuat;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label txtHieuSuat;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label txtSoHoaDonHuy;
        private System.Windows.Forms.Label txtHoaDonHuy;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartSanPham;
        private System.Windows.Forms.Label txtHoaDonBan;
        private System.Windows.Forms.Label txtGiaHoaDonBan;
        private System.Windows.Forms.Label txtTangGiam;
        private System.Windows.Forms.Label txtDoanhThu;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.ComboBox cbbDoanhThu;
    }
}