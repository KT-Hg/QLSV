using QLSV.DAO;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLSV.DAO
{
    public class AccountDAO
    {
        private static AccountDAO instance;

        public static AccountDAO Instance
        {
            get { if (instance == null) instance = new AccountDAO(); return AccountDAO.instance; }
            private set { AccountDAO.instance = value; }
        }

        private AccountDAO() { }

        public bool login(string username, string password)
        {
            object[] parameterSV = { username, Encryption.Instance.CalculateMD5(password) };
            object[] parameterNV = { username, Encryption.Instance.CalculateSHA1(password) };
            int countSinhVien = 0;
            int countNhanVien = 0;
            string query = "";
            query = "SELECT COUNT(*) FROM SINHVIEN WHERE TENDN = @Username AND MATKHAU = CONVERT(VARBINARY(MAX), @Password , 2)";
            countSinhVien = (int)DataProvider.Instance.ExecuteScalar(query, parameterSV);
            query = "SELECT COUNT(*) FROM NHANVIEN WHERE TENDN = @Username AND MATKHAU = CONVERT(VARBINARY(MAX), @Password , 2)";
            countNhanVien = (int)DataProvider.Instance.ExecuteScalar(query, parameterNV);

            if (countSinhVien > 0 || countNhanVien > 0)
            {
                return true;
            }
            return false;
        }
    }
}
