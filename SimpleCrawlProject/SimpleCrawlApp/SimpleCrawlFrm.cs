using CCWin;
using CCWin.SkinControl;
using SimpleCrawlApp.ControlsTool;
using SimpleCrawlApp.SimpleModel1;
using SimpleCrawlApp.SimpleModelTool;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace SimpleCrawlApp
{
    public partial class SimpleCrawlFrm : Skin_DevExpress
    {
        public SimpleCrawlFrm ()
        {
            InitializeComponent();
            init();
        }

        private void init ()
        {
        }

        #region 点击左下角列表触发的事件
        private void chatListBox_ClickSubItem (object sender , ChatListClickEventArgs e , MouseEventArgs es)
        {
            ChatListBoxEvent chatListBoxEvent = new ChatListBoxEvent(mdiTabControl ,this.skinSplitContainer2.Panel1);
            //MessageBox.Show("你单击了" + e.SelectSubItem.NicName);

            if (string.IsNullOrEmpty(e.SelectSubItem.NicName))
            {
                return;
            }
            chatListBoxEvent.GetTaskInfo(Convert.ToInt32(e.SelectSubItem.NicName));
        }
        #endregion




    }
}
