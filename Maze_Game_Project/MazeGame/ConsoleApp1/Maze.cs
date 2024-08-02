using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Maze
    {
        // i will need this object in this class
        Player player = new Player();       //==private Player player;
        private IMazeObject[,] mazeObjectArray;      //ready to make 2d array to save walls and space in drawing 

        
        private int Length;
        private int Width;

        public Maze(int length, int width)
        {
            Length = length;
            Width = width;
            mazeObjectArray = new IMazeObject[length, width];          //make array 2d take width and length
            player.x = 1; player.y = 1;
            
            
        }

        public void DrawMaze()
        {
            Console.Clear();
            for (int y = 0; y < Length; y++)
            {
                for (int x = 0; x < Width; x++)
                {
                    if (x == 19 && y ==19)  //outsid فتحة الخروج
                    {
                        mazeObjectArray[x, y] = new EmptySpace();
                        Console.Write(mazeObjectArray[x, y].Icon);
                    }
                    else if (x == 0 || y == 0 || x == Width - 1 || y == Length - 1)
                    {
                        mazeObjectArray[x, y] = new Wall();
                        Console.Write(mazeObjectArray[x, y].Icon);
                    }
                    else if (x == player.x && y == player.y)
                    {
                        Console.Write(player.Icon);
                    }
                    else if (x % 3==0 && y%3==0)        //to make walls (#) enter the maze, you can edit in this(Critical thinking)
                    {
                        mazeObjectArray[x, y] = new Wall();
                        Console.Write(mazeObjectArray[x, y].Icon);
                    }
                    else
                    {
                        mazeObjectArray[x, y] = new EmptySpace();
                        Console.Write(mazeObjectArray[x, y].Icon);
                    }

                }
                Console.WriteLine();
            }
        }

        public void Move()
        {
            var userInput = Console.ReadKey();
            var keyboardKey = userInput.Key;

            switch (keyboardKey)
            {
                //in console: program work from up to down, so that if press up:
                case ConsoleKey.UpArrow:           //minus
                    UpdatePlayer(0, -1);
                    break;
                case ConsoleKey.DownArrow:          //ponus
                    UpdatePlayer(0, 1);
                    break;
                case ConsoleKey.LeftArrow:
                    UpdatePlayer(-1, 0);
                    break;
                case ConsoleKey.RightArrow:
                    UpdatePlayer(1, 0);
                    break;
                default:
                    break;
            }
        }

        public void UpdatePlayer(int dx, int dy)      //update player place
        {
            //new position
            int newx = player.x + dx;
            int newy = player.y + dy;

            //condition to update new position                         last condition(false): to prevent player to out of square
            if (newx < Width && newx>=0 && newy < Length && newy>=0 && mazeObjectArray[newx,newy].IsSolid ==false)
            {
                //execute new position
                player.x = newx; 
                player.y = newy;
                DrawMaze();
            }
        }


        

        
    }
}
