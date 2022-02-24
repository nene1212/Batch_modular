namespace 批量量化工具
{
    partial class Form1
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
            this.select = new System.Windows.Forms.Button();
            this.data = new System.Windows.Forms.TextBox();
            this.threshold = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.clear = new System.Windows.Forms.Button();
            this.status = new System.Windows.Forms.Label();
            this.reverse = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // select
            // 
            this.select.Location = new System.Drawing.Point(12, 12);
            this.select.Name = "select";
            this.select.Size = new System.Drawing.Size(156, 63);
            this.select.TabIndex = 0;
            this.select.Text = "选择图片";
            this.select.UseVisualStyleBackColor = true;
            this.select.Click += new System.EventHandler(this.select_Click);
            // 
            // data
            // 
            this.data.Location = new System.Drawing.Point(184, 12);
            this.data.MaxLength = 9999990;
            this.data.Multiline = true;
            this.data.Name = "data";
            this.data.ReadOnly = true;
            this.data.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.data.Size = new System.Drawing.Size(388, 243);
            this.data.TabIndex = 1;
            this.data.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // threshold
            // 
            this.threshold.Location = new System.Drawing.Point(68, 261);
            this.threshold.MaxLength = 3;
            this.threshold.Name = "threshold";
            this.threshold.Size = new System.Drawing.Size(100, 25);
            this.threshold.TabIndex = 2;
            this.threshold.Text = "300";
            this.threshold.TextChanged += new System.EventHandler(this.threshold_TextChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(13, 82);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(155, 173);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(10, 264);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 15);
            this.label1.TabIndex = 4;
            this.label1.Text = "阈值:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // clear
            // 
            this.clear.Location = new System.Drawing.Point(467, 264);
            this.clear.Name = "clear";
            this.clear.Size = new System.Drawing.Size(95, 34);
            this.clear.TabIndex = 5;
            this.clear.Text = "清除数据";
            this.clear.UseVisualStyleBackColor = true;
            this.clear.Click += new System.EventHandler(this.clear_Click);
            // 
            // status
            // 
            this.status.AutoSize = true;
            this.status.Location = new System.Drawing.Point(184, 271);
            this.status.Name = "status";
            this.status.Size = new System.Drawing.Size(15, 15);
            this.status.TabIndex = 6;
            this.status.Text = " ";
            // 
            // reverse
            // 
            this.reverse.AutoSize = true;
            this.reverse.Location = new System.Drawing.Point(402, 271);
            this.reverse.Name = "reverse";
            this.reverse.Size = new System.Drawing.Size(59, 19);
            this.reverse.TabIndex = 7;
            this.reverse.Text = "取反";
            this.reverse.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(574, 298);
            this.Controls.Add(this.reverse);
            this.Controls.Add(this.status);
            this.Controls.Add(this.clear);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.threshold);
            this.Controls.Add(this.data);
            this.Controls.Add(this.select);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button select;
        private System.Windows.Forms.TextBox data;
        private System.Windows.Forms.TextBox threshold;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button clear;
        private System.Windows.Forms.Label status;
        private System.Windows.Forms.CheckBox reverse;
    }
}

