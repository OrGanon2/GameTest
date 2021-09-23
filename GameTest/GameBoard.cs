using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//namespace GameTest
//{
//    public class GameBoard
//    {
//        static public void BoG(int Width, int Height)
//        {
//            for (int i = 1; i < Width; i++)
//            {
//                BoardChars(i, 0, '-');
//                BoardChars(Width + 1, (Height + 1), '┘');
//            }
//            BoardChars(0, 0, '┌');
//            BoardChars((Width + 1), 0, '┐');
//            BoardChars(0, (Height + 1), '└');
//            BoardChars((Width + 1), (Height + 1), '┘');
//        }
//        static void BoardChars(int x, int y, char znak)
//        {
//            Console.SetCursorPosition(x, y);
//            Console.Write(znak);
//        }
//    }
//}
