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
    public partial class frmSanPham : Form
    {
        bool Them;
        LinQDataContext dbs = new LinQDataContext();
        BUS.ANhanVien nv = new BUS.NhanVienQuanLy();
        public frmSanPham()
        {
            InitializeComponent();
        }
        private void frmSanPham_Load(object sender, EventArgs e)
        {
            loadData();
            txtMaSP.Enabled = false;
        }

        private void loadData()
        {
            var sql = dbs.sp_LoadSanPham();
            dgvSanPham.DataSource = sql.ToList();

            //
            var sql1 = dbs.sp_LoadSanPham();
            cbbTenSP.DataSource = sql1.ToList();
            cbbTenSP.DisplayMember = "TenSP";
            cbbTenSP.ValueMember = "IDSP";
            //
            resetText();
            grbMota.Enabled = false;
            grbChitiet.Enabled = false;
            btnThem.Enabled = true;
            btnSua.Enabled = true;
            btnXoa.Enabled = true;
            btnLuu.Enabled = false;
        }
        void resetText()
        {
            txtMaSP.ResetText();
            txtTenSP.ResetText();
            txtGiaSP.ResetText();
            txtMoTa.ResetText();        
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            Them = true; // Thêm mới
            grbMota.Enabled = true;
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
            dgvSanPham_CellClick(null, null);
            // Cho phép thao tác trên Panel 
            grbChitiet.Enabled = true;
            grbMota.Enabled = true;

            // Cho thao tác trên các nút Lưu / Hủy / Panel 
            btnLuu.Enabled = true;
            // Không cho thao tác trên các nút Thêm / Xóa / Thoát 
            btnThem.Enabled = false;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            // Đưa con trỏ đến TextField txtTenSP        
            txtTenSP.Focus();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            int r = dgvSanPham.CurrentCell.RowIndex;
            string strID =
                       dgvSanPham.Rows[r].Cells[0].Value.ToString();
            nv.XoaSanPham(strID);
            loadData();
            MessageBox.Show("Đã xóa xong!");
            
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (Them)
            {
                try
                {
                    nv.ThemSanPham(txtTenSP.Text, Convert.ToInt32(txtGiaSP.Text), txtMoTa.Text);                   
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

                int r = dgvSanPham.CurrentCell.RowIndex;
                // MaKH hiện hành
                string strID =
                dgvSanPham.Rows[r].Cells[0].Value.ToString();
                // Câu lệnh SQL
                nv.SuaSanPham(Convert.ToInt32(strID), txtTenSP.Text, Convert.ToInt32(txtGiaSP.Text), txtMoTa.Text);
                loadData();
                // Thông báo
                MessageBox.Show("Đã sửa xong!");

            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvSanPham_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int r = dgvSanPham.CurrentCell.RowIndex;
            // Chuyển thông tin lên panel 
            int id = Convert.ToInt32(dgvSanPham.Rows[r].Cells[0].Value.ToString());
            txtMaSP.Text =
                dgvSanPham.Rows[r].Cells[0].Value.ToString();
            txtTenSP.Text =
                dgvSanPham.Rows[r].Cells[1].Value.ToString();
            txtGiaSP.Text =
               dgvSanPham.Rows[r].Cells[2].Value.ToString();


            txtMoTa.Text = nv.LoadMoTaByID(id);
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            var sql = dbs.sp_LoadSanPhamByID(Convert.ToInt32(cbbTenSP.SelectedValue.ToString()));
            dgvSanPham.DataSource = sql.ToList();
        }
    }
}
