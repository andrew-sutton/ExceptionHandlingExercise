﻿using System;
using System.Collections.Generic;
using System.IO;

namespace ExceptionHandlingExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            // -----------------------------------------------------------------------------
            // First create an char[], it must contain 6 numbers and 3 letters - name it arr
            // Create a list called numbers that will hold integers
            // Create an string variable with an empty string initializer - name it str

            // using a foreach loop, attempt to parse the elements in your char[] with int.Parse()
            // and Exceptions will be thrown 
            // Below we will set this up 
            // ------------------------------------------------------------------------------
            var arr = new char[] { '5', 't', '8', '3', 'f', '2', '0', 'e', '4' };
            var numbers = new List<int>();
            var str = "";



            //TODO START HERE:

            // Make a foreach loop to iterate through your character array
            foreach (var character in arr)
            {
                // Now create a try catch
                try
                {
                    // Inside your try block
                    // set your string variable to each array element in your char[] to .ToString()
                    // Now, using int.Parse, parse your string variable and store in an int variable
                    // Then add each int to your list
                    str = character.ToString();
                    numbers.Add(int.Parse(str));
                }
                // catch your Exception: 
                catch(Exception e)
                {
                    Console.WriteLine($"Unable to Parse '{character}'"); //character will be the name of each item in your collection
                }
            }
            foreach (var num in numbers)
            {
                Console.WriteLine(num);
            }
        }
    }
}
