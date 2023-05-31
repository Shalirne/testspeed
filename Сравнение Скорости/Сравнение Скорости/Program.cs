using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;

namespace Сравнение_Скорости
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SpeedList();
            SpeedArreyList();
            SpeedLinkedList();

        }

        private static void SpeedList()
        {
            Stopwatch TimeList = new Stopwatch();
            Stopwatch Time496753 = new Stopwatch();
            Stopwatch Time777 = new Stopwatch();

            var TestList = new List<int>(1000000);
            TimeList.Start();
            for (int i = 0; 1000000 > i; i++)
            {
                TestList.Add(i);
            }
            TimeList.Stop();
            Console.WriteLine($"Скорость List равняется = {TimeList.Elapsed.Milliseconds} миллисекунды");

            Time496753.Start();
            TestList.IndexOf(496753);
            Time496753.Stop();
            Console.WriteLine($"Скорость поиска 496753 в List равняется = {Time496753.Elapsed.Milliseconds} миллисекунды");

            Time777.Start();
            foreach(int i in TestList)
            {
                if (i%777 == 0)
                {
                    Console.WriteLine(i);
                }
            }    
            Time777.Stop();
            Console.WriteLine($"Скорость поиска деления без остатка на 777 в List равняется = {Time777.Elapsed.Milliseconds} миллисекунды");

        }
        private static void SpeedArreyList()
        {
            Stopwatch TimeList = new Stopwatch();
            Stopwatch Time496753 = new Stopwatch();
            Stopwatch Time777 = new Stopwatch();

            var TestArreyList = new ArrayList(1000000);
            TimeList.Start();
            for (int i = 0; 1000000 > i; i++)
            {
                TestArreyList.Add(i);
            }
            TimeList.Stop();
            Console.WriteLine($"Скорость ArrayList равняется = {TimeList.Elapsed.Milliseconds} миллисекунды");

            Time496753.Start();
            TestArreyList.IndexOf(496753);
            Time496753.Stop();
            Console.WriteLine($"Скорость поиска 496753 в ArrayList равняется = {Time496753.Elapsed.Milliseconds} миллисекунды");

            Time777.Start();
            foreach (int i in TestArreyList)
            {
                if (i % 777 == 0)
                {
                    Console.WriteLine(i);
                }
            }
            Time777.Stop();
            Console.WriteLine($"Скорость поиска деления без остатка на 777 в ArrayList равняется = {Time777.Elapsed.Milliseconds} миллисекунды");
        }

        private static void SpeedLinkedList()
        {
            Stopwatch TimeList = new Stopwatch();
            Stopwatch Time496753 = new Stopwatch();
            Stopwatch Time777 = new Stopwatch();

            var TestLinkedList = new LinkedList<int> ();
            TimeList.Start();
            for (int i = 0; 1000000 > i; i++)
            {
                TestLinkedList.AddFirst(i);
            }
            TimeList.Stop();
            Console.WriteLine($"Скорость LinkedList равняется = {TimeList.Elapsed.Milliseconds} миллисекунды");

            Time496753.Start();
            TestLinkedList.ElementAt(496753);
            Time496753.Stop();
            Console.WriteLine($"Скорость поиска 496753 в LinkedList равняется = {Time496753.Elapsed.Milliseconds} миллисекунды");

            Time777.Start();
            foreach (int i in TestLinkedList)
            {
                if (i % 777 == 0)
                {
                    Console.WriteLine(i);
                }
            }
            Time777.Stop();
            Console.WriteLine($"Скорость поиска деления без остатка на 777 в LinkedList равняется = {Time777.Elapsed.Milliseconds} миллисекунды");
        }
    }
}