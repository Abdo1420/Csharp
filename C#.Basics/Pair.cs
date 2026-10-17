using System;
using System.Collections.Generic;
using System.Text;

namespace C_.Basics
{
    public class Pair<TKey,TValue>
    {
        private TKey? First ;
        private TValue? Socend;

        public Pair(TKey? first, TValue? socend)
        {
            First = first;
            Socend = socend;
        }
        public TKey getFirst()
        {
            return First;
        }
        public TValue getSocend()
        {
            return Socend;
        }
        public override string ToString()
        {
            return $"First : {First} - Socend : {Socend}";
        }
    }
}
