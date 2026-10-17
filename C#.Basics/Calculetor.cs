using System;
using System.Collections.Generic;
using System.Text;

namespace C_.Basics
{
    public class Calculetor<T>where T:struct,IComparable
    {
        private T numper;

        public Calculetor(T numper)
        {
            this.numper = numper;
        }
        public T getNumper()
        {
            return numper;
        }
    }
}
