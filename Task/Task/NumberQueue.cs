using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Text;

namespace Task
{
    internal class NumberQueue
    {
        private ConcurrentQueue<int> _queue;

        public NumberQueue(ConcurrentQueue<int> queue)
        {
            Queue = queue;
        }

        public ConcurrentQueue<int> Queue { get => _queue; set => _queue = value; }
    }
}
