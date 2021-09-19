using System;
using System.Linq;
using System.Collections.Generic;
using GenMo.Domain.Crossovers;

namespace SampleGenMoProject1
{
    class Program
    {
        static void Main(string[] args)
        {
            var parentA = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            var parentB = new List<int>() { 3, 5, 2, 1, 8, 7, 6, 9, 4 };

            var result = new OnePointCrossover()
                .Breed(parentA, parentB);

            foreach (var item in result.Item1)
            {
                Console.Write($" {item}");
            }

            Console.WriteLine();

            foreach (var item in result.Item2)
            {
                Console.Write($" {item}");
            }
        }
    }
}
