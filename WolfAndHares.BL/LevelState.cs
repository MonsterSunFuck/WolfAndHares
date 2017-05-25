namespace WolfAndHares.BL
{
    public class LevelState
    {
        public int Lives { get; set; }
        public bool WolfIsLose { get; set; }
        public int GetPoints() => Lives * 100 + Carrots * 40;
        public Level Level { get; set; }
        public int AllCarrotsCount { get; set; }
        public int AllHaresCount { get; set; }
        public int Carrots { get; set; }
        public int Hares { get; set; }
        public bool IsWin()
        {
            return Hares == AllHaresCount;
        }

        public bool IsLoose() => Lives < 1 || WolfIsLose;
    }
}