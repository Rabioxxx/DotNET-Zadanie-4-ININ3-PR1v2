using System.Windows;
using System.Windows.Controls;
using System.Xml;

namespace DotNET_Zadanie_4_ININ3_PR1v2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void OpenElementsWindow(object sender, RoutedEventArgs e)
        {
            ListBox list = (ListBox)FindName("carsGroup");
            XmlNode group = (XmlNode)list.SelectedItem;
            if (group != null)
            {
                new ElementsWindow(group).Show();
            }
        }
    }
}
