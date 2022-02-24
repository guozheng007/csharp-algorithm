using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList.LeetCode
{
    public class Node
    {
        public int data;
        public int np;
        public string names;
        public Node next;

        public Node(int data,int np, string names)
        {
            this.data = data;
            this.np = np;
            this.names = names;
            next = null;
        }
    }
}
