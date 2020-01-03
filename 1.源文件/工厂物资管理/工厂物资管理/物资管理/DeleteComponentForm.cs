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
    public partial class DeleteComponentForm : Form
    {
        private SqlConnection sqlconn = null;
        private SqlCommand sqlcmd = null;
        public DeleteComponentForm()
        {
            InitializeComponent();
            this.sqlconn = new SqlConnection(DB.DBConnStr.ConnStr);
            this.sqlcmd = new SqlCommand();
            this.sqlcmd.Connection = this.sqlconn;
            // https://blog.csdn.net/boss2967/article/details/79019467
            //sql去重复操作详解SQL中distinct的用法

            DataSet ds = new DataSet();
            SqlDataAdapter sadp = new SqlDataAdapter("", sqlconn);
            sadp.SelectCommand.CommandText = "select distinct ComponentID from Component";
            sadp.Fill(ds);
            this.comboBox_id.DataSource = ds.Tables[0].DefaultView;
            this.comboBox_id.DisplayMember = "ComponentID";
            this.comboBox_id.ValueMember = "ComponentID";
        }

        private void comboBox_id_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataSet ds = new DataSet();
            SqlDataAdapter sadp = new SqlDataAdapter("", sqlconn);
            string sql = "" +
                "select ComponentID, ComponentName, ComponentFormat, ComponentUnitprice,ComponentDescribe " +
                "from Component" +
                " where ComponentID='" + this.comboBox_id.Text.Trim() + "'";
            sadp.SelectCommand.CommandText = sql;
            sadp.Fill(ds);
            if (ds.Tables[0].Rows.Count > 0)
            {
                this.textBoxName.Text = ds.Tables[0].Rows[0][1].ToString().Trim();
                this.textBoxFormat.Text = ds.Tables[0].Rows[0][2].ToString().Trim();
                this.textBoxUnitprice.Text = ds.Tables[0].Rows[0][3].ToString().Trim();
                this.textBoxDescribe.Text = ds.Tables[0].Rows[0][4].ToString().Trim();
            }
        }

        private void ModifyComponentbutton_Click(object sender, EventArgs e)
        {
            if (this.comboBox_id.Text.Trim() == "")
            {
                MessageBox.Show("请输入零件编号！", "提示");
                return;
            }
          
            try
            {
                if (sqlconn.State != ConnectionState.Open)
                {
                    sqlconn.Open();
                }
                string sql = "select * from Component where ComponentID = '" + this.comboBox_id.Text.Trim() + "'";
                this.sqlcmd.CommandText = sql;
                if (sqlcmd.ExecuteScalar() == null)
                {
                    MessageBox.Show("零件编号" + this.comboBox_id.Text.Trim() + "不存在！", "警告");
                }
                else
                {
                    sql = "delete Component where ComponentID='" + comboBox_id.Text.Trim() + "'";
                    sqlcmd.CommandText = sql;
                    if (sqlcmd.ExecuteNonQuery() > 0)
                    {
                        MessageBox.Show("零件信息删除成功！", "提示");
                    }
                    else
                    { MessageBox.Show("零件信息删除失败！", "提示"); }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "数据库操作失败");
                //throw;
            }
            finally
            { sqlconn.Close(); }
        }
    }
}
