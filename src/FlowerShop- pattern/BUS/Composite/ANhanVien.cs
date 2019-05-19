using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
namespace BUS
{
    public abstract class ANhanVien
    {
        LinQDataContext dbs = new LinQDataContext();



        public virtual void XoaNhanVien(string strID) { }

        public virtual void ThemNhanVien(string txtTenNV, string txtTuoi, string txtUserID, string txtUserPassword, int cboLoaiNV) { }

        public virtual void SuaNhanVien(int strID, string txtTenNV, string txtTuoi, string txtUserID, string txtUserPassword, int cboLoaiNV) { }
        public virtual void ThemSanPham(string txtTenSP, int txtGiaSP, string txtMoTa) { }
        public virtual void SuaSanPham(int strID, string txtTenSP, int txtGiaSP, string txtMoTa) { }
        
        public virtual void XoaSanPham(string strID) { }
        
        public virtual string LoadMoTaByID(int id) { return null; }
        public int LoadLoaiNV(int idnv)
        {
            var loainv = from a in dbs.NhanViens
                         where a.IDNV == idnv
                         select a.IDLoaiNV;
            return Convert.ToInt32(loainv.First().ToString());
        }
        public virtual void ThemKhoHang(int txtCBBTenSP, int txtCBBTenNV, string txtNgayNhap, string txtNgayHetHan, int txtSoLuong, int txtGiaNhap)
        {
          
        }
        public virtual void SuaKhoHang(int strID, int txtCBBTenSP, int txtCBBTenNV, string txtNgayNhap, string txtNgayHetHan, int txtSoLuong, int txtGiaNhap)
        {
          
        }
        public virtual void XoaKhoHang(string strID)
        {
           
        }
        public virtual void InHoaDon(DataTable dt, string sheetName, string title) {  }
        public virtual void LuuChiTietHoaDon(int idhoadon,int idsp,int sl,int dongia)
        {
            
        }
    }
}
