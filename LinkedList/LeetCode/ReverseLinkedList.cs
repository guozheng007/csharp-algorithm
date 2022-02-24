using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList.LeetCode
{
    public class ReverseLinkedList: StuLinkedList
    {
        public void ReverseAndPrint()
        {
            Node cur = first;
            Node pre = null;

            Console.WriteLine("反转后的链表数据：");

            while (cur != null)
            {
                last = pre;
                pre = cur;
                cur = cur.next;
                pre.next = last;
            }

            cur = pre;

            while(cur != null)
            {
                Console.WriteLine($"[{cur.data} {cur.names} {cur.np}]");
                cur = cur.next;
            }

            Console.WriteLine();
        }
    }
}
