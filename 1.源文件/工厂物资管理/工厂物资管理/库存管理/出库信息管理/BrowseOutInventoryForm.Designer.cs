﻿namespace 工厂物资管理.库存管理.出库信息管理
{
    partial class BrowseOutInventoryForm
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.Exit_button = new System.Windows.Forms.Button();
            this.Modify_button = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.SX_button = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(946, 108);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("楷体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(389, 42);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(168, 25);
            this.label3.TabIndex = 14;
            this.label3.Text = "浏览出库信息";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.Exit_button);
            this.groupBox3.Controls.Add(this.SX_button);
            this.groupBox3.Controls.Add(this.Modify_button);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox3.Location = new System.Drawing.Point(0, 487);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(946, 100);
            this.groupBox3.TabIndex = 12;
            this.groupBox3.TabStop = false;
            // 
            // Exit_button
            // 
            this.Exit_button.Location = new System.Drawing.Point(614, 33);
            this.Exit_button.Name = "Exit_button";
            this.Exit_button.Size = new System.Drawing.Size(75, 34);
            this.Exit_button.TabIndex = 0;
            this.Exit_button.Text = "退出";
            this.Exit_button.UseVisualStyleBackColor = true;
            this.Exit_button.Click += new System.EventHandler(this.Exit_button_Click);
            // 
            // Modify_button
            // 
            this.Modify_button.Location = new System.Drawing.Point(256, 33);
            this.Modify_button.Name = "Modify_button";
            this.Modify_button.Size = new System.Drawing.Size(75, 34);
            this.Modify_button.TabIndex = 0;
            this.Modify_button.Text = "修改";
            this.Modify_button.UseVisualStyleBackColor = true;
            this.Modify_button.Click += new System.EventHandler(this.Modify_button_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dataGridView1);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(0, 108);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(946, 379);
            this.groupBox2.TabIndex = 14;
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
            this.dataGridView1.Size = new System.Drawing.Size(940, 355);
            this.dataGridView1.TabIndex = 0;
            // 
            // SX_button
            // 
            this.SX_button.Location = new System.Drawing.Point(435, 33);
            this.SX_button.Name = "SX_button";
            this.SX_button.Size = new System.Drawing.Size(75, 34);
            this.SX_button.TabIndex = 0;
            this.SX_button.Text = "刷新";
            this.SX_button.UseVisualStyleBackColor = true;
            this.SX_button.Click += new System.EventHandler(this.SX_button_Click);
            // 
            // BrowseOutInventoryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(946, 587);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox3);
            this.Name = "BrowseOutInventoryForm";
            this.Text = "BrowseOutInventoryForm";
            this.Load += new System.EventHandler(this.BrowseOutInventoryForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button Exit_button;
        private System.Windows.Forms.Button Modify_button;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button SX_button;
    }
}