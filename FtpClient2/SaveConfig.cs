using System;
using System.Collections.Generic;
using System.Text;

namespace FtpClient2
{
    class SaveConfig
    {
       public void Save(List<String> config)
        {
            using (var sw = new System.IO.StreamWriter("Config.cfg", true))
            {
                foreach (string x in config)
                {
                    sw.WriteLine(x);
                }
            }

        }
    }
}
