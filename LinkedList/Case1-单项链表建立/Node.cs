using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList.Case1
{
    public class Node
    {
        public int data;
        public int np;
        public string names;
        public Node next;

        public Node(int data, string names,int np)
        {
            this.data = data;
            this.names = names;
            this.np = np;
            this.next = null;
        }
    }
}
