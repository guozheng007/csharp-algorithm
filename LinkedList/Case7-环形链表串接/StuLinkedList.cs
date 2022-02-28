using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList.Case7
{
    public class StuLinkedList
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

            while (current != null)
            {
                Console.WriteLine($"[{current.data}  {current.names} {current.np}]");
                current = current.next;
            }
            Console.WriteLine();
        }

        public void Insert(int data,string names, int np)
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

        public void Delete(Node delNode)
        {
            Node newNode;
            Node tmp;
            if(first.data == delNode.data)
            {
                first = first.next;
            }
            else if(last.data == delNode.data)
            {
                newNode = first;
                while (newNode.next != last)
                {
                    newNode = newNode.next;
                }
                newNode.next = last.next;
                last = newNode;
            }
            else
            {
                newNode = first;
                tmp = first;
                while (newNode.data != delNode.data)
                {
                    tmp = newNode;
                    newNode = newNode.next;
                }
                tmp.next = delNode.next;
            }
        }
    }
}
