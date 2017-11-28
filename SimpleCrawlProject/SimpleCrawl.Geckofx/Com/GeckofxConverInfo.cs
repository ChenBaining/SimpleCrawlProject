using Gecko;
using Gecko.DOM;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleCrawl.Geckofx.Com
{
    public class GeckofxConverInfo
    {
        public static string GetUrlByElement (Object objElement)
        {
            string URL;
            GeckoHtmlElement element = (GeckoHtmlElement)objElement;

            try
            {
                GeckoAnchorElement d = (GeckoAnchorElement)element;
                URL = d.Href;
            }
            catch (Exception)
            {
                URL = null;
            }
            return URL;
        }

        public static string GetUrlByElementParent (Object objElement)
        {
            string URL;
            GeckoHtmlElement element = (GeckoHtmlElement)objElement;
            try
            {
                GeckoAnchorElement d = (GeckoAnchorElement)element.Parent;
                URL = d.Href;
            }
            catch (Exception)
            {
                URL = null;
            }
            return URL;
        }

    }
}
