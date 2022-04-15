using System;
using System.Collections.Generic;
using System.Threading;

namespace Snake
{
    class Program
    {
        static int x = 0;
        static int y = 0;

        static string direction = "x+";

        static bool exitGame = false;

        static int snakeSpeed = 1000;

        struct XY {
            int x;
            int y;
        }

        /// <summary>
        /// Keeps all the parts of the snake and also determines the snakes length
        /// </summary>
        /// <typeparam name="XY"></typeparam>
        /// <returns></returns>
        static Queue<XY> Snake = new Queue<XY>();

        static void Main(string[] args)
        {
            Console.CursorVisible = false;
            Console.BackgroundColor = ConsoleColor.Blue;
            
            // Start a timer to move the snake
            var snakeMover = new Timer(SnakeMover, null, snakeSpeed, Timeout.Infinite);
            
            // Enter the main game loop
            while (!exitGame)
            {
                //First page is to draw the current position
                if (Console.CursorLeft != x || Console.CursorTop != y)
                {
                    Console.Clear();
                    Console.SetCursorPosition(x,y);
                    Console.Write("X");
                }

                //Second part is to react on keys if there are any
                if (Console.KeyAvailable)  
                {  
                    ConsoleKeyInfo key = Console.ReadKey(true);  
            
                    switch (key.Key)
                    {
                        case ConsoleKey.RightArrow: y++; break;
                        case ConsoleKey.LeftArrow: y--; break;
                        case ConsoleKey.UpArrow: x--; break;
                        case ConsoleKey.DownArrow: x++; break;
                        case ConsoleKey.Q: exitGame = true; break;
                    }
                }

                //If the head of the snake has moved we need to recalculate


                //Third part is to detect collisions (wall, self, coin)

            }
        }

        public static void SnakeMover(object data)
        {
            switch (direction)
            {
                case "x+": x++; break;
                case "x-": x--; break;
                case "y+": y++; break;
                case "y-": y--; break;
            }

            var snakeMover = new Timer(SnakeMover, null, snakeSpeed, Timeout.Infinite);
        }


        
    }
}
