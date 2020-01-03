namespace 工厂物资管理.仓库信息管理
{
    partial class ModifyWarehouseForm
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
            this.textBoxArea = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.ExitModifybutton = new System.Windows.Forms.Button();
            this.ModifyWarehousebutton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxTelephone = new System.Windows.Forms.TextBox();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox_ID = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // textBoxArea
            // 
            this.textBoxArea.Location = new System.Drawing.Point(142, 234);
            this.textBoxArea.Name = "textBoxArea";
            this.textBoxArea.Size = new System.Drawing.Size(213, 25);
            this.textBoxArea.TabIndex = 3;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(34, 239);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(82, 15);
            this.label9.TabIndex = 64;
            this.label9.Text = "仓库面积：";
            // 
            // ExitModifybutton
            // 
            this.ExitModifybutton.Location = new System.Drawing.Point(280, 355);
            this.ExitModifybutton.Name = "ExitModifybutton";
            this.ExitModifybutton.Size = new System.Drawing.Size(75, 33);
            this.ExitModifybutton.TabIndex = 6;
            this.ExitModifybutton.Text = "退出";
            this.ExitModifybutton.UseVisualStyleBackColor = true;
            this.ExitModifybutton.Click += new System.EventHandler(this.ExitModifybutton_Click);
            // 
            // ModifyWarehousebutton
            // 
            this.ModifyWarehousebutton.Location = new System.Drawing.Point(69, 356);
            this.ModifyWarehousebutton.Name = "ModifyWarehousebutton";
            this.ModifyWarehousebutton.Size = new System.Drawing.Size(75, 32);
            this.ModifyWarehousebutton.TabIndex = 5;
            this.ModifyWarehousebutton.Text = "修改";
            this.ModifyWarehousebutton.UseVisualStyleBackColor = true;
            this.ModifyWarehousebutton.Click += new System.EventHandler(this.ModifyWarehousebutton_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("楷体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(32, 59);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(168, 25);
            this.label3.TabIndex = 61;
            this.label3.Text = "修改仓库信息";
            // 
            // textBoxTelephone
            // 
            this.textBoxTelephone.Location = new System.Drawing.Point(142, 290);
            this.textBoxTelephone.Name = "textBoxTelephone";
            this.textBoxTelephone.Size = new System.Drawing.Size(213, 25);
            this.textBoxTelephone.TabIndex = 4;
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(142, 179);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(213, 25);
            this.textBoxName.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(34, 184);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 15);
            this.label4.TabIndex = 55;
            this.label4.Text = "仓 库 名：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(34, 295);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 15);
            this.label2.TabIndex = 57;
            this.label2.Text = "电话号码：";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 131);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 15);
            this.label1.TabIndex = 56;
            this.label1.Text = "仓 库 号：";
            // 
            // comboBox_ID
            // 
            this.comboBox_ID.FormattingEnabled = true;
            this.comboBox_ID.Location = new System.Drawing.Point(142, 128);
            this.comboBox_ID.Name = "comboBox_ID";
            this.comboBox_ID.Size = new System.Drawing.Size(213, 23);
            this.comboBox_ID.TabIndex = 1;
            this.comboBox_ID.SelectedIndexChanged += new System.EventHandler(this.comboBox_ID_SelectedIndexChanged);
            // 
            // ModifyWarehouseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(399, 446);
            this.Controls.Add(this.comboBox_ID);
            this.Controls.Add(this.textBoxArea);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.ExitModifybutton);
            this.Controls.Add(this.ModifyWarehousebutton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxTelephone);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "ModifyWarehouseForm";
            this.Text = "ModifyWarehouseForm";
            this.Load += new System.EventHandler(this.ModifyWarehouseForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxArea;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button ExitModifybutton;
        private System.Windows.Forms.Button ModifyWarehousebutton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxTelephone;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox_ID;
    }
}