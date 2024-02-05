using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BST_Practice
{
    public class Node<T>
    {
        public T Value;
        public Node<T> Rightnode;
        public Node<T> Leftnode;

        public Node(T value)
        {
            Value = value;
            Rightnode = Leftnode = null;


        }



    }
}
