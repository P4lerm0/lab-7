﻿using System;

namespace lab7.part2
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = ",?.;:'";
            Console.WriteLine("Количество знаков препинания в строке = " + str.Count(char.IsPunctuation));
        }
    }
}