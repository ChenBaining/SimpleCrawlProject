using SimpleCrawl.Data.Auxiliary;
using SimpleCrawl.Data.Enumeration;
using SimpleCrawl.Geckofx;
using System;
using System.Windows.Forms;

namespace SimpleCrawlApp.Webbrower
{
    public partial class GeckofxWebbrowerFrm : Form
    {
        private TaskInfoEntity taskInfoEntity;
        private DataGridView dgv;
        private GeckofxWebbrowerType geckofxWebbrowerType;
        private string URL;

        public GeckofxWebbrowerFrm (TaskInfoEntity taskInfoEntity , DataGridView dgv , GeckofxWebbrowerType geckofxWebbrowerType , string URL = null)
        {
            InitializeComponent();
            this.taskInfoEntity = taskInfoEntity;
            this.dgv = dgv;
            this.geckofxWebbrowerType = geckofxWebbrowerType;
            this.URL = URL;
        }



        #region 加载事件
        private void GeckofxWebbrowerFrm_Load (object sender , EventArgs e)
        {
            GeckofxWebbrower geckofxWebbrower = new GeckofxWebbrower(this , dgv , taskInfoEntity , geckofxWebbrowerType , URL);
        }
        #endregion

    }
}
