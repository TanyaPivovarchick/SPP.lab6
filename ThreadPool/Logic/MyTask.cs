using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic
{
    public class MyTask
    {
        public delegate void CallbackDelegate(object state);

        public CallbackDelegate callback;
        public object state;

        public MyTask(CallbackDelegate callback, object state)
        {
            this.callback = callback;
            this.state = state;
        }
    }
}
