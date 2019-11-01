/*
 * Author: Ryan Kueter
 * Copyright 2019 Ryan Kueter.
 */
using System;

namespace AbstractClasses
{
    class Program
    {
        static void Main(string[] args)
        {
            var p = new Programmer("Ryan", "Kueter", 39);
            Console.WriteLine(p.GetAge());
            Console.ReadKey();
        }
    }
}
