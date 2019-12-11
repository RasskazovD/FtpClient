using System;
using System.Net;

namespace FtpClient2
{
    class Ftp
    {
        private String server;
        private String login;
        private String password;
        public Ftp(String serverAddress, String log, String pass)
        {
            server = serverAddress;
            login = log;
            password = pass;
        }
        public void upload()
        {
            var ftp = new WebClient();
            ftp.Credentials = new NetworkCredential(login, password);
            ftp.UploadFile("ftp://localhost/Config.cfg", WebRequestMethods.Ftp.UploadFile, @"C:\\Config.cfg");
        }
        public void download()
        {
            var ftp = new WebClient();
            ftp.Credentials = new NetworkCredential(login, password);
            ftp.DownloadFile("ftp://localhost/Config.cfg", @"D:\\Test\Config.cfg");
        }
    }
}
