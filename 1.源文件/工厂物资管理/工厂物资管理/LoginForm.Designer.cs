namespace 工厂物资管理
{
    partial class LoginForm
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button退出 = new System.Windows.Forms.Button();
            this.button登陆 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox用户名 = new System.Windows.Forms.TextBox();
            this.textBox密码 = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("楷体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(280, 61);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(220, 25);
            this.label3.TabIndex = 13;
            this.label3.Text = "工厂物资管理系统";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.button退出);
            this.groupBox1.Controls.Add(this.button登陆);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.textBox用户名);
            this.groupBox1.Controls.Add(this.textBox密码);
            this.groupBox1.Location = new System.Drawing.Point(203, 105);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(366, 284);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Login";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(72, 232);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(230, 36);
            this.button1.TabIndex = 15;
            this.button1.Text = "人脸登陆";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button退出
            // 
            this.button退出.BackColor = System.Drawing.Color.PaleTurquoise;
            this.button退出.Location = new System.Drawing.Point(227, 167);
            this.button退出.Name = "button退出";
            this.button退出.Size = new System.Drawing.Size(75, 34);
            this.button退出.TabIndex = 16;
            this.button退出.Text = "退出";
            this.button退出.UseVisualStyleBackColor = false;
            this.button退出.Click += new System.EventHandler(this.button退出_Click);
            // 
            // button登陆
            // 
            this.button登陆.BackColor = System.Drawing.Color.PaleTurquoise;
            this.button登陆.Location = new System.Drawing.Point(72, 167);
            this.button登陆.Name = "button登陆";
            this.button登陆.Size = new System.Drawing.Size(75, 34);
            this.button登陆.TabIndex = 15;
            this.button登陆.Text = "登陆";
            this.button登陆.UseVisualStyleBackColor = false;
            this.button登陆.Click += new System.EventHandler(this.button登陆_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(46, 114);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 15);
            this.label2.TabIndex = 40;
            this.label2.Text = "密  码";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(46, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 15);
            this.label1.TabIndex = 40;
            this.label1.Text = "用户名";
            // 
            // textBox用户名
            // 
            this.textBox用户名.BackColor = System.Drawing.Color.Snow;
            this.textBox用户名.Location = new System.Drawing.Point(113, 37);
            this.textBox用户名.Name = "textBox用户名";
            this.textBox用户名.Size = new System.Drawing.Size(207, 25);
            this.textBox用户名.TabIndex = 13;
            // 
            // textBox密码
            // 
            this.textBox密码.BackColor = System.Drawing.Color.Snow;
            this.textBox密码.Location = new System.Drawing.Point(113, 111);
            this.textBox密码.Name = "textBox密码";
            this.textBox密码.PasswordChar = '*';
            this.textBox密码.Size = new System.Drawing.Size(207, 25);
            this.textBox密码.TabIndex = 14;
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "登陆";
            this.Load += new System.EventHandler(this.LoginForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button退出;
        private System.Windows.Forms.Button button登陆;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox用户名;
        private System.Windows.Forms.TextBox textBox密码;
        private System.Windows.Forms.Button button1;
    }
}

