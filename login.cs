using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroSet_UI.Forms;
//using QConnectSDK;
using MySql.Data.MySqlClient;
using System.Threading;

namespace cs
{
    /// <summary>
    /// 未完成小问题：
    /// 解决一下先连接数据库后登录
    /// 在连接的时候将登录框隐藏，并将加载图片覆盖到登录框上，当数据库连接成功后，加载图片隐藏，且登录框显示
    /// 在输入错误的账号时，没有提示 （已完成）
    /// 权限判断 1.系统管理员 2.宿管 3.学生。。 学生到另一个界面(已完成)
    /// </summary>
    
    public partial class login : MetroSetForm
    {
        public static MySqlConnection conn = null;
        public static Boolean abc = true;
        static String exs = "";
        Thread linkMysql = new Thread(linksql);
        public login()
        {
            InitializeComponent();
            //Settings.setMysqlConfig("localhost", "3306","root","fanxing123","s1");
        }

        public static void linksql() {
            try
            {
                Mysql.comy = Mysql.link();
            }
            catch (MySqlException ex)
            {
                // MessageBox.Show("数据库连接 失败");
                // skinPanel1.Visible = true;
               // MetroSetMessageBox.Show(this, ex.Message.ToString());
                // MessageBox.Show(ex.Message.ToString(), "系统提示");
                //abc = false;

            }
            finally {
               
            }
        }

        void vis(int num) {
            if (num == 1)
            {
                gifBox1.Visible = false;
                skinLabel1.Visible = false;
                skinLabel2.Visible = false;
                user.Visible = true;
                pass.Visible = true;
                log.Visible = true;
                box.Visible = false;
            }
            else {
                gifBox1.Visible = true;
                skinLabel1.Visible = true;
                skinLabel2.Visible = true;
                user.Visible = false;
                pass.Visible = false;
                log.Visible = false;
                box.Visible = false;
            }
        }

        private void Login_Load(object sender, EventArgs e)
        {
           
            linkMysql.Start();
            Console.WriteLine("xxx:"+linkMysql.ThreadState.ToString());
           
           

            //linksql();
        }

      
 
      

        void loginyz(String user,String pass) {
            String sele = "SELECT count(*)  FROM `admin` where user = '" + user +"'";  //用来查询数据库内是否有该账号
            String sql = "SELECT * FROM `admin` where user = '" + user + "'";
            Console.WriteLine("这是" + sql);
            try
            {

                //执行查询，并将结果返回给读取器

                MySqlCommand cx = new MySqlCommand(sele, Mysql.comy);
                MySqlDataReader sel = null; //返回数据库对象
               
                sel = cx.ExecuteReader();
               
                sel.Read();
                if (Int16.Parse(sel[0].ToString()) <= 0)
                {
                    MessageBox.Show("没有找到该账号！","系统提示");

                }
                else {
                    sel.Close();
                    MySqlCommand cmd = new MySqlCommand(sql, Mysql.comy);
                    MySqlDataReader reader = null;//执行ExecuteReader()返回一个MySqlDataReader对象
                    reader = cmd.ExecuteReader();
                    
                    while (reader.Read())
                    {
                        String mypass = reader[2].ToString();
                        //String loui = reader[3].ToString();
                        if (pass == mypass)
                        {
                            Program.index[0] = user;
                            Program.index[1] = reader[3].ToString();
                            Program.index[2] = reader[4].ToString();
                            Program.index[3] = reader[5].ToString();
                            MessageBox.Show("登录成功,欢迎回来！", "系统提示");
                            Program.login_s = true;
                            this.Close();
                        }
                        else
                        {
                            MessageBox.Show("登录失败，密码错误！", "系统提示");
                            Console.WriteLine("FanxingMain:{0},失败原因:{1}", "登录失败", "密码错误");
                        }
                    }
                }
              
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message.ToString(), "系统提示");
                Console.WriteLine("FanxingMain:{0},失败原因:{1}", "登录失败", "数据库连接错误");
            }
            finally
            {
              
                Mysql.comy.Close();

            }
          

        }



        private void Timer1_Tick(object sender, EventArgs e)
        {
            if (linkMysql.ThreadState.ToString() != "Running")
            {
                try
                {
                    Mysql.comy.Open();
                    abc = true;
                }
                catch (MySqlException ex)
                {
                    abc = false;
                    exs = ex.Message.ToString();
                }
                finally
                {
                    if (abc)
                    {
                        vis(1);
                    }
                    else
                    {
                        vis(2);
                    }
                    timer1.Enabled = false;
                }
            }
        }

        private void SkinLabel2_Click_1(object sender, EventArgs e)
        {
            messbox mes = new messbox();
            mes.ShowDialog();
        }

        private void Log_Click_1(object sender, EventArgs e)
        {
            loginyz(user.Text, pass.Text);
        }
    }

     
    }

