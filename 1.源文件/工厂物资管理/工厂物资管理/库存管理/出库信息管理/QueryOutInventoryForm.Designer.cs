namespace 工厂物资管理.库存管理.出库信息管理
{
    partial class QueryOutInventoryForm
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.And_dateTimeP = new System.Windows.Forms.DateTimePicker();
            this.Between_dateTimeP = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.Retry_button = new System.Windows.Forms.Button();
            this.Query_button = new System.Windows.Forms.Button();
            this.CZY_textB = new System.Windows.Forms.TextBox();
            this.CKBH_textB = new System.Windows.Forms.TextBox();
            this.LJBH_textB = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dataGridView1);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(0, 185);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(734, 332);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "查询结果";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 21);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 27;
            this.dataGridView1.Size = new System.Drawing.Size(728, 308);
            this.dataGridView1.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.Retry_button);
            this.groupBox1.Controls.Add(this.Query_button);
            this.groupBox1.Controls.Add(this.CZY_textB);
            this.groupBox1.Controls.Add(this.CKBH_textB);
            this.groupBox1.Controls.Add(this.LJBH_textB);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(734, 185);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "查询条件";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.And_dateTimeP);
            this.groupBox3.Controls.Add(this.Between_dateTimeP);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox3.Location = new System.Drawing.Point(54, 71);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox3.Size = new System.Drawing.Size(628, 51);
            this.groupBox3.TabIndex = 5;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "入库时间";
            // 
            // And_dateTimeP
            // 
            this.And_dateTimeP.Location = new System.Drawing.Point(380, 16);
            this.And_dateTimeP.Margin = new System.Windows.Forms.Padding(4);
            this.And_dateTimeP.Name = "And_dateTimeP";
            this.And_dateTimeP.Size = new System.Drawing.Size(211, 27);
            this.And_dateTimeP.TabIndex = 4;
            // 
            // Between_dateTimeP
            // 
            this.Between_dateTimeP.Location = new System.Drawing.Point(119, 15);
            this.Between_dateTimeP.Margin = new System.Windows.Forms.Padding(4);
            this.Between_dateTimeP.Name = "Between_dateTimeP";
            this.Between_dateTimeP.Size = new System.Drawing.Size(203, 27);
            this.Between_dateTimeP.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(343, 21);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(26, 18);
            this.label5.TabIndex = 1;
            this.label5.Text = "到";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(80, 21);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(26, 18);
            this.label6.TabIndex = 0;
            this.label6.Text = "从";
            // 
            // Retry_button
            // 
            this.Retry_button.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Retry_button.Location = new System.Drawing.Point(577, 125);
            this.Retry_button.Margin = new System.Windows.Forms.Padding(4);
            this.Retry_button.Name = "Retry_button";
            this.Retry_button.Size = new System.Drawing.Size(100, 38);
            this.Retry_button.TabIndex = 7;
            this.Retry_button.Text = "重置";
            this.Retry_button.UseVisualStyleBackColor = true;
            this.Retry_button.Click += new System.EventHandler(this.Retry_button_Click);
            // 
            // Query_button
            // 
            this.Query_button.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Query_button.Location = new System.Drawing.Point(434, 125);
            this.Query_button.Margin = new System.Windows.Forms.Padding(4);
            this.Query_button.Name = "Query_button";
            this.Query_button.Size = new System.Drawing.Size(100, 38);
            this.Query_button.TabIndex = 6;
            this.Query_button.Text = "查询";
            this.Query_button.UseVisualStyleBackColor = true;
            this.Query_button.Click += new System.EventHandler(this.Query_button_Click);
            // 
            // CZY_textB
            // 
            this.CZY_textB.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.CZY_textB.Location = new System.Drawing.Point(486, 33);
            this.CZY_textB.Margin = new System.Windows.Forms.Padding(4);
            this.CZY_textB.Name = "CZY_textB";
            this.CZY_textB.Size = new System.Drawing.Size(191, 30);
            this.CZY_textB.TabIndex = 2;
            // 
            // CKBH_textB
            // 
            this.CKBH_textB.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.CKBH_textB.Location = new System.Drawing.Point(156, 130);
            this.CKBH_textB.Margin = new System.Windows.Forms.Padding(4);
            this.CKBH_textB.Name = "CKBH_textB";
            this.CKBH_textB.Size = new System.Drawing.Size(203, 30);
            this.CKBH_textB.TabIndex = 5;
            // 
            // LJBH_textB
            // 
            this.LJBH_textB.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.LJBH_textB.Location = new System.Drawing.Point(156, 32);
            this.LJBH_textB.Margin = new System.Windows.Forms.Padding(4);
            this.LJBH_textB.Name = "LJBH_textB";
            this.LJBH_textB.Size = new System.Drawing.Size(203, 30);
            this.LJBH_textB.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(378, 36);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 20);
            this.label3.TabIndex = 10;
            this.label3.Text = "操 作 员：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(48, 134);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 20);
            this.label2.TabIndex = 9;
            this.label2.Text = "仓库编号：";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(50, 39);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 20);
            this.label1.TabIndex = 8;
            this.label1.Text = "零件编号：";
            // 
            // QueryOutInventoryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(734, 517);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "QueryOutInventoryForm";
            this.Text = "QueryOutInventoryForm";
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DateTimePicker And_dateTimeP;
        private System.Windows.Forms.DateTimePicker Between_dateTimeP;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button Retry_button;
        private System.Windows.Forms.Button Query_button;
        private System.Windows.Forms.TextBox CZY_textB;
        private System.Windows.Forms.TextBox CKBH_textB;
        private System.Windows.Forms.TextBox LJBH_textB;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}