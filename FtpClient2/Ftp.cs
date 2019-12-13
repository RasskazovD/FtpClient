using System;
using System.Net;

namespace FtpClient2
{
    class Ftp
    {
        public void upload(String serverAddress, String log, String pass)
        {
            var ftp = new WebClient();
            ftp.Credentials = new NetworkCredential(log, pass);
            ftp.UploadFile("ftp://localhost/Config.cfg", WebRequestMethods.Ftp.UploadFile, @"C:\\Config.cfg");
        }
        public void download(String serverAddress, String log, String pass)
        {
            var ftp = new WebClient();
            ftp.Credentials = new NetworkCredential(log, pass);
            ftp.DownloadFile("ftp://localhost/Config.cfg", @"D:\\Test\Config.cfg");
        }
    }
}
