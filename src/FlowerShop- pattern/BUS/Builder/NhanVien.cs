using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class NhanVien
    {
        private int IDNV;//required
        private string TenNV;
        private string TuoiNV;
        private string UserID;
        private string UserPassword;
        private int IDLoaiNV;//required

        public NhanVien(int iDNV, string tenNV, string tuoiNV, string userID, string userPassword, int iDLoaiNV)
        {
            this.IDNV = iDNV;
            this.TenNV = tenNV;
            this.TuoiNV = tuoiNV;
            this.UserID = userID;
            this.UserPassword = userPassword;
            this.IDLoaiNV = iDLoaiNV;
        }

        public int IDNV1 { get => IDNV; set => IDNV = value; }
        public string TenNV1 { get => TenNV; set => TenNV = value; }
        public string TuoiNV1 { get => TuoiNV; set => TuoiNV = value; }
        public string UserID1 { get => UserID; set => UserID = value; }
        public string UserPassword1 { get => UserPassword; set => UserPassword = value; }
        public int IDLoaiNV1 { get => IDLoaiNV; set => IDLoaiNV = value; }

        public override string ToString()
        {
            return "nhanvien [id=" + IDNV + ", ten=" + TenNV + ", tuoi=" + TuoiNV + ",idU ="
                + UserID + ", pass=" + UserPassword + ", loai=" + IDLoaiNV + "]";
        }
    }

}
