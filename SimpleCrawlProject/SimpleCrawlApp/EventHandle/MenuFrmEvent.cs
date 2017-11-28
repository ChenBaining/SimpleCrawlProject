using SimpleCrawlApp.SimpleModelTool;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimpleCrawlApp.EventHandle
{
    class MenuFrmEvent
    {
        protected internal void GetMenuFrmShow (SplitterPanel splitterPanel ,Form form)
        {
            splitterPanel.Controls.Clear();
            MenuFrm mf = new MenuFrm(form);
            mf.FormBorderStyle = FormBorderStyle.None;
            mf.TopLevel = false;   //这个必须有不然会提示:"不能向tabControl中添加顶级控件"        
            mf.Dock = DockStyle.Fill;
            mf.Show();//这个必须有，不然显示不出来  
            splitterPanel.Controls.Add(mf);
        }

    }
}
