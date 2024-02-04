using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QueuePractice
{
    internal class MainQueueTest
    {
        static void Main()
        {
            Queue<int> newQueue = new Queue<int>(5);
            newQueue.Enqueue(1);
            newQueue.Enqueue(2);
            newQueue.Enqueue(3);
            newQueue.Enqueue(4);
            newQueue.Print();

            newQueue.Dequeue();
            newQueue.Print();


            newQueue.Peek();
        }
    }
}
