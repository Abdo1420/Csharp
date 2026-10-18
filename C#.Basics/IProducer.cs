namespace C_.Basics
{
    internal interface IProducer<out T>
    {
        public T getName();
    }
}
