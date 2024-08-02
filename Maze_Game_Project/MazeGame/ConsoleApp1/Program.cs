using System.Security.Cryptography.X509Certificates;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("\t \t \t \t \t Welcome to maze game!");
            //Console.WriteLine("use Keyboard arrow to move player ");

            Maze maze = new Maze(20,20);

            while (true)
            {
                maze.DrawMaze();
                maze.Move();
            }
        }
    }
}
