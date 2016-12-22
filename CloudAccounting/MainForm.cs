using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CloudAccounting
{
    public partial class MainForm : Form
    {
        public Panel MainPanel
        {
            get { return this.p_MainPanel; }
        }
        public MainForm()
        {
            InitializeComponent();
            Global.Prj = new Project();
            Global.Prj.Form = this;
        }
        
        private void addProductToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Global.Prj.ChangeUI(Project.UserInterfaceEnum.Add_Product);
        }
    }
}
