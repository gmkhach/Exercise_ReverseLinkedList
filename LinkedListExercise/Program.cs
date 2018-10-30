using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedListExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            //Elem ls = new Elem { val = 1, next = new Elem { val = 2, next = new Elem { val = 3, next = null } } };
            Elem ls = new Elem { val = 1, next = new Elem { val = 2, next = null } };
            Elem lsReversed = ReverseLinkedList(ls);
        }

        static Elem ReverseLinkedList(Elem ls)
        {
            if (ls.next == null)
                return new Elem { val = ls.val, next = null };
            else
            {
                var temp = ls.next;
                temp.next = ls;
                ls.next = null;
                return ReverseLinkedList(temp);
            }
        }
    }
}
