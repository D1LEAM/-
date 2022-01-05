using System;
using System.Windows.Forms;
using System.IO;

namespace ConsoleApp1
{
    public partial class Form1 : Form
    {
        string R1 = "";
        int net = 0;
        int a = 0;  //对网段及源与目的是否登记进行记录
        int purpose = 0;
        int source = 0;   
        int xhcs = 1;//  控制循环次数，执行多少秒


        public Form1()
        {
            InitializeComponent();  //对窗体界面的定义
        }

        private void Button1_Click(object sender, EventArgs e) //手动发送帧按钮
        {

            string s1 = comboBox1.Text;
            string s2 = comboBox2.Text;
            if (s1 == s2) //源地址==目的地址
            {
                listBox1.Items.Add(s1 + "——>" + s2); //显示发送的帧
                if (s1 == "A" || s1 == "B" || s1 == "C" || s1 == "P" || s1 == "Q") //源地址为B1内接口时的处理操作
                {
                    listBox2.Items.Add("");
                    listBox3.Items.Add("");
                    listBox4.Items.Add("丢弃");
                    listBox5.Items.Add("");
                }
                else      //源地址为B2内接口时的处理操作
                {
                    listBox2.Items.Add("");
                    listBox3.Items.Add("");
                    listBox4.Items.Add("");
                    listBox5.Items.Add("丢弃");
                }

                return;
            }
            //源地址≠目的地址
            else 
            {
                listBox1.Items.Add(s1 + "——>" + s2);  //显示发送的帧
                if ((s1 == "A" && s2 == "B") || (s1 == "B" && s2 == "A") || (s1 == "C" && s2 == "D") || (s1 == "D" && s2 == "C") || (s1 == "E" && s2 == "F") || (s1 == "F" && s2 == "E") || (s1 == "P" && s2 == "Q") || (s1 == "Q" && s2 == "P") || (s1 == "G" && s2 == "H") || (s1 == "H" && s2 == "G"))
                    net = 1; //源地址和目的地址是同一网段
                else
                    net = 0; //源地址和目的地址不是同一网段
                for (int i = 0; i < R1.Length; i++)//依次比较
                {
                    if (R1.Substring(i, 1).CompareTo(s1) == 0) //判断当前步骤S1源地址是否登记
                    {
                        source = 1; //已登记
                        break;
                    }
                    else
                        source = 0; //未登记

                }
                for (int j = 0; j < R1.Length; j++)
                {
                    if (R1.Substring(j, 1).CompareTo(s2) == 0) //判断当前步骤S2目的地址是否登记
                    {
                        purpose = 1; //已登记
                        break;
                    }
                    else
                        purpose = 0; //未登记

                }
            }
            //若源地址和目的地址在同一网段
            if (net == 1) 
            {
                if ((source == 1) && (purpose == 1)) //若源地址和目的地址均已登记
                {

                    a = 1; //不登记，丢弃
                }
                else if ((source == 1) && (purpose == 0)) //若源地址已登记，目的地址未登记
                {

                    a = 2; //不登记，扩散
                }
                else if ((source == 0) && (purpose == 0)) //若源地址和目的地址均未登记
                {
                    a = 4; //登记S1，扩散

                }
                else //若源地址未登记，目的地址已登记
                {
                    a = 3; //登记S1，丢弃


                }
            }
            //若源地址和目的地址 不 在同一网段
            else 
            {
                if ((source == 1) && (purpose == 1)) //若源地址和目的地址均已登记
                {

                    a = 5; //不登记S1，转发
                }
                else if ((source == 1) && (purpose == 0)) //若源地址已登记，目的地址未登记
                {
                    a = 6; //不登记S1，扩散

                }
                else if ((source == 0) && (purpose == 0)) //若源地址和目的地址均未登记
                {
                    a = 8; //登记S1，扩散

                }
                else //若源地址未登记，目的地址已登记
                {
                    a = 7; //登记S1，转发


                }
            }
            //若源地址和目的地址在同一网段，且源地址和目的地址均已登记
            if (a == 1) 
            {
                if (s1 == "A" || s1 == "B" || s1 == "C" || s1 == "P" || s1 == "Q") //若S1是在B1中，则B1表格显示
                {

                    listBox2.Items.Add("");
                    listBox3.Items.Add("");
                    listBox4.Items.Add("不登记，丢弃");
                    listBox5.Items.Add("");
                }

                else //若S1是在B2中，则B2表格显示
                {
                    listBox2.Items.Add("");
                    listBox3.Items.Add("");
                    listBox4.Items.Add("");
                    listBox5.Items.Add("不登记，丢弃");
                }


            }
            //若源地址和目的地址在同一网段，且源地址已登记，目的地址未登记
            else if (a == 2) 
            {
                if (s1 == "A" || s1 == "B" || s1 == "C" || s1 == "P" || s1 == "Q") //若S1是在B1中，则B1表格显示
                {

                    listBox2.Items.Add("");
                    listBox3.Items.Add("");
                    listBox4.Items.Add("不登记，扩散");
                    listBox5.Items.Add("");
                }

                else //若S1是在B2中，则B2表格显示
                {
                    listBox2.Items.Add("");
                    listBox3.Items.Add("");
                    listBox4.Items.Add("");
                    listBox5.Items.Add("不登记，扩散");
                }
            }
            //若源地址和目的地址在同一网段，且源地址未登记，目的地址已登记
            else if (a == 3) 
            {
                R1 = R1 + s1; //登记S1
                if (s1 == "A" || s1 == "B") //如果S1为A/B，则B1显示1接口，在B1表格显示
                {

                    listBox2.Items.Add(s1 + "   1");
                    listBox3.Items.Add("");
                    listBox4.Items.Add("登记，丢弃");
                    listBox5.Items.Add("");
                }
                else if (s1 == "C") //如果S1为C，则B1显示2接口，在B1表格显示
                {
                    listBox2.Items.Add(s1 + "   2");
                    listBox3.Items.Add("");
                    listBox4.Items.Add("登记，丢弃");
                    listBox5.Items.Add("");
                }
                else if (s1 == "D") //如果S1为D，则B2显示1接口，在B2表格显示
                {
                    listBox2.Items.Add("");
                    listBox3.Items.Add(s1 + "   1");
                    listBox4.Items.Add("");
                    listBox5.Items.Add("登记，丢弃");
                }
                else if (s1 == "E" || s1 == "F") //如果S1为E/F，则B2显示2接口，在B2表格显示
                {
                    listBox2.Items.Add("");
                    listBox3.Items.Add(s1 + "   2");
                    listBox4.Items.Add("");
                    listBox5.Items.Add("登记，丢弃");
                }
                else if (s1 == "G" || s1 == "H") //如果S1为G/H，则B2显示3接口，在B2表格显示
                {
                    listBox2.Items.Add("");
                    listBox3.Items.Add(s1 + "   3");
                    listBox4.Items.Add("");
                    listBox5.Items.Add("登记，丢弃");
                }
                else //如果S1为F/Q，则B1显示3接口，在B1表格显示
                {
                    listBox2.Items.Add(s1 + "   3");
                    listBox3.Items.Add("");
                    listBox4.Items.Add("登记，丢弃");
                    listBox5.Items.Add("");
                }
            }
            //若源地址和目的地址在同一网段，且源地址和目的地址均未登记
            else if (a == 4) 
            {
                R1 = R1 + s1; //登记S1
                if (s1 == "A" || s1 == "B")
                {

                    listBox2.Items.Add(s1 + "   1");
                    listBox3.Items.Add(s1 + "   1");
                    listBox4.Items.Add("登记，扩散");
                    listBox5.Items.Add("登记");
                }
                else if (s1 == "C")
                {
                    listBox2.Items.Add(s1 + "   2");
                    listBox3.Items.Add(s1 + "   1");
                    listBox4.Items.Add("登记，扩散");
                    listBox5.Items.Add("登记");
                }
                else if (s1 == "D")
                {
                    listBox2.Items.Add(s1 + "   2");
                    listBox3.Items.Add(s1 + "   1");
                    listBox4.Items.Add("登记");
                    listBox5.Items.Add("登记，扩散");
                }
                else if (s1 == "E" || s1 == "F")
                {
                    listBox2.Items.Add(s1 + "   2");
                    listBox3.Items.Add(s1 + "   2");
                    listBox4.Items.Add("登记");
                    listBox5.Items.Add("登记，扩散");
                }
                else if (s1 == "G" || s1 == "H")
                {
                    listBox2.Items.Add(s1 + "   2");
                    listBox3.Items.Add(s1 + "   3");
                    listBox4.Items.Add("登记");
                    listBox5.Items.Add("登记，扩散");
                }
                else
                {
                    listBox2.Items.Add(s1 + "   3");
                    listBox3.Items.Add(s1 + "   1");
                    listBox4.Items.Add("登记，扩散");
                    listBox5.Items.Add("登记");
                }

            }
            //若源地址和目的地址 不 在同一网段，且源地址和目的地址均已登记
            else if (a == 5)
            {
                if (s1 == "A" || s1 == "B" || s1 == "C" || s1 == "P" || s1 == "Q")
                {

                    listBox2.Items.Add("");
                    listBox3.Items.Add("");
                    listBox4.Items.Add("不登记，转发");
                    listBox5.Items.Add("");
                }

                else
                {
                    listBox2.Items.Add("");
                    listBox3.Items.Add("");
                    listBox4.Items.Add("");
                    listBox5.Items.Add("不登记，转发");
                }
            }
            //若源地址和目的地址 不 在同一网段，且源地址已登记，目的地址未登记
            else if (a == 6)
            {
                if (s1 == "A" || s1 == "B" || s1 == "C" || s1 == "P" || s1 == "Q")
                {

                    listBox2.Items.Add("");
                    listBox3.Items.Add("");
                    listBox4.Items.Add("不登记，扩散");
                    listBox5.Items.Add("");
                }

                else
                {
                    listBox2.Items.Add("");
                    listBox3.Items.Add("");
                    listBox4.Items.Add("");
                    listBox5.Items.Add("不登记，扩散");
                }

            }
            //若源地址和目的地址 不 在同一网段，且源地址未登记，目的地址已登记
            else if (a == 7)
            {
                R1 = R1 + s1; //登记S1
                if (s1 == "A" || s1 == "B")
                {
                    listBox2.Items.Add(s1 + "   1");
                    listBox3.Items.Add(s1 + "   1");
                    listBox4.Items.Add("登记，转发");
                    listBox5.Items.Add("登记");
                }
                else if (s1 == "C")
                {
                    listBox2.Items.Add(s1 + "   2");
                    listBox3.Items.Add(s1 + "   1");
                    listBox4.Items.Add("登记，转发");
                    listBox5.Items.Add("登记");
                }
                else if (s1 == "D")
                {
                    listBox2.Items.Add(s1 + "   2");
                    listBox3.Items.Add(s1 + "   1");
                    listBox4.Items.Add("登记");
                    listBox5.Items.Add("登记，转发");
                }
                else if (s1 == "E" || s1 == "F")
                {
                    listBox2.Items.Add(s1 + "   2");
                    listBox3.Items.Add(s1 + "   2");
                    listBox4.Items.Add("登记");
                    listBox5.Items.Add("登记，转发");
                }
                else if (s1 == "G" || s1 == "H")
                {
                    listBox2.Items.Add(s1 + "   2");
                    listBox3.Items.Add(s1 + "   3");
                    listBox4.Items.Add("登记");
                    listBox5.Items.Add("登记，转发");
                }
                else
                {
                    listBox2.Items.Add(s1 + "   3");
                    listBox3.Items.Add(s1 + "   1");
                    listBox4.Items.Add("登记，转发");
                    listBox5.Items.Add("登记");
                }

            }
            //若源地址和目的地址 不 在同一网段，且源地址和目的地址均未登记
            else if (a == 8)
            {
                R1 = R1 + s1;
                if (s1 == "A" || s1 == "B")
                {
                    listBox2.Items.Add(s1 + "   1");
                    listBox3.Items.Add(s1 + "   1");
                    listBox4.Items.Add("登记，扩散");
                    listBox5.Items.Add("登记");
                }
                else if (s1 == "C")
                {
                    listBox2.Items.Add(s1 + "   2");
                    listBox3.Items.Add(s1 + "   1");
                    listBox4.Items.Add("登记，扩散");
                    listBox5.Items.Add("登记");
                }
                else if (s1 == "D")
                {
                    listBox2.Items.Add(s1 + "   2");
                    listBox3.Items.Add(s1 + "   1");
                    listBox4.Items.Add("登记");
                    listBox5.Items.Add("登记，扩散");
                }
                else if (s1 == "E" || s1 == "F")
                {
                    listBox2.Items.Add(s1 + "   2");
                    listBox3.Items.Add(s1 + "   2");
                    listBox4.Items.Add("登记");
                    listBox5.Items.Add("登记，扩散");
                }
                else if (s1 == "G" || s1 == "H")
                {
                    listBox2.Items.Add(s1 + "   2");
                    listBox3.Items.Add(s1 + "   3");
                    listBox4.Items.Add("登记");
                    listBox5.Items.Add("登记，扩散");
                }
                else
                {
                    listBox2.Items.Add(s1 + "   3");
                    listBox3.Items.Add(s1 + "   1");
                    listBox4.Items.Add("登记，扩散");
                    listBox5.Items.Add("登记");
                }
            }
            else
                MessageBox.Show("错误！！");
        }



