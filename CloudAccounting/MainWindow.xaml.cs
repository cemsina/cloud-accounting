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
            Product p = new Product();
            p.Name = textname.Text;
            p.Type = texttype.Text;
            p.Barcode = textbar.Text;
            p.TaxPercent = texttax.Text.ToDouble();
            p.PriceWithoutTax = textpw.Text.ToDouble();
            p.PriceWithTax = textpwt.Text.ToDouble();
            Project.ProductList.Add(p);
        }
    }
}
