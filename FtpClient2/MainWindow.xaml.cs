using System;
using System.Windows;
using System.Net;


namespace FtpClient2
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

        private void ReceiveClick(object sender, RoutedEventArgs e)
        {
            var ftp = new Ftp("ftp://" + serverAddress.Text + "/Config.cfg", loginBox.Text, passBox.Text);
            ftp.download();
        }

        private void SendClick(object sender, RoutedEventArgs e)
        {
            var ftp = new Ftp("ftp://" + serverAddress.Text + "/Config.cfg", loginBox.Text, passBox.Text);
            ftp.upload();
        }

        private void SaveClick(object sender, RoutedEventArgs e)
        {
           
        }
    }
}
