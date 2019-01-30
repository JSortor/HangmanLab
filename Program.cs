using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HangManStarterKit
{
    class Program
    {
        static void Main(string[] args)
        {
            //////******UNCOMMENT OUT THE PLAYER YOU WOULD LIKE TO PLAY******//////


            //Player p1 = new ABCplayer();
            //HangmanGame hg1 = new HangmanGame(p1);

            Player p2 = new HumanPlayer();
            HangmanGame hg2 = new HangmanGame(p2);

            //Player p3 = new BruteForcePlayer();
            //HangmanGame hg3 = new HangmanGame(p3);

            //Player p4 = new SmartyPlayer();
            //HangmanGame hg4 = new HangmanGame(p4);

            //Player p5 = new RandomPlayer();
            //HangmanGame hg5 = new HangmanGame(p5);
        }
    }
}
