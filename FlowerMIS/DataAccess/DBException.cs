using System;
using System.Collections.Generic;
using System.Text;

namespace FlowerMIS.DataAccess
{
    public class DBException:Exception
    {
        public DBException(Exception innerException)
            : base("不能访问数据库", innerException)
        {
        }
    }
}
