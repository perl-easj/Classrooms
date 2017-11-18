using System.Collections.Generic;

namespace ClassroomA
{
    public class Catalog<TKey, TDomain>
        where TDomain : DomainBase<TKey>
    {
        private Dictionary<TKey, TDomain> _items;

        public Catalog()
        {
            _items = new Dictionary<TKey, TDomain>();
        }

        public int Count
        {
            get { return _items.Count; }
        }

        public void Add(TDomain item)
        {
            _items.Add(item.Key, item);
        }

        public TDomain Lookup(TKey key)
        {
            return (_items.ContainsKey(key) ? _items[key] : null);
        }

        public void Delete(TKey key)
        {
            _items.Remove(key);
        }
    }
}