using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;

namespace CloudAccounting
{
    public class Product
    {
        public string id;
        public string Barcode
        {
            get { return this.GetCloudValue("Barcode").ToString(); }
            set { this.SetCloudValue("Barcode",value); }
        }
        public string Name
        {
            get { return this.GetCloudValue("Name").ToString(); }
            set { this.SetCloudValue("Name", value); }
        }
        public string Type
        {
            get { return this.GetCloudValue("Type").ToString(); }
            set { this.SetCloudValue("Type", value); }
        }
        public double PriceWithoutTax
        {
            get { return this.GetCloudValue("PriceWithoutTax").ToDouble(); }
            set { this.SetCloudValue("PriceWithoutTax", value.ToString()); }
        }
        public double TaxPercent
        {
            get { return this.GetCloudValue("TaxPercent").ToDouble(); }
            set { this.SetCloudValue("TaxPercent", value.ToString()); }
        }
        public double PriceWithTax
        {
            get { return this.GetCloudValue("PriceWithTax").ToDouble(); }
            set { this.SetCloudValue("PriceWithTax", value.ToString()); }
        }
        public Product(string _id = null)
        {
            this.id = (_id == null) ? Global.CreateUniqueID() : _id;
        }
        private string GetCloudValue(string propName)
        {
            return Project.Cloud.Value["Products"][this.id][propName].ToString();
        }
        private void SetCloudValue(string propName,string value)
        {
            Project.Cloud.Value["Products"][this.id][propName] = value;
        }
    }
}
