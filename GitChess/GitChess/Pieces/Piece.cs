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
        public Piece(bool _ImBlack)
        {
            this._ImAlive = false;
            this._ImBlack = _ImBlack;
            this._MyVisualLook = "   ";
            this.AvilibleMoves = new List<Move>();
            this.Points = 0;
        }
        public Piece()
        {
            this._ImAlive = false;
            this._MyVisualLook = "   ";
            this.AvilibleMoves = new List<Move>();
            this.Points = 0;
        }
        public virtual void CheckMove(bool BlacksTurn, Piece[,] Board, int CurrentY, int CurrentX)
        {

        }
    
        public void AddMoveToList(int XPos, int YPos, int y, int x, Piece[,] Board, bool BlacksTurn)
        {
            //if (!ChackMatt(Board, BlacksTurn))
            {
                AvilibleMoves.Add(new Move(XPos, YPos, y, x, Board[y, x].Points));
            }
        }
        public void PrintMoveList()
        {
            int nr = 1;
            foreach (var item in AvilibleMoves)
            {
                Console.WriteLine($"Move {nr}: {item.XMove + 1} - {item.YMove + 1} - Points :{item.MovePoints};");
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
        public void MovingStraight(bool BlacksTurn, Piece[,] Board, int CurrentX, int CurrentY)
        {                                             // y - x
            Mover(BlacksTurn, Board, CurrentY, CurrentX, 0, 1);
            Mover(BlacksTurn, Board, CurrentY, CurrentX, 1, 0);
            Mover(BlacksTurn, Board, CurrentY, CurrentX, 0, -1);
            Mover(BlacksTurn, Board, CurrentY, CurrentX, -1, 0);
        }
        public void MovingDiagonaly(bool BlacksTurn, Piece[,] Board, int CurrentX, int CurrentY)
        {                                              // y - x
            Mover(BlacksTurn, Board, CurrentY, CurrentX, 1, 1);
            Mover(BlacksTurn, Board, CurrentY, CurrentX, -1, -1);
            Mover(BlacksTurn, Board, CurrentY, CurrentX, 1, -1);
            Mover(BlacksTurn, Board, CurrentY, CurrentX, -1, 1);
        }
        public void Mover(bool BlacksTurn, Piece[,] Board, int CurrentX, int CurrentY, int x, int y)
        {
            int RightY = y;
            int RightX = x;

            while (true)
            {
                if (x + CurrentX >= 8 || y + CurrentY >= 8 || x + CurrentX <= -1 || y + CurrentY <= -1)// Stay in the array!
                {
                    return;
                }
                else if (Board[CurrentY + y, CurrentX + x]._ImAlive && Board[CurrentY + y, CurrentX + x]._ImBlack == BlacksTurn) // Cant move threw your own pieces
                {
                    return;
                }
                else if (Board[CurrentY + y, CurrentX + x]._ImAlive == false) // Moves to a empty spot
                {
                    AddMoveToList(CurrentY, CurrentX, CurrentY + y, CurrentX + x, Board, BlacksTurn);
                }
                else if (Board[CurrentY, CurrentX]._ImBlack != Board[CurrentY + y,   //  takes a enemy and loop breaks
                    CurrentX + x]._ImBlack && Board[CurrentY + y, CurrentX + x]._ImAlive)
                {
                    AddMoveToList(CurrentY, CurrentX, CurrentY + y, CurrentX + x, Board, BlacksTurn);
                    return;
                }
                y += RightY;
                x += RightX;
            }
        }
   
     

    }
}
