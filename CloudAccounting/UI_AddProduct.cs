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
    public partial class UI_AddProduct : UserControl
    {
        public UI_AddProduct()
        {
            InitializeComponent();
            List<UI_Item> Items = new List<UI_Item>();
            Items.Add(new UI_Item("Barcode"));
            Items.Add(new UI_Item("Name"));
            Items.Add(new UI_Item("Type"));
            Items.Add(new UI_Item("PriceWithoutTax"));
            Items.Add(new UI_Item("TaxPercent"));
            Items.Add(new UI_Item("PriceWithTax"));
        }
        
    }
}
