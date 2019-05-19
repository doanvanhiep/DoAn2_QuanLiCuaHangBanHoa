using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
namespace BUS
{
    public class ShowHieuSuatDoanhThu
    {
        LinQDataContext dbs = new LinQDataContext();
        public double[] HieuXuatThang()
        {
            double[] hieuxuatdoanhthu = new double[2] { 0 ,0};
            var thangnay = dbs.sp_LoadDoanhThuThang();
            foreach (var index in thangnay)
                hieuxuatdoanhthu[0] += Convert.ToDouble(index.Gia.ToString())* Convert.ToDouble(index.SoLuong);

            var thangtruoc = dbs.sp_LoadDoanhThuThangTruoc();
            foreach (var index in thangtruoc)
                hieuxuatdoanhthu[1] += Convert.ToDouble(index.Gia.ToString()) * Convert.ToDouble(index.SoLuong);

            return hieuxuatdoanhthu;
        }
        public double[] HieuXuatTuan()
        {
            double[] hieuxuatdoanhthu = new double[2] { 0, 0 };
            var tuannay = dbs.sp_LoadDoanhThuTuan();
            foreach (var index in tuannay)
                hieuxuatdoanhthu[0] += Convert.ToDouble(index.Gia.ToString()) * Convert.ToDouble(index.SoLuong);

            var tuantruoc = dbs.sp_LoadDoanhThuTuanTruoc();
            foreach (var index in tuantruoc)
                hieuxuatdoanhthu[1] += Convert.ToDouble(index.Gia.ToString()) * Convert.ToDouble(index.SoLuong);

            return hieuxuatdoanhthu;
        }
        public double[] HieuXuatNam()
        {
            double[] hieuxuatdoanhthu = new double[2] { 0, 0 };
            var namnay = dbs.sp_LoadDoanhThuNam();
            foreach (var index in namnay)
                hieuxuatdoanhthu[0] += Convert.ToDouble(index.Gia.ToString()) * Convert.ToDouble(index.SoLuong);

            var namtruoc = dbs.sp_LoadDoanhThuNamTruoc();
            foreach (var index in namtruoc)
                hieuxuatdoanhthu[1] += Convert.ToDouble(index.Gia.ToString()) * Convert.ToDouble(index.SoLuong);

            return hieuxuatdoanhthu;
        }
    }
}
