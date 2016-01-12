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
class Player
{
    static void Main(string[] args)
    {
        int road = int.Parse(Console.ReadLine()); // the length of the road before the gap.
        int gap = int.Parse(Console.ReadLine()); // the length of the gap.
        int platform = int.Parse(Console.ReadLine()); // the length of the landing platform.

        // game loop
        while (true)
        {
            int speed = int.Parse(Console.ReadLine()); // the motorbike's speed.
            int coordX = int.Parse(Console.ReadLine()); // the position on the road of the motorbike.

            if (coordX + speed > road && coordX <= road)
                Console.WriteLine("JUMP");
            if (coordX < road - 1)
            {
                if (platform < speed * speed / 2)
                    Console.WriteLine("SLOW");
                else
                {
                    if (speed < gap + 1)
                        Console.WriteLine("SPEED");
                    else
                        Console.WriteLine("WAIT");
                }
            }
            else
            {
                Console.WriteLine("SLOW");
            }
        }
    }
}
