using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.IO;

namespace Logic
{
    public class AllTasks
    {
        public static void EmptyTask(object obj = null)
        {
            Thread.Sleep(1000);
        }

        public static void DivideByZeroTask(object obj = null)
        {
            int a = 1, b = 0;
            int c = a / b;
            Console.WriteLine(c);
        }

        public static void CopyFileTask(object state)
        {
            FileCopyData args;

            if (state != null && state is FileCopyData)
            {
                args = (FileCopyData)state;
                File.Copy(args.From, args.To, true);
            }
        }
    }
}
