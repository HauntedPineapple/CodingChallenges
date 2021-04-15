using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomLinkedLists
{
    class CustomLinkedList<T>
    {
        private int count;
        private CustomLinkedNode<T> head;
        private CustomLinkedNode<T> tail;

        public int Count { get { return count; } }

        public T this[int index] //indexer
        {
            get
            {
                if (index < 0 || index >= count)
                {
                    throw new IndexOutOfRangeException("Invalid index");
                }
                CustomLinkedNode<T> current = head;
                for (int a = 0; a < count - 1; a++)
                { // loop until we're at the index
                    current = current.Next;
                }
                return current.Data;
            }
        }

        public CustomLinkedList()
        {
            count = 0;
            head = null;
            tail = null;
        }

        public void Add(T data)
        {
            CustomLinkedNode<T> n = new CustomLinkedNode<T>(data);
            // determine if the list is empty
            // or has a bunch of nodes already
            if (count == 0)
            {
                head = n;
                tail = n;
            }
            else
            {
                tail.Next = n;
                tail = n;
            }
            count++;
        }

        public void Remove(int index)
        {
            if (index < 0 || index >= count)
            {
                throw new IndexOutOfRangeException("ERROR: Invalid index specified. No object exists for index " + index + "!");
            }
            if (index == 0)
            {
                head = head.Next;
            }
            if (index == count - 1)
            {
                tail = GetNode(count - 2);
            }
            if (count == 1)
            {
                head = null;
                tail = null;
            }
            else
            {
                CustomLinkedNode<T> before = GetNode(index - 1);
                before.Next = before.Next.Next;
                count--;
            }
        }

        public T GetData(int index)
        {
            CustomLinkedNode<T> current = head;
            for (int a = 0; a < index; a++)
            {
                current = current.Next;
            }
            return current.Data;
        }

        public CustomLinkedNode<T> GetNode(int index)
        {
            if (index < 0 || index >= count)
            {
                throw new IndexOutOfRangeException("Invalid index");
            }
            CustomLinkedNode<T> current = head;
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
    }
}
