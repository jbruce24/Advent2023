using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Advent
{
    internal class Day2
    {
        public static void Run()
        {
            StreamReader sr = new StreamReader("C:\\Users\\Jared\\sourceP\\repos\\AdventOfCode23\\Files\\day2.txt");
            StreamWriter sw = new StreamWriter("C:\\Users\\Jared\\sourceP\\repos\\AdventOfCode23\\Files\\day2Output.txt");
            
            string line = sr.ReadLine();
            int count = 0;
            int gameId = 0;
            const int red = 12;
            const int green = 13;
            const int blue = 14;
            string[] colorArray = null;
            string[] numArray = null;
            while (line != null)
            {
                string gameId1 = line.Split(':')[0];
                string[] gameId2 = gameId1.Split(" ");
                string part2 = line.Split(':')[1];
                string[] arrayTest = part2.Split(';');
                bool Over = false;
                for(int i=0; i<arrayTest.Length; i++)
                {
                    colorArray = arrayTest[i].Split(',');
                    for (int j = 0; j < colorArray.Length; j++)
                    {
                        numArray = colorArray[j].Split(" ");
                        if ((numArray[2] == "red" && Convert.ToInt32(numArray[1]) <= red) || (numArray[2] == "green" && Convert.ToInt32(numArray[1]) <= green) || (numArray[2] == "blue" && Convert.ToInt32(numArray[1]) <= blue))
                        {
                            Over = false;
                        }
                        else
                        {
                            Over = true;
                            break;
                        }
                        if (Over)
                            break;
                    }
                    if (Over)
                        break;
                }
                if (!Over)
                {
                    gameId += Convert.ToInt32(gameId2[1]);
                }
                count++;
                Console.WriteLine("Line Num: " + count + " Bool Value: " + Over + " Total Of Game: " + gameId);
                line = sr.ReadLine();
            }
            



        }
    }
}
