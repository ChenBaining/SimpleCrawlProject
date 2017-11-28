using Gecko;
using Gecko.DOM;
using SimpleCrawl.Data.Auxiliary;
using SimpleCrawl.Data.Enumeration;
using SimpleCrawl.Geckofx.CssStyle;
using SimpleCrawl.Geckofx.Xpath;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;


namespace SimpleCrawl.Geckofx
{
    public class GeckofxWebbrower
    {
        private GeckoWebBrowser geckoWebBrowser;  //浏览器组件
        private TaskInfoEntity taskInfoEntity;   //定义规则的对象
        private Control control;    //获取控件
        private bool _load = false;   //判断页面是否加载过样式和JS
        private RuleStyle ruleStyle;    //引入样式库
        private XpathHelper xpathHelper;   //引入xpath规则库
        private int count = 1;
        private DataGridView dgv;   //引入下一页datagridview
        private GeckofxWebbrowerType geckofxType;   //枚举，约定浏览器采用何种模式
        private string URL;   //要执行的URL链接


        //通用
        public GeckofxWebbrower (Control control , DataGridView dgv , TaskInfoEntity taskInfoEntity , GeckofxWebbrowerType geckofxType , string URL)
        {
            //GeckoPreferences.User["gfx.font_rendering.graphite.enabled"] = false;
            geckoWebBrowser = new GeckoWebBrowser();
            geckoWebBrowser.Parent = control;
            geckoWebBrowser.Dock = DockStyle.Fill;

            this.taskInfoEntity = taskInfoEntity;
            this.control = control;
            this.dgv = dgv;
            this.geckofxType = geckofxType;   // 浏览类型
            ruleStyle = new RuleStyle();
            xpathHelper = new XpathHelper();
            this.URL = URL;

            init();
        }

        #region 初始化方法
        public void init()
        {
            if (string.IsNullOrEmpty(URL))
            {
                geckoWebBrowser.Navigate(taskInfoEntity.taskURL);  //地址taskInfoEntity.taskURL
            }
            else
            {
                geckoWebBrowser.Navigate(URL);  //地址taskInfoEntity.taskURL
            }    

            //事件
            geckoWebBrowser.Load += On_Load;  //加载中事件
            geckoWebBrowser.DomClick += On_DomClick;//元素单击事件
            //geckoWebBrowser.DomDoubleClick += On_DomDoubleClick;//元素双击事件

            //geckoWebBrowser.DomMouseMove += On_MouseMove;
            //geckoWebBrowser.DomMouseOut += On_MouseOut;

            geckoWebBrowser.DocumentCompleted += On_DocumentCompleted;  //浏览器渲染完成事件 
        }
        #endregion

        #region 浏览器加载事件
        /// <summary>
        /// 浏览器加载事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void On_Load (object sender , EventArgs e)
        {
            if (!_load)
            {
                ruleStyle.InjectCss(geckoWebBrowser);
                //ruleStyle.InjectCssHover(geckoWebBrowser);
                ruleStyle.InAutoCssHover(geckoWebBrowser);
            }
            if (!_load)
                _load = true;
        }
        #endregion

        #region 鼠标移动到元素上执行的事件
        /// <summary>
        /// 鼠标移动到元素上执行的事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void On_MouseMove (object sender , DomMouseEventArgs e)
        {
            var ele = e.CurrentTarget.CastToGeckoElement();
            ele = e.Target.CastToGeckoElement();

            var cls = ele.GetAttribute("class");

            if (!cls.Contains("focusHover"))
            {
                cls += " " + "focusHover";
                ele.SetAttribute("class" , cls);
            }
        }
        #endregion

        #region 鼠标移走的事件
        /// <summary>
        /// 鼠标移走的事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void On_MouseOut (object sender , DomMouseEventArgs e)
        {
            var ele = e.CurrentTarget.CastToGeckoElement();
            ele = e.Target.CastToGeckoElement();


            var cls = ele.GetAttribute("class");
            if (!string.IsNullOrWhiteSpace(cls))
            {
                cls = cls.Replace("focusHover" , "").Trim();
                ele.SetAttribute("class" , cls);
            }
        }
        #endregion

