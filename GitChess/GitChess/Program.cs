using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GitChess
{
    class Program
    {
        static void Main(string[] args)
        {
            TheGame theGame = new TheGame();

            theGame.StartGame();
            //Console.WriteLine("♔");
            //Console.WriteLine("♕");
        }
    }
}
