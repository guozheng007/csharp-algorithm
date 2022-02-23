using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList.Case1
{
    public class LinkedList
    {
        private Node first;
        private Node last;

        public bool IsEmpty()
        {
            return first == null;
        }

        public void Print()
        {
            Node current = first;

            while (current != null)
            {
                Console.WriteLine($"[{current.data} {current.names} {current.np}]");
                current = current.next;
            }

            Console.WriteLine();
        }

        public void Insert(int data, string names, int np)
        {
            Node newNode = new(data, names, np);

            if(this.IsEmpty())
            {
                first = newNode;
                last = newNode;
            }
            else
            {
                last.next = newNode;
                last = newNode;
            }
        }
    }
}
