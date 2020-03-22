using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab01
{
    class MyEventArgs : EventArgs
    {
        public int Count { get; private set; }
        public MyEventArgs(int count)
        {
            this.Count = count;
        }
    }
    class MyClass
    {
        public event EventHandler<MyEventArgs> MyEventHandler;

        private int processCount = 0;
        public MyClass() { }

        public void IncrementEvent()
        {
            this.processCount += 1;
            if (MyEventHandler != null)
                MyEventHandler(this, new MyEventArgs(this.processCount));
        }
    }
}
