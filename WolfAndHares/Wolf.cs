namespace test_four
{
    using System.Drawing;

    public class Wolf : IGameObject
    {
        public Wolf()
        {
            Image = new Bitmap("Icons/wolf.png");
        }
        public Image Image { get; private set; }
    }
}