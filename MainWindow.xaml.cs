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

namespace Chromedino1
{
    /// <summary>
    /// MainWindow.xaml の相互作用ロジック
    /// </summary>
    public partial class MainWindow : Window
    {
        private Microsoft.VisualBasic.Devices.Audio audio =
    new Microsoft.VisualBasic.Devices.Audio();//BGM再生用
        public MainWindow()
        {
            InitializeComponent();
            var browser = new CefSharp.Wpf.ChromiumWebBrowser();
            browser.Address = "file://" + AppDomain.CurrentDomain.SetupInformation.ApplicationBase + "\\DINODATA\\Index.html";
            Content = browser;
            audio.Play(AppDomain.CurrentDomain.SetupInformation.ApplicationBase + "\\DINODATA\\Assets\\BGM.wav", Microsoft.VisualBasic.AudioPlayMode.BackgroundLoop);



        }

        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            audio.Stop();
            CefSharp.Cef.Shutdown();
        }
    }
}
