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
        public SingleLinkedList(SingleLinkedNode<T> node)
        {
            count = 1;
            head = node;
            tail = node;
        }

        public void Add(T data)
        {
            SingleLinkedNode<T> node = new SingleLinkedNode<T>(data);
            if (count == 0)
            {
                head = node;
                tail = node;
            }
            else
            {
                tail.Next = node;
                tail = node;
            }
            count++;
        }

        public T Remove(int index)
        {
            if (index < 0 || index >= count)
            {
                throw new IndexOutOfRangeException("Invalid index");
            }
            T temp = head.Data;
            if (count == 1) //when there is only one element
            {
                head = null;
                tail = null;
                count = 0;
                return temp;
            }
            if (index == 0) //remove head
            {
                head = head.Next;
                count--;
                return temp;
            }
            if (index == count - 1) //remove tail
            {
                temp = tail.Data;
                tail = GetNode(count - 2);
                count--;
                return temp;
            }
            SingleLinkedNode<T> before = GetNode(index - 1);
            temp = before.Next.Data;
            before.Next = before.Next.Next;
            count--;
            return temp;
        }

        public T GetData(int index)
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
        public SingleLinkedNode<T> GetNode(int index)
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
            return current;
        }

        public void Clear()
        {
            head = null;
            tail = null;
            count = 0;
        }

        public SingleLinkedNode<T> this[int index]
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
                return current;
            }
            set
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
                current = value;
            }
        }

        public int Count { get { return count; } }
    }
}
