namespace test_four
{
    using System.Drawing;

    public class Trap : IGameObject
    {
        public Trap()
        {
            Image = new Bitmap("Icons/trap.png");
        }

        public Image Image { get; private set; }
    }
}