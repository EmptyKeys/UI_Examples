using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameUILibrary
{
    public class CircularQueue<T> : IEnumerable<T>, ICollection, IEnumerable
    {
        private Queue<T> _queue;

        /// <summary>
        /// Gets the number of elements contained in the <see cref="T:System.Collections.ICollection" />.
        /// </summary>
        public int Count
        {
            get
            {
                return this._queue.Count;
            }
        }

        /// <summary>
        /// Gets a value indicating whether access to the <see cref="T:System.Collections.ICollection" /> is synchronized (thread safe).
        /// </summary>
        public bool IsSynchronized
        {
            get
            {
                return false;
            }
        }

        /// <summary>
        /// Gets an object that can be used to synchronize access to the <see cref="T:System.Collections.ICollection" />.
        /// </summary>
        public object SyncRoot
        {
            get
            {
                return this;
            }
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CircularQueue{T}"/> class.
        /// </summary>
        public CircularQueue()
        {
            this._queue = new Queue<T>();
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CircularQueue{T}"/> class.
        /// </summary>
        /// <param name="capacity">The capacity.</param>
        public CircularQueue(int capacity)
        {
            this._queue = new Queue<T>(capacity);
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CircularQueue{T}"/> class.
        /// </summary>
        /// <param name="collection">The collection.</param>
        public CircularQueue(IEnumerable<T> collection)
        {
            this._queue = new Queue<T>(collection);
        }

        /// <summary>
        /// Clears this instance.
        /// </summary>
        public void Clear()
        {
            this._queue.Clear();
        }

        /// <summary>
        /// Determines whether [contains] [the specified item].
        /// </summary>
        /// <param name="item">The item.</param>
        /// <returns></returns>
        public bool Contains(T item)
        {
            return this._queue.Contains(item);
        }

        /// <summary>
        /// Dequeues this instance.
        /// </summary>
        /// <returns></returns>
        public T Dequeue()
        {
            T result;
            if (this._queue.Count == 0)
            {
                result = default(T);
            }
            else
            {
                T item = this._queue.Dequeue();
                this._queue.Enqueue(item);
                result = item;
            }
            return result;
        }

        /// <summary>
        /// Enqueues the specified item.
        /// </summary>
        /// <param name="item">The item.</param>
        public void Enqueue(T item)
        {
            this._queue.Enqueue(item);
        }

        /// <summary>
        /// Peeks this instance.
        /// </summary>
        /// <returns></returns>
        public T Peek()
        {
            return this._queue.Peek();
        }

        /// <summary>
        /// To the array.
        /// </summary>
        /// <returns></returns>
        public T[] ToArray()
        {
            return this._queue.ToArray();
        }

        /// <summary>
        /// Returns an enumerator that iterates through the collection.
        /// </summary>
        /// <returns>
        /// A <see cref="T:System.Collections.Generic.IEnumerator`1" /> that can be used to iterate through the collection.
        /// </returns>
        public IEnumerator<T> GetEnumerator()
        {
            return this._queue.GetEnumerator();
        }

        /// <summary>
        /// Returns an enumerator that iterates through a collection.
        /// </summary>
        /// <returns>
        /// An <see cref="T:System.Collections.IEnumerator" /> object that can be used to iterate through the collection.
        /// </returns>
        IEnumerator IEnumerable.GetEnumerator()
        {
            return this._queue.GetEnumerator();
        }

        /// <summary>
        /// Copies the elements of the <see cref="T:System.Collections.ICollection" /> to an <see cref="T:System.Array" />, starting at a particular <see cref="T:System.Array" /> index.
        /// </summary>
        /// <param name="array">The one-dimensional <see cref="T:System.Array" /> that is the destination of the elements copied from <see cref="T:System.Collections.ICollection" />. The <see cref="T:System.Array" /> must have zero-based indexing.</param>
        /// <param name="index">The zero-based index in <paramref name="array" /> at which copying begins.</param>
        public void CopyTo(Array array, int index)
        {
            int bound;
            if ((bound = this._queue.Count) > 0)
            {
                T[] sourceArray = this._queue.ToArray();
                for (int i = index; i < bound; i++)
                {
                    array.SetValue(sourceArray[i], i - index);
                }
            }
        }
    }
}
