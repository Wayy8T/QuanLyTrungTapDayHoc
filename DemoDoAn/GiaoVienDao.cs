using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoDoAn
{
    internal class GiaoVienDao
    {
        DBConnection dbConn = new DBConnection();
        public DataTable LayDanhSachGiaoVien()
        {
            string sqlStr = string.Format("SELECT *FROM GIAOVIEN");
            return dbConn.LayDanhSach(sqlStr);
        }
        public void Them(GiaoVien gv)
        {
            string sqlStr = string.Format("INSERT INTO GIAOVIEN(Ten , Diachi, CMND) VALUES ('{0}', '{1}', '{2}')");
            dbConn.ThucThi(sqlStr);
        }
        public void ThemAccout(GiaoVien gv)
        {
            string sqlStr = string.Format("INSERT INTO ACCOUNT(Ten , Diachi, CMND) VALUES ('{0}', '{1}', '{2}')");
            dbConn.ThucThi(sqlStr);
        }

        public void Sua(GiaoVien gv)
        {
            string sqlStr = string.Format("delete from GIAOVIEN where Ten = '{0}'");
            dbConn.ThucThi(sqlStr);
        }

        public void Xoa(GiaoVien gv)
        {
            string sqlStr = string.Format("update GIAOVIEN set Diachi = '{0}' where Ten = '{1}'");
            dbConn.ThucThi(sqlStr);
        }
    }
}
