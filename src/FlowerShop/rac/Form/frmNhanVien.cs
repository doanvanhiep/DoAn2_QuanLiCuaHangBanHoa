using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace rac
{
    public partial class frmNhanVien : Form
    {
        bool Them;
        LinQDataContext dbs = new LinQDataContext();
        
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

            var sql1 = dbs.sp_LoadNhanVien();
            cboLoaiNV.DataSource = sql1.ToList();
            cboLoaiNV.DisplayMember = "LoaiNV";
            cboLoaiNV.ValueMember = "IDLoaiNV";
            //
            resetText();
            grbChitiet.Enabled = false;
            btnThem.Enabled = true;
            btnSua.Enabled = true;
            btnXoa.Enabled = true;
            btnLuu.Enabled = false;
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
            var del = dbs.sp_DeleteNhanVien(Convert.ToInt32(strID));
            dbs.SubmitChanges();
            loadData();
            MessageBox.Show("Đã xóa xong!");  
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (Them)
            {
                try
                {
                    var insert = dbs.sp_insertNhanVien(txtTenNV.Text, Convert.ToInt32( txtTuoi.Text),txtUserID.Text,txtUserPassword.Text,Convert.ToInt32(cboLoaiNV.SelectedValue));
                    dbs.SubmitChanges();
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

                int r = dgvNhanVien.CurrentCell.RowIndex;
                // MaKH hiện hành
                string strID =
                dgvNhanVien.Rows[r].Cells[0].Value.ToString();
                // Câu lệnh SQL
                var updateProduct = dbs.sp_updateNhanVien(Convert.ToInt32(strID), txtTenNV.Text, Convert.ToInt32(txtTuoi.Text),txtUserID.Text,txtUserPassword.Text, Convert.ToInt32(cboLoaiNV.SelectedValue));
                dbs.SubmitChanges();
                loadData();
                // Thông báo
                MessageBox.Show("Đã sửa xong!");

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
    }
}
