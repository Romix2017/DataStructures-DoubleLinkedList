using System;
using System.Collections;
using DoubleLinkedList.Models;

namespace DoubleLinkedList
{
    class Program
    {
        static void Main(string[] args)
        {
            var doubleLinkedList = new DoubleLinkedList<int>();
            doubleLinkedList.Add(1);
            doubleLinkedList.Add(2);
            doubleLinkedList.Add(3);
            doubleLinkedList.Add(4);
            doubleLinkedList.Add(5);
            doubleLinkedList.Add(6);
            ShowResult(doubleLinkedList);

            doubleLinkedList.Delete(3);
            ShowResult(doubleLinkedList);

            var reverse = doubleLinkedList.Reverse();
            ShowResult(reverse);

            var circularList = new CircularLinkedList<int>();
            circularList.Add(1);
            circularList.Add(2);
            circularList.Add(3);
            circularList.Add(4);
            circularList.Add(5);
            circularList.Add(6);
            ShowResult(circularList);

            circularList.Delete(6);
            ShowResult(circularList);

            Console.ReadLine();
        }

        private static void ShowResult(IEnumerable data)
        {
            foreach (var item in data)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();
        }
    }
}
