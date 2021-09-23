using System;

namespace GameTest
{
    class Program
    {
        
        static void Main(string[] args)
        {
            Console.SetWindowSize(82, 27);
            Board board = new Board();
            board.write();
            //rectangle RecTan = new rectangle();
            //RecTan.ShapeRectangle();
            //triangle TriTan = new triangle();
            //TriTan.ShapeTriangle();
            //square SQ = new square();
            //SQ.SquareShape();
            //Lines line = new Lines();
            //line.LineLength();
            Game MainGame = new Game();
            MainGame.StartGame();
          
           
          

            

        //do
        //{
        //    keyinfo = Console.ReadKey();
        //    Console.WriteLine("you entered: " + keyinfo.KeyChar);

        //} while (keyinfo.Key != ConsoleKey.Escape);

    }
    }
}
