<<<<<<< HEAD
﻿namespace game;
=======
﻿﻿namespace game;
>>>>>>> c1b3e8dbe3b2ce08198b4148f46ba2e85a429d76

class Program
{
    static void Main(string[] args)
    {
<<<<<<< HEAD
        Console.WriteLine($"{World.Weapons[0].Name} {World.Weapons[0].maximumDamage}");
    }

=======
        Console.WriteLine("Hello, World!");

        string[,] map = new string[4, 6]
        {
            { " ", " ", "P", " ", " ", " "},
            { " ", " ", "A", " ", " ", " "},
            { "V", "F", "T", "G", "B", "S"},
            { " ", " ", "H", " ", " ", " "}
        };

        int playerX = 3;
        int playerY = 6;

        for (int i = 0; i < 4; i++)
        {
            for (int j = 0; j < 6; j++)
            {
                if (i == playerX && j == playerY)
                {
                    Console.Write("H");
                }
                else
                {
                    Console.Write(map[i, j]);
                }
            }
            Console.WriteLine();
        }

        Console.WriteLine("Choose a direction to move (up, down, left, right):");
        string? direction = Console.ReadLine();

        if (direction == "up" && playerX > 0)
        {
            playerX--;
        }
        else if (direction == "down" && playerX < 4)
        {
            playerX++;
        }
        else if (direction == "left" && playerY > 0)
        {
            playerY--;
        }
        else if (direction == "right" && playerY < 6)
        {
            playerY++;
        }

        for (int i = 0; i < 5; i++)
        {
            for (int j = 0; j < 7; j++)
            {
                if (i == playerX && j == playerY)
                {
                    Console.Write("H");
                }
                else
                {
                    Console.Write(map[i, j]);
                }
            }
            Console.WriteLine();
        }
    }
    
>>>>>>> c1b3e8dbe3b2ce08198b4148f46ba2e85a429d76
}
