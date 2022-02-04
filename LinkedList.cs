using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Self_Stack
{
    public class LinkedList<T> : IEnumerable<T>
    {
        private Node<T> _head;
        protected Node<T> _tail;
        private int _count;
        
        public int Count => _count;

        public void Add(T value)
        {
            var node = new Node<T>(value);
            if (_head == null)
            {
                _head = node;
            }
            else
            {
                _tail.Next = node;
            }
            _tail = node;
            _count++;
        }

        public void Remove(T value)
        {
            var current = _head;
            Node<T> previous = null;
            while (current != null)
            {
                if (current.Value.Equals(value))
                {
                    if (previous != null)
                    {
                        previous.Next = current.Next;
                        if (current.Next == null)
                        {
                            _tail = previous;
                        }
                    }
                    else
                    {
                        _head = _head.Next;
                        if (_head == null)
                        {
                            _tail = null;
                        }
                    }
                    _count--;
                    break;
                }
                previous = current;
                current = current.Next;
            }
        }

        public void Clear()
        {
            _count = 0;
            _head = null;
            _tail = null;
        }

        public IEnumerator<T> GetEnumerator()
        {
            var current = _head;
            while (current != null)
            {
                yield return current.Value;
                current = current.Next;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {

            return ((IEnumerable)this).GetEnumerator();
        }
    }
}
