using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedListNode.cs
{
    class LinkedListNode
    {
        public int valor { get; }
        public LinkedListNode next;

        public LinkedListNode (int valor, LinkedListNode next)
        {
            this.valor = valor;
            this.next = next;
        }

    
    }
}
