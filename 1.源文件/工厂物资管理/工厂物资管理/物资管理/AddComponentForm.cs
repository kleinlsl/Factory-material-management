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

namespace 工厂物资管理.零件管理
{
    public partial class AddComponentForm : Form
    {
        private SqlConnection sqlconn = null;
        private SqlCommand sqlcmd = null;
        public AddComponentForm()
        {
            InitializeComponent();
            this.sqlconn = new SqlConnection(DB.DBConnStr.ConnStr);
            this.sqlcmd = new SqlCommand();
            this.sqlcmd.Connection = this.sqlconn;
        }

        private void AddComponentForm_Load(object sender, EventArgs e)
        {

        }

        private void ExitAddbutton_Click(object sender, EventArgs e)
        {
             this.Close();
        }

        private void AddComponentbutton_Click(object sender, EventArgs e)
        {
            if (this.textBoxID.Text.Trim() == "")
            {
                MessageBox.Show("请输入零件编号！", "提示");
                return;
            }
            if (this.textBoxFormat.Text.Trim() == "")
            {
                MessageBox.Show("请输入零件格式！", "提示");
                return;
            }
            if (this.textBoxName.Text.Trim() == "")
            {
                MessageBox.Show("请输入零件名！", "提示");
                return;
            }
            if (this.textBoxUnitprice.Text.Trim() == "")
            {
                MessageBox.Show("请输入单价！", "提示");
                return;
            }
            double Unitprice;
            if (!double.TryParse(this.textBoxUnitprice.Text.Trim(),out Unitprice)||Unitprice==0)
            {
                MessageBox.Show("单价请输入数字！", "提示");
                return;
            }
            try
            {
                if (sqlconn.State != ConnectionState.Open)
                {
                    sqlconn.Open();
                }
                string sql = "select * from Component where ComponentID = '" + this.textBoxID.Text.Trim() + "'";
                this.sqlcmd.CommandText = sql;
                if (sqlcmd.ExecuteScalar() != null)
                {
                    MessageBox.Show("零件编号" + this.textBoxID.Text.Trim() + "已经存在！", "警告");
                }
                else
                {
                    sql = "insert into Component(ComponentID, ComponentName, ComponentFormat, ComponentUnitprice, ComponentDescribe) values ('"
                        + this.textBoxID.Text.Trim() + "','" + this.textBoxName.Text.Trim() + "'," +"'" + this.textBoxFormat.Text.Trim() + "'," + this.textBoxUnitprice.Text.Trim() + ",'" + this.textBoxDescribe.Text.Trim() + "')";
                    sqlcmd.CommandText = sql;
                    if (sqlcmd.ExecuteNonQuery() > 0)
                    {
                        MessageBox.Show("添加零件信息成功！", "提示");
                    }
                    else
                    { MessageBox.Show("零件信息添加失败！", "提示"); }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "错误提示");
                //throw;
            }
            finally
            { sqlconn.Close(); }
        }
    }
}
