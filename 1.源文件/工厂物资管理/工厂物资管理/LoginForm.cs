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

namespace 工厂物资管理
{
    public partial class LoginForm : Form
    {
        private string MD5_Key = DB.DBConnStr.DES_MD5_Key;
        private DES md5 = null;
        private FaceLoginForm faceLogin;

        private SqlConnection sqlConnection = null;
        private SqlCommand sqlCommand = null;
        public LoginForm()
        {
  
            InitializeComponent();
            md5 = new DES();

            this.sqlConnection = new SqlConnection(DB.DBConnStr.ConnStr);
            this.sqlCommand = new SqlCommand();
            this.sqlCommand.Connection = this.sqlConnection;
            this.textBox用户名.Text = "admin";
            //this.textBox密码.Text = "admin";
        }

        private void button登陆_Click(object sender, EventArgs e)
        {
            if (textBox密码.Text.Trim() == "" || textBox用户名.Text.Trim() == "")
            {
                MessageBox.Show("请输入用户名和密码！", "提示信息");
                return;
            }
            try
            {
                String Login_name = textBox用户名.Text.Trim();
                String Login_pwd = textBox密码.Text.Trim();
                if (sqlConnection.State != ConnectionState.Open)
                {
                    sqlConnection.Open();
                }
                string sql = string.Format("select EmployeeID,EmployeePwd,EmployeeName,Employee.EmployeeTitle " +
                    "from Employee "+
                    "where Employee.EmployeeID = '{0}' and Employee.EmployeePwd = '{1}'",Login_name,md5.MD5Encrypt(Login_pwd,MD5_Key));
                sqlCommand.CommandText = sql;
                SqlDataReader sdr = sqlCommand.ExecuteReader();
                if (sdr.HasRows)
                {
                    //有返回行
                    sdr.Read();

                    if (sdr[0].ToString() == Login_name && md5.MD5Decrypt(sdr[1].ToString(),MD5_Key).ToString() == Login_pwd)
                    {//输入用户名和密码等于查询结果中用户名和密码
                      
                        MainForm mform = new MainForm(sdr[3].ToString(),sdr[0].ToString(),sdr[2].ToString());
                        sdr.Close();
                        this.Hide();
                        mform.ShowDialog();
                        // this.Uname_textB.Text = "";
                        this.textBox密码.Text = "";
                        this.Show();
                    }
                    else
                    {
                        sdr.Close();
                        MessageBox.Show("用户名或密码错误，请重新输入！", "SQL注入攻击无效,提示信息");
                    }

                }
                else
                {
                    //无返回行
                    MessageBox.Show("用户名或密码错误，请重新输入！", "提示信息");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "数据库操作问题提示");
                //throw;
            }
            finally
            {
                sqlConnection.Close();
            }
        }

        private void button退出_Click(object sender, EventArgs e)
        {
            DialogResult dialogR = MessageBox.Show("确定要退出系统吗？", "退出提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (dialogR == DialogResult.OK)
            {
                Application.Exit();
            }
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            MessageBox.Show(DB.DBConnStr.ConnStr,"数据库服务器信息");

        }

        private void button1_Click(object sender, EventArgs e)
        {
            faceLogin = new FaceLoginForm();
            
            this.Hide();
            faceLogin.ShowDialog();
       
            this.Show();
        }
    }
}
