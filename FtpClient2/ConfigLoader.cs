using System;
using System.IO;
using System.Collections.Generic;
using System.Text;

namespace FtpClient2
{
    class ConfigLoader
    {
        string line;
        public List<string> Main()
        {
            List<string> resultConfig = new List<string>();
            StreamReader file = new StreamReader("Config.cfg");
            while ((line = file.ReadLine()) != null)
            {
                if (!line.StartsWith("#"))
                {
                    resultConfig.Add(line);
                }
            }

            return resultConfig;
        }
    }
}
