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
    public partial class frmHetHan : Form
    {
        LinQDataContext dbs = new LinQDataContext();
        public frmHetHan()
        {
            InitializeComponent();
        }

        private void frmHetHan_Load(object sender, EventArgs e)
        {
            var DSHH = dbs.sp_LoadDSHetHan();
            dgvDSSPSapHetHan.DataSource = DSHH.ToList();
        }
    }
}
