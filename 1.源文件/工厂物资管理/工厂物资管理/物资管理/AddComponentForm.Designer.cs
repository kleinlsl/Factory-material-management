namespace 工厂物资管理.零件管理
{
    partial class AddComponentForm
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
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.ExitAddbutton = new System.Windows.Forms.Button();
            this.AddComponentbutton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxUnitprice = new System.Windows.Forms.TextBox();
            this.textBoxFormat = new System.Windows.Forms.TextBox();
            this.textBoxID = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxDescribe = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(177, 148);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(213, 25);
            this.textBoxName.TabIndex = 2;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(69, 153);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(82, 15);
            this.label9.TabIndex = 40;
            this.label9.Text = "零件名称：";
            // 
            // ExitAddbutton
            // 
            this.ExitAddbutton.Location = new System.Drawing.Point(315, 372);
            this.ExitAddbutton.Name = "ExitAddbutton";
            this.ExitAddbutton.Size = new System.Drawing.Size(75, 33);
            this.ExitAddbutton.TabIndex = 7;
            this.ExitAddbutton.Text = "退出";
            this.ExitAddbutton.UseVisualStyleBackColor = true;
            this.ExitAddbutton.Click += new System.EventHandler(this.ExitAddbutton_Click);
            // 
            // AddComponentbutton
            // 
            this.AddComponentbutton.Location = new System.Drawing.Point(104, 373);
            this.AddComponentbutton.Name = "AddComponentbutton";
            this.AddComponentbutton.Size = new System.Drawing.Size(75, 32);
            this.AddComponentbutton.TabIndex = 6;
            this.AddComponentbutton.Text = "添加";
            this.AddComponentbutton.UseVisualStyleBackColor = true;
            this.AddComponentbutton.Click += new System.EventHandler(this.AddComponentbutton_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("楷体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(67, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(116, 25);
            this.label3.TabIndex = 33;
            this.label3.Text = "添加物资";
            // 
            // textBoxUnitprice
            // 
            this.textBoxUnitprice.Location = new System.Drawing.Point(177, 260);
            this.textBoxUnitprice.Name = "textBoxUnitprice";
            this.textBoxUnitprice.Size = new System.Drawing.Size(213, 25);
            this.textBoxUnitprice.TabIndex = 4;
            // 
            // textBoxFormat
            // 
            this.textBoxFormat.Location = new System.Drawing.Point(177, 204);
            this.textBoxFormat.Name = "textBoxFormat";
            this.textBoxFormat.Size = new System.Drawing.Size(213, 25);
            this.textBoxFormat.TabIndex = 3;
            // 
            // textBoxID
            // 
            this.textBoxID.Location = new System.Drawing.Point(177, 92);
            this.textBoxID.Name = "textBoxID";
            this.textBoxID.Size = new System.Drawing.Size(213, 25);
            this.textBoxID.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(69, 265);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 15);
            this.label4.TabIndex = 24;
            this.label4.Text = "零件单价：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(69, 209);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 15);
            this.label2.TabIndex = 29;
            this.label2.Text = "零件规格：";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(69, 97);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 15);
            this.label1.TabIndex = 23;
            this.label1.Text = "零 件 号：";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(69, 317);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 15);
            this.label5.TabIndex = 24;
            this.label5.Text = "描    述：";
            // 
            // textBoxDescribe
            // 
            this.textBoxDescribe.Location = new System.Drawing.Point(177, 312);
            this.textBoxDescribe.MaxLength = 80;
            this.textBoxDescribe.Name = "textBoxDescribe";
            this.textBoxDescribe.Size = new System.Drawing.Size(213, 25);
            this.textBoxDescribe.TabIndex = 5;
            // 
            // AddComponentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(467, 448);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.ExitAddbutton);
            this.Controls.Add(this.AddComponentbutton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxDescribe);
            this.Controls.Add(this.textBoxUnitprice);
            this.Controls.Add(this.textBoxFormat);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBoxID);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "AddComponentForm";
            this.Text = "添加物资";
            this.Load += new System.EventHandler(this.AddComponentForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button ExitAddbutton;
        private System.Windows.Forms.Button AddComponentbutton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxUnitprice;
        private System.Windows.Forms.TextBox textBoxFormat;
        private System.Windows.Forms.TextBox textBoxID;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxDescribe;
    }
}