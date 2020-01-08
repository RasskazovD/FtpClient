using System;
using System.IO;
using System.Collections.Generic;
using System.Text;

namespace FtpClient2
{
    class GetFiles
    {
        public List<string> FindFiles(string dir_name, string patterns, bool search_subdirectories)
        {
            List<string> files = new List<string>();
            string[] pattern_array = patterns.Split(';');
            SearchOption search_option = SearchOption.TopDirectoryOnly;
            if (search_subdirectories)
                search_option = SearchOption.AllDirectories;
            foreach (string pattern in pattern_array)
            {
                foreach (string filename in Directory.GetFiles(
                    dir_name, pattern, search_option))
                {
                    if (!files.Contains(filename)) files.Add(filename);
                }
            }
            return files;
        }
    }
}
