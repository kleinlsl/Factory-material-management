using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//using System.Drawing;
using AForge.Video.DirectShow;
using 工厂物资管理.Face;
using Newtonsoft.Json;
using System.Data.SqlClient;

namespace 工厂物资管理
{
    public partial class FaceLoginForm : Form
    {

        private FilterInfoCollection videoDevices = null;
        private VideoCaptureDevice videoSource = null;
        private string EmployeeID = null;
        private int Indexof = 0;

        private SqlConnection sqlConnection = null;
        private SqlCommand sqlCommand = null;
        public FaceLoginForm()
        {
            InitializeComponent();

            this.sqlConnection = new SqlConnection(DB.DBConnStr.ConnStr);
            this.sqlCommand = new SqlCommand();
            this.sqlCommand.Connection = this.sqlConnection;
        }

        private void Checkcam_Click(object sender, EventArgs e)
        {
            Camlist();
        }

        private void Camlist()
        {
            videoDevices = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            Cameralist.Items.Clear();
            if (videoDevices.Count == 0)
            {
                MessageBox.Show("未找到摄像头设备");
            }
            else
            {
                foreach (FilterInfo device in videoDevices)
                {
                    Cameralist.Items.Add(device.Name);
                }
                //if(Cameralist)
                Cameralist.SelectedIndex = 1;
            }

        }

        private void Select_button_Click(object sender, EventArgs e)
        {
            Indexof = Cameralist.SelectedIndex;
            if (Indexof <= 0)
            {
                MessageBox.Show("请选择一个摄像头");
                return;
            }
            //在1个或以上摄像头进行切换时执行
            videoSourcePlayer1.SignalToStop();
            videoSourcePlayer1.WaitForStop();
            this.pictureBox1.Visible = false;
            this.videoSourcePlayer1.Visible = true;
            //videoDevices[Indexof]确定出用哪个摄像头了。
            videoSource = new VideoCaptureDevice(videoDevices[Indexof].MonikerString);
            //设置下像素，这句话不写也可以正常运行：
            //videoSource.VideoResolution = videoSource.VideoCapabilities[Indexof];
            //在videoSourcePlayer1里显示
            videoSourcePlayer1.VideoSource = videoSource;
            videoSourcePlayer1.Start();

        }

        private void TiJiao_button_Click(object sender, EventArgs e)
        {
            if (videoSource == null)
            {
                MessageBox.Show("请先打开摄像头");
                return;
            }
            //videoSourcePlayer继承Control父类，定义 GetCurrentVideoFrame能输出bitmap
            Bitmap bitmap = videoSourcePlayer1.GetCurrentVideoFrame();
            pictureBox1.Image = bitmap;
            this.videoSourcePlayer1.Visible = false;
            this.pictureBox1.Visible = true;
            //这里停止摄像头继续工作 当然videoSourcePlayer里也定义了 Stop();用哪个都行

            //    string imagestr = this.pictureBox1.Image.ToString();
            //  
           bitmap = videoSourcePlayer1.GetCurrentVideoFrame();
            String imagestr=Util.ImgToBase64String(bitmap);
           // MessageBox.Show("01",imagestr.Substring(1,10));
            
            videoSourcePlayer1.Stop();

            checkFace(imagestr);
            if (this.EmployeeID != null)
            {
                login();
            }
            // videoSourcePlayer1.SignalToStop(); videoSourcePlayer1.WaitForStop();
            //原文链接：https://blog.csdn.net/u013667895/article/details/78426649
        }
        private void login()
        {
            try
            {
                if (sqlConnection.State != ConnectionState.Open)
                {
                    sqlConnection.Open();
                }
                string sql = string.Format("select EmployeeID,EmployeePwd,EmployeeName,Employee.EmployeeTitle " +
                    "from Employee " +
                    "where Employee.EmployeeID = '{0}'", this.EmployeeID);
                sqlCommand.CommandText = sql;
                SqlDataReader sdr = sqlCommand.ExecuteReader();
                if (sdr.HasRows)
                {
                    //有返回行
                    sdr.Read();

                    if (sdr[0].ToString() == this.EmployeeID)
                    {//输入用户名和密码等于查询结果中用户名和密码

                        MainForm mform = new MainForm(sdr[3].ToString(), sdr[0].ToString(), sdr[2].ToString());
                        sdr.Close();
                        this.Hide();
                        mform.ShowDialog();
                        this.Close();
                        //this.Show();
                    }
                    else
                    {
                        sdr.Close();
                        MessageBox.Show("登陆失败，请重新尝试！", "SQL注入攻击无效,提示信息");
                    }

                }
                else
                {
                    //无返回行
                    MessageBox.Show("登陆失败，请重新尝试！", "提示信息");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "数据库操作问题提示");
                //throw;
            }
            finally
            {
                sqlConnection.Close();
            }
        }
        private void checkFace(string image)
        {
            //识别
            SearchResult searchResult = FaceSearch.faceSearch(image);
            
            if (searchResult.error_msg.Equals("SUCCESS"))
            {
                string score=searchResult.result.user_list[0].score;
              //  MessageBox.Show(score);
                if (Double.Parse(score)>85.0)
                {
                    this.EmployeeID = searchResult.result.user_list[0].user_id;
                    MessageBox.Show("验证成功");
                }
                else
                {
                    MessageBox.Show("未成功，请确认已采集人脸后再试！","验证失败");
                }
            }
            else
            {
                MessageBox.Show("未成功，请确认已采集人脸后再试！", "验证失败");
            }
        }

        private void FaceLoginForm_Load(object sender, EventArgs e)
        {
          //  String str=AuthService.getAccessToken();
          //  Token token = JsonConvert.DeserializeObject<Token>(str);
          //  MessageBox.Show(token.access_token);
        }

        private void FaceLoginForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (videoSource != null)
            {
                videoSourcePlayer1.Stop();
            }
        }
    }
}
