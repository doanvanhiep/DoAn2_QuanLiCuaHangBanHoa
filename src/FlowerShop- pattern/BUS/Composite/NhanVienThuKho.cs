using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
namespace BUS
{
    public class NhanVienThuKho:ANhanVien
    {
        LinQDataContext dbs = new LinQDataContext();

        public override void ThemKhoHang(int txtCBBTenSP, int txtCBBTenNV, string txtNgayNhap, string txtNgayHetHan, int txtSoLuong, int txtGiaNhap)
        {
            var insert = dbs.sp_insertKhoHang(Convert.ToInt32(txtCBBTenSP),
                        Convert.ToInt32(txtCBBTenNV),
                        txtNgayNhap, txtNgayHetHan, Convert.ToInt32(txtSoLuong),
                        Convert.ToInt32(txtGiaNhap));
            dbs.SubmitChanges();
        }
        public override void SuaKhoHang(int strID, int txtCBBTenSP, int txtCBBTenNV, string txtNgayNhap, string txtNgayHetHan, int txtSoLuong, int txtGiaNhap)
        {
            var updateProduct = dbs.sp_updateKhoHang(Convert.ToInt32(strID), Convert.ToInt32(txtCBBTenSP),
                    Convert.ToInt32(txtCBBTenNV), txtNgayNhap, txtNgayHetHan,
                    Convert.ToInt32(txtSoLuong), Convert.ToInt32(txtGiaNhap));
            dbs.SubmitChanges();
        }
        public override void XoaKhoHang(string strID)
        {
            var del = dbs.sp_DeleteKhoHang(Convert.ToInt32(strID));
            dbs.SubmitChanges();
        }
    }
}
