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
    public partial class QueryWarehouseForm : Form
    {
        private SqlConnection sqlconn = null;
        private SqlCommand sqlcmd = null;
        public QueryWarehouseForm()
        {
            InitializeComponent();
            this.sqlconn = new SqlConnection(DB.DBConnStr.ConnStr);
            this.sqlcmd = this.sqlconn.CreateCommand();
        }

        private void Query_button_Click(object sender, EventArgs e)
        {
            //后续可加价格区间功能
            string sql = "select WarehouseID as 仓库编号,WarehouseName as 仓库名称,Area as 仓库面积,Telephone as 电话号码 " +
                "from Warehouse "
                + "where WarehouseID = WarehouseID ";
            if (CKBH_textB.Text.Trim() == "" && CKMC_textB.Text.Trim() == "" && CKHM_textB.Text.Trim() == "")
            {
                MessageBox.Show("请输入查询条件！", "警告");
                return;
            }
            if (CKBH_textB.Text.Trim() != "")
                sql = sql + " and WarehouseID= " + "'" + CKBH_textB.Text.Trim() + "'";
            if (CKMC_textB.Text.Trim() != "")
                sql = sql + " and WarehouseName= " + "'" + CKMC_textB.Text.Trim() + "'";
            string tel = CKHM_textB.Text.Trim();
            if (tel != "")
            {
                if (!Check.IsTelephone(tel) && !Check.IsHandset(tel))
                {
                    MessageBox.Show("请输入正确的电话！", "提示");
                    return;
                }
                sql = sql + " and Telephone= " + "'" + CKHM_textB.Text.Trim() + "'";
            }
         
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
            this.CKBH_textB.Text = "";
            this.CKHM_textB.Text = "";
            this.CKMC_textB.Text = "";
        }
    }
}
