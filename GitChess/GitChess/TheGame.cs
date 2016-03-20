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
        bool BlacksTurn = true;
        string WhitePiecesDied = "";
        string BlackPiecesDied = "";

        Player player = new Player();
        AI aiBlack = new AI(true);
        AI aiWhite = new AI(false);
        public void StartGame()
        {
            ChessBoard chessboard = new ChessBoard();
            Logger logger = new Logger();
         

            while (!ChackMate)
            {
                chessboard.CLearPieceMoveLists();
                chessboard.FillPiecesMoveLists(BlacksTurn);
         
                Printer.PrintGame(chessboard.GetBoard(), BlacksTurn);

                if (BlacksTurn)
                {
                    Console.WriteLine("Press a key for next Black");
                    Console.ReadKey();
                    aiBlack.Move(BlacksTurn, chessboard.Board);
                }

                else
                {
                    Console.WriteLine("Press a key for next White");
                    Console.ReadKey();
                    aiWhite.Move(BlacksTurn, chessboard.Board);
                }
                // player.Move(BlacksTurn, chessboard.Board, WhitePiecesDied, BlackPiecesDied, logger);

                //Changes turn to next player
                if (BlacksTurn) { BlacksTurn = false; } //Maybe change variable... a bit confusing 
                else { BlacksTurn = true; }
            }
        }
    }
    

}
