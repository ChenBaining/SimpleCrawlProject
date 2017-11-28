using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimpleCrawlApp.SimpleModelTool
{
    public partial class MenuFrm : Form
    {
        private Form form;

        public MenuFrm (Form form)
        {
            InitializeComponent();
            this.form = form;
            init();
        }


        private void init ()
        {
            form.FormBorderStyle = FormBorderStyle.None;
            form.TopLevel = false;   //这个必须有不然会提示:"不能向tabControl中添加顶级控件"        
            form.Dock = DockStyle.Fill;
            form.Show();//这个必须有，不然显示不出来 
            menuPanel.Controls.Add(form);

        }



    }
}
