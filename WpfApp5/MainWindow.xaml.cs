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
using HtmlAgilityPack;

namespace WpfApp5
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, RoutedEventArgs e)
        {
            // Load
            var doc = new HtmlDocument();
            doc.LoadHtml("http://192.168.0.103:8085/");
            var div = doc.GetElementbyId("foo");

            // Show info
            System.Console.WriteLine(div.OuterHtml);
            TB1.Text = div.OuterHtml;

            // Show info
            //FiddleHelper.WriteTable(new List<string>() { div.OuterHtml });

            // Show info
            //FiddleHelper.WriteTable(new List<HtmlAgilityPack.HtmlNode>() { div });
        }
    }
}
