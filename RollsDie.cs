using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeAndLadderSimulator
{
    public static class RollsDie
    {       
        public static void DisplayRandom()
        {
            Random random = new Random();
            int number = random.Next(1, 6);
            Console.WriteLine("random number is:" + number);
        }

    }
}
