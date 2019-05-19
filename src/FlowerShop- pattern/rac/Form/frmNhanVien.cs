using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DAL;
using BUS;
namespace rac
{
    public partial class frmNhanVien : Form
    {
        bool Them;
        LinQDataContext dbs = new LinQDataContext();
        BUS.NhanVienQuanLy nhanvien = new BUS.NhanVienQuanLy();
        BUS.NhanVien nv;
        public frmNhanVien()
        {
            InitializeComponent();
        }

        private void frmNhanVien_Load(object sender, EventArgs e)
        {
            loadData();
            txtMaNV.Enabled = false;
        }
        void loadData()
        {
            var sql = dbs.sp_LoadNhanVien();
            dgvNhanVien.DataSource = sql.ToList();

            var sql1 = from lnv in dbs.LoaiNhanViens
                       select lnv;
            cboLoaiNV.DataSource = sql1.ToList();
            cboLoaiNV.DisplayMember = "LoaiNV";
            cboLoaiNV.ValueMember = "IDLoaiNV";
            //
            var sql2 = from lnv in dbs.LoaiNhanViens
                       select lnv;
            txtCBBTKLoaiNV.DataSource = sql2.ToList();
            txtCBBTKLoaiNV.DisplayMember = "LoaiNV";
            txtCBBTKLoaiNV.ValueMember = "IDLoaiNV";
            //
            resetText();
            grbChitiet.Enabled = false;
            btnThem.Enabled = true;
            btnSua.Enabled = true;
            btnXoa.Enabled = true;
            btnLuu.Enabled = false;
            dgvNhanVien_CellClick(null, null);
            
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            Them = true; // Thêm mới
            grbChitiet.Enabled = true;
            resetText();


            // Cho thao tác trên các nút Lưu  
            btnLuu.Enabled = true;
            // Không cho thao tác trên các nút Thêm / Xóa / Thoát 
            btnThem.Enabled = false;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            Them = false; // Sửa dữ liệu
            dgvNhanVien_CellClick(null, null);
            // Cho phép thao tác trên Panel 
            grbChitiet.Enabled = true;
            // Cho thao tác trên các nút Lưu / Hủy / Panel 
            btnLuu.Enabled = true;
            // Không cho thao tác trên các nút Thêm / Xóa / Thoát 
            btnThem.Enabled = false;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            // Đưa con trỏ đến TextField txtTenCty            
            txtTenNV.Focus();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {            
            int r = dgvNhanVien.CurrentCell.RowIndex;
            string strID =
                       dgvNhanVien.Rows[r].Cells[0].Value.ToString();
            nhanvien.XoaNhanVien(strID);
            loadData();
            MessageBox.Show("Đã xóa xong!");  
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtMaNV.Text))
                txtMaNV.Text = "-1";
            nv = new NhanVienBuilder(Convert.ToInt32(txtMaNV.Text), Convert.ToInt32(cboLoaiNV.SelectedValue))
                .withTenNV(txtTenNV.Text)
                .withTuoiNV(txtTuoi.Text)
                .withUserID(txtUserID.Text)
                .withUserPassWord(txtUserPassword.Text)
                .build();

            if (string.IsNullOrWhiteSpace(txtTenNV.Text))
            {
                nv = new NhanVienBuilder(Convert.ToInt32(txtMaNV.Text), Convert.ToInt32(cboLoaiNV.SelectedValue))
                .withTuoiNV(txtTuoi.Text)
                .withUserID(txtUserID.Text)
                .withUserPassWord(txtUserPassword.Text)
                .build();
            }
            if (string.IsNullOrWhiteSpace(txtTuoi.Text))
            {
                nv = new NhanVienBuilder(Convert.ToInt32(txtMaNV.Text), Convert.ToInt32(cboLoaiNV.SelectedValue))
                 .withTenNV(txtTenNV.Text)
                 .withUserID(txtUserID.Text)
                 .withUserPassWord(txtUserPassword.Text)
                 .build();
            }
            
            if (Them)
            {
                try
                {
                    nhanvien.ThemNhanVien(nv.TenNV1, nv.TuoiNV1, nv.UserID1, nv.UserPassword1, nv.IDLoaiNV1);
                    //nhanvien.ThemNhanVien(txtTenNV.Text, txtTuoi.Text, txtUserID.Text, txtUserPassword.Text, Convert.ToInt32(cboLoaiNV.SelectedValue));                 
                    loadData();
                    MessageBox.Show("Đã thêm xong!");                  
                }
                catch (Exception)
                {
                    MessageBox.Show("Không thêm được. Lỗi rồi!!!");
                }

            }
            else // sua doi
            {
                try
                {
                    int r = dgvNhanVien.CurrentCell.RowIndex;
                    // MaKH hiện hành
                    string strID =
                    dgvNhanVien.Rows[r].Cells[0].Value.ToString();
                    // Câu lệnh SQL
                    nhanvien.SuaNhanVien(nv.IDNV1, nv.TenNV1, nv.TuoiNV1, nv.UserID1, nv.UserPassword1, nv.IDLoaiNV1);
                    //nhanvien.SuaNhanVien(Convert.ToInt32(strID), txtTenNV.Text, txtTuoi.Text, txtUserID.Text, txtUserPassword.Text, Convert.ToInt32(cboLoaiNV.SelectedValue));
                    loadData();
                    // Thông báo
                    MessageBox.Show("Đã sửa xong!");
                }
                catch (Exception)
                {
                    MessageBox.Show("Không sửa được. Lỗi rồi!!!");
                }

            }

        }
    
        void resetText()
        {
            txtMaNV.ResetText();
            txtTenNV.ResetText();
            txtTuoi.ResetText();
            txtUserID.ResetText();
            txtUserPassword.ResetText();
        }
        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvNhanVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
           
            int r = dgvNhanVien.CurrentCell.RowIndex;
            // Chuyển thông tin lên panel 
            int id =Convert.ToInt32(dgvNhanVien.Rows[r].Cells[0].Value.ToString());
            txtMaNV.Text =
                dgvNhanVien.Rows[r].Cells[0].Value.ToString();
            txtTenNV.Text =
                dgvNhanVien.Rows[r].Cells[1].Value.ToString();
            cboLoaiNV.Text =
               dgvNhanVien.Rows[r].Cells[2].Value.ToString();
    
            var sqlNhanVien = from nv in dbs.NhanViens
                              where nv.IDNV == id
                              select nv;
            foreach (var index in sqlNhanVien)
            {
                txtTuoi.Text = index.TuoiNV;
                txtUserID.Text = index.UserID;
                txtUserPassword.Text = index.UserPassword;
            }
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            var sql = dbs.sp_LoadNhanVienByType(Convert.ToInt32(txtCBBTKLoaiNV.SelectedValue.ToString()), txtTKTenNV.Text);
            dgvNhanVien.DataSource = sql.ToList();
            txtTKTenNV.ResetText();
        }
    }
}
