using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeAndLadderSimulator
{
    public class PlayerOption
    {
        public const int NoPlay = 0;
        public const int Ladder = 1;
        public const int Snake = 2;


        public static void PlayerChecksOption()
        {
                  Random random = new Random();
            int randomcheck = random.Next(0, 3);

            switch (randomcheck)
            {
                case NoPlay:
                    Console.WriteLine("  player stays in same position");
                    break;
                case Ladder:
                    Console.WriteLine("the player moves ahead by the number of position received in the die");
                    break;
                default  :
                    Console.WriteLine("the player moves behind by the number of position received in the die");
                    break;
            }
        }
    }
}
