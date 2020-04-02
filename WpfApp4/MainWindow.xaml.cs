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
using System.Windows.Markup;

namespace WpfApp4
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

        int NodeCounter = 1;

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            /*GroupBox MyBG = new GroupBox();
            MyBG.Header = "Узел " + NodeCounter;
            MyBG.Width = 200;
            SP1.Children.Add(MyBG);
            NodeCounter++;
            StackPanel MySP = new StackPanel();
            MySP.Name = "SP" + NodeCounter;
            Label MyLB = new Label();
            MyLB.Content = NodeCounter;
            //GB1.Children.Add(MySP);
            //SP1.Children.Add(MyBG);
            NodeCounter++; */

            // Create a stringBuilder
            StringBuilder sb = new StringBuilder();

            // use xaml to declare a button as string containing xaml
            sb.Append(@"<GroupBox xmlns='http://schemas.microsoft.com/winfx/2006/xaml/presentation' 
                            xmlns:x='http://schemas.microsoft.com/winfx/2006/xaml' ");
            sb.Append(@"Name='GB1' Width='200' Header='@NodeCounter'/>");

            // Create a button using a XamlReader
            GroupBox myButton = (GroupBox)XamlReader.Parse(sb.ToString());

            // Add created button to previously created container.
            SP1.Children.Add(myButton);

        }
    }
}
