using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace ConsoleApp1
{
    static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles(); //启动应用可视化
            Application.SetCompatibleTextRenderingDefault(false); //在应用程序范围内设置控件、使用GDI方式显示文本
            Application.Run(new Form1()); //在当前线程上开始运行标准应用程序消息循环，并使窗体可见
        }
    }
}
