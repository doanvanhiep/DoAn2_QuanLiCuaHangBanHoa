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
    public partial class frmChiTietCuaHang : Form
    {
        LinQDataContext dbs = new LinQDataContext();
        public frmChiTietCuaHang()
        {
            InitializeComponent();
        }

        private void frmChiTietCuaHang_Load(object sender, EventArgs e)
        {
            var sql = dbs.sp_LoadSanPham();
            
            chart.DataSource = sql.ToList();
            chart.Series["Gia"].XValueMember = "TenSP";
            chart.Series["Gia"].YValueMembers = "Gia";
            //chart.DataBind();


        }
    }
}
