# AAADmsys
S1项目的寝室管理系统大概框架
# 说明
这是本人一期的结业项目，并不会用于商业，资源文件中可能会有侵犯版权的文件，请联系2217892328@qq.com<br>
因为源代码是在没有任何准备下直接开撸的肯定会有些没有注意的小bug

以下暂时考虑到的小问题：<br>
    [login.cs]<br>
    登录和数据库连接一起进行 （已解决）<br>
    加了个加载图片，但进入的时候因为登录框隐藏了会直接显示白的，几秒后直接跳出登录框（已解决）<br>
    在数据库连接的时候加载图片显示，如果数据库连接失败弹出修改数据库配置窗口（已解决）<br>
    在输入错误的账号时不会出现提示 （已解决）<br>
    权限判断 1.系统管理员 2.宿管 3.学生。。 学生到另一个界面，管理员界面会显示宿管管理(已解决)<br>
    [main.cs]<br>
     1.判断mid是否已打开窗口，如果已打开则会跳转到（未解决），没有打开即打开窗口(已解决一半)<br>
     2.更换mid背景图片（已解决 随便找了张图片换上去了）<br>
     3.权限问题，如果权限为管理员显示“宿管管理”，如果为宿管则不显示（已解决）<br>
     4.底部状态条添加点内容（未解决）<br>

