using System;
using System.Collections;
using System.Collections.Generic;

namespace DoubleLinkedList.Models
{

    public class DoubleLinkedList<T> : IEnumerable<T>
    {

        public TwoWayItem<T> Head { get; set; }
        public TwoWayItem<T> Tail { get; set; }

        public int Count { get; set; }

        public DoubleLinkedList() { }

        public DoubleLinkedList(T data)
        {
            var item = new TwoWayItem<T>(data);
            Head = item;
            Tail = item;
            Count = 1;
        }

        public void Add(T data)
        {
            var item = new TwoWayItem<T>(data);

            if (Count == 0)
            {
                Head = item;
                Tail = item;
                Count = 1;
                return;
            }

            Tail.Next = item;
            item.Previous = Tail;
            Tail = item;
            Count++;
        }

        public void Delete(T data)
        {
            var current = Head;

            while (current != null)
            {
                if (current.Data.Equals(data))
                {
                    current.Previous.Next = current.Next;
                    current.Next.Previous = current.Previous;
                    Count--;
                    return;
                }

                current = current.Next;
            }
        }
        public DoubleLinkedList<T> Reverse()
        {
            var result = new DoubleLinkedList<T>();
            var current = Tail;

            while (current != null)
            {
                result.Add(current.Data);
                current = current.Previous;
            }
            return result;
        }
        public IEnumerator GetEnumerator()
        {
            var current = Head;

            while (current != null)
            {
                yield return current;
                current = current.Next;
            }
        }
        IEnumerator<T> IEnumerable<T>.GetEnumerator()
        {
            return (IEnumerator<T>)GetEnumerator();
        }
    }

}