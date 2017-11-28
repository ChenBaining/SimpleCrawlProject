using CCWin.SkinControl;
using SimpleCrawl.Data.Auxiliary;
using SimpleCrawl.Data.Controls;
using SimpleCrawl.Data.Enumeration;
using SimpleCrawl.Geckofx;
using SimpleCrawl.Geckofx.Com;
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
    public partial class GeckofxFrm : Form
    {
        private DataGridViewEvent dataGridViewEvent;
        private SkinTabControl tabControl;  //获取翻页的控件
        private SkinComboBox comboBox;  //下拉框，选择抓取的类型
        private SkinComboBox fieldsComboBox; //下拉框 字段名称下拉框
        private TaskInfoEntity taskInfoEntity;
        private SplitterPanel splitterPanel;
        private DataGridView dgv;

        public GeckofxFrm (SkinTabControl tabControl , TaskInfoEntity taskInfoEntity)
        {
            InitializeComponent();
            comboBox = new SkinComboBox();
            fieldsComboBox = new SkinComboBox();

            this.tabControl = tabControl;
            this.taskInfoEntity = taskInfoEntity;
            dataGridViewEvent = new DataGridViewEvent();

            init();
        }

        public SplitterPanel GetSplitterPanel ()
        {
            return this.skinSplitContainer1.Panel1;
        }

        public void SetSplitterPanel (SplitterPanel splitterPanel)
        {
            this.splitterPanel = splitterPanel;
        }

        public DataGridView GetDataGridView ()
        {
            return this.dataGridViewData;
        }

        public void SetDataGridView (DataGridView dgv)
        {
            this.dgv = dgv;
        }

        private void init ()
        {
            //GetInitData();
            //初始化DataGridView
            for (int i = 0 ; i < dataGridViewData.ColumnCount ; i++)
            {
                if (i == dataGridViewData.ColumnCount - 1)
                { continue; }
                dataGridViewData.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }
            this.dataGridViewData.Columns[0].FillWeight = 20; //第一列的相对宽度为8%
            this.dataGridViewData.Columns[1].FillWeight = 60; //第一列的相对宽度为22%
            this.dataGridViewData.Columns[2].FillWeight = 18; //第一列的相对宽度为70%
            this.dataGridViewData.Columns[3].FillWeight = 2; //第一列的相对宽度为70%

            //初始化ComboBox
            ComboBoxEvent comboBoxEvent = new ComboBoxEvent(2 , dataGridViewData , comboBox ,true ,true);
            comboBox.Visible = false;
            comboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox.Items.AddRange(FetchTypeList.fetchType);
            comboBox.AutoCompleteSource = AutoCompleteSource.ListItems;
            comboBox.DropDown += comboBoxEvent.AutoSizeComboBoxItem;
            comboBox.SelectedIndex = 0;
            comboBox.SelectedItem = comboBox.Items[0];
            ComboxMethod comboxMethod = new ComboxMethod(dataGridViewData , ComboxSelectChangeType.Fetch);
            comboBoxEvent.SelectedIndexChanged += comboxMethod.ComboBox_SelectedIndexChanged;   //下拉框选择改变事件
            this.dataGridViewData.CellEnter += comboBoxEvent.dataGridView_CellEnter;
            this.dataGridViewData.CellLeave += comboBoxEvent.dataGridView_CellLeave;
            //this.dataGridViewData.CellClick += comboBoxEvent.dataGridView_CellClick;

            ComboBoxEvent fieldsComboBoxEvent = new ComboBoxEvent(0 , dataGridViewData , fieldsComboBox);
            fieldsComboBox.Visible = false;
            fieldsComboBox.DropDownStyle = ComboBoxStyle.DropDown;
            fieldsComboBox.Items.AddRange(FetchTypeList.fieldType);
            fieldsComboBox.AutoCompleteSource = AutoCompleteSource.ListItems;
            fieldsComboBox.DropDown += fieldsComboBoxEvent.AutoSizeComboBoxItem;
            fieldsComboBox.SelectedIndex = 0;
            fieldsComboBox.SelectedItem = fieldsComboBox.Items[0];
            this.dataGridViewData.CellEnter += fieldsComboBoxEvent.dataGridView_CellEnter;
            this.dataGridViewData.CellLeave += fieldsComboBoxEvent.dataGridView_CellLeave;

            //事件
            this.backBtn.Click += GetBack;
            this.upBtn.Click += GetUp;


        }

        #region 上一步下一步
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
                if (dataGridViewData.Rows.Count > 0)
                {
                    taskInfoEntity.urlListEntity.UrlDataSource = dataGridViewData;
                    object elementNode =  dataGridViewData.Rows[0].Cells["VisibleGeckofxElement"].Value;
                    string url = GeckofxConverInfo.GetUrlByElement(elementNode);

                    GeckofxWebbrowerFrm geckofxWebbrowerFrm = new GeckofxWebbrowerFrm(taskInfoEntity , dgv , GeckofxWebbrowerType.General , url);
                    geckofxWebbrowerFrm.FormBorderStyle = FormBorderStyle.None;
                    geckofxWebbrowerFrm.TopLevel = false;   //这个必须有不然会提示:"不能向tabControl中添加顶级控件"        
                    geckofxWebbrowerFrm.Dock = DockStyle.Fill;
                    geckofxWebbrowerFrm.Show();//这个必须有，不然显示不出来  
                    this.splitterPanel.Controls.Add(geckofxWebbrowerFrm);
                }
                else
                {
                    MessageBox.Show("您还没有选择需要抓取详细页的链接地址！");
                    return;
                }

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
