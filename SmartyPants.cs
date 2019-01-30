using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HangManStarterKit
{
    class SmartyPants : Player
    {
        int index = 0;
        public override char Guess()
        {
            char[] smartChar = new char[] { 'e', 'a', 'i', 'o', 'u', 'r', 't', 'n', 'l', 's', 'c', 'd', 'p', 'm', 'h', 'g', 'b', 'f', 'y', 'w', 'k', 'v', 'x', 'z', 'j', 'q' };
            //char[] smartChar = new char[] { 'e', 'a', 'o', 'i', 'u', 't', 'n', 's', 'r', 'h', 'l', 'd', 'c', 'm', 'f', 'p', 'g', 'w', 'y', 'b', 'v', 'k', 'x', 'j', 'q', 'z' };
            index++;
            return smartChar[index - 1];
        }
    }
}
