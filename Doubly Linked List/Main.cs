using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Doubly_Linked_List
{
    public class MainTest
    {
        static void Main()
        {
            Class1<int> newLink = new Class1<int>();
            newLink.Add(1);
            newLink.Print();
            newLink.Add(2);
            newLink.Print();
            newLink.Add(3);
            newLink.Print();
            
            newLink.addBegg(4);
            newLink.Print();
            newLink.addMid_after(7);
            newLink.Print();
            newLink.deletebegg();
            newLink.Print();
            newLink.deleteEnd();
            newLink.Print();
            newLink.deleteMiddle();
            newLink.Print();

        }

        

    }
}
