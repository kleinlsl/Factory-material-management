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

namespace 工厂物资管理.系统管理
{
    public partial class AddTitleForm : Form
    {
        private SqlConnection sqlconn = null;
        private SqlCommand sqlcmd = null;
        public AddTitleForm()
        {
            InitializeComponent();
            this.sqlconn = new SqlConnection(DB.DBConnStr.ConnStr);
            this.sqlcmd = new SqlCommand();
            this.sqlcmd.Connection = sqlconn;
        }

        private void AddTitleForm_Load(object sender, EventArgs e)
        {

        }

        private void Cancle_button_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Create_button_Click(object sender, EventArgs e)
        {
            if (this.TitleName.Text.Trim() == "")
            {
                MessageBox.Show("职称名不能为空！", "警告");
                return;
            }

            try
            {
                if (sqlconn.State != ConnectionState.Open)
                {
                    sqlconn.Open();
                }
                sqlcmd.CommandText = "select * from Title where TitleName = '" + this.TitleName.Text.Trim() + "'";
                if (sqlcmd.ExecuteScalar() == null)
                {
                    sqlcmd.CommandText = "insert into Title(TitleName,SystemManage, MaterialManage, InManage, OutManage) values ('" + this.TitleName.Text.Trim() + "','" + XTGL_checkB.Checked + "','" + WZGL_checkBox.Checked + "','" +
                             "" + RKGL_checkBox.Checked + "','" + CKGL_checkBox.Checked + "')";
                    if (sqlcmd.ExecuteNonQuery() > 0)
                    {
                        MessageBox.Show("角色添加成功！", "提示");
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("角色添加失败！", "提示");
                    }

                }
                else
                {
                    MessageBox.Show("角色名称重复！", "警告");
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "警告！");
                // throw;
            }
            finally
            {
                sqlconn.Close();
            }
        }
    }
}
