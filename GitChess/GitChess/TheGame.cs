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
                Console.ReadKey();

               
                //Iplay.CheckAvilibleMoves();
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