        #region Dom单击事件
        /// <summary>
        /// Dom单击事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void On_DomClick (object sender , DomMouseEventArgs e)
        {
            //屏蔽页面点击事件
            e.PreventDefault();
            e.StopPropagation();

            var ele = e.CurrentTarget.CastToGeckoElement();
            ele = e.Target.CastToGeckoElement();
            GeckoHtmlElement geckoHtmlElement = (GeckoHtmlElement)ele;
            string searchElement = geckoHtmlElement.OuterHtml;

            if (!searchElement.Contains("firefinder-match-red"))
            {
                //在datagridview中显示选中行的内容
                GeckoHtmlElement[] geckoHtmlEle = new GeckoHtmlElement[1];
                geckoHtmlEle[0] = geckoHtmlElement;

                if (geckofxType.Equals(GeckofxWebbrowerType.General))
                {
                    InsertDataGridRow(dgv , geckoWebBrowser , geckoHtmlEle);
                }
                else if (geckofxType.Equals(GeckofxWebbrowerType.ListDetails))
                {
                    InsertDataGridRow(dgv , geckoWebBrowser , geckoHtmlEle);
                }
                else if (geckofxType.Equals(GeckofxWebbrowerType.UrlModel))
                {
                    try
                    {
                        GeckoAnchorElement d = (GeckoAnchorElement)geckoHtmlElement;
                        string URL = d.Href;

                        InsertDataGridRow(GeckofxWebbrowerType.UrlModel , dgv , geckoWebBrowser , geckoHtmlEle);
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("请获取链接！");
                        return;
                    }
                }

                ruleStyle.AddClass("firefinder-match-red" , ele);
            }
            else
            {
                //在浏览器中标记红圈
                ruleStyle.RemoveClass("firefinder-match-red" , ele);
            }




        }
        #endregion

        #region Dom双击事件
        /// <summary>
        /// Dom双击事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void On_DomDoubleClick (object sender , DomMouseEventArgs e)
        {
            //屏蔽页面点击事件
            e.PreventDefault();
            e.StopPropagation();

            var ele = e.CurrentTarget.CastToGeckoElement();
            ele = e.Target.CastToGeckoElement();
            GeckoHtmlElement geckoHtmlElement = (GeckoHtmlElement)ele;

            //短xpath  
            var xpath1 = xpathHelper.GetSmallXpath(ele);
            //var xpath2 = xpathHelper.GetXpath(ele);
            if (xpath1.Contains("tr"))
            {
                string demo = xpath1.Substring(xpath1.IndexOf("tr"));
                try
                {
                    demo = demo.Substring(0 , demo.IndexOf("/"));
                }
                catch (Exception)
                {
                }
                xpath1 = xpath1.Replace(demo , "tr");
            }
            else if (xpath1.Contains("li"))
            {
                string demo = xpath1.Substring(xpath1.IndexOf("li"));
                try
                {
                    demo = demo.Substring(0 , demo.IndexOf("/"));
                }
                catch (Exception)
                {
                }
                xpath1 = xpath1.Replace(demo , "li");
            }

            if (string.IsNullOrWhiteSpace(xpath1))
                return;
            var xresult = geckoWebBrowser.DomDocument.EvaluateXPath(xpath1);
            var nodes = xresult.GetNodes();
            var elements = nodes.Select(x => x as GeckoElement).ToArray();


            if (geckofxType.Equals(GeckofxWebbrowerType.General))
            {

            }
            else if (geckofxType.Equals(GeckofxWebbrowerType.ListDetails))
            {

            }
            else if (geckofxType.Equals(GeckofxWebbrowerType.UrlModel))
            {
                foreach (var item in elements)
                {
                    try
                    {
                        GeckoAnchorElement d = (GeckoAnchorElement)geckoHtmlElement;
                        string URL = d.Href;
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("链接列表有问题，请检查！");
                        return;
                    }

                }
            }

            ruleStyle.AddClass("firefinder-match-red" , elements);
            InsertDataGridRow(GeckofxWebbrowerType.UrlModel , dgv , geckoWebBrowser , elements);

        }
        #endregion

