using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Doubly_Linked_List
{
    public class Class1<T>
    {
        Node<T> head;
        

        public Class1()
        {
            head = null;
            
        }

        public void Add(T data)
        {
            Node<T> newNode = new Node<T>(data);
            if(head == null)
            {
                head = newNode;
                

            }
            else
            {
                Node<T> temp = head;
                while(temp.Next != null)
                {
                    
                    temp = temp.Next;

                }
                temp.Next = newNode;
                newNode.Prev = temp;
            }
        }

        public void addBegg(T data)
        {
            Node<T> newNode = new Node<T>(data);
            
            newNode.Next = head;
            head.Prev = newNode;
            head = newNode;



        }

        public void addMid_after(T data)
        {
            Console.WriteLine("Enter the Position at which you want to enter the Node: ");
            int position = Convert.ToInt32(Console.ReadLine());

            Node<T> newNode = new Node<T>(data);
            Node<T> temp = head;    
            for(int i =0; i < position; i++)
            {
                temp = temp.Next;
            }
            newNode.Next = temp;
            newNode.Prev = temp.Prev;
            temp.Prev.Next= newNode;
            temp.Prev= newNode;


        }

       /* public void addMid_after(T data)
        {
            Console.WriteLine("Enter the Position at which you want to enter the Node: ");
            int position = Convert.ToInt32(Console.ReadLine());

            Node<T> newNode = new Node<T>(data);
            Node<T> temp = head;

        }*/

        public void deletebegg()
        {
            Node<T> temp = head;
            head = temp.Next;
            temp.Next.Prev = null;
            temp.Next = null;
            

           


        }

        public void deleteEnd()
        {
            Node<T> temp = head;    

            while(temp.Next.Next != null)
            {
                temp = temp.Next;

            }
            temp.Next = null;
            
        }

        public void deleteMiddle()
        {
            Console.WriteLine("Enter the Position of Node you want to delete: ");
            int position = Convert.ToInt32(Console.ReadLine());
            Node<T> temp = head;
            

            for (int i = 0; i <= position-2; i++)
            {
                temp = temp.Next;
            }
           if(temp.Next != null && temp.Prev != null)
            {
                temp.Prev.Next = temp.Next;
                temp.Next.Prev = temp.Prev;
                temp.Next = null;
                temp.Prev = null;

            }
           else if(temp.Next != null && temp.Prev == null)
            {
                deletebegg();
            }
            
            else if(temp.Next == null && temp.Prev != null)
            {
                deleteEnd();
            }

            else
            {
                Console.WriteLine("There is Only One node present");
            }




        }

        public void Print()
        {


            Node<T> temp = head;

          while(temp !=null)
            {
                Console.Write($"{temp.Data}-> ");
                temp = temp.Next;
            }
            Console.WriteLine();

        }
    }


   
}
