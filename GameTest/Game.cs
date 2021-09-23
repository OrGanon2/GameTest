using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameTest
{
    public class Game 
    {
        
        public ShapeTypes[] storageShape { get; set; } = new ShapeTypes[4] { new Lines(), new triangle(), new rectangle(), new square() };
        public List<ShapeTypes> ListGameTypes { get; set; } = new List<ShapeTypes>();
        public bool[,] OuterBoundaries = new bool[81,26];
        public int CounterTypes { get; set; }
        Random Rand = new Random();
        public bool check { get; set; }
        public int Try { get; set; }
        public string YesOrNo { get; set; }
       
        
        



        public void StartGame()
        {
            int points = 0;
            Board board = new Board();
            
            Player player = new Player();
            CounterTypes = Rand.Next(3,6);
            while (CounterTypes != 15 && Try != 30)
            {
                Console.Clear();
                board.write();

                OuterBoundaries.reset();
                for (int i = 0; i < CounterTypes; i++)
                {
                    int RollShape = Rand.Next(0, 3);
                    ListGameTypes.Add(storageShape[RollShape]);
                }
                foreach (var Roll in ListGameTypes)
                {
                    Roll.CreateShape();
                    check = CheckBoundaries(ref OuterBoundaries, Roll.InnerBoundaries);
                    if (check == false)
                    {
                        Try++;
                        ListGameTypes.Clear();
                        break;
                    }

                }

                if (check == true)
                {
                    player.shift(ref OuterBoundaries, ref points);
                    CounterTypes++;
                }
                if (CounterTypes == 15 || Try == 30)
                {
                    Console.Clear();
                    Console.WriteLine("GAME OVER");
                    Console.WriteLine("Would you like to try again y/n?");
                    Console.WriteLine($"your points: {points}");
                    YesOrNo = Console.ReadLine();
                    if (YesOrNo == "y")
                    {
                        StartGame();
                    }
                    else if (YesOrNo == "n")
                    {
                        Console.Clear();
                        Console.WriteLine("Too Bad GOOD BYE!");
                        Console.WriteLine($"your points: {points}");
                       
                        
                    }
                    else
                    {
                        while (YesOrNo != "y" || YesOrNo !="n")
                        {
                            Console.WriteLine("wrong Typo would you like to try again y/n?");
                           YesOrNo = Console.ReadLine();

                            if (YesOrNo == "y")
                            {
                                StartGame();
                            }
                            else if (YesOrNo == "n")
                            {
                                Console.Clear();
                                Console.WriteLine("Too Bad GOOD BYE!");
                                Console.WriteLine($"your points: {points}");

                            }
                        }
                      
                    }
                    
                }
            }
           


        }
        public bool CheckBoundaries(ref bool[,] outer, bool[,] inner)
        {
            for (int i = 0; i < inner.GetLength(0); i++)
            {
                for (int j = 0; j < inner.GetLength(1); j++)
                {
                    if (inner[i,j] == true && outer[i,j] == false)
                    {
                        outer[i, j] = true;
                    }
                    else if (inner[i,j] == true && outer[i,j] == true )
                    {
                        return false;
                    }
                }
            }
            return true;
            
        }
      
           
    
    }
}
