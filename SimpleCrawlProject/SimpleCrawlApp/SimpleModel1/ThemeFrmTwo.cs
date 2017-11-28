using CCWin.SkinControl;
using SimpleCrawl.Data.Auxiliary;
using SimpleCrawl.Data.Enumeration;
using SimpleCrawl.Geckofx;
using SimpleCrawlApp.Webbrower;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimpleCrawlApp.SimpleModel1
{
    public partial class ThemeFrmTwo : Form
    {
        private SkinTabControl tabControl;
        private TaskInfoEntity taskInfoEntity;
        private SplitterPanel splitterPanel;
        private DataGridView dgv;

        public ThemeFrmTwo (SkinTabControl tabControl , TaskInfoEntity taskInfoEntity)
        {
            InitializeComponent();
            this.tabControl = tabControl;
            this.taskInfoEntity = taskInfoEntity;

            init();
        }

        public void SetSplitterPanel (SplitterPanel splitterPanel)
        {
            this.splitterPanel = splitterPanel;
        }

        public void SetDataGridView (DataGridView dgv)
        {
            this.dgv = dgv;
        }


        private void init ()
        {
            this.backBtn.Click += GetBack;
            this.upBtn.Click += GetUp;
        }

        #region 上一步 下一步
        /// <summary>
        /// 上一步
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void GetBack (object sender , EventArgs e)
        {
            if (tabControl == null)
            {
                return;
            }
            if (tabControl.SelectedIndex == 0)
            {
                return;
            }
            tabControl.SelectedIndex = --tabControl.SelectedIndex;
        }

        /// <summary>
        /// 下一步
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void GetUp (object sender , EventArgs e)
        {
            try
            {
                taskInfoEntity.taskURL = taskURLWaterTextBox.Text;

                GeckofxWebbrowerFrm geckofxWebbrowerFrm = new GeckofxWebbrowerFrm(taskInfoEntity , dgv , GeckofxWebbrowerType.UrlModel);
                geckofxWebbrowerFrm.FormBorderStyle = FormBorderStyle.None;
                geckofxWebbrowerFrm.TopLevel = false;   //这个必须有不然会提示:"不能向tabControl中添加顶级控件"        
                geckofxWebbrowerFrm.Dock = DockStyle.Fill;
                geckofxWebbrowerFrm.Show();//这个必须有，不然显示不出来  
                this.splitterPanel.Controls.Add(geckofxWebbrowerFrm);
            }
            catch (Exception)
            {
                MessageBox.Show("信息填写有误！");
            }


            tabControl.SelectedIndex = ++tabControl.SelectedIndex;
        }

        #endregion







    }
}
