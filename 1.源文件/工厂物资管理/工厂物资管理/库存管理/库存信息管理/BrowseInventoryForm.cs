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

namespace 工厂物资管理.库存管理.库存信息管理
{
    public partial class BrowseInventoryForm : Form
    {
        private SqlConnection sqlconn = null;
        private SqlCommand sqlcmd = null;
        public BrowseInventoryForm()
        {
            InitializeComponent();
            this.sqlconn = new SqlConnection(DB.DBConnStr.ConnStr);
            this.sqlcmd = this.sqlconn.CreateCommand();
        }

        private void BrowseInventoryForm_Load(object sender, EventArgs e)
        {
            string sql = "select Inventory.WarehouseID as 仓库号,Warehouse.WarehouseName as 仓库名,Warehouse.Telephone as 仓库电话号码," +
                "Inventory.ComponentID as 零件号,Component.ComponentName as 零件名, Component.ComponentFormat as 零件规格," +
                "Component.ComponentUnitprice as 零件单价,Inventory.InventoryNum as 库存量 " +
                "from Inventory, Warehouse, Component " +
                "where Inventory.ComponentID=Component.ComponentID and Inventory.WarehouseID=Warehouse.WarehouseID ";
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
