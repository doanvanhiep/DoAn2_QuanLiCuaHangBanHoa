using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
namespace BUS
{
    public class Login
    {
        LinQDataContext dbs = new LinQDataContext();
        public string findIDNVLogin(string userid, string userpass)
        {
            var info = from id in dbs.NhanViens
                       where id.UserID == userid && id.UserPassword == userpass
                       select id.IDNV;

            foreach (var a in info)
                return a.ToString();
            return null;
        }
    }
}
