using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomLinkedList_C_Sharp
{
    class SingleLinkedList<T>
    {
        private int count;
        private SingleLinkedNode<T> head, tail;

        public SingleLinkedList()
        {
            count = 0;
            head = null;
            tail = null;
        }

        void Add(T data)
        {
            count++;
        }

        public T this[int index]
        {
            get
            {
                if (index < 0 || index >= count)
                {
                    throw new IndexOutOfRangeException("Invalid index");
                }
                SingleLinkedNode<T> current = head;
                for (int a = 0; a < count - 1; a++)
                { // loop until we're at the index
                    current = current.Next;
                }
                return current.Data;
            }
            set
            {
                if (index < 0 || index > count)
                {
                    throw new ArgumentOutOfRangeException();
                }
            }
        }
    }
}
