using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomLinkedLists
{
    class CustomLinkedNode<T>
    {
        private T data;
        private CustomLinkedNode<T> next;

        public CustomLinkedNode(T data)
        {
            this.data = data;
            next = null;
        }

        public CustomLinkedNode(T data, CustomLinkedNode<T> next)
        {
            this.data = data;
            this.next = next;
        }

        public T Data
        {
            get
            {
                return data;
            }
        }

        public CustomLinkedNode<T> Next
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

