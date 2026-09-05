using System;
using System.Collections.Generic;
using System.Text;
using static System.Console;

namespace C_.Basics
{
    internal class Book
    {
        public string Title;
        public int Pages =0;
        public override string ToString()
        {
            return $"Title= {Title}, Pages= {Pages}";
        }
    }
}
