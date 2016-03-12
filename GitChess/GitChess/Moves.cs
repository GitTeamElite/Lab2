using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GitChess
{
    class Moves
    {
        public int XNumber;
        public int YNumber;
        public int Points;

       public Moves(int XNumber,int YNumber,int Points)
        {
            this.XNumber = XNumber;
            this.YNumber = YNumber;
            this.Points = Points;
        }
    }
}
