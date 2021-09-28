using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nerd_Labyrinth
{
    class Program
    {
        static void Main(string[] args)
        {
            
            
            Console.ReadKey();
        }
    }

    public class Player
    {
        public string name;
        public int age;
        public double luck;
        public double points;
        public bool hasKey;
    }

    public class Room
    {
        public int number;
        public string type; // Exit Room or Type of Puzzle
        public int lengthPosition; // x-axis
        public int heightPosition; // y-axis
        public int widthPosition; // z-axis
    }
}
