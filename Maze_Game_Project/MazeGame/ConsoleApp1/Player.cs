using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Player : IMazeObject
    {
        public char Icon { get => '@'; }
        public bool IsSolid { get => true; }

        public int x { get; set; }       //x-axis
        public int y { get; set; }      //y-axis
    }
}
