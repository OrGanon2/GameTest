using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameTest
{
   public class Player : Game
    {
        public char p1 { get; set; } = '*';
        
        
        public int Loaction { get; set; } 
        public int startingPoint { get; set; } 
        public int steps { get; set; }
        public int count { get; set; }
        //public enum Direction { Left, Right,Top,Bottom }

        public void shift(ref bool[,] outerbound,ref int points)
        {
            Random Rand = new Random();
            Loaction = Rand.Next(1, 79);
            startingPoint = Rand.Next(1, 24);
            Console.SetCursorPosition(Loaction,startingPoint);
            if (outerbound[Loaction,startingPoint] == true)
            {
                Try++;
                return;
            }

            try
            {
                while (outerbound[Loaction, startingPoint] == false)
                {
                    ConsoleKeyInfo direction;
                    Console.BackgroundColor = ConsoleColor.Blue;
                    Console.ForegroundColor = ConsoleColor.White;
                    direction = Console.ReadKey(true);
                    switch (direction.Key)
                    {
                        case ConsoleKey.LeftArrow:
                            Console.SetCursorPosition(Loaction, startingPoint);
                            outerbound[Loaction, startingPoint] = true;
                            Console.Write(p1);
                            Loaction--;
                            points++;



                            break;
                        case ConsoleKey.RightArrow:
                            Console.SetCursorPosition(Loaction, startingPoint);
                            outerbound[Loaction, startingPoint] = true;
                            Console.Write(p1);
                            Loaction++;
                            points++;


                            break;
                        case ConsoleKey.UpArrow:
                            Console.SetCursorPosition(Loaction, startingPoint);
                            outerbound[Loaction, startingPoint] = true;
                            Console.Write(p1);
                            startingPoint--;
                            points++;


                            break;
                        case ConsoleKey.DownArrow:
                            Console.SetCursorPosition(Loaction, startingPoint);
                            outerbound[Loaction, startingPoint] = true;
                            Console.Write(p1);
                            startingPoint++;
                            points++;



                            break;

                    }
                    Console.BackgroundColor = ConsoleColor.Black;
                }
            }
            catch 
            {
                return;
                
            }
          
                //OuterBoundaries[Loaction, startingPoint] = true;
        }
            
            //ConsoleKeyInfo direction;
            //direction = Console.ReadKey(true);
            //switch (direction.Key)
            //{
            //    case ConsoleKey.LeftArrow:
                  
            //        break;
            //    case ConsoleKey.RightArrow:
                   
            //        break;
            //    case ConsoleKey.UpArrow:
                   
            //        break;
            //    case ConsoleKey.DownArrow:
                   
            //        break;
            //    default:
            //        break;
            //}
        

       
        
    }
}
