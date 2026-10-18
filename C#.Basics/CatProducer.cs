
namespace C_.Basics
{
    internal class CatProducer : IProducer<Cat>
    {
        public Cat getName()
        {
            return new Cat("max", "meow");
        }
    }
}
