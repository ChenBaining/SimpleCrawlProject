using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleCrawl.Data.Enumeration
{
    public enum GeckofxWebbrowerType
    {
        General,    //通用模式 ，标准模式
        ListDetails,  //链表详细模式  此模式规定浏览器只返回URL地址
        UrlModel       //获取URL地址模式
    }
}
