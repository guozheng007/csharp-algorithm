using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList.Case4
{
    public class Node
    {
        public int data;
        public int np;
        public string name;
        public Node next;

        public Node(int data,string name,int np)
        {
            this.data = data;
            this.name = name;
            this.np = np;
            next = null;
        }

    }
}
