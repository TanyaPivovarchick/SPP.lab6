using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Logic
{
    public class MyThreadPool : IMyThreadPool
    {
        private const int MAX_COUNT_OF_TASKS = 2;
        private const int WAITING_TIME = 1000;

        private int MinCountOfThreads { get; set; }
        private int MaxCountOfThreads { get; set; }

        private object dictionarySync = new object();
        private object queueSync = new object();

        private Logger logger = new Logger();

        private Queue<MyTask> queueOfTasks = new Queue<MyTask>();
        private List<int> listOfThreads = new List<int>();

        private CancellationTokenSource cancelTokenSource = new CancellationTokenSource();

        private static AutoResetEvent newTaskEvent = new AutoResetEvent(true);

        public MyThreadPool(int min, int max)
        {
            SetThreadPoolСharacteristics(min, max);

            logger.ClearFile();

            for (int i = 0; i < MinCountOfThreads; i++)
            {
                AddNewThreadsInDictionary();
            }
        }

        public void SetThreadPoolСharacteristics(int min, int max)
        {
            MinCountOfThreads = min;
            MaxCountOfThreads = max;
        }

        public void AddTaskInQueue(MyTask task)
        {
            logger.Add("Добавлена новая задача");

            lock (queueSync)
            {
                queueOfTasks.Enqueue(task);
                newTaskEvent.Set();
            }
        }

        private void AddNewThreadsInDictionary()
        {
            var newThread = new Task(WorkForThread, cancelTokenSource.Token, TaskCreationOptions.LongRunning);

            lock (dictionarySync)
            {
                listOfThreads.Add(newThread.Id);
            }

            logger.Add("Создан поток с идентификатором = " + newThread.Id);

            newThread.Start();
        }

        public void WorkForThread()
        {
            MyTask currentTask;
            bool isEvent = false;

            do
            {
                if (queueOfTasks.Count() >= MAX_COUNT_OF_TASKS && GetCountOfThreads() == MaxCountOfThreads)
                    logger.Add("Достигнуто максимальное количество потоков");

                if (queueOfTasks.Count() >= MAX_COUNT_OF_TASKS && GetCountOfThreads() < MaxCountOfThreads)
                    AddNewThreadsInDictionary();

                currentTask = TakeTaskFromQueue();

                if (currentTask != null)
                {
                    ProcessingTask(currentTask);
                }
                else
                {
                    if (GetCountOfThreads() > MinCountOfThreads)
                    {
                        isEvent = newTaskEvent.WaitOne(WAITING_TIME);
                    }
                    else
                    {
                        isEvent = newTaskEvent.WaitOne();
                    }

                    if (!isEvent)
                    {
                        if (GetCountOfThreads() > MinCountOfThreads)
                        {
                            logger.Add("Поток с номером " + Task.CurrentId + " остановлен");
                            lock (dictionarySync)
                            {
                                listOfThreads.Remove((int)Task.CurrentId);
                                cancelTokenSource.Cancel();
                            }
                        }
                    }
                }
            }
            while (true);
        }

        private int GetCountOfThreads()
        {
            lock (dictionarySync)
            {
                return listOfThreads.Count();
            }
        }

        private MyTask TakeTaskFromQueue()
        {
            lock (queueSync)
            {
                if (queueOfTasks.Count != 0)
                {
                    return queueOfTasks.Dequeue();
                }
                else return null;
            }
        }

        private void ProcessingTask(MyTask task)
        {
            task.callback(task.state);
        }
    }
}