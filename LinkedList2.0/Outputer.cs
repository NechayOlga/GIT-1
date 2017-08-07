using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList2
{
    class Outputer
    {
        public void Output (LinkedList2 list2)
        {
            Node node;
            node = list2.Head;
            while (node != null)
            {
                Console.WriteLine(node.Value + " ");
                node = node.Next;
            }
        }
    }
}
