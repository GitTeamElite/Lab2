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


        public void MoveDown(bool BlacksTurn, Piece[,] Board, int CurrentX, int CurrentY)
        {
            int nr = 1;
            while (CurrentY + nr < 7) // Move down*
            {
                if (Board[CurrentY + nr, CurrentX]._ImAlive == false) { AddMoveToList(CurrentY + nr, CurrentX); }

                if (Board[CurrentY, CurrentX]._ImBlack && !Board[CurrentY + nr, CurrentX]._ImBlack && Board[CurrentY + nr, CurrentX]._ImAlive)
                { AddMoveToList(CurrentY + 1, CurrentX); break; }

                if (!Board[CurrentY, CurrentX]._ImBlack && Board[CurrentY + nr, CurrentX]._ImBlack && Board[CurrentY + nr, CurrentX]._ImAlive)
                { AddMoveToList(CurrentY + 1, CurrentX); break; }


                if (Board[CurrentY + nr, CurrentX]._ImAlive && Board[CurrentY + nr, CurrentX]._ImBlack == BlacksTurn)
                {
                    break;
                }
                nr++;
            }
        }
        public void MoveUp(bool BlacksTurn, Piece[,] Board, int CurrentX, int CurrentY)
        {
            int nr = -1;
            while (CurrentY + nr > 0) // Move up*
            {
                if (Board[CurrentY + nr, CurrentX]._ImAlive == false) { AddMoveToList(CurrentY + nr, CurrentX); }

                if (Board[CurrentY, CurrentX]._ImBlack && !Board[CurrentY + nr, CurrentX]._ImBlack && Board[CurrentY + nr, CurrentX]._ImAlive)
                { AddMoveToList(CurrentY + 1, CurrentX); break; }

                if (!Board[CurrentY, CurrentX]._ImBlack && Board[CurrentY + nr, CurrentX]._ImBlack && Board[CurrentY + nr, CurrentX]._ImAlive)
                { AddMoveToList(CurrentY + 1, CurrentX); break; }


                if (Board[CurrentY + nr, CurrentX]._ImAlive && Board[CurrentY + nr, CurrentX]._ImBlack == BlacksTurn)
                {
                    break;
                }
                nr--;
            }
        }
        public void MoveRight(bool BlacksTurn, Piece[,] Board, int CurrentX, int CurrentY)
        {
            int nr = 1;
            while (CurrentX + nr < 7) // Move Right*
            {
                if (Board[CurrentY, CurrentX + nr]._ImAlive == false) { AddMoveToList(CurrentY, CurrentX + nr); }

                if (Board[CurrentY, CurrentX]._ImBlack && !Board[CurrentY, CurrentX + nr]._ImBlack && Board[CurrentY, CurrentX + nr]._ImAlive)
                { AddMoveToList(CurrentY, CurrentX + nr); break; }

                if (!Board[CurrentY, CurrentX]._ImBlack && Board[CurrentY, CurrentX + nr]._ImBlack && Board[CurrentY, CurrentX + nr]._ImAlive)
                { AddMoveToList(CurrentY, CurrentX + nr); break; }


                if (Board[CurrentY, CurrentX + nr]._ImAlive && Board[CurrentY, CurrentX + nr]._ImBlack == BlacksTurn)
                {
                    break;
                }
                nr++;
            }
        }
        public void MoveLeft(bool BlacksTurn, Piece[,] Board, int CurrentX, int CurrentY)
        {
            int nr = -1;
            while (CurrentX + nr > 0) // Move Left*
            {
                if (Board[CurrentY, CurrentX + nr]._ImAlive == false) { AddMoveToList(CurrentY, CurrentX + nr); }

                if (Board[CurrentY, CurrentX]._ImBlack && !Board[CurrentY, CurrentX + nr]._ImBlack && Board[CurrentY, CurrentX + nr]._ImAlive)
                { AddMoveToList(CurrentY, CurrentX + nr); break; }

                if (!Board[CurrentY, CurrentX]._ImBlack && Board[CurrentY, CurrentX + nr]._ImBlack && Board[CurrentY, CurrentX + nr]._ImAlive)
                { AddMoveToList(CurrentY, CurrentX + nr); break; }


                if (Board[CurrentY, CurrentX + nr]._ImAlive && Board[CurrentY, CurrentX + nr]._ImBlack == BlacksTurn)
                {
                    break;
                }
                nr--;
            }
        }


        public void MoveStraight(bool BlacksTurn, Piece[,] Board, int CurrentX, int CurrentY)
        {
         
            //-----------------------------------------------------------------------------------------------//
            while (CurrentY < 7) // Move down*
            {
               
                if (Board[CurrentY + 1, CurrentX]._ImAlive == false) { AddMoveToList(CurrentY + 1, CurrentX); }

                if (Board[CurrentY, CurrentX]._ImBlack && !Board[CurrentY + 1, CurrentX]._ImBlack && Board[CurrentY + 1, CurrentX]._ImAlive)
                { AddMoveToList(CurrentY + 1, CurrentX); break; }

                if (!Board[CurrentX, CurrentY]._ImBlack && Board[CurrentY + 1, CurrentX]._ImBlack && Board[CurrentX, CurrentY + 1]._ImAlive)
                { AddMoveToList(CurrentY + 1, CurrentX); break; }


                if (Board[CurrentY + 1, CurrentX]._ImAlive && Board[CurrentY + 1, CurrentX]._ImBlack == BlacksTurn)
                {
                    break;
                }
                CurrentY++;
            }

            //-----------------------------------------------------------------------------------------------//     
            while (CurrentY > 0)// move Up*
            {
                {
                    if (Board[CurrentY - 1, CurrentX]._ImAlive == false || Board[CurrentY - 1, CurrentX]._ImBlack != BlacksTurn) { AddMoveToList(CurrentX, CurrentY - 1); }
                }
                if (Board[CurrentY - 1, CurrentX]._ImAlive == true && Board[CurrentY - 1, CurrentX]._ImBlack == BlacksTurn)
                {
                    return;
                }
                CurrentY--;
            }
            //-----------------------------------------------------------------------------------------------//        
            while (CurrentX < 7) // move Right*
            {
                if (Board[CurrentY, CurrentX + 1]._ImAlive == false || Board[CurrentY, CurrentX + 1]._ImBlack != BlacksTurn) { AddMoveToList(CurrentX + 1, CurrentY); }

                if (Board[CurrentY, CurrentX + 1]._ImAlive == true && Board[CurrentY, CurrentX + 1]._ImBlack == BlacksTurn)
                {
                    return;
                }
                CurrentX++;
            }
            //-----------------------------------------------------------------------------------------------//              
            while (CurrentX > 0)// move Right*
            {
                if (Board[CurrentY, CurrentX - 1]._ImAlive == false || Board[CurrentY, CurrentX - 1]._ImBlack != BlacksTurn) { AddMoveToList(CurrentX - 1, CurrentY); }

                if (Board[CurrentY, CurrentX - 1]._ImAlive == true && Board[CurrentY, CurrentX - 1]._ImBlack == BlacksTurn)
                {
                    return;
                }
                CurrentX--;
            }
        }
        //-----------------------------------    END    -------------------------------------------------//
        //-----------------------------------------------------------------------------------------------//

        public void MoveDiagonaly(bool BlacksTurn, Piece[,] Board, int CurrentX, int CurrentY)
        {
       we
            //-----------------------------------------------------------------------------------------------//

            while (CurrentY < 7 && CurrentX > 0) //  Down y+1/Left x-1 *
            {

                if (Board[CurrentY + 1, CurrentX - 1]._ImAlive == false || Board[CurrentY + 1, CurrentX - 1]._ImBlack != BlacksTurn)
                {
                    AddMoveToList(CurrentX - 1, CurrentY + 1);
                }

                if (Board[CurrentY + 1, CurrentX - 1]._ImAlive == true && Board[CurrentY + 1, CurrentX - 1]._ImBlack == BlacksTurn)
                {
                    return;
                }
                CurrentY++; CurrentX--;
            }

            //-----------------------------------------------------------------------------------------------//
            while (CurrentY < 7 && CurrentX < 7) // Down y+1 Right x+1 *
            {

                if (Board[CurrentY + 1, CurrentX + 1]._ImAlive == false || Board[CurrentX + 1, CurrentY + 1]._ImBlack != BlacksTurn) { AddMoveToList(CurrentX + 1, CurrentY + 1); }

                if (Board[CurrentY + 1, CurrentX + 1]._ImAlive == true && Board[CurrentY + 1, CurrentX + 1]._ImBlack == BlacksTurn)
                {
                    return;
                }
                CurrentX++; CurrentY++;
            }
            //-----------------------------------------------------------------------------------------------//
            while (CurrentY > 0 && CurrentX > 0) // move Up y-1 Left x-1 *
            {
                if (Board[CurrentY - 1, CurrentX - 1]._ImAlive == false || Board[CurrentY - 1, CurrentX - 1]._ImBlack != BlacksTurn) { AddMoveToList(CurrentX - 1, CurrentY - 1); }

                if (Board[CurrentY - 1, CurrentX - 1]._ImAlive == true && Board[CurrentY - 1, CurrentX - 1]._ImBlack == BlacksTurn)
                {
                    return;
                }
                CurrentX--; CurrentY--;
            }
            //-----------------------------------------------------------------------------------------------//     
            while (CurrentY > 0 && CurrentX < 7) // move Up y-1 Right x+1 *
            {
                if (Board[CurrentY - 1, CurrentX + 1]._ImAlive == false || Board[CurrentY - 1, CurrentX + 1]._ImBlack != BlacksTurn) { AddMoveToList(CurrentX + 1, CurrentY - 1); }

                if (Board[CurrentY - 1, CurrentX + 1]._ImAlive == true && Board[CurrentY - 1, CurrentX + 1]._ImBlack == BlacksTurn)
                {
                    return;
                }
                CurrentX++; CurrentY--;
            }
            //-----------------------------------    END    -------------------------------------------------//
            //-----------------------------------------------------------------------------------------------//
        }
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

    //public void Mover(bool BlacksTurn, Piece[,] Board, int CurrentX, int CurrentY, int x, int y)
    //{
    //    while (true)
    //    {
    //        if (Board[CurrentY + y, CurrentX + x]._ImAlive == false) { AddMoveToList(CurrentY + y, CurrentX + x); } // Moves to a empty spot

    //        if (Board[CurrentY, CurrentX]._ImBlack && !Board[CurrentY + y, CurrentX]._ImBlack && Board[CurrentY + 1, CurrentX]._ImAlive)  // Black takes a enemy and loop breaks
    //        { AddMoveToList(CurrentY + y, CurrentX); break; }

    //        if (!Board[CurrentY, CurrentX]._ImBlack && Board[CurrentY + y, CurrentX + x]._ImBlack && Board[CurrentY + y, CurrentX + x]._ImAlive) // White takes a enemy and loop breaks
    //        { AddMoveToList(CurrentY + 1, CurrentX); break; }

    //        if (Board[CurrentY + y, CurrentX + x]._ImAlive && Board[CurrentY + y, CurrentX]._ImBlack == BlacksTurn) // Cant move threw your own pieces
    //        {
    //            break;
    //        }
    //        y += y;
    //        x += x;
    //    }
    //}
    public void MovingStraight(bool BlacksTurn, Piece[,] Board, int CurrentX, int CurrentY)
    {
        ///////////////////////////////////////////// X - Y
        MoveUp(BlacksTurn, Board, CurrentX, CurrentY);
        MoveDown(BlacksTurn, Board, CurrentX, CurrentY);
        MoveLeft(BlacksTurn, Board, CurrentX, CurrentY);
        MoveRight(BlacksTurn, Board, CurrentX, CurrentY);
        //if (CurrentY + 1 < 7)
        //{
        //    Mover(BlacksTurn, Board, CurrentX, CurrentY, 0, 1);
        //}
        //if (CurrentX + 1 < 7)
        //{
        //    Mover(BlacksTurn, Board, CurrentX, CurrentY, 1, 0);
        //}
        //if (CurrentY - 1 > 0)
        //{
        //    Mover(BlacksTurn, Board, CurrentX, CurrentY, 0, -1);
        //}
        //if (CurrentX - 1 > 0)
        //{
        //    Mover(BlacksTurn, Board, CurrentX, CurrentY, -1, 0);
        //}

    }
    public void MovingDiagonaly(bool BlacksTurn, Piece[,] Board, int CurrentX, int CurrentY)
    {
        //////////////////////////////////////////// X - Y
        //if (CurrentX + 1 < 7 && CurrentY + 1 < 7)
        //{
        //    Mover(BlacksTurn, Board, CurrentX, CurrentY, 1, 1);
        //}
        //if (CurrentX - 1 > 0 && CurrentY + 1 > 0)
        //{
        //    Mover(BlacksTurn, Board, CurrentX, CurrentY, -1, -1);
        //}
        //if (CurrentX + 1 < 7 && CurrentY - 1 > 0)
        //{
        //    Mover(BlacksTurn, Board, CurrentX, CurrentY, 1, -1);
        //}
        //if (CurrentX - 1 > 0 && CurrentY + 1 < 7)
        //{
        //    Mover(BlacksTurn, Board, CurrentX, CurrentY, -1, 1);
        //}
    }

}

}
