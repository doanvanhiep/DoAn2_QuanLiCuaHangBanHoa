using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace rac
{
    public partial class frmLogin : Form
    {
        
        public frmLogin()
        {
            InitializeComponent();
        }
        LinQDataContext dbs = new LinQDataContext();
        private void txtUserID_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
                txtPassword.Focus();
        }

        private void txtPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
                btnDangNhap.Focus();
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {

            frmMain main = new frmMain();
            
            if (dbs.checkAccount(txtUserID.Text,txtPassword.Text).Equals(1))
            {
                
                var info = from id in dbs.NhanViens
                           where id.UserID== txtUserID.Text && id.UserPassword==txtPassword.Text
                           select id.IDNV;

                foreach (var a in info)
                    main.idnv = a.ToString();
                this.Hide();
                main.ShowDialog();
                Application.Exit();
            }
            else
            {
                MessageBox.Show("Không đúng tên người dùng / mật khẩu !!!",
                    "Thông báo", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                txtUserID.Focus();
            }
        }

        private void btnDangKy_Click(object sender, EventArgs e)
        {
            Form frm = new frmChangePassword();
            frm.ShowDialog();
        }
    }
}
