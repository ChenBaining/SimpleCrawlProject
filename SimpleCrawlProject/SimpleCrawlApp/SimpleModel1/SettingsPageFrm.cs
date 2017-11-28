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
    public partial class SettingsPageFrm : Form
    {
        public SettingsPageFrm ()
        {
            InitializeComponent();

            init();
        }

        public void init ()
        {
            this.visiblePanel.Visible = false;
            this.noPageRadioBtn.CheckedChanged += radioBtn_CheckedChange;
            this.yesPageRadioBtn.CheckedChanged += radioBtn_CheckedChange;
        }

        #region 选择元素
        //RadioButton新事件
        public void radioBtn_CheckedChange (object sender , EventArgs e)
        {
            if (!( (RadioButton)sender ).Checked)
            {
                return;
            }
            string rechargeMoney = string.Empty;

            if (((RadioButton)sender ).Text.ToString().Contains("不需要翻页"))
            {
                this.visiblePanel.Visible = false;
            }
            else if (( (RadioButton)sender ).Text.ToString().Contains("需要翻页"))
            {
                this.visiblePanel.Visible = true;
            }
        }
        #endregion








    }
}
