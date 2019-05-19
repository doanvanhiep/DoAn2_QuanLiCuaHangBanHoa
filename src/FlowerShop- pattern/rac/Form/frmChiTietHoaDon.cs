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
    public partial class frmChiTietHoaDon : Form
    {
        public int idhd;
        public frmChiTietHoaDon()
        {
            InitializeComponent();
        }
        LinQDataContext dbs = new LinQDataContext();
        private void frmChiTietHoaDon_Load(object sender, EventArgs e)
        {
            var DSCT = dbs.sp_LoadHoaDonChiTietbyIDHoaDon(idhd);
            dgvDSHoaDonChiTiet.DataSource = DSCT.ToList();
        }
    }
}
