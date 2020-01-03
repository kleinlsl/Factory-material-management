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
using 工厂物资管理.正则式;
namespace 工厂物资管理.仓库信息管理
{
    public partial class AddWarehouseForm : Form
    {
        private SqlConnection sqlconn = null;
        private SqlCommand sqlcmd = null;
        public AddWarehouseForm()
        {
            InitializeComponent();
            this.sqlconn = new SqlConnection(DB.DBConnStr.ConnStr);
            this.sqlcmd = new SqlCommand();
            this.sqlcmd.Connection = this.sqlconn;
        }

        private void AddWarehouseForm_Load(object sender, EventArgs e)
        {

        }

        private void ExitAddbutton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AddWarehousebutton_Click(object sender, EventArgs e)
        {
            if (this.textBoxID.Text.Trim() == "")
            {
                MessageBox.Show("请输入仓库编号！", "提示");
                return;
            }
            if (this.textBoxName.Text.Trim() == "")
            {
                MessageBox.Show("请输入仓库名！", "提示");
                return;
            }
            string tel = this.textBoxTelephone.Text.Trim();
            if (!Check.IsHandset(tel))
            {
                MessageBox.Show("请输入正确的国内手机号！", "提示");
                return;
            }
            if (this.textBoxArea.Text.Trim() == "")
            {
                MessageBox.Show("请输入仓库面积！", "提示");
                return;
            }
            double Area;
            if (!double.TryParse(this.textBoxArea.Text.Trim(), out Area) || Area == 0)
            {
                MessageBox.Show("仓库面积请输入数字！", "提示");
                return;
            }
            try
            {
                if (sqlconn.State != ConnectionState.Open)
                {
                    sqlconn.Open();
                }
                string sql = "select * from Warehouse where WarehouseID = '" + this.textBoxID.Text.Trim() + "'";
                this.sqlcmd.CommandText = sql;
                if (sqlcmd.ExecuteScalar() != null)
                {
                    MessageBox.Show("仓库编号" + this.textBoxID.Text.Trim() + "已经存在！", "警告");
                }
                else
                {
                    sql = "insert into Warehouse(WarehouseID, WarehouseName, Area, Telephone) values ('"
                        + this.textBoxID.Text.Trim() + "','" + this.textBoxName.Text.Trim() + "'," + "" + this.textBoxArea.Text.Trim() + ",'" + this.textBoxTelephone.Text.Trim() + "')";
                    sqlcmd.CommandText = sql;
                    if (sqlcmd.ExecuteNonQuery() > 0)
                    {
                        MessageBox.Show("添加仓库信息成功！", "提示");
                    }
                    else
                    { MessageBox.Show("仓库信息添加失败！", "提示"); }

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
