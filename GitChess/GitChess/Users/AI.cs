using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace GitChess
{
    public class AI
    {
        List<Piece> UserPieceList;
        List< Move> ListWithBestMoves;
        List<Move> PossibleMoves;

        bool IsBlack;
        public AI(bool IsBlack)
        {
            this.UserPieceList = new List<Piece>();
            this.PossibleMoves = new List<Move>();
            this.ListWithBestMoves = new List<Move>();
            this.IsBlack = IsBlack;
        }

        public void Move(bool BlacksTurn, Piece[,] Board)
        {
            
            UserPieceList.Clear();
            ListWithBestMoves.Clear();
            PossibleMoves.Clear();
           
            FillUserPieceList(Board, BlacksTurn);
            FillMoveList();      
            FillBestMoveLIst();

            MoverMall(Board, BlacksTurn, ListWithBestMoves);
    
     
        }
        public void MoverMall(Piece[,] Board, bool BlacksTurn,List<Move> MovingList)
        {
            Random random = new Random();
            int randomPick = random.Next(MovingList.Count);
            int y = MovingList[randomPick].YPos;
            int x = MovingList[randomPick].XPos;

            int yTo = MovingList[randomPick].YMove;
            int xTo = MovingList[randomPick].XMove;

            Printer.PrintGameHighLights(Board, BlacksTurn, x, y, xTo, yTo);
            Console.ReadKey();

            Board[xTo, yTo] = Board[x, y];
            Board[x, y] = new Piece();
        }

        public void FillUserPieceList(Piece[,] Board, bool BlacksTurn)
        {
            foreach (var item in Board)
            {
                if (item._ImBlack == BlacksTurn)
                {
                    UserPieceList.Add(item);
                }
            }
        }
        public int GetHighestPoint()
        {
            int Highest = -1;
            {
                foreach (var item in PossibleMoves)
                {
                    if (Highest < item.MovePoints) { Highest = item.MovePoints; }
                }
            }
            return Highest;
        }
        public void FillBestMoveLIst()
        {
            int highest = GetHighestPoint();
            foreach (var item in PossibleMoves)
            {
                if (item.MovePoints >= highest) { ListWithBestMoves.Add(item); }
            }
        }

        public void FillMoveList()
        {
            foreach (var item in UserPieceList)
            {
                foreach (var item2 in item.AvilibleMoves)
                {
                    PossibleMoves.Add(item2);
                }
            }
        }
     

    }
}
