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
using 工厂物资管理.仓库信息管理;
using 工厂物资管理.加密;
using 工厂物资管理.库存管理.入库信息管理;
using 工厂物资管理.库存管理.出库信息管理;
using 工厂物资管理.库存管理.库存信息管理;
using 工厂物资管理.用户操作;
using 工厂物资管理.系统管理;
using 工厂物资管理.零件管理;

namespace 工厂物资管理
{
    public partial class MainForm : Form
    {
        private String EmployeeTitle =null;
        private String EmployeeID =null;
        private String EmployeeName =null;
        private SqlConnection sqlconn = null;
        private SqlCommand sqlcmd = null;
        private AddUserForm adduser = null;
        private AddTitleForm addTitle = null;
        private AddComponentForm addComponent = null;
        private QueryComponentForm queryComponent = null;
        private ModifyComponentForm modifyComponent = null;
        private AddWarehouseForm addWarehouse = null;
        private ModifyWarehouseForm modifyWarehouse = null;
        private QueryWarehouseForm queryWarehouse = null;
        private BrowseWarehouseForm browseWarehouse = null;
        private BrowseInventoryForm browseInventory = null;
        private QueryInventoryForm queryInventory = null;
        private AddInInventoryForm addInInventory = null;
        private ModifyInInventoryForm modifyInInventory = null;
        private BrowseInInventoryForm browseInInventory = null;
        private QueryInInventoryForm queryInInventory = null;
        private ModifyPasswdForm modifyPasswd = null;
        private AddOutInventoryForm addOutInventory = null;
        private QueryOutInventoryForm queryOutInventory = null;
        private BrowseOutInventoryForm browseOutInventory = null;
        private ModifyOutInventoryForm modifyOutInventory = null;
        private LookUserInfoForm LookUserInfo = null;
        private DeleteComponentForm deleteComponent = null;

        private AddFaceForm addFaceForm = null;


        public MainForm()
        {
            InitializeComponent();
        }
        public MainForm(String Title,String ID,String name)
        {
            this.EmployeeID = ID;
            this.EmployeeName = name;
            this.EmployeeTitle = Title;

            InitializeComponent();
            User_ID_toolStripStatusLabel.Text = this.EmployeeID;
            User_Title_toolStripStatusLabel.Text = EmployeeTitle;
            User_name_toolStripStatusLabel.Text = EmployeeName;
            sqlconn = new SqlConnection(DB.DBConnStr.ConnStr);
            sqlcmd = new SqlCommand();
            this.sqlcmd.Connection = sqlconn;
            string sql =string.Format("select SystemManage, MaterialManage, InManage, OutManage from Title "+
                        "where Title.TitleName='{0}'",this.EmployeeTitle);
            sqlcmd.CommandText = sql;
            try
            {
                if (sqlconn.State != ConnectionState.Open)
                {
                    sqlconn.Open();
                }
                SqlDataReader sdr = sqlcmd.ExecuteReader();
                if (sdr.Read())
                {
                    bool[] q=new bool[4];
                    q[0] = (bool)sdr.GetValue(0);
                    q[1] = (bool)sdr.GetValue(1);
                    q[2] = (bool)sdr.GetValue(2);
                    q[3] = (bool)sdr.GetValue(3);
                    if (this.EmployeeID == "admin")
                    {
                        this.查看用户信息ToolStripMenuItem.Visible = true;
                    }
                    else
                    {
                        this.查看用户信息ToolStripMenuItem.Visible = false;
                    }
                    系统管理ToolStripMenuItem.Visible = q[0];
                    物资管理ToolStripMenuItem.Visible = q[1];
                    仓库信息管理ToolStripMenuItem.Visible = q[0];
                    入库信息管理ToolStripMenuItem.Visible = q[2];
                    出库信息管理ToolStripMenuItem.Visible = q[3];
                    
                }
                sdr.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "数据库操作失败提示");
                //throw;
            }
            finally
            {
                sqlconn.Close();
            }
        }
        //主面板装载事件
        private void MainForm_Load(object sender, EventArgs e)
        {
            this.Sy_time_toolStripStatusLabel5.Text=DateTime.Now.ToString();
        }

