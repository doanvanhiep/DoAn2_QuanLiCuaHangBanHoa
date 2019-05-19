using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
namespace BUS
{
    public class NhanVienQuanLy:ANhanVien
    {
        LinQDataContext dbs = new LinQDataContext();
        protected ANhanVien nvThuNgan;
        protected ANhanVien nvThuKho;

        public NhanVienQuanLy()
        {
            this.nvThuNgan = new NhanVienThuNgan();
            this.nvThuKho = new NhanVienThuKho();
        }

        public override void XoaNhanVien(string strID)
        {
            var del = dbs.sp_DeleteNhanVien(Convert.ToInt32(strID));
            dbs.SubmitChanges();
            
        }
        public override void ThemNhanVien(string txtTenNV, string txtTuoi, string txtUserID, string txtUserPassword,int cboLoaiNV)
        {
            var insert = dbs.sp_insertNhanVien(txtTenNV, txtTuoi, txtUserID, txtUserPassword, Convert.ToInt32(cboLoaiNV));
            dbs.SubmitChanges();
        }
        public override void SuaNhanVien(int strID,string txtTenNV, string txtTuoi, string txtUserID, string txtUserPassword, int cboLoaiNV)
        {
            var updateProduct = dbs.sp_updateNhanVien(Convert.ToInt32(strID), txtTenNV, txtTuoi, txtUserID, txtUserPassword, Convert.ToInt32(cboLoaiNV));
            dbs.SubmitChanges();
        }
        public override string LoadMoTaByID(int id)
        {
            var sqlMoTa = from sp in dbs.SanPhams
                          where sp.IDSP == id
                          select sp.MoTa;
            foreach (var index in sqlMoTa)
                return index.ToString();
            return null;
        }



        public override void SuaSanPham(int strID, string txtTenSP, int txtGiaSP, string txtMoTa)
        {
            var updateProduct = dbs.sp_updateSanPham(Convert.ToInt32(strID), txtTenSP, Convert.ToInt32(txtGiaSP), txtMoTa);
            dbs.SubmitChanges();
        }



        public override void ThemSanPham(string txtTenSP, int txtGiaSP, string txtMoTa)
        {
            var insert = dbs.sp_insertSanPham(txtTenSP, Convert.ToInt32(txtGiaSP), txtMoTa);
            dbs.SubmitChanges();
        }
        public override void XoaSanPham(string strID)
        {
            var del = dbs.sp_DeleteSanPham(Convert.ToInt32(strID));
            dbs.SubmitChanges();
        }

    }
}
