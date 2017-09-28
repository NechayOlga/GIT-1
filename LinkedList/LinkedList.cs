/*using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
    public class LinkedList
    {
        public Node Head
        { get; set; }
        public Node Tail
        { get; set; }
        public int Count
        { get; set; }
        public LinkedList(int value)
        {
            Node node = new Node(value);
            Head = node;
            Tail = node;
            Count++;
        }
        public void Add(int value)
        {
            Node node = new Node(value);
            if(Head == null)
            {
                Head = node;
                Tail = node;
            }
            else
            {
                Tail.Next = node;
                Tail = node;
            }
            Count++;
        }
        public bool Delete(int value)
        {
            Node node = Head;
            while (node != Tail)
            {
                if(node.Next.Value == value)
                {
                    node.Next = node.Next.Next;
                    Count--;
                    return true;
                }
                node = node.Next;
            }
            return false;
        }

    }
}*/
