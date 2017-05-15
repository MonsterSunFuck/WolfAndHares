namespace test_four
{
    using System.Drawing;

    public class Stump : IGameObject
    {
        public Stump()
        {
            Image = new Bitmap("Icons/stump.png");
        }

        public Image Image { get; }
    }
}