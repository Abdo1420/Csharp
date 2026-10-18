
namespace C_.Basics
{
    public class SafeList<T>
    {
        public SafeList(List<T> myList)
        {
            MyList = myList;
        }

        private List<T> MyList { get; set; }
        public T getList()
        {
            if (MyList.Count == 0)
            {
                return default;
            }
            

            return MyList[0];
        }
    }
}
