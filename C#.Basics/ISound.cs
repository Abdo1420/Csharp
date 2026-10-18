using System;
using System.Collections.Generic;
using System.Text;

namespace C_.Basics
{
    public interface ISound<in T>
    {
        public void setSound(T item);
    }
}
