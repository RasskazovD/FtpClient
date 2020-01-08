using System;
using System.Net;

namespace FtpClient2
{
    class Ftp
    {
        public void upload(String serverAddress, String log, String pass, String file)
        {
            var ftp = new WebClient();
            ftp.Credentials = new NetworkCredential(log, pass);
            ftp.UploadFile(serverAddress, WebRequestMethods.Ftp.UploadFile, file);
        }
        public void download(String serverAddress, String log, String pass, String file)
        {
            var ftp = new WebClient();
            ftp.Credentials = new NetworkCredential(log, pass);
            ftp.DownloadFile(serverAddress, file);
        }
    }
}
