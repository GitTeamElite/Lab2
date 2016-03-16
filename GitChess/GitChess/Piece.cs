using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GitChess
{
    public class Piece
    {
        public bool _ImBlack { get; set; }
        public bool _ImAlive { get; set; }
        public string _MyName { get; set; }
        public string _MyVisualLook { get; set; }
        public int Points { get; set; }
        public int Xposition { get; set; }
        public int Yposition { get; set; }
        public List<Move> AvilibleMoves;

        public Piece(bool _ImBlack )
        {
            this._ImAlive = false;
            this._ImBlack = _ImBlack;
            this._MyVisualLook = "   ";
            this.AvilibleMoves = new List<Move>();
            this.Points = 0;
        }

        public virtual void CheckMove(bool BlacksTurn, Piece[,] Board, int CurrentX, int CurrentY)
        {

        }
    
        public void AddMoveToList(int x, int y)
        {
            AvilibleMoves.Add(new Move(x, y));
        }
        public void MoveStraight(bool BlacksTurn, Piece[,] Board, int CurrentX, int CurrentY)
        {
            int y = CurrentY;
            int x = CurrentX;
            //-----------------------------------------------------------------------------------------------//
            while (y < 7) // Move down*
            {
                if (Board[y + 1, CurrentX ]._ImAlive == false || Board[y + 1, CurrentX]._ImBlack != BlacksTurn && Board[y + 1, CurrentX]._ImAlive == true) { AddMoveToList(y + 1, CurrentX); }

                if (Board[y + 1, CurrentX]._ImAlive == true && Board[y + 1, CurrentX]._ImBlack == BlacksTurn)
                {
                    return;
                }
                y++;
            }

            //-----------------------------------------------------------------------------------------------//     
            while (y > 0)// move Up*
            {
                {
                    if (Board[y - 1, CurrentX]._ImAlive == false || Board[y - 1, CurrentX]._ImBlack != BlacksTurn) { AddMoveToList(y - 1, CurrentX); }
                }
                if (Board[y - 1, CurrentX]._ImAlive == true && Board[y - 1, CurrentX]._ImBlack == BlacksTurn)
                {
                    return;
                }
                y--;
            }
            //-----------------------------------------------------------------------------------------------//        
            while (x < 7) // move Right*
            {
                if (Board[CurrentY, x + 1]._ImAlive == false || Board[CurrentY, x + 1]._ImBlack != BlacksTurn) { AddMoveToList(CurrentY, x + 1); }

                if (Board[CurrentY, x + 1]._ImAlive == true && Board[CurrentY, x + 1]._ImBlack == BlacksTurn)
                {
                    return;
                }
                x++;
            }
            //-----------------------------------------------------------------------------------------------//              
            while (x > 0)// move Right*
            {
                if (Board[CurrentY, x - 1]._ImAlive == false || Board[CurrentY, x - 1]._ImBlack != BlacksTurn) { AddMoveToList(CurrentY, x - 1); }

                if (Board[CurrentY, x - 1]._ImAlive == true && Board[CurrentY, x - 1]._ImBlack == BlacksTurn)
                {
                    return;
                }
                x--;
            }
        }
        //-----------------------------------    END    -------------------------------------------------//
        //-----------------------------------------------------------------------------------------------//
        public void MoveDiagonaly(bool BlacksTurn, Piece[,] Board, int CurrentX, int CurrentY)
        {
            int y = CurrentY;
            int x = CurrentX;
            //-----------------------------------------------------------------------------------------------//

            while (y < 7 && x > 0) //  Down y+1/Left x-1 *
            {

                if (Board[y + 1, x - 1]._ImAlive == false || Board[y + 1, x - 1 ]._ImBlack != BlacksTurn) { AddMoveToList(y + 1, x - 1); }

                if (Board[y + 1, x - 1 ]._ImAlive == true && Board[y + 1, x - 1 ]._ImBlack == BlacksTurn)
                {
                    return;
                }
                y++; x--;
            }

            //-----------------------------------------------------------------------------------------------//
            while (y < 7 && x < 7) // Down y+1 Right x+1 *
            {

                if (Board[y + 1, x + 1 ]._ImAlive == false || Board[x + 1, y + 1]._ImBlack != BlacksTurn) { AddMoveToList(x + 1, y + 1); }

                if (Board[y + 1, x + 1]._ImAlive == true && Board[y + 1, x + 1]._ImBlack == BlacksTurn)
                {
                    return;
                }
                x++; y++;
            }
            //-----------------------------------------------------------------------------------------------//
            while (y > 0 && x > 0) // move Up y-1 Left x-1 *
            {
                if (Board[y - 1, x - 1]._ImAlive == false || Board[y - 1, x - 1]._ImBlack != BlacksTurn) { AddMoveToList(y - 1, x - 1);  }

                if (Board[y - 1, x - 1 ]._ImAlive == true && Board[y - 1, x - 1]._ImBlack == BlacksTurn)
                {
                    return;
                }
                x--; y--;
            }
            //-----------------------------------------------------------------------------------------------//     
            while (y > 0 && x < 7) // move Up y-1 Right x+1 *
            {
                if (Board[y - 1, x + 1]._ImAlive == false || Board[y - 1 , x + 1]._ImBlack != BlacksTurn) { AddMoveToList(y - 1, x + 1 ); }

                if (Board[y - 1 , x + 1]._ImAlive == true && Board[y - 1, x + 1]._ImBlack == BlacksTurn)
                {
                    return;
                }
                x++; y--;
            }
            //-----------------------------------    END    -------------------------------------------------//
            //-----------------------------------------------------------------------------------------------//
        }

        public void PrintMoveList()
        {
            int nr = 1;
            foreach (var item in AvilibleMoves)
            {
                Console.WriteLine($"Move {nr}: {item.XMove + 1} - {item.YMove + 1};");
                nr++;
            }
        }
        public void ClearMoveList()
        {
            AvilibleMoves.RemoveRange(0, AvilibleMoves.Count);
        }
        public bool CheckMoveTry(int x, int y)
        {
            foreach (var item in AvilibleMoves)
            {
                if (item.XMove == x && item.YMove == y) { return true; }
            }
            return false;
        }
    }

}
