﻿namespace WolfAndHares.BL
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
                Hares = 0,
                AllHaresCount = _currentLevel.AllHaresCount,
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
            MoveHares();
            MoveFox();
        }

        private Wolf Wolf => _currentLevel.GameObjects[_currentWolfPosition.X, _currentWolfPosition.Y] as Wolf;

        private void MoveWolf()
        {
            _currentLevel.GameObjects[_newWolfPosition.X, _newWolfPosition.Y] = Wolf;
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
            return _levelState.Lives < 1 || _levelState.Hares == _currentLevel.AllHaresCount ||
                   _currentLevel.GameObjects[_newWolfPosition.X, _newWolfPosition.Y] is Stump;
        }

        private void CalculateStats()
        {
            if (IsGameObjectOnTheWay<Carrot>())
                _levelState.Carrots++;
            if (IsGameObjectOnTheWay<Hare>())
            {
                _levelState.Hares++;
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

        private void MoveHares()
        {
            if (_levelState.Carrots > 0)
                return;
            Point harePosition;
            if (IsHareOnUp(out harePosition))
            {
                JumpHare(harePosition);
            }

            if (IsHareOnRight(out harePosition))
            {
                JumpHare(harePosition);
            }

            if (IsHareOnDown(out harePosition))
            {
                JumpHare(harePosition);
            }

            if (IsHareOnLeft(out harePosition))
            {
                JumpHare(harePosition);
            }
        }

        private bool IsHareOnUp(out Point harePosition)
        {
            harePosition = new Point(_currentWolfPosition.X - 1, _currentWolfPosition.Y);
            return CheckHare(harePosition);
        }

        private bool IsHareOnRight(out Point harePosition)
        {
            harePosition = new Point(_currentWolfPosition.X, _currentWolfPosition.Y + 1);
            return CheckHare(harePosition);
        }

        private bool IsHareOnDown(out Point harePosition)
        {
            harePosition = new Point(_currentWolfPosition.X + 1, _currentWolfPosition.Y);
            return CheckHare(harePosition);
        }

        private bool IsHareOnLeft(out Point harePosition)
        {
            harePosition = new Point(_currentWolfPosition.X, _currentWolfPosition.Y - 1);
            return CheckHare(harePosition);
        }

        private bool CheckHare(Point harePosition)
        {
            return IsInArea(harePosition) && _currentLevel.GameObjects[harePosition.X, harePosition.Y] is Hare;
        }

        private bool IsInArea(Point point)
        {
            return point.X >= 0 && point.Y >= 0 && point.X < _currentLevel.GameObjects.GetLength(0) &&
                   point.Y < _currentLevel.GameObjects.GetLength(1);
        }

        private void JumpHare(Point harePostion)
        {
            var availableJumps = GetAvailableJumps(harePostion);
            if (availableJumps.Count == 0)
                return;

            var rnd = new Random();
            var position = rnd.Next(0, availableJumps.Count);
            var newHarePostion = availableJumps[position];

            _currentLevel.GameObjects[newHarePostion.X, newHarePostion.Y] = _currentLevel.GameObjects[harePostion.X, harePostion.Y];
            _currentLevel.GameObjects[harePostion.X, harePostion.Y] = new Glade();
        }

        private List<Point> GetAvailableJumps(Point harePostion)
        {
            return new List<Point>
            {
                new Point(harePostion.X + 1, harePostion.Y),
                new Point(harePostion.X - 1, harePostion.Y),
                new Point(harePostion.X, harePostion.Y + 1),
                new Point(harePostion.X, harePostion.Y - 1)
            }.Where(point => IsInArea(point) && _currentLevel.GameObjects[point.X, point.Y] is Glade).ToList();
        }

        private void MoveFox()
        {

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