using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList.Case4
{
    public class LinkedList
    {
        public Node first;
        public Node last;

        public bool IsEmpty()
        {
            return first is null;
        }

        public void Print()
        {
            Node current = first;

            while(current != null)
            {
                Console.WriteLine($"[{current.data}  {current.name} {current.np}]");

                current = current.next;
            }
            Console.WriteLine();
        }

        public void Update(Node updateNode)
        {
            Node current = first;

            while (current != null)
            {
                if(current.name == updateNode.name)
                {
                    current.data = updateNode.data;
                }

                current = current.next;
            }

        }

        public void Insert(Node ptr)
        {
            Node tmp;
            Node newNode;

            if (this.IsEmpty())
            {
                first = ptr;
                last = ptr;
            }
            else
            {
                if (ptr.next == first)
                {
                    ptr.next = first;
                    first = ptr;
                }
                else
                {
                    if (ptr.next == null)
                    {
                        last.next = ptr;
                        last = ptr;
                    }
                    else
                    {
                        newNode = first;
                        tmp = first;
                        while (ptr.next != newNode.next)
                        {
                            tmp = newNode;
                            newNode = newNode.next;
                        }
                        tmp.next = ptr;
                        ptr.next = newNode;
                    }
                }
            }
        }
    }
}
