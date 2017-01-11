namespace XMLTest2
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.btn_addXML = new System.Windows.Forms.Button();
            this.tb_bag = new System.Windows.Forms.TextBox();
            this.tb_bundle = new System.Windows.Forms.TextBox();
            this.tb_box = new System.Windows.Forms.TextBox();
            this.tb_version = new System.Windows.Forms.TextBox();
            this.tb_type = new System.Windows.Forms.TextBox();
            this.lb_bag = new System.Windows.Forms.Label();
            this.lb_bundle = new System.Windows.Forms.Label();
            this.lb_box = new System.Windows.Forms.Label();
            this.lb_version = new System.Windows.Forms.Label();
            this.lb_type = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_addXML
            // 
            this.btn_addXML.Location = new System.Drawing.Point(133, 220);
            this.btn_addXML.Name = "btn_addXML";
            this.btn_addXML.Size = new System.Drawing.Size(75, 23);
            this.btn_addXML.TabIndex = 21;
            this.btn_addXML.Text = "添加";
            this.btn_addXML.UseVisualStyleBackColor = true;
            this.btn_addXML.Click += new System.EventHandler(this.btn_addXML_Click);
            // 
            // tb_bag
            // 
            this.tb_bag.Location = new System.Drawing.Point(101, 160);
            this.tb_bag.Name = "tb_bag";
            this.tb_bag.Size = new System.Drawing.Size(177, 21);
            this.tb_bag.TabIndex = 20;
            // 
            // tb_bundle
            // 
            this.tb_bundle.Location = new System.Drawing.Point(101, 122);
            this.tb_bundle.Name = "tb_bundle";
            this.tb_bundle.Size = new System.Drawing.Size(177, 21);
            this.tb_bundle.TabIndex = 19;
            // 
            // tb_box
            // 
            this.tb_box.Location = new System.Drawing.Point(101, 88);
            this.tb_box.Name = "tb_box";
            this.tb_box.Size = new System.Drawing.Size(177, 21);
            this.tb_box.TabIndex = 18;
            // 
            // tb_version
            // 
            this.tb_version.Location = new System.Drawing.Point(101, 53);
            this.tb_version.Name = "tb_version";
            this.tb_version.Size = new System.Drawing.Size(177, 21);
            this.tb_version.TabIndex = 17;
            // 
            // tb_type
            // 
            this.tb_type.Location = new System.Drawing.Point(101, 19);
            this.tb_type.Name = "tb_type";
            this.tb_type.Size = new System.Drawing.Size(177, 21);
            this.tb_type.TabIndex = 16;
            // 
            // lb_bag
            // 
            this.lb_bag.AutoSize = true;
            this.lb_bag.Location = new System.Drawing.Point(6, 163);
            this.lb_bag.Name = "lb_bag";
            this.lb_bag.Size = new System.Drawing.Size(89, 12);
            this.lb_bag.TabIndex = 15;
            this.lb_bag.Text = "一袋金额（元）";
            // 
            // lb_bundle
            // 
            this.lb_bundle.AutoSize = true;
            this.lb_bundle.Location = new System.Drawing.Point(6, 125);
            this.lb_bundle.Name = "lb_bundle";
            this.lb_bundle.Size = new System.Drawing.Size(89, 12);
            this.lb_bundle.TabIndex = 14;
            this.lb_bundle.Text = "一捆金额（元）";
            // 
            // lb_box
            // 
            this.lb_box.AutoSize = true;
            this.lb_box.Location = new System.Drawing.Point(6, 91);
            this.lb_box.Name = "lb_box";
            this.lb_box.Size = new System.Drawing.Size(89, 12);
            this.lb_box.TabIndex = 13;
            this.lb_box.Text = "一箱金额（元）";
            // 
            // lb_version
            // 
            this.lb_version.AutoSize = true;
            this.lb_version.Location = new System.Drawing.Point(54, 56);
            this.lb_version.Name = "lb_version";
            this.lb_version.Size = new System.Drawing.Size(41, 12);
            this.lb_version.TabIndex = 12;
            this.lb_version.Text = "版本号";
            // 
            // lb_type
            // 
            this.lb_type.AutoSize = true;
            this.lb_type.Location = new System.Drawing.Point(42, 22);
            this.lb_type.Name = "lb_type";
            this.lb_type.Size = new System.Drawing.Size(53, 12);
            this.lb_type.TabIndex = 11;
            this.lb_type.Text = "券别名称";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(317, 275);
            this.Controls.Add(this.btn_addXML);
            this.Controls.Add(this.tb_bag);
            this.Controls.Add(this.tb_bundle);
            this.Controls.Add(this.tb_box);
            this.Controls.Add(this.tb_version);
            this.Controls.Add(this.tb_type);
            this.Controls.Add(this.lb_bag);
            this.Controls.Add(this.lb_bundle);
            this.Controls.Add(this.lb_box);
            this.Controls.Add(this.lb_version);
            this.Controls.Add(this.lb_type);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form2";
            this.Text = "手动录入券别信息";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_addXML;
        private System.Windows.Forms.TextBox tb_bag;
        private System.Windows.Forms.TextBox tb_bundle;
        private System.Windows.Forms.TextBox tb_box;
        private System.Windows.Forms.TextBox tb_version;
        private System.Windows.Forms.TextBox tb_type;
        private System.Windows.Forms.Label lb_bag;
        private System.Windows.Forms.Label lb_bundle;
        private System.Windows.Forms.Label lb_box;
        private System.Windows.Forms.Label lb_version;
        private System.Windows.Forms.Label lb_type;
    }
}