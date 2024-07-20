using QLSV.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLSV
{
    public partial class fManager : Form
    {
        string username;
        string password;

        public fManager()
        {
            InitializeComponent();
        }

        public fManager(string username, string password)
        {
            this.username = username;
            this.password = password;
            InitializeComponent();
            loadData();
            //disableInputField();
        }

        public void enableInputField()
        {
            txbId.ReadOnly = false;
            txbName.ReadOnly = false;
            txbEmail.ReadOnly = false;
            txbSalary.ReadOnly = false;
            txbUsername.ReadOnly = false;
            txbPassword.ReadOnly = false;
        }

        public void disableInputField()
        {
            txbId.ReadOnly = true;
            txbName.ReadOnly = true;
            txbEmail.ReadOnly = true;
            txbSalary.ReadOnly = true;
            txbUsername.ReadOnly = true;
            txbPassword.ReadOnly = true;
        }


        private void clearDataInInputField()
        {
            txbId.Text = "";
            txbName.Text = "";
            txbEmail.Text = "";
            txbSalary.Text = "";
            txbUsername.Text = "";
            txbPassword.Text = "";
        }

        private object[] getDataFromInputField()
        {
            string id = txbId.Text.Trim();
            string name = txbName.Text.Trim();
            string email = txbEmail.Text.Trim();
            string salary = txbSalary.Text.Trim();
            string username = txbUsername.Text.Trim();
            string password = txbPassword.Text.Trim();
            object[] data = { id, name, email, salary, username, password };
            return data;
        }

        private void loadData()
        {
            DataTable dataTable = new DataTable();
            object[] parameter = getDataFromInputField();
            if (parameter[4] == "" || parameter[5]=="")
            {
                parameter[4] = this.username;
                parameter[5] = this.password;
            }
            dataTable = EmployeeManagerDAO.Instance.GetDataEmployeeAES();
            dgvEmployee.DataSource = dataTable;
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            clearDataInInputField();
            enableInputField();
            EmployeeManagerDAO.Instance.setOption(1);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            clearDataInInputField();
            enableInputField();
            EmployeeManagerDAO.Instance.setOption(2);
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            clearDataInInputField();
            enableInputField();
            EmployeeManagerDAO.Instance.setOption(3);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            object[] parameter = getDataFromInputField();

            int option = EmployeeManagerDAO.Instance.getOption();
            switch (option)
            {
                case 1:
                    {
                        int result = EmployeeManagerDAO.Instance.insert(parameter);
                        if (result != 0)
                        {
                            MessageBox.Show("Thêm thành công.");
                            //loadData();
                        }
                        break;
                    }
                case 2:
                    {
                        MessageBox.Show("Chức năng chưa được thực hiện.");
                        break;
                    }
                case 3:
                    {
                        MessageBox.Show("Chức năng chưa được thực hiện.");
                        break;
                    }
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            clearDataInInputField();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
