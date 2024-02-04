using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackUsingLinkedlist
{
    internal class Node1<T>
    {
        public T Data;
        public Node1<T> Next;

        public Node1(T data )
        {
            Data = data;
            Next = null;
        }



    }

   
}
