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
        List<Moves> PossibleMoves;
     

        public Piece(bool _ImBlack)
        {
            this._ImBlack = _ImBlack;
            this._MyVisualLook = "   ";
            this.PossibleMoves = new List<Moves>();
        }

        public virtual bool CheckMove(int XDestination, int YDestination)
        {
            if (XDestination < 0 || XDestination > 7 || YDestination < 0 || XDestination > 7) { return false; }


            return true;
        }
        public void AddMoveToMoveList(int x, int y)
        {
            this.PossibleMoves.Add(new Moves(x, y, 0));
        }
       

    }
}
