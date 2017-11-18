using System.Collections.Generic;

namespace ClassroomA
{
    public class DVDCatalog
    {
        private Dictionary<int, DVD> _dvds;

        public DVDCatalog()
        {
            _dvds = new Dictionary<int, DVD>();
        }

        public int Count
        {
            get { return _dvds.Count; }
        }

        public void AddDVD(DVD aDVD)
        {
            _dvds.Add(aDVD.ID, aDVD);
        }

        public DVD LookupDVD(int id)
        {
            return (_dvds.ContainsKey(id) ? _dvds[id] : null);
        }

        public void DeleteDVD(int id)
        {
            _dvds.Remove(id);
        }
    }
}