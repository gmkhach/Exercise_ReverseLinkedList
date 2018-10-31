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

        public void Print()
        {
            string output = string.Empty;

            // build the output string
            Elem temp = this;
            while(temp.next != null)
            {
                output += $"{temp.val}, "; 
                temp = temp.next != null ? temp.next : temp;
            }

            // add the last value to output string
            output += temp.val;

            // print the output string
            Console.WriteLine(output);
        }
    }
}