        #region 加载完成执行的事件
        public void On_DocumentCompleted (object sender , EventArgs e)
        {

            GeckoWebBrowser br = sender as GeckoWebBrowser;
            if (br.Url.ToString() == "about:blank")
            { return; }


          

        }
        #endregion

        #region DataGridView数据区
        public void InsertDataGridRow (DataGridView dgv , GeckoWebBrowser geckoWebBrowser , params GeckoElement[] ele)
        {
            List<GeckoHtmlElement> geckoHtmlElementList = null;
            //设置xpath 获取html信息
            if (ele.Length == 1)
            {
                var xpathTxt = xpathHelper.GetSmallXpath(ele[0]);
                var xresult = geckoWebBrowser.DomDocument.EvaluateXPath(xpathTxt);
                var nodes = xresult.GetNodes();
                var elements = nodes.Select(x => x as GeckoElement).ToArray();
                //foreach (GeckoElement item in elements)
                //{
                //    geckoElementList.Add(item);
                //}
                geckoHtmlElementList = XpathHelper.FindHtmlTxt(true , elements);
            }
            else
            {
                //foreach (GeckoElement item in ele)
                //{
                //    geckoElementList.Add(item);
                //}

                geckoHtmlElementList = XpathHelper.FindHtmlTxt(true , ele);
            }

            foreach (GeckoHtmlElement element in geckoHtmlElementList)
            {
                //if (dgv.Rows.Count > 1)
                //{
                //    for (int i = 0 ; i < dgv.Rows.Count ; i++)
                //    {
                //        GeckoHtmlElement ghe = (GeckoHtmlElement)dgv.Rows[i].Cells[dgv.Rows[0].Cells.Count - 1].Value;
                //        if (ghe.Equals(element))
                //        {
                //            continue;
                //        }
                //    }
                //}


                DataGridViewRow row = new DataGridViewRow();
                //文本
                DataGridViewTextBoxCell fieldsNameCell = new DataGridViewTextBoxCell();
                fieldsNameCell.Value = "字段" + ( count++ );
                row.Cells.Add(fieldsNameCell);

                DataGridViewTextBoxCell fieldsContentCell = new DataGridViewTextBoxCell();
                fieldsContentCell.Value = element.TextContent;
                row.Cells.Add(fieldsContentCell);

                //下拉框
                DataGridViewTextBoxCell fieldsTypeCell = new DataGridViewTextBoxCell();
                fieldsTypeCell.Value = "抓取文本";
                row.Cells.Add(fieldsTypeCell);
                
                DataGridViewImageCell deleteCell = new DataGridViewImageCell();
                deleteCell.Value = Image.FromFile(@"E:\Project\C#\SimpleCrawlProject\SimpleCrawlApp\Resources\1108658.png");
                row.Cells.Add(deleteCell);

                //隐藏浏览器句柄
                DataGridViewTextBoxCell visibleGeckofxElementCell = new DataGridViewTextBoxCell();
                visibleGeckofxElementCell.Value = element;
                row.Cells.Add(visibleGeckofxElementCell);

                //隐藏xpath
                DataGridViewTextBoxCell visibleGeckofxXpathCell = new DataGridViewTextBoxCell();
                visibleGeckofxXpathCell.Value = xpathHelper.GetSmallXpath(element);
                row.Cells.Add(visibleGeckofxXpathCell);

                //将元素插入datagridview控件中
                dgv.Rows.Add(row);
            }
        }

