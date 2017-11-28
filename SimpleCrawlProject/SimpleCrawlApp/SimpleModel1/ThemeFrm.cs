using CCWin.SkinControl;
using SimpleCrawl.Data.Auxiliary;
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
    public partial class ThemeFrm : Form
    {
        private SkinTabControl tabControl;
        private TaskInfoEntity taskInfoEntity;

        public ThemeFrm (SkinTabControl tabControl , TaskInfoEntity taskInfoEntity)
        {
            InitializeComponent();
            this.tabControl = tabControl;
            this.taskInfoEntity = taskInfoEntity;

            init();
        }

        private void init ()
        {
            this.backBtn.Click += GetBack;
            this.upBtn.Click += GetUp;
        }

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
                taskInfoEntity.taskName = taskNameWaterTextBox.Text;
                taskInfoEntity.taskGroup = taskGroupComboBox.Text;
                taskInfoEntity.taskRemarks = taskRemarksWaterTextBox.Text;
            }
            catch (Exception)
            {
                MessageBox.Show("信息填写有误！");
            }

            tabControl.SelectedIndex = ++tabControl.SelectedIndex;
        }


    }
}
