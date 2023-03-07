using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DemoDoAn
{
    public partial class Fadmin : Form
    {
        AdminDao adminDao=new AdminDao();
        GiaoVienDao giaovienDao=new GiaoVienDao();
        HocSinhDao hocsinhDao=new HocSinhDao();
        public Fadmin()
        {
            InitializeComponent();
        }

        private void btnHocSinh_Click(object sender, EventArgs e)
        {
            this.dataGridViewAdmin.DataSource = hocsinhDao.LayDanhSachSinhVien();
        }

        private void btnGiaoVien_Click(object sender, EventArgs e)
        {
            this.dataGridViewAdmin.DataSource= giaovienDao.LayDanhSachGiaoVien();
        }
    }
}