        private void 添加用户ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (adduser == null || adduser.IsDisposed)
            {
                adduser = new AddUserForm();
                for (int i = 0; i < this.MdiChildren.Length; i++)
                {
                    Form tempChild = (Form)this.MdiChildren[i];
                    tempChild.Close();
                }
                this.IsMdiContainer = true;
                adduser.MdiParent = this;      //设置父窗体
                adduser.Show();
            }
        }

        private void 添加职称ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.addTitle == null || addTitle.IsDisposed)
            {
                addTitle = new AddTitleForm();
                for (int i = 0; i < this.MdiChildren.Length; i++)
                {
                    Form tempChild = (Form)this.MdiChildren[i];
                    tempChild.Close();
                }
                this.IsMdiContainer = true;
                addTitle.MdiParent = this;
                addTitle.Show();
            }
        }

        private void 添加零件ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (addComponent == null || addComponent.IsDisposed)
            {
                addComponent = new AddComponentForm();
                for (int i = 0; i < this.MdiChildren.Length; i++)
                {
                    Form tempChild = (Form)this.MdiChildren[i];
                    tempChild.Close();
                }
                this.IsMdiContainer = true;
                addComponent.MdiParent = this;
                addComponent.Show();
            }
        }

        private void 浏览零件信息ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (queryComponent == null || queryComponent.IsDisposed)
            {
                queryComponent = new QueryComponentForm();
                for (int i = 0; i < this.MdiChildren.Length; i++)
                {
                    Form tempChild = (Form)this.MdiChildren[i];
                    tempChild.Close();
                }
                this.IsMdiContainer = true;
                queryComponent.MdiParent = this;
                queryComponent.Show();
            }
        }

        private void 修改零件信息ToolStripMenuItem_Click(object sender, EventArgs e)
        {

            if (modifyComponent == null || modifyComponent.IsDisposed)
            {
                modifyComponent = new ModifyComponentForm();
                for (int i = 0; i < this.MdiChildren.Length; i++)
                {
                    Form tempChild = (Form)this.MdiChildren[i];
                    tempChild.Close();
                }
                this.IsMdiContainer = true;
                modifyComponent.MdiParent = this;
                modifyComponent.Show();
            }
        }

        private void 添加仓库信息ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (addWarehouse == null || addWarehouse.IsDisposed)
            {
                addWarehouse = new AddWarehouseForm();
                for (int i = 0; i < this.MdiChildren.Length; i++)
                {
                    Form tempChild = (Form)this.MdiChildren[i];
                    tempChild.Close();
                }
                this.IsMdiContainer = true;
                addWarehouse.MdiParent = this;
                addWarehouse.Show();
            }
        }

        private void 修改仓库信息ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (modifyWarehouse == null || modifyWarehouse.IsDisposed)
            {
                modifyWarehouse = new ModifyWarehouseForm();
                for (int i = 0; i < this.MdiChildren.Length; i++)
                {
                    Form tempChild = (Form)this.MdiChildren[i];
                    tempChild.Close();
                }
                this.IsMdiContainer = true;
                modifyWarehouse.MdiParent = this;
                modifyWarehouse.Show();
            }
        }

        private void 查询仓库信息ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (queryWarehouse == null || queryWarehouse.IsDisposed)
            {
                queryWarehouse = new QueryWarehouseForm();
                for (int i = 0; i < this.MdiChildren.Length; i++)
                {
                    Form tempChild = (Form)this.MdiChildren[i];
                    tempChild.Close();
                }
                this.IsMdiContainer = true;
                queryWarehouse.MdiParent = this;
                queryWarehouse.Show();
            }
        }

        private void 浏览仓库信息ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (browseWarehouse == null || browseWarehouse.IsDisposed)
            {
                browseWarehouse = new BrowseWarehouseForm();
                for (int i = 0; i < this.MdiChildren.Length; i++)
                {
                    Form tempChild = (Form)this.MdiChildren[i];
                    tempChild.Close();
                }
                this.IsMdiContainer = true;
                browseWarehouse.MdiParent = this;
                browseWarehouse.Show();
            }
        }

        private void 浏览库存信息ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (browseInventory == null || browseInventory.IsDisposed)
            {
                browseInventory = new BrowseInventoryForm();
                for (int i = 0; i < this.MdiChildren.Length; i++)
                {
                    Form tempChild = (Form)this.MdiChildren[i];
                    tempChild.Close();
                }
                this.IsMdiContainer = true;
                browseInventory.MdiParent = this;
                browseInventory.Show();
            }
        }

        private void 查询库存信息ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (queryInventory == null || queryInventory.IsDisposed)
            {
                queryInventory = new QueryInventoryForm();
                for (int i = 0; i < this.MdiChildren.Length; i++)
                {
                    Form tempChild = (Form)this.MdiChildren[i];
                    tempChild.Close();
                }
                this.IsMdiContainer = true;
                queryInventory.MdiParent = this;
                queryInventory.Show();
            }
        }

        private void 添加入库信息ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (addInInventory == null || addInInventory.IsDisposed)
            {
                //MessageBox.Show(this.User_ID_toolStripStatusLabel.Text.Trim(),"");
                addInInventory = new AddInInventoryForm(this.User_ID_toolStripStatusLabel.Text.Trim());
                for (int i = 0; i < this.MdiChildren.Length; i++)
                {
                    Form tempChild = (Form)this.MdiChildren[i];
                    tempChild.Close();
                }
                this.IsMdiContainer = true;
                addInInventory.MdiParent = this;
                addInInventory.Show();
            }
        }

        private void 修改入库信息ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (modifyInInventory == null || modifyInInventory.IsDisposed)
            {
                //MessageBox.Show(this.User_ID_toolStripStatusLabel.Text.Trim(),"");
                modifyInInventory = new ModifyInInventoryForm();
                for (int i = 0; i < this.MdiChildren.Length; i++)
                {
                    Form tempChild = (Form)this.MdiChildren[i];
                    tempChild.Close();
                }
                this.IsMdiContainer = true;
                modifyInInventory.MdiParent = this;
                modifyInInventory.Show();
            }
        }

        private void 浏览入库信息ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (browseInInventory == null || browseInInventory.IsDisposed)
            {
                //MessageBox.Show(this.User_ID_toolStripStatusLabel.Text.Trim(),"");
                browseInInventory = new BrowseInInventoryForm();
                for (int i = 0; i < this.MdiChildren.Length; i++)
                {
                    Form tempChild = (Form)this.MdiChildren[i];
                    tempChild.Close();
                }
                this.IsMdiContainer = true;
                browseInInventory.MdiParent = this;
                browseInInventory.Show();
            }
        }

        private void 查询入库信息ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (queryInInventory == null || queryInInventory.IsDisposed)
            {
                //MessageBox.Show(this.User_ID_toolStripStatusLabel.Text.Trim(),"");
                queryInInventory = new QueryInInventoryForm();
                for (int i = 0; i < this.MdiChildren.Length; i++)
                {
                    Form tempChild = (Form)this.MdiChildren[i];
                    tempChild.Close();
                }
                this.IsMdiContainer = true;
                queryInInventory.MdiParent = this;
                queryInInventory.Show();
            }
        }

        private void 重新登陆ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void 修改密码ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (modifyPasswd == null || modifyPasswd.IsDisposed)
            {
                //MessageBox.Show(this.User_ID_toolStripStatusLabel.Text.Trim(),"");
                modifyPasswd = new ModifyPasswdForm(this.User_ID_toolStripStatusLabel.Text.Trim(),this.User_name_toolStripStatusLabel.Text.Trim());
                for (int i = 0; i < this.MdiChildren.Length; i++)
                {
                    Form tempChild = (Form)this.MdiChildren[i];
                    tempChild.Close();
                }
                this.IsMdiContainer = true;
                modifyPasswd.MdiParent = this;
                modifyPasswd.Show();
            }
        }

        private void 出库信息管理ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void 添加出库信息ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (addOutInventory == null || addOutInventory.IsDisposed)
            {
                //MessageBox.Show(this.User_ID_toolStripStatusLabel.Text.Trim(),"");
                addOutInventory = new AddOutInventoryForm(this.User_ID_toolStripStatusLabel.Text.Trim());
                for (int i = 0; i < this.MdiChildren.Length; i++)
                {
                    Form tempChild = (Form)this.MdiChildren[i];
                    tempChild.Close();
                }
                this.IsMdiContainer = true;
                addOutInventory.MdiParent = this;
                addOutInventory.Show();
            }
        }

        private void 查询出库信息ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (queryOutInventory == null || queryOutInventory.IsDisposed)
            {
                //MessageBox.Show(this.User_ID_toolStripStatusLabel.Text.Trim(),"");
                queryOutInventory = new QueryOutInventoryForm();
                for (int i = 0; i < this.MdiChildren.Length; i++)
                {
                    Form tempChild = (Form)this.MdiChildren[i];
                    tempChild.Close();
                }
                this.IsMdiContainer = true;
                queryOutInventory.MdiParent = this;
                queryOutInventory.Show();
            }
        }

        private void 浏览出库信息ToolStripMenuItem_Click(object sender, EventArgs e)
        {

            if (browseOutInventory == null || browseOutInventory.IsDisposed)
            {
                //MessageBox.Show(this.User_ID_toolStripStatusLabel.Text.Trim(),"");
                browseOutInventory = new BrowseOutInventoryForm();
                for (int i = 0; i < this.MdiChildren.Length; i++)
                {
                    Form tempChild = (Form)this.MdiChildren[i];
                    tempChild.Close();
                }
                this.IsMdiContainer = true;
                browseOutInventory.MdiParent = this;
                browseOutInventory.Show();
            }
        }

        private void 修改出库信息ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (modifyOutInventory == null || modifyOutInventory.IsDisposed)
            {
                //MessageBox.Show(this.User_ID_toolStripStatusLabel.Text.Trim(),"");
                modifyOutInventory = new ModifyOutInventoryForm();
                for (int i = 0; i < this.MdiChildren.Length; i++)
                {
                    Form tempChild = (Form)this.MdiChildren[i];
                    tempChild.Close();
                }
                this.IsMdiContainer = true;
                modifyOutInventory.MdiParent = this;
                modifyOutInventory.Show();
            }
        }

        private void 查看用户信息ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LookUserInfo = null;
            if (LookUserInfo == null || LookUserInfo.IsDisposed)
            {
                //MessageBox.Show(this.User_ID_toolStripStatusLabel.Text.Trim(),"");
                LookUserInfo = new LookUserInfoForm();
                for (int i = 0; i < this.MdiChildren.Length; i++)
                {
                    Form tempChild = (Form)this.MdiChildren[i];
                    tempChild.Close();
                }
                this.IsMdiContainer = true;
                LookUserInfo.MdiParent = this;
                LookUserInfo.Show();
            }
        }

        private void 查看个人信息ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LookUserInfo = null;
            if (LookUserInfo == null || LookUserInfo.IsDisposed)
            {
                //MessageBox.Show(this.User_ID_toolStripStatusLabel.Text.Trim(),"");
                LookUserInfo = new LookUserInfoForm(this.User_ID_toolStripStatusLabel.Text.Trim());
                for (int i = 0; i < this.MdiChildren.Length; i++)
                {
                    Form tempChild = (Form)this.MdiChildren[i];
                    tempChild.Close();
                }
                this.IsMdiContainer = true;
                LookUserInfo.MdiParent = this;
                LookUserInfo.Show();
            }
        }

        private void 删除零件信息ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (deleteComponent == null || deleteComponent.IsDisposed)
            {
                //MessageBox.Show(this.User_ID_toolStripStatusLabel.Text.Trim(),"");
                deleteComponent = new DeleteComponentForm();
                for (int i = 0; i < this.MdiChildren.Length; i++)
                {
                    Form tempChild = (Form)this.MdiChildren[i];
                    tempChild.Close();
                }
                this.IsMdiContainer = true;
                deleteComponent.MdiParent = this;
                deleteComponent.Show();
            }
        }

        private void 人脸采集ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (addFaceForm == null || addFaceForm.IsDisposed)
            {
                //MessageBox.Show(this.User_ID_toolStripStatusLabel.Text.Trim(),"");
                addFaceForm = new AddFaceForm(this.User_ID_toolStripStatusLabel.Text.Trim());
                for (int i = 0; i < this.MdiChildren.Length; i++)
                {
                    Form tempChild = (Form)this.MdiChildren[i];
                    tempChild.Close();
                }
                this.IsMdiContainer = true;
                addFaceForm.MdiParent = this;
                addFaceForm.Show();
            }
        }
    }
}
