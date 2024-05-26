using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FeatureManager.Core.Protections
{
    public class ApplicationList<T> : ICollection<T>, IEnumerable<T>, IEnumerable, IList<T>, IReadOnlyCollection<T>, IReadOnlyList<T>, ICollection, IList
    {
        private readonly List<T> list;

        public ApplicationList()
        {
            list = [];
        }

        public ApplicationList(int capacity)
        {
            list = new List<T>(capacity);
        }

        public ApplicationList(IEnumerable<T> collection)
        {
            list = new List<T>(collection);
        }

        public ApplicationList(params T[] collection)
        {
            list = new List<T>(collection);
        }

        public T this[int index] { get => list[index]; set => list[index] = value; }
        object? IList.this[int index] { get => ((IList)list)[index]; set => ((IList)list)[index] = value; }

        public int Count => list.Count;

        public bool IsReadOnly => ((IList)list).IsReadOnly;

        public bool IsFixedSize => ((IList)list).IsFixedSize;

        public bool IsSynchronized => ((ICollection)list).IsSynchronized;

        public object SyncRoot => ((ICollection)list).SyncRoot;

        public virtual void Add(T item)
        {
            list.Add(item);
        }

        public virtual int Add(object? value)
        {
            return ((IList)list).Add(value);
        }

        public void Clear()
        {
            list.Clear();
        }

        public bool Contains(T item)
        {
            return list.Contains(item);
        }

        public bool Contains(object? value)
        {
            return ((IList)list).Contains(value);
        }

        public void CopyTo(T[] array, int arrayIndex)
        {
            list.CopyTo(array, arrayIndex);
        }

        public void CopyTo(Array array, int index)
        {
            ((ICollection)list).CopyTo(array, index);
        }

        public IEnumerator<T> GetEnumerator()
        {
            return ((IEnumerable<T>)list).GetEnumerator();
        }

        public int IndexOf(T item)
        {
            return list.IndexOf(item);
        }

        public int IndexOf(object? value)
        {
            return ((IList)list).IndexOf(value);
        }

        public virtual void Insert(int index, T item)
        {
            list.Insert(index, item);
        }

        public virtual void Insert(int index, object? value)
        {
            ((IList)list).Insert(index, value);
        }

        public virtual bool Remove(T item)
        {
            return list.Remove(item);
        }

        public virtual void Remove(object? value)
        {
            ((IList)list).Remove(value);
        }

        public virtual void RemoveAt(int index)
        {
            list.RemoveAt(index);
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return ((IEnumerable)list).GetEnumerator();
        }
    }
}
