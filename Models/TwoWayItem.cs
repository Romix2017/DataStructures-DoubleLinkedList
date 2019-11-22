using System;

namespace DoubleLinkedList.Models
{

    public class TwoWayItem<T>
    {
        public T Data { get; set; }
        public TwoWayItem<T> Previous { get; set; }

        public TwoWayItem<T> Next { get; set; }

        public TwoWayItem()
        {

        }
        public TwoWayItem(T data)
        {
            Data = data;
        }

        public override string ToString()
        {
            return Data.ToString();
        }
    }
}