using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal interface IMazeObject
    {
        char Icon { get; }        //the shape of icon
        bool IsSolid { get; }      //Movment Block
    }
}
