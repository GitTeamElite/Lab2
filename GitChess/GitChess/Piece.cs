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
        public int Xposition { get; set; } //
        public int Yposition { get; set; }//
        public List<Move> AvilibleMoves;

        public Piece(bool _ImBlack)
        {
            this._ImAlive = false;
            this._ImBlack = _ImBlack;
            this._MyVisualLook = "   ";
            this.AvilibleMoves = new List<Move>();
            this.Points = 0;
        }

        public virtual bool CheckMove(bool BlacksTurn, bool BlackIsEnemy, Piece[,] Board, int CurrentX, int CurrentY, int MovingX, int MovingY)
        {
            if (CurrentX < 0 || CurrentX > 7 || CurrentY < 0 || CurrentY > 7) { return false; }


            return true;
        }
        public int PiecePoint()
        {
            return Points;
        }
        public void AddMoveToList(int x, int y)
        {
            this.AvilibleMoves.Add(new Move(x, y, this.Points));
        }
        public bool MoveStraight(bool BlacksTurn, bool BlackIsEnemy, Piece[,] Board, int CurrentX, int CurrentY, int MovingX, int MovingY)
        {

            //-----------------------------------------------------------------------------------------------//Fixed
            if (CurrentX == MovingX && CurrentY < MovingY) // move Down
            {
                int y = CurrentY;
                while (y != MovingY)
                {

                    if (Board[CurrentX, y + 1]._ImAlive == false || Board[CurrentX, y + 1]._ImBlack == !BlacksTurn) { AddMoveToList(CurrentX, y + 1); }

                    if (Board[CurrentX, y + 1]._ImAlive == true || Board[CurrentX, y + 1]._ImBlack == BlacksTurn)
                    {

                        return true;
                    }
                    y++;
                }
            }
            //-----------------------------------------------------------------------------------------------//
            else if (CurrentX == MovingX && CurrentY > MovingY) // move Up
            {
                int y = CurrentY;
                while (y != MovingY)
                {
                    if (Board[CurrentX, y - 1] == Board[MovingX, MovingY])
                    {
                        if (Board[CurrentX, y - 1]._ImAlive == false || Board[CurrentX, y - 1]._ImBlack == !BlackIsEnemy) { AddMoveToList(MovingX, MovingY); return true; }
                    }
                    if (Board[CurrentX, y - 1]._ImAlive == true)
                    {
                        return false;
                    }
                    y--;
                }
            }
            //-----------------------------------------------------------------------------------------------//
            else if (CurrentX < MovingX && CurrentY == MovingY) // move Right
            {
                int x = CurrentX;
                while (x != MovingY)
                {
                    if (Board[x + 1, CurrentY] == Board[MovingX, MovingY])
                    {
                        if (Board[x + 1, CurrentY]._ImAlive == false || Board[x + 1, CurrentY]._ImBlack == !BlackIsEnemy) { AddMoveToList(MovingX, MovingY); return true; }
                    }
                    if (Board[x + 1, CurrentY]._ImAlive == true)
                    {
                        return false;
                    }
                    x++;
                }
            }
            //-----------------------------------------------------------------------------------------------//
            else if (CurrentX > MovingX && CurrentY == MovingY) // move Right
            {
                int x = CurrentX;
                while (x != MovingY)
                {
                    if (Board[x - 1, CurrentY] == Board[MovingX, MovingY])
                    {
                        if (Board[x - 1, CurrentY]._ImAlive == false || Board[x - 1, CurrentY]._ImBlack == !BlackIsEnemy) { AddMoveToList(MovingX, MovingY); return true; }
                    }
                    if (Board[x - 1, CurrentY]._ImAlive == true)
                    {
                        return false;
                    }
                    x--;
                }
            }

            return false; ;
        }
        //-----------------------------------    END    -------------------------------------------------//
        //-----------------------------------------------------------------------------------------------//


        public bool MoveDiagonaly(bool BlacksTurn, bool BlackIsEnemy, Piece[,] Board, int CurrentX, int CurrentY, int MovingX, int MovingY)   // UnderCOnstruction!!!!!! 
        {
            int y = CurrentY;
            int x = CurrentX;
            //-----------------------------------------------------------------------------------------------//
            if (CurrentX > MovingX && CurrentY < MovingY) //  Down y+1/Left x-1
            {

                while (y < MovingY && x < MovingX)
                {
                    if (Board[x - 1, y + 1] == Board[MovingX, MovingY])
                    {
                        if (Board[x - 1, y + 1]._ImAlive == false || Board[x - 1, y + 1]._ImBlack == !BlackIsEnemy) { AddMoveToList(MovingX, MovingY); return true; }
                    }
                    if (Board[x - 1, y + 1]._ImAlive == true)
                    {
                        return false;
                    }
                    y++;
                    x--;
                }
            }
            //-----------------------------------------------------------------------------------------------//
            else if (CurrentX < MovingX && CurrentY < MovingY) // Down y+1 Right x+1
            {

                while (y < MovingY && x < MovingX)
                {
                    if (Board[x + 1, y + 1] == Board[MovingX, MovingY])
                    {
                        if (Board[x + 1, y + 1]._ImAlive == false || Board[x + 1, y + 1]._ImBlack == !BlackIsEnemy) { AddMoveToList(MovingX, MovingY); return true; }
                    }
                    if (Board[x + 1, y + 1]._ImAlive == true)
                    {
                        return false;
                    }
                    x++;
                    y++;
                }
            }
            //-----------------------------------------------------------------------------------------------//
            else if (CurrentX > MovingX && CurrentY > MovingY) // move Up y-1 Left x-1
            {

                while (y < MovingY && x < MovingX)
                {
                    if (Board[x - 1, y - 1] == Board[MovingX, MovingY])
                    {
                        if (Board[x - 1, y - 1]._ImAlive == false || Board[x - 1, y - 1]._ImBlack == !BlackIsEnemy) { AddMoveToList(MovingX, MovingY); return true; }
                    }
                    if (Board[x - 1, y - 1]._ImAlive == true)
                    {
                        return false;
                    }
                    x--;
                    y--;
                }
            }
            //-----------------------------------------------------------------------------------------------//
            else if (CurrentX > MovingX && CurrentY < MovingY) // move Up y-1 Right x+1
            {

                while (y < MovingY && x < MovingX)
                {
                    if (Board[x + 1, y - 1] == Board[MovingX, MovingY])
                    {
                        if (Board[x + 1, y - 1]._ImAlive == false || Board[x + 1, y - 1]._ImBlack == !BlackIsEnemy) { AddMoveToList(MovingX, MovingY); return true; }
                    }
                    if (Board[x + 1, y - 1]._ImAlive == true)
                    {
                        return false;
                    }
                    x++;
                    y--;
                }
            }
            return false; ;
            //-----------------------------------    END    -------------------------------------------------//
            //-----------------------------------------------------------------------------------------------//
        }

        public void PrintMoveList()
        {
            int nr = 1;
            foreach (var item in AvilibleMoves)
            {
                Console.WriteLine($"Move {nr}: {item.XMove} {item.YMove}");
                nr++;
            }
        }
    }

}
