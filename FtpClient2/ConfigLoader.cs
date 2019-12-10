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
            String line = File.ReadAllText("Config.cfg");
            return line;
        }
    }
}
