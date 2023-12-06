using System;
using System.IO;
using System.Runtime.CompilerServices;

namespace Advent
{ 
    public class Day1
    {
        public static void Run()
        {
            string line;
            int num;
            int total = 0;
            int i = 0;
            StreamReader sr = new StreamReader("C:\\Users\\Jared\\sourceP\\repos\\AdventOfCode23\\Files\\day1.txt");
            StreamWriter sw = new StreamWriter("C:\\Users\\Jared\\sourceP\\repos\\AdventOfCode23\\Files\\day1Output.txt");

            try
            {
               
                line = sr.ReadLine();
                while (line != null)
                {
                    List<int> nums = new List<int>();
                    line = new String(line.Where(Char.IsDigit).ToArray());
                    int length = line.Length;
                    foreach (char c in line)
                    {
                        int c1 = (int)char.GetNumericValue(c);
                        nums.Add(c1);
                    }
                    int newNum1 = nums[0];
                    int newNum2 = nums[line.Length - 1];
                    string conNum = Convert.ToString(newNum1) + Convert.ToString(newNum2);
                    int totalNum = Int32.Parse(conNum);
                    total = (totalNum + total);
                    //sw.WriteLine("ConNum = " + conNum + "\n");
                    sw.Write("Row = " + i + " Total = " + total + "\n");
                    Console.Write(total);
                    line = sr.ReadLine();
                    i++;
                    Console.WriteLine(i);
                }
            }
            catch(Exception e)
            {
                Console.WriteLine("Exception: " + e.Message);
            }
            finally
            {
                sw.WriteLine("Total = " + total);
            }
        }
    }
}