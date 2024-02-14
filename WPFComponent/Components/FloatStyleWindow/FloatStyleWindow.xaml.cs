using System;
using System.Collections.Generic;
using System.ComponentModel;
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

namespace WPFComponent.Components.FloatStyleWindow
{
    /// <summary>
    /// FloatStyleWindow.xaml 的交互逻辑
    /// </summary>
    public partial class FloatStyleWindow : Window
    {
        private readonly BackgroundWorker backgroundWorker;//任务工作处理线程
        private readonly DispatcherTimer timer;//动画处理定时器

        private double rotationAngle = 0.0;
        public FloatStyleWindow()
        {
            InitializeComponent();
            InitializeDragAndDrop();

            ShowInTaskbar = false;
            Topmost = true;
            LoadPreferences();
            timer = new DispatcherTimer
            {
                Interval = TimeSpan.FromMilliseconds(10),//设置定时器间隔
            };
            timer.Tick += Timer_Tick;

            //创建工作线程
            backgroundWorker = new BackgroundWorker();
            backgroundWorker.WorkerReportsProgress = true;
            backgroundWorker.WorkerSupportsCancellation = true;
            backgroundWorker.DoWork += BackgroundWorker_DoWork;
            backgroundWorker.ProgressChanged += BackgroundWorker_ProgressChanged;
            backgroundWorker.RunWorkerAsync();
        }

        private void BackgroundWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            //var thread = sender as BackgroundWorker;
            //while(!backgroundWorker.CancellationPending)
            //{
            //    if (!GlobalConfig.Instance.OngoingQueue.IsEmpty && !timer.ISEnabled)//进入工作状态
            //    {
            //        rotationAngle = 0.0;
            //        timer.Start();
            //    }

            //    if (GlobalConfig.Instance.OngoingQueue.TryDequeue(out ConvertTask? result) && result != null)
            //    {
            //        try
            //        {
            //            using MagicImage webpImage = new(result.Source);
            //            switch (result.Format)
            //            {
            //                case "JPG":
            //                    webpImage.Format = MagicFormat.Jpg; break;
            //                case "PNG":
            //                    webpImage.Format = MagicFormat.Png; break;
            //                case "WEBP":
            //                    webpImage.Format = MagicFormat.WebP; break;
            //                case "AVIF":
            //                    webpImage.Format = MagicFormat.Avif; break;
            //            }
            //            webpImage.Write(result.Target);
            //            thread?.ReportProgress(result.Id, ConvertTask.ConvertTaskStatus.Success);

            //        }
            //        catch
            //        {
            //            thread?.ReportProgress(result.Id, ConvertTask.ConvertTaskStatus.Failed);
            //        }
            //    }
            //    else
            //    {
            //        //退出工作状态
            //        if (timer.IsEnabled)
            //        {
            //            timer.Stop();
            //        }
            //    }
            //}
        }

        private void BackgroundWorker_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            //var task = GlobalConfig.Instance.Queue.FirstOrDefaut(item => item.Id == (int)e.ProgressPercentage);
            //var status = e.UserState;
            //if (task != null && status != null)
            //{
            //    task.Status = (ConvertTask.ConvertTaskStatus)status;
            //}
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            //定时器触发时旋转图像
            RotateImage();
        }

        private void RotateImage()
        {
            throw new NotImplementedException();
        }

        private void LoadPreferences()
        {
            throw new NotImplementedException();
        }

        private void InitializeDragAndDrop()
        {
            throw new NotImplementedException();
        }

        private void Window_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {

        }

        private void Window_MouseRightButtonDown(object sender, MouseButtonEventArgs e)
        {

        }

        private void SettingItem_Click(object sender, RoutedEventArgs e)
        {

        }

        private void AboutItem_Click(object sender, RoutedEventArgs e)
        {

        }

        private void ExitItem_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
