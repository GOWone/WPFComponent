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

namespace WPFComponent.Components.DropMenu
{
    /// <summary>
    /// DropMenuWindow.xaml 的交互逻辑
    /// </summary>
    public partial class DropMenuWindow : Window
    {
        public DropMenuWindow()
        {
            InitializeComponent();
        }

        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Index MenuItem is Clicked");
        }
    }
}
