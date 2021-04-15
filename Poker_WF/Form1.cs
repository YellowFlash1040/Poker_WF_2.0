using System;
using System.Collections.Generic;
using System.Windows.Forms;
using GraphicCards;
using GraphicPoker_Model;

namespace Poker_WF
{
    public partial class GameForm : Form
    {
        List<Control> FirstPlayerControls;
        List<Control> SecondPlayerControls;
        List<Control> ThirdPlayerControls;
        List<Control> FourthPlayerControls;
        List<Control> DillerControls;
        List<Control> TableControls;

        GraphicPokerGame Game;
        int countOfTimesDealCardsToPlayers_timerWasCalled = 0;
        int countOfTimesDoAutomaticBets_timerWasCalled = 0;

        public GameForm()
        {
            GraphicCards.GraphicCard graphicCard = new GraphicCards.GraphicCard(new PictureBox(), Cards.CardSuite.Club,
                Cards.CardFigure.Ace);
            InitializeComponent();

            FirstPlayerControls = new List<Control>();
            FirstPlayerControls.Add(FirstPlayer_BankLabel_label);
            FirstPlayerControls.Add(FirstPlayer_BankValue_label);
            FirstPlayerControls.Add(FirstPlayer_BetLabel_label);
            FirstPlayerControls.Add(FirstPlayer_BetValue_label);
            FirstPlayerControls.Add(FirstPlayer_Name_label);
            FirstPlayerControls.Add(FirstPlayer_panel);

            SecondPlayerControls = new List<Control>();
            SecondPlayerControls.Add(SecondPlayer_BankLabel_label);
            SecondPlayerControls.Add(SecondPlayer_BankValue_label);
            SecondPlayerControls.Add(SecondPlayer_BetLabel_label);
            SecondPlayerControls.Add(SecondPlayer_BetValue_label);
            SecondPlayerControls.Add(SecondPlayer_Name_label);
            SecondPlayerControls.Add(SecondPlayer_panel);

            ThirdPlayerControls = new List<Control>();
            ThirdPlayerControls.Add(ThirdPlayer_BankLabel_label);
            ThirdPlayerControls.Add(ThirdPlayer_BankValue_label);
            ThirdPlayerControls.Add(ThirdPlayer_BetLabel_label);
            ThirdPlayerControls.Add(ThirdPlayer_BetValue_label);
            ThirdPlayerControls.Add(ThirdPlayer_Name_label);
            ThirdPlayerControls.Add(ThirdPlayer_panel);

            FourthPlayerControls = new List<Control>();
            FourthPlayerControls.Add(FourthPlayer_BankLabel_label);
            FourthPlayerControls.Add(FourthPlayer_BankValue_label);
            FourthPlayerControls.Add(FourthPlayer_BetLabel_label);
            FourthPlayerControls.Add(FourthPlayer_BetValue_label);
            FourthPlayerControls.Add(fourthPlayer_Name_label);
            FourthPlayerControls.Add(FourthPlayer_panel);

            DillerControls = new List<Control>();
            DillerControls.Add(Diller_Name_label);
            DillerControls.Add(Diller_panel);

            TableControls = new List<Control>();
            TableControls.Add(RightWallOfTable_label);
            TableControls.Add(DownWallOfTable_label);
            TableControls.Add(LeftWallOfTable_label);
            TableControls.Add(UpWallOfTable_label);
            TableControls.Add(Table_label);
            TableControls.Add(Table_panel);
            TableControls.Add(GameBank_Value_Label);
            TableControls.Add(GameBank_label);

            GraphicPokerPlayer FirstPlayer = new GraphicPokerPlayer("FirstPlayer", new GraphicCardSet(FirstPlayer_panel), 1000,
               FirstPlayer_BankValue_label, FirstPlayer_BetValue_label, FirstPlayer_Raise_label, FirstPlayer_Check_label,
               FirstPlayer_Fold_label, FirstPlayer_Call_label, FirstPlayer_ConfirmRaiseBet_button,
               FirstPlayer_CanselRaiseBet_button, FirstPlayer_EnterValueOfRaiseBet_textBox, FirstPlayer_Winner_label,
               FirstPlayerCombination_Label);
            GraphicPokerPlayer SecondPlayer = new GraphicPokerPlayer("SecondPlayer", new GraphicCardSet(SecondPlayer_panel), 1000,
                SecondPlayer_BankValue_label, SecondPlayer_BetValue_label, SecondPlayer_Raise_label, SecondPlayer_Check_label,
                SecondPlayer_Fold_label, SecondPlayer_Call_label, SecondPlayer_ConfirmRaiseBet_button,
                SecondPlayer_CanselRaiseBet_button, SecondPlayer_EnterValueOfRaiseBet_textBox, SecondPlayer_Winner_label,
                SecondPlayerCombination_Label);
            GraphicPokerPlayer ThirdPlayer = new GraphicPokerPlayer("ThirdPlayer", new GraphicCardSet(ThirdPlayer_panel), 1000,
                ThirdPlayer_BankValue_label, ThirdPlayer_BetValue_label, ThirdPlayer_Raise_label, ThirdPlayer_Check_label,
                ThirdPlayer_Fold_label, ThirdPlayer_Call_label, ThirdPlayer_ConfirmRaiseBet_button,
                ThirdPlayer_CanselRaiseBet_button, ThirdPlayer_EnterValueOfRaiseBet_textBox, ThirdPlayer_Winner_label,
                ThirdPlayerCombination_Label);
            GraphicPokerPlayer FourthPlayer = new GraphicPokerPlayer("FourthPlayer", new GraphicCardSet(FourthPlayer_panel), 1000,
                FourthPlayer_BankValue_label, FourthPlayer_BetValue_label, FourthPlayer_Raise_label, FourthPlayer_Check_label,
                FourthPlayer_Fold_label, FourthPlayer_Call_label, FourthPlayer_ConfirmRaiseBet_button,
                FourthPlayer_CanselRaiseBet_button, FourthPlayer_EnterValueOfRaiseBet_textBox, FourthPlayer_Winner_label,
                FourthPlayerCombination_Label);

            List<GraphicPokerPlayer> players = new List<GraphicPokerPlayer>() { FirstPlayer, SecondPlayer, ThirdPlayer,
                FourthPlayer };
            Game = new GraphicPokerGame(players, Table_panel, Diller_panel, GameBank_Value_Label, RestartGame_button);
        }

