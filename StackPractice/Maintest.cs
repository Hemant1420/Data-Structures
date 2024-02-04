using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackPractice
{
    internal class Maintest
    {
        static void Main(string[] args)
        {
            Stack newstack = new Stack(5);
            newstack.push(1);
            newstack.push(2);
            newstack.push(3);
            newstack.push(4);

            newstack.pop();

            newstack.print();
        }
    }
}
