using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class ShopFacade
    {
        private static ShopFacade INSTANCE = new ShopFacade();
       
        private ShowDoanhThuTong showDoanhThu;
        private ShowHieuSuatDoanhThu showHieuXuat;

     
        private ShopFacade()
        {
            showDoanhThu = new ShowDoanhThuTong();
            showHieuXuat = new ShowHieuSuatDoanhThu();
        }
        public static ShopFacade getInstance()
        {
            return INSTANCE;
        }
        public double[] ShowDoanhThuThangVaHieuSuatThang()
        {
            double[] mangchua = new double[3] { 0,0 ,0};
            mangchua[0] = showDoanhThu.Show1Thang();
            mangchua[1] = showHieuXuat.HieuXuatThang()[0];
            mangchua[2]= showHieuXuat.HieuXuatThang()[1];
            return mangchua;
        }
        public double[] ShowDoanhThuNamVaHieuSuatNam()
        {
            double[] mangchua = new double[3] { 0, 0, 0 };
            mangchua[0] = showDoanhThu.Show1Nam();
            mangchua[1] = showHieuXuat.HieuXuatNam()[0];
            mangchua[2] = showHieuXuat.HieuXuatNam()[1];
            return mangchua;
        }
        public double[] ShowDoanhThuThangVaHieuXuatTuan()
        {
            double[] mangchua = new double[3] { 0, 0, 0 };
            mangchua[0] = showDoanhThu.Show1Thang();
            mangchua[1] = showHieuXuat.HieuXuatTuan()[0];
            mangchua[2] = showHieuXuat.HieuXuatTuan()[1];
            return mangchua;
        }
    }
}
