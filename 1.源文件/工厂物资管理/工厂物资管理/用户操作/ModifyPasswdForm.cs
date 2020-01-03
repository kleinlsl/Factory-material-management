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
using 工厂物资管理.DB;
namespace 工厂物资管理.用户操作
{
    public partial class ModifyPasswdForm : Form
    {
        SqlConnection sqlconn = null;
        SqlCommand sqlcmd = null;
        private string MD5_Key = DB.DBConnStr.DES_MD5_Key;
        private DES md5;
        public ModifyPasswdForm(string User_Id,string User_name)
        {
            InitializeComponent();
            this.sqlconn = new SqlConnection(DB.DBConnStr.ConnStr);
            this.sqlcmd = this.sqlconn.CreateCommand();
            this.textBoxUserID.Text = User_Id;
            this.textBoxUserName.Text = User_name;
            md5 = new DES();
        }

      

        private void Modify_Passwd_button_Click(object sender, EventArgs e)
        {
            if (this.Old_Passwd_textB.Text.Trim() == "" || this.New_Passwd_textB.Text.Trim() == "" || this.Once_New_Password_textB.Text.Trim() == "")
            {
                MessageBox.Show("请填写完整信息！", "提示");
                return;
            }
            string sql = "select * from Employee where EmployeeID='" + this.textBoxUserID.Text.Trim() + "' and EmployeePwd='" + md5.MD5Encrypt(this.Old_Passwd_textB.Text.Trim(),MD5_Key) + "'";
            sqlcmd.CommandText = sql;
            try
            {
                if (sqlconn.State != ConnectionState.Open)
                {
                    sqlconn.Open();
                }
                if (sqlcmd.ExecuteScalar() != null)
                {
                    if (this.New_Passwd_textB.Text.Trim() == this.Once_New_Password_textB.Text.Trim())
                    {
                        if (this.New_Passwd_textB.Text.Trim().Length <= 16)
                        {
                            sql = "update Employee set EmployeePwd='" + md5.MD5Encrypt(this.New_Passwd_textB.Text.Trim(),this.MD5_Key) + "' where EmployeeID='" + this.textBoxUserID.Text.Trim() + "'";
                            sqlcmd.CommandText = sql;
                            if (sqlcmd.ExecuteNonQuery() > 0)
                            {
                                MessageBox.Show("密码修改成功！", "提示");
                                this.Close();
                            }
                        }
                        else
                        {
                            MessageBox.Show("请控制密码长度在16位以内！", "警告");
                        }
                    }
                    else
                    { MessageBox.Show("两次密码输入不一致！", "警告"); }
                }
                else
                { MessageBox.Show("密码错误！", "提示"); }



            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "提示");
                //throw;
            }
            finally
            {
                sqlconn.Close();
            }
        }
    }
}
