using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList.Case3
{
    public class LinkedList
    {
        public Node first;
        public Node last;

        public bool IsEmpty()
        {
            return first == null;
        }

        public void Print()
        {
            Node current = first;
            while (current != null)
            {
                Console.Write($"[{current.data}]");

                current = current.next;
            }
            Console.WriteLine();
        }

        public LinkedList Concatenate(LinkedList head1, LinkedList head2)
        {
            LinkedList ptr;
            ptr = head1;
            while (ptr.last.next != null)
            {
                ptr.last = ptr.last.next;
            }
            ptr.last.next = head2.first;

            return head1;
        }

        public void Insert(Node ptr)
        {
            Node tmp;
            Node newNode;

            if(this.IsEmpty())
            {
                first = ptr;
                last = ptr;
            }
            else
            {
                if(ptr.next == first)
                {
                    ptr.next = first;
                    first = ptr;
                }
                else
                {
                    if(ptr.next == null)
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
