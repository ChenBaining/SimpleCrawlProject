using Miluo.ExtensionTool.IO;
using Miluo.ExtensionTool.Sqlite3;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleCrawl.Data.Sqlite3
{
    public class BaseSqliteInfo
    {
        #region 全局变量
        SqliteHelper sqliteHelper;
        private const string FolderName = "SimpleCrawl";
        private string DataSourcePath = System.Environment.CurrentDirectory + @"\" + FolderName;
        private string fileName = @"\SimpleCrawlData.db";
        private string PASSWORD = "123456";
        #endregion

        public BaseSqliteInfo ()
        {
            sqliteHelper = new SqliteHelper(@"Data Source=" + DataSourcePath + fileName);
        }

        #region 创建数据库
        /// <summary>
        /// 创建数据库
        /// 第二次封装
        /// </summary>
        /// <returns></returns>
        public bool CreateDB (string dataBaseName)
        {
            bool state = true;
            try
            {
                FileHelper.ChekFolderIsExists(DataSourcePath);
                sqliteHelper.CreateEncryptionDB(dataBaseName , sqliteHelper.connStr , PASSWORD);
            }
            catch (Exception ex)
            {
                state = false;
            }
            return state;
        }
        #endregion



        #region 创建数据表
        public void CreateShopTable ()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("drop table if exists user_info; ");  //先清除表
            sb.Append("CREATE TABLE user_info (");  //创建表
            sb.Append("crawl_time         datetime             NOT NULL  ,"); //创建时间
            sb.Append("userName           varchar(50)         NOT NULL  ,");  //帐号
            sb.Append("password           varchar(50)          NOT NULL ,");  //密码
            sb.Append("cookie               varchar(500)          NOT NULL  ");  //Cookie
            sb.Append(")");
            sqliteHelper.ExecuteSqlRetBool(sb.ToString() , PASSWORD);
        }
        #endregion

        #region 插入数据
        /// <summary>
        /// 插入数据到数据库
        /// </summary>
        /// <param name="tmShopEntity">要插入数据库的对象，对象在上一步经过封装</param>
        //public void InsetData (UserInfoEntity userInfoEntity)
        //{
        //    StringBuilder sb = new StringBuilder();
        //    sb.Append("INSERT INTO user_info");
        //    sb.Append("(");
        //    sb.Append("crawl_time,");
        //    sb.Append("userName,");
        //    sb.Append("password,");
        //    sb.Append("cookie");
        //    sb.Append(")");
        //    sb.Append("VALUES");
        //    sb.Append("(");
        //    sb.Append("DATETIME('" + DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") + "')");  //抓取时间
        //    sb.Append(",'");
        //    sb.Append(userInfoEntity.UserName); //店铺ID
        //    sb.Append("','");
        //    sb.Append(userInfoEntity.password);//创建时间
        //    sb.Append("','");
        //    sb.Append(userInfoEntity.cookie);//创建时间
        //    sb.Append("')");
        //    sqliteHelper.ExecuteSqlRetBool(sb.ToString() , PASSWORD);
        //}
        #endregion

        #region 数据总和方法
        //public void CreateDataSource (UserInfoEntity userInfoEntity)
        //{
        //    if (FileHelper.ChekFolderIsExists(DataSourcePath))
        //    {
        //        if (!System.IO.File.Exists(DataSourcePath + fileName))
        //        {
        //            CreateDB();  //创建数据库
        //        }
        //        int result = Convert.ToInt32(sqliteHelper.ExecuteScalar("SELECT COUNT(*)  as CNT FROM sqlite_master where type='table' and name='user_info' " , PASSWORD) != null ? sqliteHelper.ExecuteScalar("SELECT COUNT(*)  as CNT FROM sqlite_master where type='table' and name='user_info' " , PASSWORD) : 0);
        //        if (result != 1)
        //        {
        //            CreateShopTable();  //创建数据库
        //        }
        //        InsetData(userInfoEntity); //插入数据
        //    }
        //}
        #endregion

        #region 修改数据
        public void UpdateData (string userInfoEntity)
        {
            //StringBuilder sb = new StringBuilder();
            //sb.Append("update user_info");
            //sb.Append("set cookie = '" + userInfoEntity.cookie + "'");
            //sb.Append("where userName = '" + userInfoEntity.UserName + "'");
            //sb.Append("and password = '" + userInfoEntity.password + "'");
            //sqliteHelper.ExecuteSqlRetBool(sb.ToString() , PASSWORD);
        }
        #endregion


        #region 查询数据
        public void SearchData ()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("select * from user_info");
            DataSet dataSet = sqliteHelper.ExecDataSet(sb.ToString() , PASSWORD);

            foreach (DataTable dt in dataSet.Tables)
            {
                foreach (DataRow dr in dt.Rows)
                {
                    foreach (DataColumn dc in dt.Columns)
                    {
                        string asdasd = dt.TableName + "-" + dc.ColumnName + "-" + dr[dc] + "\n";  //或得到的具体数据
                    }
                }
            }




        }
        #endregion




    }
}
