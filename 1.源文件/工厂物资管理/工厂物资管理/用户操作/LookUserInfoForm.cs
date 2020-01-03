using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using 工厂物资管理.加密;

namespace 工厂物资管理.用户操作
{
    public partial class LookUserInfoForm : Form
    {
        private SqlConnection sqlconn = null;
        private SqlCommand sqlcmd = null;
        private string MD5_Key = DB.DBConnStr.DES_MD5_Key;
        private DES md5=new DES();
        public LookUserInfoForm()
        {
            InitializeComponent();
            this.sqlconn = new SqlConnection(DB.DBConnStr.ConnStr);
            this.sqlcmd = new SqlCommand();
            this.sqlcmd.Connection = this.sqlconn;

            // https://blog.csdn.net/boss2967/article/details/79019467
            //sql去重复操作详解SQL中distinct的用法

            DataSet ds = new DataSet();
            SqlDataAdapter sadp = new SqlDataAdapter("", sqlconn);
            sadp.SelectCommand.CommandText = "select EmployeeID from Employee ";
            sadp.Fill(ds);
            this.comboBoxUserId.DataSource = ds.Tables[0].DefaultView;
            this.comboBoxUserId.DisplayMember = "EmployeeID";
            this.comboBoxUserId.ValueMember = "EmployeeID";

        }
        public LookUserInfoForm(string User_Id)
        {
            InitializeComponent();
            this.sqlconn = new SqlConnection(DB.DBConnStr.ConnStr);
            this.sqlcmd = new SqlCommand();
            this.sqlcmd.Connection = this.sqlconn;
            this.textBoxPassword.PasswordChar = '*';

            this.comboBoxUserId.Items.Add(User_Id);
            this.comboBoxUserId.SelectedIndex = 0;

        }

        private void LookUserInfoForm_Load(object sender, EventArgs e)
        {

        }

        private void comboBoxUserId_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataSet ds = new DataSet();
            SqlDataAdapter sadp = new SqlDataAdapter("", sqlconn);
            string sql = "" +
                "select EmployeeID, EmployeeName, EmployeeAge, EmployeeTitle, WarehouseID ,EmployeeLead ,EmployeePwd " +
                "from Employee" +
                " where EmployeeID='" + this.comboBoxUserId.Text.Trim() + "'";
            sadp.SelectCommand.CommandText = sql;
            sadp.Fill(ds);
            if (ds.Tables[0].Rows.Count > 0)
            {
                this.textBoxUserName.Text = ds.Tables[0].Rows[0][1].ToString().Trim();
                this.textBoxUserAge.Text = ds.Tables[0].Rows[0][2].ToString().Trim();
                this.textBoxUserTitle.Text = ds.Tables[0].Rows[0][3].ToString().Trim();
                this.textBoxUserWarehouse.Text = ds.Tables[0].Rows[0][4].ToString().Trim();
                this.textBoxUserLead.Text = ds.Tables[0].Rows[0][5].ToString().Trim();
                this.textBoxPassword.Text = md5.MD5Decrypt(ds.Tables[0].Rows[0][6].ToString().Trim(),MD5_Key);
            }
        }
    }
}
