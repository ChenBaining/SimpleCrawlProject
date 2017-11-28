using SimpleCrawl.Data.Auxiliary;
using SimpleCrawl.Data.Enumeration;
using SimpleCrawlApp.SimpleModel1;
using SimpleCrawlApp.Webbrower;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimpleCrawlApp
{
    static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main ()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            //TaskInfoEntity taskInfoEntity = new TaskInfoEntity();
            //taskInfoEntity.taskURL = "https://www.baidu.com/";
            //Application.Run(new GeckofxWebbrowerFrm(taskInfoEntity , new  DataGridView() , GeckofxWebbrowerType.General ));

            Application.Run(new SimpleCrawlFrm());
        }
    }
}
