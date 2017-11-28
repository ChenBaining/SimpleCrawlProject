using CCWin.SkinControl;
using SimpleCrawl.Data.Auxiliary;
using SimpleCrawlApp.SimpleModel1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimpleCrawlApp.EventHandle
{
    class MDIFrmEvent
    {
        private int tabIndex = 1;
        private TaskInfoEntity taskInfoEntity;

        public MDIFrmEvent ()
        {
            taskInfoEntity = new TaskInfoEntity();
        }

        protected internal void GetMDIFrmShow (SkinTabControl tabControl ,string pageText)
        {
            TabPage Page = new TabPage();
            Page.Name = "Page" + tabIndex;
            Page.Text = pageText;
            Page.TabIndex = tabIndex++;
            tabControl.Dock = DockStyle.Fill;

            MDIFrm mdif = new MDIFrm();
            List<Form> formList = new List<Form>();

            ThemeFrm themeFrm = new ThemeFrm(mdif.GetTabControl() , taskInfoEntity);
            formList.Add(themeFrm);

            ThemeFrmTwo themeFrmTwo = new ThemeFrmTwo(mdif.GetTabControl() , taskInfoEntity);
            formList.Add(themeFrmTwo);

            GeckofxFrm geckofxFrm = new GeckofxFrm(mdif.GetTabControl() , taskInfoEntity);
            formList.Add(geckofxFrm);
            themeFrmTwo.SetSplitterPanel(geckofxFrm.GetSplitterPanel());
            themeFrmTwo.SetDataGridView(geckofxFrm.GetDataGridView());

            GeckofxDetailedFrm geckofxDetailedFrm = new GeckofxDetailedFrm(mdif.GetTabControl() , taskInfoEntity);
            formList.Add(geckofxDetailedFrm);
            geckofxFrm.SetSplitterPanel(geckofxDetailedFrm.GetSplitterPanel());
            geckofxFrm.SetDataGridView(geckofxDetailedFrm.GetDataGridView());

            formList.Add(new ResultFrm(mdif.GetTabControl() , taskInfoEntity));
            mdif.LoadData(formList);

            mdif.FormBorderStyle = FormBorderStyle.None;
            mdif.TopLevel = false;   //这个必须有不然会提示:"不能向tabControl中添加顶级控件"        
            mdif.Dock = DockStyle.Fill;
            mdif.Show();//这个必须有，不然显示不出来  
            Page.Controls.Add(mdif);
            tabControl.Controls.Add(Page);
        }

    }
}
