
namespace C_.Basics
{
    public class Container<T>where T:class
    {
        private T item;
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
