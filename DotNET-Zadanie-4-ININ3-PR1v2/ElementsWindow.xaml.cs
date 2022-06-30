using System.Windows;
using System.Windows.Controls;
using System.Xml;

namespace DotNET_Zadanie_4_ININ3_PR1v2
{
    /// <summary>
    /// Interaction logic for ElementsWindow.xaml
    /// </summary>
    public partial class ElementsWindow : Window
    {
        public ElementsWindow(XmlNode group)
        {
            DataContext = group;
            InitializeComponent();
        }

        private void OpenDetailsWindow(object sender, RoutedEventArgs e)
        {
            ListBox list = (ListBox)FindName("carsCategories");
            XmlNode group = (XmlNode)list.SelectedItem;
            if (group != null)
            {
                new ElementDetailsWindow(group).Show();
            }
        }
    }
}
