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
            int sumTotal = 0;
            while (line != null)
            {
                string gameId1 = line.Split(':')[0];
                string[] gameId2 = gameId1.Split(" ");
                string part2 = line.Split(':')[1];
                string[] arrayTest = part2.Split(';');
                int redMin = 0;
                int greenMin = 0;
                int blueMin = 0;
                bool redVal = false;//setting these three to determine if the value has been changed
                bool greenVal = false;
                bool blueVal = false;

                bool Over = false;
                for (int i = 0; i < arrayTest.Length; i++)
                {
                    colorArray = arrayTest[i].Split(',');
                    int grMin = int.MaxValue;
                    int blMin = int.MaxValue;
                    int reMin = int.MaxValue;
                    for (int j = 0; j < colorArray.Length; j++)
                    {
                        numArray = colorArray[j].Split(" ");
                        //-------------------Part 2 work

                        if (numArray[2] == "green" && greenVal)
                        {
                            if (Convert.ToInt32(numArray[1]) >= greenMin)
                            {
                                greenMin = Convert.ToInt32(numArray[1]);
                            }
                        }
                        else if (numArray[2] == "green")
                        {
                            greenMin = Convert.ToInt32(numArray[1]);
                            greenVal = true;
                        }

                        if (numArray[2] == "red" && redVal)
                        {
                            if (Convert.ToInt32(numArray[1]) >= redMin)
                                redMin = Convert.ToInt32(numArray[1]);
                        }
                        else if (numArray[2] == "red")
                        {
                            redMin = Convert.ToInt32(numArray[1]);
                            redVal = true;
                        }

                        if (numArray[2] == "blue" && blueVal)
                        {
                            if (Convert.ToInt32(numArray[1]) >= blueMin)
                                blueMin = Convert.ToInt32(numArray[1]);
                        }
                        else if(numArray[2] == "blue")
                        {
                            blueMin = Convert.ToInt32(numArray[1]);
                            blueVal = true;
                        }

                        //-------------------
                        /**if ((numArray[2] == "red" && Convert.ToInt32(numArray[1]) <= red) || (numArray[2] == "green" && Convert.ToInt32(numArray[1]) <= green) || (numArray[2] == "blue" && Convert.ToInt32(numArray[1]) <= blue))
                        {
                            Over = false;
                        }
                        else
                        {
                            Over = true;
                            break;
                        }**/
                    }
                }
                if (!Over)
                {
                    gameId += Convert.ToInt32(gameId2[1]);
                }
                count++;
                int minMult = blueMin*redMin*greenMin;
                sumTotal += minMult;
                Console.WriteLine("Line Num: " + count + " Bool Value: " + Over + " Total Of Game: " + gameId);
                Console.WriteLine("Red Min = " + redMin + " Green Min = " + greenMin + " Blue Min = " + blueMin);
                Console.WriteLine(minMult);
                Console.WriteLine(sumTotal);

                line = sr.ReadLine();
            }
        }
    }
}