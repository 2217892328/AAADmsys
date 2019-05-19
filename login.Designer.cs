namespace cs
{
    partial class login
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
            this.components = new System.ComponentModel.Container();
            this.metroSetControlBox1 = new MetroSet_UI.Controls.MetroSetControlBox();
            this.metroSetLabel1 = new MetroSet_UI.Controls.MetroSetLabel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.box = new System.Windows.Forms.PictureBox();
            this.skinLabel2 = new CCWin.SkinControl.SkinLabel();
            this.skinLabel1 = new CCWin.SkinControl.SkinLabel();
            this.gifBox1 = new CCWin.SkinControl.GifBox();
            this.log = new MetroSet_UI.Controls.MetroSetButton();
            this.pass = new System.Windows.Forms.TextBox();
            this.user = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.box)).BeginInit();
            this.SuspendLayout();
            // 
            // metroSetControlBox1
            // 
            this.metroSetControlBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.metroSetControlBox1.CloseHoverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.metroSetControlBox1.CloseHoverForeColor = System.Drawing.Color.White;
            this.metroSetControlBox1.CloseNormalForeColor = System.Drawing.Color.Gray;
            this.metroSetControlBox1.DisabledForeColor = System.Drawing.Color.DimGray;
            this.metroSetControlBox1.Location = new System.Drawing.Point(1491, 2);
            this.metroSetControlBox1.MaximizeBox = false;
            this.metroSetControlBox1.MaximizeHoverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.metroSetControlBox1.MaximizeHoverForeColor = System.Drawing.Color.Gray;
            this.metroSetControlBox1.MaximizeNormalForeColor = System.Drawing.Color.Gray;
            this.metroSetControlBox1.MinimizeBox = false;
            this.metroSetControlBox1.MinimizeHoverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.metroSetControlBox1.MinimizeHoverForeColor = System.Drawing.Color.Gray;
            this.metroSetControlBox1.MinimizeNormalForeColor = System.Drawing.Color.Gray;
            this.metroSetControlBox1.Name = "metroSetControlBox1";
            this.metroSetControlBox1.Size = new System.Drawing.Size(100, 25);
            this.metroSetControlBox1.Style = MetroSet_UI.Design.Style.Light;
            this.metroSetControlBox1.StyleManager = null;
            this.metroSetControlBox1.TabIndex = 0;
            this.metroSetControlBox1.Text = "metroSetControlBox1";
            this.metroSetControlBox1.ThemeAuthor = "Narwin";
            this.metroSetControlBox1.ThemeName = "MetroLite";
            // 
            // metroSetLabel1
            // 
            this.metroSetLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 5.445378F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.metroSetLabel1.Location = new System.Drawing.Point(-2, 681);
            this.metroSetLabel1.Name = "metroSetLabel1";
            this.metroSetLabel1.Size = new System.Drawing.Size(438, 20);
            this.metroSetLabel1.Style = MetroSet_UI.Design.Style.Dark;
            this.metroSetLabel1.StyleManager = null;
            this.metroSetLabel1.TabIndex = 9;
            this.metroSetLabel1.Text = "©AAA130 FANXING";
            this.metroSetLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroSetLabel1.ThemeAuthor = "Narwin";
            this.metroSetLabel1.ThemeName = "MetroDark";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.Timer1_Tick);
            // 
            // box
            // 
            this.box.BackColor = System.Drawing.Color.White;
            this.box.Location = new System.Drawing.Point(741, 206);
            this.box.Name = "box";
            this.box.Size = new System.Drawing.Size(474, 407);
            this.box.TabIndex = 10;
            this.box.TabStop = false;
            // 
            // skinLabel2
            // 
            this.skinLabel2.AutoSize = true;
            this.skinLabel2.BackColor = System.Drawing.Color.White;
            this.skinLabel2.BorderColor = System.Drawing.Color.White;
            this.skinLabel2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.skinLabel2.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel2.ForeColor = System.Drawing.Color.LightSkyBlue;
            this.skinLabel2.Location = new System.Drawing.Point(1017, 635);
            this.skinLabel2.Name = "skinLabel2";
            this.skinLabel2.Size = new System.Drawing.Size(69, 20);
            this.skinLabel2.TabIndex = 30;
            this.skinLabel2.Text = "重新配置";
            this.skinLabel2.Visible = false;
            this.skinLabel2.Click += new System.EventHandler(this.SkinLabel2_Click_1);
            // 
            // skinLabel1
            // 
            this.skinLabel1.AutoSize = true;
            this.skinLabel1.BackColor = System.Drawing.Color.White;
            this.skinLabel1.BorderColor = System.Drawing.Color.White;
            this.skinLabel1.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel1.Location = new System.Drawing.Point(891, 635);
            this.skinLabel1.Name = "skinLabel1";
            this.skinLabel1.Size = new System.Drawing.Size(129, 20);
            this.skinLabel1.TabIndex = 29;
            this.skinLabel1.Text = "数据库连接异常，";
            this.skinLabel1.Visible = false;
            // 
            // gifBox1
            // 
            this.gifBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.gifBox1.BorderColor = System.Drawing.Color.Transparent;
            this.gifBox1.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.gifBox1.Image = global::cs.Properties.Resources.loading;
            this.gifBox1.Location = new System.Drawing.Point(727, 192);
            this.gifBox1.Name = "gifBox1";
            this.gifBox1.Size = new System.Drawing.Size(528, 432);
            this.gifBox1.TabIndex = 28;
            this.gifBox1.Text = "gifBox1";
            this.gifBox1.Visible = false;
            // 
            // log
            // 
            this.log.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.log.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.log.DisabledForeColor = System.Drawing.Color.Gray;
            this.log.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.log.HoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(207)))), ((int)(((byte)(255)))));
            this.log.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(207)))), ((int)(((byte)(255)))));
            this.log.HoverTextColor = System.Drawing.Color.White;
            this.log.Location = new System.Drawing.Point(812, 587);
            this.log.Name = "log";
            this.log.NormalBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.log.NormalColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.log.NormalTextColor = System.Drawing.Color.White;
            this.log.PressBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(147)))), ((int)(((byte)(195)))));
            this.log.PressColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(147)))), ((int)(((byte)(195)))));
            this.log.PressTextColor = System.Drawing.Color.White;
            this.log.Size = new System.Drawing.Size(374, 57);
            this.log.Style = MetroSet_UI.Design.Style.Light;
            this.log.StyleManager = null;
            this.log.TabIndex = 27;
            this.log.Text = "LOGIN SYSTEM";
            this.log.ThemeAuthor = "Narwin";
            this.log.ThemeName = "MetroLite";
            this.log.Visible = false;
            this.log.Click += new System.EventHandler(this.Log_Click_1);
            // 
            // pass
            // 
            this.pass.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.pass.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.28571F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pass.Location = new System.Drawing.Point(845, 497);
            this.pass.Name = "pass";
            this.pass.Size = new System.Drawing.Size(323, 20);
            this.pass.TabIndex = 26;
            this.pass.Text = "123456";
            this.pass.UseSystemPasswordChar = true;
            this.pass.Visible = false;
            // 
            // user
            // 
            this.user.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.user.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.28571F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.user.Location = new System.Drawing.Point(846, 434);
            this.user.Name = "user";
            this.user.Size = new System.Drawing.Size(323, 20);
            this.user.TabIndex = 25;
            this.user.Text = "admin";
            this.user.Visible = false;
            // 
            // login
            // 
            this.AllowResize = false;
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackgroundImage = global::cs.Properties.Resources.nicel1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.BorderThickness = 0F;
            this.ClientSize = new System.Drawing.Size(1595, 897);
            this.Controls.Add(this.skinLabel2);
            this.Controls.Add(this.skinLabel1);
            this.Controls.Add(this.gifBox1);
            this.Controls.Add(this.log);
            this.Controls.Add(this.pass);
            this.Controls.Add(this.user);
            this.Controls.Add(this.box);
            this.Controls.Add(this.metroSetLabel1);
            this.Controls.Add(this.metroSetControlBox1);
            this.HeaderColor = System.Drawing.Color.Yellow;
            this.HeaderHeight = 20;
            this.HelpButton = true;
            this.MaximumSize = new System.Drawing.Size(1595, 897);
            this.Name = "login";
            this.Padding = new System.Windows.Forms.Padding(12, 90, 12, 12);
            this.ShowTitle = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "登录后台管理系统";
            this.TextColor = System.Drawing.Color.White;
            this.Load += new System.EventHandler(this.Login_Load);
            ((System.ComponentModel.ISupportInitialize)(this.box)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MetroSet_UI.Controls.MetroSetControlBox metroSetControlBox1;
        private MetroSet_UI.Controls.MetroSetLabel metroSetLabel1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox box;
        private CCWin.SkinControl.SkinLabel skinLabel2;
        private CCWin.SkinControl.SkinLabel skinLabel1;
        private CCWin.SkinControl.GifBox gifBox1;
        private MetroSet_UI.Controls.MetroSetButton log;
        private System.Windows.Forms.TextBox pass;
        private System.Windows.Forms.TextBox user;
    }
}