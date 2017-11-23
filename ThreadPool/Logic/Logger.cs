using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Logic
{
    public class Logger
    {
        private const string FILENAME = "log.txt";

        private object syncObj = new object();

        public void Add(string logInfo)
        {
            lock (syncObj)
            {
                using (var fs = new FileStream(FILENAME, FileMode.Append))
                {
                    byte[] array = System.Text.Encoding.Default.GetBytes(logInfo + "\r\n");
                    fs.Write(array, 0, array.Length);
                }
            }
        }

        public void ClearFile()
        {
            using (var fs = new FileStream(FILENAME, FileMode.Create)) { }
        }
    }
}
