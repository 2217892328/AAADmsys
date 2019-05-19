using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cs
{
    static class Program
    {
        public static Boolean login_s = false; //是否登录成功
        public static String[] index = new String[4] { "账号","权限","手机","姓名"};  //保存登录信息
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new login());
            if (login_s) {
                #region 根据权限进入不同的处理页面
                switch (index[1]) {
                    case "1":
                        Application.Run(new main());
                        break;
                    case "2":
                        Application.Run(new main());
                        break;
                    case "3":
                        //Application.Run(new main());
                        MessageBox.Show("非常抱歉，学生模式暂时不开放！","系统提示");
                        break;
                    default:
                        MessageBox.Show("检测到异常权限，立即退出系统!","系统提示");
                        break;
                }
                #endregion
            }
        }
    }
}
