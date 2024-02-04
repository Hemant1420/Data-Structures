using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QueuePractice
{
    public class Queue<T>
    {
        public T[] arr;
        public int Front;
        public int Rear;
        public int Queuesize;
        

        public Queue(int size)
        {
            arr = new T[size];
            Queuesize = size;
            Front = -1;
            Rear = -1;

        }

        

        public bool Isfull()
        {
            if(Rear == Queuesize - 1)
            {
                Console.WriteLine("Queue is full");
                return true;
            }
            return false;
        }

        public bool Isempty()
        {
            if(Front == -1 && Rear == -1) 
            {
                Console.WriteLine("Queue is empty");
                return true;
            }
            return false;
        }

        public void Enqueue(T data)
        {
            if (Isfull())
            {

                Console.WriteLine("Queue is full");
            }
            else
            {
                if (Front == -1)
                {
                    Front = 0;
                    Rear++;
                    arr[Rear] = data;

                }
                else
                {

                    Rear++;
                    arr[Rear] = data;
                }
            }
        }

        public void Dequeue()
        {
            if (Isempty())
            {
                Console.WriteLine("Queue is empty");
            }
            else
            {
                if (Front == Rear)
                {
                    Front = -1;
                    Rear = -1;
                }
                else
                {
                    Front++;
                }


            }

        }

        public void Peek()
        {
            Console.WriteLine(arr[Front]);


        }

        public void Print()
        {
            for(int i = Front; i<=Rear; i++)
            {
                Console.Write($"{arr[i]}->");
            }
            Console.WriteLine();
        }



    }
}