namespace 工厂物资管理.用户操作
{
    partial class AddFaceForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddFaceForm));
            this.pictureBox1 = new AForge.Controls.PictureBox();
            this.videoSourcePlayer1 = new AForge.Controls.VideoSourcePlayer();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Cameralist = new System.Windows.Forms.ComboBox();
            this.TiJiao_button = new System.Windows.Forms.Button();
            this.Checkcam = new System.Windows.Forms.Button();
            this.Select_button = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(66, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(443, 263);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // videoSourcePlayer1
            // 
            this.videoSourcePlayer1.Location = new System.Drawing.Point(66, 12);
            this.videoSourcePlayer1.Name = "videoSourcePlayer1";
            this.videoSourcePlayer1.Size = new System.Drawing.Size(443, 263);
            this.videoSourcePlayer1.TabIndex = 8;
            this.videoSourcePlayer1.Text = "videoSourcePlayer1";
            this.videoSourcePlayer1.VideoSource = null;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(348, 301);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(170, 25);
            this.textBox1.TabIndex = 18;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(82, 306);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 15);
            this.label1.TabIndex = 17;
            this.label1.Text = "选择设备";
            // 
            // Cameralist
            // 
            this.Cameralist.FormattingEnabled = true;
            this.Cameralist.Location = new System.Drawing.Point(158, 303);
            this.Cameralist.Name = "Cameralist";
            this.Cameralist.Size = new System.Drawing.Size(151, 23);
            this.Cameralist.TabIndex = 16;
            // 
            // TiJiao_button
            // 
            this.TiJiao_button.Location = new System.Drawing.Point(348, 348);
            this.TiJiao_button.Name = "TiJiao_button";
            this.TiJiao_button.Size = new System.Drawing.Size(108, 38);
            this.TiJiao_button.TabIndex = 13;
            this.TiJiao_button.Text = "抓拍添加";
            this.TiJiao_button.UseVisualStyleBackColor = true;
            this.TiJiao_button.Click += new System.EventHandler(this.TiJiao_button_Click);
            // 
            // Checkcam
            // 
            this.Checkcam.Location = new System.Drawing.Point(66, 348);
            this.Checkcam.Name = "Checkcam";
            this.Checkcam.Size = new System.Drawing.Size(97, 40);
            this.Checkcam.TabIndex = 14;
            this.Checkcam.Text = "检索设备";
            this.Checkcam.UseVisualStyleBackColor = true;
            this.Checkcam.Click += new System.EventHandler(this.Checkcam_Click);
            // 
            // Select_button
            // 
            this.Select_button.Location = new System.Drawing.Point(200, 350);
            this.Select_button.Name = "Select_button";
            this.Select_button.Size = new System.Drawing.Size(109, 38);
            this.Select_button.TabIndex = 15;
            this.Select_button.Text = "打开摄像头";
            this.Select_button.UseVisualStyleBackColor = true;
            this.Select_button.Click += new System.EventHandler(this.Select_button_Click);
            // 
            // AddFaceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(589, 458);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Cameralist);
            this.Controls.Add(this.TiJiao_button);
            this.Controls.Add(this.Checkcam);
            this.Controls.Add(this.Select_button);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.videoSourcePlayer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "AddFaceForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddFaceForm";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private AForge.Controls.PictureBox pictureBox1;
        private AForge.Controls.VideoSourcePlayer videoSourcePlayer1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox Cameralist;
        private System.Windows.Forms.Button TiJiao_button;
        private System.Windows.Forms.Button Checkcam;
        private System.Windows.Forms.Button Select_button;
    }
}