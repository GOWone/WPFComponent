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
using System.Windows.Threading;

namespace WPFComponent.Components.SplashWindow
{
    /// <summary>
    /// SplashWindow.xaml 的交互逻辑
    /// </summary>
    public partial class SplashWindow : Window
    {
        DispatcherTimer timer = new DispatcherTimer();
        public SplashWindow()
        {
            InitializeComponent();
            timer.Tick += new EventHandler(SplashEndEvent);
            timer.Interval += new TimeSpan(0, 0, 13);
            timer.Start();
        }

        private void SplashEndEvent(object sender, EventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
            timer.Stop();
            this.Close();
        }
    }
}