        private void button2_Click(object sender, EventArgs e) //重置
        {
            R1 = "";
            net = 0;
            purpose = 0;
            source = 0;
            listBox1.Items.Clear();
            listBox2.Items.Clear();
            listBox3.Items.Clear();
            listBox4.Items.Clear();
            listBox5.Items.Clear();
            comboBox1.Text = ""; //源地址栏
            comboBox2.Text = ""; //目的地址栏
            textBox1.Text = ""; //自动执行次数栏
            xhcs = 1; //循环次数
        }

        private void button3_Click(object sender, EventArgs e) //文件写入
        {
            string s = DateTime.Now.ToString(); //时间
            StreamWriter sw = new StreamWriter(@"C:\Users\40354\Desktop\test C#\ConsoleApp1\日志.txt", true);
            sw.WriteLine(); //回车
            sw.Write(s); //写入时间
            for (int i = 0; i < listBox1.Items.Count; i++)
            {

                sw.WriteLine();
                sw.Write("传送的帧：");
                sw.Write(listBox1.Items[i]);
                sw.WriteLine();
                sw.Write("网桥B1的操作及处理：");
                sw.Write(listBox2.Items[i]+" ");
                sw.Write(listBox4.Items[i]);
                sw.WriteLine();
                sw.Write("网桥B2的操作及处理：");
                sw.Write(listBox3.Items[i]+" ");
                sw.Write(listBox5.Items[i]);
                sw.WriteLine();
            }
            MessageBox.Show("保存成功！", "提示"); //保存成功提示框
            //清空缓冲区、关闭流 
            sw.Flush();
            sw.Close();
        }


