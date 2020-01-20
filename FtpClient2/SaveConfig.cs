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
                for (int x = 0; x < 5; x++)
                {
                    sw.WriteLine(x);
                }
            }

        }
    }
}