        private void Play_button_Click(object sender, EventArgs e)
        {
            Play_button.Visible = false;
            MakeVisibleAllControls();
            StartTimer_DealCardsToPlayersTimer();
        }

        private void StartTimer_DealCardsToPlayersTimer()
        {
            DealCardsToPlayers_timer.Start();
        }

        private void DealCardsToPlayers_timer_Tick(object sender, EventArgs e)
        {
            if (countOfTimesDealCardsToPlayers_timerWasCalled < Game.Players.Count)
            {
                Game.DealTwoCardsFromDeckToPlayer(Game.Players[countOfTimesDealCardsToPlayers_timerWasCalled].Name);
                countOfTimesDealCardsToPlayers_timerWasCalled++;

                if (countOfTimesDealCardsToPlayers_timerWasCalled == Game.Players.Count)
                {
                    DealCardsToPlayers_timer.Stop();
                    countOfTimesDealCardsToPlayers_timerWasCalled = 0;
                    DoAutomaticBets_timer.Start();
                }
            }
        }

        private void DoAutomaticBets_timer_Tick(object sender, EventArgs e)
        {
            if (countOfTimesDoAutomaticBets_timerWasCalled < 2)
            {
                Game.DoAutomaticBet();
                countOfTimesDoAutomaticBets_timerWasCalled++;

                if (countOfTimesDoAutomaticBets_timerWasCalled == 2)
                {
                    DoAutomaticBets_timer.Stop();
                    countOfTimesDoAutomaticBets_timerWasCalled = 0;
                }
            }
        }

        private void MakeVisibleAllControls()
        {
            List<List<Control>> allControlsLists = new List<List<Control>>();
            allControlsLists.Add(FourthPlayerControls);
            allControlsLists.Add(DillerControls);
            allControlsLists.Add(TableControls);
            allControlsLists.Add(ThirdPlayerControls);
            allControlsLists.Add(FirstPlayerControls);
            allControlsLists.Add(SecondPlayerControls);

            foreach (var list in allControlsLists)
            {
                foreach (var control in list)
                {
                    control.Visible = true;
                }
            }

            Table_panel.BringToFront();
            GameBank_Value_Label.BringToFront();
        }

        private void RestartGame_button_Click(object sender, EventArgs e)
        {
            RestartGame_button.Visible = false;
            RestartGame();
        }

        private void RestartGame()
        {
            Game.Restart();
            StartTimer_DealCardsToPlayersTimer();
        }

        private void Raise()
        {
            Game.MakeVisibleWriteSumOfRaiseMenu();
        }

        private void Confirm()
        {
            string result = Game.ConfirmRaise();
            if (result != null)
            {
                MessageBox.Show(result);
            }
        }

        private void Check()
        {
            Game.Check();
        }

        private void Call()
        {
            Game.Call();
        }

        private void Fold()
        {
            Game.Fold();
        }

        //////11111111111111111111111/////
        private void FirstPlayer_Fold_label_Click(object sender, EventArgs e)
        {
            Fold();
        }

