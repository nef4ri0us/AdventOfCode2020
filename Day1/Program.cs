using System;
using System.IO;
using System.Collections.Generic;

namespace Day1
{
    class Program
    {
        static void Main(string[] args)
        {

            try
            {
                // Create an instance of StreamReader to read from a file.
                // The using statement also closes the StreamReader.
                using (StreamReader sr = new StreamReader("Data.txt"))
                {
                    //string line;
                    List<int> numbs = new List<int>();
                    List<int> numbs2 = new List<int>();

                    // Read and display lines from the file until the end of
                    while (sr.Peek() > -1)
                    {
                        int w = Convert.ToInt32(sr.ReadLine());
                        numbs.Add(w);
                    }

                    numbs.Sort();

                    numbs2 = numbs;
                    //int sum = 0;
                    foreach (int no in numbs)
                    {
                        foreach (int no2 in numbs2)
                        {

                            ///sum = no + no2;
                            //Console.WriteLine("{0} + {1} = {2}", no, no2, sum);        

                            if (no + no2 > 2020)
                            {
                                break;
                            }
                            else if (no + no2 == 2020)
                            {
                                int mult = no * no2;
                                //Console.WriteLine("{0} * {1}  = {2]", no, no2, mult );
                                Console.WriteLine(mult);
                                //Console.ReadLine();
                                goto JumpHere1;

                            }
                        }

                    }

                JumpHere1:

                    List<int> numbs3 = new List<int>();
                    numbs3 = numbs;
                    //int sum = 0;
                    foreach (int no in numbs)
                    {
                        foreach (int no2 in numbs2)
                        {
                            foreach (int no3 in numbs3)
                            {

                                ///sum = no + no2;
                                //Console.WriteLine("{0} + {1} = {2}", no, no2, sum);        

                                if (no + no2 + no3 > 2020)
                                {
                                    break;
                                }
                                else if (no + no2 + no3 == 2020)
                                {
                                    int mult = no * no2 * no3;
                                    //Console.WriteLine("{0} * {1}  = {2]", no, no2, mult );
                                    Console.WriteLine(mult);
                                    //Console.ReadLine();
                                    Environment.Exit(0);

                                }
                            }

                        }

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
