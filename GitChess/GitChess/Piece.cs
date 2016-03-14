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
    }
}
