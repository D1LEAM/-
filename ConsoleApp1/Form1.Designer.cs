
namespace ConsoleApp1
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
        // 释放组件所占用的内存
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
        private void InitializeComponent() //窗体界面定义
        {
            this.components = new System.ComponentModel.Container();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.listBox3 = new System.Windows.Forms.ListBox();
            this.listBox4 = new System.Windows.Forms.ListBox();
            this.listBox5 = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1 按钮
            // 
            this.button1.Location = new System.Drawing.Point(683, 90); //X、Y坐标
            this.button1.Margin = new System.Windows.Forms.Padding(4); //内边距为4
            this.button1.Name = "button1"; //名称
            this.button1.Size = new System.Drawing.Size(97, 41); //大小
            this.button1.TabIndex = 0; //TAB优先级
            this.button1.Text = "发送帧"; //按钮内文字
            this.button1.UseVisualStyleBackColor = true;  //使用视觉样式
            this.button1.Click += new System.EventHandler(this.Button1_Click); //点击操作
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(1249, 134);
            this.button2.Margin = new System.Windows.Forms.Padding(4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(112, 41);
            this.button2.TabIndex = 1;
            this.button2.Text = "重置";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(1249, 36);
            this.button3.Margin = new System.Windows.Forms.Padding(4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(112, 41);
            this.button3.TabIndex = 2;
            this.button3.Text = "保存";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // listBox1 空白表格
            // 
            this.listBox1.FormattingEnabled = true;  //启用获取值
            this.listBox1.ItemHeight = 15; //每行高度
            this.listBox1.Location = new System.Drawing.Point(453, 229); //X、Y坐标
            this.listBox1.Margin = new System.Windows.Forms.Padding(4); //内边距
            this.listBox1.Name = "listBox1"; //名称
            this.listBox1.Size = new System.Drawing.Size(116, 259); //尺寸
            this.listBox1.TabIndex = 3; //TAB优先级
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.ItemHeight = 15;
            this.listBox2.Location = new System.Drawing.Point(639, 231);
            this.listBox2.Margin = new System.Windows.Forms.Padding(4);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(116, 259);
            this.listBox2.TabIndex = 4;
            // 
            // comboBox1 下拉栏
            // 
            this.comboBox1.FormattingEnabled = true; //启用获取值
            this.comboBox1.Items.AddRange(new object[] //下拉栏项目
            {
            "A",
            "B",
            "C",
            "D",
            "E",
            "F",
            "G",
            "H",
            "P",
            "Q"});
            this.comboBox1.Location = new System.Drawing.Point(547, 68); //X、Y坐标
            this.comboBox1.Margin = new System.Windows.Forms.Padding(4); //内边距
            this.comboBox1.Name = "comboBox1"; //名称
            this.comboBox1.Size = new System.Drawing.Size(104, 23); //大小
            this.comboBox1.TabIndex = 5; //TAB优先级
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "A",
            "B",
            "C",
            "D",
            "E",
            "F",
            "G",
            "H",
            "P",
            "Q"});
            this.comboBox2.Location = new System.Drawing.Point(547, 139);
            this.comboBox2.Margin = new System.Windows.Forms.Padding(4);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(104, 23);
            this.comboBox2.TabIndex = 6;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ConsoleApp1.Properties.Resources.网桥; //应用图像
            this.pictureBox1.Location = new System.Drawing.Point(-2, 36); //X、Y坐标
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4); //内边距
            this.pictureBox1.Name = "pictureBox1"; //名称
            this.pictureBox1.Size = new System.Drawing.Size(447, 405); //大小
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;  //压缩图像
            this.pictureBox1.TabIndex = 7; //TAB优先级
            this.pictureBox1.TabStop = false; //不可使用TAB将其视为焦点
            // 
            // listBox3 程序内表格
            // 
            this.listBox3.FormattingEnabled = true;
            this.listBox3.ItemHeight = 15;
            this.listBox3.Location = new System.Drawing.Point(827, 229);
            this.listBox3.Margin = new System.Windows.Forms.Padding(4);
            this.listBox3.Name = "listBox3";
            this.listBox3.Size = new System.Drawing.Size(116, 259);
            this.listBox3.TabIndex = 8;
            // 
            // listBox4
            // 
            this.listBox4.FormattingEnabled = true;
            this.listBox4.ItemHeight = 15;
            this.listBox4.Location = new System.Drawing.Point(1024, 229);
            this.listBox4.Margin = new System.Windows.Forms.Padding(4);
            this.listBox4.Name = "listBox4";
            this.listBox4.Size = new System.Drawing.Size(116, 259);
            this.listBox4.TabIndex = 9;
            // 
            // listBox5
            // 
            this.listBox5.FormattingEnabled = true;
            this.listBox5.ItemHeight = 15;
            this.listBox5.Location = new System.Drawing.Point(1220, 229);
            this.listBox5.Margin = new System.Windows.Forms.Padding(4);
            this.listBox5.Name = "listBox5";
            this.listBox5.Size = new System.Drawing.Size(116, 259);
            this.listBox5.TabIndex = 10;
            // 
            // label1 程序内小字
            // 
            this.label1.AutoSize = true; //自动调整控件大小以显示全部内容
            this.label1.Location = new System.Drawing.Point(468, 210); //X、Y坐标
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0); //内边距
            this.label1.Name = "label1"; //名称
            this.label1.Size = new System.Drawing.Size(67, 15); //大小
            this.label1.TabIndex = 11; //TAB优先级
            this.label1.Text = "发送的帧"; //文字
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(637, 195);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 15);
            this.label2.TabIndex = 12;
            this.label2.Text = "B1的转发表地址";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(824, 194);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(113, 15);
            this.label3.TabIndex = 13;
            this.label3.Text = "B2的转发表地址";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(1040, 210);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 15);
            this.label4.TabIndex = 14;
            this.label4.Text = "B1的处理";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(1231, 210);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 15);
            this.label5.TabIndex = 15;
            this.label5.Text = "B2的处理";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(468, 142);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 15);
            this.label6.TabIndex = 16;
            this.label6.Text = "目的地址";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(484, 78);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(52, 15);
            this.label7.TabIndex = 17;
            this.label7.Text = "源地址";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(109, 474);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(157, 15);
            this.label8.TabIndex = 18;
            this.label8.Text = "小型局域网的拓扑结构";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(680, 212);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(37, 15);
            this.label10.TabIndex = 20;
            this.label10.Text = "接口";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(859, 210);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(37, 15);
            this.label11.TabIndex = 21;
            this.label11.Text = "接口";
            // 
            // button4 按钮
            // 
            this.button4.Location = new System.Drawing.Point(1043, 78);
            this.button4.Margin = new System.Windows.Forms.Padding(4);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(83, 36);
            this.button4.TabIndex = 22;
            this.button4.Text = "开始";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click_1);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(1044, 142);
            this.button5.Margin = new System.Windows.Forms.Padding(4);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(81, 32);
            this.button5.TabIndex = 23;
            this.button5.Text = "停止";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick); //当计时器处于启动状态时，启动
            // 
            // textBox1 循环次数（时间）
            // 
            this.textBox1.Location = new System.Drawing.Point(873, 131);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(132, 25);
            this.textBox1.TabIndex = 24;
            // 
            // label12 自动功能
            // 
            this.label12.AutoSize = true; //自动适配尺寸
            this.label12.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134))); //使用指定的大小、样式、单位和字符集初始化新的 Font
            this.label12.Location = new System.Drawing.Point(976, 24); //X、Y坐标
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0); //内边距
            this.label12.Name = "label12"; //名称
            this.label12.Size = new System.Drawing.Size(49, 20); //大小
            this.label12.TabIndex = 25; //TAB优先级
            this.label12.Text = "自动"; //文字
            // 
            // label13 文字提示
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(883, 88);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(97, 15);
            this.label13.TabIndex = 26;
            this.label13.Text = "输入循环时间";
            // 
            // label14 文字提示
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(883, 112);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(75, 15);
            this.label14.TabIndex = 27;
            this.label14.Text = "以s为单位";
            // 
            // label9 手动功能
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label9.Location = new System.Drawing.Point(576, 24);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(49, 20);
            this.label9.TabIndex = 28;
            this.label9.Text = "手动";
            // 
            // Form1 整体
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F); //按照屏幕DPI缩放
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font; //根据类使用的字体的维度控制缩放
            this.ClientSize = new System.Drawing.Size(1407, 506); //窗口大小
            this.Controls.Add(this.label9); //获取控件
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBox5);
            this.Controls.Add(this.listBox4);
            this.Controls.Add(this.listBox3);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.listBox2);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "                                                                                 " +
    "                                       转发表生成";
            this.Load += new System.EventHandler(this.Form1_Load); //加载事件到系统代理上，当任何的按钮后，每次的页面刷新，都会调用了Form1_Load（）函数
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit(); //指定该对象支持对批初始化的简单的事务处理通知，用信号通知对象初始化完成
            this.ResumeLayout(false); //恢复正常逻辑布局
            this.PerformLayout(); //强制控件将布局逻辑应用于所有子布局
        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ListBox listBox3;
        private System.Windows.Forms.ListBox listBox4;
        private System.Windows.Forms.ListBox listBox5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label9;
    }
}

