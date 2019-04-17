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
    public partial class frmKhoHang : Form
    {
        bool Them;
        LinQDataContext dbs = new LinQDataContext();
        public frmKhoHang()
        {
            InitializeComponent();
        }
        void loadData()
        {
            var sql = dbs.sp_LoadKhoHang();
            dgvKhoHang.DataSource = sql.ToList();
            var sql1 = dbs.sp_LoadSanPham();
            txtCBBTenSP.DataSource = sql1.ToList();
            txtCBBTenSP.DisplayMember = "TenSP";
            txtCBBTenSP.ValueMember = "IDSP";
            //
            resetText();
            grbChitiet.Enabled = false;
            btnThem.Enabled = true;
            btnSua.Enabled = true;
            btnXoa.Enabled = true;
            btnLuu.Enabled = false;
            txtNgayNhap.Mask = "00/00/0000";
            txtNgayHetHan.Mask = "00/00/0000";
        }

        private void resetText()
        {
            txtSTT.ResetText();
            txtCBBTenSP.ResetText();
            txtNgayHetHan.ResetText();
            txtNgayNhap.ResetText();
            txtSoLuong.ResetText();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            Them = true; // Thêm mới
            grbChitiet.Enabled = true;
            resetText();

            txtCBBTenSP.Enabled = true;
            // Cho thao tác trên các nút Lưu  
            btnLuu.Enabled = true;
            // Không cho thao tác trên các nút Thêm / Xóa / Thoát 
            btnThem.Enabled = false;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            txtNgayNhap.Mask = "00/00/0000";
            txtNgayHetHan.Mask = "00/00/0000";
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            Them = false; // Sửa dữ liệu
            dgvKhoHang_CellClick(null, null);
            // Cho phép thao tác trên Panel 
            grbChitiet.Enabled = true;
            // Cho thao tác trên các nút Lưu / Hủy / Panel 
            btnLuu.Enabled = true;
            // Không cho thao tác trên các nút Thêm / Xóa / Thoát 
            btnThem.Enabled = false;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            // Đưa con trỏ đến TextField txtTenCty            
            txtNgayNhap.Focus();         
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            int r = dgvKhoHang.CurrentCell.RowIndex;
            string strID =
                       dgvKhoHang.Rows[r].Cells[0].Value.ToString();            
            var del = dbs.sp_DeleteKhoHang(Convert.ToInt32(strID));
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
                    var insert = dbs.sp_insertKhoHang(Convert.ToInt32(txtCBBTenSP.SelectedValue.ToString()), txtNgayNhap.Text, txtNgayHetHan.Text, Convert.ToInt32(txtSoLuong.Text));
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

                int r = dgvKhoHang.CurrentCell.RowIndex;
                // MaKH hiện hành
                string strID =
                dgvKhoHang.Rows[r].Cells[0].Value.ToString();
                
                // Câu lệnh SQL
                var updateProduct = dbs.sp_updateKhoHang(Convert.ToInt32(strID),Convert.ToInt32(txtCBBTenSP.SelectedValue), txtNgayNhap.Text, txtNgayHetHan.Text, Convert.ToInt32(txtSoLuong.Text));
                dbs.SubmitChanges();
                loadData();
                // Thông báo
                MessageBox.Show("Đã sửa xong!");

            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvKhoHang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int r = dgvKhoHang.CurrentCell.RowIndex;
            // Chuyển thông tin lên panel 
            int id = Convert.ToInt32(dgvKhoHang.Rows[r].Cells[0].Value.ToString());
            txtSTT.Text =
                dgvKhoHang.Rows[r].Cells[0].Value.ToString();
            txtCBBTenSP.Text =
                dgvKhoHang.Rows[r].Cells[1].Value.ToString();
            txtNgayNhap.Mask="";
            txtNgayHetHan.Mask = "";
            txtNgayNhap.Text =
                dgvKhoHang.Rows[r].Cells[2].Value.ToString();
            txtNgayHetHan.Text =
                dgvKhoHang.Rows[r].Cells[3].Value.ToString();
            txtSoLuong.Text =
               dgvKhoHang.Rows[r].Cells[4].Value.ToString();
           
        }

        private void frmKhoHang_Load(object sender, EventArgs e)
        {
            loadData();
            txtSTT.Enabled = false;
            txtCBBTenSP.Enabled = false;
        }
    }
}
