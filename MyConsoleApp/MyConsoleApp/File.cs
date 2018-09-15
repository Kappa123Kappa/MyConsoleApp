using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyConsoleApp
{
    class File
    {
        public StreamReader getStreamReader(string path)
        {
            StreamReader streamReader = null;
            try
            {
                streamReader = new StreamReader(path, System.Text.Encoding.Default);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            return streamReader;
        }
    }
}
