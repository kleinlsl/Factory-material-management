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
    public partial class AddOutInventoryForm : Form
    {

        private string User_Id = null;
        private SqlConnection sqlconn = null;
        private SqlCommand sqlcmd = null;
        DateTimePicker dtp = null;

        public AddOutInventoryForm(string id)
        {
            InitializeComponent();

            this.User_Id = id;
            dtp = this.RKSJ_dateTimeP;
            dtp.Format = DateTimePickerFormat.Custom;
            dtp.CustomFormat = "yyyy-MM-dd ";
            this.sqlconn = new SqlConnection(DB.DBConnStr.ConnStr);
            this.sqlcmd = new SqlCommand();
            this.sqlcmd.Connection = this.sqlconn;
        }

        private void Save_button_Click(object sender, EventArgs e)
        {
            if (this.LJBH_comboB.Text.Trim() == "")
            {
                MessageBox.Show("请填写物资编号！", "提示");
                return;
            }
            if (this.CKBH_comboBoxB.Text.Trim() == "")
            {
                MessageBox.Show("请填写库存编号！", "提示");
                return;
            }
            if (this.RKSL_textB.Text.Trim() == "")
            {
                MessageBox.Show("请填写出库数量！", "提示");
                return;
            }
            int rk;
            if (!int.TryParse(this.RKSL_textB.Text.Trim(), out rk))
            {
                if (int.Parse(this.RKSL_textB.Text.Trim().ToString()) < 0)
                {
                    MessageBox.Show("出库数量请输入正整数", "提示");
                    return;
                }
                if (int.Parse(this.RKSL_textB.Text.Trim().ToString()) > int.Parse(this.KCZL_textB.Text.Trim()))
                {
                    MessageBox.Show("该仓库的该零件库存不够！出库失败！","提示");
                    return;
                }
                MessageBox.Show("出库数量请填写整数！", "提示");
                return;
            }
            try
            {

                //
                // insert into test values('2015-09-14 23:59:59')
                //MessageBox.Show(DateTime.Now.ToString("yyyy-MM-dd"));
                /*
                 * https://www.cnblogs.com/ZCoding/p/4192009.html
                 * */
                if (sqlconn.State != ConnectionState.Open)
                {
                    sqlconn.Open();
                }
                string sql = "select * from OutInfo where " +
                    "ComponentID='" + this.LJBH_comboB.Text.Trim() + "' " +
                    "and WarehouseID='" + this.CKBH_comboBoxB.Text.Trim() + "' " +
                    "and Outdate='" + this.RKSJ_dateTimeP.Text.Trim() + "'";
                //  MessageBox.Show(this.User_Id, "");
                this.sqlcmd.CommandText = sql;
                if (sqlcmd.ExecuteScalar() == null)
                {
                    sql = "insert into OutInfo (ComponentID,WarehouseID,OutNum,Outdate,OutEmployeeID) " +
                        "values ('"
                          + this.LJBH_comboB.Text.Trim() + "','"
                          + this.CKBH_comboBoxB.Text.Trim() + "',"
                          + this.RKSL_textB.Text.Trim() + ",'"
                          + this.RKSJ_dateTimeP.Text.Trim() + "','"
                          + this.User_Id + "')";
                    //MessageBox.Show(sql,"");
                    sqlcmd.CommandText = sql;
                    if (sqlcmd.ExecuteNonQuery() > 0)
                    {
                        MessageBox.Show("添加出库信息成功！", "提示");
                    }
                }
                else
                {
                    MessageBox.Show(this.CKBH_comboBoxB.Text.Trim() + "仓库在" + this.RKSJ_dateTimeP.Text.Trim() + "当天已出库过该物资" + this.LJBH_comboB.Text.Trim() + "", "警告");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "提示");
                // throw;
            }
            finally
            {
                sqlconn.Close();
            }
        }

        private void Clear_button_Click(object sender, EventArgs e)
        {
            this.LJBH_comboB.Text = "";
            this.LJMC_textBoxB.Text = "";
            this.LJGS_textBoxB.Text = "";
            this.LJDJ_textBoxB.Text = "";
            this.LJMS_textBoxB.Text = "";

            this.CKBH_comboBoxB.Text = "";
            this.CKMC_textBoxB.Text = "";
            this.CKMJ_textBox.Text = "";
            this.CKD_HtextBox.Text = "";

            this.KCZL_textB.Text = "";
            this.RKSL_textB.Text = "";
        }

        private void Cancel_button_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void LJBH_comboB_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataSet ds = new DataSet();
            SqlDataAdapter sadp = new SqlDataAdapter("", sqlconn);
            string sql = "" +
                "select ComponentID, ComponentName, ComponentFormat, ComponentUnitprice, ComponentDescribe " +
                "from Component" +
                " where ComponentID='" + this.LJBH_comboB.Text.Trim() + "'";
            sadp.SelectCommand.CommandText = sql;
            sadp.Fill(ds);
            if (ds.Tables[0].Rows.Count > 0)
            {
                this.LJMC_textBoxB.Text = ds.Tables[0].Rows[0][1].ToString().Trim();
                this.LJGS_textBoxB.Text = ds.Tables[0].Rows[0][2].ToString().Trim();
                this.LJDJ_textBoxB.Text = ds.Tables[0].Rows[0][3].ToString().Trim();
                this.LJMS_textBoxB.Text = ds.Tables[0].Rows[0][4].ToString().Trim();
            }
        }

        private void AddOutInventoryForm_Load(object sender, EventArgs e)
        {
            DataSet ds = new DataSet();
            SqlDataAdapter sadp = new SqlDataAdapter("", sqlconn);
            sadp.SelectCommand.CommandText = "select distinct ComponentID from Inventory";
            sadp.Fill(ds);
            this.LJBH_comboB.DataSource = ds.Tables[0].DefaultView;
            this.LJBH_comboB.DisplayMember = "ComponentID";
            this.LJBH_comboB.ValueMember = "ComponentID";

            DataSet ck = new DataSet();
            sadp = new SqlDataAdapter("", sqlconn);
            sadp.SelectCommand.CommandText = "select distinct WarehouseID from Inventory";
            sadp.Fill(ck);
            this.CKBH_comboBoxB.DataSource = ck.Tables[0].DefaultView;
            this.CKBH_comboBoxB.DisplayMember = "WarehouseID";
            this.CKBH_comboBoxB.ValueMember = "WarehouseID";
        }

        private void CKBH_comboBoxB_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.CKMC_textBoxB.Text = "";
            this.CKMJ_textBox.Text = "";// ds.Tables[0].Rows[0][2].ToString().Trim();
            this.CKD_HtextBox.Text = "";// ds.Tables[0].Rows[0][3].ToString().Trim();
            this.KCZL_textB.Text = "";// ds.Tables[0].Rows[0][4].ToString().Trim();
            DataSet ds = new DataSet();
            SqlDataAdapter sadp = new SqlDataAdapter("", sqlconn);
            string sql = "" +
                "select Warehouse.WarehouseID, Warehouse.WarehouseName, Warehouse.Area, " +
                "Warehouse.Telephone,Inventory.InventoryNum " +
                "from Warehouse,Inventory" +
                " where Warehouse.WarehouseID=Inventory.WarehouseID and " +
                "Warehouse.WarehouseID='" + this.CKBH_comboBoxB.Text.Trim() + "' and " +
                "Inventory.ComponentID='"+this.LJBH_comboB.Text.Trim()+"'";
            sadp.SelectCommand.CommandText = sql;
            sadp.Fill(ds);
            if (ds.Tables[0].Rows.Count > 0)
            {
                this.CKMC_textBoxB.Text = ds.Tables[0].Rows[0][1].ToString().Trim();
                this.CKMJ_textBox.Text = ds.Tables[0].Rows[0][2].ToString().Trim();
                this.CKD_HtextBox.Text = ds.Tables[0].Rows[0][3].ToString().Trim();
                this.KCZL_textB.Text = ds.Tables[0].Rows[0][4].ToString().Trim();
            }
        }
    }
}
