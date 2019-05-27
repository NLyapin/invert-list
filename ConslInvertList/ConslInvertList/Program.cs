using System;
using System.Collections.Generic;

namespace ConslInvertList
{
    /// <summary>
    /// Методы для работы со связнным списком.
    /// </summary>
    public static class LinkedListExtentions
    {
        /// <summary>
        /// Вывод на консоль связного списка.
        /// </summary>
        /// <typeparam name="T">Тип значения, которое хранистся в списке.</typeparam>
        /// <param name="list">Связный список, который нужно вывести на консоль.</param>
        public static void PrintLinkedListToConsole<T>(this LinkedList<T> list)
        {
            foreach (var item in list)
            {
                Console.Write(item.ToString());
                Console.Write(";");
            }
            Console.WriteLine();
        }

        /// <summary>
        /// Инвертирование связного списка.
        /// </summary>
        /// <typeparam name="T">Тип значения, которое хранистся в списке.</typeparam>
        /// <param name="list">Связный список, который нужно инвертировать.</param>
        /// <returns>Сам связный список.</returns>
        public static LinkedList<T> InvertList<T>(this LinkedList<T> list)
        {
            var head = list.First;
            while (head.Next != null)
            {
                var next = head.Next;
                list.Remove(next);
                list.AddFirst(next.Value);
            }
            return list;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            LinkedList<string> list = new LinkedList<string>();
            var first = list.AddFirst("1");
            var second = list.AddAfter(first, "2");
            var third = list.AddAfter(second, "3");
            var fourth = list.AddAfter(third, "4");
            list.AddAfter(fourth, "5");

            list.PrintLinkedListToConsole();

            list.InvertList();

            list.PrintLinkedListToConsole();

            list.InvertList();

            list.PrintLinkedListToConsole();
        }
    }
}