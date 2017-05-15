namespace WolfAndHares
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.pnlMain = new System.Windows.Forms.Panel();
            this.aboutScreen = new WolfAndHares.Controls.AboutScreen();
            this.instructionScreen = new WolfAndHares.Controls.InstructionScreen();
            this.btnContinue = new System.Windows.Forms.Button();
            this.btnNewGame = new System.Windows.Forms.Button();
            this.btnHowToPlay = new System.Windows.Forms.Button();
            this.btnAbout = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.pnlLevels = new System.Windows.Forms.Panel();
            this.pbxMainMenu = new System.Windows.Forms.PictureBox();
            this.pnlGame = new System.Windows.Forms.Panel();
            this.winScreen = new WolfAndHares.Controls.WinScreen();
            this.fullWinScreen = new WolfAndHares.Controls.FullWinScreen();
            this.imgPause = new System.Windows.Forms.PictureBox();
            this.lblLiveCount = new System.Windows.Forms.Label();
            this.lblCarrotCount = new System.Windows.Forms.Label();
            this.menuPause = new WolfAndHares.Controls.MenuPause();
            this.looseScreen = new WolfAndHares.Controls.LoseScreen();
            this.pnlMain.SuspendLayout();
            this.pnlLevels.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxMainMenu)).BeginInit();
            this.pnlGame.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgPause)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlMain
            // 
            this.pnlMain.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnlMain.BackgroundImage")));
            this.pnlMain.Controls.Add(this.aboutScreen);
            this.pnlMain.Controls.Add(this.instructionScreen);
            this.pnlMain.Controls.Add(this.btnContinue);
            this.pnlMain.Controls.Add(this.btnNewGame);
            this.pnlMain.Controls.Add(this.btnHowToPlay);
            this.pnlMain.Controls.Add(this.btnAbout);
            this.pnlMain.Controls.Add(this.btnExit);
            this.pnlMain.Location = new System.Drawing.Point(1, 2);
            this.pnlMain.Margin = new System.Windows.Forms.Padding(10);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(484, 480);
            this.pnlMain.TabIndex = 0;
            // 
            // aboutScreen
            // 
            this.aboutScreen.BackColor = System.Drawing.Color.Transparent;
            this.aboutScreen.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("aboutScreen.BackgroundImage")));
            this.aboutScreen.ForeColor = System.Drawing.Color.White;
            this.aboutScreen.Location = new System.Drawing.Point(26, 57);
            this.aboutScreen.Name = "aboutScreen";
            this.aboutScreen.Size = new System.Drawing.Size(427, 415);
            this.aboutScreen.TabIndex = 8;
            this.aboutScreen.Visible = false;
            // 
            // instructionScreen
            // 
            this.instructionScreen.BackColor = System.Drawing.Color.Transparent;
            this.instructionScreen.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("instructionScreen.BackgroundImage")));
            this.instructionScreen.Location = new System.Drawing.Point(24, 55);
            this.instructionScreen.Name = "instructionScreen";
            this.instructionScreen.Size = new System.Drawing.Size(427, 415);
            this.instructionScreen.TabIndex = 9;
            this.instructionScreen.Visible = false;
            // 
            // btnContinue
            // 
            this.btnContinue.BackColor = System.Drawing.Color.Transparent;
            this.btnContinue.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnContinue.FlatAppearance.BorderSize = 0;
            this.btnContinue.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnContinue.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnContinue.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnContinue.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.25F);
            this.btnContinue.ForeColor = System.Drawing.Color.White;
            this.btnContinue.Image = global::WolfAndHares.Properties.Resources.button;
            this.btnContinue.Location = new System.Drawing.Point(271, 173);
            this.btnContinue.Name = "btnContinue";
            this.btnContinue.Size = new System.Drawing.Size(167, 55);
            this.btnContinue.TabIndex = 7;
            this.btnContinue.Text = "Продолжить";
            this.btnContinue.UseVisualStyleBackColor = false;
            this.btnContinue.Visible = false;
            this.btnContinue.Click += new System.EventHandler(this.ContinueClick);
            // 
            // btnNewGame
            // 
            this.btnNewGame.BackColor = System.Drawing.Color.Transparent;
            this.btnNewGame.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNewGame.FlatAppearance.BorderSize = 0;
            this.btnNewGame.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnNewGame.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnNewGame.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNewGame.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.25F);
            this.btnNewGame.ForeColor = System.Drawing.Color.White;
            this.btnNewGame.Image = global::WolfAndHares.Properties.Resources.button;
            this.btnNewGame.Location = new System.Drawing.Point(271, 234);
            this.btnNewGame.Name = "btnNewGame";
            this.btnNewGame.Size = new System.Drawing.Size(167, 55);
            this.btnNewGame.TabIndex = 6;
            this.btnNewGame.Text = "Новая игра";
            this.btnNewGame.UseVisualStyleBackColor = false;
            this.btnNewGame.Click += new System.EventHandler(this.btnNewGame_Click);
            // 
            // btnHowToPlay
            // 
            this.btnHowToPlay.BackColor = System.Drawing.Color.Transparent;
            this.btnHowToPlay.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnHowToPlay.FlatAppearance.BorderSize = 0;
            this.btnHowToPlay.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnHowToPlay.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnHowToPlay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHowToPlay.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.25F);
            this.btnHowToPlay.ForeColor = System.Drawing.Color.White;
            this.btnHowToPlay.Image = global::WolfAndHares.Properties.Resources.button;
            this.btnHowToPlay.Location = new System.Drawing.Point(271, 295);
            this.btnHowToPlay.Name = "btnHowToPlay";
            this.btnHowToPlay.Size = new System.Drawing.Size(167, 55);
            this.btnHowToPlay.TabIndex = 5;
            this.btnHowToPlay.Text = "Как играть";
            this.btnHowToPlay.UseVisualStyleBackColor = false;
            this.btnHowToPlay.Click += new System.EventHandler(this.btnHowToPlay_Click);
            // 
            // btnAbout
            // 
            this.btnAbout.BackColor = System.Drawing.Color.Transparent;
            this.btnAbout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAbout.FlatAppearance.BorderSize = 0;
            this.btnAbout.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnAbout.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnAbout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAbout.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.25F);
            this.btnAbout.ForeColor = System.Drawing.Color.White;
            this.btnAbout.Image = global::WolfAndHares.Properties.Resources.button;
            this.btnAbout.Location = new System.Drawing.Point(271, 356);
            this.btnAbout.Name = "btnAbout";
            this.btnAbout.Size = new System.Drawing.Size(167, 55);
            this.btnAbout.TabIndex = 4;
            this.btnAbout.Text = "Справка";
            this.btnAbout.UseVisualStyleBackColor = false;
            this.btnAbout.Click += new System.EventHandler(this.btnAbout_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.Transparent;
            this.btnExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnExit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.25F);
            this.btnExit.ForeColor = System.Drawing.Color.White;
            this.btnExit.Image = global::WolfAndHares.Properties.Resources.button;
            this.btnExit.Location = new System.Drawing.Point(271, 417);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(167, 55);
            this.btnExit.TabIndex = 3;
            this.btnExit.Text = "Выход";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // pnlLevels
            // 
            this.pnlLevels.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnlLevels.BackgroundImage")));
            this.pnlLevels.Controls.Add(this.pbxMainMenu);
            this.pnlLevels.Location = new System.Drawing.Point(1, 121);
            this.pnlLevels.Margin = new System.Windows.Forms.Padding(10);
            this.pnlLevels.Name = "pnlLevels";
            this.pnlLevels.Size = new System.Drawing.Size(481, 73);
            this.pnlLevels.TabIndex = 3;
            this.pnlLevels.Visible = false;
            // 
            // pbxMainMenu
            // 
            this.pbxMainMenu.BackColor = System.Drawing.Color.Transparent;
            this.pbxMainMenu.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pbxMainMenu.BackgroundImage")));
            this.pbxMainMenu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbxMainMenu.Location = new System.Drawing.Point(145, 425);
            this.pbxMainMenu.Name = "pbxMainMenu";
            this.pbxMainMenu.Size = new System.Drawing.Size(213, 55);
            this.pbxMainMenu.TabIndex = 0;
            this.pbxMainMenu.TabStop = false;
            this.pbxMainMenu.Click += new System.EventHandler(this.MainMenuClick);
            // 
            // pnlGame
            // 
            this.pnlGame.BackColor = System.Drawing.Color.Transparent;
            this.pnlGame.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnlGame.BackgroundImage")));
            this.pnlGame.Controls.Add(this.winScreen);
            this.pnlGame.Controls.Add(this.fullWinScreen);
            this.pnlGame.Controls.Add(this.imgPause);
            this.pnlGame.Controls.Add(this.lblLiveCount);
            this.pnlGame.Controls.Add(this.lblCarrotCount);
            this.pnlGame.Controls.Add(this.menuPause);
            this.pnlGame.Controls.Add(this.looseScreen);
            this.pnlGame.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.pnlGame.Location = new System.Drawing.Point(1, 268);
            this.pnlGame.Name = "pnlGame";
            this.pnlGame.Size = new System.Drawing.Size(484, 299);
            this.pnlGame.TabIndex = 2;
            this.pnlGame.Visible = false;
            // 
            // winScreen
            // 
            this.winScreen.BackColor = System.Drawing.Color.Transparent;
            this.winScreen.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("winScreen.BackgroundImage")));
            this.winScreen.ForeColor = System.Drawing.Color.White;
            this.winScreen.Location = new System.Drawing.Point(65, 100);
            this.winScreen.Name = "winScreen";
            this.winScreen.Size = new System.Drawing.Size(357, 426);
            this.winScreen.TabIndex = 10;
            this.winScreen.Visible = false;
            this.winScreen.ContinueClick += new System.EventHandler(this.ContinueClick);
            this.winScreen.SelectLevelClick += new System.EventHandler(this.SelectLevelClick);
            this.winScreen.MainMenuClick += new System.EventHandler(this.MainMenuClick);
            this.winScreen.RestartClick += new System.EventHandler(this.RestartClick);
            // 
            // fullWinScreen
            // 
            this.fullWinScreen.BackColor = System.Drawing.Color.Transparent;
            this.fullWinScreen.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("fullWinScreen.BackgroundImage")));
            this.fullWinScreen.Location = new System.Drawing.Point(65, 99);
            this.fullWinScreen.Name = "fullWinScreen";
            this.fullWinScreen.Size = new System.Drawing.Size(357, 381);
            this.fullWinScreen.TabIndex = 11;
            this.fullWinScreen.Visible = false;
            this.fullWinScreen.MainMenuClick += new System.EventHandler(this.MainMenuClick);
            // 
            // imgPause
            // 
            this.imgPause.Cursor = System.Windows.Forms.Cursors.Hand;
            this.imgPause.Image = ((System.Drawing.Image)(resources.GetObject("imgPause.Image")));
            this.imgPause.Location = new System.Drawing.Point(407, 29);
            this.imgPause.Name = "imgPause";
            this.imgPause.Size = new System.Drawing.Size(46, 46);
            this.imgPause.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.imgPause.TabIndex = 7;
            this.imgPause.TabStop = false;
            this.imgPause.Click += new System.EventHandler(this.imgPause_Click);
            // 
            // lblLiveCount
            // 
            this.lblLiveCount.AutoSize = true;
            this.lblLiveCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblLiveCount.ForeColor = System.Drawing.Color.White;
            this.lblLiveCount.Location = new System.Drawing.Point(74, 26);
            this.lblLiveCount.Name = "lblLiveCount";
            this.lblLiveCount.Size = new System.Drawing.Size(32, 24);
            this.lblLiveCount.TabIndex = 5;
            this.lblLiveCount.Text = "10";
            this.lblLiveCount.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblCarrotCount
            // 
            this.lblCarrotCount.AutoSize = true;
            this.lblCarrotCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblCarrotCount.ForeColor = System.Drawing.Color.White;
            this.lblCarrotCount.Location = new System.Drawing.Point(74, 73);
            this.lblCarrotCount.Name = "lblCarrotCount";
            this.lblCarrotCount.Size = new System.Drawing.Size(21, 24);
            this.lblCarrotCount.TabIndex = 4;
            this.lblCarrotCount.Text = "0";
            this.lblCarrotCount.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // menuPause
            // 
            this.menuPause.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("menuPause.BackgroundImage")));
            this.menuPause.Location = new System.Drawing.Point(124, 134);
            this.menuPause.Name = "menuPause";
            this.menuPause.Size = new System.Drawing.Size(251, 332);
            this.menuPause.TabIndex = 8;
            this.menuPause.Visible = false;
            this.menuPause.ContinueClick += new System.EventHandler(this.ContinueClick);
            this.menuPause.SelectLevelClick += new System.EventHandler(this.SelectLevelClick);
            this.menuPause.MainMenuClick += new System.EventHandler(this.MainMenuClick);
            this.menuPause.RestartClick += new System.EventHandler(this.RestartClick);
            // 
            // looseScreen
            // 
            this.looseScreen.BackColor = System.Drawing.Color.Transparent;
            this.looseScreen.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("looseScreen.BackgroundImage")));
            this.looseScreen.Location = new System.Drawing.Point(64, 100);
            this.looseScreen.Name = "looseScreen";
            this.looseScreen.Size = new System.Drawing.Size(360, 380);
            this.looseScreen.TabIndex = 9;
            this.looseScreen.Visible = false;
            this.looseScreen.RestartClick += new System.EventHandler(this.RestartClick);
            this.looseScreen.SelectLevelClick += new System.EventHandler(this.SelectLevelClick);
            this.looseScreen.MainMenuClick += new System.EventHandler(this.MainMenuClick);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 561);
            this.Controls.Add(this.pnlMain);
            this.Controls.Add(this.pnlLevels);
            this.Controls.Add(this.pnlGame);
            this.KeyPreview = true;
            this.MaximumSize = new System.Drawing.Size(500, 600);
            this.MinimumSize = new System.Drawing.Size(500, 600);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "\"Волк и зайцы\"";
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.MainForm_KeyUp);
            this.pnlMain.ResumeLayout(false);
            this.pnlLevels.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbxMainMenu)).EndInit();
            this.pnlGame.ResumeLayout(false);
            this.pnlGame.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgPause)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlMain;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Panel pnlGame;
        private System.Windows.Forms.Label lblCarrotCount;
        private System.Windows.Forms.Label lblLiveCount;
        private System.Windows.Forms.Panel pnlLevels;
        private System.Windows.Forms.PictureBox imgPause;
        private System.Windows.Forms.PictureBox pbxMainMenu;
        private System.Windows.Forms.Button btnAbout;
        private System.Windows.Forms.Button btnHowToPlay;
        private System.Windows.Forms.Button btnNewGame;
        private Controls.MenuPause menuPause;
        private Controls.LoseScreen looseScreen;
        private Controls.WinScreen winScreen;
        private Controls.FullWinScreen fullWinScreen;
        private System.Windows.Forms.Button btnContinue;
        private Controls.AboutScreen aboutScreen;
        private Controls.InstructionScreen instructionScreen;
    }
}

