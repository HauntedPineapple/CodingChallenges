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

        }

        void Add(T data)
        {

        }

        T GetData(int index)
        {
            if (index < 0 || index > count)
            {
                throw new ArgumentOutOfRangeException();
            }
            return head.Data;
        }
    }
}
