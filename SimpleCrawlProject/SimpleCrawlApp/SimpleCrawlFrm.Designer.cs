namespace SimpleCrawlApp
{
    partial class SimpleCrawlFrm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose (bool disposing)
        {
            if (disposing && ( components != null ))
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
        private void InitializeComponent ()
        {
            CCWin.SkinControl.ChatListItem chatListItem1 = new CCWin.SkinControl.ChatListItem();
            CCWin.SkinControl.ChatListSubItem chatListSubItem1 = new CCWin.SkinControl.ChatListSubItem();
            CCWin.SkinControl.ChatListSubItem chatListSubItem2 = new CCWin.SkinControl.ChatListSubItem();
            CCWin.SkinControl.ChatListSubItem chatListSubItem3 = new CCWin.SkinControl.ChatListSubItem();
            CCWin.SkinControl.ChatListSubItem chatListSubItem4 = new CCWin.SkinControl.ChatListSubItem();
            CCWin.SkinControl.ChatListSubItem chatListSubItem5 = new CCWin.SkinControl.ChatListSubItem();
            CCWin.SkinControl.ChatListItem chatListItem2 = new CCWin.SkinControl.ChatListItem();
            CCWin.SkinControl.ChatListSubItem chatListSubItem6 = new CCWin.SkinControl.ChatListSubItem();
            CCWin.SkinControl.ChatListSubItem chatListSubItem7 = new CCWin.SkinControl.ChatListSubItem();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SimpleCrawlFrm));
            this.chatListBox = new CCWin.SkinControl.ChatListBox();
            this.skinTabPage12 = new CCWin.SkinControl.SkinTabPage();
            this.skinSplitContainer1 = new CCWin.SkinControl.SkinSplitContainer();
            this.skinSplitContainer2 = new CCWin.SkinControl.SkinSplitContainer();
            this.mdiTabControl = new CCWin.SkinControl.SkinTabControl();
            this.richTxtControl1 = new CCWin.SkinControl.RichTxtControl();
            this.skinPanel1 = new CCWin.SkinControl.SkinPanel();
            this.skinLabel2 = new CCWin.SkinControl.SkinLabel();
            this.skinLabel1 = new CCWin.SkinControl.SkinLabel();
            ((System.ComponentModel.ISupportInitialize)(this.skinSplitContainer1)).BeginInit();
            this.skinSplitContainer1.Panel1.SuspendLayout();
            this.skinSplitContainer1.Panel2.SuspendLayout();
            this.skinSplitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.skinSplitContainer2)).BeginInit();
            this.skinSplitContainer2.Panel2.SuspendLayout();
            this.skinSplitContainer2.SuspendLayout();
            this.mdiTabControl.SuspendLayout();
            this.skinPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // chatListBox
            // 
            this.chatListBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.chatListBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chatListBox.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.chatListBox.ForeColor = System.Drawing.Color.Black;
            this.chatListBox.FriendsMobile = false;
            chatListItem1.Bounds = new System.Drawing.Rectangle(0, 1, 150, 25);
            chatListItem1.IsTwinkleHide = false;
            chatListItem1.OwnerChatListBox = this.chatListBox;
            chatListSubItem1.Bounds = new System.Drawing.Rectangle(0, 27, 150, 53);
            chatListSubItem1.DisplayName = "新建任务(单页)";
            chatListSubItem1.HeadImage = global::SimpleCrawlApp.ImagesResource._1108673;
            chatListSubItem1.HeadRect = new System.Drawing.Rectangle(5, 33, 40, 40);
            chatListSubItem1.ID = ((uint)(0u));
            chatListSubItem1.IpAddress = null;
            chatListSubItem1.IsTwinkle = false;
            chatListSubItem1.IsTwinkleHide = false;
            chatListSubItem1.IsVip = false;
            chatListSubItem1.NicName = "9001";
            chatListSubItem1.OwnerListItem = chatListItem1;
            chatListSubItem1.PersonalMsg = "建立抓取单页的任务";
            chatListSubItem1.PlatformTypes = CCWin.SkinControl.PlatformType.PC;
            chatListSubItem1.QQShow = null;
            chatListSubItem1.Status = CCWin.SkinControl.ChatListSubItem.UserStatus.Online;
            chatListSubItem1.Tag = null;
            chatListSubItem1.TcpPort = 0;
            chatListSubItem1.UpdPort = 0;
            chatListSubItem2.Bounds = new System.Drawing.Rectangle(0, 81, 150, 53);
            chatListSubItem2.DisplayName = "导入任务";
            chatListSubItem2.HeadImage = global::SimpleCrawlApp.ImagesResource._1108683;
            chatListSubItem2.HeadRect = new System.Drawing.Rectangle(5, 87, 40, 40);
            chatListSubItem2.ID = ((uint)(0u));
            chatListSubItem2.IpAddress = null;
            chatListSubItem2.IsTwinkle = false;
            chatListSubItem2.IsTwinkleHide = false;
            chatListSubItem2.IsVip = false;
            chatListSubItem2.NicName = "9101";
            chatListSubItem2.OwnerListItem = chatListItem1;
            chatListSubItem2.PersonalMsg = "导入任务文件";
            chatListSubItem2.PlatformTypes = CCWin.SkinControl.PlatformType.PC;
            chatListSubItem2.QQShow = null;
            chatListSubItem2.Status = CCWin.SkinControl.ChatListSubItem.UserStatus.Online;
            chatListSubItem2.Tag = null;
            chatListSubItem2.TcpPort = 0;
            chatListSubItem2.UpdPort = 0;
            chatListSubItem3.Bounds = new System.Drawing.Rectangle(0, 135, 150, 53);
            chatListSubItem3.DisplayName = "导出任务";
            chatListSubItem3.HeadImage = global::SimpleCrawlApp.ImagesResource._1108681;
            chatListSubItem3.HeadRect = new System.Drawing.Rectangle(5, 141, 40, 40);
            chatListSubItem3.ID = ((uint)(0u));
            chatListSubItem3.IpAddress = null;
            chatListSubItem3.IsTwinkle = false;
            chatListSubItem3.IsTwinkleHide = false;
            chatListSubItem3.IsVip = false;
            chatListSubItem3.NicName = "9102";
            chatListSubItem3.OwnerListItem = chatListItem1;
            chatListSubItem3.PersonalMsg = "导出任务文件";
            chatListSubItem3.PlatformTypes = CCWin.SkinControl.PlatformType.PC;
            chatListSubItem3.QQShow = null;
            chatListSubItem3.Status = CCWin.SkinControl.ChatListSubItem.UserStatus.Online;
            chatListSubItem3.Tag = null;
            chatListSubItem3.TcpPort = 0;
            chatListSubItem3.UpdPort = 0;
            chatListSubItem4.Bounds = new System.Drawing.Rectangle(0, 189, 150, 53);
            chatListSubItem4.DisplayName = "规则市场";
            chatListSubItem4.HeadImage = global::SimpleCrawlApp.ImagesResource._1108660;
            chatListSubItem4.HeadRect = new System.Drawing.Rectangle(5, 195, 40, 40);
            chatListSubItem4.ID = ((uint)(0u));
            chatListSubItem4.IpAddress = null;
            chatListSubItem4.IsTwinkle = false;
            chatListSubItem4.IsTwinkleHide = false;
            chatListSubItem4.IsVip = false;
            chatListSubItem4.NicName = "9103";
            chatListSubItem4.OwnerListItem = chatListItem1;
            chatListSubItem4.PersonalMsg = "到市场查看规则";
            chatListSubItem4.PlatformTypes = CCWin.SkinControl.PlatformType.PC;
            chatListSubItem4.QQShow = null;
            chatListSubItem4.Status = CCWin.SkinControl.ChatListSubItem.UserStatus.Online;
            chatListSubItem4.Tag = null;
            chatListSubItem4.TcpPort = 0;
            chatListSubItem4.UpdPort = 0;
            chatListSubItem5.Bounds = new System.Drawing.Rectangle(0, 243, 150, 53);
            chatListSubItem5.DisplayName = "数据市场";
            chatListSubItem5.HeadImage = global::SimpleCrawlApp.ImagesResource._1108665;
            chatListSubItem5.HeadRect = new System.Drawing.Rectangle(5, 249, 40, 40);
            chatListSubItem5.ID = ((uint)(0u));
            chatListSubItem5.IpAddress = null;
            chatListSubItem5.IsTwinkle = false;
            chatListSubItem5.IsTwinkleHide = false;
            chatListSubItem5.IsVip = false;
            chatListSubItem5.NicName = "9105";
            chatListSubItem5.OwnerListItem = chatListItem1;
            chatListSubItem5.PersonalMsg = "到市场查看数据";
            chatListSubItem5.PlatformTypes = CCWin.SkinControl.PlatformType.PC;
            chatListSubItem5.QQShow = null;
            chatListSubItem5.Status = CCWin.SkinControl.ChatListSubItem.UserStatus.Online;
            chatListSubItem5.Tag = null;
            chatListSubItem5.TcpPort = 0;
            chatListSubItem5.UpdPort = 0;
            chatListItem1.SubItems.AddRange(new CCWin.SkinControl.ChatListSubItem[] {
            chatListSubItem1,
            chatListSubItem2,
            chatListSubItem3,
            chatListSubItem4,
            chatListSubItem5});
            chatListItem1.Tag = null;
            chatListItem1.Text = "任务向导";
            chatListItem1.TwinkleSubItemNumber = 0;
            chatListItem2.Bounds = new System.Drawing.Rectangle(0, 27, 150, 25);
            chatListItem2.IsTwinkleHide = false;
            chatListItem2.OwnerChatListBox = this.chatListBox;
            chatListSubItem6.Bounds = new System.Drawing.Rectangle(0, 0, 0, 0);
            chatListSubItem6.DisplayName = "我的任务";
            chatListSubItem6.HeadImage = global::SimpleCrawlApp.ImagesResource._1108686;
            chatListSubItem6.HeadRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            chatListSubItem6.ID = ((uint)(0u));
            chatListSubItem6.IpAddress = null;
            chatListSubItem6.IsTwinkle = false;
            chatListSubItem6.IsTwinkleHide = false;
            chatListSubItem6.IsVip = false;
            chatListSubItem6.NicName = "9201";
            chatListSubItem6.OwnerListItem = chatListItem2;
            chatListSubItem6.PersonalMsg = "我的所有任务";
            chatListSubItem6.PlatformTypes = CCWin.SkinControl.PlatformType.PC;
            chatListSubItem6.QQShow = null;
            chatListSubItem6.Status = CCWin.SkinControl.ChatListSubItem.UserStatus.Online;
            chatListSubItem6.Tag = null;
            chatListSubItem6.TcpPort = 0;
            chatListSubItem6.UpdPort = 0;
            chatListSubItem7.Bounds = new System.Drawing.Rectangle(0, 0, 0, 0);
            chatListSubItem7.DisplayName = "任务状态";
            chatListSubItem7.HeadImage = global::SimpleCrawlApp.ImagesResource._1108774;
            chatListSubItem7.HeadRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            chatListSubItem7.ID = ((uint)(0u));
            chatListSubItem7.IpAddress = null;
            chatListSubItem7.IsTwinkle = false;
            chatListSubItem7.IsTwinkleHide = false;
            chatListSubItem7.IsVip = false;
            chatListSubItem7.NicName = "9202";
            chatListSubItem7.OwnerListItem = chatListItem2;
            chatListSubItem7.PersonalMsg = "任务执行状态";
            chatListSubItem7.PlatformTypes = CCWin.SkinControl.PlatformType.PC;
            chatListSubItem7.QQShow = null;
            chatListSubItem7.Status = CCWin.SkinControl.ChatListSubItem.UserStatus.Online;
            chatListSubItem7.Tag = null;
            chatListSubItem7.TcpPort = 0;
            chatListSubItem7.UpdPort = 0;
            chatListItem2.SubItems.AddRange(new CCWin.SkinControl.ChatListSubItem[] {
            chatListSubItem6,
            chatListSubItem7});
            chatListItem2.Tag = null;
            chatListItem2.Text = "我的内容";
            chatListItem2.TwinkleSubItemNumber = 0;
            this.chatListBox.Items.AddRange(new CCWin.SkinControl.ChatListItem[] {
            chatListItem1,
            chatListItem2});
            this.chatListBox.ListSubItemMenu = null;
            this.chatListBox.Location = new System.Drawing.Point(0, 0);
            this.chatListBox.Name = "chatListBox";
            this.chatListBox.SelectSubItem = null;
            this.chatListBox.Size = new System.Drawing.Size(150, 247);
            this.chatListBox.SubItemMenu = null;
            this.chatListBox.TabIndex = 0;
            this.chatListBox.Text = "chatListBox1";
            this.chatListBox.ClickSubItem += new CCWin.SkinControl.ChatListBox.ChatListClickEventHandler(this.chatListBox_ClickSubItem);
            // 
            // skinTabPage12
            // 
            this.skinTabPage12.BackColor = System.Drawing.Color.White;
            this.skinTabPage12.Dock = System.Windows.Forms.DockStyle.Fill;
            this.skinTabPage12.Location = new System.Drawing.Point(0, 36);
            this.skinTabPage12.Name = "skinTabPage12";
            this.skinTabPage12.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.skinTabPage12.Size = new System.Drawing.Size(838, 496);
            this.skinTabPage12.TabIndex = 11;
            this.skinTabPage12.TabItemImage = global::SimpleCrawlApp.ImagesResource._1108665;
            this.skinTabPage12.Text = "Home";
            // 
            // skinSplitContainer1
            // 
            this.skinSplitContainer1.Cursor = System.Windows.Forms.Cursors.Default;
            this.skinSplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.skinSplitContainer1.Location = new System.Drawing.Point(4, 34);
            this.skinSplitContainer1.Name = "skinSplitContainer1";
            // 
            // skinSplitContainer1.Panel1
            // 
            this.skinSplitContainer1.Panel1.Controls.Add(this.skinSplitContainer2);
            // 
            // skinSplitContainer1.Panel2
            // 
            this.skinSplitContainer1.Panel2.Controls.Add(this.mdiTabControl);
            this.skinSplitContainer1.Size = new System.Drawing.Size(992, 532);
            this.skinSplitContainer1.SplitterDistance = 150;
            this.skinSplitContainer1.TabIndex = 10;
            // 
            // skinSplitContainer2
            // 
            this.skinSplitContainer2.Cursor = System.Windows.Forms.Cursors.Default;
            this.skinSplitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.skinSplitContainer2.Location = new System.Drawing.Point(0, 0);
            this.skinSplitContainer2.Name = "skinSplitContainer2";
            this.skinSplitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // skinSplitContainer2.Panel2
            // 
            this.skinSplitContainer2.Panel2.Controls.Add(this.chatListBox);
            this.skinSplitContainer2.Size = new System.Drawing.Size(150, 532);
            this.skinSplitContainer2.SplitterDistance = 281;
            this.skinSplitContainer2.TabIndex = 0;
            // 
            // mdiTabControl
            // 
            this.mdiTabControl.AnimatorType = CCWin.SkinControl.AnimationType.HorizSlide;
            this.mdiTabControl.ArrowBaseColor = System.Drawing.Color.White;
            this.mdiTabControl.ArrowBorderColor = System.Drawing.Color.LightGray;
            this.mdiTabControl.ArrowColor = System.Drawing.Color.SteelBlue;
            this.mdiTabControl.CloseRect = new System.Drawing.Rectangle(2, 2, 12, 12);
            this.mdiTabControl.Controls.Add(this.skinTabPage12);
            this.mdiTabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mdiTabControl.HeadBack = null;
            this.mdiTabControl.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.mdiTabControl.ImgTxtOffset = new System.Drawing.Point(0, 0);
            this.mdiTabControl.ItemSize = new System.Drawing.Size(58, 36);
            this.mdiTabControl.Location = new System.Drawing.Point(0, 0);
            this.mdiTabControl.Name = "mdiTabControl";
            this.mdiTabControl.PageArrowDown = ((System.Drawing.Image)(resources.GetObject("mdiTabControl.PageArrowDown")));
            this.mdiTabControl.PageArrowHover = ((System.Drawing.Image)(resources.GetObject("mdiTabControl.PageArrowHover")));
            this.mdiTabControl.PageCloseHover = ((System.Drawing.Image)(resources.GetObject("mdiTabControl.PageCloseHover")));
            this.mdiTabControl.PageCloseNormal = ((System.Drawing.Image)(resources.GetObject("mdiTabControl.PageCloseNormal")));
            this.mdiTabControl.PageCloseVisble = true;
            this.mdiTabControl.PageDown = ((System.Drawing.Image)(resources.GetObject("mdiTabControl.PageDown")));
            this.mdiTabControl.PageHover = ((System.Drawing.Image)(resources.GetObject("mdiTabControl.PageHover")));
            this.mdiTabControl.PageImagePosition = CCWin.SkinControl.SkinTabControl.ePageImagePosition.Left;
            this.mdiTabControl.PageNorml = null;
            this.mdiTabControl.PageNormlTxtColor = System.Drawing.Color.DimGray;
            this.mdiTabControl.SelectedIndex = 0;
            this.mdiTabControl.Size = new System.Drawing.Size(838, 532);
            this.mdiTabControl.SizeMode = System.Windows.Forms.TabSizeMode.FillToRight;
            this.mdiTabControl.TabIndex = 0;
            // 
            // richTxtControl1
            // 
            this.richTxtControl1.Location = new System.Drawing.Point(7, 35);
            this.richTxtControl1.Name = "richTxtControl1";
            this.richTxtControl1.Size = new System.Drawing.Size(105, 53);
            this.richTxtControl1.TabIndex = 9;
            // 
            // skinPanel1
            // 
            this.skinPanel1.BackColor = System.Drawing.Color.Transparent;
            this.skinPanel1.BorderColor = System.Drawing.Color.LightGray;
            this.skinPanel1.Controls.Add(this.skinLabel2);
            this.skinPanel1.Controls.Add(this.skinLabel1);
            this.skinPanel1.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.skinPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.skinPanel1.DownBack = null;
            this.skinPanel1.Location = new System.Drawing.Point(4, 566);
            this.skinPanel1.MouseBack = null;
            this.skinPanel1.Name = "skinPanel1";
            this.skinPanel1.NormlBack = null;
            this.skinPanel1.Size = new System.Drawing.Size(992, 30);
            this.skinPanel1.TabIndex = 11;
            // 
            // skinLabel2
            // 
            this.skinLabel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.skinLabel2.AutoSize = true;
            this.skinLabel2.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel2.BorderColor = System.Drawing.Color.White;
            this.skinLabel2.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel2.Location = new System.Drawing.Point(660, 6);
            this.skinLabel2.Name = "skinLabel2";
            this.skinLabel2.Size = new System.Drawing.Size(172, 17);
            this.skinLabel2.TabIndex = 1;
            this.skinLabel2.Text = "消息通道，目前还在构建中……";
            // 
            // skinLabel1
            // 
            this.skinLabel1.AutoSize = true;
            this.skinLabel1.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel1.BorderColor = System.Drawing.Color.White;
            this.skinLabel1.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel1.Location = new System.Drawing.Point(20, 6);
            this.skinLabel1.Name = "skinLabel1";
            this.skinLabel1.Size = new System.Drawing.Size(223, 17);
            this.skinLabel1.TabIndex = 0;
            this.skinLabel1.Text = "欢迎您  【Demo】 您目前是免费用户！";
            // 
            // SimpleCrawlFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 600);
            this.Controls.Add(this.skinSplitContainer1);
            this.Controls.Add(this.richTxtControl1);
            this.Controls.Add(this.skinPanel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SimpleCrawlFrm";
            this.Text = "爬山虎";
            this.skinSplitContainer1.Panel1.ResumeLayout(false);
            this.skinSplitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.skinSplitContainer1)).EndInit();
            this.skinSplitContainer1.ResumeLayout(false);
            this.skinSplitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.skinSplitContainer2)).EndInit();
            this.skinSplitContainer2.ResumeLayout(false);
            this.mdiTabControl.ResumeLayout(false);
            this.skinPanel1.ResumeLayout(false);
            this.skinPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private CCWin.SkinControl.SkinTabPage skinTabPage12;
        private CCWin.SkinControl.SkinSplitContainer skinSplitContainer1;
        private CCWin.SkinControl.SkinSplitContainer skinSplitContainer2;
        private CCWin.SkinControl.SkinTabControl mdiTabControl;
        private CCWin.SkinControl.RichTxtControl richTxtControl1;
        private CCWin.SkinControl.SkinPanel skinPanel1;
        private CCWin.SkinControl.SkinLabel skinLabel1;
        private CCWin.SkinControl.SkinLabel skinLabel2;
        private CCWin.SkinControl.ChatListBox chatListBox;
    }
}