﻿using System;
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
    public partial class BrowseInInventoryForm : Form
    {
        private SqlConnection sqlconn = null;

        SqlDataAdapter sda = null;
        DataSet ds = null;
        ModifyInInventoryForm ModifyInInventory = null;
        public BrowseInInventoryForm()
        {
            InitializeComponent();
            this.sqlconn = new SqlConnection(DB.DBConnStr.ConnStr);
           // this.sqlcmd = this.sqlconn.CreateCommand();
        }

        private void BrowseInInventoryForm_Load(object sender, EventArgs e)
        {
            this.Freshen();
        }

        private void Modify_button_Click(object sender, EventArgs e)
        {
         //   MessageBox.Show(ds.Tables["store"].Rows[dataGridView1.CurrentCell.RowIndex][3].ToString() + ds.Tables["store"].Rows[dataGridView1.CurrentCell.RowIndex][0].ToString() + ds.Tables["store"].Rows[dataGridView1.CurrentCell.RowIndex][9].ToString() + "123", "");

            if (dataGridView1.DataSource != null || dataGridView1.CurrentCell != null)
            {
                this.ModifyInInventory = new ModifyInInventoryForm(ds.Tables["store"].Rows[dataGridView1.CurrentCell.RowIndex][3].ToString(), ds.Tables["store"].Rows[dataGridView1.CurrentCell.RowIndex][0].ToString(), ds.Tables["store"].Rows[dataGridView1.CurrentCell.RowIndex][9].ToString());
                //this.ModifyInInventory = new ModifyInInventoryForm();
                  this.ModifyInInventory.ShowDialog();
            }
            else
            {
                MessageBox.Show("请选择要修改数据行中的任一单元格", "系统使用提示");
            }
            this.Freshen();
        }

        private void SX_button_Click(object sender, EventArgs e)
        {
            this.Freshen();
        }
        private void Freshen()
        {
            string sql = "select InInfo.WarehouseID as 仓库号,Warehouse.WarehouseName as 仓库名,Warehouse.Telephone as 仓库电话号码," +
               "InInfo.ComponentID as 零件号,Component.ComponentName as 零件名, Component.ComponentFormat as 零件规格," +
               "Component.ComponentUnitprice as 零件单价,InInfo.InNum as 入库数量,Employee.EmployeeName as 操作员,InInfo.Indate as 入库时间 " +
               "from InInfo, Warehouse, Component,Employee " +
               "where InInfo.ComponentID=Component.ComponentID and InInfo.WarehouseID=Warehouse.WarehouseID and Employee.EmployeeID=InInfo.InEmployeeID";
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
    }
}
