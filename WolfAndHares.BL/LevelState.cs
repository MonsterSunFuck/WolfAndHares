namespace WolfAndHares.BL
{
    public class LevelState : ILevelState
    {
        public int Lives { get; set; }
        public int GetPoints() => Lives * 100 + Carrots * 40;
        public ILevel Level { get; set; }
        public int AllCarrotsCount { get; set; }
        public int AllRabbitsCount { get; set; }
        public int Carrots { get; set; }
        public int Rabbits { get; set; }
        public bool IsWin()
        {
            return Rabbits == AllRabbitsCount;
        }

        public bool IsLoose() => Lives < 1;
    }
}