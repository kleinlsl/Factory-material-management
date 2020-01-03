namespace 工厂物资管理.零件管理
{
    partial class DeleteComponentForm
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
            this.comboBox_id = new System.Windows.Forms.ComboBox();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.ExitModifybutton = new System.Windows.Forms.Button();
            this.ModifyComponentbutton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxDescribe = new System.Windows.Forms.TextBox();
            this.textBoxUnitprice = new System.Windows.Forms.TextBox();
            this.textBoxFormat = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // comboBox_id
            // 
            this.comboBox_id.FormattingEnabled = true;
            this.comboBox_id.Location = new System.Drawing.Point(158, 120);
            this.comboBox_id.Name = "comboBox_id";
            this.comboBox_id.Size = new System.Drawing.Size(213, 23);
            this.comboBox_id.TabIndex = 54;
            this.comboBox_id.SelectedIndexChanged += new System.EventHandler(this.comboBox_id_SelectedIndexChanged);
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(158, 174);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.ReadOnly = true;
            this.textBoxName.Size = new System.Drawing.Size(213, 25);
            this.textBoxName.TabIndex = 55;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(50, 179);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(82, 15);
            this.label9.TabIndex = 66;
            this.label9.Text = "零件名称：";
            // 
            // ExitModifybutton
            // 
            this.ExitModifybutton.Location = new System.Drawing.Point(296, 398);
            this.ExitModifybutton.Name = "ExitModifybutton";
            this.ExitModifybutton.Size = new System.Drawing.Size(75, 33);
            this.ExitModifybutton.TabIndex = 60;
            this.ExitModifybutton.Text = "退出";
            this.ExitModifybutton.UseVisualStyleBackColor = true;
            // 
            // ModifyComponentbutton
            // 
            this.ModifyComponentbutton.Location = new System.Drawing.Point(85, 399);
            this.ModifyComponentbutton.Name = "ModifyComponentbutton";
            this.ModifyComponentbutton.Size = new System.Drawing.Size(75, 32);
            this.ModifyComponentbutton.TabIndex = 59;
            this.ModifyComponentbutton.Text = "确认删除";
            this.ModifyComponentbutton.UseVisualStyleBackColor = true;
            this.ModifyComponentbutton.Click += new System.EventHandler(this.ModifyComponentbutton_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("楷体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(48, 51);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(116, 25);
            this.label3.TabIndex = 65;
            this.label3.Text = "删除零件";
            // 
            // textBoxDescribe
            // 
            this.textBoxDescribe.Location = new System.Drawing.Point(158, 338);
            this.textBoxDescribe.MaxLength = 80;
            this.textBoxDescribe.Name = "textBoxDescribe";
            this.textBoxDescribe.ReadOnly = true;
            this.textBoxDescribe.Size = new System.Drawing.Size(213, 25);
            this.textBoxDescribe.TabIndex = 58;
            // 
            // textBoxUnitprice
            // 
            this.textBoxUnitprice.Location = new System.Drawing.Point(158, 286);
            this.textBoxUnitprice.Name = "textBoxUnitprice";
            this.textBoxUnitprice.ReadOnly = true;
            this.textBoxUnitprice.Size = new System.Drawing.Size(213, 25);
            this.textBoxUnitprice.TabIndex = 57;
            // 
            // textBoxFormat
            // 
            this.textBoxFormat.Location = new System.Drawing.Point(158, 230);
            this.textBoxFormat.Name = "textBoxFormat";
            this.textBoxFormat.ReadOnly = true;
            this.textBoxFormat.Size = new System.Drawing.Size(213, 25);
            this.textBoxFormat.TabIndex = 56;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(50, 343);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 15);
            this.label5.TabIndex = 62;
            this.label5.Text = "描    述：";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(50, 291);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 15);
            this.label4.TabIndex = 63;
            this.label4.Text = "零件单价：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(50, 235);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 15);
            this.label2.TabIndex = 64;
            this.label2.Text = "零件规格：";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(50, 123);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 15);
            this.label1.TabIndex = 61;
            this.label1.Text = "零 件 号：";
            // 
            // DeleteComponentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(418, 482);
            this.Controls.Add(this.comboBox_id);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.ExitModifybutton);
            this.Controls.Add(this.ModifyComponentbutton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxDescribe);
            this.Controls.Add(this.textBoxUnitprice);
            this.Controls.Add(this.textBoxFormat);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "DeleteComponentForm";
            this.Text = "DeleteComponentForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox_id;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button ExitModifybutton;
        private System.Windows.Forms.Button ModifyComponentbutton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxDescribe;
        private System.Windows.Forms.TextBox textBoxUnitprice;
        private System.Windows.Forms.TextBox textBoxFormat;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}