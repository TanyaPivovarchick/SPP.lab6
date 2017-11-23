using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic
{
    public class FileCopyData
    {
        public string From { get; private set; }
        public string To { get; private set; }

        public FileCopyData(string from, string to)
        {
            From = from;
            To = to;
        }
    }
}
