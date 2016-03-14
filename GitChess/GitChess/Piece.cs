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
        public int _MyValue { get; set; }
        public string _MyName { get; set; }
        public string _MyVisualLook { get; set; }
        public int Points { get; set; }

        public List<Move> AvilibleMoves;

        public Piece(bool _ImBlack)
        {
            this._ImBlack = _ImBlack;
            this._MyVisualLook = "   ";
            this.AvilibleMoves = new List<Move>();
            this.Points = 0;
        }

        public virtual bool CheckMove(bool BlacksTurn,bool BlackIsEnemy, Piece[,] Board, int CurrentX, int CurrentY, int MovingX, int MovingY)
        {
            if (MovingX < 0 || MovingX > 7 || MovingY < 0 || MovingY > 7) { return false; }


            return true;
        }
        public int PiecePoint()
        {
            return Points;
        }
        public bool MoveStraight(bool BlacksTurn, bool BlackIsEnemy, Piece[,] Board, int CurrentX, int CurrentY, int MovingX, int MovingY)
        {

            if (CurrentX == MovingX && CurrentY < MovingY) // move Down
            {
                int y = CurrentY;
                while (y != MovingY)
                {
                    if (Board[CurrentX, y + 1] == Board[MovingX, MovingY])
                    {
                        if (Board[CurrentX, y + 1]._ImAlive == false || Board[CurrentX, y + 1]._ImBlack == !BlackIsEnemy) { return true; }
                    }
                    if (Board[CurrentX, y + 1]._ImAlive == true)
                    {
                        return false;
                    }
                    y++;
                }
            }
            //-----------------------------------------------------------------------------------------------//
            if (CurrentX == MovingX && CurrentY > MovingY) // move Up
            {
                int y = CurrentY;
                while (y != MovingY)
                {
                    if (Board[CurrentX, y - 1] == Board[MovingX, MovingY])
                    {
                        if (Board[CurrentX, y - 1]._ImAlive == false || Board[CurrentX, y - 1]._ImBlack == !BlackIsEnemy) { return true; }
                    }
                    if (Board[CurrentX, y - 1]._ImAlive == true)
                    {
                        return false;
                    }
                    y--;
                }
            }
            //-----------------------------------------------------------------------------------------------//
            if (CurrentX < MovingX && CurrentY == MovingY) // move Right
            {
                int x = CurrentX;
                while (x != MovingY)
                {
                    if (Board[x + 1, CurrentY] == Board[MovingX, MovingY])
                    {
                        if (Board[x + 1, CurrentY]._ImAlive == false || Board[x + 1, CurrentY]._ImBlack == !BlackIsEnemy) { return true; }
                    }
                    if (Board[x + 1, CurrentY]._ImAlive == true)
                    {
                        return false;
                    }
                    x++;
                }
            }
            //-----------------------------------------------------------------------------------------------//
            if (CurrentX > MovingX && CurrentY == MovingY) // move Right
            {
                int x = CurrentX;
                while (x != MovingY)
                {
                    if (Board[x - 1, CurrentY] == Board[MovingX, MovingY])
                    {
                        if (Board[x - 1, CurrentY]._ImAlive == false || Board[x - 1, CurrentY]._ImBlack == !BlackIsEnemy) { return true; }
                    }
                    if (Board[x - 1, CurrentY]._ImAlive == true)
                    {
                        return false;
                    }
                    x--;
                }
            }
            //-----------------------------------------------------------------------------------------------//

            return false; ;
        }
        public bool MoveDiagonaly(bool BlacksTurn, bool BlackIsEnemy, Piece[,] Board, int CurrentX, int CurrentY, int MovingX, int MovingY)   // UnderCOnstruction!!!!!! 
        {

            if (CurrentX > MovingX && CurrentY < MovingY) // move Down/Left
            {
                int y = CurrentY;
                int x = CurrentX;
                while (y != MovingY)
                {
                    if (Board[CurrentX, y + 1] == Board[MovingX, MovingY])
                    {
                        if (Board[CurrentX, y + 1]._ImAlive == false || Board[CurrentX, y + 1]._ImBlack == !BlackIsEnemy) { return true; }
                    }
                    if (Board[CurrentX, y + 1]._ImAlive == true)
                    {
                        return false;
                    }
                    y++;
                }
            }
            //-----------------------------------------------------------------------------------------------//
            if (CurrentX == MovingX && CurrentY > MovingY) // DownRight
            {
                int y = CurrentY;
                while (y != MovingY)
                {
                    if (Board[CurrentX, y - 1] == Board[MovingX, MovingY])
                    {
                        if (Board[CurrentX, y - 1]._ImAlive == false || Board[CurrentX, y - 1]._ImBlack == !BlackIsEnemy) { return true; }
                    }
                    if (Board[CurrentX, y - 1]._ImAlive == true)
                    {
                        return false;
                    }
                    y--;
                }
            }
            //-----------------------------------------------------------------------------------------------//
            if (CurrentX < MovingX && CurrentY == MovingY) // move UpLeft
            {
                int x = CurrentX;
                while (x != MovingY)
                {
                    if (Board[x + 1, CurrentY] == Board[MovingX, MovingY])
                    {
                        if (Board[x + 1, CurrentY]._ImAlive == false || Board[x + 1, CurrentY]._ImBlack == !BlackIsEnemy) { return true; }
                    }
                    if (Board[x + 1, CurrentY]._ImAlive == true)
                    {
                        return false;
                    }
                    x++;
                }
            }
            //-----------------------------------------------------------------------------------------------//
            if (CurrentX > MovingX && CurrentY == MovingY) // move UpRight
            {
                int x = CurrentX;
                while (x != MovingY)
                {
                    if (Board[x - 1, CurrentY] == Board[MovingX, MovingY])
                    {
                        if (Board[x - 1, CurrentY]._ImAlive == false || Board[x - 1, CurrentY]._ImBlack == !BlackIsEnemy) { return true; }
                    }
                    if (Board[x - 1, CurrentY]._ImAlive == true)
                    {
                        return false;
                    }
                    x--;
                }
            }
            //-----------------------------------------------------------------------------------------------//

            return false; ;
        }
    }
}
