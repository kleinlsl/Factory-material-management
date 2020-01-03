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

namespace 工厂物资管理.仓库信息管理
{
    public partial class BrowseWarehouseForm : Form
    {
        private SqlConnection sqlconn = null;
        private SqlCommand sqlcmd = null;
        public BrowseWarehouseForm()
        {
            InitializeComponent();
            this.sqlconn = new SqlConnection(DB.DBConnStr.ConnStr);
            this.sqlcmd = this.sqlconn.CreateCommand();
        }

        private void BrowseWarehouseForm_Load(object sender, EventArgs e)
        {
            string sql = "select WarehouseID as 仓库编号,WarehouseName as 仓库名称,Area as 仓库面积,Telephone as 电话号码 " +
                "from Warehouse "
                + "where WarehouseID = WarehouseID ";
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
    }
}
