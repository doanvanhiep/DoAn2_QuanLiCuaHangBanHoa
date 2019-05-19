using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
namespace BUS
{
    public class ChiTietCuaHang
    {
        LinQDataContext dbs = new LinQDataContext();
        private double[] mang;
  

        public double[] Mang { get => mang; set => mang = value; }
      
        public void LoadFacade()
        {
            this.mang = new double[3] { 0, 0 ,0};          
            this.mang=ShopFacade.getInstance().ShowDoanhThuThangVaHieuSuatThang();

        }
        public double loadGiaHoaDonNgayHienTai()
        {
            double countGiaNgayHienTai = 0;
            var giahd = dbs.sp_LoadGiaHoaDon();
            
            foreach (var index in giahd)
            {
                countGiaNgayHienTai += Convert.ToDouble(index.Gia.ToString()) * Convert.ToDouble(index.SoLuong);
            }
            return countGiaNgayHienTai;
        }
        public int loadSoLuong()
        {
            var giahd = dbs.sp_LoadGiaHoaDon();
            int countSL = 0;
            int id = 0;
            foreach (var index in giahd)
            {

                if (id != index.IDHoaDon)
                    countSL++;
                id = index.IDHoaDon;
                //countGiaNgayHienTai += Convert.ToDouble(index.Gia.ToString()) * Convert.ToDouble(index.SoLuong);
            }
            return countSL;
        }
        public double loadGiaHomQua()
        {
            double countGiaNgayHomQua = 0;
            var ngayhomqua = dbs.sp_LoadHoaDonNgayTruoc();
            foreach (var index in ngayhomqua)
            {
                countGiaNgayHomQua += Convert.ToDouble(index.Gia.ToString()) * Convert.ToDouble(index.SoLuong);
            }
            return countGiaNgayHomQua;
        }
        public string loadHDHuy()
        {
            string sl = "0";
            var hdhuy = dbs.sp_LoadHoaDonHuy();
            foreach (var index in hdhuy)
                sl = index.sl.ToString();
            return sl;
        }
        public string doanhThuThangNay()
        {
            double countDoanhThu = 0;
            var doạnhthu = dbs.sp_LoadDoanhThuThang();
            foreach (var index in doạnhthu)
            {
                countDoanhThu += Convert.ToDouble(index.Gia.ToString()) * Convert.ToDouble(index.SoLuong);
            }
            return countDoanhThu.ToString() + " Đ";
        }
        public double tinhToan(double a,double b)
        {
            return a * b;
        }


    }
}
