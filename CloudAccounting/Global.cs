using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CloudAccounting
{
    public static class Global
    {
        public static Project Prj;
        public static string CreateUniqueID()
        {
            string id = "";
            char[] chList = "aeiosrklmd".ToCharArray();
            DateTime now = DateTime.Now;
            long ticks = (now.Ticks - 621355968000000000);
            char[] tickArr = ticks.ToString().ToCharArray();
            foreach (char t in tickArr) id += chList[Convert.ToInt32(t.ToString())].ToString();
            return id;
        }
        public static string ToTimestamp(this DateTime datet)
        {
            return (DateTime.Now.Ticks - 621355968000000000).ToString();
        }
        public static double ToDouble(this string str)
        {
            return Convert.ToDouble(str);
        }

    }
}
