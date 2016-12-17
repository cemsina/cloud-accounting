using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;
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
