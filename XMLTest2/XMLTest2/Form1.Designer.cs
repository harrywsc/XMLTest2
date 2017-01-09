namespace XMLTest2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.Btn_SelectData = new System.Windows.Forms.Button();
            this.Btn_SelectXML = new System.Windows.Forms.Button();
            this.lb_DataDir = new System.Windows.Forms.Label();
            this.lb_XMLDir = new System.Windows.Forms.Label();
            this.Btn_Start = new System.Windows.Forms.Button();
            this.Btn_Stop = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Btn_SelectData
            // 
            this.Btn_SelectData.Location = new System.Drawing.Point(45, 33);
            this.Btn_SelectData.Name = "Btn_SelectData";
            this.Btn_SelectData.Size = new System.Drawing.Size(105, 23);
            this.Btn_SelectData.TabIndex = 0;
            this.Btn_SelectData.Text = "请选择数据文件";
            this.Btn_SelectData.UseVisualStyleBackColor = true;
            this.Btn_SelectData.Click += new System.EventHandler(this.Btn_SelectData_Click);
            // 
            // Btn_SelectXML
            // 
            this.Btn_SelectXML.Location = new System.Drawing.Point(45, 104);
            this.Btn_SelectXML.Name = "Btn_SelectXML";
            this.Btn_SelectXML.Size = new System.Drawing.Size(105, 23);
            this.Btn_SelectXML.TabIndex = 1;
            this.Btn_SelectXML.Text = "请选择配置文件";
            this.Btn_SelectXML.UseVisualStyleBackColor = true;
            this.Btn_SelectXML.Click += new System.EventHandler(this.Btn_SelectXML_Click);
            // 
            // lb_DataDir
            // 
            this.lb_DataDir.AutoSize = true;
            this.lb_DataDir.Location = new System.Drawing.Point(45, 63);
            this.lb_DataDir.Name = "lb_DataDir";
            this.lb_DataDir.Size = new System.Drawing.Size(65, 12);
            this.lb_DataDir.TabIndex = 2;
            this.lb_DataDir.Text = "数据文件：";
            // 
            // lb_XMLDir
            // 
            this.lb_XMLDir.AutoSize = true;
            this.lb_XMLDir.Location = new System.Drawing.Point(45, 134);
            this.lb_XMLDir.Name = "lb_XMLDir";
            this.lb_XMLDir.Size = new System.Drawing.Size(65, 12);
            this.lb_XMLDir.TabIndex = 3;
            this.lb_XMLDir.Text = "配置文件：";
            // 
            // Btn_Start
            // 
            this.Btn_Start.Location = new System.Drawing.Point(83, 198);
            this.Btn_Start.Name = "Btn_Start";
            this.Btn_Start.Size = new System.Drawing.Size(75, 23);
            this.Btn_Start.TabIndex = 4;
            this.Btn_Start.Text = "启动";
            this.Btn_Start.UseVisualStyleBackColor = true;
            // 
            // Btn_Stop
            // 
            this.Btn_Stop.Location = new System.Drawing.Point(245, 198);
            this.Btn_Stop.Name = "Btn_Stop";
            this.Btn_Stop.Size = new System.Drawing.Size(75, 23);
            this.Btn_Stop.TabIndex = 5;
            this.Btn_Stop.Text = "停止";
            this.Btn_Stop.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(429, 246);
            this.Controls.Add(this.Btn_Stop);
            this.Controls.Add(this.Btn_Start);
            this.Controls.Add(this.lb_XMLDir);
            this.Controls.Add(this.lb_DataDir);
            this.Controls.Add(this.Btn_SelectXML);
            this.Controls.Add(this.Btn_SelectData);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "发行显示系统V2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Btn_SelectData;
        private System.Windows.Forms.Button Btn_SelectXML;
        private System.Windows.Forms.Label lb_DataDir;
        private System.Windows.Forms.Label lb_XMLDir;
        private System.Windows.Forms.Button Btn_Start;
        private System.Windows.Forms.Button Btn_Stop;
    }
}

