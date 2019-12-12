using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace FtpClient2
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        private void Application_Startup(object sender, StartupEventArgs e)
        {
            MainWindow wnd = new MainWindow();
            List<string> config = new ConfigLoader().Main();
            wnd.serverAddress.Text = config[0];
            wnd.loginBox.Text = config[1];
            wnd.passBox.Text = config[2];
            wnd.Index.Text = config[3];
            wnd.Import.Text = config[4];
            wnd.Export.Text = config[5];
            wnd.ImportMask.Text = config[6];
            wnd.ExportMask.Text = config[7];
            wnd.Show();
        }
    }
}
