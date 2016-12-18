using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;
using System.Security.Cryptography;
namespace CloudAccounting
{
    public class User
    {
        public string id;
        public string Name
        {
            get { return this.GetCloudValue("Name"); }
            set { this.SetCloudValue("Name", value); }
        }
        public string Surname
        {
            get { return this.GetCloudValue("Surname"); }
            set { this.SetCloudValue("Surname", value); }
        }
        public string Username
        {
            get { return this.GetCloudValue("Username"); }
            set { this.SetCloudValue("Username", value); }
        }
        public string Password
        {
            get { return this.GetCloudValue("Password"); }            
            set { this.SetCloudValue("Password", Md5password(value)); }
        }
        public static string Md5password (string original)
        {
            MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider();
            byte[] btr = Encoding.UTF8.GetBytes(original);
            btr = md5.ComputeHash(btr);
            StringBuilder sb = new StringBuilder();
            foreach (byte ba in btr)
            {
                sb.Append(ba.ToString("x2").ToLower());
            }
            return sb.ToString();
        }
        private string GetCloudValue(string propName)
        {
            return Project.Cloud.Value["Users"][this.id][propName].ToString();
        }
        private void SetCloudValue(string propName, string value)
        {
            Project.Cloud.Value["Users"][this.id][propName] = value;
        }

    }
}
