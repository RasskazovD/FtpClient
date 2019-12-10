using System;
using System.Net;
using System.IO;


namespace FtpClient2
{
    class Ftp
    {
        public Ftp(string hostIP, string userName, string password) { host = hostIP; user = userName; pass = password; }

        private string host = null;
        private string user = null;
        private string pass = null;
        private FtpWebRequest ftpRequest = null;
        private FtpWebResponse ftpResponse = null;
        private Stream ftpStream = null;
        private int bufferSize = 2048;

        public void upload(string serverPath, string localPath)
        {
            ftpRequest = (FtpWebRequest)FtpWebRequest.Create("ftp://"+host+"/"+localPath);
            ftpRequest.Credentials = new NetworkCredential(user, pass);
            ftpRequest.UseBinary = true;
            ftpRequest.UsePassive = false;
            ftpRequest.KeepAlive = false;
            ftpRequest.Method = WebRequestMethods.Ftp.UploadFile;
            ftpStream = ftpRequest.GetRequestStream();
            FileStream localFileStream = new FileStream(localPath, FileMode.Create);
            byte[] byteBuffer = new byte[bufferSize];
            int bytesSent = localFileStream.Read(byteBuffer, 0, bufferSize);
            try
            {
                while (bytesSent != 0)
                {
                    ftpStream.Write(byteBuffer, 0, bytesSent);
                    bytesSent = localFileStream.Read(byteBuffer, 0, bufferSize);
                }
            }
            catch(Exception ex)
            {
                //TODO
            }
            return;
        }
        //public void download(TODO)
    }
}
