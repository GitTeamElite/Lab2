using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GitBlackJack
{
    public class GameFlow
    {
        Deck deck = new Deck();
        Player player = new Player(100);
        Dealer dealer = new Dealer();
        bool playing = true;
        bool win = true;
       
      

        public GameFlow()
        { }
        /// <summary>
        /// Progess of the game - From start to end;
        /// </summary>
        public bool RunGame()
        {
            int DealerValue = 0;
            int DealerAceValue = 0;
            int playerValue = 0;
            int PlayerAceValue = 0;
            int SplitValue = 0;
            int SplitAceValue = 0;
            bool winSplit = false;
            bool split = false;
            dealer.CheckActiveDeck(deck);
            GamePresentation.LOGG();
            GamePresentation.ControlCheck(dealer, deck);

            dealer.ClearHand();  //Clear both hands
            player.ClearHand();

            int bet = player.Bet(); // Player set bet

            dealer.GetCardToDealer(); // Give cards to dealer and player
            player.GetCard(dealer.GiveCard());
            player.GetCard(dealer.GiveCard());
            GamePresentation.PrintGame(player.ShowPlayerHand(), dealer.ShowDealerHand(), bet, player.balance, split, player);
          
            split = Rules.SplittPosible(player.ShowPlayerHand(),player,bet);
            bool IWantSplit = false;
            if (split) { IWantSplit = GamePresentation.AskSplitt(dealer, player); }
            if (IWantSplit)
            {
                dealer.SplittPlayerCards(player);
                {
                    player.HitMeSplitt(player, dealer, bet, split);
                }
            }
            else
            {

                player.HitMe(player, dealer, bet,split); //Give player all his cards
            }

            GamePresentation.PrintGame(player.ShowPlayerHand(), dealer.ShowDealerHand(), bet, player.balance,split, player);


            if (Rules.NotOver21(StaticMethods.CountValue(player.ShowPlayerHand())))
            {
                GamePresentation.PrintGame(player.ShowPlayerHand(), dealer.ShowDealerHand(), bet, player.balance,split,player);

                dealer.DealerGetAllHisCards(player, dealer, bet,split); // Give dealer all his cards

                if (Rules.NotOver21(StaticMethods.CountValue(dealer.ShowDealerHand())) || Rules.NotOver21(StaticMethods.CountAceValue(dealer.ShowDealerHand())))
                {
                    

                    DealerValue = StaticMethods.CountValue(dealer.ShowDealerHand());
                    DealerAceValue = StaticMethods.CountAceValue(dealer.ShowDealerHand());
                    playerValue = StaticMethods.CountValue(player.ShowPlayerHand());
                    PlayerAceValue = StaticMethods.CountAceValue(player.ShowPlayerHand());
                    if (IWantSplit)
                    {
                        SplitValue = StaticMethods.CountValue(player.SplittHand);
                        SplitAceValue = StaticMethods.CountAceValue(player.SplittHand);
                    }

                    int PlayerwinValue = 0;
                    int SplitwinValue = 0;
                    int DealerwinValue = 0;


                    if (PlayerAceValue < 22) { PlayerwinValue = PlayerAceValue; } else if(playerValue<22){ PlayerwinValue = playerValue; } else { PlayerwinValue = 0; }
                    if (DealerAceValue < 22) { DealerwinValue = DealerAceValue; } else if (DealerValue<22) { DealerwinValue = DealerValue; } else { DealerwinValue = 0; }
                    if (SplitAceValue < 22) { SplitwinValue = SplitAceValue; }else if (SplitValue < 22){ SplitwinValue = SplitValue; } else { SplitwinValue = 0; }

                    win = Rules.PlayerWin(PlayerwinValue, DealerwinValue);
                    if (IWantSplit)
                    {
                        winSplit = Rules.PlayerWin(SplitwinValue, DealerwinValue);
                    }
                }
                else { win = true; }

            }
            else { win = false; }

          
            Rules.WinManager(win,winSplit, bet, player,IWantSplit);

            GamePresentation.EndMsg(player.ShowPlayerHand(), dealer.ShowDealerHand(), bet, player.balance, split, player,win,winSplit);


            if (player.balance < 1) { playing = false; GamePresentation.GameOver(); }
            return playing;
        }
    }

}



