using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedListExercise
{
    class Elem
    {
        public int val { get; set; }
        public Elem next { get; set; }

        public Elem Reverse()
        {
            if (next == null)
            {
                return this;
            }
            var temp = next.Reverse();
            next.next = this;
            this.next = null;
            return temp;
        }
    }
}