        private void FirstPlayer_Check_label_Click(object sender, EventArgs e)
        {
            Check();
        }

        private void FirstPlayer_Raise_label_Click(object sender, EventArgs e)
        {
            Raise();
        }

        private void FirstPlayer_Call_label_Click(object sender, EventArgs e)
        {
            Call();
        }

        private void FirstPlayer_ConfirmRaiseBet_button_Click(object sender, EventArgs e)
        {
            Confirm();
        }

        private void FirstPlayer_CanselRaiseBet_button_Click(object sender, EventArgs e)
        {
            Game.MakeInVisibleWriteSumOfRaiseMenu();
        }

        private void FirstPlayer_EnterValueOfRaiseBet_textBox_TextChanged(object sender, EventArgs e)
        {
            if (FirstPlayer_EnterValueOfRaiseBet_textBox.Text != "")
            {
                FirstPlayer_ConfirmRaiseBet_button.Enabled = true;
            }
            else
            {
                FirstPlayer_ConfirmRaiseBet_button.Enabled = false;
            }
        }
        //////////222222222222222222222222/////////////
        private void SecondPlayer_Raise_label_Click(object sender, EventArgs e)
        {
            Raise();
        }

        private void SecondPlayer_Check_label_Click(object sender, EventArgs e)
        {
            Check();
        }

        private void SecondPlayer_Fold_label_Click(object sender, EventArgs e)
        {
            Fold();
        }

        private void SecondPlayer_Call_label_Click(object sender, EventArgs e)
        {
            Call();
        }

        private void SecondPlayer_ConfirmRaiseBet_button_Click(object sender, EventArgs e)
        {
            Confirm();
        }

        private void SecondPlayer_CanselRaiseBet_button_Click(object sender, EventArgs e)
        {
            Game.MakeInVisibleWriteSumOfRaiseMenu();
        }

        private void SecondPlayer_EnterValueOfRaiseBet_textBox_TextChanged(object sender, EventArgs e)
        {
            if (SecondPlayer_EnterValueOfRaiseBet_textBox.Text != "")
            {
                SecondPlayer_ConfirmRaiseBet_button.Enabled = true;
            }
            else
            {
                SecondPlayer_ConfirmRaiseBet_button.Enabled = false;
            }
        }
        ///////////333333333333333333333333////////////
        private void ThirdPlayer_Raise_label_Click(object sender, EventArgs e)
        {
            Raise();
        }

        private void ThirdPlayer_Check_label_Click(object sender, EventArgs e)
        {
            Check();
        }

        private void ThirdPlayer_Fold_label_Click(object sender, EventArgs e)
        {
            Fold();
        }

        private void ThirdPlayer_Call_label_Click(object sender, EventArgs e)
        {
            Call();
        }

        private void ThirdPlayer_ConfirmRaiseBet_button_Click(object sender, EventArgs e)
        {
            Confirm();
        }

        private void ThirdPlayer_CanselRaiseBet_button_Click(object sender, EventArgs e)
        {
            Game.MakeInVisibleWriteSumOfRaiseMenu();
        }

        private void ThirdPlayer_EnterValueOfRaiseBet_textBox_TextChanged(object sender, EventArgs e)
        {
            if (ThirdPlayer_EnterValueOfRaiseBet_textBox.Text != "")
            {
                ThirdPlayer_ConfirmRaiseBet_button.Enabled = true;
            }
            else
            {
                ThirdPlayer_ConfirmRaiseBet_button.Enabled = false;
            }
        }
        ///////////4444444444444444444//////
        private void FourthPlayer_Raise_label_Click(object sender, EventArgs e)
        {
            Raise();
        }

        private void FourthPlayer_Check_label_Click(object sender, EventArgs e)
        {
            Check();
        }

        private void FourthPlayer_Fold_label_Click(object sender, EventArgs e)
        {
            Fold();
        }

        private void FourthPlayer_Call_label_Click(object sender, EventArgs e)
        {
            Call();
        }

        private void FourthPlayer_ConfirmRaiseBet_button_Click(object sender, EventArgs e)
        {
            Confirm();
        }

        private void FourthPlayer_CanselRaiseBet_button_Click(object sender, EventArgs e)
        {
            Game.MakeInVisibleWriteSumOfRaiseMenu();
        }

        private void FourthPlayer_EnterValueOfRaiseBet_textBox_TextChanged(object sender, EventArgs e)
        {
            if (FourthPlayer_EnterValueOfRaiseBet_textBox.Text != "")
            {
                FourthPlayer_ConfirmRaiseBet_button.Enabled = true;
            }
            else
            {
                FourthPlayer_ConfirmRaiseBet_button.Enabled = false;
            }
        }
    }
}
