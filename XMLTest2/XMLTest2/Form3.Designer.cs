namespace XMLTest2
{
    partial class Form3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            this.cb_Cash = new System.Windows.Forms.ComboBox();
            this.lb_bag = new System.Windows.Forms.Label();
            this.lb_bundle = new System.Windows.Forms.Label();
            this.lb_box = new System.Windows.Forms.Label();
            this.lb_version = new System.Windows.Forms.Label();
            this.lb_type = new System.Windows.Forms.Label();
            this.tb_bag = new System.Windows.Forms.TextBox();
            this.tb_bundle = new System.Windows.Forms.TextBox();
            this.tb_box = new System.Windows.Forms.TextBox();
            this.tb_version = new System.Windows.Forms.TextBox();
            this.Btn_UpdateCashInfo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cb_Cash
            // 
            this.cb_Cash.FormattingEnabled = true;
            this.cb_Cash.Location = new System.Drawing.Point(116, 39);
            this.cb_Cash.Name = "cb_Cash";
            this.cb_Cash.Size = new System.Drawing.Size(177, 20);
            this.cb_Cash.TabIndex = 0;
            this.cb_Cash.SelectedIndexChanged += new System.EventHandler(this.cb_Cash_SelectedIndexChanged);
            // 
            // lb_bag
            // 
            this.lb_bag.AutoSize = true;
            this.lb_bag.Location = new System.Drawing.Point(21, 183);
            this.lb_bag.Name = "lb_bag";
            this.lb_bag.Size = new System.Drawing.Size(89, 12);
            this.lb_bag.TabIndex = 20;
            this.lb_bag.Text = "一袋金额（元）";
            // 
            // lb_bundle
            // 
            this.lb_bundle.AutoSize = true;
            this.lb_bundle.Location = new System.Drawing.Point(21, 145);
            this.lb_bundle.Name = "lb_bundle";
            this.lb_bundle.Size = new System.Drawing.Size(89, 12);
            this.lb_bundle.TabIndex = 19;
            this.lb_bundle.Text = "一捆金额（元）";
            // 
            // lb_box
            // 
            this.lb_box.AutoSize = true;
            this.lb_box.Location = new System.Drawing.Point(21, 111);
            this.lb_box.Name = "lb_box";
            this.lb_box.Size = new System.Drawing.Size(89, 12);
            this.lb_box.TabIndex = 18;
            this.lb_box.Text = "一箱金额（元）";
            // 
            // lb_version
            // 
            this.lb_version.AutoSize = true;
            this.lb_version.Location = new System.Drawing.Point(69, 79);
            this.lb_version.Name = "lb_version";
            this.lb_version.Size = new System.Drawing.Size(41, 12);
            this.lb_version.TabIndex = 17;
            this.lb_version.Text = "版本号";
            // 
            // lb_type
            // 
            this.lb_type.AutoSize = true;
            this.lb_type.Location = new System.Drawing.Point(57, 42);
            this.lb_type.Name = "lb_type";
            this.lb_type.Size = new System.Drawing.Size(53, 12);
            this.lb_type.TabIndex = 16;
            this.lb_type.Text = "券别名称";
            // 
            // tb_bag
            // 
            this.tb_bag.Location = new System.Drawing.Point(116, 180);
            this.tb_bag.Name = "tb_bag";
            this.tb_bag.Size = new System.Drawing.Size(177, 21);
            this.tb_bag.TabIndex = 24;
            // 
            // tb_bundle
            // 
            this.tb_bundle.Location = new System.Drawing.Point(116, 142);
            this.tb_bundle.Name = "tb_bundle";
            this.tb_bundle.Size = new System.Drawing.Size(177, 21);
            this.tb_bundle.TabIndex = 23;
            // 
            // tb_box
            // 
            this.tb_box.Location = new System.Drawing.Point(116, 108);
            this.tb_box.Name = "tb_box";
            this.tb_box.Size = new System.Drawing.Size(177, 21);
            this.tb_box.TabIndex = 22;
            // 
            // tb_version
            // 
            this.tb_version.Location = new System.Drawing.Point(116, 76);
            this.tb_version.Name = "tb_version";
            this.tb_version.Size = new System.Drawing.Size(177, 21);
            this.tb_version.TabIndex = 21;
            // 
            // Btn_UpdateCashInfo
            // 
            this.Btn_UpdateCashInfo.Location = new System.Drawing.Point(116, 238);
            this.Btn_UpdateCashInfo.Name = "Btn_UpdateCashInfo";
            this.Btn_UpdateCashInfo.Size = new System.Drawing.Size(75, 23);
            this.Btn_UpdateCashInfo.TabIndex = 25;
            this.Btn_UpdateCashInfo.Text = "修改";
            this.Btn_UpdateCashInfo.UseVisualStyleBackColor = true;
            this.Btn_UpdateCashInfo.Click += new System.EventHandler(this.Btn_UpdateCashInfo_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(335, 287);
            this.Controls.Add(this.Btn_UpdateCashInfo);
            this.Controls.Add(this.tb_bag);
            this.Controls.Add(this.tb_bundle);
            this.Controls.Add(this.tb_box);
            this.Controls.Add(this.tb_version);
            this.Controls.Add(this.lb_bag);
            this.Controls.Add(this.lb_bundle);
            this.Controls.Add(this.lb_box);
            this.Controls.Add(this.lb_version);
            this.Controls.Add(this.lb_type);
            this.Controls.Add(this.cb_Cash);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form3";
            this.Text = "修改券别信息";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cb_Cash;
        private System.Windows.Forms.Label lb_bag;
        private System.Windows.Forms.Label lb_bundle;
        private System.Windows.Forms.Label lb_box;
        private System.Windows.Forms.Label lb_version;
        private System.Windows.Forms.Label lb_type;
        private System.Windows.Forms.TextBox tb_bag;
        private System.Windows.Forms.TextBox tb_bundle;
        private System.Windows.Forms.TextBox tb_box;
        private System.Windows.Forms.TextBox tb_version;
        private System.Windows.Forms.Button Btn_UpdateCashInfo;
    }
}