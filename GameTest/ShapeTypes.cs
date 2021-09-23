using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameTest
{
    public interface ShapeTypes
    {
        public char Types { get; set; }

        public int loaction { get; set; }
        public int StartingPoint { get; set; }
        public bool[,] InnerBoundaries { get; set; }

        public void CreateShape(); 




    }
    public class rectangle : ShapeTypes
    {
        public char Types { get; set; } = '#';

        public int loaction { get; set; }
        public int StartingPoint { get; set; }

        public Random Rand = new Random();
        public bool[,] InnerBoundaries { get; set; }  = new bool[81, 26];
        public void CreateShape()
        {
            InnerBoundaries.reset();
            Console.ForegroundColor = ConsoleColor.Green;

            int Height = Rand.Next(3, 10);
            int Width = Rand.Next(2, 10);

            StartingPoint = Rand.Next(1,26);
            loaction = Rand.Next(1, 79);

            
            for (int i = 0; i < Height; i++)
            {
                Console.SetCursorPosition(loaction, StartingPoint + i);
                for (int j = 0; j < Width; j++)
                {
                    if (loaction + j >= 80 || StartingPoint + i >= 25)
                    {
                        loaction = loaction + j;
                        StartingPoint = StartingPoint + i;
                        break;
                    }
                    Console.Write(Types);
                    InnerBoundaries[loaction + j, StartingPoint + i] = true;
                }
                if (loaction >= 80 || StartingPoint >= 25)
                {
                    break;
                }
                Console.WriteLine();
            }


        }
    }
    public class triangle : ShapeTypes
    {
        public char Types { get; set; } = '#';

        public int loaction { get; set; }
        public int StartingPoint { get; set; }

        public Random Rand = new Random();

        public bool[,] InnerBoundaries { get; set; } = new bool[81, 26];
        public void CreateShape()
        {
            InnerBoundaries.reset();


            Console.ForegroundColor = ConsoleColor.Yellow;
            StartingPoint = Rand.Next(1, 24);
            loaction = Rand.Next(1, 79);

            int Height = Rand.Next(2, 9);

            for (int i = 0; i < Height; i++)
            {
                
                Console.SetCursorPosition(loaction, StartingPoint + i);
                for (int j = 0; j < i; j++)
                {
                    if (loaction + j >= 80 || StartingPoint + i >= 25)
                    {
                        loaction = loaction + j;
                        StartingPoint = StartingPoint + i;
                        break;
                    }
                    
                    Console.Write(Types);
                    InnerBoundaries[loaction + j, StartingPoint + i] = true;

                }
                if (loaction >= 80 || StartingPoint >= 25)
                {
                    break;
                }
                Console.WriteLine();

            }
        }
    }
    public class square : ShapeTypes
    {
        public char Types { get; set; } = '#';

        public int loaction { get; set; }
        public int StartingPoint { get; set; }

        public Random Rand = new Random();

        public bool[,] InnerBoundaries { get; set; } = new bool[81, 26];
        public void CreateShape()
        {
            InnerBoundaries.reset();

            StartingPoint = Rand.Next(1, 24);
            loaction = Rand.Next(1, 79);

            Console.ForegroundColor = ConsoleColor.Blue;
            int Height = Rand.Next(5, 12);

            Console.WriteLine();
            for (int i = 0; i < Height; i++)
            {
                Console.SetCursorPosition(loaction, StartingPoint + i);
                for (int j = 0; j < Height; j++)
                {
                    if (loaction + j >= 80 || StartingPoint + i >= 25)
                    {
                        loaction = loaction + j;
                        StartingPoint = StartingPoint + i;
                        break;
                    }
                    Console.Write(Types);
                    InnerBoundaries[loaction + j, StartingPoint + i] = true;

                }
                if (loaction >= 80 || StartingPoint >= 25)
                {
                    break;
                }
                Console.WriteLine();
            }
        }
    }
    public class Lines : ShapeTypes
    {
        public char Types { get; set; } = '#';

        public int loaction { get; set; }
        public int StartingPoint { get; set; }

        public Random Rand = new Random();

        public bool[,] InnerBoundaries { get; set; } = new bool[81, 26];

        public void CreateShape()
        {
            InnerBoundaries.reset();

            StartingPoint = Rand.Next(1, 24);
            loaction = Rand.Next(1, 79);

            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine();
            int Length = Rand.Next(2, 10);

            for (int i = 0; i < Length; i++)
            {
                if (loaction + i>= 80 || StartingPoint  >= 25)
                {
                    break;
                }
               
                Console.SetCursorPosition(loaction +i, StartingPoint);
              

                Console.Write(Types);
                InnerBoundaries[loaction + i, StartingPoint] = true;

            }
            Console.WriteLine();
        }
    }
    


}
