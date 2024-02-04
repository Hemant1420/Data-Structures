using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackUsingLinkedlist
{
    internal class Stack<T>
    {

        //public Node1<int>;
        private int Top;
        private int Stacksize;
        Node1<T> head;


        public Stack(int size)
        {
            Top = -1;
            head = null;
            Stacksize = size;

        }

        public void Push(T data)
        {

            if (Top != Stacksize + 1)
            {
                Node1<T> newNode = new Node1<T>(data);
                Node1<T> temp;





                if (head == null)
                {
                    head = newNode;
                }
                else
                {
                    temp = head;
                    while (temp.Next != null)
                    {
                        temp = temp.Next;

                    }
                    temp.Next = newNode;
                    
                }
                ++Top;
            }
            else
            {
                Console.WriteLine("StackOverflow");
            }

        }

        public void Pop()
        {
            if(Top == -1)
            {
                Console.WriteLine("stackUnderFlow");
            }
            else
            {
                Node1<T> temp;
                temp = head;

                while (temp.Next.Next != null) 
                {
                    temp = temp.Next;

                }
                temp.Next = null;
                Top--;
            }
        }

        public void Peek()
        {
            Node1<T> temp = head;
            int i;
            i = 0;
            for(i=0 ;i < Top+1 ;i++)
            {
                temp = temp.Next;
                if(i == Top-1)
                {
                    Console.WriteLine($"{temp.Data}"); 


                }
                
            }



        }

        public void Print()
        {
            Node1<T> temp = head;
            for (int i=0 ;i < Top+1;i++)
            {

                Console.Write($"{temp.Data}->");
                temp = temp.Next;
            }
            Console.Write(" Null \n");
        }



    }
}
