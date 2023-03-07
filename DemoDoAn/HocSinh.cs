using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace DemoDoAn
{
    internal class HocSinh
    {
        private int hsid;
        private int accid;
        private string hoten;
        private string cmnd;
        private string gioitinh;
        private DateTime ngaysinh;
        private string sdt;
        private string que;
        private string diachi;
        private Image avarta;

        public int HOCSINH { get { return hsid; } }
        public int ACCID { get { return accid; } }
        public string HOTEN { get { return hoten; } }
        public string CMND { get { return cmnd; } }
        public string GIOITINH { get { return gioitinh; } }
        public DateTime NGAYSINH { get { return ngaysinh; } }
        public string SDT { get { return sdt; } }
        public string QUEQUAN { get { return que; } }
        public string DIACHI { get { return diachi; } }

        public Image AVARTAR { get { return avarta; } }

        public HocSinh()
        { }
    }
}
