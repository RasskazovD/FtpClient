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
            MessageBox.Show("Receive");
        }

        private void ReceiveSend(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Send");
        }

        private void SaveClick(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Save");
        }
    }
}
