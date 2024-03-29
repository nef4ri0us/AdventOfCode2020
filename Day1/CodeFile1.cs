﻿using System;
using System.IO;
using System.Collections.Generic;

namespace Day1
{
    class Program2
    {
        static void test(string[] args)
        {



            try
            {
                // Create an instance of StreamReader to read from a file.
                // The using statement also closes the StreamReader.
                using (StreamReader sr = new StreamReader("TestData.txt"))
                {
                    string line;
                    List<int> numbs = new List<int>();
                    List<int> numbs2 = new List<int>();

                    // Read and display lines from the file until the end of
                    // the file is reached.
                    while ((line = sr.ReadLine()) != null)
                    {
                        int w = Convert.ToInt32(sr.ReadLine());
                        numbs.Add(w);
                    }


                    int countno = 0;
                    foreach (int nono in numbs)
                    {

                        Console.WriteLine(countno);
                        countno++;
                    }

                    numbs.Sort();

                    foreach (int no in numbs)
                    {
                        Console.WriteLine(no);
                    }
                }

            }
            catch (Exception e)
            {
                // Let the user know what went wrong.
                Console.WriteLine("The file could not be read:");
                Console.WriteLine(e.Message);
            }
        }

        //    // Example #1
        //    // Read the file as one string.
        //    string text = System.IO.File.ReadAllText(@"C:\Users\ujs160\source\repos\nef4ri0us\AdventOfCode2020\Day1\Data.txt");
        //        text = Array.sort(text);

        //        // Display the file contents to the console. Variable text is a string.
        //        System.Console.WriteLine("Contents of Data.txt = {0}", text);

        //        // Example #2
        //        // Read each line of the file into a string array. Each element
        //        // of the array is one line of the file.
        //        //string[] lines = System.IO.File.ReadAllLines(@"C:\Users\Public\TestFolder\WriteLines2.txt");

        //        // Display the file contents by using a foreach loop.
        //        //System.Console.WriteLine("Contents of WriteLines2.txt = ");
        //        //foreach (string line in lines)
        //        //{
        //        //    // Use a tab to indent each line of the file.
        //        //    Console.WriteLine("\t" + line);
        //        //}

        //        // Keep the console window open in debug mode.
        //        Console.WriteLine("Press any key to exit.");
        //        System.Console.ReadKey();
        //    }
        //}
    }
}
