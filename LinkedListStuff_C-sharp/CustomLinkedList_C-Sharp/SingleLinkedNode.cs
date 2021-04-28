using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomLinkedList_C_Sharp
{
    class SingleLinkedNode<T>
    {
        private T data;
        private SingleLinkedNode<T> next;

        public SingleLinkedNode(T data)
        {
            this.data = data;
            next = null;
        }
        public SingleLinkedNode(T data, SingleLinkedNode<T> next)
        {
            this.data = data;
            this.next = next;
        }

        public T Data { get { return data; } }
        public SingleLinkedNode<T> Next
        {
            get
            {
                return next;
            }
            set
            {
                next = value;
            }
        }
    }
}
