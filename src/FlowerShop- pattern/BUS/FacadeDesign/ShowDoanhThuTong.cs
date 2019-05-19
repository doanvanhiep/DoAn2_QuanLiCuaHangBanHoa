using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
namespace BUS
{
    public class ShowDoanhThuTong
    {
        LinQDataContext dbs = new LinQDataContext();
        public double Show1Thang()
        {
            double count = 0;
            var sql = dbs.sp_LoadDoanhThuThangByCount(1);
            foreach (var index in sql)
                count += Convert.ToDouble(index.Gia.ToString())* Convert.ToDouble(index.SoLuong);
            return count;
        }
        public double Show1Nam()
        {
            double count = 0;
            var sql = dbs.sp_LoadDoanhThuThangByCount(12);
            foreach (var index in sql)
                count += Convert.ToDouble(index.Gia.ToString()) * Convert.ToDouble(index.SoLuong);
            return count;
        }
    }
}
