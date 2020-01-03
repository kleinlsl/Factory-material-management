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
    public partial class QueryComponentForm : Form
    {
        private SqlConnection sqlconn = null;
        private SqlCommand sqlcmd = null;
        public QueryComponentForm()
        {
            InitializeComponent();
            this.sqlconn = new SqlConnection(DB.DBConnStr.ConnStr);
            this.sqlcmd = this.sqlconn.CreateCommand();
        }

        private void QueryComponentForm_Load(object sender, EventArgs e)
        {
            //后续可加价格区间功能
            string sql = "select ComponentID as 零件编号,ComponentName as 零件名称,ComponentFormat as 零件规格,ComponentUnitprice as 单价,ComponentDescribe as 零件描述 " +
                "from Component "
                + "where ComponentDescribe = ComponentDescribe ";
            try
            {
                if (sqlconn.State != ConnectionState.Open)
                {
                    sqlconn.Open();
                }
                SqlDataAdapter sda = new SqlDataAdapter(sql, sqlconn);
                DataSet ds = new DataSet();
                ds.Clear();
                sda.Fill(ds, "store");
                dataGridView1.DataSource = ds.Tables["store"].DefaultView;
                MessageBox.Show("共有" + ds.Tables[0].Rows.Count + "条查询记录", "查询结果统计");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "数据库操作失败提示");
                //throw;
            }
            finally { this.sqlconn.Close(); }
        }

        private void Query_button_Click(object sender, EventArgs e)
        {

            //后续可加价格区间功能
            string sql = "select ComponentID as 零件编号,ComponentName as 零件名称,ComponentFormat as 零件规格,ComponentUnitprice as 单价,ComponentDescribe as 零件描述 " +
                "from Component " 
                + "where ComponentDescribe = ComponentDescribe ";
            if (WZBH_textB.Text.Trim() == "" && WZMC_textB.Text.Trim() == "" && WZXH_textB.Text.Trim() == "")
            {
                MessageBox.Show("请输入查询条件！", "警告");
                return;
            }
            if (WZBH_textB.Text.Trim() != "")
                sql = sql + " and ComponentID= " + "'" + WZBH_textB.Text.Trim() + "'";
            if (WZMC_textB.Text.Trim() != "")
                sql = sql + " and ComponentName= " + "'" + WZMC_textB.Text.Trim() + "'";
            if (WZXH_textB.Text.Trim() != "")
                sql = sql + " and ComponentFormat= " + "'" + WZXH_textB.Text.Trim() + "'";
            try
            {
                if (sqlconn.State != ConnectionState.Open)
                {
                    sqlconn.Open();
                }
                SqlDataAdapter sda = new SqlDataAdapter(sql, sqlconn);
                DataSet ds = new DataSet();
                ds.Clear();
                sda.Fill(ds, "store");
                dataGridView1.DataSource = ds.Tables["store"].DefaultView;
                MessageBox.Show("共有" + ds.Tables[0].Rows.Count + "条查询记录", "查询结果统计");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "数据库操作失败提示");
                //throw;
            }
            finally { this.sqlconn.Close(); }

        }

        private void Retry_button_Click(object sender, EventArgs e)
        {
            this.WZBH_textB.Text = "";
            this.WZMC_textB.Text = "";
            this.WZXH_textB.Text = "";
        }
    }
}
