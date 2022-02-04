using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Self_Stack
{
    public class Stack<T> : LinkedList<T>
    {

        public void Push(T x)
        {
            Add(x);
        }

        public T Pop()
        {
            if (_tail == null)
            {
                return default(T);
            }
            var top = _tail.Value;
            Remove(top);
            return top;
        }

        public T Top()
        {
            if (_tail == null)
            {
                return default(T);
            }
            return _tail.Value;
        }
    }
}
