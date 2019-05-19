using System;
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

            
            
            if (dbs.checkAccount(txtUserID.Text,txtPassword.Text).Equals(1))
            {
                Login lg = new Login();

                frmMain main = new frmMain();
                main.idnv = lg.findIDNVLogin(txtUserID.Text, txtPassword.Text);
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


    }
}
