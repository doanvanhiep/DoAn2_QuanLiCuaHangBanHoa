﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DAL;
using BUS;
namespace rac
{
    public partial class frmChangePassword : Form
    {
        LinQDataContext dbs = new LinQDataContext();
        public String idnv;
        public frmChangePassword()
        {
            InitializeComponent();
        }

        private void btnXacNhan_Click(object sender, EventArgs e)
        {
            Account acc = new Account();
            string password = acc.CheckPassWord(idnv);
           
                if (txtPassword.Text != password)
                {
                    MessageBox.Show("Mật khẩu không đúng!! Xin nhập lại");
                    txtPassword.ResetText();
                    txtPassword.Focus();
                    txtConfirmNewPassword.ResetText();
                    txtNewpassword.ResetText();
                }
                else if(txtConfirmNewPassword.Text!=txtNewpassword.Text)
                {
                    MessageBox.Show("Mật khẩu xác nhận phải giống mật khẩu mới !! Xin nhập lại");
                    txtPassword.ResetText();
                    txtPassword.Focus();
                    txtConfirmNewPassword.ResetText();
                    txtNewpassword.ResetText();
                }
                else
                {
                    dbs.sp_updatePasswordNhanVien(Convert.ToInt32(idnv), txtConfirmNewPassword.Text);
                    MessageBox.Show("Đã đổi xong !!");
                    this.Close();
                }
            
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
