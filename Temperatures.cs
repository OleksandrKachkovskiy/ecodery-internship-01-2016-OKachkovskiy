using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Collections;
using System.Collections.Generic;

/**
 * Auto-generated code below aims at helping you parse
 * the standard input according to the problem statement.
 **/
class Solution
{
    static void Main(string[] args)
    {
        try
        {
            int n = int.Parse(Console.ReadLine()); // the number of temperatures to analyse
            string temps = Console.ReadLine(); // the n temperatures expressed as integers ranging from -273 to 5526


            string[] values = temps.Split(' ');

            int closest = int.Parse(values[0]);

            foreach (var item in values)
            {
                int buff = int.Parse(item);

                if (buff > 0)
                {
                    closest = (buff > closest) && (buff > (closest * -1)) ? closest : buff;
                }
                else if (buff < 0)
                {
                    closest = buff < closest ? closest : buff;
                }
                else
                {
                    Console.WriteLine(0);
                }
            }
            Console.WriteLine(closest);
        }
        catch { Console.WriteLine(0); }
    }
}
