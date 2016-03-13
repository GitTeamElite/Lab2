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
  
     

        public Piece(bool _ImBlack)
        {
            this._ImBlack = _ImBlack;
            this._MyVisualLook = "   ";      
        }

        public virtual bool CheckMove(bool BlacksTurn, Piece[,] Board, int x, int y)
        {
            if (x < 0 || x > 7 || y < 0 || y > 7) { return false; }


            return true;
        }
       
       

    }
}
