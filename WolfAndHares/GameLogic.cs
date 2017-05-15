namespace test_four
{
    using System;
    using System.Collections.Generic;
    using System.Drawing;
    using System.Linq;

    public class GameLogic : IGameLogic
    {
        private List<ILevel> _levels;
        private readonly ILevelLoader _levelLoader;
        private ILevel _currentLevel;
        private ILevelState _levelState;
        private Point _currentWolfPosition;
        private Point _newWolfPosition;

        public GameLogic()
        {
            _levels = new List<ILevel>();
            _levelLoader = new FromFileLevelLoader();
        }

        public void NewGame()
        {
            _levels = _levelLoader.LoadLevels();
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
            _currentLevel = _levels[number - 1];
            InitLevelState();

            for (var i = 0; i < _currentLevel.GameObjects.GetLength(0); i++)
            {
                for (var j = 0; j < _currentLevel.GameObjects.GetLength(1); j++)
                {
                    if (_currentLevel.GameObjects[i, j] is Wolf)
                        _currentWolfPosition = new Point(i, j);
                }
            }
        }

        public ILevelState GetLevelState()
        {
            return _levelState;
        }

        public void GoLeft()
        {
            if (_currentWolfPosition.Y <= 0) return;

            _newWolfPosition = _currentWolfPosition;
            _newWolfPosition.Y--;
            RecalculatePositions();
        }

        public void GoRight()
        {
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

        private void MoveWolf()
        {
            _currentLevel.GameObjects[_newWolfPosition.X, _newWolfPosition.Y] = _currentLevel.GameObjects[_currentWolfPosition.X, _currentWolfPosition.Y];
            _currentLevel.GameObjects[_currentWolfPosition.X, _currentWolfPosition.Y] = new Glade();
            _currentWolfPosition = _newWolfPosition;
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
            if (IsGameObjectOnTheWay<Rabbit>())
            {
                _levelState.Rabbits++;
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
            return IsInArea(rabbitPosition) && _currentLevel.GameObjects[rabbitPosition.X, rabbitPosition.Y] is Rabbit;
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
            if (_currentWolfPosition.X <= 0) return;

            _newWolfPosition = _currentWolfPosition;
            _newWolfPosition.X--;
            RecalculatePositions();
        }

        public void GoDown()
        {
            if (_currentWolfPosition.X + 1 >= _currentLevel.GameObjects.GetLength(0)) return;

            _newWolfPosition = _currentWolfPosition;
            _newWolfPosition.X++;
            RecalculatePositions();
        }

        public void SaveGame()
        {
            throw new NotImplementedException();
        }

        public void LoadGame()
        {
            throw new NotImplementedException();
        }

        public List<ILevel> GetLevels()
        {
            return _levels;
        }
    }
}