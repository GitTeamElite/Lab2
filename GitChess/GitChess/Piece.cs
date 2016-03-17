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

        public virtual void CheckMove(bool BlacksTurn, Piece[,] Board, int CurrentX, int CurrentY)
        {

        }

        public void AddMoveToList(int x, int y)
        {
            AvilibleMoves.Add(new Move(x, y)); //check
        }
        #region OldMovingSystem
        //public void MoveStraight(bool BlacksTurn, Piece[,] Board, int CurrentX, int CurrentY)
        //{
        //    int y = CurrentY;
        //    int x = CurrentX;
        //    //-----------------------------------------------------------------------------------------------//
        //    while (y < 7) // Move down*
        //    {
        //        if (Board[CurrentY + 1, CurrentX]._ImAlive == false) { AddMoveToList(CurrentX, y + 1); }

        //        if (Board[x, y]._ImBlack && !Board[y + 1, CurrentX]._ImBlack && Board[CurrentX, y + 1]._ImAlive)
        //        { AddMoveToList(CurrentY + 1, CurrentX); break; }

        //        if (!Board[x, y]._ImBlack && Board[y + 1, CurrentX]._ImBlack && Board[CurrentX, y + 1]._ImAlive)
        //        { AddMoveToList(CurrentY + 1, CurrentX); break; }


        //        if (Board[y + 1, CurrentX]._ImAlive && Board[y + 1, CurrentX]._ImBlack == BlacksTurn)
        //        {
        //            break;
        //        }
        //        y++;
        //    }

        //    //-----------------------------------------------------------------------------------------------//     
        //    while (y > 0)// move Up*
        //    {
        //        {
        //            if (Board[y - 1, CurrentX]._ImAlive == false || Board[y - 1, CurrentX]._ImBlack != BlacksTurn) { AddMoveToList(CurrentX, y - 1); }
        //        }
        //        if (Board[y - 1, CurrentX]._ImAlive == true && Board[y - 1, CurrentX]._ImBlack == BlacksTurn)
        //        {
        //            return;
        //        }
        //        y--;
        //    }
        //    //-----------------------------------------------------------------------------------------------//        
        //    while (x < 7) // move Right*
        //    {
        //        if (Board[CurrentY, x + 1]._ImAlive == false || Board[CurrentY, x + 1]._ImBlack != BlacksTurn) { AddMoveToList(x + 1, CurrentY); }

        //        if (Board[CurrentY, x + 1]._ImAlive == true && Board[CurrentY, x + 1]._ImBlack == BlacksTurn)
        //        {
        //            return;
        //        }
        //        x++;
        //    }
        //    //-----------------------------------------------------------------------------------------------//              
        //    while (x > 0)// move Right*
        //    {
        //        if (Board[CurrentY, x - 1]._ImAlive == false || Board[CurrentY, x - 1]._ImBlack != BlacksTurn) { AddMoveToList(x - 1, CurrentY); }

        //        if (Board[CurrentY, x - 1]._ImAlive == true && Board[CurrentY, x - 1]._ImBlack == BlacksTurn)
        //        {
        //            return;
        //        }
        //        x--;
        //    }
        //}
        ////-----------------------------------    END    -------------------------------------------------//
        ////-----------------------------------------------------------------------------------------------//

        #endregion        //public void MoveDiagonaly(bool BlacksTurn, Piece[,] Board, int CurrentX, int CurrentY)
        //{
        //    int y = CurrentY;
        //    int x = CurrentX;
        //    //-----------------------------------------------------------------------------------------------//

        //    while (y < 7 && x > 0) //  Down y+1/Left x-1 *
        //    {

        //        if (Board[y + 1, x - 1]._ImAlive == false || Board[y + 1, x - 1]._ImBlack != BlacksTurn) { AddMoveToList(x - 1, y + 1); }

        //        if (Board[y + 1, x - 1]._ImAlive == true && Board[y + 1, x - 1]._ImBlack == BlacksTurn)
        //        {
        //            return;
        //        }
        //        y++; x--;
        //    }

        //    //-----------------------------------------------------------------------------------------------//
        //    while (y < 7 && x < 7) // Down y+1 Right x+1 *
        //    {

        //        if (Board[y + 1, x + 1]._ImAlive == false || Board[x + 1, y + 1]._ImBlack != BlacksTurn) { AddMoveToList(x + 1, y + 1); }

        //        if (Board[y + 1, x + 1]._ImAlive == true && Board[y + 1, x + 1]._ImBlack == BlacksTurn)
        //        {
        //            return;
        //        }
        //        x++; y++;
        //    }
        //    //-----------------------------------------------------------------------------------------------//
        //    while (y > 0 && x > 0) // move Up y-1 Left x-1 *
        //    {
        //        if (Board[y - 1, x - 1]._ImAlive == false || Board[y - 1, x - 1]._ImBlack != BlacksTurn) { AddMoveToList(x - 1, y - 1); }

        //        if (Board[y - 1, x - 1]._ImAlive == true && Board[y - 1, x - 1]._ImBlack == BlacksTurn)
        //        {
        //            return;
        //        }
        //        x--; y--;
        //    }
        //    //-----------------------------------------------------------------------------------------------//     
        //    while (y > 0 && x < 7) // move Up y-1 Right x+1 *
        //    {
        //        if (Board[y - 1, x + 1]._ImAlive == false || Board[y - 1, x + 1]._ImBlack != BlacksTurn) { AddMoveToList(x + 1, y - 1); }

        //        if (Board[y - 1, x + 1]._ImAlive == true && Board[y - 1, x + 1]._ImBlack == BlacksTurn)
        //        {
        //            return;
        //        }
        //        x++; y--;
        //    }
        //    //-----------------------------------    END    -------------------------------------------------//
        //    //-----------------------------------------------------------------------------------------------//
        //}

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

        public void Mover(bool BlacksTurn, Piece[,] Board, int CurrentX, int CurrentY, int x, int y)
        {
        
            while (true) 
            {
                if (CurrentX + x < 0 || CurrentX + x > 7 || CurrentY + y < 0 || CurrentY + y > 7) break;

                if (Board[CurrentX + x, CurrentY + y]._ImAlive == false) { AddMoveToList(CurrentX + x, CurrentY + y); } // Moves to a empty spot

                if (Board[CurrentX, CurrentY]._ImBlack && !Board[CurrentX, CurrentY + y]._ImBlack && Board[CurrentX, CurrentY + 1]._ImAlive)  // Black takes a enemy and loop breaks
                { AddMoveToList(CurrentX, CurrentY + y); break; }

                if (!Board[CurrentX, CurrentY]._ImBlack && Board[CurrentX + x, CurrentY + y]._ImBlack && Board[CurrentX + x, CurrentY + y]._ImAlive) // White takes a enemy and loop breaks
                { AddMoveToList(CurrentX, CurrentY + 1); break; }

                if (Board[CurrentX+x, CurrentY + y]._ImAlive && Board[CurrentX, CurrentY + y]._ImBlack == BlacksTurn) // Cant move threw your own pieces
                {
                    break;
                }
                y += y;
                x += x;
            }
        }   
        public void MovingStraight(bool BlacksTurn, Piece[,] Board, int CurrentX, int CurrentY)
        {
            ///////////////////////////////////////////// X - Y
            Mover(BlacksTurn, Board, CurrentX, CurrentY, 0, 1);
            Mover(BlacksTurn, Board, CurrentX, CurrentY, 1, 0);
            Mover(BlacksTurn, Board, CurrentX, CurrentY, 0, -1);
            Mover(BlacksTurn, Board, CurrentX, CurrentY, -1, 0);
       
        }
        public void MovingDiagonaly(bool BlacksTurn, Piece[,] Board, int CurrentX, int CurrentY)
        {
            //////////////////////////////////////////// X - Y
            Mover(BlacksTurn, Board, CurrentX, CurrentY, 1, 1);
            Mover(BlacksTurn, Board, CurrentX, CurrentY, -1, -1);
            Mover(BlacksTurn, Board, CurrentX, CurrentY, 1, -1);
            Mover(BlacksTurn, Board, CurrentX, CurrentY, -1, 1);
         
        }

    }

}
