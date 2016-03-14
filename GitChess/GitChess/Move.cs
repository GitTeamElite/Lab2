using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GitChess
{
   public  class Move
    {
        public int XMove;
        public int YMove;
        public int Points;

       public Move(int XMove,int YMove,int Points)
        {
            this.XMove = XMove;
            this.YMove = YMove;
            this.Points = Points;
        }
    }
}
