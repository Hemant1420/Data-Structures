using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace linkedlist
{
    internal class main
    {
        static void Main()
        {
            
            Console.WriteLine("Enter the operations for linked list: \nAddData->1 :\nAdd First->2 :\nAdd Mid->3 :\nRemove last->4 :\nRemove first->5 :\nRemove mid->6 :\nPrint->7 :\nExit->8");
            
            Operations<int> obj = new Operations<int>(); 
            int choice=0;
            while (choice != 8)
            {
                Console.WriteLine("enter choice :");
                choice = Convert.ToInt32(Console.ReadLine());
                if (choice == 1)
                {
                    Console.WriteLine("enter 1 data: ");
                    int data= Convert.ToInt32(Console.ReadLine());
                    obj.Addnode(data);
                }
                else if (choice == 2)
                {
                    Console.WriteLine("enter 2 data: ");
                    int data = Convert.ToInt32(Console.ReadLine());
                    obj.AddFirst(data);
                }
                else if (choice == 3)
                {
                    Console.WriteLine("enter data: ");
                    int data = Convert.ToInt32(Console.ReadLine());
                    obj.AddMid(data);
                }
                else if (choice == 4)
                {
                    obj.Removelast();
                }
                else if (choice == 5)
                {
                    obj.Removefirst();
                }
                else if (choice == 6)
                {
                    obj.Removemid();
                }
                else if (choice == 7)
                {
                    obj.PrintLL();
                }
            }

           
        }


    }
}
