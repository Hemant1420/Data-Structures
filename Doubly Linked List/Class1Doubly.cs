using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Doubly_Linked_List
{
    public class Node<T>
    {
        public T Data;
        public Node<T> Next ; 
        public Node<T> Prev ;

        public Node(T data)
        {
            Data = data;
            Next = null;
            Prev = null;

        }


    }

   
}
