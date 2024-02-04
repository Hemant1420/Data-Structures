using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackUsingLinkedlist
{
    internal class Maintest
    {

        static void Main()
        {
            Stack<int> newStack = new Stack<int>(5);
           newStack.Push(1);
           newStack.Push(2);
           newStack.Push(3);
           newStack.Push(4);
            newStack.Print();

            newStack.Pop();
            newStack.Print();

            
            newStack.Peek();
        }
    }
}
