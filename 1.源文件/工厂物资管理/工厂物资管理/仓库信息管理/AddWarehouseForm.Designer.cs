namespace 工厂物资管理.仓库信息管理
{
    partial class AddWarehouseForm
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
            this.ExitAddbutton = new System.Windows.Forms.Button();
            this.AddWarehousebutton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxTelephone = new System.Windows.Forms.TextBox();
            this.textBoxID = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // textBoxArea
            // 
            this.textBoxArea.Location = new System.Drawing.Point(140, 226);
            this.textBoxArea.Name = "textBoxArea";
            this.textBoxArea.Size = new System.Drawing.Size(213, 25);
            this.textBoxArea.TabIndex = 3;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(32, 231);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(82, 15);
            this.label9.TabIndex = 53;
            this.label9.Text = "仓库面积：";
            // 
            // ExitAddbutton
            // 
            this.ExitAddbutton.Location = new System.Drawing.Point(278, 347);
            this.ExitAddbutton.Name = "ExitAddbutton";
            this.ExitAddbutton.Size = new System.Drawing.Size(75, 33);
            this.ExitAddbutton.TabIndex = 6;
            this.ExitAddbutton.Text = "退出";
            this.ExitAddbutton.UseVisualStyleBackColor = true;
            this.ExitAddbutton.Click += new System.EventHandler(this.ExitAddbutton_Click);
            // 
            // AddWarehousebutton
            // 
            this.AddWarehousebutton.Location = new System.Drawing.Point(67, 348);
            this.AddWarehousebutton.Name = "AddWarehousebutton";
            this.AddWarehousebutton.Size = new System.Drawing.Size(75, 32);
            this.AddWarehousebutton.TabIndex = 5;
            this.AddWarehousebutton.Text = "添加";
            this.AddWarehousebutton.UseVisualStyleBackColor = true;
            this.AddWarehousebutton.Click += new System.EventHandler(this.AddWarehousebutton_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("楷体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(30, 51);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(116, 25);
            this.label3.TabIndex = 50;
            this.label3.Text = "添加仓库";
            // 
            // textBoxTelephone
            // 
            this.textBoxTelephone.Location = new System.Drawing.Point(140, 282);
            this.textBoxTelephone.Name = "textBoxTelephone";
            this.textBoxTelephone.Size = new System.Drawing.Size(213, 25);
            this.textBoxTelephone.TabIndex = 4;
            // 
            // textBoxID
            // 
            this.textBoxID.Location = new System.Drawing.Point(140, 118);
            this.textBoxID.Name = "textBoxID";
            this.textBoxID.Size = new System.Drawing.Size(213, 25);
            this.textBoxID.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 287);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 15);
            this.label2.TabIndex = 45;
            this.label2.Text = "电话号码：";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 123);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 15);
            this.label1.TabIndex = 42;
            this.label1.Text = "仓 库 号：";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(32, 176);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 15);
            this.label4.TabIndex = 42;
            this.label4.Text = "仓 库 名：";
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(140, 171);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(213, 25);
            this.textBoxName.TabIndex = 2;
            // 
            // AddWarehouseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(410, 452);
            this.Controls.Add(this.textBoxArea);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.ExitAddbutton);
            this.Controls.Add(this.AddWarehousebutton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxTelephone);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.textBoxID);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "AddWarehouseForm";
            this.Text = "AddWarehouseForm";
            this.Load += new System.EventHandler(this.AddWarehouseForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxArea;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button ExitAddbutton;
        private System.Windows.Forms.Button AddWarehousebutton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxTelephone;
        private System.Windows.Forms.TextBox textBoxID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxName;
    }
}