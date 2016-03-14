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
                //////////////////////////////////////////////////////////////////////////////////////////////////
                //------------------------------------ TEST TEST TEST ------------------------------------------//
                //////////////////////////////////////////////////////////////////////////////////////////////////
                if (BlacksTurn) { Console.WriteLine("Blacks turn"); } else { Console.WriteLine("Whites turn"); }
                int y = 0;
                Console.WriteLine("Move a piece! ENTER y then x");
                try
                {
                     y = StaticMethods.TranslateLetters(Console.ReadLine());
                }
                catch
                {

                }
                int x = 0;
                   x= int.Parse(Console.ReadLine());



                int Xmove = int.Parse(Console.ReadLine());
                int Ymove = 0;
                try
                {
                    Ymove = StaticMethods.TranslateLetters(Console.ReadLine());
                }
                catch
                {

                }
                

                foreach (var item in chessboard.GetBoard())
                {
                    item.CheckMove( BlacksTurn,  BlackIsEnemy, chessboard.GetBoard(),  x,  y,  Xmove,  Ymove);
                }

                foreach (var item in chessboard.GetBoard())
                {
                    item.PrintMoveList();
                }
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
