using System;
using System.IO;
using System.Collections.Generic;
using System.Text;

namespace FtpClient2
{
    class ConfigLoader
    {
        public string Main()
        {
            String line;
            try
            {
                using (StreamReader sr = new StreamReader(@"C:\Config.txt"))
                {
                    line = sr.ReadToEnd();
                }
            }
            catch(IOException e)
            {
                line = "No config file";
            }
            return line;
        }
    }
}
