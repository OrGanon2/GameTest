using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameTest
{
    public class Board
{

    private int height;
    public int Height { get { return height; } set { height = value; } }

    private int width;
    public int Width { get { return width; } set { width = value; } }

    public Board()
    {
        height = 25;
        width = 80;
    }
    public Board(int height, int width)
    {
        this.width = Width;
        this.height = Height;
    }
    public void write()
    {
            Console.ForegroundColor = ConsoleColor.White;

            for (int i = 1; i <= width; i++)
        {
            Console.SetCursorPosition(i, 0);
            Console.Write("-");
        }
        for (int i = 1; i <= width; i++)
        {
            Console.SetCursorPosition(i, (height + 1));
            Console.Write("-");
        }
        for (int i = 1; i <= height; i++)
        {
            Console.SetCursorPosition(0, i);
            Console.Write("|");


        }
        for (int i = 1; i <= height; i++)
        {
            Console.SetCursorPosition((width + 1), i);
            Console.Write("|");

        }

        Console.SetCursorPosition(0, 0);
        Console.Write('┌');

        Console.SetCursorPosition((width + 1), 0);
        Console.Write('┐');

        Console.SetCursorPosition(0, (height + 1));
        Console.Write('└');

        Console.SetCursorPosition((width + 1), (height + 1));
        Console.Write('┘');

    }
}
}