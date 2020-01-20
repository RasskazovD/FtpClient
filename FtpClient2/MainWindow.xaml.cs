using System;
using System.Windows;
using System.Collections.Generic;


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
            var files = new GetFiles().FindFiles(Import.Text, ImportMask.Text, false); 
            var ftp = new Ftp();
            foreach (string i in files)
            {
                ftp.download(serverAddress.Text, loginBox.Text, passBox.Text, i);
            }
        }

        private void SendClick(object sender, RoutedEventArgs e)
        {
            var files = new GetFiles().FindFiles(Export.Text, ExportMask.Text,false);
            var ftp = new Ftp();
            foreach (string i in files)
            {
                ftp.upload(serverAddress.Text, loginBox.Text, passBox.Text, i);
            }

        }

        private void SaveClick(object sender, RoutedEventArgs e)
        {
            List<String> config = new List<string>();
            config.Add(serverAddress.Text);
            config.Add(loginBox.Text);
            config.Add(passBox.Text);
            config.Add(Index.Text);
            config.Add(Import.Text);
            config.Add(Export.Text);
            config.Add(ImportMask.Text);
            config.Add(ExportMask.Text);

            SaveConfig save = new SaveConfig();
            save.Save(config);

        }
    }
}
