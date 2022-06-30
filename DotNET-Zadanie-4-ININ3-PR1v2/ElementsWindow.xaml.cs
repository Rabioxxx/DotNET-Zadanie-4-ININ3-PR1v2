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
using System.Windows.Shapes;
using System.Xml;

namespace DotNET_Zadanie_4_ININ3_PR1v2
{
    /// <summary>
    /// Interaction logic for SubcategoriesWindow.xaml
    /// </summary>
    public partial class ElementsWindow : Window
    {
        public ElementsWindow(XmlNode group)
        {
            DataContext = group;
            InitializeComponent();
        }
    }
}
