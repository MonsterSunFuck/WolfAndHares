namespace WolfAndHares.BL
{
    public interface ILevelState
    {
        int Lives { get; set; }
        int GetPoints();
        ILevel Level { get; set; }
        int AllCarrotsCount { get; set; }
        int AllRabbitsCount { get; set; }
        int Carrots { get; set; }
        int Rabbits { get; set; }
        bool IsWin();
        bool IsLoose();
    }
}