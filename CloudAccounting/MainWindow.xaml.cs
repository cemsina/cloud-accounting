using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Diagnostics;
using Newtonsoft.Json.Linq;

namespace CloudAccounting
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            Project.settings = new Settings();
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            Product p = new Product("testid");
            textname.Text = p.Name;
            texttype.Text = p.Type;
            textbar.Text = p.Barcode;
            texttax.Text = p.TaxPercent.ToString();
            textpw.Text = p.PriceWithoutTax.ToString();
            textpwt.Text = p.PriceWithTax.ToString();
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            Project.Cloud.GetValue();
        }
    }
}
