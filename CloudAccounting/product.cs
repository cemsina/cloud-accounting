using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CloudAccounting
{
    public class Product
    {
        public string id;
        public string Barcode;
        public string Name;
        public CloudObject CObj;
        public string Type;
        private double p_PriceWithoutTax;
        public double PriceWithoutTax
        {
            get { return p_PriceWithoutTax; }
            set { p_PriceWithoutTax = value; p_PriceWithTax = value + value * this.TaxPercent; }
        }
        public double TaxPercent;
        private double p_PriceWithTax;
        public double PriceWithTax
        {
            get { return p_PriceWithTax; }
            set { p_PriceWithTax = value; p_PriceWithoutTax = value * 100 / (100 + TaxPercent); }
        }
        public Product(string _id = null)
        {
            this.id = (_id == null) ? Global.CreateUniqueID() : _id;
        }
    }
}
