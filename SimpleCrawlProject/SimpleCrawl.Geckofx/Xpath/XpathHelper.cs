using Gecko;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleCrawl.Geckofx.Xpath
{
    public class XpathHelper
    {
        /// <summary>
        /// 获取短 xpath
        /// </summary>
        /// <param name="node"></param>
        /// <returns></returns>
        public string GetSmallXpath (GeckoNode node)
        {
            if (node == null)
                return "";
            if (node.NodeType == NodeType.Attribute)
            {
                return String.Format("{0}/@{1}" , GetSmallXpath(( (GeckoAttribute)node ).OwnerDocument) , node.LocalName);
            }
            if (node.ParentNode == null)
            {
                return "";
            }
            string elementId = ( (GeckoHtmlElement)node ).Id;
            if (!String.IsNullOrEmpty(elementId))
            {
                return String.Format("//*[@id=\"{0}\"]" , elementId);
            }
            int indexInParent = 1;
            GeckoNode siblingNode = node.PreviousSibling;
            while (siblingNode != null)
            {
                if (siblingNode.LocalName == node.LocalName)
                {
                    indexInParent++;
                }
                siblingNode = siblingNode.PreviousSibling;
            }
            return String.Format("{0}/{1}[{2}]" , GetSmallXpath(node.ParentNode) , node.LocalName , indexInParent);
        }

        /// <summary>
        /// 获取长xpath
        /// </summary>
        /// <param name="node"></param>
        /// <returns></returns>
        public string GetXpath (GeckoNode node)
        {
            if (node == null)
                return "";
            if (node.NodeType == NodeType.Attribute)
            {
                return String.Format("{0}/@{1}" , GetXpath(( (GeckoAttribute)node ).OwnerDocument) , node.LocalName);
            }
            if (node.ParentNode == null)
            {
                return "";
            }
            int indexInParent = 1;
            GeckoNode siblingNode = node.PreviousSibling;
            while (siblingNode != null)
            {
                if (siblingNode.LocalName == node.LocalName)
                {
                    indexInParent++;
                }
                siblingNode = siblingNode.PreviousSibling;
            }
            return String.Format("{0}/{1}[{2}]" , GetXpath(node.ParentNode) , node.LocalName , indexInParent);
        }


        /// <summary>
        /// 获得元素的 HTML 信息   精确获取，只能获取一条
        /// </summary>
        /// <param name="IsLike">是否是模糊查询</param>
        /// <param name="nodes">传入参数</param>
        /// <returns></returns>
        public static List<GeckoHtmlElement> FindHtmlTxt (bool IsLike , params GeckoElement[] nodes)
        {
            List<GeckoHtmlElement> geckoHtmlElementList = null;

            if (nodes == null)
            {
                return geckoHtmlElementList;
            }
            geckoHtmlElementList = new List<GeckoHtmlElement>();
            nodes.All(x =>
            {
                geckoHtmlElementList.Add(( x as GeckoHtmlElement ));
                return IsLike;
            });
            return geckoHtmlElementList;
        }
    }
}
