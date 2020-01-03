using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AForge.Video.DirectShow;
using 工厂物资管理.Face;

namespace 工厂物资管理.用户操作
{
    public partial class AddFaceForm : Form
    {
        private FilterInfoCollection videoDevices = null;
        private VideoCaptureDevice videoSource = null;
        private string EmployeeID = null;
        private int Indexof = 0;

        public AddFaceForm(string userid)
        {
            InitializeComponent();

            this.EmployeeID = userid;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

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
            String imagestr = Util.ImgToBase64String(bitmap);
         //   MessageBox.Show("01", imagestr.Substring(1, 10));

            videoSourcePlayer1.Stop();

            //检索人脸是否存在
            SearchResult searchResult = FaceSearch.faceSearch(imagestr);
            if (searchResult.error_msg.Equals("SUCCESS")&&searchResult.result.user_list[0].user_id.Equals(this.EmployeeID))
            {
                MessageBox.Show("已采集，不可重复采集","提示信息");      
            }
            else
            {
                AddResult result=FaceAdd.add(imagestr,this.EmployeeID);
                if (result.error_msg.Equals("SUCCESS"))
                {
                    MessageBox.Show("采集成功","提示信息");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("采集未成功","提示信息");
                }
            }
        }
    }
}
