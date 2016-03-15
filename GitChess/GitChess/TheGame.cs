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
        bool BlacksTurn = false;
        Iplayer Iplay;
         
        public void StartGame()
        {
            ChessBoard chessboard = new ChessBoard();

            bool BlackIsEnemy = StaticMethods.HowIsEnemy(BlacksTurn); // Check wath color your enemy is

            while (!ChackMate)
            {
                Console.Clear();


                Printer.PrintGame(chessboard.GetBoard());
        
                //////////////////////////////////////////////////////////////////////////////////////////////////
                //------------------------------------ TEST TEST TEST ------------------------------------------//
                //////////////////////////////////////////////////////////////////////////////////////////////////
            
                if (BlacksTurn) { Console.WriteLine("Blacks turn"); } else { Console.WriteLine("Whites turn"); }
                int x = 0;
                int y = 0;
                int Xmove = 1;
                int Ymove = 1;
                

                //foreach (var item in chessboard.GetBoard())
                //{
                //    item.CheckMove( BlacksTurn,  BlackIsEnemy, chessboard.GetBoard(),  x,  y,  Xmove,  Ymove);
                //}

                foreach (var item in chessboard.GetBoard())
                {
                    item.PrintMoveList();
                }
                Console.ReadKey();
                //////////////////////////////////////////////////////////////////////////////////////////////////
                //------------------------------------ TEST TEST TEST ------------------------------------------//
                //////////////////////////////////////////////////////////////////////////////////////////////////


                //Player.CheckAvilibleMoves();
                //Player.MovePiece();
                //Iplay.CheckThretenPieces();

                //Iplay.MovePiece();
                // Add possible moves to AI




                // Changes turn to next player
                if (BlacksTurn) { BlacksTurn = false; }
                else { BlacksTurn = true; }
            }
        }
    }
}
