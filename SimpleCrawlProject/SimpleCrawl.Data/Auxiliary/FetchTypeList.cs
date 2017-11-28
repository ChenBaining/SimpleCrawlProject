using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleCrawl.Data.Auxiliary
{
    public class FetchTypeList
    {
        public static string[] fetchType =
            new string[]
            {
                "抓取文本" ,
                "抓取详情页链接",
                "抓取附件信息",
                "抓取这个元素的InnerHtml(当前元素的内部网页源代码、带格式的文本和图片)",
                "抓取这个元素的OuterHtml(当前元素的内部网页源代码、带格式的文本和图片)"
            };

        public static string[] fieldType = 
            new string[]
            {
                "标题",
                "副标题",
                "正文",
                "附件信息",
                "时间",
                "作者",
                "名称",
                "价格",
                "地址",
                "电话",
                "邮箱",
                "网址",
                "采集时间",
                "图片地址"
            };




    }


     
}
