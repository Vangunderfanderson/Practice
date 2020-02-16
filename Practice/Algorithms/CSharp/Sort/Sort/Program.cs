using Classes.MessageWriter;
using System;
using System.Collections.Generic;

namespace Sort
{
    class Program
    {
        static void Main(string[] args)
        {
            var writer = new ConsoleMessageWriter();
            var sorter = new QuickSort<int>();

            var array = new[] { 1, 9, 2, 8, 7, 6, 4 };
            writer.WriteMessage($"Unsorted array: {string.Join(", ", array)}");
            writer.WriteMessage($"Sorted array (algorithm = {sorter.Name}): {string.Join(", ", sorter.Sort(array))}");
        }
    }
}
