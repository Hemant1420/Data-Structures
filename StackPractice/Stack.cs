using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackPractice
{
    internal class Stack
    {
        private int[] arr;
        private int Top;
        private int Stacksize;
        
        public Stack(int size) 
        {
            Top = -1;
            arr = new int[size];
            Stacksize = size;

        }
         public void push(int x)
        {
            if(Top != Stacksize - 1)
            {
                arr[++Top] = x;
            }
            else
            {
                Console.WriteLine("Stackoverflow");
            }

        }

        public void pop()
        {
            if(Top == -1)
            {
                Console.WriteLine("Stack is empty");
            }
            else
            {
                Top--;
            }
            
        }

        public int size()
        {
            return Stacksize;
        }

        public void print()
        {
            for (int i = 0; i < Top+1; i++)
            {
                Console.WriteLine(arr[i]);
            }
        }
    }
}
