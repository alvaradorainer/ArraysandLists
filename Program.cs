using System;
using System.Collections.Generic;

namespace ArraysAndLists
{
    class Program
    {
        static void Main(string[] args)
        {
            //TODO:

            // Create an int Array and populate numbers 1-10

            //Create two Lists of type int.
            //* Name one List "evens"
            var evens = new List<int>();
            //* Name the other List "odds"
            var odds = new List<int>();

            //Using either a foreach or for loop,
            //* nest an if statement to check to see
            //*  if a number is even or odd.
            //* Then add those numbers to either the evens List
            //* or the odds List

            for (int i = 0; i <= 10; i++)
            {
                if(i % 2 != 0)
                {
                    odds.Add(i);
                } 
                else
                {
                    evens.Add(i);
                }
            }

            //Now using foeach or for loops,
            //* display each List of even and odd numbers
            //*
            //* Try to be creative in your display

            Console.WriteLine("--------List of Even Numbers-----------");

            foreach (var num in evens)
            {
                Console.WriteLine(num);
            }

            Console.WriteLine("----------List of Odd Numbers-----------");

            foreach (var num in odds)
            {
                Console.WriteLine(num);
            }

        }
    }
}
