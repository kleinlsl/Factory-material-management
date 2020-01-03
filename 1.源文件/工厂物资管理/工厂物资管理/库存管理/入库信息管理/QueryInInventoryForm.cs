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

namespace 工厂物资管理.库存管理.入库信息管理
{
    public partial class QueryInInventoryForm : Form
    {
        private SqlConnection sqlconn = null;
        private SqlCommand sqlcmd = null;
        public QueryInInventoryForm()
        {
            InitializeComponent();
            this.sqlconn = new SqlConnection(DB.DBConnStr.ConnStr);
            this.sqlcmd = this.sqlconn.CreateCommand();
        }

        private void QueryInInventoryForm_Load(object sender, EventArgs e)
        {

        }

        private void Retry_button_Click(object sender, EventArgs e)
        {
            this.LJBH_textB.Text = "";
            this.CZY_textB.Text = "";
            this.CKBH_textB.Text = "";
            this.Between_dateTimeP.Text = DateTime.Now.ToString("yyyy-MM-dd");
            this.And_dateTimeP.Text = DateTime.Now.ToString("yyyy-MM-dd");
        }

        private void Query_button_Click(object sender, EventArgs e)
        {

            string sql = "select InInfo.WarehouseID as 仓库号,Warehouse.WarehouseName as 仓库名,Warehouse.Telephone as 仓库电话号码," +
                "InInfo.ComponentID as 零件号,Component.ComponentName as 零件名, Component.ComponentFormat as 零件规格," +
                "Component.ComponentUnitprice as 零件单价,InInfo.InNum as 入库数量,Employee.EmployeeName as 操作员,InInfo.Indate as 入库时间 " +
                "from InInfo, Warehouse, Component,Employee " +
                "where InInfo.ComponentID=Component.ComponentID and InInfo.WarehouseID=Warehouse.WarehouseID and Employee.EmployeeID=InInfo.InEmployeeID";
            if (LJBH_textB.Text.Trim() == "" && CZY_textB.Text.Trim() == "" && CKBH_textB.Text.Trim() == "" && Between_dateTimeP.Text.Trim() == ""&&And_dateTimeP.Text.Trim()=="")
            {
                MessageBox.Show("请输入查询条件！", "警告");
                return;
            }
            if (LJBH_textB.Text.Trim() != "")
                sql = sql + " and InInfo.ComponentID= " + "'" + LJBH_textB.Text.Trim() + "'";
            if (CZY_textB.Text.Trim() != "")
                sql = sql + " and InInfo.InEmployeeID= " + "'" + CZY_textB.Text.Trim() + "'";
            if (CKBH_textB.Text.Trim() != "")
                sql = sql + " and InInfo.WarehouseID= " + "'" + CKBH_textB.Text.Trim() + "'";
            if (Between_dateTimeP.Text.Trim() != ""&&And_dateTimeP.Text.Trim()!="")
                sql = sql + " and Indate between '"+this.Between_dateTimeP.Value.ToString("yyyy-MM-dd").Trim()+"' and '"+this.And_dateTimeP.Value.ToString("yyyy-MM-dd").Trim() +"'";
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
