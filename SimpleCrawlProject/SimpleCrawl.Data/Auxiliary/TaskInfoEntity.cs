using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimpleCrawl.Data.Auxiliary
{
    public class TaskInfoEntity
    {
        public string taskName { get; set; } //任务名称

        public string taskGroup { get; set; } //任务分组

        public string taskRemarks { get; set; } // 任务备注

        public string taskURL { get; set; }

        public URLEntity urlListEntity = new URLEntity();

        
    }


    public class URLEntity
    {
        public DataGridView UrlDataSource;   //详情页链接

        public DataGridView DetailsDataSource;   //详情页中的规则
    }
}
