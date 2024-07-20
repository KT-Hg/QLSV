using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using System.Xml.Linq;

namespace QLSV.DAO
{
    public class EmployeeManagerDAO
    {
        private static EmployeeManagerDAO instance;

        public static EmployeeManagerDAO Instance
        {
            get { if (instance == null) instance = new EmployeeManagerDAO(); return EmployeeManagerDAO.instance; }
            private set { EmployeeManagerDAO.instance = value; }
        }

        private EmployeeManagerDAO() { }

        private int option = 0;
        private const string KEY = "21120456";

        public int getOption() { return this.option; }

        public void setOption(int option) { this.option = option; }

        public DataTable GetDataEmployeeAES()
        {
            DataTable data = new DataTable();
            string query = "EXEC SP_SEL_ENCRYPT_NHANVIEN";
            data = DataProvider.Instance.ExecuteQuery(query);
            data.Columns[0].ColumnName = "MÃ NHÂN VIÊN";
            data.Columns[1].ColumnName = "HỌ TÊN";
            data.Columns.Add("LƯƠNG", typeof(string));
            foreach (DataRow row in data.Rows)
            {
                byte[] bytesSalary = (byte[])row[3];
                row[4] = Encryption.Instance.DecryptAES(bytesSalary, Encryption.Instance.GenKeyAES(KEY));
            }
            data.Columns.RemoveAt(3);
            return data;
        }

        public int insert(object[] parameter = null)
        {
            int result = 0;
            parameter[3] = BitConverter.ToString(Encryption.Instance.EncryptAES((string)parameter[3]
                , Encryption.Instance.GenKeyAES(KEY))).Replace("-", "");
            parameter[5] = Encryption.Instance.CalculateSHA1((string)parameter[5]);
            string query = "EXEC SP_INS_ENCRYPT_NHANVIEN @id , @name , @email , @salary , @username , @password";
            result = DataProvider.Instance.ExecuteNonQuery(query, parameter);
            return result;
        }

        public int insertRSA(object[] parameter = null)
        {
            int result = 0;

            parameter[3] = BitConverter.ToString(Encryption.Instance.EncryptRSA((string)parameter[3]
                , (string)parameter[5])).Replace("-", "");

            parameter[5] = Encryption.Instance.CalculateSHA1((string)parameter[5]);
            Array.Resize(ref parameter, parameter.Length + 1);
            parameter[parameter.Length - 1] = parameter[0];

            string query = "EXEC SP_INS_PUBLIC_ENCRYPT_NHANVIEN @id , @name , @email , @salary , @username , @password , @pubkey";
            result = DataProvider.Instance.ExecuteNonQuery(query, parameter);
            return result;
        }

        public DataTable GetDataEmployeeRSA(object[] parameter = null)
        {
            object[] newParameter = { parameter[4] , Encryption.Instance.CalculateSHA1((string)parameter[5]) };
            DataTable data = new DataTable();
            string query = "EXEC SP_SEL_PUBLIC_ENCRYPT_NHANVIEN @username , @password";
            data = DataProvider.Instance.ExecuteQuery(query, newParameter);
            data.Columns[0].ColumnName = "MÃ NHÂN VIÊN";
            data.Columns[1].ColumnName = "HỌ TÊN";
            data.Columns.Add("LƯƠNG", typeof(string));

            foreach (DataRow row in data.Rows)
            {
                byte[] bytesSalary = (byte[])row[3];
                row[4] = Encryption.Instance.DecryptRSA(bytesSalary, (string)parameter[5]);
            }
            data.Columns.RemoveAt(3);
            return data;
        }

    }
}
