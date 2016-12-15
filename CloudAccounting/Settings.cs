using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FirebaseSharp;
using FirebaseSharp.Portable;

namespace CloudAccounting
{
    public class Settings
    {
        public FirebaseApp App;
        public Settings()
        {
            this.App = new FirebaseApp(new Uri("https://cloud-accounting-55885.firebaseio.com/"));
        }
    }
}
