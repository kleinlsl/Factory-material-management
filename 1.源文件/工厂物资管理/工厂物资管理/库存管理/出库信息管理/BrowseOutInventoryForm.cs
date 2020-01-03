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

namespace 工厂物资管理.库存管理.出库信息管理
{
    public partial class BrowseOutInventoryForm : Form
    {
        private SqlConnection sqlconn = null;

        SqlDataAdapter sda = null;
        DataSet ds = null;
        ModifyOutInventoryForm ModifyOutInventory = null;
        public BrowseOutInventoryForm()
        {
            InitializeComponent();
            this.sqlconn = new SqlConnection(DB.DBConnStr.ConnStr);
        }

        private void BrowseOutInventoryForm_Load(object sender, EventArgs e)
        {
            this.Freshen();
        }

        private void Exit_button_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Modify_button_Click(object sender, EventArgs e)
        {
            //   MessageBox.Show(ds.Tables["store"].Rows[dataGridView1.CurrentCell.RowIndex][3].ToString() + ds.Tables["store"].Rows[dataGridView1.CurrentCell.RowIndex][0].ToString() + ds.Tables["store"].Rows[dataGridView1.CurrentCell.RowIndex][9].ToString() + "123", "");

            if (dataGridView1.DataSource != null || dataGridView1.CurrentCell != null)
            {
                this.ModifyOutInventory = new ModifyOutInventoryForm(ds.Tables["store"].Rows[dataGridView1.CurrentCell.RowIndex][3].ToString(), ds.Tables["store"].Rows[dataGridView1.CurrentCell.RowIndex][0].ToString(), ds.Tables["store"].Rows[dataGridView1.CurrentCell.RowIndex][9].ToString());
                //this.ModifyInInventory = new ModifyInInventoryForm();
                this.ModifyOutInventory.ShowDialog();
            }
            else
            {
                MessageBox.Show("请选择要修改数据行中的任一单元格", "系统使用提示");
            }
            this.Freshen();
        }


        //刷新
        private void Freshen()
        {
            string sql = "select OutInfo.WarehouseID as 仓库号,Warehouse.WarehouseName as 仓库名,Warehouse.Telephone as 仓库电话号码," +
               "OutInfo.ComponentID as 零件号,Component.ComponentName as 零件名, Component.ComponentFormat as 零件规格," +
               "Component.ComponentUnitprice as 零件单价,OutInfo.OutNum as 出库数量,Employee.EmployeeName as 操作员,OutInfo.Outdate as 出库时间 " +
               "from OutInfo, Warehouse, Component,Employee " +
               "where OutInfo.ComponentID=Component.ComponentID and OutInfo.WarehouseID=Warehouse.WarehouseID and Employee.EmployeeID=OutInfo.OutEmployeeID";
            try
            {
                if (sqlconn.State != ConnectionState.Open)
                {
                    sqlconn.Open();
                }
                sda = new SqlDataAdapter(sql, sqlconn);
                ds = new DataSet();
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

        private void SX_button_Click(object sender, EventArgs e)
        {
            this.Freshen();
        }
    }
}
