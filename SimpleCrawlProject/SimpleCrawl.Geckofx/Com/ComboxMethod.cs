using Gecko;
using SimpleCrawl.Data.Enumeration;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimpleCrawl.Geckofx.Com
{
    public class ComboxMethod
    {
        private DataGridView dgv;
        private ComboxSelectChangeType comboxSelectChangeType;

        public ComboxMethod (DataGridView dgv , ComboxSelectChangeType comboxSelectChangeType)
        {
            this.dgv = dgv;
            this.comboxSelectChangeType = comboxSelectChangeType;
        }

        #region 设置下拉事件
        public void ComboBox_SelectedIndexChanged (object sender , EventArgs e)
        {
            ComboBox combox = sender as ComboBox;
            //这里比较重要
            combox.Leave += new EventHandler(combox_Leave);
            try
            {
                //在这里就可以做值是否改变判断
                if (combox.SelectedItem != null)
                {
                    GeckoHtmlElement element = (GeckoHtmlElement)dgv.CurrentRow.Cells["VisibleGeckofxElement"].Value;
                    string name = (string)combox.SelectedItem;

                    if (comboxSelectChangeType.Equals(ComboxSelectChangeType.Fetch))
                    {
                        if (name.Equals("抓取文本"))
                        {
                            dgv.CurrentRow.Cells["FieldsContent"].Value = element.TextContent;
                        }
                        else if (name.Contains("InnerHtml"))  //抓取这个元素的InnerHtml(当前元素的内部网页源代码、带格式的文本和图片)
                        {
                            dgv.CurrentRow.Cells["FieldsContent"].Value = element.InnerHtml;
                        }
                        else if (name.Contains("OuterHtml"))  //抓取这个元素的OuterHtml(当前元素的内部网页源代码、带格式的文本和图片)
                        {
                            dgv.CurrentRow.Cells["FieldsContent"].Value = element.OuterHtml;
                        }
                        else if (name.Equals("抓取详情页链接")) 
                        {
                            string url = GeckofxConverInfo.GetUrlByElement(element);
                            if (string.IsNullOrEmpty(url))
                            {
                                MessageBox.Show("所选的元素中没有链接存在，默认选择抓取文本！");
                                return;
                            }
                            else
                            {
                                dgv.CurrentRow.Cells["FieldsContent"].Value = url;
                            }
                        }
                        else if (name.Equals("抓取附件信息"))
                        {
                            string url = GeckofxConverInfo.GetUrlByElementParent(element);
                            if (string.IsNullOrEmpty(url))
                            {
                                MessageBox.Show("所选的元素中没有附件链接，默认选择抓取文本！");
                                return;
                            }
                            else
                            {
                                dgv.CurrentRow.Cells["FieldsContent"].Value = url;
                            }
                        }

                    }
                    
                }
                Thread.Sleep(100);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        /// <summary>
        /// 离开combox时，把事件删除
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void combox_Leave (object sender , EventArgs e)
        {
            ComboBox combox = sender as ComboBox;
            //做完处理，须撤销动态事件
            combox.SelectedIndexChanged -= new EventHandler(ComboBox_SelectedIndexChanged);
        }
        #endregion
    }
}
