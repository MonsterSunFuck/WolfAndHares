namespace WolfAndHares.BL
{
    using GameObjects;
    using System;
    using System.Collections.Generic;
    using System.Drawing;
    using System.Linq;

    public class GameLogic
    {
        private List<Level> _levels;
        private readonly FromFileLevelLoader _levelLoader;
        private Level _currentLevel;
        private LevelState _levelState;
        private Point _currentWolfPosition;
        private Point _newWolfPosition;
        private bool _isPause;

        public GameLogic()
        {
            Pause();
            _levelLoader = new FromFileLevelLoader();
            _levels = _levelLoader.LoadLevels();
            _currentLevel = null;
        }

        public void NewGame()
        {
            Play();
        }

        private void InitLevelState()
        {
            _levelState = new LevelState
            {
                Level = _currentLevel,
                Lives = 10,
                Carrots = 0,
                Rabbits = 0,
                AllRabbitsCount = _currentLevel.AllRabbitsCount,
                AllCarrotsCount = _currentLevel.AllCarrotsCount
            };
        }

        public void StartLevel(int number)
        {
            if (number > 16)
            {
                number = 16;
            }
            _currentLevel = _levels[number - 1];
            _currentLevel.SetToInitialState();
            InitLevelState();

            for (var i = 0; i < _currentLevel.GameObjects.GetLength(0); i++)
            {
                for (var j = 0; j < _currentLevel.GameObjects.GetLength(1); j++)
                {
                    if (_currentLevel.GameObjects[i, j] is Wolf)
                        _currentWolfPosition = new Point(i, j);
                }
            }

            Play();
        }

        public LevelState GetLevelState()
        {
            return _levelState;
        }

        public void GoLeft()
        {
            if (_isPause)
                return;

            if (_currentWolfPosition.Y <= 0) return;

            _newWolfPosition = _currentWolfPosition;
            _newWolfPosition.Y--;
            RecalculatePositions();
        }

        public void GoRight()
        {
            if (_isPause)
                return;

            if (_currentWolfPosition.Y + 1 >= _currentLevel.GameObjects.GetLength(1)) return;

            _newWolfPosition = _currentWolfPosition;
            _newWolfPosition.Y++;
            RecalculatePositions();
        }

        private void RecalculatePositions()
        {
            if (IsWolfCannotMove())
                return;

            CalculateStats();
            MoveWolf();
            MoveRabbits();
        }

        private Wolf Wolf => _currentLevel.GameObjects[_currentWolfPosition.X, _currentWolfPosition.Y] as Wolf;

        private void MoveWolf()
        {
            _currentLevel.GameObjects[_newWolfPosition.X, _newWolfPosition.Y] = _currentLevel.GameObjects[_currentWolfPosition.X, _currentWolfPosition.Y];
            _currentLevel.GameObjects[_currentWolfPosition.X, _currentWolfPosition.Y] = new Glade();
            _currentWolfPosition = _newWolfPosition;
            if (_levelState.Carrots > 0)
            {
                Wolf.GiveCarrot();
            }
            else
            {
                Wolf.PickUpCarrot();
            }
        }

        private bool IsWolfCannotMove()
        {
            return _levelState.Lives < 1 || _levelState.Rabbits == _currentLevel.AllRabbitsCount ||
                   _currentLevel.GameObjects[_newWolfPosition.X, _newWolfPosition.Y] is Stump;
        }

        private void CalculateStats()
        {
            if (IsGameObjectOnTheWay<Carrot>())
                _levelState.Carrots++;
            if (IsGameObjectOnTheWay<Hare>())
            {
                _levelState.Rabbits++;
                _levelState.Lives += 10;
                _levelState.Carrots--;
            }
            if (IsGameObjectOnTheWay<Trap>())
            {
                _levelState.Lives--;
            }

            _levelState.Lives--;
        }

        private bool IsGameObjectOnTheWay<T>()
        {
            return _currentLevel.GameObjects[_newWolfPosition.X, _newWolfPosition.Y].GetType() == typeof(T);
        }

        private void MoveRabbits()
        {
            if (_levelState.Carrots > 0)
                return;
            Point rabbitPosition;
            if (IsRabbinOnUp(out rabbitPosition))
            {
                JumpRabbit(rabbitPosition);
            }

            if (IsRabbinOnRight(out rabbitPosition))
            {
                JumpRabbit(rabbitPosition);
            }

            if (IsRabbinOnDown(out rabbitPosition))
            {
                JumpRabbit(rabbitPosition);
            }

            if (IsRabbinOnLeft(out rabbitPosition))
            {
                JumpRabbit(rabbitPosition);
            }
        }

        private bool IsRabbinOnUp(out Point rabbitPosition)
        {
            rabbitPosition = new Point(_currentWolfPosition.X - 1, _currentWolfPosition.Y);
            return CheckRabbit(rabbitPosition);
        }

        private bool IsRabbinOnRight(out Point rabbitPosition)
        {
            rabbitPosition = new Point(_currentWolfPosition.X, _currentWolfPosition.Y + 1);
            return CheckRabbit(rabbitPosition);
        }

        private bool IsRabbinOnDown(out Point rabbitPosition)
        {
            rabbitPosition = new Point(_currentWolfPosition.X + 1, _currentWolfPosition.Y);
            return CheckRabbit(rabbitPosition);
        }

        private bool IsRabbinOnLeft(out Point rabbitPosition)
        {
            rabbitPosition = new Point(_currentWolfPosition.X, _currentWolfPosition.Y - 1);
            return CheckRabbit(rabbitPosition);
        }

        private bool CheckRabbit(Point rabbitPosition)
        {
            return IsInArea(rabbitPosition) && _currentLevel.GameObjects[rabbitPosition.X, rabbitPosition.Y] is Hare;
        }

        private bool IsInArea(Point point)
        {
            return point.X >= 0 && point.Y >= 0 && point.X < _currentLevel.GameObjects.GetLength(0) &&
                   point.Y < _currentLevel.GameObjects.GetLength(1);
        }

        private void JumpRabbit(Point rabbitPostion)
        {
            var availableJumps = GetAvailableJumps(rabbitPostion);
            if (availableJumps.Count == 0)
                return;

            var rnd = new Random();
            var position = rnd.Next(0, availableJumps.Count);
            var newRabbitPostion = availableJumps[position];

            _currentLevel.GameObjects[newRabbitPostion.X, newRabbitPostion.Y] = _currentLevel.GameObjects[rabbitPostion.X, rabbitPostion.Y];
            _currentLevel.GameObjects[rabbitPostion.X, rabbitPostion.Y] = new Glade();
        }

        private List<Point> GetAvailableJumps(Point rabbitPostion)
        {
            return new List<Point>
            {
                new Point(rabbitPostion.X + 1, rabbitPostion.Y),
                new Point(rabbitPostion.X - 1, rabbitPostion.Y),
                new Point(rabbitPostion.X, rabbitPostion.Y + 1),
                new Point(rabbitPostion.X, rabbitPostion.Y - 1)
            }.Where(point => IsInArea(point) && _currentLevel.GameObjects[point.X, point.Y] is Glade).ToList();
        }

        public void GoUp()
        {
            if (_isPause)
                return;

            if (_currentWolfPosition.X <= 0) return;

            _newWolfPosition = _currentWolfPosition;
            _newWolfPosition.X--;
            RecalculatePositions();
        }

        public void GoDown()
        {
            if (_isPause)
                return;

            if (_currentWolfPosition.X + 1 >= _currentLevel.GameObjects.GetLength(0)) return;

            _newWolfPosition = _currentWolfPosition;
            _newWolfPosition.X++;
            RecalculatePositions();
        }

        public void SaveGame()
        {
            if (GetLevelState().IsWin())
                _levelLoader.SaveLevelState(new SavedLevelState()
                {
                    LevelNumber = GetCurrentLevelNumber(),
                    Points = GetLevelState().GetPoints()
                });
        }

        public List<Level> GetLevels()
        {
            return _levels;
        }

        public void Pause()
        {
            _isPause = true;
        }

        public void Play()
        {
            _isPause = false;
        }

        public void Restart()
        {
            StartLevel(GetCurrentLevelNumber());
        }

        public int GetCurrentLevelNumber()
        {
            return _levels.IndexOf(_currentLevel) + 1;
        }

        public bool IsAllLevelsWin()
        {
            return _levels.Count <= GetCurrentLevelNumber();
        }

        public int GetAllPoints()
        {
            return _levelLoader.GetSavedSate().SavedLevelStates.Sum(x => x.Points) + GetLevelState().GetPoints();
        }

        public SavedState GetSavedState()
        {
            return _levelLoader.GetSavedSate();
        }

        public void DeleteSave()
        {
            _levelLoader.DeleteSave();
        }

        public bool LoadGame()
        {
            _levels = _levelLoader.LoadLevels();
            var savedState = GetSavedState();
            if (savedState == null)
                return false;
            var levelNumber = savedState.SavedLevelStates.Max(x => x.LevelNumber);
            StartLevel(levelNumber);
            return true;
        }
    }
}