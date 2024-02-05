using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BST_Practice
{
    public class MainTest
    {
        static void Main()
        {
            Operations<int> newOp = new Operations<int>();
            newOp.Insert(10);
            newOp.Insert(15);
            newOp.Insert(8);
            newOp.Insert(5);
            newOp.Insert(4);
            newOp.Insert(6);
            newOp.Insert(18);
            newOp.Insert(20);

            
        }

    }
}
