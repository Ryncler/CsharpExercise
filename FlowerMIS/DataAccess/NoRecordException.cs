using System;
using System.Collections.Generic;
using System.Text;

namespace FlowerMIS.DataAccess
{
    public class NoRecordException:Exception
    {
        public NoRecordException(string message)
            : base(message)
        {
        }
        public NoRecordException()
            : base("û��������¼")
        {
        }
    }
}