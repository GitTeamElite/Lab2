using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GitChess
{
    
   public  class Move
    {
       
        public int XPos;
        public int YPos;
        public int XMove;
        public int YMove;
        public int MovePoints;

       public Move(int XPos,int YPos,int XMove,int YMove,int MovePoints )
        {
           
            this.XMove = XMove;
            this.YMove = YMove;
            this.MovePoints = MovePoints;

            this.XPos = XPos;
            this.YPos = YPos;
        }
        public Move(int XPos, int YPos,int XMove, int YMove )
        {
            this.XMove = XMove;
            this.YMove = YMove;

            this.XPos = XPos;
            this.YPos = YPos;

        }
      public int _GetPoints()
        {
            return this.MovePoints;
        }
    }
}
