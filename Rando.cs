using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HangManStarterKit
{
    class Rando : Player
    {
        Random random = new Random();
        public override char Guess()
        {
            char[] aToZ = new char[] { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' };
            int randomGuess = random.Next(0, aToZ.Length);
            return aToZ[randomGuess];
        }
    }
}
