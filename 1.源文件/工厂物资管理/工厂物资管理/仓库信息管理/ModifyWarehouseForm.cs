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
    public partial class ModifyWarehouseForm : Form
    {
        private SqlConnection sqlconn = null;
        private SqlCommand sqlcmd = null;
        public ModifyWarehouseForm()
        {
            InitializeComponent();
            this.sqlconn = new SqlConnection(DB.DBConnStr.ConnStr);
            this.sqlcmd = new SqlCommand();
            this.sqlcmd.Connection = this.sqlconn;

            // https://blog.csdn.net/boss2967/article/details/79019467
            //sql去重复操作详解SQL中distinct的用法

            DataSet ds = new DataSet();
            SqlDataAdapter sadp = new SqlDataAdapter("", sqlconn);
            sadp.SelectCommand.CommandText = "select distinct WarehouseID from Warehouse";
            sadp.Fill(ds);
            this.comboBox_ID.DataSource = ds.Tables[0].DefaultView;
            this.comboBox_ID.DisplayMember = "WarehouseID";
            this.comboBox_ID.ValueMember = "WarehouseID";
        }

        private void ModifyWarehousebutton_Click(object sender, EventArgs e)
        {
            if (this.comboBox_ID.Text.Trim() == "")
            {
                MessageBox.Show("请选择仓库编号！", "提示");
                return;
            }
            if (this.textBoxName.Text.Trim() == "")
            {
                MessageBox.Show("请输入仓库名！", "提示");
                return;
            }
            string tel = this.textBoxTelephone.Text.Trim();
            MessageBox.Show(tel);
            if (!Check.IsHandset(tel))
            {
                MessageBox.Show("请输入正确的国内手机号！", "提示");
                return;
            }
            //if (!Check.IsTelephone(tel))
            //{
            //    MessageBox.Show("请输入正确的座机号！", "提示");
            //    return;
            //}


            if (this.textBoxArea.Text.Trim() == "")
            {
                MessageBox.Show("请输入仓库面积！", "提示");
                return;
            }
            double Area;
            if (!double.TryParse(this.textBoxArea.Text.Trim(), out Area) || Area == 0)
            {
                MessageBox.Show("仓库面积请输入数字！", "提示");
                return;
            }
            try
            {
                if (sqlconn.State != ConnectionState.Open)
                {
                    sqlconn.Open();
                }
                string sql = "select * from Warehouse where WarehouseID = '" + this.comboBox_ID.Text.Trim() + "'";
                this.sqlcmd.CommandText = sql;
                if (sqlcmd.ExecuteScalar() == null)
                {
                    MessageBox.Show("仓库编号" + this.comboBox_ID.Text.Trim() + "不存在！", "警告");
                }
                else
                {
                //    sql = "insert into Warehouse(WarehouseID, WarehouseName, Area, Telephone) values ('"
                 //       + this.textBoxID.Text.Trim() + "','" + this.textBoxName.Text.Trim() + "'," + "" + this.textBoxArea.Text.Trim() + ",'" + this.textBoxTelephone.Text.Trim() + "')";
                    sql = "update Warehouse set WarehouseName='" + textBoxName.Text.Trim() + "',Area=" + textBoxArea.Text.Trim() + "," +
                                           "Telephone='" + textBoxTelephone.Text.Trim() + "' where WarehouseID='" + comboBox_ID.Text.Trim() + "'";
                    sqlcmd.CommandText = sql;
                    if (sqlcmd.ExecuteNonQuery() > 0)
                    {
                        MessageBox.Show("修改仓库信息成功！", "提示");
                    }
                    else
                    { MessageBox.Show("仓库信息修改失败！", "提示"); }

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

        private void ExitModifybutton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ModifyWarehouseForm_Load(object sender, EventArgs e)
        {

        }

        private void comboBox_ID_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataSet ds = new DataSet();
            SqlDataAdapter sadp = new SqlDataAdapter("", sqlconn);
            string sql = "" +
                "select WarehouseID, WarehouseName, Area, Telephone " +
                "from Warehouse" +
                " where WarehouseID='" + this.comboBox_ID.Text.Trim() + "'";
            sadp.SelectCommand.CommandText = sql;
            sadp.Fill(ds);
            if (ds.Tables[0].Rows.Count > 0)
            {
                this.textBoxName.Text = ds.Tables[0].Rows[0][1].ToString().Trim();
                this.textBoxArea.Text = ds.Tables[0].Rows[0][2].ToString().Trim();
                this.textBoxTelephone.Text = ds.Tables[0].Rows[0][3].ToString().Trim();
               // this.LJMS_textBoxB.Text = ds.Tables[0].Rows[0][4].ToString().Trim();
            }
        }
    }
}
