using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nerd_Labyrinth
{
    class Room
    {
        public bool HasExit
        { get; set; }
        public string Puzzle // type of puzzle
        { get; set; }
        public int LengthPosition // x-axis
        { get; set; }
        public int HeightPosition // y-axis
        { get; set; }

        public Room(string puzzle)
        {

        }
    }
}
