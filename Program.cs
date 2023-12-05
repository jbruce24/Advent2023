using System;
using System.IO;

namespace Advent
{ 
    public class Day1
    {
        public static void Run()
        {
            string line;
            try
            {
                StreamReader sr = new StreamReader("C:\\Users\\Jared\\sourceP\\repos\\AdventOfCode23\\Files\\day1.txt");
                StreamWriter sw = new StreamWriter("C:\\Users\\Jared\\sourceP\\repos\\AdventOfCode23\\Files\\day1Output.txt");
                line = sr.ReadLine();
                while (line != null)
                {
                    Console.WriteLine(line);
                    sw.WriteLine(line + "\n");
                    sw.Close();
                    line = sr.ReadLine();
                }
            }
            catch(Exception e)
            {
                Console.WriteLine("Exception: " + e.Message);
            }
            finally
            {
                Console.WriteLine("Hello 2");
            }
        }
    }
}