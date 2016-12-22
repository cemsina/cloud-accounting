using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace CloudAccounting
{
    public class Project
    {
        public bool DataIsChanged;
        public Settings settings;
        public List<Product> ProductList;
        public CloudObject Cloud;
        public MainForm Form;
        public Project()
        {
            this.settings = new Settings();
            this.Cloud = new CloudObject("");
        }
        public void Save()
        {
            string folderpath = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "/CloudAccounting/";
            if (!Directory.Exists(folderpath)) Directory.CreateDirectory(folderpath);
            string path = folderpath + DateTime.Now.ToTimestamp() + ".cloudaccounting";
            if (!File.Exists(path)) File.Create(path).Close();
            File.WriteAllText(path, this.Cloud.Value.ToString());
        }
        public void ChangeUI(UserInterfaceEnum ui)
        {
            switch (ui)
            {
                case UserInterfaceEnum.Add_Product:

                    Global.Prj.Form.MainPanel.Controls.Clear();

                    break;

            }
        }
        public enum UserInterfaceEnum
        {
            Add_Product
        }
    }
}
