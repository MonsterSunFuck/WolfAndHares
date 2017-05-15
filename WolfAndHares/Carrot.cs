namespace test_four
{
    using System.Drawing;

    public class Carrot : IGameObject
    {
        public Carrot()
        {
            Image = new Bitmap("Icons/carrot.png");
        }

        public Image Image { get; private set; }
    }
}