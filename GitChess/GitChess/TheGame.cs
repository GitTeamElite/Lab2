﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GitChess
{
    public class TheGame
    {
        bool ChackMate = false;
        bool BlacksTrun = false;
        public void StartGame()
        {
            ChessBoard chessboard = new ChessBoard();
            AI ai = new AI();
            
            
            while (!ChackMate)
            {
                Printer.PrintGame(chessboard.GetBoard());
                Console.ReadKey();


                if (BlacksTrun) { BlacksTrun = false; }
                else { BlacksTrun = true; }
            }
        }
    }
}
