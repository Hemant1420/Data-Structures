using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace BST_Practice
{
    public class Operations<T> where T : IComparable<T>
    {

        public Node<T> Root;

        public Operations()
        {
            Root = null;
        }

        public void Insert(T value)
        {

            Node<T> newNode = new Node<T>(value);   

            if (Root == null)
            {
                Root = newNode;
                return;

            }

            Node<T> temp = Root;

            while (true)
            {

                if (value.CompareTo(temp.Value) < 0)
                {
                    if (temp.Leftnode == null)
                    {
                        temp.Leftnode = newNode;
                        return;
                    }

                    temp = temp.Leftnode;

                }

                else if (value.CompareTo(temp.Value) > 0)
                {
                    if (temp.Rightnode == null)
                    {
                        temp.Rightnode = newNode;
                        return;
                    }
                    temp = temp.Rightnode;
                }

                else
                {
                    Console.WriteLine("The Value already exists");
                }
            }

        }

       
        


    }
}








