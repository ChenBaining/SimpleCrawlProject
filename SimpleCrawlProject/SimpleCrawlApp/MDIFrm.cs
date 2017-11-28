using CCWin.SkinControl;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimpleCrawlApp
{
    public partial class MDIFrm : Form
    {
        public MDIFrm ()
        {
            InitializeComponent();
        }
        public static SkinTabControl StaticMdiTabcontrol;

        public SkinTabControl GetTabControl ()
        {
            return this.MdiTabcontrol;
        }

        public void LoadData (List<Form> formList)
        {
            MdiTabcontrol.SizeMode = TabSizeMode.Fixed;
            MdiTabcontrol.ItemSize = new Size(0 , 1);
            MdiTabcontrol.Appearance = TabAppearance.FlatButtons;

            foreach (Form form in formList)
            {
                TabPage tp = new TabPage();
                form.FormBorderStyle = FormBorderStyle.None;
                form.TopLevel = false;   //这个必须有不然会提示:"不能向tabControl中添加顶级控件"        
                form.Dock = DockStyle.Fill;
                form.Show();//这个必须有，不然显示不出来 
                tp.Controls.Add(form);
                MdiTabcontrol.TabPages.Add(tp);
            }
        }

        private void MdiTabcontrol_SelectedIndexChanged(object sender, EventArgs e) {

        }
    }
}
