namespace test_four
{
    using System.Drawing;

    public class Glade : IGameObject
    {
        public Glade()
        {
            Image = new Bitmap("Icons/glade.png");
        }

        public Image Image { get; private set; }
    }
}