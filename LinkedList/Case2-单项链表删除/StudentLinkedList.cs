using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList.Case2
{
    //删除某位学生的成绩，链表实现
    public class StudentLinkedList
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
                Console.WriteLine($"[{current.data}  {current.names} {current.np}]");

                current = current.next;
            }
            Console.WriteLine();
        }

        public void Insert(int data, string names, int np)
        {
            Node newNode = new Node(data, names, np);

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

            //场景一：删除链表的第一个节点
            if(first.data == delNode.data)
            {
                first = first.next;
            }
            else if(last.data == delNode.data)//场景二：删除最后一个节点
            {
                newNode = first;

                while(newNode.next != last)
                {
                    newNode = newNode.next;
                }
                newNode.next = last.next;
                last = newNode;
            }
            else//场景三：删除链表内的中间节点
            {
                newNode = first;
                tmp = first;
                while(newNode.data != delNode.data)
                {
                    tmp = newNode;
                    newNode = newNode.next;
                }
                tmp.next = delNode.next;
            }
        }
    }
}
