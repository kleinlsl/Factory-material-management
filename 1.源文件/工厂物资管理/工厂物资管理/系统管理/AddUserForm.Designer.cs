namespace 工厂物资管理.系统管理
{
    partial class AddUserForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.textBoxUserID = new System.Windows.Forms.TextBox();
            this.textBoxOnce_Password = new System.Windows.Forms.TextBox();
            this.textBoxUserName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.AddUserbutton = new System.Windows.Forms.Button();
            this.ExitAddUserbutton = new System.Windows.Forms.Button();
            this.comboBoxUserTitle = new System.Windows.Forms.ComboBox();
            this.comboBoxUser_Warehouse = new System.Windows.Forms.ComboBox();
            this.comboBoxUser_Leader = new System.Windows.Forms.ComboBox();
            this.comboBoxUserAge = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(70, 104);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "职 工 号：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(70, 216);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 15);
            this.label2.TabIndex = 0;
            this.label2.Text = "确认密码：";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(70, 272);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 15);
            this.label4.TabIndex = 0;
            this.label4.Text = "姓    名：";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(70, 326);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 15);
            this.label5.TabIndex = 0;
            this.label5.Text = "年    龄：";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(70, 380);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(84, 15);
            this.label6.TabIndex = 0;
            this.label6.Text = "职    称：";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(70, 434);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(84, 15);
            this.label7.TabIndex = 0;
            this.label7.Text = "仓    库：";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(70, 488);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(84, 15);
            this.label8.TabIndex = 0;
            this.label8.Text = "领    导：";
            // 
            // textBoxUserID
            // 
            this.textBoxUserID.Location = new System.Drawing.Point(178, 99);
            this.textBoxUserID.Name = "textBoxUserID";
            this.textBoxUserID.Size = new System.Drawing.Size(213, 25);
            this.textBoxUserID.TabIndex = 1;
            // 
            // textBoxOnce_Password
            // 
            this.textBoxOnce_Password.Location = new System.Drawing.Point(178, 211);
            this.textBoxOnce_Password.Name = "textBoxOnce_Password";
            this.textBoxOnce_Password.PasswordChar = '*';
            this.textBoxOnce_Password.Size = new System.Drawing.Size(213, 25);
            this.textBoxOnce_Password.TabIndex = 3;
            // 
            // textBoxUserName
            // 
            this.textBoxUserName.Location = new System.Drawing.Point(178, 267);
            this.textBoxUserName.Name = "textBoxUserName";
            this.textBoxUserName.Size = new System.Drawing.Size(213, 25);
            this.textBoxUserName.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("楷体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(68, 32);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(116, 25);
            this.label3.TabIndex = 14;
            this.label3.Text = "添加职工";
            // 
            // AddUserbutton
            // 
            this.AddUserbutton.Location = new System.Drawing.Point(105, 557);
            this.AddUserbutton.Name = "AddUserbutton";
            this.AddUserbutton.Size = new System.Drawing.Size(75, 32);
            this.AddUserbutton.TabIndex = 9;
            this.AddUserbutton.Text = "添加";
            this.AddUserbutton.UseVisualStyleBackColor = true;
            this.AddUserbutton.Click += new System.EventHandler(this.AddUserbutton_Click);
            // 
            // ExitAddUserbutton
            // 
            this.ExitAddUserbutton.Location = new System.Drawing.Point(316, 556);
            this.ExitAddUserbutton.Name = "ExitAddUserbutton";
            this.ExitAddUserbutton.Size = new System.Drawing.Size(75, 33);
            this.ExitAddUserbutton.TabIndex = 10;
            this.ExitAddUserbutton.Text = "退出";
            this.ExitAddUserbutton.UseVisualStyleBackColor = true;
            this.ExitAddUserbutton.Click += new System.EventHandler(this.button2_Click);
            // 
            // comboBoxUserTitle
            // 
            this.comboBoxUserTitle.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxUserTitle.FormattingEnabled = true;
            this.comboBoxUserTitle.Location = new System.Drawing.Point(178, 377);
            this.comboBoxUserTitle.Name = "comboBoxUserTitle";
            this.comboBoxUserTitle.Size = new System.Drawing.Size(213, 23);
            this.comboBoxUserTitle.TabIndex = 6;
            // 
            // comboBoxUser_Warehouse
            // 
            this.comboBoxUser_Warehouse.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxUser_Warehouse.FormattingEnabled = true;
            this.comboBoxUser_Warehouse.Location = new System.Drawing.Point(178, 431);
            this.comboBoxUser_Warehouse.Name = "comboBoxUser_Warehouse";
            this.comboBoxUser_Warehouse.Size = new System.Drawing.Size(213, 23);
            this.comboBoxUser_Warehouse.TabIndex = 7;
            // 
            // comboBoxUser_Leader
            // 
            this.comboBoxUser_Leader.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxUser_Leader.FormattingEnabled = true;
            this.comboBoxUser_Leader.Location = new System.Drawing.Point(178, 485);
            this.comboBoxUser_Leader.Name = "comboBoxUser_Leader";
            this.comboBoxUser_Leader.Size = new System.Drawing.Size(213, 23);
            this.comboBoxUser_Leader.TabIndex = 8;
            // 
            // comboBoxUserAge
            // 
            this.comboBoxUserAge.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxUserAge.FormattingEnabled = true;
            this.comboBoxUserAge.Location = new System.Drawing.Point(178, 323);
            this.comboBoxUserAge.Name = "comboBoxUserAge";
            this.comboBoxUserAge.Size = new System.Drawing.Size(213, 23);
            this.comboBoxUserAge.TabIndex = 5;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(70, 160);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(84, 15);
            this.label9.TabIndex = 21;
            this.label9.Text = "密    码：";
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.Location = new System.Drawing.Point(178, 155);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.PasswordChar = '*';
            this.textBoxPassword.Size = new System.Drawing.Size(213, 25);
            this.textBoxPassword.TabIndex = 2;
            // 
            // AddUserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(503, 633);
            this.Controls.Add(this.textBoxPassword);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.comboBoxUserAge);
            this.Controls.Add(this.comboBoxUser_Leader);
            this.Controls.Add(this.comboBoxUser_Warehouse);
            this.Controls.Add(this.comboBoxUserTitle);
            this.Controls.Add(this.ExitAddUserbutton);
            this.Controls.Add(this.AddUserbutton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxUserName);
            this.Controls.Add(this.textBoxOnce_Password);
            this.Controls.Add(this.textBoxUserID);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "AddUserForm";
            this.Text = "AddUserForm";
            this.Load += new System.EventHandler(this.AddUserForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBoxUserID;
        private System.Windows.Forms.TextBox textBoxOnce_Password;
        private System.Windows.Forms.TextBox textBoxUserName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button AddUserbutton;
        private System.Windows.Forms.Button ExitAddUserbutton;
        private System.Windows.Forms.ComboBox comboBoxUserTitle;
        private System.Windows.Forms.ComboBox comboBoxUser_Warehouse;
        private System.Windows.Forms.ComboBox comboBoxUser_Leader;
        private System.Windows.Forms.ComboBox comboBoxUserAge;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBoxPassword;
    }
}