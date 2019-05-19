using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class NhanVienBuilder
    {
        private int IDNV;//required
        private int IDLoaiNV;//required
        private string TenNV;
        private string TuoiNV;
        private string UserID;
        private string UserPassword;

        public NhanVienBuilder(int iDNV, int iDLoaiNV)
        {
            this.IDNV = iDNV;
            this.IDLoaiNV = iDLoaiNV;
            //this.TenNV = null;
            //this.TuoiNV = null;
            this.UserID = "";
            this.UserPassword = "";

        }
        public NhanVienBuilder withTenNV(string tennv)
        {
            this.TenNV = tennv;
            return this;
        }
        public NhanVienBuilder withTuoiNV(string tuoinv)
        {
            this.TuoiNV = tuoinv;
            return this;
        }
        public NhanVienBuilder withUserID(string userid)
        {
            this.UserID = userid;
            return this;
        }
        public NhanVienBuilder withUserPassWord(string userpass)
        {
            this.UserPassword = userpass;
            return this;
        }
        public NhanVien build()
        {
            NhanVien nhanVien = new NhanVien(this.IDNV, this.TenNV, this.TuoiNV, this.UserID, this.UserPassword, this.IDLoaiNV);
            return nhanVien;
        }

        
    }
}
