using System;
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
        Iplayer Iplay;
        Player player = new Player();
        public void StartGame()
        {
            ChessBoard chessboard = new ChessBoard();

         

            while (!ChackMate)
            {
                for (int y = 0; y < 8; y++)
                {
                    for (int x = 0; x < 8; x++)
                    {
                        chessboard.Board[x, y].ClearMoveList();
                    }
                }


                //////////////////////////////////////////////////////////////////////////////////////////////////
                //------------------------------------ TEST TEST TEST ------------------------------------------//
                //////////////////////////////////////////////////////////////////////////////////////////////////



                ////////////////////////////////////Fills Move List ////////////////////////////////////////////////
                ////////////////////////////////////////////////////////////////////////////////////////////////////
                for (int y = 0; y < 8; y++)                                                                    /////
                {                                                                                              /////
                    for (int x = 0; x < 8; x++)                                                                /////
                    {                                                                                          /////
                        chessboard.Board[x, y].CheckMove(BlacksTurn, chessboard.GetBoard(), x, y);             /////
                    }                                                                                          /////
                } //////////////////////////////////////////////////////////////////////////////////////////////////
              //////////////////////////////////////////////////////////////////////////////////////////////////////

                Printer.PrintGame(chessboard.GetBoard(), BlacksTurn);
                bool PieceMoved = false;
                while (!PieceMoved)
                {
                   

                        Printer.PrintGame(chessboard.GetBoard(), BlacksTurn);
                        PieceMoved = player.Move(BlacksTurn, chessboard.Board);
                    
                }
        
                //////////////////////////////////////////////////////////////////////////////////////////////////
                //------------------------------------ TEST TEST TEST ------------------------------------------//
                //////////////////////////////////////////////////////////////////////////////////////////////////



                // Changes turn to next player
                //if (BlacksTurn) { BlacksTurn = false; } //Maybe change variable... a bit confusing 
                //else { BlacksTurn = true; }
            }
        }
    }
}
