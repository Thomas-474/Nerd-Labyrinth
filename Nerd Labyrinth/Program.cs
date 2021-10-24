using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nerd_Labyrinth
{
    class Program
    {
        public static void Main (string[] args)
	    {
		GameSetup.CreatePlayers();
		GameSetup.DiceTest();

		
        Console.ReadKey();
        }
    }
}
