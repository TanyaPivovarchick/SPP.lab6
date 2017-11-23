using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic
{
    public interface IMyThreadPool
    {
        void SetThreadPoolСharacteristics(int minCountOfThreads, int maxCountOfThreads);

        void AddTaskInQueue(MyTask task);
    }
}
