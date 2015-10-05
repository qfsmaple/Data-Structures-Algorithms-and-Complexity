using System;
using System.Collections.Generic;
using System.Linq;

namespace Recursion_Homework
{
    class TowerOfHanoi
    {
        static Stack<int> source = new Stack<int>(Enumerable.Range(1, 3).Reverse());
        static Stack<int> destination = new Stack<int>();
        static Stack<int> spare = new Stack<int>();
        static int steps = 0;

        static void Main()
        {
            int bottomDisk = 3;//int.Parse(Console.ReadLine());
            Print();
            MoveDisks(bottomDisk, source, destination, spare);
            Console.WriteLine(new String('-', 20));
            Print();            
        }

        private static void Print()
        {
            Console.WriteLine("Steps taken: {0}", steps);
            Console.WriteLine("Source: " + string.Join(", ", source));
            Console.WriteLine("Destination: " + string.Join(", ", destination));
            Console.WriteLine("Spare: " + string.Join(", ", spare));
        }

        private static void MoveDisks(int bottomDisk, Stack<int> source, Stack<int> destination, Stack<int> spare)
        {
            steps++;

            if (bottomDisk == 1)
            {
                destination.Push(source.Pop());
            }
            else
            {
                MoveDisks(bottomDisk - 1, source, spare, destination);
                destination.Push(source.Pop());
                MoveDisks(bottomDisk - 1, spare, destination, source);
            }
        }
    }
}
