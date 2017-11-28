using CCWin.SkinControl;
using SimpleCrawlApp.EventHandle;
using SimpleCrawlApp.SimpleModelTool;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimpleCrawlApp.ControlsTool
{
    public class ChatListBoxEvent
    {
        private SkinTabControl tabControl;  
        private SplitterPanel splitterPanel;

        public ChatListBoxEvent (SkinTabControl tabControl , SplitterPanel splitterPanel)
        {
            this.tabControl = tabControl;
            this.splitterPanel = splitterPanel;
        }

        protected internal void GetTaskInfo (int taskMessage)
        {
            switch (taskMessage)
            {
                case 9001:  //新建任务
                //MenuFrmEvent menuFrmEvents = new MenuFrmEvent();
                //menuFrmEvents.GetMenuFrmShow(splitterPanel , new MyTaskFrm());

                MDIFrmEvent frmEvent = new MDIFrmEvent();
                frmEvent.GetMDIFrmShow(tabControl , "新建任务(单页)");
                break;

                case 9101:  //导出任务
                MenuFrmEvent menuFrmEvent = new MenuFrmEvent();
                menuFrmEvent.GetMenuFrmShow(splitterPanel , new ImportTasksFrm());
                break;

                case 9102:  //导出任务
                menuFrmEvent = new MenuFrmEvent();
                menuFrmEvent.GetMenuFrmShow(splitterPanel ,new ExportTasksFrm());
                break;

                case 9202:  //任务状态
                menuFrmEvent = new MenuFrmEvent();
                menuFrmEvent.GetMenuFrmShow(splitterPanel , new TaskStatusFrm());
                break;








                default:


               


                break;
            }
        }


    }
}
