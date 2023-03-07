using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Drawing;

namespace DemoDoAn
{
    internal class GiaoVien
    {
        private int gvid;
        private int accid;
        private string hoten;
        private string cmnd;
        private string gioitinh;
        private DateTime ngaysinh;
        private string sdt;
        private string que;
        private string diachi;
        private string truongdaotao;
        private string trinhdo;
        private string uudiem;
        private Image avarta;

        public int GIAOVIEN { get { return gvid; } }
        public int ACCID { get { return accid; } }
        public string HOTEN { get { return hoten; } }
        public string CMND { get { return cmnd; } }
        public string GIOITINH { get { return gioitinh; } }
        public DateTime NGAYSINH { get { return ngaysinh; } }
        public string SDT { get { return sdt; } }
        public string QUEQUAN { get { return que; } }
        public string DIACHI { get { return diachi; } }
        public string TRUONGDAOTAO { get { return truongdaotao; } }
        public string TRINHDO { get { return trinhdo; } }
        private string UUDIEM { get { return uudiem; } }
        public Image AVARTAR { get { return avarta; } }

        public GiaoVien()
        { }
    }
}
