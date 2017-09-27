using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList2
{
    class LinkedList2
    {
        const string INVALID_INPUT = "Invalid input. Try again";
        public Node Head
        { get; set; }
        public Node Tail
        { get; set; }
        public int Count
        { get; set; }
        public LinkedList2(int value)
        {
            Node node = new Node(value);
            Head = node;
            Tail = node;
            Count++;
        }
        public void Add(int value)
        {
            Node node = new Node(value);
            if(Head != null)
            {
                Tail.Next = node;
                Tail = node;
            }
            else
            {
                Head = node;
                Tail = node;
            }
            Count++;
        }
        public bool Delete(int value)
        {
            Node node = Head;
            if(node == null)
            {
                throw new InvalidValueException(INVALID_INPUT);
            }
            while (node != Tail) 
            {
                if(node.Next.Value == value)
                {
                    node.Next = node.Next.Next;
                    Count--;
                    return true;
                }       
            }
            node = node.Next;
            return false;
        }
    }
}
