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
using CCWin;

namespace cs
{
    /// <summary>
    /// 未解决问题
    /// 1.判断mid是否已打开窗口，如果已打开则会跳转到，没有打开即打开窗口
    /// 2.更换mid背景图片
    /// 3.权限问题，如果权限为管理员显示“宿管管理”，如果为宿管则不显示
    /// 4.底部状态条添加点内容
    /// </summary>
    public partial class main : Skin_DevExpress
    {

        public main()
        {
            InitializeComponent();
        }

        private void Main_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < 4; i++)
            {
                Console.WriteLine(Program.index[i]);
            }
        }
        /// <summary>
        /// 用来快速show窗口并且检测是否存在窗口
        /// </summary>
        /// <param name="sid">窗口编号</param>
        void showin(int sid)
        {
            switch (sid)
            {
                case 1: //楼层管理
                    if (selectWin("floor"))
                    {
                        window.floor floor = new window.floor();
                        floor.MdiParent = this;
                        floor.Show();
                    }
                    break;
                case 2: //房间管理
                    if (selectWin("room"))
                    {
                        window.floor floor = new window.floor();
                        floor.MdiParent = this;
                        floor.Show();
                    }
                    break;
                case 3://入住办理
                    if (selectWin("checkin"))
                    {
                        window.floor floor = new window.floor();
                        floor.MdiParent = this;
                        floor.Show();
                    }
                    break;
                case 4://退宿办理
                    if (selectWin("checkout"))
                    {
                        window.floor floor = new window.floor();
                        floor.MdiParent = this;
                        floor.Show();
                    }
                    break;
                case 5://调宿办理
                    if (selectWin("checkup"))
                    {
                        window.floor floor = new window.floor();
                        floor.MdiParent = this;
                        floor.Show();
                    }
                    break;
                case 6://晚归记录
                    if (selectWin("backlate"))
                    {
                        window.floor floor = new window.floor();
                        floor.MdiParent = this;
                        floor.Show();
                    }
                    break;
                case 7://数据分析
                    if (selectWin("datafx"))
                    {
                        window.floor floor = new window.floor();
                        floor.MdiParent = this;
                        floor.Show();
                    }
                    break;
                case 8://来访登记
                    if (selectWin("welcomes"))
                    {
                        window.floor floor = new window.floor();
                        floor.MdiParent = this;
                        floor.Show();
                    }
                    break;
                case 9://来访记录
                    if (selectWin("welog"))
                    {
                        window.floor floor = new window.floor();
                        floor.MdiParent = this;
                        floor.Show();
                    }
                    break;
                case 10://学生列表
                    if (selectWin("stulist"))
                    {
                        window.floor floor = new window.floor();
                        floor.MdiParent = this;
                        floor.Show();
                    }
                    break;
                case 11://班级信息
                    if (selectWin("classi"))
                    {
                        window.floor floor = new window.floor();
                        floor.MdiParent = this;
                        floor.Show();
                    }
                    break;
                case 12://录入信息
                    if (selectWin("enteri"))
                    {
                        window.floor floor = new window.floor();
                        floor.MdiParent = this;
                        floor.Show();
                    }
                    break;
                case 13://添加宿管
                    if (selectWin("addsuguan"))
                    {
                        window.floor floor = new window.floor();
                        floor.MdiParent = this;
                        floor.Show();
                    }
                    break;
                case 14://宿管列表
                    if (selectWin("suguanlist"))
                    {
                        window.floor floor = new window.floor();
                        floor.MdiParent = this;
                        floor.Show();
                    }
                    break;
                case 15://临时权限
                    if (selectWin("tempower"))
                    {
                        window.floor floor = new window.floor();
                        floor.MdiParent = this;
                        floor.Show();
                    }
                    break;
                case 16://系统设置
                    //if (selectWin())
                    {
                        messbox f = new messbox();
                        // f.MdiParent = this;
                        f.ShowDialog();
                        //}
                        break;
                    }

            }
            /// <summary>
            /// 判断mid窗口是否已打开窗口
            /// </summary>
            /// <param name="name">当前窗口名称</param>
            /// <returns></returns>
            bool selectWin(String name = "")
            {
                for (int i = 0; i < this.MdiChildren.Length; i++)
                {
                    if (this.MdiChildren[i].Name == name)
                    {
                        Console.WriteLine("mdi窗口已经打开当前窗口");
                        return false;
                    }
                }
                return true;
            }



            #region 菜单选项

            #endregion


        }

   

        private void 楼层管理ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            showin(1);
        }

        private void 房间管理ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            showin(2);
        }

        private void 学生信息ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            showin(3);
        }

        private void 班级信息ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            showin(4);
        }

        private void 调宿办理ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            showin(5);
        }

        private void 申请入住ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            showin(6);
        }

        private void 离宿办理ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            showin(7);
        }

        private void 来访登记ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            showin(8);
        }

        private void 来访记录ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            showin(9);
        }

        private void 学生列表ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            showin(10);
        }

        private void 班级信息ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            showin(11);
        }

        private void 录入信息ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            showin(12);
        }

        private void 添加宿管ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            showin(13);
        }

        private void 宿管列表ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            showin(14);
        }

        private void 临时权限ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            showin(15);
        }

        private void 系统设置ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            showin(16);
        }
    }
}