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
using System.Management;

namespace WpfApp1
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

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            listBox1.Items.Clear();
            try
            {
                //string CPUtprt = 0;
                System.Management.ManagementObjectSearcher MOS = new System.Management.ManagementObjectSearcher("root\\CIMV2",
                        "SELECT * FROM Win32_NetworkAdapter  ");
                foreach (System.Management.ManagementObject Mo in MOS.Get())
                {
                    //CPUtprt = Mo.GetPropertyValue("Status".ToString());
                    listBox1.Items.Add(Mo.GetPropertyValue("NetConnectionStatus".ToString()));
                }
            }
            catch (ManagementException ex)
            {
                MessageBox.Show("Ошибка получения данных " + ex.Message);
            }
        }
    }
}
