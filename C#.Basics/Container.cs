
using System.Diagnostics.Metrics;

namespace C_.Basics
{
    public class Container<T>
    {
        private T item;
        public static int counter=0;
        public Container(T item)
        {
            this.item = item;
        }

        public void Add(T item)
        {
            this.item = item;
        }
        public T Get()
        {
            return item;
        }
    }
}
