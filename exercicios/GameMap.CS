using System;

public enum Ground
{
    GRASS, SAND, WATER, WALL
}

public static class GroundExtensions
{
    public static ConsoleColor GetColor(this Ground ground)
    {
        switch (ground)
        {
            case Ground.GRASS: return ConsoleColor.Green;
            case Ground.SAND: return ConsoleColor.Yellow;
            case Ground.WATER: return ConsoleColor.Blue;
            default: return ConsoleColor.Magenta; 
        }
    }

    public static char GetChar(this Ground ground)
    {
        switch (ground)
        {
            case Ground.GRASS: return '\u201c';
            case Ground.SAND: return '\u25cb';
            case Ground.WATER: return '\u2248';
            default: return '\u25cf';
        }
    }
}

public class Program
{
    public static void Main()
    {
        Ground[,] map = new Ground[10, 11]
        {
            { Ground.SAND, Ground.SAND, Ground.SAND, 
              Ground.SAND, Ground.GRASS, Ground.GRASS, 
              Ground.GRASS, Ground.GRASS, Ground.GRASS, 
              Ground.GRASS, Ground.GRASS },
            { Ground.WATER, Ground.WATER, Ground.WATER, 
              Ground.WATER, Ground.WATER, Ground.WATER, 
              Ground.WATER, Ground.WALL, Ground.WATER, 
              Ground.WATER, Ground.WATER },
            { Ground.GRASS, Ground.GRASS, Ground.GRASS, 
              Ground.GRASS, Ground.SAND, Ground.SAND, 
              Ground.SAND, Ground.SAND, Ground.SAND, 
              Ground.SAND, Ground.SAND },
            { Ground.WALL, Ground.WALL, Ground.WALL, 
              Ground.WALL, Ground.WALL, Ground.WALL, 
              Ground.WALL, Ground.WALL, Ground.WALL, 
              Ground.WALL, Ground.WALL },
            { Ground.GRASS, Ground.GRASS, Ground.GRASS, 
              Ground.GRASS, Ground.GRASS, Ground.GRASS, 
              Ground.GRASS, Ground.GRASS, Ground.GRASS, 
              Ground.GRASS, Ground.GRASS },
            { Ground.SAND, Ground.SAND, Ground.SAND, 
              Ground.SAND, Ground.SAND, Ground.SAND, 
              Ground.SAND, Ground.SAND, Ground.SAND, 
              Ground.SAND, Ground.SAND },
            { Ground.WATER, Ground.WATER, Ground.WATER, 
              Ground.WATER, Ground.WATER, Ground.WATER, 
              Ground.WATER, Ground.WATER, Ground.WATER, 
              Ground.WATER, Ground.WATER },
            { Ground.GRASS, Ground.GRASS, Ground.GRASS, 
              Ground.GRASS, Ground.GRASS, Ground.GRASS, 
              Ground.GRASS, Ground.GRASS, Ground.GRASS, 
              Ground.GRASS, Ground.GRASS },
            { Ground.SAND, Ground.SAND, Ground.SAND, 
              Ground.SAND, Ground.SAND, Ground.SAND, 
              Ground.SAND, Ground.SAND, Ground.SAND, 
              Ground.SAND, Ground.SAND },
            { Ground.WATER, Ground.WATER, Ground.WATER, 
              Ground.WATER, Ground.WATER, Ground.WATER, 
              Ground.WATER, Ground.WATER, Ground.WATER, 
              Ground.WATER, Ground.WATER }
        };

        Console.OutputEncoding = System.Text.Encoding.UTF8;
        for (int row = 0; row < map.GetLength(0); row++)
        {
            for (int column = 0; column < map.GetLength(1); column++)
            {
                Console.ForegroundColor = map[row, column].GetColor();
                Console.Write(map[row, column].GetChar() + " ");
            }
            Console.WriteLine();
        }
        Console.ForegroundColor = ConsoleColor.Gray;
    }
}
