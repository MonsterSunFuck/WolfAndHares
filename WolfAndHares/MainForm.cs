namespace WolfAndHares
{
    using BL;
    using System;
    using System.Collections.Generic;
    using System.Drawing;
    using System.Drawing.Text;
    using System.Linq;
    using System.Windows.Forms;

    public partial class MainForm : Form
    {
        private readonly GameLogic _gameLogic;
        private readonly PictureBox[,] _gameCells;
        private readonly List<Button> _levelButtons;
        private Font _hangyaboly;

        private Font Hangyaboly
        {
            get
            {
                if (_hangyaboly != null) return _hangyaboly;

                var privateFonts = new PrivateFontCollection();
                privateFonts.AddFontFile("Content/fonts/runesandfonts_hangyaboly/Hangyaboly.ttf");
                _hangyaboly = new Font(privateFonts.Families[0], 18, FontStyle.Bold);

                return _hangyaboly;
            }
        }

        public MainForm()
        {
            InitializeComponent();
            InitFonts();

            pnlMain.Dock = DockStyle.Fill;
            pnlLevels.Dock = DockStyle.Fill;
            _gameCells = new PictureBox[4, 5];
            _levelButtons = new List<Button>();
            _gameLogic = new GameLogic();
            InitGameCells();
            if (_gameLogic.GetSavedState().SavedLevelStates.Any() && _gameLogic.LoadGame())
                btnContinue.Visible = true;
            InitLevelsPanel(_gameLogic.GetLevels());
        }

        private void InitFonts()
        {
            lblLiveCount.Font =
                lblCarrotCount.Font =
                    btnExit.Font = btnAbout.Font = btnHowToPlay.Font = btnNewGame.Font = btnContinue.Font = Hangyaboly;
            btnExit.FlatAppearance.MouseOverBackColor =
                btnAbout.FlatAppearance.MouseOverBackColor =
                    btnHowToPlay.FlatAppearance.MouseOverBackColor =
                        btnNewGame.FlatAppearance.MouseOverBackColor =
                            btnContinue.FlatAppearance.MouseOverBackColor = Color.Transparent;

            menuPause.SetFont(Hangyaboly);
            winScreen.SetFont(Hangyaboly);
            looseScreen.SetFont(Hangyaboly);
            fullWinScreen.SetFont(Hangyaboly);
        }

        private void InitGameCells()
        {
            for (var i = 0; i < _gameCells.GetLength(0); i++)
            {
                for (var j = 0; j < _gameCells.GetLength(1); j++)
                {
                    var gameCell = new PictureBox
                    {
                        Size = new Size(64, 64),
                        Location = new Point(124 + 62 * i, 144 + 62 * j),
                        SizeMode = PictureBoxSizeMode.CenterImage,
                    };

                    _gameCells[i, j] = gameCell;

                    pnlGame.Controls.Add(_gameCells[i, j]);
                }
            }
        }

        private void btnNewGame_Click(object sender, EventArgs e)
        {
            pnlMain.Visible = false;
            _gameLogic.NewGame();
            _gameLogic.DeleteSave();
            btnContinue.Visible = false;
            pnlLevels.Visible = true;
            foreach (var levelButton in _levelButtons)
            {
                levelButton.Enabled = false;
            }
            _levelButtons[0].Enabled = true;
        }

        private void InitLevelsPanel(IReadOnlyCollection<Level> levels)
        {
            if (_levelButtons.Any())
                return;

            var savedState = _gameLogic.GetSavedState();
            var backgroundImage = new Bitmap("Content/levels/button.png");

            var x = 4;
            var y = levels.Count / x;
            var countLevel = 1;
            for (var i = 1; i <= y; i++)
            {
                for (var j = 1; j <= x; j++)
                {
                    var levelButton = new Button
                    {
                        Text = countLevel.ToString(),
                        Size = new Size(64, 64),
                        Font = Hangyaboly,
                        FlatStyle = FlatStyle.Flat,
                        FlatAppearance =
                        {
                            BorderSize = 0,
                            MouseDownBackColor = Color.Transparent,
                            MouseOverBackColor = Color.Transparent
                        },
                        Cursor = Cursors.Hand,
                        Location = new Point(j * 72 + 32, i * 72 + 54),
                        ForeColor = Color.White,
                        BackColor = Color.Transparent,
                        UseVisualStyleBackColor = false,
                        BackgroundImage = backgroundImage,
                        Enabled =
                            countLevel <= _gameLogic.GetCurrentLevelNumber() ||
                            countLevel < savedState.SavedLevelStates.Count
                    };

                    var levelCount = countLevel;
                    levelButton.Click += (sender, args) =>
                    {
                        _gameLogic.StartLevel(levelCount);
                        RenderGameLevelState(_gameLogic.GetLevelState());
                        ResumeGame();
                    };

                    _levelButtons.Add(levelButton);
                    pnlLevels.Controls.Add(levelButton);

                    countLevel++;
                }
            }

            _gameLogic.StartLevel(_gameLogic.GetCurrentLevelNumber() + 1);
        }

        private void RenderGameLevelState(LevelState levelState)
        {
            pnlMain.Visible = pnlLevels.Visible = false;

            lblLiveCount.Text = levelState.Lives.ToString();
            lblCarrotCount.Text = levelState.Carrots.ToString();

            for (var i = 0; i < levelState.Level.GameObjects.GetLength(0); i++)
            {
                for (var j = 0; j < levelState.Level.GameObjects.GetLength(1); j++)
                {
                    var gameObject = levelState.Level.GameObjects[i, j];
                    _gameCells[j, i].Image = gameObject.Image;
                }
            }

            pnlGame.Dock = DockStyle.Fill;
            pnlGame.Visible = true;

            if (levelState.IsLoose())
                RenderLooseScreen();
            else if (levelState.IsWin())
                RenderWinScreen();
        }

        private void RenderLooseScreen()
        {
            looseScreen.Show();
            menuPause.Hide();
            imgPause.Enabled = false;
        }

        private void RenderWinScreen()
        {
            _gameLogic.SaveGame();
            imgPause.Enabled = false;
            if (_gameLogic.IsAllLevelsWin())
            {
                winScreen.Hide();
                fullWinScreen.Show(_gameLogic.GetAllPoints());
            }
            else
            {
                var levelState = _gameLogic.GetLevelState();

                if (levelState != null && levelState.IsWin())
                {
                    _levelButtons[_gameLogic.GetCurrentLevelNumber()].Enabled = true;
                }

                winScreen.Show(_gameLogic.GetLevelState().GetPoints());
                fullWinScreen.Hide();
            }
        }

        private void btnHowToPlay_Click(object sender, EventArgs e)
        {
            instructionScreen.Show();
        }

        private void btnAbout_Click(object sender, EventArgs e)
        {
            aboutScreen.Show();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void MainForm_KeyUp(object sender, KeyEventArgs e)
        {
            if (_gameLogic.GetLevelState() == null || !new[] { Keys.Left, Keys.Right, Keys.Up, Keys.Down }.Contains(e.KeyCode))
                return;

            switch (e.KeyCode)
            {
                case Keys.Left:
                    _gameLogic.GoLeft();
                    break;
                case Keys.Right:
                    _gameLogic.GoRight();
                    break;
                case Keys.Up:
                    _gameLogic.GoUp();
                    break;
                case Keys.Down:
                    _gameLogic.GoDown();
                    break;
            }

            RenderGameLevelState(_gameLogic.GetLevelState());
        }

        private void PauseGame()
        {
            menuPause.Show();
            imgPause.Enabled = false;
            _gameLogic.Pause();
        }

        private void ResumeGame()
        {
            menuPause.Hide();
            looseScreen.Hide();
            winScreen.Hide();
            imgPause.Enabled = true;
            _gameLogic.Play();
            RenderGameLevelState(_gameLogic.GetLevelState());
        }

        private void SelectLevel()
        {
            menuPause.Hide();
            winScreen.Hide();
            btnContinue.Visible = true;
            pnlGame.Visible = pnlMain.Visible = false;
            for (var i = 0; i < _levelButtons.Count && i < _gameLogic.GetCurrentLevelNumber(); i++)
            {
                _levelButtons[i].Enabled = true;
            }
            pnlLevels.Visible = true;
        }

        private void MainMenuClick(object sender, EventArgs e)
        {
            menuPause.Hide();
            winScreen.Hide();
            fullWinScreen.Hide();
            pnlGame.Visible = pnlLevels.Visible = false;
            pnlMain.Visible = true;
            if (_gameLogic.GetSavedState().SavedLevelStates.Any())
                btnContinue.Visible = true;
        }

        private void imgPause_Click(object sender, EventArgs e)
        {
            if (menuPause.Visible)
            {
                ResumeGame();
            }
            else
            {
                PauseGame();
            }
        }

        private void SelectLevelClick(object sender, EventArgs e)
        {
            SelectLevel();
        }

        private void ContinueClick(object sender, EventArgs e)
        {
            var levelState = _gameLogic.GetLevelState();

            if (levelState != null && levelState.IsWin())
            {
                _gameLogic.StartLevel(_gameLogic.GetCurrentLevelNumber() + 1);
            }

            ResumeGame();
        }

        private void RestartClick(object sender, EventArgs e)
        {
            _gameLogic.Restart();
            ResumeGame();
        }
    }
}
