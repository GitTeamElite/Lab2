using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GitBlackJack
{
    class Program
    {
        static void Main(string[] args)
        {
       
            GameFlow gamelogics = new GameFlow();
            bool playing = true;

            while (playing)
            {
              playing = gamelogics.RunGame();
            }
        }
    }
}
