using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedListNode.cs
{
    class Program
    {
    
            static void Main(string[] args)
        {
            var list = new LinkedList();
            list.add(1);
            list.add(2);
            list.add(3);
            list.add(4);
            list.add(5);
            list.Contains(2);
            list.remove(1);

            Console.WriteLine(list.ToString());

            foreach (var value in list)
            {
                Console.WriteLine(value);
            }


            Console.ReadKey();
           



        }
    }
}
