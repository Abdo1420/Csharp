
namespace C_.Basics
{
    public class Dog:Zoo ,IComparable
    {

        public string Name { get; set; }

        public Dog(string name)
        {
            Name = name;
        }

        public int CompareTo(object? obj)
        {
            throw new NotImplementedException();
        }
    }
}
