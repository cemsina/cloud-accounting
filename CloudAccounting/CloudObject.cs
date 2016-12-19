using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FirebaseSharp.Portable;
using System.Diagnostics;
using Newtonsoft.Json.Linq;
namespace CloudAccounting
{
    public class CloudObject
    {
        public string Path;
        public CloudObject Parent;
        public JObject Value;
        private IFirebase Ref
        {
            get { return Global.Prj.settings.App.Child(this.Path); }
            set { }
        }
        public CloudObject(string path)
        {
            this.Path = path;
        }
        public void GetValue()
        {
            this.Ref.On("value", (snapshot, child, context) => {
                this.Value = JObject.Parse(snapshot.Value());
                Debug.WriteLine("Veri geldi");
            });
        }
        public void Set(string content)
        {
            Ref.Set(content);
        }
    }
}
