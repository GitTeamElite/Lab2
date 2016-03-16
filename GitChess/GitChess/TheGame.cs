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
            
               



                //foreach (var item in chessboard.GetBoard())
                //{
                //    item.CheckMove( BlacksTurn,  BlackIsEnemy, chessboard.GetBoard(),  x,  y,  Xmove,  Ymove);
                //}
              for(int y = 0; y < 8; y++)
                {
                    for (int x = 0; x < 8; x++)
                    {
                        chessboard.Board[x, y].CheckMove(BlacksTurn, chessboard.GetBoard(), x, y);
                    }
                }
                //foreach (var item in chessboard.GetBoard())
                //{
                //    item.PrintMoveList();
                //}
                //Console.ReadKey();
                Printer.PrintGame(chessboard.GetBoard(), BlacksTurn);

                player.Move(BlacksTurn, chessboard.Board);

                #region Test Moves
                //Console.WriteLine("Test move y");
                //int a = 0;
                //int.TryParse(Console.ReadLine(), out a);
                //a -= 1;
                //Console.WriteLine("Test move x");
                //int b = 0;
                //int.TryParse(Console.ReadLine(),out b);
                //b -= 1;
                //if (b > 0 && a > 0)
                //{
                //    chessboard.Board[a, b]._MyVisualLook = " + ";
                //    Printer.PrintGame(chessboard.GetBoard(), BlacksTurn);
                //    Console.WriteLine($"\ny:{a + 1} - x:{b + 1}");
                //    chessboard.Board[a, b].PrintMoveList();
                //    Console.ReadKey();
                //} 
                #endregion
                //////////////////////////////////////////////////////////////////////////////////////////////////
                //------------------------------------ TEST TEST TEST ------------------------------------------//
                //////////////////////////////////////////////////////////////////////////////////////////////////


                //Player.CheckAvailableMoves();
                //Player.MovePiece();
                //Iplay.CheckThretenPieces();

                //Iplay.MovePiece();
                // Add possible moves to AI




                // Changes turn to next player
                //if (BlacksTurn) { BlacksTurn = false; } //Maybe change variable... a bit confusing 
                //else { BlacksTurn = true; }
            }
        }
    }
}
