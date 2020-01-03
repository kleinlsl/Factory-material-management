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
    public partial class ModifyInInventoryForm : Form
    {
        private SqlConnection sqlconn = null;
        private SqlCommand sqlcmd = null;
        DateTimePicker dtp = null;
        string LJID = null;
        string CKID = null;
        string RKSJ = null;
        public ModifyInInventoryForm()
        {
            InitializeComponent();
            dtp = this.RKSJ_dateTimeP;
            dtp.Format = DateTimePickerFormat.Custom;
            dtp.CustomFormat = "yyyy-MM-dd ";
            this.sqlconn = new SqlConnection(DB.DBConnStr.ConnStr);
            this.sqlcmd = new SqlCommand();
            this.sqlcmd.Connection = this.sqlconn;


            // https://blog.csdn.net/boss2967/article/details/79019467
            //sql去重复操作详解SQL中distinct的用法

            DataSet ds = new DataSet();
            SqlDataAdapter sadp = new SqlDataAdapter("", sqlconn);
            sadp.SelectCommand.CommandText = "select distinct ComponentID from InInfo";
            sadp.Fill(ds);
            this.LJBH_comboB.DataSource = ds.Tables[0].DefaultView;
            this.LJBH_comboB.DisplayMember = "ComponentID";
            this.LJBH_comboB.ValueMember = "ComponentID";
        }
        public ModifyInInventoryForm(string LJID,string CKID,string RKSJ)
        {
          //  MessageBox.Show(LJID+""+CKID+""+RKSJ,"");
            InitializeComponent();

            dtp = this.RKSJ_dateTimeP;
            dtp.Format = DateTimePickerFormat.Custom;
            dtp.CustomFormat = "yyyy-MM-dd ";
            this.sqlconn = new SqlConnection(DB.DBConnStr.ConnStr);
            this.sqlcmd = new SqlCommand();
            this.sqlcmd.Connection = this.sqlconn;
            this.CKID = CKID;
            this.LJID = LJID;
            this.RKSJ = RKSJ;

            this.LJBH_comboB.Items.Add(LJID);// = CKID;
            this.LJBH_comboB.SelectedIndex = 0;
            this.CKBH_comboBoxB.Items.Add(CKID);
            this.CKBH_comboBoxB.SelectedIndex = 0;
            //MessageBox.Show
            this.LJBH_comboB.Text = LJID;
            this.CKBH_comboBoxB.Text = CKID;
            this.RKSJ_dateTimeP.Text = RKSJ; 
           // this.RKSJ_dateTimeP.Value = DateTime.Parse("2019 - 11 - 03");
            if (RKSJ != null)
            {
                this.RKSJ_dateTimeP.Value = DateTime.Parse(RKSJ);
                this.RKSJ_dateTimeP.Text = RKSJ;

            }
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
                MessageBox.Show("请填写入库数量！", "提示");
                return;
            }
            int rk;
            if (!int.TryParse(this.RKSL_textB.Text.Trim(), out rk))
            {
                MessageBox.Show("入库数量请填写整数！", "提示");
                return;
            }
            if (this.User_name_textB.Text.Trim() == "")
            {
                MessageBox.Show("请选择仓库号、零件号和时间", "提示");
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
                string sql = "select * from InInfo where ComponentID='" + this.LJBH_comboB.Text.Trim() + "' and WarehouseID='" + this.CKBH_comboBoxB.Text.Trim() + "' and Indate='" + this.RKSJ_dateTimeP.Text.Trim() + "'";
                //  MessageBox.Show(this.User_Id, "");
                this.sqlcmd.CommandText = sql;
                if (sqlcmd.ExecuteScalar() != null)
                {
                    sql = "update InInfo set ComponentID='"+this.LJBH_comboB.Text.Trim()+"',WarehouseID='"+this.CKBH_comboBoxB.Text.Trim()+"',InNum="+this.RKSL_textB.Text.Trim()+
                        " where ComponentID='" + this.LJBH_comboB.Text.Trim() + "' and WarehouseID='" + this.CKBH_comboBoxB.Text.Trim() + "' and InDate='" + this.RKSJ_dateTimeP.Text.Trim() + "'";
                  //  MessageBox.Show(sql,"");
                    sqlcmd.CommandText = sql;
                    if (sqlcmd.ExecuteNonQuery() > 0)
                    {
                        MessageBox.Show("修改入库信息成功！", "提示");
                    }
                }
                else
                {
                    MessageBox.Show("不存在该记录", "警告");
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

        private void label10_Click(object sender, EventArgs e)
        {

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
            if (this.LJBH_comboB.Text.Trim() == "")
            {
                MessageBox.Show("请选择零件号","警告");
                return;
            }
            else
            {
                if (CKID == null)
                {
                    DataSet ck = new DataSet();
                    sadp = new SqlDataAdapter("", sqlconn);
                    sadp.SelectCommand.CommandText = "select distinct WarehouseID from InInfo where ComponentID='"+this.LJBH_comboB.Text.Trim()+"'";
                    sadp.Fill(ck);
                    this.CKBH_comboBoxB.DataSource = ck.Tables[0].DefaultView;
                    this.CKBH_comboBoxB.DisplayMember = "WarehouseID";
                    this.CKBH_comboBoxB.ValueMember = "WarehouseID";
                }
                else
                {
                    //this.CKBH_comboBoxB.Items.Add(CKID);
                }

            }
        }

        private void ModifyInInventoryForm_Load(object sender, EventArgs e)
        {

        }

        private void CKBH_comboBoxB_SelectedIndexChanged(object sender, EventArgs e)
        {
            //if (CKID == null)
           // {
                DataSet ds = new DataSet();
                SqlDataAdapter sadp = new SqlDataAdapter("", sqlconn);
                string sql = "" +
                    "select WarehouseID, WarehouseName, Area, Telephone " +
                    "from Warehouse" +
                    " where WarehouseID='" + this.CKBH_comboBoxB.Text.Trim() + "'";
                sadp.SelectCommand.CommandText = sql;
                sadp.Fill(ds);
                if (ds.Tables[0].Rows.Count > 0)
                {
                    this.CKMC_textBoxB.Text = ds.Tables[0].Rows[0][1].ToString().Trim();
                    this.CKMJ_textBox.Text = ds.Tables[0].Rows[0][2].ToString().Trim();
                    this.CKD_HtextBox.Text = ds.Tables[0].Rows[0][3].ToString().Trim();
                }
  
          //  }
        }

        private void RKSJ_dateTimeP_ValueChanged(object sender, EventArgs e)
        {
         //   MessageBox.Show(RKSJ, this.RKSJ_dateTimeP.Value.ToString());

            if (this.LJBH_comboB.Text.Trim() == "" || this.CKBH_comboBoxB.Text.Trim() == "")
            {
                MessageBox.Show("请选择零件编号和仓库号","提示");
                return ;
            }
           // if (RKSJ == null)
           // {
                DataSet ds = new DataSet();
                SqlDataAdapter sadp = new SqlDataAdapter("", sqlconn);
                string sql = "" +
                    "select InNum, EmployeeName " +
                    "from InInfo,Employee" +
                    " where InInfo.InEmployeeID=Employee.EmployeeID and " +
                    "InInfo.ComponentID='" + this.LJBH_comboB.Text.Trim() + "' " +
                    "and InInfo.WarehouseID='" + this.CKBH_comboBoxB.Text.Trim()+"' " +
                    "and Indate='"+this.RKSJ_dateTimeP.Value.ToString("yyyy-MM-dd").Trim()+"'";
            //   MessageBox.Show(sql,"");
                sadp.SelectCommand.CommandText = sql;
                sadp.Fill(ds);
                if (ds.Tables[0].Rows.Count > 0)
                {
                    this.RKSL_textB.Text = ds.Tables[0].Rows[0][0].ToString().Trim();
                    this.User_name_textB.Text = ds.Tables[0].Rows[0][1].ToString().Trim();
                }
                else
                {
                    this.User_name_textB.Text = "";
                    this.RKSL_textB.Text = "";
                }
           // }

        }

        private void Cancel_button_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
