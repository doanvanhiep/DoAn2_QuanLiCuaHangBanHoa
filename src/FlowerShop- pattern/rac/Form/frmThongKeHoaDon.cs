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
    public partial class frmThongKeHoaDon : Form
    {
        LinQDataContext dbs = new LinQDataContext();
        public frmThongKeHoaDon()
        {
            InitializeComponent();
        }

        private void frmThongKeHoaDon_Load(object sender, EventArgs e)
        {
            var DSHH = dbs.sp_LoadHoaDon();
            dgvDSHoaDon.DataSource = DSHH.ToList();

        }

        private void dgvDSHoaDon_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int numrow;
            numrow = e.RowIndex;
            if (numrow + 1 > 0)
            {

                frmChiTietHoaDon f = new frmChiTietHoaDon();
                f.idhd = numrow + 1;
                f.Show();
            }
        }
    }
}
