using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedListNode.cs
{
    class LinkedList : IEnumerable
    {
        LinkedListNode head;

        public void add(int valor)
        {
            head = new LinkedListNode(valor, head);
        }

        public void clear()
        {
            head = null;

        }

        public bool Contains (int valor)
        {
            var iterador = head;
            while(iterador != null)
            {
                if (iterador.valor == valor)
                {
                    return true;
                }
                iterador = iterador.next;
            }
            return false;
        }

      

        public bool remove (int valor)
        {
            var iterador = head;
            LinkedListNode anterior = head;
            if(head.valor == valor)
            {
                head = head.next;
                return true;
            }

            while (iterador != null)
            {
                if (iterador.valor == valor)
                {
                    anterior.next = iterador.next;
                    return true;
                }
                anterior = iterador;
                iterador = iterador.next;
            }
            return false;           
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            var iterador = head;

            while(iterador != null)
            {
                sb.Append(iterador.valor + ">");
                iterador = iterador.next;
            }

            sb.Append("Null");

            return sb.ToString();
        }


        public IEnumerator GetEnumerator()
        {
            LinkedListNode proximoNo = head;
            while(proximoNo != null)
            {
                yield return proximoNo.valor;
                proximoNo = proximoNo.next;
            }
        }




    }
}
