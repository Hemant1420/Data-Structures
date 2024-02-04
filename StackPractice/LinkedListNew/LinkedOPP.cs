using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace linkedlist
{
    internal class Operations<T>
    {
        public Node<T> Head;

        public Operations()
        {
            Head = null;  //Head Defined
        }

        public void Addnode(T data) //Add Node Or Add Last Method
        {

            Node<T> obj = new Node<T>(data);

            if (Head == null)
            {
                Head = obj;
            }
            else
            {
                Node<T> temp= Head;
                while(temp.next != null) { 
                    temp=temp.next;
                }
                temp.next=obj;
            }

        }

        public void AddFirst(T data) //Add First Method
        {
            Node<T> newnode = new Node<T>(data);

            newnode.next = Head;
            Head = newnode;
        }

        public void AddMid(T data) //Add At The Middle
        {

            Node<T> temp = Head;

            Node<T> newnode = new Node<T>(data);
            Console.WriteLine("enter node position");
            int index = Convert.ToInt32(Console.ReadLine());

            while ((index - 2)>0)
            {
                temp = temp.next;
                index--;
            }
            newnode.next = temp.next;
            temp.next = newnode;

        }

        public void Removelast() //Remove Last Node
        {
            Node<T> temp = Head;
            while (temp.next.next != null)
            {
                temp = temp.next;
            }
            temp.next = null;
        }

        public void Removefirst() //Remove First Node
        {
            Head = Head.next;
        }

        public void Removemid() //Remove Middle Node
        {
            Node<T> temp = Head;

            Console.WriteLine("enter position to delete: ");
            int index = Convert.ToInt32(Console.ReadLine());

            while ((index - 2) > 0)
            {
                temp = temp.next;
                index--;
            }
            temp.next = temp.next.next;
        }

        public void PrintLL() //Print All data Nodes
        {
            Node<T> temp = Head;

            while (temp!= null)
            {
                Console.Write($"{temp.Data}->");
                temp = temp.next;
            }
            
        }

        public void PrintLastele() //Print All data Nodes
        {
            Node<T> temp = Head;

            while (temp.next != null)
            {
                
                temp = temp.next;
            }
            Console.Write($"Top: {temp.Data}\n");

        }




    }

    
}