        public void InsertDataGridRow (GeckofxWebbrowerType geckofxWebbrowerType , DataGridView dgv , GeckoWebBrowser geckoWebBrowser , params GeckoElement[] ele)
        {
            List<GeckoHtmlElement> geckoHtmlElementList = null;
            //设置xpath 获取html信息
            if (ele.Length == 1)
            {
                var xpathTxt = xpathHelper.GetSmallXpath(ele[0]);
                var xresult = geckoWebBrowser.DomDocument.EvaluateXPath(xpathTxt);
                var nodes = xresult.GetNodes();
                var elements = nodes.Select(x => x as GeckoElement).ToArray();
                geckoHtmlElementList = XpathHelper.FindHtmlTxt(true , elements);
            }
            else
            {
                geckoHtmlElementList = XpathHelper.FindHtmlTxt(true , ele);
            }

            if (geckofxWebbrowerType.Equals(GeckofxWebbrowerType.General))
            {
                foreach (GeckoHtmlElement element in geckoHtmlElementList)
                {
                    DataGridViewRow row = new DataGridViewRow();
                    //文本
                    DataGridViewTextBoxCell fieldsNameCell = new DataGridViewTextBoxCell();
                    fieldsNameCell.Value = "字段" + ( count++ );
                    row.Cells.Add(fieldsNameCell);

                    DataGridViewTextBoxCell fieldsContentCell = new DataGridViewTextBoxCell();
                    fieldsContentCell.Value = element.TextContent;
                    row.Cells.Add(fieldsContentCell);

                    //下拉框
                    DataGridViewTextBoxCell fieldsTypeCell = new DataGridViewTextBoxCell();
                    fieldsTypeCell.Value = "抓取文本";
                    row.Cells.Add(fieldsTypeCell);

                    DataGridViewImageCell deleteCell = new DataGridViewImageCell();
                    deleteCell.Value = Image.FromFile(@"E:\Project\C#\SimpleCrawlProject\SimpleCrawlApp\Resources\1108658.png");
                    row.Cells.Add(deleteCell);

                    //隐藏浏览器句柄
                    DataGridViewTextBoxCell visibleGeckofxElementCell = new DataGridViewTextBoxCell();
                    visibleGeckofxElementCell.Value = element;
                    row.Cells.Add(visibleGeckofxElementCell);

                    //隐藏xpath
                    DataGridViewTextBoxCell visibleGeckofxXpathCell = new DataGridViewTextBoxCell();
                    visibleGeckofxXpathCell.Value = xpathHelper.GetSmallXpath(element);
                    row.Cells.Add(visibleGeckofxXpathCell);

                    //将元素插入datagridview控件中
                    dgv.Rows.Add(row);
                }
            }
            else if (geckofxWebbrowerType.Equals(GeckofxWebbrowerType.ListDetails))
            {

            }
            else if (geckofxWebbrowerType.Equals(GeckofxWebbrowerType.UrlModel))
            {
                foreach (GeckoHtmlElement element in geckoHtmlElementList)
                {
                    DataGridViewRow row = new DataGridViewRow();
                    //文本
                    DataGridViewTextBoxCell fieldsNameCell = new DataGridViewTextBoxCell();
                    fieldsNameCell.Value = "字段" + ( count++ );
                    row.Cells.Add(fieldsNameCell);

                    DataGridViewTextBoxCell fieldsContentCell = new DataGridViewTextBoxCell();
                    fieldsContentCell.Value = element.TextContent;
                    row.Cells.Add(fieldsContentCell);

                    //下拉框
                    DataGridViewTextBoxCell fieldsTypeCell = new DataGridViewTextBoxCell();
                    fieldsTypeCell.Value = "抓取详情页链接";
                    row.Cells.Add(fieldsTypeCell);

                    DataGridViewImageCell deleteCell = new DataGridViewImageCell();
                    deleteCell.Value = Image.FromFile(@"E:\Project\C#\SimpleCrawlProject\SimpleCrawlApp\Resources\1108658.png");
                    row.Cells.Add(deleteCell);

                    //隐藏浏览器句柄
                    DataGridViewTextBoxCell visibleGeckofxElementCell = new DataGridViewTextBoxCell();
                    visibleGeckofxElementCell.Value = element;
                    row.Cells.Add(visibleGeckofxElementCell);

                    //隐藏xpath
                    DataGridViewTextBoxCell visibleGeckofxXpathCell = new DataGridViewTextBoxCell();
                    visibleGeckofxXpathCell.Value = xpathHelper.GetSmallXpath(element);
                    row.Cells.Add(visibleGeckofxXpathCell);

                    //将元素插入datagridview控件中
                    dgv.Rows.Add(row);
                }
            }

        }

        #endregion

    }
}
