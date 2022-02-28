using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList.Case7
{
    public class ConcatStuLinkedList: StuLinkedList
    {
        public StuLinkedList Concat(StuLinkedList stuLinkedList)
        {
            this.last.next = stuLinkedList.first;
            this.last = stuLinkedList.last;

            return this;
        }
    }
}
