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
            Elem ls = new Elem { val = 1, next = new Elem { val = 2, next = new Elem { val = 3, next = null } } };
            ls.Reverse();
            Console.WriteLine(ls.Print());
        }

    }
}
