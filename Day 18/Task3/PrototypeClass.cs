using System.Collections;
using System.Collections.Generic;

namespace Task3
{
    public class PrototypeClass<T> : IEnumerable<T>
    {
        private List<T> items = new List<T>();

        public void Add(T item)
        {
            items.Add(item);
        }

        public bool Remove(T item)
        {
            return items.Remove(item);
        }

        public PrototypeClass<T> Clone()
        {
            var clone = new PrototypeClass<T>();
            foreach (var item in items)
            {
                clone.Add(item);
            }
            return clone;
        }

        public IEnumerator<T> GetEnumerator()
        {
            return items.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
