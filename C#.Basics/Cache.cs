namespace C_.Basics
{
    public class Cache<TKey, TValue>
    {
        #region properts
        private readonly Dictionary<TKey?, Pair<TValue, DateTime>> Storage;
        #endregion
        #region conestractor
        public Cache()
        {
            Storage = new Dictionary<TKey, Pair<TValue, DateTime>>();
        }
        #endregion
        #region Methohds
        public void Add(TKey key, TValue value, DateTime ex)
        {
            Storage[key]= new Pair<TValue, DateTime>(value, ex);
        }
        public TValue getValue(TKey key)
        {
            
            if (Storage.ContainsKey(key))
            {
                var value = Storage[key];
                if (value.getSocend() <= DateTime.Now)
                {
                    Console.WriteLine("The key is Expiard!!");
                    return default!;
                }
                return value.getFirst();
            }
            return default!;
        }
        public void Remove(TKey key)
        {
            if(Storage.ContainsKey(key))
                Storage.Remove(key);
            else
                Console.WriteLine("The key not found!!");
        }
        public bool Contains(TKey key)
        {
            if (Storage.ContainsKey(key))
            {
                var expaird = Storage[key];
                if(expaird.getSocend()<= DateTime.Now)
                {
                    Storage.Remove(key);
                    Console.WriteLine($"The vlaue {expaird.getFirst()} is expaierd!!");
                    return false;
                }
                return true;
            }
            return false;
        }

        #endregion


    }
}
