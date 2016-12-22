using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CloudAccounting
{
    public partial class UI_Item : UserControl
    {
        public string Key;
        public string Value
        {
            get { return textBox1.Text; }
        }
        public UI_Item(string key)
        {
            InitializeComponent();
            this.Key = key;
            this.label1.Text = key;
        }
    }
}
