using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoDoAn
{
    internal class HocSinhDao
    {
        DBConnection dbConn = new DBConnection();

        public DataTable LayDanhSachSinhVien()
        {
            string sqlStr = string.Format("SELECT *FROM HOCSINH");
            return dbConn.LayDanhSach(sqlStr);
        }
        public void ThemAccout(HocSinh hs)
        {
            string sqlStr = string.Format("INSERT INTO ACCOUNTHOCSINH ( USERNAME,PASS_WORD) VALUES ('{0}','{1}')");
            dbConn.ThucThi(sqlStr);
        }

        public void Them(HocSinh hs)
        {
            string sqlStr = string.Format("INSERT INTO Hocsinh(Ten , Diachi, CMND) VALUES ('{0}', '{1}', '{2}')");
            dbConn.ThucThi(sqlStr);
        }

        public void Sua(HocSinh hs)
        {
            string sqlStr = string.Format("delete from HocSinh where Ten = '{0}'");
            dbConn.ThucThi(sqlStr);
        }

        public void Xoa(HocSinh hs)
        {
            string sqlStr = string.Format("update HocSinh set Diachi = '{0}' where Ten = '{1}'");
            dbConn.ThucThi(sqlStr);
        }
    }
}