        //自动跳转判断
        private void Form1_Load(object sender, EventArgs e) //加载并执行程序
        {
            timer1.Enabled = false; //控制是否进行自启动
            timer1.Interval = 1000; //每隔1S程序执行一次
        }

        private void timer1_Tick(object sender, EventArgs e) //自动生成转发表
        {
            int[] a = new int[2]; //初始化数组
            Random r = new Random();
            for (int i = 0; i < 2; i++)
                a[i] = r.Next(1, 10); //随机生成数分别存入S1,S2中
            comboBox1.Text = a[0].ToString(); 
            comboBox2.Text = a[1].ToString();
            //a[0]中的值对应的S1
            if (a[0] == 1)
            {
                comboBox1.Text = "A";
            }
            else if (a[0] == 2)
            {
                comboBox1.Text = "B";
            }
            else if (a[0] == 3)
            {
                comboBox1.Text = "C";
            }
            else if (a[0] == 4)
            {
                comboBox1.Text = "D";
            }
            else if (a[0] == 5)
            {
                comboBox1.Text = "E";
            }
            else if (a[0] == 6)
            {
                comboBox1.Text = "F";
            }
            else if (a[0] == 7)
            {
                comboBox1.Text = "G";
            }
            else if (a[0] == 8)
            {
                comboBox1.Text = "H";
            }
            else if (a[0] == 9)
            {
                comboBox1.Text = "P";
            }
            else
            {
                comboBox1.Text = "Q";
            }
            //a[1]中的值对应的S2
            if (a[1] == 1)
            {
                comboBox2.Text = "A";
            }
            else if (a[1] == 2)
            {
                comboBox2.Text = "B";
            }
            else if (a[1] == 3)
            {
                comboBox2.Text = "C";
            }
            else if (a[1] == 4)
            {
                comboBox2.Text = "D";
            }
            else if (a[1] == 5)
            {
                comboBox2.Text = "E";
            }
            else if (a[1] == 6)
            {
                comboBox2.Text = "F";
            }
            else if (a[1] == 7)
            {
                comboBox2.Text = "G";
            }
            else if (a[1] == 8)
            {
                comboBox2.Text = "H";
            }
            else if (a[1] == 9)
            {
                comboBox2.Text = "P";
            }
            else
            {
                comboBox2.Text = "Q";
            }
            Button1_Click(null, null);

            string m = textBox1.Text; //输入循环时间（次数）

            if (m == "") //若为空
            {
                timer1.Enabled = true; //启动计时器，开始循环

            }
            else //若非空
            {
                int m1 = Convert.ToInt32(m);
                xhcs = xhcs + 1; //循环次数+1
                if (xhcs > m1)
                {
                    timer1.Enabled = false; //当超过m1时，停止

                }
            }
        }

        private void button5_Click(object sender, EventArgs e) //停止按钮
        {
            timer1.Enabled = false;
        }

        private void button4_Click_1(object sender, EventArgs e) //开始按钮
        {
            timer1.Enabled = true;
            timer1.Start(); //启动计时器->timer1_Tick
        }





    }
}


