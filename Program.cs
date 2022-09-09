using System;
using System.Collections.Generic;

namespace Practice2
{
    class Program
    {
        static void Main(string[] args)
        {


            int a = 10;
            // in some cases we need to store marks of a student it is not possible to store it in int variable 
            // in that case we will go for arrays 
            // arrays will store collection of similar data type

            // negatives
            // arrays are fixed in size
            //int[] marks = new int[5] { 1,2,4,5,6 };
            //marks[0] = 1;


            //Console.WriteLine(marks[4]);

            //for (int i = 0; i < marks.Length; i++)
            //{
            //    Console.WriteLine(marks[i]);
            //    Console.WriteLine("for loop");

            //}


            //foreach (int mark in marks)
            //{
            //    Console.WriteLine(mark);
            //    Console.WriteLine("foreach loop");


            //}

            //string[] cars = { "Volvo", "BMW", "Ford", "Mazda", "Swift", "Skoda" };
            //Console.WriteLine(cars[5]);

            // List
            // List also used to store similar data type values like array
            // but it is dynamic in size not fixed like array

            List<int> lst = new List<int>() { };
            lst.Add(1);
            lst.Add(2);

           

            foreach(var l in lst)
            {
                Console.WriteLine(l);
            }

            Console.ReadLine();

        }
    }
}
