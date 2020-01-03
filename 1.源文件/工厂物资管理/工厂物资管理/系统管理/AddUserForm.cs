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

namespace 工厂物资管理.系统管理
{
    public partial class AddUserForm : Form
    {
        private string MD5_Key = DB.DBConnStr.DES_MD5_Key;
        private DES md5 = null;

        private SqlConnection sqlconn = null;
        private SqlCommand sqlcmd = null;
        public AddUserForm()
        {
            InitializeComponent();
            this.sqlconn = new SqlConnection(DB.DBConnStr.ConnStr);
            this.sqlcmd = new SqlCommand();
            this.sqlcmd.Connection = this.sqlconn;

            md5 = new DES();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AddUserForm_Load(object sender, EventArgs e)
        {
            //添加职称列表
            DataSet zc = new DataSet();
            SqlDataAdapter sdap0 = new SqlDataAdapter("", sqlconn);
            sdap0.SelectCommand.CommandText = "select TitleName from Title";
            sdap0.Fill(zc);
            comboBoxUserTitle.DataSource = zc.Tables[0].DefaultView;
            comboBoxUserTitle.DisplayMember = "TitleName";
            comboBoxUserTitle.ValueMember = "TitleName";

            //添加年龄列表
            for(int i = 18; i <= 100; i++)
            {
                comboBoxUserAge.Items.Add(i);
            }
            comboBoxUserAge.SelectedIndex = 25-18;

            //添加仓库
            DataSet ck = new DataSet();
            //SqlDataAdapter sdap0 = new SqlDataAdapter("", sqlconn);
            sdap0.SelectCommand.CommandText = "select WarehouseID from Warehouse";
            sdap0.Fill(ck);
            comboBoxUser_Warehouse.DataSource = ck.Tables[0].DefaultView;
            comboBoxUser_Warehouse.DisplayMember = "WarehouseID";
            comboBoxUser_Warehouse.ValueMember = "WarehouseID";

            //添加领导
            DataSet ld = new DataSet();
            //SqlDataAdapter sdap0 = new SqlDataAdapter("", sqlconn);
            sdap0.SelectCommand.CommandText = "select EmployeeID,EmployeeName from Employee";
            sdap0.Fill(ld);
            comboBoxUser_Leader.DataSource = ld.Tables[0].DefaultView;
            comboBoxUser_Leader.DisplayMember = "EmployeeName";
            comboBoxUser_Leader.ValueMember = "EmployeeID";

        }

        private void AddUserbutton_Click(object sender, EventArgs e)
        {
            if (this.textBoxUserID.Text.Trim() == "" || this.textBoxUserName.Text.Trim() == ""
                || this.textBoxPassword.Text.Trim() == "" || this.textBoxOnce_Password.Text.Trim() == ""
                ||this.comboBoxUserAge.Text.Trim()==""||this.comboBoxUserTitle.Text.Trim()==""||
                this.comboBoxUser_Warehouse.Text.Trim()==""||comboBoxUser_Leader.Text.Trim()=="")
            {
                MessageBox.Show("请输入完整信息", "警告");
                return;
            }
            if (this.textBoxPassword.Text.Trim() != this.textBoxOnce_Password.Text.Trim())
            {
                MessageBox.Show("两次密码输入不一致！", "警告");
                return;
            }
     
            try
            {
                if (sqlconn.State != ConnectionState.Open)
                {
                    sqlconn.Open();
                }
                sqlcmd.CommandText = "select * from Employee where EmployeeID = '" + this.textBoxUserID.Text.Trim() + "'";
                if (sqlcmd.ExecuteScalar() == null)
                {
                    //获取下拉列表的值
                    //MessageBox.Show(this.comboBoxUser_Leader.SelectedValue.ToString(),"");
                    sqlcmd.CommandText = "insert into Employee (EmployeeID,EmployeeName,EmployeeAge,EmployeeTitle,WarehouseID,EmployeeLead,EmployeePwd) " +
                         "values ('" + this.textBoxUserID.Text.Trim() + "','" + this.textBoxUserName.Text.Trim() + "'," + this.comboBoxUserAge.Text.Trim() + ",'" +
                         "" +this.comboBoxUserTitle.Text.Trim()+"','"+this.comboBoxUser_Warehouse.Text.Trim()+"','"+this.comboBoxUser_Leader.SelectedValue.ToString().Trim()+"','"
                         +md5.MD5Encrypt(this.textBoxPassword.Text.Trim(),MD5_Key)+"'"+
                         ")";
                    if (sqlcmd.ExecuteNonQuery() > 0)
                    {
                        MessageBox.Show("添加用户成功！", "提示");
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("用户添加失败！", "提示");
                    }

                }
                else
                {
                    MessageBox.Show("用户名" + this.textBoxUserID.Text.Trim() + "已经存在！", "提示");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "警告！");
                //throw;
            }
            finally
            {
                sqlconn.Close();
            }
        }
    }
}
