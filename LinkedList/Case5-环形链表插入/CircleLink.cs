using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList.Case5
{
    public class CircleLink
    {
        Node first;
        Node last;

        public bool IsEmpty()
        {
            return first is null;
        }

        public void Print()
        {
            Node current = first;
            while (current != null)
            {
                Console.Write($"[{current.data}]");
                current = current.next;
            }

            Console.Write($"[{current.data}]");
            Console.WriteLine();
        }

        /// <summary>
        /// 插入节点
        /// </summary>
        /// <param name="trp"></param>
        public void Insert(Node trp)
        {
            Node tmp;
            Node newNode;

            if(IsEmpty())
            {
                first = trp;
                last = trp;
                last.next = first;
            }
            else if(trp.next == null)
            {
                last.next = trp;
                last = trp;
                last.next = first;
            }
            else
            {
                newNode = first;
                tmp = first;
                while (newNode.next != trp.next)
                {
                    if(tmp.next == first)
                    {
                        break;
                    }

                    tmp = newNode;
                    newNode = newNode.next;
                }
                tmp.next = trp;
                trp.next = newNode;
            }
        }

        /// <summary>
        /// 删除节点
        /// </summary>
        /// <param name="delNode"></param>
        void Delete(Node delNode)
        {
            Node newNode;
            Node tmp;

            if(this.IsEmpty())
            {
                Console.Write("[环形链表已经空了]\n");
                return;
            }

            if(first.data == delNode.data)
            {
                first = first.next;
                if(first == null)
                {
                    Console.Write("[环形链表已经空了]\n");
                }

                return;
            }
            else if (last.data == delNode.data)
            {
                newNode = first;
                while (newNode.next != last)
                {
                    newNode = newNode.next;
                }
                newNode.next = last.next;
                last = newNode;
                last.next = first;
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
