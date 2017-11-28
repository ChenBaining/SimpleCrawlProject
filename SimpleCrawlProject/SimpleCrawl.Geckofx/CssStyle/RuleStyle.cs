using Gecko;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleCrawl.Geckofx.CssStyle
{
    class RuleStyle
    {
        /// <summary>
        /// 注入CSS样式方法
        /// </summary>
        /// <param name="doc"></param>
        public void InjectCss (GeckoWebBrowser geckoWebBrowser)
        {
            var css = geckoWebBrowser.Document.CreateHtmlElement("style");
            css.InnerHtml = @".firefinder-match-red {outline: 2px dashed #f00 !important;}  .firefinder-match-blue {outline: 2px dashed #00f !important;} ";
            geckoWebBrowser.Document.Head.AppendChild(css);
        }

        public void InjectCssHover (GeckoWebBrowser geckoWebBrowser)
        {
            var css = geckoWebBrowser.Document.CreateHtmlElement("style");
            css.InnerHtml = @" .focusHover{background-color:#5ad5f5;} ";
            geckoWebBrowser.Document.Head.AppendChild(css);
        }

        public void InAutoCssHover (GeckoWebBrowser geckoWebBrowser)
        {
            var css = geckoWebBrowser.Document.CreateHtmlElement("style");
            css.InnerHtml = @"a:hover {background-color:#5ad5f5;}
                              display:block;";
                                                                  
            geckoWebBrowser.Document.Head.AppendChild(css);
        }

        /// <summary>
        /// 添加样式  
        /// </summary>
        /// <param name="className">Css样式名称</param>
        /// <param name="element">需要添加样式的元素</param>
        public void AddClass (string className , params GeckoElement[] element)
        {
            if (element != null && element.Length > 0)
            {
                element.All(x =>
                {
                    if (x == null)
                        return true;
                    var cls = x.GetAttribute("class");
                    cls += " " + className;
                    x.SetAttribute("class" , cls);
                    return true;
                });
            }
        }

        /// <summary>  
        /// 移除样式  
        /// </summary>  
        /// <param name="className">Css样式名称</param>
        /// <param name="element">需要去除样式的元素</param>
        public void RemoveClass (string className , params GeckoElement[] element)
        {
            if (element != null && element.Length > 0)
            {
                element.All(x =>
                {
                    if (x == null)
                        return true;
                    var cls = x.GetAttribute("class");
                    if (!string.IsNullOrWhiteSpace(cls))
                    {
                        cls = cls.Replace(className , "").Trim();
                        x.SetAttribute("class" , cls);
                    }
                    return true;
                });
            }
        }
    }
}
