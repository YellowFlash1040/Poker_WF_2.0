namespace Poker_WF
{
    partial class GameForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GameForm));
            this.FirstPlayer_panel = new System.Windows.Forms.Panel();
            this.SecondPlayer_panel = new System.Windows.Forms.Panel();
            this.ThirdPlayer_panel = new System.Windows.Forms.Panel();
            this.FourthPlayer_panel = new System.Windows.Forms.Panel();
            this.Table_panel = new System.Windows.Forms.Panel();
            this.Play_button = new System.Windows.Forms.Button();
            this.Table_label = new System.Windows.Forms.Label();
            this.LeftWallOfTable_label = new System.Windows.Forms.Label();
            this.UpWallOfTable_label = new System.Windows.Forms.Label();
            this.RightWallOfTable_label = new System.Windows.Forms.Label();
            this.DownWallOfTable_label = new System.Windows.Forms.Label();
            this.Diller_panel = new System.Windows.Forms.Panel();
            this.FirstPlayer_Name_label = new System.Windows.Forms.Label();
            this.SecondPlayer_Name_label = new System.Windows.Forms.Label();
            this.ThirdPlayer_Name_label = new System.Windows.Forms.Label();
            this.fourthPlayer_Name_label = new System.Windows.Forms.Label();
            this.Diller_Name_label = new System.Windows.Forms.Label();
            this.ThirdPlayer_Fold_label = new System.Windows.Forms.Label();
            this.ThirdPlayer_Raise_label = new System.Windows.Forms.Label();
            this.ThirdPlayer_Call_label = new System.Windows.Forms.Label();
            this.ThirdPlayer_Check_label = new System.Windows.Forms.Label();
            this.FourthPlayer_Check_label = new System.Windows.Forms.Label();
            this.FourthPlayer_Call_label = new System.Windows.Forms.Label();
            this.FourthPlayer_Raise_label = new System.Windows.Forms.Label();
            this.FourthPlayer_Fold_label = new System.Windows.Forms.Label();
            this.FirstPlayer_Check_label = new System.Windows.Forms.Label();
            this.FirstPlayer_Call_label = new System.Windows.Forms.Label();
            this.FirstPlayer_Raise_label = new System.Windows.Forms.Label();
            this.FirstPlayer_Fold_label = new System.Windows.Forms.Label();
            this.SecondPlayer_Check_label = new System.Windows.Forms.Label();
            this.SecondPlayer_Call_label = new System.Windows.Forms.Label();
            this.SecondPlayer_Raise_label = new System.Windows.Forms.Label();
            this.SecondPlayer_Fold_label = new System.Windows.Forms.Label();
            this.FirstPlayer_BankValue_label = new System.Windows.Forms.Label();
            this.FirstPlayer_BetValue_label = new System.Windows.Forms.Label();
            this.FirstPlayer_BetLabel_label = new System.Windows.Forms.Label();
            this.FirstPlayer_BankLabel_label = new System.Windows.Forms.Label();
            this.SecondPlayer_BetLabel_label = new System.Windows.Forms.Label();
            this.SecondPlayer_BankLabel_label = new System.Windows.Forms.Label();
            this.SecondPlayer_BetValue_label = new System.Windows.Forms.Label();
            this.SecondPlayer_BankValue_label = new System.Windows.Forms.Label();
            this.ThirdPlayer_BetLabel_label = new System.Windows.Forms.Label();
            this.ThirdPlayer_BankLabel_label = new System.Windows.Forms.Label();
            this.ThirdPlayer_BetValue_label = new System.Windows.Forms.Label();
            this.ThirdPlayer_BankValue_label = new System.Windows.Forms.Label();
            this.FourthPlayer_BetLabel_label = new System.Windows.Forms.Label();
            this.FourthPlayer_BankLabel_label = new System.Windows.Forms.Label();
            this.FourthPlayer_BetValue_label = new System.Windows.Forms.Label();
            this.FourthPlayer_BankValue_label = new System.Windows.Forms.Label();
            this.GameBank_Value_Label = new System.Windows.Forms.Label();
            this.FirstPlayer_EnterValueOfRaiseBet_textBox = new System.Windows.Forms.TextBox();
            this.FirstPlayer_ConfirmRaiseBet_button = new System.Windows.Forms.Button();
            this.FourthPlayer_ConfirmRaiseBet_button = new System.Windows.Forms.Button();
            this.FourthPlayer_EnterValueOfRaiseBet_textBox = new System.Windows.Forms.TextBox();
            this.ThirdPlayer_ConfirmRaiseBet_button = new System.Windows.Forms.Button();
            this.ThirdPlayer_EnterValueOfRaiseBet_textBox = new System.Windows.Forms.TextBox();
            this.SecondPlayer_ConfirmRaiseBet_button = new System.Windows.Forms.Button();
            this.SecondPlayer_EnterValueOfRaiseBet_textBox = new System.Windows.Forms.TextBox();
            this.FirstPlayer_CanselRaiseBet_button = new System.Windows.Forms.Button();
            this.SecondPlayer_CanselRaiseBet_button = new System.Windows.Forms.Button();
            this.ThirdPlayer_CanselRaiseBet_button = new System.Windows.Forms.Button();
            this.FourthPlayer_CanselRaiseBet_button = new System.Windows.Forms.Button();
            this.GameBank_label = new System.Windows.Forms.Label();
            this.GameFone_pictureBox = new System.Windows.Forms.PictureBox();
            this.FourthPlayer_Winner_label = new System.Windows.Forms.Label();
            this.FirstPlayer_Winner_label = new System.Windows.Forms.Label();
            this.ThirdPlayer_Winner_label = new System.Windows.Forms.Label();
            this.SecondPlayer_Winner_label = new System.Windows.Forms.Label();
            this.RestartGame_button = new System.Windows.Forms.Button();
            this.FourthPlayerCombination_Label = new System.Windows.Forms.Label();
            this.ThirdPlayerCombination_Label = new System.Windows.Forms.Label();
            this.SecondPlayerCombination_Label = new System.Windows.Forms.Label();
            this.FirstPlayerCombination_Label = new System.Windows.Forms.Label();
            this.DoAutomaticBets_timer = new System.Windows.Forms.Timer(this.components);
            this.DealCardsToPlayers_timer = new System.Windows.Forms.Timer(this.components);
            this.PauseBeetweenRounds_timer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.GameFone_pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // FirstPlayer_panel
            // 
            this.FirstPlayer_panel.BackColor = System.Drawing.Color.OliveDrab;
            this.FirstPlayer_panel.Location = new System.Drawing.Point(841, 254);
            this.FirstPlayer_panel.Name = "FirstPlayer_panel";
            this.FirstPlayer_panel.Size = new System.Drawing.Size(200, 100);
            this.FirstPlayer_panel.TabIndex = 0;
            this.FirstPlayer_panel.UseWaitCursor = true;
            this.FirstPlayer_panel.Visible = false;
            // 
            // SecondPlayer_panel
            // 
            this.SecondPlayer_panel.BackColor = System.Drawing.Color.OliveDrab;
            this.SecondPlayer_panel.Location = new System.Drawing.Point(818, 536);
            this.SecondPlayer_panel.Name = "SecondPlayer_panel";
            this.SecondPlayer_panel.Size = new System.Drawing.Size(200, 100);
            this.SecondPlayer_panel.TabIndex = 1;
            this.SecondPlayer_panel.UseWaitCursor = true;
            this.SecondPlayer_panel.Visible = false;
            // 
            // ThirdPlayer_panel
            // 
            this.ThirdPlayer_panel.BackColor = System.Drawing.Color.OliveDrab;
            this.ThirdPlayer_panel.Location = new System.Drawing.Point(406, 555);
            this.ThirdPlayer_panel.Name = "ThirdPlayer_panel";
            this.ThirdPlayer_panel.Size = new System.Drawing.Size(200, 100);
            this.ThirdPlayer_panel.TabIndex = 2;
            this.ThirdPlayer_panel.UseWaitCursor = true;
            this.ThirdPlayer_panel.Visible = false;
            // 
            // FourthPlayer_panel
            // 
            this.FourthPlayer_panel.BackColor = System.Drawing.Color.OliveDrab;
            this.FourthPlayer_panel.Location = new System.Drawing.Point(67, 167);
            this.FourthPlayer_panel.Name = "FourthPlayer_panel";
            this.FourthPlayer_panel.Size = new System.Drawing.Size(200, 100);
            this.FourthPlayer_panel.TabIndex = 3;
            this.FourthPlayer_panel.UseWaitCursor = true;
            this.FourthPlayer_panel.Visible = false;
            // 
            // Table_panel
            // 
            this.Table_panel.BackColor = System.Drawing.Color.ForestGreen;
            this.Table_panel.Location = new System.Drawing.Point(363, 332);
            this.Table_panel.Name = "Table_panel";
            this.Table_panel.Size = new System.Drawing.Size(388, 100);
            this.Table_panel.TabIndex = 4;
            this.Table_panel.UseWaitCursor = true;
            this.Table_panel.Visible = false;
            // 
            // Play_button
            // 
            this.Play_button.Location = new System.Drawing.Point(520, 370);
            this.Play_button.Name = "Play_button";
            this.Play_button.Size = new System.Drawing.Size(75, 23);
            this.Play_button.TabIndex = 5;
            this.Play_button.Text = "Play";
            this.Play_button.UseVisualStyleBackColor = true;
            this.Play_button.UseWaitCursor = true;
            this.Play_button.Click += new System.EventHandler(this.Play_button_Click);
            // 
            // Table_label
            // 
            this.Table_label.BackColor = System.Drawing.Color.ForestGreen;
            this.Table_label.Location = new System.Drawing.Point(347, 291);
            this.Table_label.Name = "Table_label";
            this.Table_label.Size = new System.Drawing.Size(413, 206);
            this.Table_label.TabIndex = 6;
            this.Table_label.UseWaitCursor = true;
            this.Table_label.Visible = false;
            // 
            // LeftWallOfTable_label
            // 
            this.LeftWallOfTable_label.BackColor = System.Drawing.Color.SaddleBrown;
            this.LeftWallOfTable_label.Location = new System.Drawing.Point(324, 291);
            this.LeftWallOfTable_label.Name = "LeftWallOfTable_label";
            this.LeftWallOfTable_label.Size = new System.Drawing.Size(33, 206);
            this.LeftWallOfTable_label.TabIndex = 7;
            this.LeftWallOfTable_label.UseWaitCursor = true;
            this.LeftWallOfTable_label.Visible = false;
            // 
            // UpWallOfTable_label
            // 
            this.UpWallOfTable_label.BackColor = System.Drawing.Color.SaddleBrown;
            this.UpWallOfTable_label.Location = new System.Drawing.Point(324, 254);
            this.UpWallOfTable_label.Name = "UpWallOfTable_label";
            this.UpWallOfTable_label.Size = new System.Drawing.Size(466, 37);
            this.UpWallOfTable_label.TabIndex = 8;
            this.UpWallOfTable_label.UseWaitCursor = true;
            this.UpWallOfTable_label.Visible = false;
            // 
            // RightWallOfTable_label
            // 
            this.RightWallOfTable_label.BackColor = System.Drawing.Color.SaddleBrown;
            this.RightWallOfTable_label.Location = new System.Drawing.Point(757, 291);
            this.RightWallOfTable_label.Name = "RightWallOfTable_label";
            this.RightWallOfTable_label.Size = new System.Drawing.Size(33, 206);
            this.RightWallOfTable_label.TabIndex = 9;
            this.RightWallOfTable_label.UseWaitCursor = true;
            this.RightWallOfTable_label.Visible = false;
            // 
            // DownWallOfTable_label
            // 
            this.DownWallOfTable_label.BackColor = System.Drawing.Color.SaddleBrown;
            this.DownWallOfTable_label.Location = new System.Drawing.Point(324, 497);
            this.DownWallOfTable_label.Name = "DownWallOfTable_label";
            this.DownWallOfTable_label.Size = new System.Drawing.Size(466, 37);
            this.DownWallOfTable_label.TabIndex = 10;
            this.DownWallOfTable_label.UseWaitCursor = true;
            this.DownWallOfTable_label.Visible = false;
            // 
            // Diller_panel
            // 
            this.Diller_panel.BackColor = System.Drawing.Color.OliveDrab;
            this.Diller_panel.Location = new System.Drawing.Point(511, 138);
            this.Diller_panel.Name = "Diller_panel";
            this.Diller_panel.Size = new System.Drawing.Size(85, 104);
            this.Diller_panel.TabIndex = 11;
            this.Diller_panel.UseWaitCursor = true;
            this.Diller_panel.Visible = false;
            // 
            // FirstPlayer_Name_label
            // 
            this.FirstPlayer_Name_label.AutoSize = true;
            this.FirstPlayer_Name_label.Location = new System.Drawing.Point(917, 238);
            this.FirstPlayer_Name_label.Name = "FirstPlayer_Name_label";
            this.FirstPlayer_Name_label.Size = new System.Drawing.Size(58, 13);
            this.FirstPlayer_Name_label.TabIndex = 0;
            this.FirstPlayer_Name_label.Text = "First Player";
            this.FirstPlayer_Name_label.UseWaitCursor = true;
            this.FirstPlayer_Name_label.Visible = false;
            // 
            // SecondPlayer_Name_label
            // 
            this.SecondPlayer_Name_label.AutoSize = true;
            this.SecondPlayer_Name_label.Location = new System.Drawing.Point(887, 520);
            this.SecondPlayer_Name_label.Name = "SecondPlayer_Name_label";
            this.SecondPlayer_Name_label.Size = new System.Drawing.Size(76, 13);
            this.SecondPlayer_Name_label.TabIndex = 12;
            this.SecondPlayer_Name_label.Text = "Second Player";
            this.SecondPlayer_Name_label.UseWaitCursor = true;
            this.SecondPlayer_Name_label.Visible = false;
            // 
            // ThirdPlayer_Name_label
            // 
            this.ThirdPlayer_Name_label.AutoSize = true;
            this.ThirdPlayer_Name_label.Location = new System.Drawing.Point(469, 667);
            this.ThirdPlayer_Name_label.Name = "ThirdPlayer_Name_label";
            this.ThirdPlayer_Name_label.Size = new System.Drawing.Size(63, 13);
            this.ThirdPlayer_Name_label.TabIndex = 13;
            this.ThirdPlayer_Name_label.Text = "Third Player";
            this.ThirdPlayer_Name_label.UseWaitCursor = true;
            this.ThirdPlayer_Name_label.Visible = false;
            // 
            // fourthPlayer_Name_label
            // 
            this.fourthPlayer_Name_label.AutoSize = true;
            this.fourthPlayer_Name_label.Location = new System.Drawing.Point(132, 151);
            this.fourthPlayer_Name_label.Name = "fourthPlayer_Name_label";
            this.fourthPlayer_Name_label.Size = new System.Drawing.Size(69, 13);
            this.fourthPlayer_Name_label.TabIndex = 14;
            this.fourthPlayer_Name_label.Text = "Fourth Player";
            this.fourthPlayer_Name_label.UseWaitCursor = true;
            this.fourthPlayer_Name_label.Visible = false;
            // 
            // Diller_Name_label
            // 
            this.Diller_Name_label.AutoSize = true;
            this.Diller_Name_label.Location = new System.Drawing.Point(539, 107);
            this.Diller_Name_label.Name = "Diller_Name_label";
            this.Diller_Name_label.Size = new System.Drawing.Size(30, 13);
            this.Diller_Name_label.TabIndex = 15;
            this.Diller_Name_label.Text = "Diller";
            this.Diller_Name_label.UseWaitCursor = true;
            this.Diller_Name_label.Visible = false;
            // 
            // ThirdPlayer_Fold_label
            // 
            this.ThirdPlayer_Fold_label.BackColor = System.Drawing.Color.OrangeRed;
            this.ThirdPlayer_Fold_label.Location = new System.Drawing.Point(369, 700);
            this.ThirdPlayer_Fold_label.Name = "ThirdPlayer_Fold_label";
            this.ThirdPlayer_Fold_label.Size = new System.Drawing.Size(77, 41);
            this.ThirdPlayer_Fold_label.TabIndex = 17;
            this.ThirdPlayer_Fold_label.Text = "\r\n        Fold";
            this.ThirdPlayer_Fold_label.UseWaitCursor = true;
            this.ThirdPlayer_Fold_label.Visible = false;
            // 
            // ThirdPlayer_Raise_label
            // 
            this.ThirdPlayer_Raise_label.BackColor = System.Drawing.Color.YellowGreen;
            this.ThirdPlayer_Raise_label.Location = new System.Drawing.Point(568, 700);
            this.ThirdPlayer_Raise_label.Name = "ThirdPlayer_Raise_label";
            this.ThirdPlayer_Raise_label.Size = new System.Drawing.Size(77, 41);
            this.ThirdPlayer_Raise_label.TabIndex = 18;
            this.ThirdPlayer_Raise_label.Text = "       \r\n       Raise";
            this.ThirdPlayer_Raise_label.UseWaitCursor = true;
            this.ThirdPlayer_Raise_label.Visible = false;
            // 
            // ThirdPlayer_Call_label
            // 
            this.ThirdPlayer_Call_label.BackColor = System.Drawing.Color.Gold;
            this.ThirdPlayer_Call_label.Location = new System.Drawing.Point(469, 700);
            this.ThirdPlayer_Call_label.Name = "ThirdPlayer_Call_label";
            this.ThirdPlayer_Call_label.Size = new System.Drawing.Size(77, 41);
            this.ThirdPlayer_Call_label.TabIndex = 19;
            this.ThirdPlayer_Call_label.Text = "\r\n         Call";
            this.ThirdPlayer_Call_label.UseWaitCursor = true;
            this.ThirdPlayer_Call_label.Visible = false;
            // 
            // ThirdPlayer_Check_label
            // 
            this.ThirdPlayer_Check_label.BackColor = System.Drawing.Color.Gold;
            this.ThirdPlayer_Check_label.Location = new System.Drawing.Point(469, 700);
            this.ThirdPlayer_Check_label.Name = "ThirdPlayer_Check_label";
            this.ThirdPlayer_Check_label.Size = new System.Drawing.Size(77, 41);
            this.ThirdPlayer_Check_label.TabIndex = 20;
            this.ThirdPlayer_Check_label.Text = "\r\n       Check";
            this.ThirdPlayer_Check_label.UseWaitCursor = true;
            this.ThirdPlayer_Check_label.Visible = false;
            // 
            // FourthPlayer_Check_label
            // 
            this.FourthPlayer_Check_label.BackColor = System.Drawing.Color.Gold;
            this.FourthPlayer_Check_label.Location = new System.Drawing.Point(124, 279);
            this.FourthPlayer_Check_label.Name = "FourthPlayer_Check_label";
            this.FourthPlayer_Check_label.Size = new System.Drawing.Size(77, 41);
            this.FourthPlayer_Check_label.TabIndex = 24;
            this.FourthPlayer_Check_label.Text = "\r\n       Check";
            this.FourthPlayer_Check_label.UseWaitCursor = true;
            this.FourthPlayer_Check_label.Visible = false;
            // 
            // FourthPlayer_Call_label
            // 
            this.FourthPlayer_Call_label.BackColor = System.Drawing.Color.Gold;
            this.FourthPlayer_Call_label.Location = new System.Drawing.Point(124, 279);
            this.FourthPlayer_Call_label.Name = "FourthPlayer_Call_label";
            this.FourthPlayer_Call_label.Size = new System.Drawing.Size(77, 41);
            this.FourthPlayer_Call_label.TabIndex = 23;
            this.FourthPlayer_Call_label.Text = "\r\n         Call";
            this.FourthPlayer_Call_label.UseWaitCursor = true;
            this.FourthPlayer_Call_label.Visible = false;
            // 
            // FourthPlayer_Raise_label
            // 
            this.FourthPlayer_Raise_label.BackColor = System.Drawing.Color.YellowGreen;
            this.FourthPlayer_Raise_label.Location = new System.Drawing.Point(223, 279);
            this.FourthPlayer_Raise_label.Name = "FourthPlayer_Raise_label";
            this.FourthPlayer_Raise_label.Size = new System.Drawing.Size(77, 41);
            this.FourthPlayer_Raise_label.TabIndex = 22;
            this.FourthPlayer_Raise_label.Text = "       \r\n       Raise";
            this.FourthPlayer_Raise_label.UseWaitCursor = true;
            this.FourthPlayer_Raise_label.Visible = false;
            // 
            // FourthPlayer_Fold_label
            // 
            this.FourthPlayer_Fold_label.BackColor = System.Drawing.Color.OrangeRed;
            this.FourthPlayer_Fold_label.Location = new System.Drawing.Point(24, 279);
            this.FourthPlayer_Fold_label.Name = "FourthPlayer_Fold_label";
            this.FourthPlayer_Fold_label.Size = new System.Drawing.Size(77, 41);
            this.FourthPlayer_Fold_label.TabIndex = 21;
            this.FourthPlayer_Fold_label.Text = "\r\n        Fold";
            this.FourthPlayer_Fold_label.UseWaitCursor = true;
            this.FourthPlayer_Fold_label.Visible = false;
            // 
            // FirstPlayer_Check_label
            // 
            this.FirstPlayer_Check_label.BackColor = System.Drawing.Color.Gold;
            this.FirstPlayer_Check_label.Location = new System.Drawing.Point(908, 369);
            this.FirstPlayer_Check_label.Name = "FirstPlayer_Check_label";
            this.FirstPlayer_Check_label.Size = new System.Drawing.Size(77, 41);
            this.FirstPlayer_Check_label.TabIndex = 28;
            this.FirstPlayer_Check_label.Text = "\r\n       Check";
            this.FirstPlayer_Check_label.UseWaitCursor = true;
            this.FirstPlayer_Check_label.Visible = false;
            // 
            // FirstPlayer_Call_label
            // 
            this.FirstPlayer_Call_label.BackColor = System.Drawing.Color.Gold;
            this.FirstPlayer_Call_label.Location = new System.Drawing.Point(908, 369);
            this.FirstPlayer_Call_label.Name = "FirstPlayer_Call_label";
            this.FirstPlayer_Call_label.Size = new System.Drawing.Size(77, 41);
            this.FirstPlayer_Call_label.TabIndex = 27;
            this.FirstPlayer_Call_label.Text = "\r\n         Call";
            this.FirstPlayer_Call_label.UseWaitCursor = true;
            this.FirstPlayer_Call_label.Visible = false;
            // 
            // FirstPlayer_Raise_label
            // 
            this.FirstPlayer_Raise_label.BackColor = System.Drawing.Color.YellowGreen;
            this.FirstPlayer_Raise_label.Location = new System.Drawing.Point(1007, 369);
            this.FirstPlayer_Raise_label.Name = "FirstPlayer_Raise_label";
            this.FirstPlayer_Raise_label.Size = new System.Drawing.Size(77, 41);
            this.FirstPlayer_Raise_label.TabIndex = 26;
            this.FirstPlayer_Raise_label.Text = "       \r\n       Raise";
            this.FirstPlayer_Raise_label.UseWaitCursor = true;
            this.FirstPlayer_Raise_label.Visible = false;
            // 
            // FirstPlayer_Fold_label
            // 
            this.FirstPlayer_Fold_label.BackColor = System.Drawing.Color.OrangeRed;
            this.FirstPlayer_Fold_label.Location = new System.Drawing.Point(808, 369);
            this.FirstPlayer_Fold_label.Name = "FirstPlayer_Fold_label";
            this.FirstPlayer_Fold_label.Size = new System.Drawing.Size(77, 41);
            this.FirstPlayer_Fold_label.TabIndex = 25;
            this.FirstPlayer_Fold_label.Text = "\r\n        Fold";
            this.FirstPlayer_Fold_label.UseWaitCursor = true;
            this.FirstPlayer_Fold_label.Visible = false;
            // 
            // SecondPlayer_Check_label
            // 
            this.SecondPlayer_Check_label.BackColor = System.Drawing.Color.Gold;
            this.SecondPlayer_Check_label.Location = new System.Drawing.Point(886, 639);
            this.SecondPlayer_Check_label.Name = "SecondPlayer_Check_label";
            this.SecondPlayer_Check_label.Size = new System.Drawing.Size(77, 41);
            this.SecondPlayer_Check_label.TabIndex = 32;
            this.SecondPlayer_Check_label.Text = "\r\n       Check";
            this.SecondPlayer_Check_label.UseWaitCursor = true;
            this.SecondPlayer_Check_label.Visible = false;
            // 
            // SecondPlayer_Call_label
            // 
            this.SecondPlayer_Call_label.BackColor = System.Drawing.Color.Gold;
            this.SecondPlayer_Call_label.Location = new System.Drawing.Point(886, 639);
            this.SecondPlayer_Call_label.Name = "SecondPlayer_Call_label";
            this.SecondPlayer_Call_label.Size = new System.Drawing.Size(77, 41);
            this.SecondPlayer_Call_label.TabIndex = 31;
            this.SecondPlayer_Call_label.Text = "\r\n         Call";
            this.SecondPlayer_Call_label.UseWaitCursor = true;
            this.SecondPlayer_Call_label.Visible = false;
            // 
            // SecondPlayer_Raise_label
            // 
            this.SecondPlayer_Raise_label.BackColor = System.Drawing.Color.YellowGreen;
            this.SecondPlayer_Raise_label.Location = new System.Drawing.Point(985, 639);
            this.SecondPlayer_Raise_label.Name = "SecondPlayer_Raise_label";
            this.SecondPlayer_Raise_label.Size = new System.Drawing.Size(77, 41);
            this.SecondPlayer_Raise_label.TabIndex = 30;
            this.SecondPlayer_Raise_label.Text = "       \r\n       Raise";
            this.SecondPlayer_Raise_label.UseWaitCursor = true;
            this.SecondPlayer_Raise_label.Visible = false;
            // 
            // SecondPlayer_Fold_label
            // 
            this.SecondPlayer_Fold_label.BackColor = System.Drawing.Color.OrangeRed;
            this.SecondPlayer_Fold_label.Location = new System.Drawing.Point(786, 639);
            this.SecondPlayer_Fold_label.Name = "SecondPlayer_Fold_label";
            this.SecondPlayer_Fold_label.Size = new System.Drawing.Size(77, 41);
            this.SecondPlayer_Fold_label.TabIndex = 29;
            this.SecondPlayer_Fold_label.Text = "\r\n        Fold";
            this.SecondPlayer_Fold_label.UseWaitCursor = true;
            this.SecondPlayer_Fold_label.Visible = false;
            // 
            // FirstPlayer_BankValue_label
            // 
            this.FirstPlayer_BankValue_label.AutoSize = true;
            this.FirstPlayer_BankValue_label.Location = new System.Drawing.Point(853, 190);
            this.FirstPlayer_BankValue_label.Name = "FirstPlayer_BankValue_label";
            this.FirstPlayer_BankValue_label.Size = new System.Drawing.Size(13, 13);
            this.FirstPlayer_BankValue_label.TabIndex = 33;
            this.FirstPlayer_BankValue_label.Text = "0";
            this.FirstPlayer_BankValue_label.UseWaitCursor = true;
            this.FirstPlayer_BankValue_label.Visible = false;
            // 
            // FirstPlayer_BetValue_label
            // 
            this.FirstPlayer_BetValue_label.AutoSize = true;
            this.FirstPlayer_BetValue_label.Location = new System.Drawing.Point(853, 228);
            this.FirstPlayer_BetValue_label.Name = "FirstPlayer_BetValue_label";
            this.FirstPlayer_BetValue_label.Size = new System.Drawing.Size(13, 13);
            this.FirstPlayer_BetValue_label.TabIndex = 34;
            this.FirstPlayer_BetValue_label.Text = "0";
            this.FirstPlayer_BetValue_label.UseWaitCursor = true;
            this.FirstPlayer_BetValue_label.Visible = false;
            // 
            // FirstPlayer_BetLabel_label
            // 
            this.FirstPlayer_BetLabel_label.AutoSize = true;
            this.FirstPlayer_BetLabel_label.Location = new System.Drawing.Point(853, 206);
            this.FirstPlayer_BetLabel_label.Name = "FirstPlayer_BetLabel_label";
            this.FirstPlayer_BetLabel_label.Size = new System.Drawing.Size(23, 13);
            this.FirstPlayer_BetLabel_label.TabIndex = 36;
            this.FirstPlayer_BetLabel_label.Text = "Bet";
            this.FirstPlayer_BetLabel_label.UseWaitCursor = true;
            this.FirstPlayer_BetLabel_label.Visible = false;
            // 
            // FirstPlayer_BankLabel_label
            // 
            this.FirstPlayer_BankLabel_label.AutoSize = true;
            this.FirstPlayer_BankLabel_label.Location = new System.Drawing.Point(853, 166);
            this.FirstPlayer_BankLabel_label.Name = "FirstPlayer_BankLabel_label";
            this.FirstPlayer_BankLabel_label.Size = new System.Drawing.Size(32, 13);
            this.FirstPlayer_BankLabel_label.TabIndex = 35;
            this.FirstPlayer_BankLabel_label.Text = "Bank";
            this.FirstPlayer_BankLabel_label.UseWaitCursor = true;
            this.FirstPlayer_BankLabel_label.Visible = false;
            // 
            // SecondPlayer_BetLabel_label
            // 
            this.SecondPlayer_BetLabel_label.AutoSize = true;
            this.SecondPlayer_BetLabel_label.Location = new System.Drawing.Point(834, 497);
            this.SecondPlayer_BetLabel_label.Name = "SecondPlayer_BetLabel_label";
            this.SecondPlayer_BetLabel_label.Size = new System.Drawing.Size(23, 13);
            this.SecondPlayer_BetLabel_label.TabIndex = 40;
            this.SecondPlayer_BetLabel_label.Text = "Bet";
            this.SecondPlayer_BetLabel_label.UseWaitCursor = true;
            this.SecondPlayer_BetLabel_label.Visible = false;
            // 
            // SecondPlayer_BankLabel_label
            // 
            this.SecondPlayer_BankLabel_label.AutoSize = true;
            this.SecondPlayer_BankLabel_label.Location = new System.Drawing.Point(834, 457);
            this.SecondPlayer_BankLabel_label.Name = "SecondPlayer_BankLabel_label";
            this.SecondPlayer_BankLabel_label.Size = new System.Drawing.Size(32, 13);
            this.SecondPlayer_BankLabel_label.TabIndex = 39;
            this.SecondPlayer_BankLabel_label.Text = "Bank";
            this.SecondPlayer_BankLabel_label.UseWaitCursor = true;
            this.SecondPlayer_BankLabel_label.Visible = false;
            // 
            // SecondPlayer_BetValue_label
            // 
            this.SecondPlayer_BetValue_label.AutoSize = true;
            this.SecondPlayer_BetValue_label.Location = new System.Drawing.Point(834, 519);
            this.SecondPlayer_BetValue_label.Name = "SecondPlayer_BetValue_label";
            this.SecondPlayer_BetValue_label.Size = new System.Drawing.Size(13, 13);
            this.SecondPlayer_BetValue_label.TabIndex = 38;
            this.SecondPlayer_BetValue_label.Text = "0";
            this.SecondPlayer_BetValue_label.UseWaitCursor = true;
            this.SecondPlayer_BetValue_label.Visible = false;
            // 
            // SecondPlayer_BankValue_label
            // 
            this.SecondPlayer_BankValue_label.AutoSize = true;
            this.SecondPlayer_BankValue_label.Location = new System.Drawing.Point(834, 481);
            this.SecondPlayer_BankValue_label.Name = "SecondPlayer_BankValue_label";
            this.SecondPlayer_BankValue_label.Size = new System.Drawing.Size(13, 13);
            this.SecondPlayer_BankValue_label.TabIndex = 37;
            this.SecondPlayer_BankValue_label.Text = "0";
            this.SecondPlayer_BankValue_label.UseWaitCursor = true;
            this.SecondPlayer_BankValue_label.Visible = false;
            // 
            // ThirdPlayer_BetLabel_label
            // 
            this.ThirdPlayer_BetLabel_label.AutoSize = true;
            this.ThirdPlayer_BetLabel_label.Location = new System.Drawing.Point(347, 613);
            this.ThirdPlayer_BetLabel_label.Name = "ThirdPlayer_BetLabel_label";
            this.ThirdPlayer_BetLabel_label.Size = new System.Drawing.Size(23, 13);
            this.ThirdPlayer_BetLabel_label.TabIndex = 44;
            this.ThirdPlayer_BetLabel_label.Text = "Bet";
            this.ThirdPlayer_BetLabel_label.UseWaitCursor = true;
            this.ThirdPlayer_BetLabel_label.Visible = false;
            // 
            // ThirdPlayer_BankLabel_label
            // 
            this.ThirdPlayer_BankLabel_label.AutoSize = true;
            this.ThirdPlayer_BankLabel_label.Location = new System.Drawing.Point(347, 573);
            this.ThirdPlayer_BankLabel_label.Name = "ThirdPlayer_BankLabel_label";
            this.ThirdPlayer_BankLabel_label.Size = new System.Drawing.Size(32, 13);
            this.ThirdPlayer_BankLabel_label.TabIndex = 43;
            this.ThirdPlayer_BankLabel_label.Text = "Bank";
            this.ThirdPlayer_BankLabel_label.UseWaitCursor = true;
            this.ThirdPlayer_BankLabel_label.Visible = false;
            // 
            // ThirdPlayer_BetValue_label
            // 
            this.ThirdPlayer_BetValue_label.AutoSize = true;
            this.ThirdPlayer_BetValue_label.Location = new System.Drawing.Point(347, 635);
            this.ThirdPlayer_BetValue_label.Name = "ThirdPlayer_BetValue_label";
            this.ThirdPlayer_BetValue_label.Size = new System.Drawing.Size(13, 13);
            this.ThirdPlayer_BetValue_label.TabIndex = 42;
            this.ThirdPlayer_BetValue_label.Text = "0";
            this.ThirdPlayer_BetValue_label.UseWaitCursor = true;
            this.ThirdPlayer_BetValue_label.Visible = false;
            // 
            // ThirdPlayer_BankValue_label
            // 
            this.ThirdPlayer_BankValue_label.AutoSize = true;
            this.ThirdPlayer_BankValue_label.Location = new System.Drawing.Point(347, 597);
            this.ThirdPlayer_BankValue_label.Name = "ThirdPlayer_BankValue_label";
            this.ThirdPlayer_BankValue_label.Size = new System.Drawing.Size(13, 13);
            this.ThirdPlayer_BankValue_label.TabIndex = 41;
            this.ThirdPlayer_BankValue_label.Text = "0";
            this.ThirdPlayer_BankValue_label.UseWaitCursor = true;
            this.ThirdPlayer_BankValue_label.Visible = false;
            // 
            // FourthPlayer_BetLabel_label
            // 
            this.FourthPlayer_BetLabel_label.AutoSize = true;
            this.FourthPlayer_BetLabel_label.Location = new System.Drawing.Point(24, 207);
            this.FourthPlayer_BetLabel_label.Name = "FourthPlayer_BetLabel_label";
            this.FourthPlayer_BetLabel_label.Size = new System.Drawing.Size(23, 13);
            this.FourthPlayer_BetLabel_label.TabIndex = 48;
            this.FourthPlayer_BetLabel_label.Text = "Bet";
            this.FourthPlayer_BetLabel_label.UseWaitCursor = true;
            this.FourthPlayer_BetLabel_label.Visible = false;
            // 
            // FourthPlayer_BankLabel_label
            // 
            this.FourthPlayer_BankLabel_label.AutoSize = true;
            this.FourthPlayer_BankLabel_label.Location = new System.Drawing.Point(24, 167);
            this.FourthPlayer_BankLabel_label.Name = "FourthPlayer_BankLabel_label";
            this.FourthPlayer_BankLabel_label.Size = new System.Drawing.Size(32, 13);
            this.FourthPlayer_BankLabel_label.TabIndex = 47;
            this.FourthPlayer_BankLabel_label.Text = "Bank";
            this.FourthPlayer_BankLabel_label.UseWaitCursor = true;
            this.FourthPlayer_BankLabel_label.Visible = false;
            // 
            // FourthPlayer_BetValue_label
            // 
            this.FourthPlayer_BetValue_label.AutoSize = true;
            this.FourthPlayer_BetValue_label.Location = new System.Drawing.Point(24, 229);
            this.FourthPlayer_BetValue_label.Name = "FourthPlayer_BetValue_label";
            this.FourthPlayer_BetValue_label.Size = new System.Drawing.Size(13, 13);
            this.FourthPlayer_BetValue_label.TabIndex = 46;
            this.FourthPlayer_BetValue_label.Text = "0";
            this.FourthPlayer_BetValue_label.UseWaitCursor = true;
            this.FourthPlayer_BetValue_label.Visible = false;
            // 
            // FourthPlayer_BankValue_label
            // 
            this.FourthPlayer_BankValue_label.AutoSize = true;
            this.FourthPlayer_BankValue_label.Location = new System.Drawing.Point(24, 191);
            this.FourthPlayer_BankValue_label.Name = "FourthPlayer_BankValue_label";
            this.FourthPlayer_BankValue_label.Size = new System.Drawing.Size(13, 13);
            this.FourthPlayer_BankValue_label.TabIndex = 45;
            this.FourthPlayer_BankValue_label.Text = "0";
            this.FourthPlayer_BankValue_label.UseWaitCursor = true;
            this.FourthPlayer_BankValue_label.Visible = false;
            // 
            // GameBank_Value_Label
            // 
            this.GameBank_Value_Label.AutoSize = true;
            this.GameBank_Value_Label.BackColor = System.Drawing.Color.ForestGreen;
            this.GameBank_Value_Label.ForeColor = System.Drawing.SystemColors.Control;
            this.GameBank_Value_Label.Location = new System.Drawing.Point(540, 300);
            this.GameBank_Value_Label.Name = "GameBank_Value_Label";
            this.GameBank_Value_Label.Size = new System.Drawing.Size(13, 13);
            this.GameBank_Value_Label.TabIndex = 49;
            this.GameBank_Value_Label.Text = "0";
            this.GameBank_Value_Label.UseWaitCursor = true;
            this.GameBank_Value_Label.Visible = false;
            // 
            // FirstPlayer_EnterValueOfRaiseBet_textBox
            // 
            this.FirstPlayer_EnterValueOfRaiseBet_textBox.Location = new System.Drawing.Point(993, 373);
            this.FirstPlayer_EnterValueOfRaiseBet_textBox.Name = "FirstPlayer_EnterValueOfRaiseBet_textBox";
            this.FirstPlayer_EnterValueOfRaiseBet_textBox.Size = new System.Drawing.Size(100, 20);
            this.FirstPlayer_EnterValueOfRaiseBet_textBox.TabIndex = 50;
            this.FirstPlayer_EnterValueOfRaiseBet_textBox.UseWaitCursor = true;
            this.FirstPlayer_EnterValueOfRaiseBet_textBox.Visible = false;
            // 
            // FirstPlayer_ConfirmRaiseBet_button
            // 
            this.FirstPlayer_ConfirmRaiseBet_button.Enabled = false;
            this.FirstPlayer_ConfirmRaiseBet_button.Location = new System.Drawing.Point(1006, 399);
            this.FirstPlayer_ConfirmRaiseBet_button.Name = "FirstPlayer_ConfirmRaiseBet_button";
            this.FirstPlayer_ConfirmRaiseBet_button.Size = new System.Drawing.Size(75, 23);
            this.FirstPlayer_ConfirmRaiseBet_button.TabIndex = 51;
            this.FirstPlayer_ConfirmRaiseBet_button.Text = "Confirm";
            this.FirstPlayer_ConfirmRaiseBet_button.UseVisualStyleBackColor = true;
            this.FirstPlayer_ConfirmRaiseBet_button.UseWaitCursor = true;
            this.FirstPlayer_ConfirmRaiseBet_button.Visible = false;
            // 
            // FourthPlayer_ConfirmRaiseBet_button
            // 
            this.FourthPlayer_ConfirmRaiseBet_button.Enabled = false;
            this.FourthPlayer_ConfirmRaiseBet_button.Location = new System.Drawing.Point(231, 305);
            this.FourthPlayer_ConfirmRaiseBet_button.Name = "FourthPlayer_ConfirmRaiseBet_button";
            this.FourthPlayer_ConfirmRaiseBet_button.Size = new System.Drawing.Size(75, 23);
            this.FourthPlayer_ConfirmRaiseBet_button.TabIndex = 53;
            this.FourthPlayer_ConfirmRaiseBet_button.Text = "Confirm";
            this.FourthPlayer_ConfirmRaiseBet_button.UseVisualStyleBackColor = true;
            this.FourthPlayer_ConfirmRaiseBet_button.UseWaitCursor = true;
            this.FourthPlayer_ConfirmRaiseBet_button.Visible = false;
            // 
            // FourthPlayer_EnterValueOfRaiseBet_textBox
            // 
            this.FourthPlayer_EnterValueOfRaiseBet_textBox.Location = new System.Drawing.Point(218, 279);
            this.FourthPlayer_EnterValueOfRaiseBet_textBox.Name = "FourthPlayer_EnterValueOfRaiseBet_textBox";
            this.FourthPlayer_EnterValueOfRaiseBet_textBox.Size = new System.Drawing.Size(100, 20);
            this.FourthPlayer_EnterValueOfRaiseBet_textBox.TabIndex = 52;
            this.FourthPlayer_EnterValueOfRaiseBet_textBox.UseWaitCursor = true;
            this.FourthPlayer_EnterValueOfRaiseBet_textBox.Visible = false;
            // 
            // ThirdPlayer_ConfirmRaiseBet_button
            // 
            this.ThirdPlayer_ConfirmRaiseBet_button.Enabled = false;
            this.ThirdPlayer_ConfirmRaiseBet_button.Location = new System.Drawing.Point(584, 719);
            this.ThirdPlayer_ConfirmRaiseBet_button.Name = "ThirdPlayer_ConfirmRaiseBet_button";
            this.ThirdPlayer_ConfirmRaiseBet_button.Size = new System.Drawing.Size(75, 23);
            this.ThirdPlayer_ConfirmRaiseBet_button.TabIndex = 55;
            this.ThirdPlayer_ConfirmRaiseBet_button.Text = "Confirm";
            this.ThirdPlayer_ConfirmRaiseBet_button.UseVisualStyleBackColor = true;
            this.ThirdPlayer_ConfirmRaiseBet_button.UseWaitCursor = true;
            this.ThirdPlayer_ConfirmRaiseBet_button.Visible = false;
            // 
            // ThirdPlayer_EnterValueOfRaiseBet_textBox
            // 
            this.ThirdPlayer_EnterValueOfRaiseBet_textBox.Location = new System.Drawing.Point(571, 693);
            this.ThirdPlayer_EnterValueOfRaiseBet_textBox.Name = "ThirdPlayer_EnterValueOfRaiseBet_textBox";
            this.ThirdPlayer_EnterValueOfRaiseBet_textBox.Size = new System.Drawing.Size(100, 20);
            this.ThirdPlayer_EnterValueOfRaiseBet_textBox.TabIndex = 54;
            this.ThirdPlayer_EnterValueOfRaiseBet_textBox.UseWaitCursor = true;
            this.ThirdPlayer_EnterValueOfRaiseBet_textBox.Visible = false;
            // 
            // SecondPlayer_ConfirmRaiseBet_button
            // 
            this.SecondPlayer_ConfirmRaiseBet_button.Enabled = false;
            this.SecondPlayer_ConfirmRaiseBet_button.Location = new System.Drawing.Point(994, 668);
            this.SecondPlayer_ConfirmRaiseBet_button.Name = "SecondPlayer_ConfirmRaiseBet_button";
            this.SecondPlayer_ConfirmRaiseBet_button.Size = new System.Drawing.Size(75, 23);
            this.SecondPlayer_ConfirmRaiseBet_button.TabIndex = 57;
            this.SecondPlayer_ConfirmRaiseBet_button.Text = "Confirm";
            this.SecondPlayer_ConfirmRaiseBet_button.UseVisualStyleBackColor = true;
            this.SecondPlayer_ConfirmRaiseBet_button.UseWaitCursor = true;
            this.SecondPlayer_ConfirmRaiseBet_button.Visible = false;
            // 
            // SecondPlayer_EnterValueOfRaiseBet_textBox
            // 
            this.SecondPlayer_EnterValueOfRaiseBet_textBox.Location = new System.Drawing.Point(981, 642);
            this.SecondPlayer_EnterValueOfRaiseBet_textBox.Name = "SecondPlayer_EnterValueOfRaiseBet_textBox";
            this.SecondPlayer_EnterValueOfRaiseBet_textBox.Size = new System.Drawing.Size(100, 20);
            this.SecondPlayer_EnterValueOfRaiseBet_textBox.TabIndex = 56;
            this.SecondPlayer_EnterValueOfRaiseBet_textBox.UseWaitCursor = true;
            this.SecondPlayer_EnterValueOfRaiseBet_textBox.Visible = false;
            // 
            // FirstPlayer_CanselRaiseBet_button
            // 
            this.FirstPlayer_CanselRaiseBet_button.Location = new System.Drawing.Point(1006, 428);
            this.FirstPlayer_CanselRaiseBet_button.Name = "FirstPlayer_CanselRaiseBet_button";
            this.FirstPlayer_CanselRaiseBet_button.Size = new System.Drawing.Size(75, 23);
            this.FirstPlayer_CanselRaiseBet_button.TabIndex = 58;
            this.FirstPlayer_CanselRaiseBet_button.Text = "Cancel";
            this.FirstPlayer_CanselRaiseBet_button.UseVisualStyleBackColor = true;
            this.FirstPlayer_CanselRaiseBet_button.UseWaitCursor = true;
            this.FirstPlayer_CanselRaiseBet_button.Visible = false;
            // 
            // SecondPlayer_CanselRaiseBet_button
            // 
            this.SecondPlayer_CanselRaiseBet_button.Location = new System.Drawing.Point(994, 697);
            this.SecondPlayer_CanselRaiseBet_button.Name = "SecondPlayer_CanselRaiseBet_button";
            this.SecondPlayer_CanselRaiseBet_button.Size = new System.Drawing.Size(75, 23);
            this.SecondPlayer_CanselRaiseBet_button.TabIndex = 59;
            this.SecondPlayer_CanselRaiseBet_button.Text = "Cancel";
            this.SecondPlayer_CanselRaiseBet_button.UseVisualStyleBackColor = true;
            this.SecondPlayer_CanselRaiseBet_button.UseWaitCursor = true;
            this.SecondPlayer_CanselRaiseBet_button.Visible = false;
            // 
            // ThirdPlayer_CanselRaiseBet_button
            // 
            this.ThirdPlayer_CanselRaiseBet_button.Location = new System.Drawing.Point(584, 747);
            this.ThirdPlayer_CanselRaiseBet_button.Name = "ThirdPlayer_CanselRaiseBet_button";
            this.ThirdPlayer_CanselRaiseBet_button.Size = new System.Drawing.Size(75, 23);
            this.ThirdPlayer_CanselRaiseBet_button.TabIndex = 60;
            this.ThirdPlayer_CanselRaiseBet_button.Text = "Cancel";
            this.ThirdPlayer_CanselRaiseBet_button.UseVisualStyleBackColor = true;
            this.ThirdPlayer_CanselRaiseBet_button.UseWaitCursor = true;
            this.ThirdPlayer_CanselRaiseBet_button.Visible = false;
            // 
            // FourthPlayer_CanselRaiseBet_button
            // 
            this.FourthPlayer_CanselRaiseBet_button.Location = new System.Drawing.Point(231, 334);
            this.FourthPlayer_CanselRaiseBet_button.Name = "FourthPlayer_CanselRaiseBet_button";
            this.FourthPlayer_CanselRaiseBet_button.Size = new System.Drawing.Size(75, 23);
            this.FourthPlayer_CanselRaiseBet_button.TabIndex = 61;
            this.FourthPlayer_CanselRaiseBet_button.Text = "Cancel";
            this.FourthPlayer_CanselRaiseBet_button.UseVisualStyleBackColor = true;
            this.FourthPlayer_CanselRaiseBet_button.UseWaitCursor = true;
            this.FourthPlayer_CanselRaiseBet_button.Visible = false;
            // 
            // GameBank_label
            // 
            this.GameBank_label.AutoSize = true;
            this.GameBank_label.BackColor = System.Drawing.Color.ForestGreen;
            this.GameBank_label.ForeColor = System.Drawing.SystemColors.Control;
            this.GameBank_label.Location = new System.Drawing.Point(464, 300);
            this.GameBank_label.Name = "GameBank_label";
            this.GameBank_label.Size = new System.Drawing.Size(68, 13);
            this.GameBank_label.TabIndex = 62;
            this.GameBank_label.Text = "Game bank :";
            this.GameBank_label.UseWaitCursor = true;
            this.GameBank_label.Visible = false;
            // 
            // GameFone_pictureBox
            // 
            this.GameFone_pictureBox.BackColor = System.Drawing.Color.OliveDrab;
            this.GameFone_pictureBox.Location = new System.Drawing.Point(0, 0);
            this.GameFone_pictureBox.Name = "GameFone_pictureBox";
            this.GameFone_pictureBox.Size = new System.Drawing.Size(1112, 814);
            this.GameFone_pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.GameFone_pictureBox.TabIndex = 63;
            this.GameFone_pictureBox.TabStop = false;
            this.GameFone_pictureBox.UseWaitCursor = true;
            // 
            // FourthPlayer_Winner_label
            // 
            this.FourthPlayer_Winner_label.AutoSize = true;
            this.FourthPlayer_Winner_label.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.FourthPlayer_Winner_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FourthPlayer_Winner_label.ForeColor = System.Drawing.Color.Gold;
            this.FourthPlayer_Winner_label.Location = new System.Drawing.Point(94, 276);
            this.FourthPlayer_Winner_label.Name = "FourthPlayer_Winner_label";
            this.FourthPlayer_Winner_label.Size = new System.Drawing.Size(131, 31);
            this.FourthPlayer_Winner_label.TabIndex = 64;
            this.FourthPlayer_Winner_label.Text = "WINNER";
            this.FourthPlayer_Winner_label.UseWaitCursor = true;
            this.FourthPlayer_Winner_label.Visible = false;
            // 
            // FirstPlayer_Winner_label
            // 
            this.FirstPlayer_Winner_label.AutoSize = true;
            this.FirstPlayer_Winner_label.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.FirstPlayer_Winner_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FirstPlayer_Winner_label.ForeColor = System.Drawing.Color.Gold;
            this.FirstPlayer_Winner_label.Location = new System.Drawing.Point(883, 365);
            this.FirstPlayer_Winner_label.Name = "FirstPlayer_Winner_label";
            this.FirstPlayer_Winner_label.Size = new System.Drawing.Size(131, 31);
            this.FirstPlayer_Winner_label.TabIndex = 65;
            this.FirstPlayer_Winner_label.Text = "WINNER";
            this.FirstPlayer_Winner_label.UseWaitCursor = true;
            this.FirstPlayer_Winner_label.Visible = false;
            // 
            // ThirdPlayer_Winner_label
            // 
            this.ThirdPlayer_Winner_label.AutoSize = true;
            this.ThirdPlayer_Winner_label.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ThirdPlayer_Winner_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ThirdPlayer_Winner_label.ForeColor = System.Drawing.Color.Gold;
            this.ThirdPlayer_Winner_label.Location = new System.Drawing.Point(438, 693);
            this.ThirdPlayer_Winner_label.Name = "ThirdPlayer_Winner_label";
            this.ThirdPlayer_Winner_label.Size = new System.Drawing.Size(131, 31);
            this.ThirdPlayer_Winner_label.TabIndex = 66;
            this.ThirdPlayer_Winner_label.Text = "WINNER";
            this.ThirdPlayer_Winner_label.UseWaitCursor = true;
            this.ThirdPlayer_Winner_label.Visible = false;
            // 
            // SecondPlayer_Winner_label
            // 
            this.SecondPlayer_Winner_label.AutoSize = true;
            this.SecondPlayer_Winner_label.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.SecondPlayer_Winner_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SecondPlayer_Winner_label.ForeColor = System.Drawing.Color.Gold;
            this.SecondPlayer_Winner_label.Location = new System.Drawing.Point(854, 658);
            this.SecondPlayer_Winner_label.Name = "SecondPlayer_Winner_label";
            this.SecondPlayer_Winner_label.Size = new System.Drawing.Size(131, 31);
            this.SecondPlayer_Winner_label.TabIndex = 66;
            this.SecondPlayer_Winner_label.Text = "WINNER";
            this.SecondPlayer_Winner_label.UseWaitCursor = true;
            this.SecondPlayer_Winner_label.Visible = false;
            // 
            // RestartGame_button
            // 
            this.RestartGame_button.Location = new System.Drawing.Point(520, 452);
            this.RestartGame_button.Name = "RestartGame_button";
            this.RestartGame_button.Size = new System.Drawing.Size(75, 23);
            this.RestartGame_button.TabIndex = 67;
            this.RestartGame_button.Text = "Play Again";
            this.RestartGame_button.UseVisualStyleBackColor = true;
            this.RestartGame_button.UseWaitCursor = true;
            this.RestartGame_button.Visible = false;
            // 
            // FourthPlayerCombination_Label
            // 
            this.FourthPlayerCombination_Label.AutoSize = true;
            this.FourthPlayerCombination_Label.Location = new System.Drawing.Point(24, 344);
            this.FourthPlayerCombination_Label.Name = "FourthPlayerCombination_Label";
            this.FourthPlayerCombination_Label.Size = new System.Drawing.Size(65, 13);
            this.FourthPlayerCombination_Label.TabIndex = 68;
            this.FourthPlayerCombination_Label.Text = "Combination";
            this.FourthPlayerCombination_Label.UseWaitCursor = true;
            this.FourthPlayerCombination_Label.Visible = false;
            // 
            // ThirdPlayerCombination_Label
            // 
            this.ThirdPlayerCombination_Label.AutoSize = true;
            this.ThirdPlayerCombination_Label.Location = new System.Drawing.Point(381, 757);
            this.ThirdPlayerCombination_Label.Name = "ThirdPlayerCombination_Label";
            this.ThirdPlayerCombination_Label.Size = new System.Drawing.Size(65, 13);
            this.ThirdPlayerCombination_Label.TabIndex = 69;
            this.ThirdPlayerCombination_Label.Text = "Combination";
            this.ThirdPlayerCombination_Label.UseWaitCursor = true;
            this.ThirdPlayerCombination_Label.Visible = false;
            // 
            // SecondPlayerCombination_Label
            // 
            this.SecondPlayerCombination_Label.AutoSize = true;
            this.SecondPlayerCombination_Label.Location = new System.Drawing.Point(820, 697);
            this.SecondPlayerCombination_Label.Name = "SecondPlayerCombination_Label";
            this.SecondPlayerCombination_Label.Size = new System.Drawing.Size(65, 13);
            this.SecondPlayerCombination_Label.TabIndex = 70;
            this.SecondPlayerCombination_Label.Text = "Combination";
            this.SecondPlayerCombination_Label.UseWaitCursor = true;
            this.SecondPlayerCombination_Label.Visible = false;
            // 
            // FirstPlayerCombination_Label
            // 
            this.FirstPlayerCombination_Label.AutoSize = true;
            this.FirstPlayerCombination_Label.Location = new System.Drawing.Point(834, 419);
            this.FirstPlayerCombination_Label.Name = "FirstPlayerCombination_Label";
            this.FirstPlayerCombination_Label.Size = new System.Drawing.Size(65, 13);
            this.FirstPlayerCombination_Label.TabIndex = 71;
            this.FirstPlayerCombination_Label.Text = "Combination";
            this.FirstPlayerCombination_Label.UseWaitCursor = true;
            this.FirstPlayerCombination_Label.Visible = false;
            // 
            // DoAutomaticBets_timer
            // 
            this.DoAutomaticBets_timer.Interval = 1000;
            // 
            // DealCardsToPlayers_timer
            // 
            this.DealCardsToPlayers_timer.Interval = 1000;
            // 
            // PauseBeetweenRounds_timer
            // 
            this.PauseBeetweenRounds_timer.Interval = 1000;
            // 
            // GameForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1102, 791);
            this.Controls.Add(this.FirstPlayerCombination_Label);
            this.Controls.Add(this.SecondPlayerCombination_Label);
            this.Controls.Add(this.ThirdPlayerCombination_Label);
            this.Controls.Add(this.FourthPlayerCombination_Label);
            this.Controls.Add(this.RestartGame_button);
            this.Controls.Add(this.ThirdPlayer_Winner_label);
            this.Controls.Add(this.GameBank_label);
            this.Controls.Add(this.FourthPlayer_CanselRaiseBet_button);
            this.Controls.Add(this.ThirdPlayer_CanselRaiseBet_button);
            this.Controls.Add(this.SecondPlayer_CanselRaiseBet_button);
            this.Controls.Add(this.FirstPlayer_CanselRaiseBet_button);
            this.Controls.Add(this.SecondPlayer_ConfirmRaiseBet_button);
            this.Controls.Add(this.SecondPlayer_EnterValueOfRaiseBet_textBox);
            this.Controls.Add(this.ThirdPlayer_ConfirmRaiseBet_button);
            this.Controls.Add(this.ThirdPlayer_EnterValueOfRaiseBet_textBox);
            this.Controls.Add(this.FourthPlayer_ConfirmRaiseBet_button);
            this.Controls.Add(this.FourthPlayer_EnterValueOfRaiseBet_textBox);
            this.Controls.Add(this.FirstPlayer_ConfirmRaiseBet_button);
            this.Controls.Add(this.FirstPlayer_EnterValueOfRaiseBet_textBox);
            this.Controls.Add(this.Play_button);
            this.Controls.Add(this.Table_panel);
            this.Controls.Add(this.GameBank_Value_Label);
            this.Controls.Add(this.FourthPlayer_BetLabel_label);
            this.Controls.Add(this.FourthPlayer_BankLabel_label);
            this.Controls.Add(this.FourthPlayer_BetValue_label);
            this.Controls.Add(this.FourthPlayer_BankValue_label);
            this.Controls.Add(this.ThirdPlayer_BetLabel_label);
            this.Controls.Add(this.ThirdPlayer_BankLabel_label);
            this.Controls.Add(this.ThirdPlayer_BetValue_label);
            this.Controls.Add(this.ThirdPlayer_BankValue_label);
            this.Controls.Add(this.SecondPlayer_BetLabel_label);
            this.Controls.Add(this.SecondPlayer_BankLabel_label);
            this.Controls.Add(this.SecondPlayer_BetValue_label);
            this.Controls.Add(this.SecondPlayer_BankValue_label);
            this.Controls.Add(this.FirstPlayer_BetLabel_label);
            this.Controls.Add(this.FirstPlayer_BankLabel_label);
            this.Controls.Add(this.FirstPlayer_BetValue_label);
            this.Controls.Add(this.FirstPlayer_BankValue_label);
            this.Controls.Add(this.SecondPlayer_Check_label);
            this.Controls.Add(this.SecondPlayer_Call_label);
            this.Controls.Add(this.SecondPlayer_Raise_label);
            this.Controls.Add(this.SecondPlayer_Fold_label);
            this.Controls.Add(this.FirstPlayer_Check_label);
            this.Controls.Add(this.FirstPlayer_Call_label);
            this.Controls.Add(this.FirstPlayer_Raise_label);
            this.Controls.Add(this.FirstPlayer_Fold_label);
            this.Controls.Add(this.FourthPlayer_Check_label);
            this.Controls.Add(this.FourthPlayer_Call_label);
            this.Controls.Add(this.FourthPlayer_Raise_label);
            this.Controls.Add(this.FourthPlayer_Fold_label);
            this.Controls.Add(this.ThirdPlayer_Check_label);
            this.Controls.Add(this.ThirdPlayer_Call_label);
            this.Controls.Add(this.ThirdPlayer_Raise_label);
            this.Controls.Add(this.ThirdPlayer_Fold_label);
            this.Controls.Add(this.Diller_Name_label);
            this.Controls.Add(this.fourthPlayer_Name_label);
            this.Controls.Add(this.ThirdPlayer_Name_label);
            this.Controls.Add(this.SecondPlayer_Name_label);
            this.Controls.Add(this.FirstPlayer_Name_label);
            this.Controls.Add(this.Diller_panel);
            this.Controls.Add(this.DownWallOfTable_label);
            this.Controls.Add(this.RightWallOfTable_label);
            this.Controls.Add(this.UpWallOfTable_label);
            this.Controls.Add(this.LeftWallOfTable_label);
            this.Controls.Add(this.Table_label);
            this.Controls.Add(this.FourthPlayer_Winner_label);
            this.Controls.Add(this.SecondPlayer_Winner_label);
            this.Controls.Add(this.FirstPlayer_Winner_label);
            this.Controls.Add(this.FourthPlayer_panel);
            this.Controls.Add(this.ThirdPlayer_panel);
            this.Controls.Add(this.SecondPlayer_panel);
            this.Controls.Add(this.FirstPlayer_panel);
            this.Controls.Add(this.GameFone_pictureBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "GameForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Poker";
            this.UseWaitCursor = true;
            ((System.ComponentModel.ISupportInitialize)(this.GameFone_pictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel FirstPlayer_panel;
        private System.Windows.Forms.Panel SecondPlayer_panel;
        private System.Windows.Forms.Panel ThirdPlayer_panel;
        private System.Windows.Forms.Panel FourthPlayer_panel;
        private System.Windows.Forms.Panel Table_panel;
        private System.Windows.Forms.Button Play_button;
        private System.Windows.Forms.Label Table_label;
        private System.Windows.Forms.Label LeftWallOfTable_label;
        private System.Windows.Forms.Label UpWallOfTable_label;
        private System.Windows.Forms.Label RightWallOfTable_label;
        private System.Windows.Forms.Label DownWallOfTable_label;
        private System.Windows.Forms.Panel Diller_panel;
        private System.Windows.Forms.Label FirstPlayer_Name_label;
        private System.Windows.Forms.Label SecondPlayer_Name_label;
        private System.Windows.Forms.Label ThirdPlayer_Name_label;
        private System.Windows.Forms.Label fourthPlayer_Name_label;
        private System.Windows.Forms.Label Diller_Name_label;
        private System.Windows.Forms.Label ThirdPlayer_Fold_label;
        private System.Windows.Forms.Label ThirdPlayer_Raise_label;
        private System.Windows.Forms.Label ThirdPlayer_Call_label;
        private System.Windows.Forms.Label ThirdPlayer_Check_label;
        private System.Windows.Forms.Label FourthPlayer_Check_label;
        private System.Windows.Forms.Label FourthPlayer_Call_label;
        private System.Windows.Forms.Label FourthPlayer_Raise_label;
        private System.Windows.Forms.Label FourthPlayer_Fold_label;
        private System.Windows.Forms.Label FirstPlayer_Check_label;
        private System.Windows.Forms.Label FirstPlayer_Call_label;
        private System.Windows.Forms.Label FirstPlayer_Raise_label;
        private System.Windows.Forms.Label FirstPlayer_Fold_label;
        private System.Windows.Forms.Label SecondPlayer_Check_label;
        private System.Windows.Forms.Label SecondPlayer_Call_label;
        private System.Windows.Forms.Label SecondPlayer_Raise_label;
        private System.Windows.Forms.Label SecondPlayer_Fold_label;
        private System.Windows.Forms.Label FirstPlayer_BankValue_label;
        private System.Windows.Forms.Label FirstPlayer_BetValue_label;
        private System.Windows.Forms.Label FirstPlayer_BetLabel_label;
        private System.Windows.Forms.Label FirstPlayer_BankLabel_label;
        private System.Windows.Forms.Label SecondPlayer_BetLabel_label;
        private System.Windows.Forms.Label SecondPlayer_BankLabel_label;
        private System.Windows.Forms.Label SecondPlayer_BetValue_label;
        private System.Windows.Forms.Label SecondPlayer_BankValue_label;
        private System.Windows.Forms.Label ThirdPlayer_BetLabel_label;
        private System.Windows.Forms.Label ThirdPlayer_BankLabel_label;
        private System.Windows.Forms.Label ThirdPlayer_BetValue_label;
        private System.Windows.Forms.Label ThirdPlayer_BankValue_label;
        private System.Windows.Forms.Label FourthPlayer_BetLabel_label;
        private System.Windows.Forms.Label FourthPlayer_BankLabel_label;
        private System.Windows.Forms.Label FourthPlayer_BetValue_label;
        private System.Windows.Forms.Label FourthPlayer_BankValue_label;
        private System.Windows.Forms.Label GameBank_Value_Label;
        private System.Windows.Forms.TextBox FirstPlayer_EnterValueOfRaiseBet_textBox;
        private System.Windows.Forms.Button FirstPlayer_ConfirmRaiseBet_button;
        private System.Windows.Forms.Button FourthPlayer_ConfirmRaiseBet_button;
        private System.Windows.Forms.TextBox FourthPlayer_EnterValueOfRaiseBet_textBox;
        private System.Windows.Forms.Button ThirdPlayer_ConfirmRaiseBet_button;
        private System.Windows.Forms.TextBox ThirdPlayer_EnterValueOfRaiseBet_textBox;
        private System.Windows.Forms.Button SecondPlayer_ConfirmRaiseBet_button;
        private System.Windows.Forms.TextBox SecondPlayer_EnterValueOfRaiseBet_textBox;
        private System.Windows.Forms.Button FirstPlayer_CanselRaiseBet_button;
        private System.Windows.Forms.Button SecondPlayer_CanselRaiseBet_button;
        private System.Windows.Forms.Button ThirdPlayer_CanselRaiseBet_button;
        private System.Windows.Forms.Button FourthPlayer_CanselRaiseBet_button;
        private System.Windows.Forms.Label GameBank_label;
        private System.Windows.Forms.PictureBox GameFone_pictureBox;
        private System.Windows.Forms.Label FirstPlayer_Winner_label;
        private System.Windows.Forms.Label SecondPlayer_Winner_label;
        private System.Windows.Forms.Label ThirdPlayer_Winner_label;
        private System.Windows.Forms.Label FourthPlayer_Winner_label;
        private System.Windows.Forms.Button RestartGame_button;
        private System.Windows.Forms.Label FourthPlayerCombination_Label;
        private System.Windows.Forms.Label ThirdPlayerCombination_Label;
        private System.Windows.Forms.Label SecondPlayerCombination_Label;
        private System.Windows.Forms.Label FirstPlayerCombination_Label;
        private System.Windows.Forms.Timer DoAutomaticBets_timer;
        private System.Windows.Forms.Timer DealCardsToPlayers_timer;
        private System.Windows.Forms.Timer PauseBeetweenRounds_timer;
    }
}