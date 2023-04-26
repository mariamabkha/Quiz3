using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomQueue
{
    public class CustomQueue<T>
    {
        private List<T> _queue = new List<T>();

        public CustomQueue()
        {
        }

        public CustomQueue(int capacity)
        {
            if (capacity < 0)
                throw new ArgumentOutOfRangeException(nameof(capacity), "cant be negative");

            _queue = new List<T>(capacity);

        }

        //adds an item 
        public void Enqueue(T item)
        {
            _queue.Add(item);
        }

        // removes and returns the item from the front of the queue
        public T Dequeue()
        {
            if (_queue.Count == 0)
                throw new InvalidOperationException("Queue is empty");

            T item = _queue[0];
            _queue.RemoveAt(0);
            return item;
        }

        public int Count
        {
            get { return _queue.Count; }
        }

        public void Clear()
        {
            _queue.Clear();
        }

        //returns the item from the front of the queue without removing it
        public T Peek()
        {
            if (_queue.Count == 0)
                throw new InvalidOperationException("Queue is empty ");

            return _queue[0];
        }

    
    }

}
