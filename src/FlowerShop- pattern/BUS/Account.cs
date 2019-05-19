using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
namespace BUS
{
    public class Account
    {
        LinQDataContext dbs = new LinQDataContext();
        public string CheckPassWord(string idnv)
        {
            var checkPassword = from nv in dbs.NhanViens
                                where nv.IDNV == Convert.ToInt32(idnv)
                                select nv.UserPassword;
            foreach (var index in checkPassword)
                return index.ToString();
            return null;
        } 
    }
}
