using System;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;

namespace Advent
{ 
    public class Day1
    {
        public static void Run()
        {
            string line;
            int total = 0;
            int i = 0;
            Dictionary<string, string> numAsWord = new Dictionary<string, string>();
            numAsWord.Add("o1one", "one");
            numAsWord.Add("t2two", "two");
            numAsWord.Add("t3three", "three");
            numAsWord.Add("4four", "four");
            numAsWord.Add("5five","five");
            numAsWord.Add("s6six","six");
            numAsWord.Add("s7seven","seven");
            numAsWord.Add("e8eight","eight");
            numAsWord.Add("n9nine", "nine");
            StreamReader sr = new StreamReader("C:\\Users\\Jared\\sourceP\\repos\\AdventOfCode23\\Files\\day1.txt");
            StreamWriter sw = new StreamWriter("C:\\Users\\Jared\\sourceP\\repos\\AdventOfCode23\\Files\\day1Output.txt");

            try
            {
               
                line = sr.ReadLine();
                while (line != null)
                {
                    string lineText = line;
                    string finalText = lineText;
                    //------Part2---------------------------
                    foreach (var num1 in numAsWord)
                    {
                        if (lineText.Contains(num1.Value))
                        {
                            finalText = finalText.Replace(num1.Value, Convert.ToString(num1.Key));
                        }
                    }
                    List<int> nums = new List<int>();
                    line = new String(finalText.Where(Char.IsDigit).ToArray());
                    int length = line.Length;
                    foreach (char c in line)
                    {
                        int c1 = (int)char.GetNumericValue(c);
                        nums.Add(c1);
                        line.Substring(0, line.LastIndexOf(c));
                    }
                    int newNum1 = nums[0];
                    int newNum2 = nums[line.Length - 1];
                    string conNum = Convert.ToString(newNum1) + Convert.ToString(newNum2);
                    int totalNum = Int32.Parse(conNum);
                    total = (totalNum +  total);

                    sw.Write("Row = " + i + " Line Input = " + finalText + " ConNum = " +  conNum + " Total = " + total + "\n");
                    Console.WriteLine(total);
                    line = sr.ReadLine();
                    i++;
                }
            }
            catch(Exception e)
            {
                Console.WriteLine("Exception: " + e.Message);
            }
            finally
            {
                sw.WriteLine("Total = " + total);
                sw.Close();
            }
        }
    }
}