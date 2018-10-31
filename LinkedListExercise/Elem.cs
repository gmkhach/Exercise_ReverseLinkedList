using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedListExercise
{
    class Elem
    {
        public int val;
        public Elem next;

        public Elem Reverse()
        {
            // base case
            if (next == null)
            {
                return this;
            }

            // revers what current Elem is pointing at
            var temp = next.Reverse();

            // make the next Elem point at `this` 
            next.next = this;

            // set current Elem's pointer to null
            this.next = null;

            return temp;
        }

        public string Print()
        {
            if (next == null)
            {
                return val.ToString();
            }
            else
            {
                return $"{val.ToString()}, {next.Print()}";
            }
        }
    }
}
