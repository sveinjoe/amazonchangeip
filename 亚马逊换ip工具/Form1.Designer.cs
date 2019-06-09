namespace 亚马逊换ip工具
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
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.textBoxADSLAccount = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxADSLPass = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxTimerInterval = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxErrorStr = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxURI = new System.Windows.Forms.TextBox();
            this.textBoxADSLName = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.labelResult = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBoxADSLAccount
            // 
            this.textBoxADSLAccount.Location = new System.Drawing.Point(90, 66);
            this.textBoxADSLAccount.Name = "textBoxADSLAccount";
            this.textBoxADSLAccount.Size = new System.Drawing.Size(203, 21);
            this.textBoxADSLAccount.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "宽带账号：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 104);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "宽带密码：";
            // 
            // textBoxADSLPass
            // 
            this.textBoxADSLPass.Location = new System.Drawing.Point(90, 101);
            this.textBoxADSLPass.Name = "textBoxADSLPass";
            this.textBoxADSLPass.Size = new System.Drawing.Size(203, 21);
            this.textBoxADSLPass.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 140);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 12);
            this.label3.TabIndex = 2;
            this.label3.Text = "间隔(毫秒)";
            // 
            // textBoxTimerInterval
            // 
            this.textBoxTimerInterval.Location = new System.Drawing.Point(90, 137);
            this.textBoxTimerInterval.Name = "textBoxTimerInterval";
            this.textBoxTimerInterval.Size = new System.Drawing.Size(203, 21);
            this.textBoxTimerInterval.TabIndex = 4;
            this.textBoxTimerInterval.Text = "3000";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 214);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 12);
            this.label4.TabIndex = 3;
            this.label4.Text = "检测字符：";
            // 
            // textBoxErrorStr
            // 
            this.textBoxErrorStr.Location = new System.Drawing.Point(90, 211);
            this.textBoxErrorStr.Name = "textBoxErrorStr";
            this.textBoxErrorStr.Size = new System.Drawing.Size(203, 21);
            this.textBoxErrorStr.TabIndex = 6;
            this.textBoxErrorStr.Text = "/errors/validateCaptcha";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(218, 279);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "开始检测";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 30000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(19, 179);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 12);
            this.label5.TabIndex = 3;
            this.label5.Text = "检测URL：";
            // 
            // textBoxURI
            // 
            this.textBoxURI.Location = new System.Drawing.Point(90, 176);
            this.textBoxURI.Name = "textBoxURI";
            this.textBoxURI.Size = new System.Drawing.Size(203, 21);
            this.textBoxURI.TabIndex = 5;
            this.textBoxURI.Text = "https://www.amazon.com/";
            // 
            // textBoxADSLName
            // 
            this.textBoxADSLName.Location = new System.Drawing.Point(90, 28);
            this.textBoxADSLName.Name = "textBoxADSLName";
            this.textBoxADSLName.Size = new System.Drawing.Size(203, 21);
            this.textBoxADSLName.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(19, 31);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 12);
            this.label6.TabIndex = 1;
            this.label6.Text = "宽带名称：";
            // 
            // labelResult
            // 
            this.labelResult.AutoSize = true;
            this.labelResult.Location = new System.Drawing.Point(21, 255);
            this.labelResult.Name = "labelResult";
            this.labelResult.Size = new System.Drawing.Size(0, 12);
            this.labelResult.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(305, 314);
            this.Controls.Add(this.labelResult);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxURI);
            this.Controls.Add(this.textBoxErrorStr);
            this.Controls.Add(this.textBoxTimerInterval);
            this.Controls.Add(this.textBoxADSLPass);
            this.Controls.Add(this.textBoxADSLName);
            this.Controls.Add(this.textBoxADSLAccount);
            this.Name = "Form1";
            this.Text = "亚马逊验证码检测工具（换ip）";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxADSLAccount;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxADSLPass;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxTimerInterval;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxErrorStr;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxURI;
        private System.Windows.Forms.TextBox textBoxADSLName;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label labelResult;
    }
}

